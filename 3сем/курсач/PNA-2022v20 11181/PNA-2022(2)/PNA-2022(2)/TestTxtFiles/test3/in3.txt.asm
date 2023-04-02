.586							; ������� ������ (��������� Pentium)
.model flat, stdcall			; ������ ������, ���������� � �������
includelib kernel32.lib
includelib libucrt.lib
includelib StdLib.lib

ExitProcess PROTO: dword		; �������� ������� ��� ���������� �������� Windows

EXTRN strlens: proc
EXTRN print_int: proc
EXTRN print_str: proc
EXTRN atois: proc
EXTRN adate: proc
EXTRN atime: proc

.stack 4096

.const							; ������� �������� - ��������
	L0 sdword 2747
	L1 sdword 5
	L2 sdword 9
	L3 byte "qwertyuiopasdfghjklzxcvbnm", 0
.data							; ������� ������ - ���������� � ���������
	numberh_main sdword 0
	numberb_main sdword 0
	numbero_main sdword 0
	string_main dword ?
.code							; ������� ����

;----------- MAIN ------------
main PROC

push L0
pop numberh_main

push numberh_main
call print_int

push L1
pop numberb_main

push numberb_main
call print_int

push L2
pop numbero_main

push numbero_main
call print_int

mov string_main, offset L3
push string_main
call print_str

push 0
call ExitProcess
main ENDP
end main