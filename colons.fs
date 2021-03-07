( the comment before the -- describes the first stack)

: squared ( n -- n^2 )
	dup * ;

: cubed ( n -- n^3 )
	dup squared ;

5 squared .
7 squared .
