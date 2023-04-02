#include "stdafx.h"
#include "Auxil.h"                           
#include <chrono>
#define  CYCLE 50000                 

int main()
{
	setlocale(LC_ALL, "rus");

	double  av1 = 0, av2 = 0;
	//clock_t  t1 = 0, t2 = 0;


	auxil::start();                          // старт генерации 
	auto start = std::chrono::steady_clock::now();                          
	for (long long i = 0; i < CYCLE; i++)
	{
		av1 += (int)auxil::iget(-100, 100); 
		av2 += auxil::dget(-100, 100);          
	}
	auto end = std::chrono::steady_clock::now();                     // фиксация времени 

	std::cout << "количество циклов:         " << CYCLE;
	std::cout << "\nсреднее значение (int):    " << av1 / CYCLE;
	std::cout << "\nсреднее значение (double): " << av2 / CYCLE;
	std::cout << "\nпродолжительность (н.с):   " << std::chrono::duration_cast<std::chrono::nanoseconds > (end - start).count();
	//std::cout << "\n                  (сек):   "
		//<< ((double)(end - start)) / ((double)CLOCKS_PER_SEC);
	std::cout << std::endl;
	system("pause");

	return 0;
}