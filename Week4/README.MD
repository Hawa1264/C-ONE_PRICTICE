# Chapter 4: Loops, Files, and Random Numbers

Study guide based on the Chapter 4 slides of *Starting Out with Visual C#* (Gaddis, Sixth Edition, Global Edition). It is written in plain language, with no code blocks. Note that the slides are titled Chapter 4 but number their sections 5.1 to 5.9, so the section numbers below follow the slides.

---

## Topics Covered

1. The while loop
2. The increment and decrement operators
3. The for loop
4. The do-while loop
5. Using files for data storage
6. The OpenFileDialog and SaveFileDialog controls
7. Random numbers
8. The Load event

---

## 1. The while Loop

- A while loop repeats a statement or a set of statements as long as a Boolean expression is true.
- It has two parts: the Boolean expression that is tested, and the body, which is the statements inside the curly braces.
- The first line is called the while clause.
- Each pass through the body is called an iteration.
- A counter variable is a variable used to track how many times a loop runs.

### Pretest loop
- A while loop tests its condition before each iteration.
- Because of this, you usually need to set things up before the loop so it runs at least once. For example, a counter starting at 0 with a test of "less than 5" runs 5 times.
- If the condition is false from the start, the loop never runs.

### Infinite loops
- An infinite loop repeats until the program is interrupted.
- The usual cause is forgetting to change something in the body that eventually makes the condition false, such as never increasing the counter.

---

## 2. The Increment and Decrement Operators

- To increment means to increase a variable's value, and to decrement means to decrease it.
- C# provides the ++ and -- operators for this.
- Adding 1 can be done three ways: with ++, with += 1, or by writing the variable equals itself plus 1. Subtracting 1 works the same way with --, -= 1, or equals itself minus 1.

### Postfix versus prefix
- Postfix means the operator goes after the variable. The old value is used first, then the variable changes.
- Prefix means the operator goes before the variable. The variable changes first, then the new value is used.

---

## 3. The for Loop

- The for loop is designed for situations that need a counter variable to control how many times the loop runs.
- It has three parts:
  - **Initialization:** a one-time step that sets the starting value of the counter.
  - **Test:** a Boolean expression; if true, the loop iterates.
  - **Update:** a step that increases or decreases the counter.
- Like the while loop, the for loop is a pretest loop.
- The counter can be declared inside the initialization part or before the loop.
- The update does not have to add 1. It can count by tens, or count backward by decrementing.

---

## 4. The do-while Loop

- The do-while loop is a posttest loop: it runs the body once and only then tests the Boolean expression.
- This means the body always runs at least once, even if the condition is false from the start.
- A matching while loop with the same false condition would not run at all. That difference is the key point to remember.

### Loop comparison

| Loop | Type | Minimum runs | Best used when |
|------|------|--------------|----------------|
| while | Pretest | 0 | The number of repeats is not known in advance 
| for   | Pretest | 0 | You need a counter and know how many repeats 
|do-while|Posttest | 1 | The body must run at least once 

---

## 5. Using Files for Data Storage

- Programs save data in files for later use.
- There are always three steps: **open** the file, **process** it (write to it or read from it), and **close** it.
- There are two kinds of files: text files, which store data encoded as text such as Unicode, and binary files, which store data that is not text and cannot be viewed in a text editor. This chapter only deals with text files.
- A file object is tied to one specific file and lets the program work with it.
- .NET provides two classes: **StreamWriter** for writing to a text file and **StreamReader** for reading from one.

### Writing to a file
1. Create a StreamWriter variable.
2. Open the file with a File method:
   - **CreateText** creates the file. If it already exists, its contents are erased.
   - **AppendText** opens the file and adds to the end without erasing what is there.
3. Write data with **WriteLine** (writes the item and then a newline, ending the line) or **Write** (writes the item with no newline).
4. Close the file.

### File paths
- To use a file in another location, give a full path along with the file name.
- Put the @ character before the path string so backslashes are read correctly.

### Reading from a file
1. Create a StreamReader variable.
2. Open the file with **File.OpenText**.
3. Read data with one of these:
   - **ReadLine** reads one line and returns it as a string.
   - **Read** reads the next character or set of characters.
   - **ReadToEnd** and **File.ReadAllText** read the whole file at once (the slides list these without further detail).
4. Close the file.

### Reading a whole file with a loop
- A StreamReader has a Boolean property called **EndOfStream** that tells you whether the end of the file has been reached.
- You can loop while EndOfStream is false (or, written another way, while it is not true) to read every line.

---

## 6. The OpenFileDialog and SaveFileDialog Controls

- These controls show the standard Windows Open and Save As dialog boxes.
- They are invisible controls. When added to a form, they appear in the component tray at the bottom of the Designer, not on the form itself.

### Showing and checking the dialog
- Call the **ShowDialog** method to display the dialog box.
- ShowDialog returns a **DialogResult** value telling you which button the user clicked: **OK** if they clicked Open (or Save), and **Cancel** if they cancelled.
- Check this result with an if statement before doing anything with the file.

### Useful properties
- **FileName** holds the path and file name the user selected. Use it to open the chosen file.
- **InitialDirectory** sets which folder is shown first when the dialog opens.

### Save As dialog
- SaveFileDialog works the same way: show it, check for OK, then use the selected file name to create the output file.

---

## 7. Random Numbers

- .NET provides the **Random** class for generating random numbers.
- First create a Random object, then call its methods:
  - **Next** produces a random integer.
  - **NextDouble** produces a random floating-point number from 0.0 up to (but not including) 1.0.
- With no argument, Next gives a number from 0 up to 2,147,483,647.
- To get a number from 0 up to a chosen maximum, pass the maximum plus 1 as the argument. For example, passing 100 gives a number from 0 to 99.

---

## 8. The Load Event

- When an application runs, its form is loaded into memory and a **Load** event takes place.
- To create a Load event handler, double-click the form in the Designer.
- Any code placed in the Load event runs when the form is launched, for example showing a message box as the form opens.

