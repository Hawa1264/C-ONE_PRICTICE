# Discuss Chapter 4 screenshot

This practice demonstrates how to:

- Repeat code with the `while`, `for`, and `do-while` loops
- Increase and decrease variables with `++` and `--`
- Write data to a file and read it back
- Let the user choose a file with the OpenFileDialog and SaveFileDialog controls
- Generate random numbers
- Run code when a form loads

---

## 1. The while Loop

In this step, a `while` loop repeats a block of code as long as its condition is true.

- `count` starts at 0.
- The condition `count < 5` is checked **before** every pass, so the `while` loop is a pretest loop.
- Each pass shows a message box and adds 1 to `count`.
- The loop stops when `count` reaches 5, so "Hello" is shown 5 times.

If the condition is false at the start (`count = 5`), the loop never runs.
If `count` is never updated, the condition stays true forever and the loop becomes an infinite loop.

The following screenshot shows the `while` loop examples.

![While Loop](Screenshots/While_Loop.png)

## 2. The Increment and Decrement Operators

In this step, `++` adds 1 to a variable and `--` subtracts 1 from it.

- `count++` does the same thing as `count += 1` and `count = count + 1`.
- `count--` does the same thing as `count -= 1` and `count = count - 1`.

The operators can be used in two modes:

- Postfix (`x = count++`) uses the old value first, then changes the variable. Here `x` is 5 and `count` is 6.
- Prefix (`x = ++count`) changes the variable first, then uses the new value. Here `count` goes from 6 to 7, so `x` is 7.

The following screenshot shows the increment and decrement examples.

![Increment and Decrement](Screenshots/Increment_Decrement.png)

## 3. The for Loop

In this step, a `for` loop puts the start value, the test, and the update in one line.

A `for` loop has three parts: `for (InitializationExpression; TestExpression; UpdateExpression)`.

- `for (int count = 0; count < 5; count++)` shows "Hello" 5 times. The variable `count` is declared inside the loop.
- `for (count = 0; count < 5; count++)` does the same, but `count` is declared before the loop.
- `count += 10` makes the loop count by tens: 0, 10, 20 ... 100.
- `count--` makes the loop count backward: 10, 9, 8 ... 0.

The following screenshot shows the `for` loop examples.

![For Loop](Screenshots/For_Loop.png)

## 4. The do-while Loop

In this step, a `do-while` loop checks its condition **after** the body, so the body always runs at least once.

- `number` is set to 1.
- The message box shows `1`.
- The condition `number < 0` is then checked. It is false, so the loop stops.

The same code written as a `while` loop shows nothing, because the condition is checked first.

The following screenshot shows the `do-while` loop example.

![Do While Loop](Screenshots/Do_While_Loop.png)

## 5. Using Files for Data Storage

In this step, data is written to a text file and read back.

### Writing to a file

- `StreamWriter` is the object that writes text to a file.
- `File.CreateText("courses.txt")` creates a new file. If the file already exists, it is overwritten.
- `File.AppendText("Names.txt")` adds new lines to the end of an existing file.
- `WriteLine(...)` writes one line of text.
- `Close()` closes the file so the data is saved.

### Specifying the file location

A path can be given instead of a file name. The `@` symbol is placed before the string so the backslashes are treated as normal characters: `@"C:\Data\Names.txt"`.

### Reading from a file

- `StreamReader` is the object that reads text from a file.
- `File.OpenText("students.txt")` opens an existing file.
- `while (!inputFile.EndOfStream)` repeats until the end of the file is reached. It is the same as `inputFile.EndOfStream == false`.

The following screenshot shows the file examples.

![Files](Screenshots/Files.png)

## 6. The OpenFileDialog and SaveFileDialog Controls

In this step, the user chooses a file with a dialog box instead of typing its name.

- `openFileDialog.ShowDialog()` shows the Open dialog when the button is clicked.
- `ShowDialog()` returns a `DialogResult`. It is `DialogResult.OK` when the user clicks Open and `DialogResult.Cancel` when the user cancels.
- `openFileDialog.FileName` holds the file the user selected, so it can be passed to `File.OpenText`.
- `openFileDialog.InitialDirectory` sets the folder the dialog starts in.
- `saveFileDialog.ShowDialog()` shows the Save As dialog. If the user clicks OK, `File.CreateText(saveFileDialog.FileName)` creates the file.

The following screenshot shows the dialog examples.

![File Dialogs](Screenshots/File_Dialogs.png)

## 7. Random Numbers

In this step, the `Random` class is used to create random numbers.

- `new Random()` creates the random number generator.
- `rand.Next()` returns a random integer.
- `rand.NextDouble()` returns a random decimal number from 0.0 up to (but not including) 1.0.
- `rand.Next(100)` returns a random integer from 0 to 99.

The following screenshot shows the random number examples.

![Random Numbers](Screenshots/Random_Numbers.png)

## 8. The Load Event

In this step, the `Form1_Load` event handler runs when the form is loaded into memory.

- Double-clicking the form in the Designer creates an empty `Load` event handler.
- Code placed inside it runs before the form appears.
- In the example, `MessageBox.Show("Prepare to see the form!");` displays a message first.

The following screenshot shows the Load event handler.

![Load Event](Screenshots/Load_Event.png)