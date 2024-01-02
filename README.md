# TrigonometricAndLogarithmicFunctionCalculator

First assignment in C# and .Net

September 29, 2023

**1. Overview:**
   - The C# project is a console application that calculates and displays values of two mathematical functions, Sin(2theta) and Log(theta) in base 2.
   - Users input lower and upper bounds for the angle theta and the number of equally spaced values desired. The program then calculates and displays the function values for each theta.

**2. Key Features:**

   - **User Input:**
     - Prompts the user to input lower and upper bounds for the angle theta, and the number of equally spaced values desired.
     - The user can choose to continue or exit after viewing the results.

   - **Function Calculation:**
     - Calculates the values of two functions, Sin(2theta) and Log(theta) in base 2.
     - The functions are defined as `f(theta) = 2 * Math.Sin(theta)` and `g(theta) = Math.Log(theta, 2)`.

   - **Display:**
     - Prints a table displaying theta, Sin(2theta), and Log(theta) for the specified range.
     - Utilizes a loop to iterate through the range of theta values and display the corresponding function results.

   - **Loop and User Interaction:**
     - Implements a while loop to allow the user to input multiple sets of parameters for calculations.
     - The user can choose to continue or exit the program.

   - **Mathematical Functions:**
     - Demonstrates the use of trigonometric (`Sin`) and logarithmic (`Log`) functions from the `Math` class in C#.

**3. Usage:**
   - Users can run the program and input values for the lower and upper bounds of theta, as well as the number of equally spaced values desired.
   - The program calculates and displays the corresponding values of Sin(2theta) and Log(theta) in base 2.

**4. Error Handling:**
   - Assumes valid input from the user for numerical values.
   - Does not include extensive error handling or validation.

**5. Continuous Execution:**
   - The program runs continuously until the user chooses to exit, allowing multiple sets of calculations in a single run.

**6. Conclusion:**
   - The project serves as a simple mathematical calculator that provides values for trigonometric and logarithmic functions based on user input.
   - It demonstrates the use of basic mathematical functions in C# and provides a loop for continuous user interaction.
