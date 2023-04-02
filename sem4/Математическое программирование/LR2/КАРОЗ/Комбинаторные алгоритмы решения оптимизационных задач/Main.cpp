#pragma once
#include "stdafx.h"

/*
������� 1.  ��������� � ����������� ��������� ����������� ��������� ���������.
������� 2.  ��������� � ����������� ��������� ���������.
������� 3.  ��������� � ����������� ��������� ������������.
������� 4.  ��������� � ����������� ��������� ����������.

������� 5.  ������  � ������������ � ��������� ������ � ��������� ������� � ����� (������� �������������� �� ������):
������������ (���������� ������������� ��������� �������: 
10 �������, ���������� 10 � 300 ��, 3 ���������� ����� �������� ������ ������������);

������� 6. ����������� ����������� ������� ���������� ����������� ��� ������� ������ (� ������������ � ���������) �� ����������� ������ � ��������� � ���� ������� � ��������� ���������� ������� � �����:
������������ (6 � 12 �������);

*/

int TASK1() {
    //1.	���������  ����������� ��������� ���������
    setlocale(LC_ALL, "rus");
    char  AA[][2] = { "A", "B", "C", "D" };
    std::cout << std::endl << " - ��������� ��������� ���� ����������� -";
    std::cout << std::endl << "�������� ���������: ";
    std::cout << "{ ";
    for (int i = 0; i < sizeof(AA) / 2; i++)
        std::cout << AA[i] << ((i < sizeof(AA) / 2 - 1) ? ", " : " ");
    std::cout << "}";
    std::cout << std::endl << "��������� ���� �����������  ";
    combi::subset s1(sizeof(AA) / 2);         // �������� ����������   
    int  n = s1.getfirst();                // ������ (������) ������������    
    while (n >= 0)                          // ���� ���� ������������ 
    {
        std::cout << std::endl << "{ ";
        for (int i = 0; i < n; i++)
            std::cout << AA[s1.ntx(i)] << ((i < n - 1) ? ", " : " ");
        std::cout << "}";
        n = s1.getnext();                   // c�������� ������������ 
    };
    std::cout << std::endl << "�����: " << s1.count() << std::endl;
    system("pause");
    return 0;

}

int TASK2() {
    //2.	��������� ���������
    setlocale(LC_ALL, "rus");
    char  AA[][2] = { "A", "B", "C", "D", "E" };
    std::cout << std::endl << " --- ��������� ��������� ---";
    std::cout << std::endl << "�������� ���������: ";
    std::cout << "{ ";
    for (int i = 0; i < sizeof(AA) / 2; i++)

        std::cout << AA[i] << ((i < sizeof(AA) / 2 - 1) ? ", " : " ");
    std::cout << "}";
    std::cout << std::endl << "��������� ��������� ";
    combi::xcombination xc(sizeof(AA) / 2, 3);
    std::cout << "�� " << xc.n << " �� " << xc.m;
    int  n = xc.getfirst();
    while (n >= 0)
    {

        std::cout << std::endl << xc.nc << ": { ";

        for (int i = 0; i < n; i++)


            std::cout << AA[xc.ntx(i)] << ((i < n - 1) ? ", " : " ");

        std::cout << "}";

        n = xc.getnext();
    };
    std::cout << std::endl << "�����: " << xc.count() << std::endl;
    system("pause");
    return 0;
}

int TASK3() {
    //3. ��������� ������������
    setlocale(LC_ALL, "rus");
    char  AA[][2] = { "A", "B", "C", "D" };
    std::cout << std::endl << " --- ��������� ������������ ---";
    std::cout << std::endl << "�������� ���������: ";
    std::cout << "{ ";
    for (int i = 0; i < sizeof(AA) / 2; i++)

        std::cout << AA[i] << ((i < sizeof(AA) / 2 - 1) ? ", " : " ");
    std::cout << "}";
    std::cout << std::endl << "��������� ������������ ";
    combi::permutation p(sizeof(AA) / 2);
    __int64  n = p.getfirst();
    while (n >= 0)
    {
        std::cout << std::endl << std::setw(4) << p.np << ": { ";

        for (int i = 0; i < p.n; i++)

            std::cout << AA[p.ntx(i)] << ((i < p.n - 1) ? ", " : " ");

        std::cout << "}";

        n = p.getnext();
    };
    std::cout << std::endl << "�����: " << p.count() << std::endl;
    system("pause");
    return 0;

}

