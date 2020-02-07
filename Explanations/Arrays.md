# Array Operations

- Calculate item index: O(1)
  Calculating an item index is a constant-time operation, since it just involves a mathematical calculation and is not dependent on how many items are in the array

- Insert or delete an item at beggining: O(n)
- Insert or delete an item in the midle: O(n)
  Some languages don't allow arrays to grow or shrink, but in those that do, inserting or deleting an item at the beginning takes order n, or linear, time complexity, as does performing those operations on items in the middle, since the remaining items must be moved to their new memory locations. 

- Insert or delete an item at end: O(1)
  Performing an insert or delete at the end can usually be done in constant time.