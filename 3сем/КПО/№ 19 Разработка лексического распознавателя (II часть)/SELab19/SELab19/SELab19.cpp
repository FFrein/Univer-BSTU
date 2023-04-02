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

	if (FST::execute(fst2))	// выполнить разбор
		std::cout << "Цепочка " << fst2.string << " распознана" << std::endl;
	else
		std::cout << "Цепочка " << fst2.string << " не распознана" << std::endl;

	system("pause");
	return 0;
}