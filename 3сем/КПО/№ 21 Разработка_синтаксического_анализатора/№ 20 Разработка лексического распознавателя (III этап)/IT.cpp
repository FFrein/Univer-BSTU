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
			throw "ошибка превышен допустимый размер таблицы идентификаторов";
	}

	// получить строку таблицы идентификаторов
	// экземпл€р таблицы идентификаторов
	// номер получаемой строки
	Entry GetEntry(IdTable& idtable, int n) {
		try {
			return idtable.table[n];
		}
		catch (Error::ERROR e) {
			throw "¬ыход за пределы массива лексем";
		}
	}
	
	// возврат: номер строки (если есть), TI_NULLIDX (если нет
	// экземпл€р таблицы идентификаторов
	// идентификатор
	int IsId(IdTable& idtable, unsigned char id[ID_MAXSIZE]) {
		//в разработке
		return 0;
	}

	// удалить таблицу лексем (освободить пам€ть)
	void Delete(IdTable& idtable) {
		delete[] idtable.table;
		idtable.table = nullptr;
	}
}