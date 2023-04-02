#pragma once
#include "stdafx.h"


using namespace std;

namespace SM
{
	int i = 0;

	void semAnaliz(LT::LexTable& lextable, IT::IdTable& idtable)
	{
		for (; i < lextable.current_size; i++)
		{
			switch (lextable.table[i]->lexema)
			{
			case LEX_OPERATOR:	// ������� �� 0
			{
				CheckDivByZero(lextable, idtable);
				break;
			}
			case LEX_EQUAL: // ���������
			{
				CheckEqual(lextable, idtable);
				break;
			}
			case LEX_ID: // �������� ���� ������������� ��������  
			{
				CheckFuncType(lextable, idtable);
				break;
			}
			case LEX_MORE:	case LEX_LESS:
			{
				CheckCompareINT(lextable, idtable);
				// �������� �������� ���������
				break;
			}
			}
		}
	}
	void CheckFuncType(LT::LexTable& lextable, IT::IdTable& idtable)
	{
		IT::Entry* e = idtable.table[lextable.table[i]->idxTI];

		if (i && lextable.table[i - 1]->lexema == LEX_FUNCTION)	// ���������� �������
		{
			for (int k = i + 1; ; k++)
			{
				char l = lextable.table[k]->lexema;
				if (l == LEX_RETURN)
				{
					int next = lextable.table[k + 1]->idxTI; // ����. �� return
					if (idtable.table[next]->iddatatype != e->iddatatype)
					{
						printf_s(ERROR_TRACE, "SemanticAnaliz.cpp", "CheckFuncType", "types?");
						throw ERROR_THROW_IN(703, lextable.table[k + 1]->sn, -1);
					}
					break;
				}
			}
		}
		if (lextable.table[i + 1]->lexema == LEX_LEFTHESIS && lextable.table[i - 1]->lexema != LEX_FUNCTION) // ������ �����
		{
			if (e->idtype == IT::IDTYPE::F) // ����� �������
			{
				int argscount = NULL;
				// �������� ������������ ����������
				for (int j = i + 1; lextable.table[j]->lexema != LEX_RIGHTHESIS; j++)
				{
					// �������� ������������ ������������ ���������� ����������
					if (lextable.table[j]->lexema == LEX_ID || lextable.table[j]->lexema == LEX_LITERAL)
					{
						argscount++;
						IT::IDDATATYPE ctype = idtable.table[lextable.table[j]->idxTI]->iddatatype;
						if (argscount > e->params.count)
						{
							printf_s(ERROR_TRACE, "SemanticAnaliz.cpp", "CheckFuncType", "overflow args");
							throw ERROR_THROW_IN(705, lextable.table[i]->sn, -1);
						}
						if (ctype != e->params.types[argscount - 1])
						{
							printf_s(ERROR_TRACE, "SemanticAnaliz.cpp", "CheckFuncType", "type?");
							throw ERROR_THROW_IN(704, lextable.table[j]->sn, lextable.table[j]->tn);
						}
					}
				}
				if (argscount != e->params.count)
				{
					printf_s(ERROR_TRACE, "SemanticAnaliz.cpp", "CheckFuncType", "overflow args");
					throw ERROR_THROW_IN(705, lextable.table[i]->sn, -1);
				}
			}
		}

	}
	void CheckDivByZero(LT::LexTable& lextable, IT::IdTable& idtable)
	{
		if (lextable.table[i]->sign == '/')
			if (lextable.table[i + 1]->lexema == LEX_LITERAL || lextable.table[i + 1]->lexema == LEX_ID)
			{
				int k = lextable.table[i + 1]->lexema == LEX_LITERAL  ? 0 : 1;
				if (idtable.table[lextable.table[i + 1]->idxTI + k]->value.vint == 0)
				{
					printf_s(ERROR_TRACE, "SemanticAnaliz.cpp", "CheckDivByZero", "x\\0");
					throw ERROR_THROW_IN(700, lextable.table[i + 1]->sn, lextable.table[i + 1]->tn);
				}
			}
	}
	void CheckCompareINT(LT::LexTable& lextable, IT::IdTable& idtable)
	{
		// ����� � ������ ������� - �������� ���
		bool flag = true;
		if (lextable.table[i - 1]->idxTI != LT_TI_NULLXDX)
		{
			if (idtable.table[lextable.table[i - 1]->idxTI]->iddatatype != IT::IDDATATYPE::INT)
				flag = false;
		}
		if (lextable.table[i + 1]->idxTI != LT_TI_NULLXDX)
		{
			if (idtable.table[lextable.table[i + 1]->idxTI]->iddatatype != IT::IDDATATYPE::INT)
				flag = false;
		}
		if (!flag)
		{
			printf_s(ERROR_TRACE, "IT.cpp", "IdTAble", "int|str > str|int");
			throw ERROR_THROW_IN(706, lextable.table[i]->sn, -1);
		}
	}
	void CheckEqual(LT::LexTable& lextable, IT::IdTable& idtable)
	{
		if (i)
		{
			IT::IDDATATYPE lefttype = idtable.table[lextable.table[i - 1]->idxTI]->iddatatype;	// ����� �������
			bool ignore = false;

			for (int k = i + 1; lextable.table[k]->lexema != LEX_SEMICOLON; k++)
			{
				if (lextable.table[k]->idxTI != LT_TI_NULLXDX) // ���� �� - ��������� ���������� �����
				{
					if (!ignore)
					{
						IT::IDDATATYPE righttype = idtable.table[lextable.table[k]->idxTI]->iddatatype;
						if (lefttype != righttype) // ���� ������ � ��������� �� ���������
						{
							printf_s(ERROR_TRACE, "SemanticAnaliz.cpp", "CheckEqual", "str type = int val");
							throw ERROR_THROW_IN(701, lextable.table[k]->sn, -1);
						}
					}
					// ���� ������� ����� ����� ������� ������ - ��� ����� �������
					if (k + 1 < lextable.current_size && lextable.table[k + 1]->lexema == LEX_LEFTHESIS && idtable.table[lextable.table[k]->idxTI]->idtype == IT::IDTYPE::F)
					{
						ignore = true;
						continue;
					}
					// ����������� ������ ����� ������ ����������
					if (ignore && lextable.table[k + 1]->lexema == LEX_RIGHTHESIS)
					{
						ignore = false;
						continue;
					}
				}
				if (lefttype == IT::IDDATATYPE::STR) // ������ ������ �������, �� ��� ����� ��������� �-���
				{
					char l = lextable.table[k]->lexema;
					if (l == LEX_OPERATOR) // ��������� �����������
					{
						printf_s(ERROR_TRACE, "SemanticAnaliz.cpp", "CheckEqual", "literal");
						throw ERROR_THROW_IN(702, lextable.table[k]->sn, -1);
					}
				}
			}
		}
	}
}