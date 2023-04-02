#pragma once
#include "stdafx.h"

using namespace std;

int wmain(int argc, wchar_t* argv[])
{
	setlocale(LC_ALL, "rus");

	Log::LOG log;
	Out::OUT out;
	try
	{

		Parm::PARM parm = Parm::getparm(argc, argv);				// ��������� ������� ����������
		log = Log::getlog(parm.log);								// �������� ���������� ������ � ��������
		Log::WriteLog(log.stream);									// ����� ��������� ���������
		Log::WriteParm(log.stream, parm);							// ����� � �������� ���������� � ������� ����������


		In::IN in = In::getin(parm.in);								// ��������� ���������� �� ����� (�������� ������ �������� � �.�.)
		Log::WriteIn(log.stream, in);								// ����� � �������� ���������� � ������� IN ����� 


		LT::LexTable lex(LT_MAXSIZE);								// ��������� ������ ��� ������� ������
		IT::IdTable id(TI_MAXSIZE);									// ��������� ������ ��� ������ ���������������

		//����������� ������
		LexAnalysis(in, lex, id);
		Log::WriteLine(&std::cout, "����������� ������ �������� ��� ������", "");
		Delete(in);

		//�������������� ������
		MFST_TRACE_START(log.stream)
			MFST::MFST sintaxAnaliz(lex, GRB::getGreibach());
		bool syntax_ok = sintaxAnaliz.start(log.stream);
		if (!syntax_ok)
		{
			Log::WriteLine(&std::cout, "�������������� ������ �������� � ��������\n", "���������� ��������� �����������", "");
			//throw ERROR_THROW(600);
			return 0;

		}
		Log::WriteLine(&std::cout, "�������������� ������ �������� ��� ������", "");
		sintaxAnaliz.printRules(log.stream);


		//������������� ������ 
		SM::semAnaliz(lex, id);
		Log::WriteLine(&std::cout, "������������� ������ �������� ��� ������", "");


		//��������� � ���������
		out = Out::getout(parm.out);										// 	�������� ���������� ������ � �������� ���� OUT
		GN::GenerationASM(out.stream, lex, id);
		Log::WriteLine(&std::cout, "\n��������� ������� ���������!", "");

		PrintIdTable(id, L"Table");
		PrintLexTable(lex, L"Table");

		Delete(lex);
		Delete(id);
		Out::Close(out);
		Log::Close(log);
	}

	catch (Error::ERROR e)
	{
		cout << "������ " << e.id << ": " << e.message << endl << endl;
		return e.id;
	}

	return 0;
}
