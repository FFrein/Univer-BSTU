#pragma once
#include "stdafx.h"

namespace FST
{
	struct RELATION			// ребро:символ -> вершина графа переходов  ј
	{
		char symbol;	// символ перехода
		short nnode;	// номер смежной вершины
		RELATION(
			char c = 0x00,		// символ перехода
			short ns = NULL		// новое состо€ние
			);
	};

	struct NODE					// вершина графа переходов
	{
		short n_relation;		// колличество инцидентных ребер
		RELATION* relation;		// инцидентные ребра
		NODE();
		NODE(
			short n,			// количество инцидентный ребер
			RELATION rel, ...	// список ребер
			);
	};

	struct FST
	{
		char* string;
		short position;
		short nstates;
		NODE* nodes;
		short* rstates;
		FST(
			char* s,
			short ns,
			NODE n, ...
			);
	};

	bool execute(	// выполнить распознавание цепочки
		FST& fst	// недетерменированный конечный автомат
	);
}