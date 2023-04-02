#include "stdafx.h"

namespace LT
{
	//добавл€ем к таблице строку с лексемой
	void Add(LexTable& lextable, Entry entry)
	{
		if (lextable.size < lextable.maxsize)
			lextable.table[lextable.size++] = entry;
		else
			throw "ошибка превышен допустимый размер таблицы лексем";
	}
	//создаЄм таблицу лексем
	LexTable Create(int size) {
		if(size < LT_MAXSIZE)
		{
			LexTable lextable;
			lextable.size = 0; // текущий размер
			lextable.maxsize = LT_MAXSIZE; // максимальынй размер
			lextable.table = new Entry[size]; // массив с лексемами (размерность size делать или LT_MAXSIZE?)
			return lextable;
		}
		else {
			throw "ошибка превышен допустимый размер таблицы лексем";
		}
	}

	Entry GetEntry(LexTable& lextable, int n) {
		try {
			return lextable.table[n];
		}
		catch (Error::ERROR e) {
			throw "¬ыход за пределы массива лексем";
		}
	}

	void Delete(LexTable& lextable)
	{
		delete[] lextable.table;
		lextable.table = nullptr;
	}
}