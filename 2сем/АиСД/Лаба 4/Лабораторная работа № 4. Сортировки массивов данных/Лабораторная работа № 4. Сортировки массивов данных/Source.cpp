#include <iostream>

using namespace std;

void main() {

	cout << "Quest 1" << endl;
	const int N = 9;
	int mass[N], result = 0;

	srand(time(NULL));

	for (int i = 0; i < N; i++) {
		mass[i] = rand() % 25;
	}

	for (int i = 0; i < N; i++) {
		for (int j = 0; j < N - 1; j++) {
			if (mass[j] < mass[j + 1]) {
				mass[j + 1] += mass[j];
				mass[j] = mass[j + 1] - mass[j];
				mass[j + 1] -= mass[j];
			}
		}
	}

	for (int i = 0; i < N / 2; i++) {
		cout << mass[i] << " ";
		result += mass[i];
		cout << mass[(N / 2) + i] << " ";
	}
	cout << "\n result : " << result << endl;

	cout << "Quest 2" << endl;

	const int M = 20;
	int mass_2[M], result_2 = 0, counter = 0;
	for (int i = 0; i < M; i++) {
		mass_2[i] = rand() % 10;
	}

	for (int i = 0; i < M; i++) {
		for (int j = 0; j < M - 1; j++) {
			if (mass_2[j] < mass_2[j + 1]) {
				mass_2[j + 1] += mass_2[j];
				mass_2[j] = mass_2[j + 1] - mass_2[j];
				mass_2[j + 1] -= mass_2[j];
			}
		}
	}

	for (int i = 0; i < M; i++) {
		cout << mass_2[i] << " ";
	}

	bool checker = 0;
	for (int i = 0; i < M; i++) {
		checker = 0;
		if (i == 0) {
			counter++;
			result_2++;
			checker = 1;
		}

		if (mass_2[i] == mass_2[i - 1] && checker != 1) {
			result_2++;
			checker = 1;
		}

		if (mass_2[i] != mass_2[i - 1] && checker != 1) {
			counter++;
			result_2++;
		}

		if (mass_2[i] == mass_2[i + 1] && checker != 1) {
			checker = 1;
		}

		if (counter == 3 && mass_2[i] != mass_2[i + 1])
			break;
			
	}
	cout << "\n result : " << result_2 << endl;
}