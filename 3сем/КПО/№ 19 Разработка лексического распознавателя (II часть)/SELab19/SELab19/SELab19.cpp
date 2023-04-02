#include <iostream>
#include "FST.h"

int main() {
	setlocale(LC_ALL, "rus");

	FST::FST fst2(	
		(char*)"int",
		4,			
		FST::NODE(1, FST::RELATION('i', 1)),
		FST::NODE(1, FST::RELATION('n', 2)),
		FST::NODE(1, FST::RELATION('t', 3)),
		FST::NODE()
	);

	if (FST::execute(fst2))	// ��������� ������
		std::cout << "������� " << fst2.string << " ����������" << std::endl;
	else
		std::cout << "������� " << fst2.string << " �� ����������" << std::endl;

	system("pause");
	return 0;
}