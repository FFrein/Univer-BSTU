.586P
.MODEL FLAT, STDCALL
includelib kernel32.lib

ExitProcess PROTO : DWORD
MessageBoxA PROTO : DWORD, : DWORD, : DWORD, : DWORD

.STACK 4096

.CONST

.DATA
Bool1	byte	1
int1	dword	500

.CODE

main PROC
push -1
 call ExitProcess

main ENDP

end main
