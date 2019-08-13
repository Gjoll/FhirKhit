grammar CIMPLMap;

map:
    target (end (arg | command))* end?  EOF
	;

target: Name ;
arg: Name EQ value+ ;
command: Name OP (value (COMMA value))? CP ;
value: Name | QString ;
end: (SEMICOLON | LF)+;

CONT: '\\' '\n' ;
DQUOTE: '\"' ;
OP: '(' ;
CP: ')' ;
EQ: '=' ;
LF: '\n' ;
COMMA: ',';

Name: NAMECHARS+ ;
QString: DQUOTE QSTR_CHAR*? DQUOTE ;

fragment QSTR_CHAR : ~["\\] | ESCAPE_SEQ;
fragment ESCAPE_SEQ: '\\' ['"?abfnrtv\\] ;
fragment DIGIT : [0-9] ;
fragment HEX_DIGIT : [0-9a-fA-F] ;
fragment NAMECHARS: [A-Za-z] [A-Za-z0-9]* ;

INTEGER: DIGIT+ ;
SEMICOLON: ';' ;
WS         : [ \t\r]+ -> channel(HIDDEN) ;
LINE       : CONT -> channel(HIDDEN);
CMT_LINE   : '--' .*? '\n' -> channel(HIDDEN) ; 
