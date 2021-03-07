: abs ( n -- +n )
	dup 0 < if
		negate
	endif ;

: min ( n1 n2 -- n)
	2dup < if
		drop
	else
		nip
	endif ;

5 abs .
-5 abs .

2 3 min .
3 2 min .
