grammar match_parser;

match :
	boolRule EOF
	;

boolRule:  
	  TRUE															# true
	| FALSE															# false
	| boolRule ( OR boolRule )+										# orRule
	| boolRule ( AND boolRule )+									# andRule
	| OP boolRule CP												# groupRule

	| stringValue DBLEQUALS stringPattern							# stringValueMatch
	| stringValue IN stringPatternArray								# stringValueMemberOf
	| stringValue MATCHES stringValue								# stringValueRegEx

	| stringArray MATCHES stringValue								# stringArrayRegEx
	| stringArray IN stringPatternArray								# stringArrayMemberOf
	;

stringPattern:
	  stringValue													# stringPatternSimple
	| ELIPSIS stringValue											# stringPatternOpenStart
	| stringValue ELIPSIS					 						# stringPatternOpenEnd
	| ELIPSIS stringValue ELIPSIS									# stringPatternOpen
	;

stringPatternArray: (stringArray | OSQ (stringPattern ( COMMA stringPattern )* CSQ) )+
	;

stringValue:
	stringSource+
	;

stringSource:
	  QString														# QString
	| path															# stringPath
	| path OSQ integer CSQ											# pathIndexed
	| path OSQ integer ELIPSIS CSQ									# pathIndexedOpen
	;

stringArray:
	  SOURCE DOT TYPE												# sourceType
	| TARGET DOT TYPE												# targetType
	;

path:
	  SOURCE DOT PATH												# sourcePath
	| TARGET DOT PATH												# targetPath
	;

integer: INTEGER ;
QString: SQUOTE QSTR_CHAR*? SQUOTE ;

IN: 'in' ;
PATH: 'path';
SOURCE: 'source';
TARGET: 'target';
TYPE: 'type';
MATCHES: 'matches' ;
TRUE: 'true' ;
FALSE: 'false' ;

DBLEQUALS: '==';
COMMA: ',';
DOT: '.';
SQUOTE: '\'' ;
ELIPSIS: '...' ;
OR: '||' ;
AND: '&&' ;
OP: '(' ;
CP: ')' ;
OSQ: '[';
CSQ: ']';

fragment QSTR_CHAR : ~["\\] | ESCAPE_SEQ;
fragment ESCAPE_SEQ: '\\' ['"?abfnrtv\\] ;
fragment DIGIT : [0-9] ;
fragment HEX_DIGIT : [0-9a-fA-F] ;

INTEGER: DIGIT+ ;

WS         : [ \t\r]+    -> channel(HIDDEN) ;
LINE       : '\n'        -> channel(HIDDEN);
CMT_LINE   : '--' .*? '\n'  -> channel(HIDDEN) ; 
