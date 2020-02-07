# ProgrammingFoundations
Content of the course Programming Foundations: Algorithms by Joe Marini


The Big O notation:

|===============|=======================|===========================================================|==================================================================================|
|Notation		|Description			|Explanation												|Example														                   |
|O(1)			|Constant time			|Looking up a single elemente in array						|Big-O of one. Essentially that means that the operation in                        |
|				|						|															|question doesn't depend on the number of elements in the given data set.          |
|				|						|															|So a good example of this is calculating whether a number is even or odd,         |
|				|						|															|or looking up a specific element index in an array                                |
|===============|=======================|===========================================================|==================================================================================|
|O(log n)		|Logarithmic			|Finding an item in a sorted array with a binary search     |Log n which is called logarithmic time.                                           |
|				|						|															|And a typical example of this kind of operation is finding                        |
|				|						|															|a specific value in a sorted array using a binary search.                         |
|				|						|															|So as the number of items in the sorted array grows,                              |
|				|						|															|it only takes a logarithmic time relationship to find any given item              |
|===============|=======================|===========================================================|==================================================================================|
|O(n)			|Linear time			|Searching un unsorted array for specific value             |Big-O of n, and this level of time complexity corresponds to a typical example    |
|				|						|															|of searching for an item in an unsorted array.                                    |
|				|						|															|So as more items are added to the array in an unsorted fashion,                   |
|				|						|															|it takes a corresponding linear amount of time to perform a search                |
|===============|=======================|===========================================================|==================================================================================|
|O(n log n)		|Log-Linear				|Complex sorting algorithms like heap sort and merged sort  |Order of n times log n or what's called log-linear time complexity.               |
|				|						|															|And some good examples of this kind of operation                                  |
|				|						|															|are some sorting algorithms like heap sort and merge sort                         |
|===============|=======================|===========================================================|==================================================================================|
||O(n²)			|Quadratic				|Simple sorting algorithms,                                 |Order of n squared, which is called quadratic time complexity,                    |
|				|						|uch as bubble sort, selection sort and insertion sort		|and as you've probably guessed it's not a very good level of performance,         |
|				|						|															|because what that means is that as the number of items in the data set increases  |
|				|						|															|the time it takes to process them increases at the square of that number.         |
|				|						|															|So some examples of this type of operation are some of the simpler                |
|				|						|															|sorting algorithms like the bubble sort and the selection sort.                   |
|===============|=======================|===========================================================|==================================================================================|

