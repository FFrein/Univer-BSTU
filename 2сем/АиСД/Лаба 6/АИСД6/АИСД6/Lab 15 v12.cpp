#include "Hash_Twin_Chain.h"
#include <iostream>

#define int_max 32767

using namespace std;
unsigned char rand8[256];
struct AAA
{
	int key;
	char* mas;
	AAA(int k, char* z) //конструктор с параметрами
	{
		key = k;
		mas = z;
	}
	AAA()//конструктор без параметров
	{
		key = 0;
		mas = (char*)"";
	}
};
//-------------------------------
int hf(void* d) // функци€ получени€ ключа (3 вариант)
{
	double A;
	A = (sqrt(5.0f) - 1.0f) / 2.0f;
	std::cout << A;
	AAA* f = (AAA*)d;
	return  f->key * A;
}

//-------------------------------
void AAA_print(listx::Element* e) // функци€ вывода ключа и значений 
{
	std::cout << ((AAA*)e->data)->key << '-' << ((AAA*)e->data)->mas << " / ";
}
//-------------------------------
int main()
{
	setlocale(LC_ALL, "rus");
	int current_size = 7;
	cout << "¬ведите размер хеш-таблицы" << endl;
	cin >> current_size;
	for (int i = 0; i < 256; i++)
		rand8[i] = rand() % 255;
	hashTC::Object H = hashTC::create(current_size, hf); //—оздание таблицы 
	int choice; // переменна€ дл€ выбора 
	int k;
	for (;;)
	{
		cout << "1 - вывод хеш-таблицы" << endl;
		cout << "2 - добавление элемента" << endl;
		cout << "3 - удаление элемента" << endl;
		cout << "4 - поиск элемента" << endl;
		cout << "0 - выход" << endl;
		cout << "сделайте выбор" << endl;
		cin >> choice;
		switch (choice)
		{
		case 0:  exit(0);
		case 2: {	  AAA* a = new AAA; // структура данных
			char* str = new char[20]; //заполнение 
			do {
				cout << "введите номер" << endl;
				cin >> k;
			} while (k > int_max);
			a->key = k;
			cout << "введите им€ " << endl;
			cin >> str;
			a->mas = str;
			H.insert(a); //функци€ добавлени€ в таблицу 
		}
			  break;
		case 1: H.Scan(); // функци€ вывода талицы
			break;
		case 3: {	  AAA* b = new AAA;
			cout << "введите номер" << endl;
			cin >> k;
			b->key = k;
			H.deleteByData(b); // функци€ удалени€ 
		}
			  break;
		case 4: AAA * c = new AAA;
			cout << "введите номер " << endl;
			cin >> k;
			c->key = k;
			if (H.search(c) == NULL) //поиск элемента 
				cout << "'элемент не найдена" << endl;
			else
			{
				cout << "Ёлемент с данным номером" << endl;
				AAA_print(H.search(c));
				cout << endl;
			}
			break;
		}
	}
	return 0;
}