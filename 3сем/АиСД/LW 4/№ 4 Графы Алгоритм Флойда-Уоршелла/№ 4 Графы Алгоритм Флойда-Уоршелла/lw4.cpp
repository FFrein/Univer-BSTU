#include <iostream>

using namespace std;

//алгоритм Флойда-Уоршелла
void FWA1(int M[6][6], int SM[6][6])
{
	int MS = sizeof(M) - 2;

	for (int k = 0; k < MS; k++)
		for (int i = 0; i < MS; i++)
			for (int j = 0; j < MS; j++)
				if (M[i][k] && M[k][j] && i != j)
					if (M[i][k] + M[k][j] < M[i][j] || M[i][j] == 0) {
						M[i][j] = M[i][k] + M[k][j];
						SM[i][j] = k + 1;
					}
}
//Вывод матрицы
void PritM(int SPM[6][6]) 
{	//matrix - матрица смежности
	int MS = sizeof(SPM) - 2;
	for (int i = 0; i < MS; i++) {
		for (int j = 0; j < MS; j++) {

				std::cout << SPM[i][j] << "\t";;
		}
		std::cout << std::endl;
	}
	std::cout << std::endl;
}

void main() {
	//матрица кратчайших путей
	int Matrix[6][6] =
	{
		{0, 28, 21, 59, 12, 27},
		{7, 0, 24, INFINITY, 21, 9},
		{9, 32, 0, 13, 11, INFINITY},
		{8, INFINITY, 5, 0, 16, INFINITY},
		{14, 13, 15, 10, 0 ,22},
		{15, 18, INFINITY, INFINITY, 6, 0}
	};
	//матрица последовательности
	int SequenceMatrix[6][6] = {
		{0, 2, 3, 4, 5, 6},
		{1, 0, 3, 4, 5, 6},
		{1, 2, 0, 4, 5, 6},
		{1, 2, 3, 0, 5, 6},
		{1, 2, 3, 4, 0, 6},
		{1, 2, 3, 4, 5, 0},
	};
	FWA1(Matrix, SequenceMatrix);
	PritM(Matrix);
	PritM(SequenceMatrix);
}








//Пробегаемся по всем вершинам и ищем более короткий путь через вершину k

//Новое значение ребра равно минимальному между старым ребром и суммой ребер