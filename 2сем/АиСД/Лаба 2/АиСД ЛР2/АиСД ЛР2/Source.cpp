#include <iostream>

int main() {

	using namespace std;

	int N, choice = 0, left = 0, right, mid;

	cout << "Input max number" << endl;
	cin >> right;
	mid = right / 2;

	cout << "Input N" << endl;
	cin >> N;

	for (;;) {
		if (choice == 3 || mid == N) {
			system("cls");
			break;
		}

		if (choice == 2) {
			left = mid;
			mid = (right + left) / 2;
		}

		if (choice == 1) {
			right = mid;
			mid = (right + left) / 2;
		}

		system("cls");

		cout << mid << endl;

		cout << "1)many\n2)few\n3)you guessed it" << endl;
		cin >> choice;

	}

	return 0;
}