#include <iostream>
#include <fstream>

#define TYPE_BOOL "0x01"
#define TYPE_INT "0x02"

using namespace std;

void main() {
	bool Boolean = true;
	const int numb = 500;

	fstream fs("File.txt", ios::out);

	if (fs.is_open())
	{
		fs << TYPE_BOOL << "0x" << hex << Boolean << "\n";
		fs << TYPE_INT << "0x" << hex << numb << "\n";
		fs.close();
	}
}