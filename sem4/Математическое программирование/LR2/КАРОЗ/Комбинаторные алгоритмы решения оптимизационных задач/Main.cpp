#pragma once
#include "stdafx.h"

/*
Задание 1.  Разобрать и разработать генератор подмножеств заданного множества.
Задание 2.  Разобрать и разработать генератор сочетаний.
Задание 3.  Разобрать и разработать генератор перестановок.
Задание 4.  Разобрать и разработать генератор размещений.

Задание 5.  Решить  в соответствии с вариантом задачу и результат занести в отчет (Вариант распределяется по списку):
коммивояжера (расстояния сгенерировать случайным образом: 
10 городов, расстояния 10 – 300 км, 3 расстояния между городами задать бесконечными);

Задание 6. Исследовать зависимость времени вычисления необходимое для решения задачи (в соответствии с вариантом) от размерности задачи и результат в виде графика с небольшим пояснением занести в отчет:
коммивояжера (6 – 12 городов);

*/

int TASK1() {
    //1.	Генерация  подмножеств заданного множества
    setlocale(LC_ALL, "rus");
    char  AA[][2] = { "A", "B", "C", "D" };
    std::cout << std::endl << " - Генератор множества всех подмножеств -";
    std::cout << std::endl << "Исходное множество: ";
    std::cout << "{ ";
    for (int i = 0; i < sizeof(AA) / 2; i++)
        std::cout << AA[i] << ((i < sizeof(AA) / 2 - 1) ? ", " : " ");
    std::cout << "}";
    std::cout << std::endl << "Генерация всех подмножеств  ";
    combi::subset s1(sizeof(AA) / 2);         // создание генератора   
    int  n = s1.getfirst();                // первое (пустое) подмножество    
    while (n >= 0)                          // пока есть подмножества 
    {
        std::cout << std::endl << "{ ";
        for (int i = 0; i < n; i++)
            std::cout << AA[s1.ntx(i)] << ((i < n - 1) ? ", " : " ");
        std::cout << "}";
        n = s1.getnext();                   // cледующее подмножество 
    };
    std::cout << std::endl << "всего: " << s1.count() << std::endl;
    system("pause");
    return 0;

}

int TASK2() {
    //2.	Генерация сочетаний
    setlocale(LC_ALL, "rus");
    char  AA[][2] = { "A", "B", "C", "D", "E" };
    std::cout << std::endl << " --- Генератор сочетаний ---";
    std::cout << std::endl << "Исходное множество: ";
    std::cout << "{ ";
    for (int i = 0; i < sizeof(AA) / 2; i++)

        std::cout << AA[i] << ((i < sizeof(AA) / 2 - 1) ? ", " : " ");
    std::cout << "}";
    std::cout << std::endl << "Генерация сочетаний ";
    combi::xcombination xc(sizeof(AA) / 2, 3);
    std::cout << "из " << xc.n << " по " << xc.m;
    int  n = xc.getfirst();
    while (n >= 0)
    {

        std::cout << std::endl << xc.nc << ": { ";

        for (int i = 0; i < n; i++)


            std::cout << AA[xc.ntx(i)] << ((i < n - 1) ? ", " : " ");

        std::cout << "}";

        n = xc.getnext();
    };
    std::cout << std::endl << "всего: " << xc.count() << std::endl;
    system("pause");
    return 0;
}

int TASK3() {
    //3. Генерация перестановок
    setlocale(LC_ALL, "rus");
    char  AA[][2] = { "A", "B", "C", "D" };
    std::cout << std::endl << " --- Генератор перестановок ---";
    std::cout << std::endl << "Исходное множество: ";
    std::cout << "{ ";
    for (int i = 0; i < sizeof(AA) / 2; i++)

        std::cout << AA[i] << ((i < sizeof(AA) / 2 - 1) ? ", " : " ");
    std::cout << "}";
    std::cout << std::endl << "Генерация перестановок ";
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
    std::cout << std::endl << "всего: " << p.count() << std::endl;
    system("pause");
    return 0;

}

#define N (sizeof(AA)/2)
#define M 3

int TASK4() {
    //4. Генерация размещений
    setlocale(LC_ALL, "rus");
    char  AA[][2] = { "A", "B", "C", "D" };
    std::cout << std::endl << " --- Генератор размещений ---";
    std::cout << std::endl << "Исходное множество: ";
    std::cout << "{ ";
    for (int i = 0; i < N; i++)

        std::cout << AA[i] << ((i < N - 1) ? ", " : " ");
    std::cout << "}";
    std::cout << std::endl << "Генерация размещений  из  " << N << " по " << M;
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
    std::cout << std::endl << "всего: " << s.count() << std::endl;
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
    int r[N5];                     // результат 
    int s = salesman(
        N5,          // [in]  количество городов 
        (int*)d,          // [in]  массив [n*n] расстояний 
        r           // [out] массив [n] маршрут 0 x x x x  

    );
    std::cout << std::endl << "-- Задача коммивояжера -- ";
    std::cout << std::endl << "-- количество  городов: " << N5;
    std::cout << std::endl << "-- матрица расстояний : ";
    for (int i = 0; i < N5; i++)
    {
        std::cout << std::endl;
        for (int j = 0; j < N5; j++)

            if (d[i][j] != INF) std::cout << std::setw(3) << d[i][j] << " ";

            else std::cout << std::setw(3) << "INF" << " ";
    }
    std::cout << std::endl << "-- оптимальный маршрут: ";
    for (int i = 0; i < N5; i++) std::cout << r[i] << "-->"; std::cout << 0;
    std::cout << std::endl << "-- длина маршрута     : " << s;
    std::cout << std::endl;

    return 0;

}

//Решение задачи об оптимальном  размещении  контейнеров  на судне с помощью генератора размещений
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
