.586
.model flat, stdcall
includelib kernel32.lib
includelib libucrt.lib
ExitProcess PROTO: DWORD
…
EXTRN getmin: proc
…
 push lengthof massiv 
 push offset massiv 
 call getmin


 ;https://learn.microsoft.com/ru-ru/cpp/c-runtime-library/crt-library-features?view=msvc-170