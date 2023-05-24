# ShapeCalculatorApplication

Task: Create a Shape Calculator Application

Description:
You are tasked with creating a Shape Calculator application that allows users to calculate the area and perimeter of different shapes. The application should support calculations for rectangles, circles, and triangles.

Requirements:
1. Create a base class called `Shape` with the following properties and methods:
   - Properties:
     - `Name` (string): Encapsulate with appropriate getter and setter.
   - Methods:
     - `CalculateArea()` (abstract): Calculate and return the area of the shape.
     - `CalculatePerimeter()` (abstract): Calculate and return the perimeter of the shape.
     - `PrintDetails()`: Print the shape's name, area, and perimeter.

2. Create derived classes for each shape:
   - `Rectangle`:
     - Properties:
       - `Width` (double): Encapsulate with appropriate getter and setter.
       - `Height` (double): Encapsulate with appropriate getter and setter.
     - Implement the abstract methods `CalculateArea()` and `CalculatePerimeter()` to calculate the area and perimeter of the rectangle.
   - `Circle`:
     - Properties:
       - `Radius` (double): Encapsulate with appropriate getter and setter.
     - Implement the abstract methods `CalculateArea()` and `CalculatePerimeter()` to calculate the area and circumference of the circle.
   - `Triangle`:
     - Properties:
       - `SideA` (double): Encapsulate with appropriate getter and setter.
       - `SideB` (double): Encapsulate with appropriate getter and setter.
       - `SideC` (double): Encapsulate with appropriate getter and setter.
     - Implement the abstract methods `CalculateArea()` and `CalculatePerimeter()` to calculate the area and perimeter of the triangle.

3. Implement error handling and validation:
   - Ensure that appropriate validation is performed for input values such as dimensions or radii. Display error messages when invalid values are entered.
   - Handle exceptions gracefully to prevent application crashes.

4. Implement a menu-driven user interface:
   - Display a menu with options for different shapes.
   - Allow the user to select a shape and input the necessary dimensions.
   - Perform the calculations and display the results using the `PrintDetails()` method.

5. Implement the ability to handle multiple shape calculations:
   - Allow the user to perform calculations for multiple shapes in a single session.
   - Provide an option to exit the program when the user is done.

6. Apply proper encapsulation, inheritance, method overriding, and method overloading principles throughout the application.

Note: You are encouraged to modularize your code into separate classes and files as appropriate, following good object-oriented design principles.

This project task challenges you to apply the concepts of encapsulation, inheritance, method overriding, method overloading, error handling, and user interface design to create a Shape Calculator application. It requires you to think about class design, validation, and implementing the necessary calculations for each shape.
