.586P														; система команд (процессор Pentium)
.MODEL FLAT, STDCALL										; модель памяти, соглашение о вызовах
includelib kernel32.lib										; компановщику: компоновать с kernel32

ExitProcess PROTO : DWORD									; прототип функции для завершения процесса Windows
MessageBoxA PROTO : DWORD, : DWORD, : DWORD, : DWORD		; прототип API-функции MessageBoxA

.STACK 4096													; выделение стека

.CONST														; сегмент констант

.DATA														; сегмент данных							; EQU определяет константу
	myBytes			BYTE		10h, 20h, 30h, 40h
	myWords			WORD		8Ah, 3Bh, 44h, 5Fh, 99h
	myDoubles		DWORD		1, 2, 3, 4, 5, 6, 0
	myPointer		DWORD		myDoubles	
	Sum				DWORD	0

	WINDOWNAME		db		"Третяя программа на ассемблере", 0
	Res1			db		"В массиве есть 0", 0
	Res2			db		"В массиве нет нуля", 0
				
.CODE

main PROC													; точка фхода main
START	:													; метка
	   
	mov EBX, myPointer
	mov EAX, [EBX + 8]
	mov EDX, [EBX]

	mov ESI, OFFSET myDoubles									;записываем ссылку на массив в регистр
	mov ECX, lengthof myDoubles									;запись длинны массива в ECX
	mov EBX, 1												;заносим в EBX 0 по условию задачи
	
CYCLE:
	mov EAX, [ESI]											;достаём элемент из массива
	add Sum, EAX
	add ESI, type myDoubles										;сдвигаем адрресс на следующее число в массиве
	cmp EAX, 0												;проверрка что в массиве число было не 0
	jz ZERO													;выполняется, если предыдущая строка выдаёт результат true
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
	push - 1												; код возврата процесса Windows(параметр ExitProcess)
	call ExitProcess										; так завершается любой процесс Windows
main ENDP													; конец процедуры
			
end main													; конец модуля main