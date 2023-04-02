#include <iostream>
#include <string>

using namespace std;

void towerOfHanoi(int n, string from_rod, string to_rod,
	string aux_rod)
{
	if (n == 0) {
		return;
	}
	towerOfHanoi(n - 1, from_rod, aux_rod, to_rod);
	cout << "Переместите диск " << n << " с столба " << from_rod
		<< " на столб " << to_rod << endl;
	towerOfHanoi(n - 1, aux_rod, to_rod, from_rod);
}

// Driver code
int main()
{
	setlocale(LC_ALL, "rus");
	
	string number;
	int N = 0;

	string start_rod, end_rod, aux_rod;

	cout << "Введите число дисков: ";
	bool checker = false;
	do {
		try {
			cin >> number;

			N = stoi(number);
			checker = true;
		}
		catch(invalid_argument e) {
			cout << "fu";
			cin.clear();
			cin.ignore();
		}
	} while (!checker && N <= 0);

	cout << "выберите начальный столб:" << endl;
	cin >> start_rod;
	cout << "выберите конечный столб:" << endl;
	cin >> end_rod;
	cout << "выберите доп столб:" << endl;
	cin >> aux_rod;
	// A, B and C are names of rods


	towerOfHanoi(N, start_rod, end_rod, aux_rod);
	return 0;
}






































/*
void MoveDisk(int diskcol, int TowOne, int TowTwo) {
	using namespace std;
	cout << "Переместите диск " << diskcol << " c башни " << TowOne << " на башню " << TowTwo << endl;
}

void MoveFunHT(int start, int end, int col) {
	if (col == 1) {
		MoveDisk(1, start, end);
	}


}

int main() {

	using namespace std;

	setlocale(LC_ALL, "rus");

	int start; //стартовый стержень
	int col; //кол дисков

	int end; // На какой стержень перемещаем

	cout << "Введите стартовый стержень" << endl;
	cin >> start;

	cout << "Введите кол дисков" << endl;
	cin >> col;

	do {
		cout << "Введите на какой стержень хотите перенести башню" << endl;
		cin >> end;
	} while (end == start || end <= 0 || end > 3);

	MoveFunHT(start, end, col);

	return 0;
}
*/