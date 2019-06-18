# Collatz Conjecture

From [Wikipedia](https://en.wikipedia.org/wiki/Collatz_conjecture)

> The Collatz conjecture is a conjecture in mathematics that concerns a sequence defined as follows: 
> start with any positive integer n. 
> Then each term is obtained from the previous term as follows: 
> if the previous term is even, the next term is one half the previous term. 
> If the previous term is odd, the next term is 3 times the previous term plus 1. 
> The conjecture is that no matter what value of n, the sequence will always reach 1.

## What to do
1. Take any positive integer x
1. In case if it is even, divide it by two, otherwise triple it and add 1
1. Repeat step 2 until you reach 1

## Extra
* Both recursive and iterative approach
* Count how many iterations it takes for x to converge to 1

## Solutions
### Ruby
* [iterative one-liner](https://github.com/sigarettenenkoffie/CodingDrills/blob/master/Collatz%20conjecture/Iterative.rb)

