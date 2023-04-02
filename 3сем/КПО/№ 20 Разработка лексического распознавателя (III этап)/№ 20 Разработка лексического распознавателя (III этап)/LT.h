#pragma once
#include "stdafx.h"
#define LEXEMA_FIXSIZE	1			// ������������� ������ �������
#define LT_MAXSIZE		4096		// ������������ ���������� ����� � ������� ������
#define LT_TI_NULLIDX	0xfffffff	// ��� �������� ������� ���������������
#define LEX_INTEGER		't'	// ������� ��� integer
#define LEX_STRING		't'	// ������� ��� string
#define LEX_ID			'i'	// ������� ��� ��������������
#define LEX_LITERAL		'l'	// ������� ��� ��������
#define LEX_FUNCTION	'f'	// ������� ��� function
#define LEX_RETURN		'r'	// ������� ��� return
#define LEX_RUNOUT		'p'	// ������� ��� runout
#define LEX_RUNIN		'p'	// ������� ��� runin
#define LEX_FOR			'o'	// ������� ��� for
#define LEX_MAIN		'm'	// ������� ��� main
#define LEX_SEMICOLON	';'	// ������� ��� ;
#define LEX_TWOPOINT	':'	// ������� ��� :
#define LEX_COMMA		','	// ������� ��� ,
#define LEX_LEFTBRACE	'{'	// ������� ��� {
#define LEX_BRACELET	'}'	// ������� ��� }
#define LEX_LEFTTHESIS	'('	// ������� ��� (
#define LEX_RIGHTTHESIS	')'	// ������� ��� )
#define LEX_PLUS		'v'	// ������� ��� +
#define LEX_MINUS		'v'	// ������� ��� -
#define LEX_STAR		'v'	// ������� ��� *
#define LEX_DIRSLASH	'v'	// ������� ��� /
#define LEX_OPERATOR	'v'	// ������� ��� ����������
#define LEX_LOGOPERATOR 'q' // ������� ��� ���������� ����������
#define LEX_SMALL		'q' // <
#define LEX_BIG			'q' // >
#define LEX_AND			'&' // &
#define LEX_EXL			'q' // !
#define LEX_TILDA		'q' // ~
#define LEX_EQUAL		'='
#define LEX_ROOF		'^'
#define LEX_IF			'w' // ������� ������
#define LEX_VOID		'n' // ������� void
#define LEX_ENDIF		'|' // ����� �������
#define TI_NULLIDX		0xffffffff
namespace LT									// ������� ������
{
	struct Entry								// ������ ������� ������
	{
		char lexema;							// �������
		int sn;									// ����� ������ � �������� ������
		int idxTI;								// ������ � ������� ��������������� ��� LT_TI_NULLIDX
	};

	struct LexTable								// �������� ������� ������
	{
		int maxsize;							// ������� ������� ������ < LT_MAXSIZE
		int size;								// ������� ������ ������� ������ < maxsize
		Entry* table;							// ������ ����� ������� ������
	};

	LexTable Create(							// ������� ������� ������
					int size					// ������� ������� ������ < LT_MAXSIZE
					);

	void Add(									// �������� ������ � ������� ������
		LexTable& lextable,						// ��������� ������� ������
		Entry entry								// ������ ������� ������
	);

	Entry GetEntry(								//�������� ������ ������� ������
					LexTable& lextable,			//��������� ������� ������
					int n						//����� ���������� ������
				   );

	void Delete(LexTable& lextable);			// ������� ������� ������ (���������� ������)
};