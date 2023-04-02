#include <iostream>
#include <ctime>
#include <chrono>
using namespace std;


int recursion(int number)
{
    if (number == 1)
        return 0;
    if (number == 2 or number == 3)
        return 1;
    return recursion(number - 1) + recursion(number - 2);
}


int main()
{
    setlocale(LC_ALL, "rus");
    int number;
    cout << "Введите порядковый номер числа из последовательности Фибоначчи: ";
    cin >> number;
    auto start = std::chrono::steady_clock::now();                           // фиксация времени 
    recursion(number);
    //cout << number << " число данной последовательности: " << recursion(number) << endl;
    auto end = std::chrono::steady_clock::now();                           // фиксация времени 

    std::cout << "\nпродолжительность:   " << std::chrono::duration_cast<std::chrono::nanoseconds> (end - start).count();
    return 0;
}

