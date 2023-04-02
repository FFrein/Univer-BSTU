#include <iostream>
#include <string>

using namespace std;

//this Node its left or right -> number = 0 or 1 (left:0 right:1)
struct NODE {
	string letter;
	int number;
	NODE* left;
	NODE* right;
};

string Haffman(string input) {
	string start_str = input;
	string Letters[32];
	int Letters_count[32];
	int Letters_amount = 0;
	int string_lenght = 0;

	//подсчёт символов
	for (int i = 0; i < start_str.length(); i++) {
		for (int j = 0; j < 32; j++) {
			if (start_str[i] == Letters[j][0]) {
				Letters_count[j] += 1;
				break;
			}
			if (Letters[j][0] == NULL) {
				Letters[j] = start_str[i];
				Letters_count[j] = 1;
				Letters_amount++;
				string_lenght++;
				break;
			}
		}
	}

	//первоначальная сортировка
	bool check = 0;
	do {
		int buff_i;
		char buff_c;
		check = 0;
		for (int i = 0; i < Letters_amount; i++) {
			if (Letters[i][0] < 0) break;
			for (int j = i; j < Letters_amount; j++) {
				if (Letters_count[i] < Letters_count[j]) {
					buff_i = Letters_count[i];
					Letters_count[i] = Letters_count[j];
					Letters_count[j] = buff_i;

					buff_c = Letters[i][0];
					Letters[i] = Letters[j];
					Letters[j][0] = buff_c;

					check = 1;
					break;
				}
			}
		}
	} while (check == 1);
	
	//Что мы получили после подсчёта и сортировки
	for (int i = 0; i < Letters_amount; i++) {
		cout << Letters[i][0] << Letters_count[i] << "\t";
	}
	cout << endl;

	//соединение символов в одну строку
	do {
		int buff_i;
		string buff_s;
		Letters[Letters_amount - 2] += Letters[Letters_amount - 1];
		Letters_count[Letters_amount - 2] += Letters_count[Letters_amount - 1];

		buff_s = Letters[Letters_amount - 2];
		buff_i = Letters_count[Letters_amount - 2];

		Letters_amount--;

		for (int i = 0; i < Letters_amount - 1; i++) {
			if (Letters_count[Letters_amount - 1] > Letters_count[i]) {
				for (int j = Letters_amount - 1; j > i; j--) {
					Letters_count[j] = Letters_count[j - 1];
					Letters[j] = Letters[j - 1];
				}
				Letters_count[i] = buff_i;
				Letters[i] = buff_s;
				break;
			}
		}
	}while(Letters_amount != 1);

	cout << Letters[0] << Letters_count[0] << endl;

	//создиние кодов
	string CODE[32];

	cout << endl;

	string result = "";

	for (int i = 0; i < start_str.length(); i++) {
		for (int j = 0; j < string_lenght; j++) {
			if (start_str[i] == Letters[0][j]) {
				result += CODE[j];
			}
		}
	}

	return result + "\n";
}

void main() {
	cout << Haffman("aabbbccccddd");
	cout << Haffman("Pesetsky Nikita Andreevich");
}