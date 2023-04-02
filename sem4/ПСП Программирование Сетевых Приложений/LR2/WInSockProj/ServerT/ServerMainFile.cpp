#include <iostream>
#include <clocale>
#include <ctime>

#include "ErrorMsgText.h"
#include "Winsock2.h"                
#pragma comment(lib, "WS2_32.lib")   

int main()
{
    setlocale(LC_ALL, "rus");

    WSADATA wsaData;                                                              // ���������, �������� �������� � ���������� ������� Windows

    SOCKET  sS;                                                                   // ����� �������
    SOCKADDR_IN serv;                                                             // ��������� ��� �������� ���������� ������ sS
    serv.sin_family = AF_INET;                                                    // ��� ������������� ������ (AF_INET = ��������� IP)
    serv.sin_port = htons(2000);                                                  // ����� �����
    serv.sin_addr.s_addr = INADDR_ANY;                                            // ����� ����������� IP �����

    try {
        std::cout << "ServerT\n\n";

                                                                                 // ������������� ���������� WS2_32.lib; ���������: ������ Windows Sockets, ��������� �� WSADATA
        if (WSAStartup(MAKEWORD(2, 0), &wsaData) != 0) {
            throw  SetErrorMsgText("Startup: ", WSAGetLastError());
        }

                                                                                 // �������� ������ �������; SOCK_STREAM - ��� ������ (��������������� �� �����, ��������������� ����������); NULL - ��������, ������������ ��������, ��� TCP/IP ����� �������� NULL
        if ((sS = socket(AF_INET, SOCK_STREAM, NULL)) == INVALID_SOCKET) {
            throw  SetErrorMsgText("socket: ", WSAGetLastError());
        }
                                                                                 // ���������� ������ � ����������� (�����, ��������� �� ��� ���������, ����� ���������� � ������)
        if (bind(sS, (LPSOCKADDR)&serv, sizeof(serv)) == SOCKET_ERROR) {
            throw  SetErrorMsgText("bind: ", WSAGetLastError());
        }

                                                                                 // ������� ������ � ��������� �������������, ��������� ������ � ���� (��������� �����, ������������ ����� �������)
        if (listen(sS, SOMAXCONN) == SOCKET_ERROR) {
            throw SetErrorMsgText("listen: ", WSAGetLastError());
        }

        SOCKET cS;                                                                  // ����� �������
        SOCKADDR_IN clnt;                                                           // ��������� ������ �������
        memset(&clnt, 0, sizeof(clnt));                                             // ������� ���������� ������ �������
        int lclnt = sizeof(clnt);

        clock_t start, end;                                                         // ����� ������ � ����� ������ ������� � ��������
        char ibuf[50],                                                              // ����� �����
            obuf[50] = "server: ������� ";                                          // ����� ������
        int libuf = 0,                                                              // ���������� �������� ����
            lobuf = 0;                                                              // ���������� ������������ ����
        bool flag = true;

        while (true) {
                                                                                    // ��������� ���������� � �������� (��������� ��������, ���� ������ �� �������� connect(...); ���� ��� ���������, ������� ���������� ����� �����
            if ((cS = accept(sS, (sockaddr*)&clnt, &lclnt)) == INVALID_SOCKET) {
                throw SetErrorMsgText("accept: ", WSAGetLastError());
            }
            else {
                std::cout << "\n---- NEW CLIENT ACCEPTED ----\n\n";
            }

            while (true) {

                                                          // ���������� ������ ������� (����� �������, ����� ������, ���-�� ���� ������ � ������, ���� (����� ��������� ����� ���������� ������))
                if ((libuf = recv(cS, ibuf, sizeof(ibuf), NULL)) == SOCKET_ERROR) {
                    if (WSAGetLastError() == WSAECONNRESET) {
                        end = clock();
                        flag = true;
                        std::cout << "\n---- CLIENT CONNECTION WAS RESET after " << ((double)(end - start) / CLK_TCK) << " seconds of recv/send excange ----\n";
                        break;
                    }
                    else throw SetErrorMsgText("recv: ", WSAGetLastError());
                }
                else {
                    if (flag) {
                        start = clock();
                        flag = !flag;
                    }
                }

                std::string obuf = ibuf;
                if ((lobuf = send(cS, obuf.c_str(), strlen(obuf.c_str()) + 1, NULL)) == SOCKET_ERROR) {
                    throw SetErrorMsgText("send: ", WSAGetLastError());
                }

                if (strcmp(ibuf, "") == 0) {
                    flag = true;
                    end = clock();
                    std::cout << "Full time of recv/send exchange: " << ((double)(end - start) / CLK_TCK) << " c\n\n";
                    break;
                }
                else {
                    std::cout << ibuf << std::endl;
                }
            }
        }

        if (closesocket(cS) == SOCKET_ERROR) {
            throw  SetErrorMsgText("closesocket: ", WSAGetLastError());
        }
        if (closesocket(sS) == SOCKET_ERROR) {
            throw  SetErrorMsgText("closesocket: ", WSAGetLastError());
        }
        if (WSACleanup() == SOCKET_ERROR) {
            throw  SetErrorMsgText("Cleanup: ", WSAGetLastError());
        }
    }
    catch (std::string errorMsgText) {
        WSACleanup();
        std::cout << '\n' << errorMsgText;
    }

    system("pause");
    return 0;
}