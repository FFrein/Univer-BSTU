#include "stdafx.h"

namespace LT
{
	//��������� � ������� ������ � ��������
	void Add(LexTable& lextable, Entry entry)
	{
		if (lextable.size < lextable.maxsize)
			lextable.table[lextable.size++] = entry;
		else
			throw "������ �������� ���������� ������ ������� ������";
	}
	//������ ������� ������
	LexTable Create(int size) {
		if(size < LT_MAXSIZE)
		{
			LexTable lextable;
			lextable.size = 0; // ������� ������
			lextable.maxsize = LT_MAXSIZE; // ������������ ������
			lextable.table = new Entry[size]; // ������ � ��������� (����������� size ������ ��� LT_MAXSIZE?)
			return lextable;
		}
		else {
			throw "������ �������� ���������� ������ ������� ������";
		}
	}

	Entry GetEntry(LexTable& lextable, int n) {
		try {
			return lextable.table[n];
		}
		catch (Error::ERROR e) {
			throw "����� �� ������� ������� ������";
		}
	}

	void Delete(LexTable& lextable)
	{
		delete[] lextable.table;
		lextable.table = nullptr;
	}
}