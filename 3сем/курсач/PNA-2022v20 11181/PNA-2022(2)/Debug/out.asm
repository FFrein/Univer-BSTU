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
	L0 sdword 5
	L1 sdword 1
.data							; ������� ������ - ���������� � ���������
	i_main sdword 0
	nowtime_main sdword 0
.code							; ������� ����

;----------- MAIN ------------
main PROC

call atime
push eax
pop nowtime_main

push nowtime_main
call print_int

cyclenext0:
mov edx, i_main
cmp edx, L0
jg cycle0
push i_main
call print_int

push i_main
push L1
pop ebx
pop eax
add eax, ebx
push eax
pop i_main

jmp cyclenext0
cycle0:

push 0
call ExitProcess
main ENDP
end main