#pragma once
#include "stdafx.h"

namespace Out
{
	struct OUT
	{
		wchar_t outfile[PARM_MAX_SIZE];
		std::ofstream* stream;

		OUT();
	};

	OUT getout(wchar_t outfile[]);							// �������� � �������� ���������� ������

	void Close(OUT out);									// �������� ������ ������
}