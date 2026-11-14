# Processing Data
#chapter two#

## Topics Covered

3.1 Reading Input with TextBox Controls  
3.2 A First Look at Variables  
3.3 Numeric Data Types and Variables  
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

# 3.1 READING INPUT WITH TEXTBOX CONTROLS

A TextBox is a rectangular control that accepts keyboard input from the user.

It is found in the Common Controls group of the Toolbox. Double-click it to add it to the Form.

The default name is textBoxN, where N is 1, 2, 3, ...

### The Text Property

The Text property of a TextBox stores the user's input.

The Text property accepts only string values.

Example:

```csharp
textBox1.Text = "Hello";
```

### Clearing a TextBox

Assign an empty string, or use the Clear method:

```csharp
textBox1.Text = string.Empty;
textBox1.Clear();
textBox1.Text = "";
```

**Important Exam Points**
- TextBox = Accepts keyboard input.
- Text property = Stores the input as a string.
- Clear() = Empties the TextBox.
- Default name = textBox1, textBox2, ...

---

# 3.2 A FIRST LOOK AT VARIABLES

A variable is a named storage location in memory.

In C#, a variable must be declared before it is used.

Syntax:

```csharp
DataType VariableName;
```

### Data Types

The data type specifies the kind of data a variable can hold.

Many data types in C# are called primitive data types. They are basic, built-in types already defined by the language, such as string and int.

### Variable Names

Naming rules:

1. The first character must be a letter or underscore (_).
2. The name cannot contain spaces.
3. Do not use keywords or reserved words.

Always choose a meaningful name.

### String Variables

A string is a combination of characters, such as names or phone numbers.

The value is written inside double quotes.

```csharp
string productDescription = "Jamhuuriya University";
productLabel.Text = productDescription;
MessageBox.Show(productDescription);
```

### String Concatenation

Concatenation means appending one string to the end of another.

The + operator is used for concatenation. It also works between a string and another data type.

```csharp
"Total is " + 25.75;
12 + " apples";
```

### Local Variables and Scope

A local variable belongs to the method in which it is declared.

- **Scope:** The part of the program where the variable can be accessed.
- **Lifetime:** The time the variable exists in memory. It is created when the method starts and destroyed when the method ends.

### Duplicate Variable Names

- You cannot declare two variables with the same name in the same scope.
- You can use the same name in different methods.

### Assignment Compatibility

A value can be assigned to a variable only if it is compatible with the variable's data type.

Only strings are compatible with the string data type.

### Initializing Variables

A variable must be assigned a value before it is used.

```csharp
string productDescription;
MessageBox.Show(productDescription);   // ERROR
```

Error message: **Use of unassigned local variable 'productDescription'.**

### Declaring Multiple Variables with One Statement

```csharp
string lastName, firstName, middleName;
```

You can also initialize them across several lines:

```csharp
string lastName = "Khalaf",
       firstName = "Mohamed",
       middleName = "Abdullahi";
```

**Important Exam Points**
- Variable = Named storage location in memory.
- Declaration = DataType VariableName;
- Scope = Where a variable can be accessed.
- Lifetime = How long a variable exists.
- Concatenation = Joining strings with +.
- A variable must be assigned a value before it is used.

---

# 3.3 NUMERIC DATA TYPES AND VARIABLES

To store a number and use it in a mathematical operation, the variable must be of a numeric data type.

### Common Numeric Data Types

| Type | Description |
|---|---|
| int | Whole numbers, up to 2,147,483,647 |
| double | Real numbers, including fractions |
| decimal | Real numbers with greater precision than double; used in financial applications |

### Numeric Literals

A numeric literal is a number written directly in the program's code.

```csharp
int hoursWorked = 40;
double temperature = 87.6;
decimal payRate = 28.75m;
```

- Never put quotes around a numeric literal.
- Whole numbers such as 40 and 99 are treated as int.
- Numbers with a decimal point such as 87.6 are treated as double.
- Add **M** or **m** to create a decimal literal.

### Assignment Compatibility

**int variables** accept only int values:

```csharp
int hoursWorked = 40;     // Works
int unitsSold = 650m;     // ERROR
int score = -25.5;        // ERROR
```

**double variables** accept double and int values, but not decimal:

```csharp
double distance = 28.75;  // Works
double speed = 75;        // Works
double sales = 6500.0m;   // ERROR
```

**decimal variables** accept decimal and int values, but not double:

```csharp
decimal balance = 9280.73m;  // Works
decimal price = 50;          // Works
decimal sales = 6500.0;      // ERROR
```

### Explicit Conversion with Cast Operators

A cast operator is the name of the type in parentheses.

