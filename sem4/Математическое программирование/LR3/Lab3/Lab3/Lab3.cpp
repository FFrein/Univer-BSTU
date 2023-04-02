#include <iostream>
#include <iomanip> 
#include "Salesman.h"
#define N 5
int main()
{
    setlocale(LC_ALL, "rus");
    int n = 9;
    int d[N][N] = { //0   1    2    3     4        
                  { INF, 2*n, 21+n, INF, n},    //  0
                  { n, INF,  15+n,  68-n, 84-n},    //  1
                  { 2+n,  3*n, INF, 86, 49+n},    //  2 
                  { 17+n,  58-n,  4*n, INF, 3*n},    //  
                  { 93-n,  66+n,  52,  13+n, INF} };   //  4  
    int r[N];                     // результат 
    int s = salesman(
        N,          // [in]  количество городов 
        (int*)d,          // [in]  массив [n*n] расстояний 
        r           // [out] массив [n] маршрут 0 x x x x  

    );
    std::cout << std::endl << "-- Задача коммивояжера -- ";
    std::cout << std::endl << "-- количество  городов: " << N;
    std::cout << std::endl << "-- матрица расстояний : ";
    for (int i = 0; i < N; i++)
    {
        std::cout << std::endl;
        for (int j = 0; j < N; j++)

            if (d[i][j] != INF) std::cout << std::setw(3) << d[i][j] << " ";

            else std::cout << std::setw(3) << "INF" << " ";
    }
    std::cout << std::endl << "-- оптимальный маршрут: ";
    for (int i = 0; i < N; i++) std::cout << r[i] << "-->"; std::cout << 0;
    std::cout << std::endl << "-- длина маршрута     : " << s;
    std::cout << std::endl;
    system("pause");
    return 0;
}


//#include "Auxil.h"
//#include <iostream>
//#include <iomanip> 
//#include <time.h>
//#include "Salesman.h"
//#define SPACE(n) std::setw(n)<<" "
//#define N 12
//int main()
//{
//    setlocale(LC_ALL, "rus");
//    int d[N * N + 1], r[N];
//    auxil::start();
//    for (int i = 0; i <= N * N; i++) d[i] = auxil::iget(10, 100);
//    std::cout << std::endl << "-- Задача коммивояжера -- ";
//    std::cout << std::endl << "-- количество ------ продолжительность -- ";
//    std::cout << std::endl << "      городов           вычисления  ";
//    clock_t t1, t2;
//    for (int i = 7; i <= N; i++)
//    {
//        t1 = clock();
//        salesman(i, (int*)d, r);
//        t2 = clock();
//        std::cout << std::endl << SPACE(7) << std::setw(2) << i
//            << SPACE(15) << std::setw(5) << (t2 - t1);
//    }
//    std::cout << std::endl;
//    system("pause");
//    return 0;
//}

