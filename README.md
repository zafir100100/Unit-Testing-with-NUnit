## Unit-Testin-with-Nunit

This repository contains a simple arithmetic calculator implemented in C# with basic operations (addition, subtraction, multiplication, and division) and its corresponding NUnit test cases. The tests validate the correctness of each arithmetic function, ensuring accurate results and proper exception handling, such as division by zero. The project demonstrates the use of NUnit testing framework and follows modern best practices for unit testing in C#.

## Video

https://github.com/user-attachments/assets/b10ab71c-6ec4-4af0-8eeb-5e7166848330

## Test Scenario - Step by Step

**Test Scenario: Validate Calculator Operations**

**Test 1: Addition**
- **Test Steps:**
  1. Initialize the `Calculator` class.
  2. Call the `Add` method with two numbers, `3` and `2`.
  3. Assert that the result is `5`.

**Test 2: Subtraction**
- **Test Steps:**
  1. Initialize the `Calculator` class.
  2. Call the `Subtract` method with two numbers, `5` and `3`.
  3. Assert that the result is `2`.

**Test 3: Multiplication**
- **Test Steps:**
  1. Initialize the `Calculator` class.
  2. Call the `Multiply` method with two numbers, `3` and `4`.
  3. Assert that the result is `12`.

**Test 4: Division**
- **Test Steps:**
  1. Initialize the `Calculator` class.
  2. Call the `Divide` method with two numbers, `10` and `2`.
  3. Assert that the result is `5.0`.

**Test 5: Division by Zero**
- **Test Steps:**
  1. Initialize the `Calculator` class.
  2. Call the `Divide` method with two numbers, `10` and `0`.
  3. Assert that a `DivideByZeroException` is thrown.

---

These tests ensure that each arithmetic operation in the `Calculator` class behaves as expected, and the edge cases like division by zero are properly handled.

## Screenshot (Report)

![image](https://github.com/user-attachments/assets/9511766b-fdef-4174-b87d-11c39c3f5020)
