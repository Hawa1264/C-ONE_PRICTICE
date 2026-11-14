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

---

### 3.1 Reading Input with TextBox Controls (Slides 4–5)

**TextBox** = rectangular control that accepts keyboard input
Found in the Toolbox's Common Controls group;
double-click to add to form

Default name: textBoxN (n = 1, 2, 3...)
Text property stores the input — always as a string
Clearing a TextBox: .Text = "", .Text = string.Empty, or .Clear()

### 3.2 A First Look at Variables (Slides 6–18)

**A variable** = a named storage location in memory
Must be declared before use: DataType VariableName;
Data types define what kind of data a variable can hold ("primitive" = basic, built-in types)

**Naming rules**
start with a letter or underscore, no spaces, no reserved keywords
String variables hold text, assigned with double quotes: productDescription = "text";

**String concatenation**: the + operator appends one string to another (e.g., "Total is " + 25.75)

Variables can be declared and used later in the same method

**Local variables**: belong only to the method they're declared in
**Scope** = the part of the program where the variable can be accessed
**Lifetime** = created when the method starts, destroyed when it ends

**Duplicate names**: not allowed in the same scope; allowed in different methods
**Assignment compatibility**: only compatible values can be assigned (only strings go into string variables)

Variables must be assigned a value before use, or the compiler throws an error
("Use of unassigned local variable")
Multiple variables of the same type can be declared in
one statement: string lastName, firstName, middleName;

### 3.3 Numeric Data Types and Variables (Slides 19–24)

**Three common numeric types**
int — whole numbers (up to 2,147,483,647)
double — real numbers with decimals
decimal — real numbers with greater precision than double; used in financial applications

**Numeric literals**
whole number (40) → int
number with decimal point (87.6) → double
add M or m for decimal: decimal payRate = 28.75m;
never put quotes around a numeric literal

**Assignment compatibility rules**
int variables only accept int values
double variables accept both int and double values
decimal variables accept both int and decimal values
double and decimal cannot mix directly

**Explicit conversion (casting)**: (int)moneyNumber, (double)moneyNumber

**var keyword**: compiler infers the type from the assigned value (type inference); only usable for local variables; must be initialized at declaration

### 3.4 Performing Calculations (Slides 25–27)

Math operators: + - * / % (modulus = remainder)
Order of operations applies; use parentheses to control grouping
Mixed-type calculations: int + double → result is double; int + decimal → result is decimal; double + decimal → not allowed
Integer division: dividing two ints truncates the result (7 / 3 → 2)
Fix: cast one operand to double before dividing, e.g., (double)x / y

### 3.5 Inputting and Outputting Numeric Values (Slides 28–31)

**Input**: a TextBox always gives a string, even if the user types 25.65
A cast operator cannot convert a string to a number
Use the Parse methods: int.Parse, double.Parse, decimal.Parse
e.g., int hoursWorked = int.Parse(hoursWorkedTextBox.Text);

**Output**: the Text property accepts only strings
Use .ToString() to convert a number: grossPayLabel.Text = grossPay.ToString();
Or implicit conversion with +: "Your ID number is " + idNumber

### 3.6 Formatting Numbers with the ToString Method (Slides 32–33)

ToString() can take a format string to control how a number looks

| Format | Meaning | Example | Result |
|---|---|---|---|
| n | Number format | 12.3 → ToString("n3") | 12.300 |
| f | Fixed-point | 123456.0 → ToString("f2") | 123456.00 |
| e | Exponential (scientific) | 123456.0 → ToString("e3") | 1.235e+005 |
| c | Currency | -1234567.8 → ToString("C") | ($1,234,567.80) |
| p | Percent | .234 → ToString("P") | 23.40% |

### 3.7 Simple Exception Handling (Slides 34–40)

**Exception** = an unexpected runtime error (divide by zero, missing file, invalid input)
If not handled, the program halts abruptly
**Exception handler** = code that catches the error and decides what to do instead of crashing

**try-catch**
try block → statements that may cause an exception
catch block → statements that respond when it happens

**Throwing** = raising the error (problem occurs)
**Catching** = handling the error (deciding what to do)
Example: ATM throws "Invalid PIN"; it catches it by showing "try again" instead of shutting down

**Default message**: every exception is an object with a Message property
catch (Exception ex) { MessageBox.Show(ex.Message); }

### 3.8 Using Named Constants (Slide 41)

**Named constant** = a name for a value that cannot change while the program runs
Declared with the const keyword: const double INTEREST_RATE = 0.129;
UPPERCASE names are traditional, not required

### 3.9 Declaring Variables as Fields (Slides 42–43)

**Field** = a variable declared at the class level (inside the class, outside any method)
Scope = the entire class (all methods can use it)
Created in memory when the form is created
Example: the name variable in the FieldDemo application (Form1 class)

### 3.10 Using the Math Class (Slide 44)

Math.Sqrt(x) — square root
Math.Pow(x, y) — x raised to the power y
Math.Max(x, y) — greater of the two values
Math.Min(x, y) — lesser of the two values
Math.Round(x) — rounds to the nearest integer
Constants: Math.PI (circle ratio), Math.E (natural log base)

### 3.11 More GUI Details (Slides 45–52)

**Tab order**
Focus = the control that receives keyboard input
Tab order = the order controls receive focus when Tab is pressed
TabIndex property: starts at 0
Set via View → Tab Order, then click controls in order
Labels cannot receive focus
In code: ControlName.Focus();

**Access keys**: put & before a letter in a button's Text (e.g., &Clear) → Alt + letter; not case sensitive

**Colors**: BackColor (forms, most controls), ForeColor (controls with text)
Color picker tabs: Custom, Web, System
In code: messageLabel.BackColor = Color.Black;

**Background images**: Form has BackgroundImage and BackgroundImageLayout (like PictureBox's Image and SizeMode)

**GroupBox vs Panel**: both are containers for other controls
GroupBox → has a title (Text property), fixed thin border
Panel → no title or Text property, border set with BorderStyle

### 3.12 Using the Debugger to Locate Logic Errors (Slides 53–61)

**Logic error** = the program runs but produces incorrect results (math mistakes, wrong variable, wrong value)
**Breakpoint** = a line where execution pauses (break mode); hover over variables to see values
**Locals window** = all variables in the current method, with value and type
**Watch window** = only the variables you add (Debug → Windows)
**Single-stepping** = run one statement at a time; F11 (Step Into), toolbar, or Debug → Step Into
