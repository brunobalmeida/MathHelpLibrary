# MathHelpLibrary
A basic Math Help Library with a couple basic math functions that are not included in the C#Math Library
This is a simple project that I always wanted to start. Please, feel free to contribute fixing bugs, enhancing the code, of giving me suggestions of more functions to be inserted here. It starting with 5, but there is much more to do. 

Author: Bruno P B Almeida
Email: dbrunob@gmail.com
GitHub: https://github.com/brunobalmeida
LinkedIn: https://www.linkedin.com/in/brunobalmeida/


This is a basic Math library with some methods that are not included in the C# Math library. Each method has its own documentation comments explaining how it works. 

#The Methods are: 

#Factorial 

Receives an integer as argument and returns a double as the factorial of that number. 
Factorial of a number, ex:
5! = 5*4*3*2*1 = 120
10! = 10*9*8*7*6*5! 


#Number of SubGroups 

Given a specific group of n elements, how many subgroups of p elements are contained within it? 
The method gets to integers n and p and returns a double as the number of possible subgroups that can be formed from n elements.

#Greatest common divisor 

This method returns the greatest common divisor between two numbers.
Ex: GCD of 20 and 16 is 4. 

#Lowest Common Multiple 

This method returns the lowest common multiple between two numbers
Note: This requires the Greatest common divisor to work. 

Ex: The LCM of 3 and 4 is 12. 

#Second degree equation solver. 

This method solves a second degree equation. 
The equation needs to be written on the following format: 
ax² + bx + c = 0; The arguments received by the methods are: a, b and c in that order. 

The function will return an array with three numbers:
1- The first (index 0) is the number of solutions that equation has. 
If result[0] = 0, then the equation has no real solution. 

Else if result[0] = 1, then the equation has one solution and it is stored in the second index result[1]. 
It is important to state that in this case the last number will be zero, but it DOES NOT MEAN that zero is a solution. 

Then if result[0] = 2, the next two numbers of the array will be the solutions for the equation. 

