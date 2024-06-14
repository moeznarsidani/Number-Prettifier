**System**
- Visual Studio 2022
- .NET 8 Framework
- nUnit framework for Unit Testing

**Number Prettifier**

The Number Prettifier is a code implementation that converts large numbers into a more human-readable format by adding suffixes such as "K" for thousands, "M" for millions, "B" for billions, and so on. This readme provides an overview of the approach, assumptions, design decisions, and requirements of the code.

**Approach**

The code follows a simple approach to determine the appropriate suffix based on the magnitude of the input number. It checks if the absolute value of the number is less than one million. If true, it returns the original number as a string. If false, it divides the number iteratively by 1000 until it falls below one million and selects the appropriate suffix (e.g., K, M, B, T) based on the number.

**Assumptions**

- The input is a numeric value with the type of double.
- The output should be a string representation of the prettified number.
- if input number can not be parsed into double type of numeric then it will be considered as invalid input.
- Numbers greater than or equal to one trillion are considered out of range and cannot be prettified further.

**Design Decisions**

- The code uses the Math.Abs method to handle both positive and negative numbers by converting them to their absolute values.
- A string array of suffixes is used to provide the appropriate suffix based on the magnitude of the number.
- The code divides the number by 1000 iteratively until it falls below one million to determine the appropriate suffix and scale.

**Requirements**

- The code should expect input type numeric.
- The code should correctly prettify numbers above one million by adding the appropriate suffix (e.g. M, B, T) based on the magnitude.
- The code should return the original number as a string if it is less than one million.
- The code should handle both positive and negative numbers correctly.
- The prettified number should have one decimal place if there are decimal digits present in the input.

**Code Complexity with Big O notation**

- Time and Space complexity of this code is O(1) which is constant is performance time and amount of space required. we usually aim for O(1) or O(N) when we are considering code performance.
- Reason the complexity of this code is O(1) because it does not need to be depend of input size regardless its magnitude therefore it will always run fixed number of operation.
