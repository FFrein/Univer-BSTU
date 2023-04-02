#include "Winsock2.h"
#pragma comment(lib, "WS2_32.lib")
#pragma warning(disable:4996)
#include <string>
#include <iostream>
#include <tchar.h>

SOCKET startSocket;
WSADATA info;
SOCKADDR_IN serv;

std::string GetErrorMsgText(int code);
std::string SetErrorMsgText(std::string msgText, int code);

using namespace std;

int main(int argc, _TCHAR* argv[])
{
    SOCKET  cC;
    WSADATA wsaData;
    try
    {
        if (WSAStartup(MAKEWORD(2, 0), &wsaData) != 0)
            throw  SetErrorMsgText("Startup:", WSAGetLastError());


        if ((cC = socket(AF_INET, SOCK_STREAM, NULL)) == INVALID_SOCKET)
            throw  SetErrorMsgText("Socket:", WSAGetLastError());

        SOCKADDR_IN serv;
        serv.sin_family = AF_INET;
        serv.sin_port = htons(2000);

        serv.sin_addr.s_addr = inet_addr("192.168.22.235");  // адрес сервера
        // serv.sin_addr.s_addr = inet_addr("192.168.43.99");  // адрес сервера


        if ((connect(cC, (sockaddr*)&serv, sizeof(serv))) == SOCKET_ERROR)
            throw  SetErrorMsgText("Connect:", WSAGetLastError());


        char ibuf[50];                     //буфер ввода 
        char obuf[50];                       //буфер вывода
        int  libuf = 0;                     //количество принятых байт
        int lobuf = 0;                     //количество отправленных байт
        int count = 0;                      //количество иттераций

        cout << "Enter a number of itterations: ", cin >> count;

        char num[10],
            in[50];
        int t = clock();
        do
        {
            char out[50] = "Hello from Client ";
            _itoa_s(count, num, 10);
            strcat_s(out, num);
            if ((lobuf = send(cC, out, strlen(out) + 1, NULL)) == SOCKET_ERROR)
                throw  SetErrorMsgText("send:", WSAGetLastError());

            if ((libuf = recv(cC, in, sizeof(in), NULL)) == SOCKET_ERROR)
                throw  SetErrorMsgText("recv:", WSAGetLastError());


        } while (--count);

        cout << "Ticks: " << clock() - t << endl;
        string t55;
        cin >> t55;

        if ((lobuf = send(cC, "", 1, NULL)) == SOCKET_ERROR)
            throw  SetErrorMsgText("Send:", WSAGetLastError());


        if (closesocket(cC) == SOCKET_ERROR)
            throw  SetErrorMsgText("Closesocket:", WSAGetLastError());

        if (WSACleanup() == SOCKET_ERROR)
            throw  SetErrorMsgText("Cleanup:", WSAGetLastError());

    }
    catch (string errorMsgText)
    {
        cout << endl << errorMsgText;
    }
    return 0;
}
string GetErrorMsgText(int code)
{
    std::string msgText;
    switch (code)
    {
    case WSAEINTR: msgText = "WSAEINTR"; break;
    case WSAEACCES: msgText = "WSAEACCES"; break;
    case WSAEFAULT:msgText = "WSAEFAULT"; break;
    case WSAEINVAL: msgText = "WSAEINVAL"; break;
    case WSAEMFILE: msgText = "WSAEMFILE"; break;
    case WSAEWOULDBLOCK: msgText = "WSAEWOULDBLOCK"; break;
    case WSAEINPROGRESS: msgText = "WSAEINPROGRESS"; break;
    case WSAEALREADY: msgText = "WSAEALREADY"; break;
    case WSAENOTSOCK: msgText = "WSAENOTSOCK"; break;
    case WSAEDESTADDRREQ: msgText = "WSAEDESTADDRREQ"; break;
    case WSAEMSGSIZE: msgText = "WSAEMSGSIZE"; break;
    case WSAEPROTOTYPE: msgText = "WSAEPROTOTYPE"; break;
    case WSAENOPROTOOPT: msgText = "WSAENOPROTOOPT"; break;
    case WSAEPROTONOSUPPORT: msgText = "WSAEPROTONOSUPPORT"; break;
    case WSAESOCKTNOSUPPORT: msgText = "WSAESOCKTNOSUPPORT"; break;
    case WSAEOPNOTSUPP: msgText = "WSAEOPNOTSUPP"; break;
    case WSAEPFNOSUPPORT: msgText = "WSAEPFNOSUPPORT"; break;
    case WSAEAFNOSUPPORT: msgText = "WSAEAFNOSUPPORT"; break;
    case WSAEADDRINUSE: msgText = "WSAEADDRINUSE"; break;
    case WSAEADDRNOTAVAIL: msgText = "WSAEADDRNOTAVAIL"; break;
    case WSAENETDOWN: msgText = "WSAENETDOWN"; break;
    case WSAENETUNREACH: msgText = "WSAENETUNREACH"; break;
    case WSAENETRESET: msgText = "WSAENETRESET"; break;
    case WSAECONNABORTED: msgText = "WSAECONNABORTED"; break;
    case WSAECONNRESET: msgText = "WSAECONNRESET"; break;
    case WSAENOBUFS: msgText = "WSAENOBUFS"; break;
    case WSAEISCONN: msgText = "WSAEISCONN"; break;
    case WSAENOTCONN: msgText = "WSAENOTCONN"; break;
    case WSAESHUTDOWN: msgText = "WSAESHUTDOWN"; break;
    case WSAETIMEDOUT: msgText = "WSAETIMEDOUT"; break;
    case WSAECONNREFUSED: msgText = "WSAECONNREFUSED"; break;
    case WSAEHOSTDOWN: msgText = "WSAEHOSTDOWN"; break;
    case WSAEHOSTUNREACH: msgText = "WSAEHOSTUNREACH"; break;
    case WSAEPROCLIM: msgText = "WSAEPROCLIM"; break;
    case WSASYSNOTREADY: msgText = "WSASYSNOTREADY"; break;
    case WSAVERNOTSUPPORTED: msgText = "WSAVERNOTSUPPORTED"; break;
    case WSANOTINITIALISED: msgText = "WSANOTINITIALISED"; break;
    case WSAEDISCON: msgText = "WSAEDISCON"; break;
    case WSATYPE_NOT_FOUND: msgText = "WSATYPE_NOT_FOUND"; break;
    case WSAHOST_NOT_FOUND: msgText = "WSAHOST_NOT_FOUND"; break;
    case WSATRY_AGAIN: msgText = "WSATRY_AGAIN"; break;
    case WSANO_RECOVERY: msgText = "WSANO_RECOVERY"; break;
    case WSANO_DATA: msgText = "WSANO_DATA"; break;
    case WSA_INVALID_HANDLE: msgText = "WSA_INVALID_HANDLE"; break;
    case WSA_INVALID_PARAMETER: msgText = "WSA_INVALID_PARAMETER"; break;
    case WSA_IO_INCOMPLETE: msgText = "WSA_IO_INCOMPLETE"; break;
    case WSA_IO_PENDING: msgText = "WSA_IO_PENDING"; break;
    case WSA_NOT_ENOUGH_MEMORY: msgText = "WSA_NOT_ENOUGH_MEMORY"; break;
    case WSA_OPERATION_ABORTED: msgText = "WSA_OPERATION_ABORTED"; break;
    case WSASYSCALLFAILURE: msgText = "WSASYSCALLFAILURE"; break;
    default: msgText = "***ERROR***"; break;
    };
    return msgText;
};

std::string SetErrorMsgText(std::string msgText, int code)
{
    return msgText + GetErrorMsgText(code);
};