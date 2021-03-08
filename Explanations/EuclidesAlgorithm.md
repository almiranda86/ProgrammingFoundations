# EUCLIDES ALGORITHM

Find the greatest common denominator (GCD) of two integers.

Example:   
GCD of 20 and 8 is 4   
because 8/4 is 2 and 20 / 4 is 5

| GCD (20, 8) |             |             |
|------------	|------------	|------------	|
|a            |b            |r            |
|20           |8            |4            |
|8            |4            |0            |


 # Steps
 1. For two integers, a and b, where a > b, divide a by b.   
 2. If the remainder, r, is 0, than STOP. GCD is b.
 3. Else, set a to b, b to r, and repeate step 1 until r is 0.