#define N (sizeof(AA)/2)
#define M 3

int TASK4() {
    //4. ��������� ����������
    setlocale(LC_ALL, "rus");
    char  AA[][2] = { "A", "B", "C", "D" };
    std::cout << std::endl << " --- ��������� ���������� ---";
    std::cout << std::endl << "�������� ���������: ";
    std::cout << "{ ";
    for (int i = 0; i < N; i++)

        std::cout << AA[i] << ((i < N - 1) ? ", " : " ");
    std::cout << "}";
    std::cout << std::endl << "��������� ����������  ��  " << N << " �� " << M;
    combi::accomodation s(N, M);
    int  n = s.getfirst();
    while (n >= 0)
    {

        std::cout << std::endl << std::setw(2) << s.na << ": { ";

        for (int i = 0; i < 3; i++)

            std::cout << AA[s.ntx(i)] << ((i < n - 1) ? ", " : " ");

        std::cout << "}";

        n = s.getnext();
    };
    std::cout << std::endl << "�����: " << s.count() << std::endl;
    system("pause");

    return 0;
}

#define N5 10
int TASK5() {
    setlocale(LC_ALL, "rus");
    int d[N5][N5] = { //0       1       2        3     4         5     6       7       8       9             
                      {  0,     45,     INF,     25,   50,       40,     45,     INF,     25,   50,},    //  0
                      { 45,     0,      55,      20,   100,      45,     20,     55,      20,   100},    //  1
                      { 70,     20,     0,       10,   30,       70,     20,     10,      10,   30},    //  2 
                      { 80,     10,     40,      0,    10,       70,     20,     40,      10,   30},    //  3
                      { 30,     50,     20,      10,   0,        30,     50,     20,      10,   90},    // 4
                      { 30,     45,     INF,     25,   50,       0,      45,     100,     25,   50,},    //  5
                      { 45,     50,     55,      20,   100,      45,     0,      55,      20,   100},    //  6
                      { 70,     20,     60,      10,   30,       70,     20,     0,       10,   30},    //  7 
                      { 80,     10,     40,      70,   10,       70,     20,     80,      0,    30},    //  8
                      { 30,     50,     20,      10,   80,       30,     50,     20,      10,   0}    //  9 
                    };
    int r[N5];                     // ��������� 
    int s = salesman(
        N5,          // [in]  ���������� ������� 
        (int*)d,          // [in]  ������ [n*n] ���������� 
        r           // [out] ������ [n] ������� 0 x x x x  

    );
    std::cout << std::endl << "-- ������ ������������ -- ";
    std::cout << std::endl << "-- ����������  �������: " << N5;
    std::cout << std::endl << "-- ������� ���������� : ";
    for (int i = 0; i < N5; i++)
    {
        std::cout << std::endl;
        for (int j = 0; j < N5; j++)

            if (d[i][j] != INF) std::cout << std::setw(3) << d[i][j] << " ";

            else std::cout << std::setw(3) << "INF" << " ";
    }
    std::cout << std::endl << "-- ����������� �������: ";
    for (int i = 0; i < N5; i++) std::cout << r[i] << "-->"; std::cout << 0;
    std::cout << std::endl << "-- ����� ��������     : " << s;
    std::cout << std::endl;

    return 0;

}

//������� ������ �� �����������  ����������  �����������  �� ����� � ������� ���������� ����������
int _tmain(int argc, _TCHAR* argv[])
{
    //TASK1();
    //TASK2();
    //TASK3();
    //TASK4();
    double time_spent = 0.0;

    clock_t begin = clock();

    TASK5();

    clock_t end = clock();

    time_spent += (double)(end - begin) / CLOCKS_PER_SEC;

    printf("The elapsed time is %f seconds", time_spent);

    return 0;
}
