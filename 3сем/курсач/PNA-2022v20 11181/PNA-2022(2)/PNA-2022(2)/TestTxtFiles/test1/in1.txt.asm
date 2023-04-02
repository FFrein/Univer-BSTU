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
	L1 sdword 0
	L2 sdword 4
.data							; ������� ������ - ���������� � ���������
	callf_main sdword 0
.code							; ������� ����

;----------- inttypes ------------
inttypes PROC,	ccc_inttypes : sdword  
; --- ��������� �������� ---
push ebx
push edx
; ----------------------
mov edx, L0
cmp edx, ccc_inttypes

jg true0
jl false0
true0:
push L0
call print_int

jmp next0

false0:
push ccc_inttypes
call print_int

next0:

; --- ������������ �������� ---
pop edx
pop ebx
; -------------------------
mov eax, L1
ret
inttypes ENDP
;------------------------------


;----------- MAIN ------------
main PROC

push L2
call inttypes
push eax
pop callf_main

push 0
call ExitProcess
main ENDP
end main