```csharp
decimal moneyNumber = 4500m;
int wholeNumber = (int)moneyNumber;

decimal money = 625.70m;
double realNumber = (double)money;
```

### The var Keyword

The compiler works out the type from the assigned value (type inference).

```csharp
var interestRate = 12.0;        // double
var stockCode = "D465U";        // string
var accountBalance = 1000.0m;   // decimal
```

Rules:
- You must provide an initial value.
- var can be used only for local variables.

**Important Exam Points**
- int = Whole numbers.
- double = Real numbers.
- decimal = Precise real numbers (money). Use the M suffix.
- double and decimal cannot be assigned to each other.
- Cast = (type)value.
- var = Type inferred from the initial value.

---

# 3.4 PERFORMING CALCULATIONS

### Math Operators

| Operator | Name | Description |
|---|---|---|
| + | Addition | Adds two numbers |
| - | Subtraction | Subtracts one number from another |
| * | Multiplication | Multiplies one number by another |
| / | Division | Gives the quotient |
| % | Modulus | Gives the remainder |

### Math Expressions

```csharp
int x = 5, y = 4;
MessageBox.Show((x + y).ToString());   // 9
```

Follow the order of operations and use parentheses to group:

```csharp
result = (a + b) / 4;
```

### Mixed Data Types

- int and double → result is **double**.
- int and decimal → result is **decimal**.
- double and decimal → **not allowed**.

### Integer Division

Dividing an int by an int always gives an int. The fractional part is dropped.

```csharp
int x = 7, y = 3;
MessageBox.Show((x / y).ToString());   // 2
```

To avoid integer division:

```csharp
MessageBox.Show(((double)x / y).ToString());   // 2.3333...

double a = 7, b = 3;
MessageBox.Show((a / b).ToString());           // 2.3333...
```

**Important Exam Points**
- % = Remainder (7 % 3 = 1).
- int / int = int (7 / 3 = 2).
- Cast one operand to double to avoid integer division.
- double and decimal cannot be mixed in a calculation.

---

# 3.5 INPUTTING AND OUTPUTTING NUMERIC VALUES

### Input

Keyboard input is read as a string, even if it looks like a number (for example 25.65).

You cannot use a cast operator to convert a string to a number. Use the **Parse** methods:

- int.Parse
- double.Parse
- decimal.Parse

```csharp
int hoursWorked = int.Parse(hoursWorkedTextBox.Text);
double temperature = double.Parse(temperatureTextBox.Text);
```

### Output

The Text property accepts only strings, so a number must be converted to a string.

Use the **ToString** method:

```csharp
decimal grossPay = 1550.0m;
grossPayLabel.Text = grossPay.ToString();

int myNumber = 123;
MessageBox.Show(myNumber.ToString());
```

Another option is implicit conversion with the + operator:

```csharp
int idNumber = 1044;
string output = "Your ID number is " + idNumber;
```

**Important Exam Points**
- TextBox input = string.
- Parse = Converts string to number.
- ToString() = Converts number to string.
- A cast cannot convert a string to a number.

---

# 3.6 FORMATTING NUMBERS WITH THE TOSTRING METHOD

The ToString method can take a format string to control how a number appears.

| Format | Description | Number | Code | Result |
|---|---|---|---|---|
| n | Number format | 12.3 | ToString("n3") | 12.300 |
| f | Fixed-point | 123456.0 | ToString("f2") | 123456.00 |
| e | Exponential (scientific) | 123456.0 | ToString("e3") | 1.235e+005 |
| c | Currency | -1234567.8 | ToString("C") | ($1,234,567.80) |
| p | Percentage | .234 | ToString("P") | 23.40% |

The number after the letter is the number of decimal places.

**Important Exam Points**
- n = Number, f = Fixed-point, e = Exponential, c = Currency, p = Percent.
- ToString("f2") = Two decimal places.

---

# 3.7 SIMPLE EXCEPTION HANDLING

An exception is an unexpected error that happens while a program is running (a runtime error).

Examples:
- Dividing by zero.
- Opening a file that does not exist.
- Invalid user input.

If an exception is not handled, the program halts abruptly.

An **exception handler** is code that catches the error and tells the program what to do instead of crashing.

### The try-catch Statement

```csharp
try
{
    statement;
    statement;
}
catch
{
    statement;
    statement;
}
```

- **try block:** Contains statements that can cause an exception.
- **catch block:** Contains statements that respond when the exception happens.

### Throwing and Catching

- **Throwing** = Raising the error (the problem occurs).
- **Catching** = Handling the error (deciding what to do).

