# What are Algorithms?

Algorithms are a set of steps that are taken together to solve some problem.  
For example: if we had only one box, with some shapes inside.  
Ellipses, triangles and rectangles.  
And we want to separate them, in order to organize it.  
How can we do this?  
Well, we could problably, iterate throught the shapes, and check what kind of shape it is, and them, put it into the correct box, something like:  

    for(each shape){
      if(shape is ellipse){
        ellipses.add(shap)
      }

      if(shape is triangle){
        triangles.add(shap)
      }

      if(shape is rectangle){
        rectangles.add(shap)
      }
    }

The iteration, the type check and the add to a new box, all this put together to solve our problem is an Algorithm.

Algorithms has some characteristicts that we could use to describe them.  
One of them is the Complexity, which usually is more than one thing.  
The complexity could be:   
Space complexity, which is, how much memory and space the algorithm needs to work.  
Time complexity, which is, how efficient the algorithm is, in relation to a given entrance data.  

Other characteristict, could be the Inputs and Outputs.  
This means:  
the algorithm accpets inputs? Of what type?  
the algorithm returns data? Of what type?  

And we could also say about the algorithm classification, using some criteria.  
For example, some algorithm could work in a with data in sequencial, which means that this algorithm is serial.  
Or it could break this data and work with it in parallel steps simultaneosly, which means that this algorithm is a parallel one.  
An algorithm could produce a know value, which means than this algorithm is an exact algorithm.  
Or it could try to find an answer, that could not be what exactly what we wanted, which means that this is an aproximate algorithm.  
We could have an deterministc algorithm, which is an algorithm that executes each step with an exact decision.  
Or it could be a non deterministc, which means that this algorithm tries to produce a result, and throught successives guesses which became more accurate during the time.  


There are some most common types of algorithms.  
Types like:
- Search algorithm: where you try to find some specific data in a structure, like a substring within a string
- Sorting algorithm: where you take a dataset and apply a sort order to it
- Computacional algorithm: where, given one set of data, you try to calculate another, like try to find prime numbers
- Collection algorithm: where you work with collections of data, like count specific itens, navigate throught data elements, filter data and so on




# Good to know
- An algorithm that takes eight times longer to operate on a data set that is twice as large is said to be cubic in time.
- Question:
  Which classifications apply to Euclid's algorithm for finding the least common denominator? 
  Answer:
  exact and deterministic
- An algorithm that is deterministic always produces the same outputs from a given set of inputs .

- Question: Why are hash tables favored over arrays or linked lists?  
  Answer: Because they are faster for large data sets.
  
- Question: What is the order in which elements are popped from a stack?  
  Answer: Last in, first out, or first in, last out

- Question: Why are linked lists sometimes preferred over arrays?  
  Answer: They are easier and faster to reorganize.
  
- Question: How many elements are in an [8,3,2] array?  
  Answer: 48
  
- Question: Which data structure is most analogous to a dictionary?  
  Answer: A hash table
  
  
- Question: Which is the defining property of a recursive function?   
  Answer: It calls itself.
