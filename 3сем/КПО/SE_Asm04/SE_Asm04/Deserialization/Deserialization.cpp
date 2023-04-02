#include <iostream>
#include <string>
#include <cstring>
#include <fstream>

#define TYPE_BOOL "0x01"
#define TYPE_INT "0x02"
#define OutFileAdress 
#define ASM_Start ".586P\n.MODEL FLAT, STDCALL\nincludelib kernel32.lib\n\nExitProcess PROTO : DWORD\nMessageBoxA PROTO : DWORD, : DWORD, : DWORD, : DWORD\n\n"
#define ASM_STACK ".STACK 4096\n\n"
#define ASM_CONST ".CONST\n\n"
#define ASM_DATA ".DATA\n"
#define ASM_CODE ".CODE\n\n"
#define ASM_MAIN "main PROC\npush -1\n call ExitProcess\n\nmain ENDP\n\nend main\n"

using namespace std;

void main() {
	string buff;

	fstream readF("C:/MyFile/Универ/3сем/КПО/SE_Asm04/SE_Asm04/SE_Asm04/File.txt", ios::in);

	fstream asmF("C:/MyFile/Универ/3сем/КПО/SE_Asm04/SE_Asm04/ASM/Main.asm", ios::out);
	if (readF.is_open())
	{
		asmF << ASM_Start << ASM_STACK << ASM_CONST << ASM_DATA;
		while (getline(readF, buff))
		{

			int bool_counter = 1;
			int int_counter = 1;
			if (buff.find("0x010x") != std::string::npos) {
				buff.erase(0, 6);
				asmF << "Bool" << bool_counter << "\t" << "byte\t" << stoi(buff, 0, 16) << "\n";
				int_counter++;
			}
			if (buff.find("0x020x") != std::string::npos) {
				buff.erase(0, 6);
				asmF << "int" << int_counter << "\t" << "dword\t" << stoi(buff, 0, 16) << "\n";
				int_counter++;
			}
		}
		asmF << "\n" << ASM_CODE << ASM_MAIN;
		asmF.close();
		readF.close();
	}
}