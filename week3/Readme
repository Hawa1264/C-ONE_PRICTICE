# Chapter 2 – Processing Data (C#)
## Integer Division
When both numbers are integers, C# divides them and throws away the decimal part. For example, 7 / 3 gives 2, not 2.33. To keep the decimals, at least one of the numbers must be a `double`, so 7.0 / 3 gives 2.3333.

## Numeric Input
Text typed into a TextBox is always a string, even if it looks like a number. You cannot calculate with a string, so you must convert it first using `Parse()`:
- `int.Parse()` for whole numbers (age, quantity).
- `double.Parse()` for numbers with decimals (price, distance).
- `decimal.Parse()` for money values (salary), where accuracy matters.

Always read the value and convert it before doing any calculation.

## Displaying Numbers
A Label or TextBox shows text, so a number must be converted back to a string with `ToString()` before it is displayed.

**Remember:** `Parse()` = text to number; `ToString()` = number to text.

## Typical Program Steps (Home Assignment)
1. Read the input from the TextBoxes.
2. Convert it with `Parse()`.
3. Calculate the result.
4. Convert the result with `ToString()` and display it.

## Number Formatting
`ToString()` can take a format code to control how the number looks:
- `"N"`: number with thousands separators (1,234.50).
- `"F2"`: fixed, exactly two decimal places (12.3 becomes 12.30). The number after F sets how many decimals.
- `"E"`: scientific notation, for very large or small numbers.
- `"C"`: currency, adds the currency symbol (like $12.30).
- `"P"`: percentage; the value is multiplied by 100, so 0.23 shows as 23%.

Practice with `"N"`, `"F2"`, `"C"`, and `"P"`.

## Exceptions
An exception is an error that happens while the program is running. A common cause is invalid input, such as typing "hello" where a number is expected. If nothing handles it, the program crashes.

- **Throwing:** the moment the error is raised (for example, `Parse()` fails on bad text).
- **Catching:** the program handles the error so it does not crash.

### Try-Catch
Put code that might fail inside `try`. If an exception occurs, execution jumps to `catch`, where you can show a friendly message like "Invalid input!". Code after the catch continues normally.

### Exception Message
You can catch the exception as an object (`Exception ex`) and use `ex.Message` to show the system's description of what went wrong. This is useful for debugging.

## Named Constants
A `const` is a value that never changes while the program runs, such as an interest rate. Naming it makes the code easier to read and means you change it in only one place. By convention, constant names are written in capital letters. **Exam point:** a constant cannot be reassigned.

## Fields
A field is a variable declared inside a class but outside any method. Every method in the class can use it, and it keeps its value between events. This means one event handler can change a field and another handler will see the new value. A variable declared inside a method (a local variable) exists only while that method runs.

## Math Class
The `Math` class gives ready-made calculations:
- `Math.Sqrt(25)`: square root, gives 5.
- `Math.Pow(2, 3)`: 2 to the power of 3, gives 8.
- `Math.Max(4, 9)`: the larger value, gives 9.
- `Math.Min(4, 9)`: the smaller value, gives 4.
- `Math.Round(4.6)`: rounds to the nearest whole number, gives 5.
- `Math.PI` and `Math.E`: constants for pi and Euler's number.

## Form Design

### Tab Order
Tab order decides which control gets focus each time the user presses the Tab key. `TabIndex` starts at 0 for the first control. In Visual Studio, choose View → Tab Order and click the controls in the order you want.

### Focus()
`Focus()` moves the cursor to a chosen control in code, for example back to a TextBox after an input error so the user can retype.

### Access Keys
Placing `&` before a letter in a control's text (like `E&xit`) underlines that letter. The user can then press Alt + that letter to activate the control.

### Colors
`BackColor` changes the background color of a control; `ForeColor` changes its text color. Values come from the `Color` class, such as `Color.Black` or `Color.Yellow`.

### Background Images
The form's `BackgroundImage` property sets a picture, and the layout setting controls how it is shown:
- **None:** original size, placed at the top-left.
- **Tile:** repeats the image to fill the form.
- **Center:** places the image in the middle at original size.
- **Stretch:** fills the whole form, but may distort the picture.
- **Zoom:** fits the form while keeping the correct proportions.

### GroupBox vs. Panel
Both are containers that group other controls. A **GroupBox** has a title and a border. A **Panel** has no title but supports border styles and can scroll.

## Debugging

### Logic Errors
A logic error is when the program runs without crashing but gives the wrong answer, for example using the wrong formula or assigning the wrong variable. The computer cannot detect these, so you must find them by testing.

### Breakpoints and Break Mode
A breakpoint is a marker on a line of code. When the program reaches it, execution pauses (break mode). While paused, hover over a variable to see its current value and check whether it is what you expect.

### Locals and Watch Windows
- **Locals:** automatically lists the local variables and their current values.
- **Watch:** lets you pick specific variables or expressions to monitor as you step through.

### Single-Stepping
Run the program one statement at a time with F11 or Debug → Step Into. After each step, check the values. The first statement that produces a wrong value is usually where the error is.