Example: An ATM throws "Invalid PIN" after a wrong PIN. It catches the error by showing "Invalid PIN, please try again" instead of shutting down.

### Displaying an Exception's Default Message

Every exception is an object with a **Message** property.

```csharp
try
{
    statement;
}
catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}
```

**Important Exam Points**
- Exception = Runtime error.
- try = Code that may fail.
- catch = Code that handles the failure.
- ex.Message = Default error message.
- Unhandled exception = Program crashes.

---

# 3.8 USING NAMED CONSTANTS

A named constant is a name that represents a value that cannot change while the program runs.

Declare it with the **const** keyword:

```csharp
const double INTEREST_RATE = 0.129;
```

Uppercase names are traditional but not required.

**Important Exam Points**
- const = Value cannot change.
- Constants make code easier to read and maintain.

---

# 3.9 DECLARING VARIABLES AS FIELDS

A field is a variable declared at the class level: inside the class but not inside any method.

- A field's scope is the entire class.
- It is created in memory when the form is created.

Example: In the FieldDemo application, the name variable is a field declared in the Form1 class.

### Local Variable vs Field

| | Local Variable | Field |
|---|---|---|
| Declared | Inside a method | In the class, outside methods |
| Scope | That method only | The entire class |

**Important Exam Points**
- Field = Class-level variable.
- Field scope = Entire class.
- Local variable scope = Its method.

---

# 3.10 USING THE MATH CLASS

The .NET Math class provides methods for complex mathematical calculations.

| Member | Description |
|---|---|
| Math.Sqrt(x) | Square root of x |
| Math.Pow(x, y) | x raised to the power y |
| Math.Max(x, y) | Greater of x and y |
| Math.Min(x, y) | Lesser of x and y |
| Math.Round(x) | x rounded to the nearest integer |
| Math.PI | Ratio of a circle's circumference to its diameter |
| Math.E | Base of the natural logarithm |

**Important Exam Points**
- Sqrt = Square root.
- Pow = Power.
- Max / Min = Larger / smaller value.
- PI and E are predefined constants.

---

# 3.11 MORE GUI DETAILS

### Tab Order

- **Focus:** The control that receives the user's keyboard input.
- **Tab order:** The order in which controls receive focus when Tab is pressed.
- The **TabIndex** property holds the position in the tab order. It starts at 0.

To set it: View menu → Tab Order, then click the controls in the order you want.

Labels cannot receive focus, so their TabIndex values are irrelevant.

Change focus in code with the Focus method:

```csharp
private void clearButton_Click(object sender, EventArgs e)
{
    nameTextBox.Focus();
}
```

### Access Keys

An access key is used with the Alt key to quickly reach a control.

Add an ampersand (&) before a letter in a button's Text property, for example `&Exit`. The user then presses Alt + E.

Access keys are not case sensitive.

### Setting Colors

- **BackColor:** Background color of forms and most controls.
- **ForeColor:** Text color of controls that display text.

The color list has three tabs: Custom, Web, and System.

```csharp
messageLabel.BackColor = Color.Black;
messageLabel.ForeColor = Color.Yellow;
```

### Background Images for Forms

A Form has:
- **BackgroundImage:** The image shown on the form.
- **BackgroundImageLayout:** How the image is displayed (similar to SizeMode of a PictureBox).

### GroupBoxes versus Panels

Both are containers that hold other controls.

| | GroupBox | Panel |
|---|---|---|
| Title (Text property) | Yes | No |
| Border | Thin border, fixed | Set with BorderStyle |

**Important Exam Points**
- TabIndex starts at 0.
- Focus() = Moves focus to a control.
- & before a letter = Access key (Alt + letter).
- BackColor = Background, ForeColor = Text.
- GroupBox has a title, Panel does not.

---

# 3.12 USING THE DEBUGGER TO LOCATE LOGIC ERRORS

A logic error is a mistake that does not stop the application from running but causes incorrect results.

Examples:
- Mathematical errors.
- Assigning a value to the wrong variable.
- Assigning the wrong value to a variable.

Visual Studio provides debugging tools to help find them.

### Breakpoints

A breakpoint is a line of code where the running application pauses and enters **break mode**.

In break mode you can hover the cursor over a variable or property to see its value.

### The Locals and Watch Windows

- **Locals window:** Shows all variables in the current method with their values and data types.
- **Watch window:** Shows only the variables you add.

Open them from: Debug menu → Windows.

### Single-Stepping

Single-stepping runs the code one statement at a time after a breakpoint pauses it.

You can check variable values after each statement to find the line that causes the error.

To single-step:
- Press **F11**, or
- Click **Step Into** on the toolbar, or
- Debug menu → Step Into.
