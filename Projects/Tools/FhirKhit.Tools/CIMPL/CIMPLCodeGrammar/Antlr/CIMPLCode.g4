grammar CIMPLCode;

code: items* EOF ;
items:
	text									
 |	item
 |  qStringQuotes

 ;

text:
	TextChars
 |  WS
 |	OP
 |	CP
 |	EQ
 |	LF
 |	COMMA
 |	DBLPER
 ;

item:
	PER TextChars PER												# macro
 |	PER TextChars OP (qString (COMMA qString)* )? CP PER			# command
 ;

qStringQuotes:  qString;
qString:  DQUOTE qStringItem* DQUOTE;
qStringItem: text | item;

DQUOTE: '\"' ;
OP: '(' ;
CP: ')' ;
EQ: '=' ;
LF: '\n' ;
COMMA: WS* ',' WS*;
DBLPER: '%%' ;
PER: '%' ;
TextChars: ~[%()"]+;

WS: ' ' | '\t' | '\n' | '\r' ;
fragment QSTR_CHAR: ~["\\] | ESCAPE_SEQ;
fragment ESCAPE_SEQ: '\\' ['"?abfnrtv\\] ;
