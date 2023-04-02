#include "pch.h"

#define  CYCLE  1000000                       // количество циклов  

void taskOne() {
	double  av1 = 0, av2 = 0;
	clock_t  t1 = 0, t2 = 0;

	setlocale(LC_ALL, "rus");

	auxil::start();                          // старт генерации 
	t1 = clock();                            // фиксация времени 
	for (int i = 0; i < CYCLE; i++)
	{
		av1 += (double)auxil::iget(-100, 100); // сумма случайных чисел 
		av2 += auxil::dget(-100, 100);         // сумма случайных чисел 
	}
	t2 = clock();                            // фиксация времени 


	std::cout << std::endl << "количество циклов:         " << CYCLE;
	std::cout << std::endl << "среднее значение (int):    " << av1 / CYCLE;
	std::cout << std::endl << "среднее значение (double): " << av2 / CYCLE;
	std::cout << std::endl << "продолжительность (у.е):   " << (t2 - t1);
	std::cout << std::endl << "                  (сек):   "
		<< ((double)(t2 - t1)) / ((double)CLOCKS_PER_SEC);
	std::cout << std::endl;

}

int fibonachi(int itter, int startnum1, int startnum2, int counter = 0) {

	long buff = startnum2;
	startnum2 = startnum1 + startnum2;
	if (counter != itter) {
		counter++;
		return fibonachi(itter, buff, startnum2, counter);
	}
	else if (counter == itter) {
		return startnum2;
	}
	else {
		return 0;
	}
}

int _tmain(int argc, _TCHAR* argv[])
{
	using namespace std;

	taskOne();


	clock_t  t1 = 0, t2 = 0;
	t1 = clock();

	cout << "Fibonachi: ";
	cout << fibonachi(100, 0, 1) << endl;

	t2 = clock();
	std::cout << std::endl << "продолжительность (у.е):   " << (t2 - t1);
	std::cout << std::endl << "                  (сек):   "
		<< ((double)(t2 - t1)) / ((double)CLOCKS_PER_SEC) << endl;

	system("pause");
}