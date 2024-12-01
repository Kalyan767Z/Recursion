# Program: Recursive Methods for Array Operations and Digit Sum Calculation

## Task

1. Implement a method to print the elements of an array using recursion.
2. Implement a method to find the sum of the elements of an array using recursion.
3. Implement a method to find the sum of the digits of a number using recursion.

---

## Program Description

### 1. **Array Printing using Recursion**:
   - The program prints the elements of an array one by one using recursion. The method calls itself with the next index until it reaches the end of the array.

### 2. **Sum of Array Elements using Recursion**:
   - This method calculates the sum of the elements in an array by recursively adding each element to a cumulative sum until the array is fully traversed.

### 3. **Sum of Digits of a Number using Recursion**:
   - The program takes a number as input and calculates the sum of its digits by recursively extracting the last digit (using modulus operation) and reducing the number by dividing it by 10.

---

## Program Structure

1. **Array Printing Method**:
   - The method `OutputArray` uses recursion to print the elements of the array. It prints the current element and calls itself with the next index until it reaches the end of the array.

2. **Sum of Array Method**:
   - The method `SumArray` uses recursion to calculate the sum of the elements of the array. It adds the current element to the cumulative sum and calls itself with the next index until it reaches the end of the array.

3. **Sum of Digits Method**:
   - The method `NumberSum` recursively calculates the sum of the digits of a number by extracting the last digit (`number % 10`) and reducing the number (`number / 10`) until the number becomes zero.

---

## Summary:

This program demonstrates how recursion can be used for various operations like printing an array, calculating the sum of array elements, and summing the digits of a number. The recursive approach is elegant and helps in breaking down the tasks into smaller, manageable sub-problems. The program validates user input to ensure correctness, and handles array operations and digit sum calculations recursively.

--- 

## Key Operations:

- **Recursive Printing**: Recursively prints the array elements.
- **Recursive Sum of Array**: Uses recursion to calculate the sum of array elements.
- **Recursive Sum of Digits**: Recursively calculates the sum of digits of a given number.

These recursive methods are essential for learning how recursion works and its applications in array manipulation and number operations.
