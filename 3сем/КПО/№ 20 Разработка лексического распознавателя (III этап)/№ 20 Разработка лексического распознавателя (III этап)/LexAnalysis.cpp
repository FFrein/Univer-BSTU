#pragma once
#include "stdafx.h"

namespace LA 
{
	bool AnalyseIdentificator(char* token, const int strNumber, LT::LexTable& lexTable, IT::IdTable& idTable, TypeOfVar& flag_type_variable) {
		//для функций. переменных и т.д
		if (true) {
			return true;
		}
		else {
			return false;
		}
	}

	bool Analyse(char* token, const int strNumber, LT::LexTable& lexTable, IT::IdTable& idTable) {
		static TypeOfVar flag_type_variable;

		switch (token[0])
		{
			//перебо всех лексем (пока что не доделано)
			case LEX_COMMA:
			{
				Add(lexTable, { LEX_COMMA ,strNumber, LT_TI_NULLIDX });
				return true;
			}
		}
	}
	void FindLex(const In::IN& source, LT::LexTable& lexTable, IT::IdTable& idTable) {
		char* temp = new char[token_size] {};//буфер для слова
		int str_number = 1;
		int str_position = 1;

		for (int i = 0, j = 0; i < source.size; i++)
		{
			if (source.text[i] == '\0' || source.text[i] == EOF)
				break;
			//запись слова в буфер
			if (source.text[i] != ' ' && source.text[i] != '\n') {
				temp[j] = source.text[i];
				j++;
				continue;
			}
			else if (source.text[i] == ' ' || source.text[i] == '\n') {
				//запись перехода на следующую строку
				if (source.text[i] == '\0')
					str_position++;
				//анализ лексемы(слова)
				if (Analyse(temp, str_number, lexTable, idTable)) {
					j = 0;
					continue;
				}
				else {
					//место для будущего вывода ошибки
				}
			}
		}
	}

}