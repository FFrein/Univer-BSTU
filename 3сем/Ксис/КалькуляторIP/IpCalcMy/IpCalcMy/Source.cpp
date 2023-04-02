#include <iostream>

using namespace std;

/*
128 64 32 16 8 4 2 1
*/

int main() {
	int octets[4];
	for (int i = 0; i < 4; i++)
		cin >> octets[i];

	int buff[4][8];
	for (int octet = 0; octet != 4; octet++) {
		int i = 128, byte_pos = 0;
		do{
			if (octets[octet] - i >= 0) {
				octets[octet] -= i;
				buff[octet][byte_pos] = 1;
				if (buff[octet][byte_pos - 1] == 0) {
					cout << "Error: invalid maska";
					return 0;
				}
			}
			else {
				buff[octet][byte_pos] = 0;
			}

			i = i / 2, byte_pos++;
			if (i == 1) {
				if (octets[octet] - i >= 0)
					buff[octet][byte_pos] = 1;
				else
					buff[octet][byte_pos] = 0;
			}
		} while (i != 1);
	}
	for (int i = 0; i != 4; i++) {
		for (int j = 0; j != 8; j++)
			cout << buff[i][j];
		cout << ".";
	}
		

}