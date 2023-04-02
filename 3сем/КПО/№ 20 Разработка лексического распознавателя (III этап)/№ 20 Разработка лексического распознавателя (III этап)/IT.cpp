#include "stdafx.h"
namespace IT 
{
	IdTable Create(int size) {
		IdTable idtable;
		idtable.max_size = TI_MAXSIZE;
		idtable.size = 0;
		idtable.table = new Entry[size];
		return idtable;
	}
	
	void Add(IdTable& idtable, Entry entry) {
		if (idtable.size < idtable.max_size)
			idtable.table[idtable.size++] = entry;
		else
			throw "������ �������� ���������� ������ ������� ���������������";
	}

	// �������� ������ ������� ���������������
	// ��������� ������� ���������������
	// ����� ���������� ������
	Entry GetEntry(IdTable& idtable, int n) {
		try {
			return idtable.table[n];
		}
		catch (Error::ERROR e) {
			throw "����� �� ������� ������� ������";
		}
	}
	
	// �������: ����� ������ (���� ����), TI_NULLIDX (���� ���
	// ��������� ������� ���������������
	// �������������
	int IsId(IdTable& idtable, unsigned char id[ID_MAXSIZE]) {
		//� ����������
		return 0;
	}

	// ������� ������� ������ (���������� ������)
	void Delete(IdTable& idtable) {
		delete[] idtable.table;
		idtable.table = nullptr;
	}
}