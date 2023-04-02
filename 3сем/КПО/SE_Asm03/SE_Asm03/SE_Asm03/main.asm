.586P														; ������� ������ (��������� Pentium)
.MODEL FLAT, STDCALL										; ������ ������, ���������� � �������
includelib kernel32.lib										; ������������: ����������� � kernel32

ExitProcess PROTO : DWORD									; �������� ������� ��� ���������� �������� Windows
MessageBoxA PROTO : DWORD, : DWORD, : DWORD, : DWORD		; �������� API-������� MessageBoxA

.STACK 4096													; ��������� �����

.CONST														; ������� ��������

.DATA														; ������� ������							; EQU ���������� ���������
	myBytes			BYTE		10h, 20h, 30h, 40h
	myWords			WORD		8Ah, 3Bh, 44h, 5Fh, 99h
	myDoubles		DWORD		1, 2, 3, 4, 5, 6, 0
	myPointer		DWORD		myDoubles	
	Sum				DWORD	0

	WINDOWNAME		db		"������ ��������� �� ����������", 0
	Res1			db		"� ������� ���� 0", 0
	Res2			db		"� ������� ��� ����", 0
				
.CODE

main PROC													; ����� ����� main
START	:													; �����
	   
	mov EBX, myPointer
	mov EAX, [EBX + 8]
	mov EDX, [EBX]

	mov ESI, OFFSET myDoubles									;���������� ������ �� ������ � �������
	mov ECX, lengthof myDoubles									;������ ������ ������� � ECX
	mov EBX, 1												;������� � EBX 0 �� ������� ������
	
CYCLE:
	mov EAX, [ESI]											;������ ������� �� �������
	add Sum, EAX
	add ESI, type myDoubles										;�������� ������� �� ��������� ����� � �������
	cmp EAX, 0												;��������� ��� � ������� ����� ���� �� 0
	jz ZERO													;�����������, ���� ���������� ������ ����� ��������� true
	loop CYCLE												;--ECX, if (ECX != 0) goto CYCLE
	jmp NOZERO

ZERO:
	mov EBX, 0
	jz QUEST1

NOZERO:
	mov eax, Sum
	jnz QUEST2

QUEST1:
	invoke MessageBoxA, 0, OFFSET Res1, OFFSET WINDOWNAME, 1
	jz FINAL

QUEST2:
	invoke MessageBoxA, 0, OFFSET Res2, OFFSET WINDOWNAME, 1
	jz FINAL

FINAL:
	push - 1												; ��� �������� �������� Windows(�������� ExitProcess)
	call ExitProcess										; ��� ����������� ����� ������� Windows
main ENDP													; ����� ���������
			
end main													; ����� ������ main