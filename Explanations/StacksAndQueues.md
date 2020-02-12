# Stacks and Queues

A stack is a collection of elements that supports two principle operations, push and pop. 

Stacks are last-in, first-out data structures (LIFO). In other words, the last item pushed is the first one popped. 

So if we had a stack with one item in it and we pushed another item onto the stack, followed by another, we'd have a stack with three items in it.
Pushing an item onto the stack is a constant-time operation since it doesn't matter how many items are already on the stack. 
Then we could take that stack and pop an item off to operate on it. 
And again, that's a constant-time operation. 

Queues work a little bit differently. 

So like a stack, the queue structure supports adding and removing items, but it operates in a first-in, first-out method (FIFO).
So if we had an empty queue and added an item in, it would be the first item in the list.
And queuing another item would add it to the end of the list until we had several items.
And those are also constant-time operations. 
Then items could be removed from the front of the list when they needed to be processed. 

Stacks and queues are very fundamental data structures and have broad practical applications in software development. 

Stacks, for example, are often used to parse and evaluate various forms of expression statements. 

An example of this would be using a stack to evaluate a mathematical expression that is written using reverse Polish notation. 
Stacks are also used to provide backtracking features. 
And a good example of this is when you're using the back button in your browser. 
So as you click on various links in the page, the browser adds each link to a stack in order to maintain the order in which they were visited. 
So when the user clicks on the back button, the most recently added URL is popped off the stack and then revisited. 

Queues also have some pretty common uses.
 
Order processing is a good use for a queue because it ensures that orders for a product are fulfilled in the order in that they were received by the system. 
Another good use for something like a queue is in message processing. 
When you're using your phone's SMS messenger app and entering each message, you want to make sure that each of those messages is sent in the order they were written. 
The messenger app might use a queue to maintain each message and make sure that they are sent in the order they were placed into the queue.
