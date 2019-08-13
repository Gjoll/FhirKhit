grammar map_parser;

map:  
	(mapCommand  SEMICOLON)* EOF
	;

mapCommand:
	  ABORT OP stringValue CP									# abortCommand
	| MESSAGE OP stringValue CP									# messageCommand
	| EXTENSION OP CP											# extensionImplicitCommand
	| EXTENSION OP stringValue COMMA stringValue CP				# extensionExplicitCommand
	| IGNORE OP CP												# ignoreCommand
	| mapNewElement												# mapNewElementCommand
	;

mapNewElement:
	  OVERWRITE OP CP											# overwrite
	| UPDATE OP CP												# updateCommand
	| SLICE OP ( stringValue ( COMMA fhirElement)? )? CP		# sliceCommand
	;

fhirElement:
	CODING OP stringValue COMMA stringValue (COMMA stringValue)? CP	# fhirElementCoding
	;

stringValue:
	  QString									# stringValueQString
	| FIELDTERMINOLOGYSOURCE					# stringValueFieldTermSource
	| FIELDTERMINOLOGYID						# stringValueFieldTermId
	;

SQUOTE: '\'' ;
OC: '{' ;
CC: '}' ;
OP: '(' ;
CP: ')' ;
COMMA: ',';

QString: SQUOTE QSTR_CHAR*? SQUOTE ;

fragment QSTR_CHAR : ~["\\] | ESCAPE_SEQ;
fragment ESCAPE_SEQ: '\\' ['"?abfnrtv\\] ;
fragment DIGIT : [0-9] ;
fragment HEX_DIGIT : [0-9a-fA-F] ;

ABORT: 'Abort' ;
CODE: 'code' ;
CODING: 'coding' ;
DISPLAY: 'display' ;
EXTENSION: 'Extension' ;
FIELDTERMINOLOGYSOURCE: 'FieldTerminologySource' ;
FIELDTERMINOLOGYID: 'FieldTerminologyId' ;
IGNORE: 'Ignore' ;
MESSAGE: 'Message' ;
OVERWRITE: 'Overwrite' ;
SLICE: 'slice' ;
SYSTEM: 'system' ;
UPDATE: 'Update' ;
VERSION: 'version' ;

INTEGER: DIGIT+ ;
SEMICOLON: ';' ;
WS         : [ \t\r]+ -> channel(HIDDEN) ;
LINE       : '\n' -> channel(HIDDEN);
CMT_LINE   : '--' .*? '\n' -> channel(HIDDEN) ; 
