#include <iostream>

int Fibonachi_Cikl(int N) {
	int mass[3] = { 0, 1 };
	N = N - 2;
	for (int c = 0; c <= N; c++) {
			mass[2] = mass[1];
			mass[1] = mass[1] + mass[0];
			mass[0] = mass[2];
	}
	return mass[1];
}

int Fibonachi_recursia(int N)
{
	if (N == 0)
	{
		return 0;
	}
	if (N == 1)
	{
		return 1;
	}
	return Fibonachi_recursia(N - 1) + Fibonachi_recursia(N - 2);
}

int main()
{
	using namespace std;
	setlocale(LC_ALL, "RUS");
	double N = 50, time1, time2, time_razn;
	//cout << "Введите N-ое число ряда Фибоначчи: ";
	//cin >> N;

	cout << "Число = " << Fibonachi_recursia(N) << endl;
	time1 = clock() / 1000.0;
	cout << "Время выполнение рекурсии = " << time1 << "sec" << endl;
	cout << "Число = " << Fibonachi_Cikl(N) << endl;
	time2 = clock() / 1000.0 - time1;
	cout << "Время выполнение цикла = " << time2 << "sec" << endl;
	time_razn = abs(time2 - time1);
	cout << "Time_razn = " << time_razn << endl;
	return 0;
}

