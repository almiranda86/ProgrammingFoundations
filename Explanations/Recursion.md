# Recursion

There's one more programming technique and that's a technique known as recursion. 

And in its simplest form recursion is when a function calls itself from within its own code. 

Now, that might seem strange at first glance, after all why would you want to write a function that calls itself? 

But it turns out that this kind of programming pattern appears in multiple scenarios in the real world.

Suppose for example, your program needed to find a particular file that's nestled somewhere within a set of directories. 
And your program doesn't know how many programs there are, and of course these directories can contain other directories, and so on. 
So what algorithm would you use to search for the file? 

Well one possibility might look like this:

You start off by making a list of the items that are in the current directory, and then while that list isn't empty you get an item from that list, and if that item is the file that you're looking for, well, congratulations, you're done! 
Otherwise, if it's a directory, you add all the items in that directory to the list and then you go back to step two and you repeat this until you found the file or you've exhausted all the items in the list. 
Now, another approach might be, you loop over every item in the directory and you look at each item, and if that item is the file, then you're done. 
Otherwise, you go back to step one and loop over every item in the directory that you just found. 
And then this process will repeat until you've found the file or you visited every directory. 

The second approach is much easier to implement because you're essentially reusing the logic you already have for searching a directory each time you encounter one, and you don't have to keep track of this global list of items. 

So there are a few important things to remember about recursion. 
First, it's important to make sure that your recursive function actually terminates and returns at some point. 
And this is called the breaking condition. 
Otherwise the code will get into an infinite loop, and eventually crash the program because the computer will run out of memory to keep track of all the nested function calls. 
Also, each time the function is called, remember that the values of the arguments of the previous call are stored aside. 
They're not written over by the new call. 
And this is accomplished by what's known as the call stack. 
And if you're wondering, the answer is yes. 
This is implemented using a stack data structure. 

So, let's look at an example. 
Suppose we have a function named countdown, which will print a countdown of numbers starting with initial number, and you can see that the function checks to see if the argument x is equal to zero, in which case it prints a done message and then returns. 
So this is the breaking condition right here. 
Otherwise it prints the number and then calls itself with the current number minus one. 
So if we look at the call stack for each of these function calls, we start off with the initial call where x is four. 
No, x is not zero, so the number is printed, and then the function is called again. 
And now we have a stack where the initial call is equal to four and now x is three. 
So the previous call is pushed onto the call stack, and then this happens again when x is two, and then again when x is one, and then one more time when x is zero. 
Now at this point the breaking condition is met, and the function returns, which then will cause all of the previous function calls to return, and the stack is unwound back to the beginning.
