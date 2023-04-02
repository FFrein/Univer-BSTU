#include "stdafx.h"

using namespace std;


int _tmain(int argc, _TCHAR* argv[]) {
	setlocale(LC_ALL, "russian");

	cout << "---- тест getparm ----" << endl;
	try
	{
		Parm::PARM parm = Parm::getparm(argc, argv);
		wcout << "-in:" << parm.in << ", -out:" << parm.out << ", -log:" << parm.log << endl << endl;
	}
	catch (Error::ERROR e)
	{
		cout << "ID: " << e.id << " Сообщение: " << e.message << " Строка: " << e.inext.line << " Позиция:" << e.inext.col << endl;
	}


	cout << "\n---- тест getin----" << endl;
	try
	{
		Parm::PARM parm = Parm::getparm(argc, argv);
		In::IN in = In::getin(parm.in);
		cout << in.text << endl;
		cout << "Всего символов: " << in.size << endl;
		cout << "Всего строк: " << in.lines << endl;
		cout << "Пропущено: " << in.ignore << endl;
	}
	catch (Error::ERROR e)
	{
		cout << "ID: " << e.id << " Сообщение: " << e.message << " Строка: " << e.inext.line << " Позиция:" << e.inext.col << endl;
	}

	cout << "\n---- тест LexAnalysis(LT&IT&LexAnalysis)----" << endl;
	try
	{
		Parm::PARM parm = Parm::getparm(argc, argv);
		In::IN in = In::getin(parm.in);
	}
	catch (Error::ERROR e)
	{

	}


	cout << "\n-----------------------Конец тестов---------------------------\n" << endl;

	Log::LOG log = Log::INITLOG;
	Parm::PARM parm = Parm::getparm(argc, argv);
	Out::OUT out = Out::getout(parm.out);
	try
	{

		log = Log::getlog(parm.log);
		Log::WriteLine(log, (char*)"Тест", (char*)" без ошибок \n", "");
		Log::WriteLine(log, (wchar_t*)L"Тест", (wchar_t*)L" без ошибок \n", L"");
		Log::WriteLog(log);
		Log::WriteParm(log, parm);
		In::IN in = In::getin(parm.in);
		Log::WriteIn(log, in);
		Out::WriteOut(in, parm.out);

		LT::LexTable lexTable;
		IT::IdTable	idTable;

		LA::FindLex(in, lexTable, idTable);

		//lexTable.PrintLexTable(L"TableOfLexems.txt");
		//idTable.PrintIdTable(L"TableOfIdentificators.txt");

		//LT::Delete(lexTable);
		//IT::Delete(idTable);

		Log::Close(log);
		Out::Close(out);
	}
	catch (Error::ERROR e)
	{
		Log::WriteError(log, e);
		Out::getout(parm.out);
		Out::WriteError(out, e);
		Out::Close(out);
	};
	system("pause");

	return 0;
}
