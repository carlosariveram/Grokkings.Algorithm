# Algorithms test projects

Currently I am reading the book Algorithms "An illustrated guide for programmers and other curious people". This project aims to test each of the algorithms studied and validate the eficiency against their regular counterparts.

The algorithms currently tested are:
- Chapter 1: Binary Search

The running time of a regular search where each element needs to be checked is of O(n) and for binary search is of O(log n), that means that when the amount of element in the array increases binary seach will be a lot more efficient if compare to a regular search.

- Chapter 2: Selection Sort

Execution time of this algorithm is of O(n^2). Which means that in the same way the array length increases, the execution time of the algorithm grows exponentially.

- Chapter 3: Introduction to recursions

In this chapter recursions are being presented as a medium to simplify code readbility and will be the base of other data structures and algorithms. In the code we can see a very simple scenario where recursions can be used. We must observe that recursions do not optimize the code, actually its performance is one of their disadvantages when compare with regular loops.

- Chapter 4: D & C - Divide and Conquer

Divide and conquer is a strategy to create algorithms that aims to solve problems by dividing them in smallest issues which are easier to solve. In chapter 4 we will see the implementation of Euclid's algorithm to find the Greatest Common Divisor and Quicksort algorithm.  
Divide and conquer uses recursion very deeply by dividing the problem in a base case (where the recursion breaks) and the recursion scenario (the simplified version of the problem).  
Defined the following functions using D&C approach:  
a. Sums the elements of an array.  
b. Count the number of elements in a list.  
c. Find the maximum number in a list.  
  
Quicksort algorithm