# Linked List

A linked list is a linear collection of data elements which are sometimes called nodes. 

So this is sort of like an array, but a little bit different. 

Each of these nodes have a field that points to the next element in the list. And each of these elements can contain whatever information your app needs to work with. 

So conceptually, a linked list looks like this and in this case, the nodes contain integer numbers as their data. 

The first item in the list is called the head. And each element has a field that refers to the next item in the list. 
The last item in the list has a field that points to nothing, which indicates that it is the end of the list. 

When an item in a Linked List only knows about its next neighbor, we could call this as a singly-linked list. 

But there's no reason we couldn't have a doubly linked list. In this case, each data item could have a reference to both the previous and next items that are its neighbors. 

Linked lists provide a benefit over regular arrays in that it's fast and easy to add and remove items from the list. 
And it's not necessary to reorganize the underlying memory that holds the data because the individual nodes don't have to be stored contiguously, like they do in an array. 

The main drawback of a linked list, though, is that it's not possible to do constant-time random access of any item in the list like an array can. 
Looking up an arbitrary item is linear in time complexity and it's easy to see why this is.

So to find and item that is in the end of this list, we'd first have to start at the head, and then work our way down the list until we found the item at the end. 
Other operations on lists are pretty straightforward. 

So using the same linked list, we can insert a new item into the list by placing it at the head. 

So we would set the new node's next pointer to be the current head, and then set the head to be the new node. 

And similarly, we can remove a node from the list by changing the next field of the node that points to it. 
So just by manipulating the various pointers, you can achieve the operations you need on the linked list.
