# Hash tables

In some languages, they call it dictionaries.

A hash table is a form of what's called an associative array. 
It's a data structure that maps keys to their associated values, and it does this using what's called a hash function. 
This function uses the key to compute an index into the slots that are in the hash table and map the key to the value. 

Now, ideally, the hash function will assign each key to a unique slot in the table where the values are stored. 
In reality, sometimes there are collisions in which two separate keys each map to the same slot in the table. 
And in that case, the hash table has to have a way of resolving those collisions so that the correct value is mapped to the right key. 

That's a bit of a complex subject, so we're not going to see how hash functions work and how collisions are resolved. 
Most languages and frameworks already have hash table data structures that have all of these figured out already. 

For the purpose of this content, what's important is that we understand how hash tables are used and what their advantages and drawbacks are. 

One of the primary benefits of hash tables is their ability to uniquely map a given key to a specific value. 
This feature provides the ability to implement certain kinds of algorithms which we will demonstrate, such as counters and filters. 
Another advantage of hash tables is their speed. 
They are typically faster than other kinds of table lookup structures, particularly when the number of entries is large. 

They do have some drawbacks, however. 
If the number of entries in the hash table are small, then it might be more efficient to just use a regular array or a linked list, because there won't be any collisions to resolve. 
Also, hash tables don't usually order their entries in any particular way, so unless we want to incur the cost of a separate sorting step, they may not be able to efficiently enumerate entries that are close to a given key since the data might be spread out randomly in the system's memory. 
