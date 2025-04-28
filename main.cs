// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        // PROBLEM 1
        
        /*
        
        Check if a number is positive, negative, or zero.
        ➔ Hint: Use if-else to compare with 0.
        
        
        int num = 4;
        
        if(num > 0){
            Console.WriteLine("number is positive");
        }
        
        else if(num == 0){
            Console.WriteLine("number is zero");
        }
        
        else{
            Console.WriteLine("number is negative");
        }
        
        */
        
        // PROBLEM 2 
        
        /*
        
        Check if a number is even or odd.
        ➔ Hint: Use modulo % 2 operator.

        
        
        int num = 2;
        
        if(num % 2 == 0){
            Console.WriteLine("number is even");
        }
        else{
            Console.WriteLine("number is odd");
        }
        
        */
        
        // PROBLEM 3
        
        /*
        
        Find the maximum of two numbers.
        ➔ Hint: Compare using if-else.
        
        
        
        int num1 = 2;
        int num2 = 3;
        
        if(num2 > num1){
            Console.WriteLine("num2 is greater than num1");
        }
        else if(num2 == num1){
            Console.WriteLine("num2 is equal to num1");
        }
        else{
            Console.WriteLine("num1 is greater than num2");
        }
        
        */
        
        
        // PROBLEM 4
        
        /*
        
        Find the minimum of two numbers.
        ➔ Hint: Compare using if-else.
        
        
        
        int num1 = 2;
        int num2 = 3;
        
        if(num2 < num1){
            Console.WriteLine("num2 is less than num1");
        }
        else if(num2 == num1){
            Console.WriteLine("num2 is equal to num1");
        }
        else{
            Console.WriteLine("num1 is less than num2");
        }
        
        */
        
        // PROBLEM 5
        
        /*
        
        Print numbers from 1 to 10 using a loop.
        ➔ Hint: Use a while or for loop.
        
        int i = 1;
        while(i <= 10){
            Console.WriteLine(i);
            i++;
        }
        
        */
        
        // PROBLEM 6
        
        /*
        
        Print even numbers from 1 to 20.
        ➔ Hint: Check if number is divisible by 2.
        
        int i = 1;
        
        while(i <= 20){
            if(i % 2 == 0){
                Console.WriteLine(i);
            }
            i++;
        }
        */
        
        // PROBLEM 7
        
        /*
        
        Find the sum of numbers from 1 to n.
        ➔ Hint: Add numbers inside a loop.
        
        
        
        int total = 0;
        int i = 1;
        int n = 10;
        
        while(i <= n){
            total += i;
            i++;
        }
        
        Console.WriteLine(total);

        */
        
        // PROBLEM 8
        
        /*
        
        Display the multiplication table of a given number.
        ➔ Hint: Multiply inside a loop.
        
        
    
        int num = 2;
        int counter = 100;
        
        for(int i = 0; i <= counter; i++){
            Console.WriteLine($"{num} x {i} = {num * i}");

        }
        
        */
        
        
        // PROBLEM 9
        
        /*
        
        Input age and check if eligible to vote (18+).
        ➔ Hint: Use if-else statement.
        
        int age = 18;
        if(age >= 18){
            Console.WriteLine("Eligible to vote");
        }
        */
        
        // PROBLEM 10
        
        /*
        
        Check if a number is divisible by 5.
        ➔ Hint: Use % 5 operator.
        
        
        
        int num = 3122;
        
        if(num % 5 == 0){
            Console.WriteLine("Number is divisible by 5");
        }
        else{
            Console.WriteLine("Number is not divisible by 5");
        }
        
        */
        
        
        // PROBLEM 11
        
        /*
        
        Check if a number is divisible by 3 and 5.
        ➔ Hint: Combine two conditions using &&.
        
        
        
        int num = 93;
        
        if(num % 3 == 0 && num % 5 == 0){
            Console.WriteLine("Number is divisible by 3 and 5");
        }
        else{
            Console.WriteLine("Number is not divisible by 3 and 5");
        }
        
        */
        
        // PROBLEM 12
        
        /*
        
        Find the square of a number.
        ➔ Hint: Multiply the number by itself.
        
        int num = 3;
        
        Console.WriteLine(num *= num);
        
        */
        
        // PROBLEM 13
        
        /*
        
        Find the cube of a number.
        ➔ Hint: Multiply the number three times.
    
        int num = 3;
        
        Console.WriteLine(num * num * num);
        
        */
        
        // PROBLEM 14
        
        /*
        
        Check if two numbers are equal.
        ➔ Hint: Use == operator.
        
        
        
        int num1 = 3, num2 = 3;
        
        if(num1 == num2){
            Console.WriteLine("numbers r equal");
        }
        else{
            Console.WriteLine("not equal");
        }
        
        */
        
        // PROBLEM 15
        
        /*
        
        Find the absolute value of a number.
        ➔ Hint: If number is negative, make it positive.
        
        
        int num = 5;
        
        int absnum = Math.Abs(num);
        
        Console.WriteLine(absnum);
        
        */
        
        // PROBLEM 16
        
        /*
        
        Input two numbers and swap them (without third variable).
        ➔ Hint: Use addition and subtraction to swap
        
        int a = 10;
        
        int b = 5;
        
        a = a + b; // 15
        b = a - b; // 10
        a = a - b; // 5
        
        Console.WriteLine("A is " + a);
        Console.WriteLine("B is " + b);
        
        */ 
        
        // PROBLEM 17
        
        /*
        
        Find the largest among three numbers.
        ➔ Hint: Use nested if-else.
        
        int a = 5, b = 10, c = 6;
        
        if (a > b && a > c){
            Console.WriteLine($"Largest: {a}");
        }
        else if (b > a && b > c){
            Console.WriteLine($"Largest: {b}");
        }
        else{
            Console.WriteLine($"Largest: {c}");
        }
        
        */
        
        // PROBLEM 18
        
        /*
        
        Print numbers from 10 down to 1.
        ➔ Hint: Use a decrementing loop.
        
        
        
        for(int i = 10; i >= 1; i--){
            Console.WriteLine(i);
        }
        
        */
        
        // PROBLEM 19
        
        /*
        
        Input marks and determine pass or fail (pass >= 75).
        ➔ Hint: Compare input with 75.

        int grade = 75;
        
        if(grade >= 75){
            Console.WriteLine("Pasado");
        }
        else{
            Console.WriteLine("Bagsak");
        }
        
        */
        
        // PROBLEM 20
        
        /*
        
        Display "Hello World" 5 times.
        ➔ Hint: Use a loop to print multiple times.
        
        for(int i = 0; i < 5; i++){
            Console.WriteLine("Hello World");
        }
        
        */
        
        // PROBLEM 21
        
        /*
        
        Find the sum of even numbers from 1 to 50.
        ➔ Hint: Add only if number % 2 == 0.

        
        
        int counter = 0;
        
        for(int i = 0; i <= 50; i++){
            if(i %2 == 0){
                Console.WriteLine($"{i}");
                Console.WriteLine($"{counter} + {i} = {counter += i}");
            }
        }
        
        Console.WriteLine($"Total is {counter}");
        
        */
        
        // PROBLEM 22
        
        /*
        
        Find the sum of odd numbers from 1 to 50.
        ➔ Hint: Add only if number % 2 != 0.
        
        
        
        int counter = 0;
        
        for(int i = 0; i <= 50; i++){
            if(i %2 != 0){
                Console.WriteLine($"{i}");
                Console.WriteLine($"{counter} + {i} = {counter += i}");
            }
        }
        
        Console.WriteLine($"Total is {counter}");
        
        */
        
        // PROBLEM 23
        
        /*
        
        Input a character and check if it is a vowel
        ➔ Hint: Compare character to 'a', 'e', 'i', 'o', 'u'.

        
        
        string letter = "k";
        
        if(letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u"){
            Console.WriteLine($"{letter} is vowel");
        }
        else{
            Console.WriteLine($"{letter} is consonant");
        }
        
        */
        
        // PROBLEM 24
        
        /*
        
        Print the first n natural numbers.
        ➔ Hint: Loop from 1 up to n.

        
        
        int n = 6;
        
        for(int i = 1; i <= n; i++){
            Console.WriteLine(i);
        }
        
        */
        
        // PROBLEM 25
        
        /*
        
        Input a number and find its double and triple.
        ➔ Hint: Multiply by 2 and by 3.
        
        
        int num = 3;
        
        Console.WriteLine($"{num} x 2 = {num * 2}");
        Console.WriteLine($"{num} x 3 = {num * 3}");
       
        */
    }
}
