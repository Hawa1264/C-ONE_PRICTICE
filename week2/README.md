## week two
# Discuss Chapter2

## Topics Covered
3.1 Reading Input with TextBox Controls
3.2 A First Look at Variables
3.3 Numeric Data Type and Variables
3.4 Performing Calculations
3.5 Inputting and Outputting Numeric Values
3.6 Formatting Numbers with the ToString Method
3.7 Simple Exception Handling
3.8 Using Named Constants
3.9 Declaring Variables as Fields
3.10 Using the Math Class
3.11 More GUI Details
3.12 Using the Debugger to Locate Logic Errors



### 3.1 Reading Input with TextBox Controls

**TextBox** = rectangular control that accepts keyboard input
Found in the Toolbox's Common Controls group; 
double-click to add to form

Default name: textBoxN (n = 1, 2, 3...)
Text property stores the input — always as a string
Clearing a TextBox: .Text = "", .Text = string.Empty, or .Clear()

#### 3.2 A First Look at Variables (Slides 6–18)

**A variable** = a named storage location in memory
Must be declared before use: DataType VariableName;
Data types define what kind of data a variable can hold ("primitive" = basic, built-in types)

**Naming rules**
start with a letter or underscore, no spaces, no reserved keywords
String variables hold text, assigned with double quotes: productDescription = "text";

Variables can be declared and used later in the same method

**Local variables**: belong only to the method they're declared in

Variables must be assigned a value before use, or the compiler throws an error
Multiple variables of the same type can be declared in 
one statement: string lastName, firstName, middleName;

### Numeric Data Types and Variables

**Three common numeric types**
int — whole numbers
double — real numbers with decimals
decimal — real numbers, 

### Assignment compatibility rules
int variables only accept int values
double variables accept both int and double values
decimal variables accept both int and decimal values
double and decimal cannot mix directly

Explicit conversion (casting): (int)moneyNumber, (double)moneyNumber

**var keyword**: compiler infers the type from the assigned value (type inference); only usable for local variables; must be initialized at declaration

### Performing Calculations 

Math operators: + - * / % (modulus = remainder)
Order of operations applies; use parentheses to control grouping
Mixed-type calculations: int + double → result is double; int + decimal → result is decimal; double + decimal → not allowed
Integer division: dividing two ints truncates the result (7 / 3 → 2)
Fix: cast one operand to double before dividing, e.g., (double)x / y

