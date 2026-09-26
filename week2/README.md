# Discuss Chapter 2 – Student Record Form

This practice demonstrates how to:

- Clear multiple TextBox and Label controls at once
- Close a form using a Button control
- Parse string input from a TextBox into a numeric variable

---

## 1. Clearing the Form Fields

In this step, the `Clear` button's Click event resets every input control back to its default (empty) state.

- `txtname.Clear();` empties the name TextBox.
- `txtstudentid.Clear();` empties the student ID TextBox.
- `txtdepatment.Clear();` empties the department TextBox.
- `txtsemester.Clear();` empties the semester TextBox.
- `lbloutput.Text = string.Empty;` clears the output Label.

Note that TextBox controls use the `.Clear()` method, while the Label control instead has its `.Text` property set directly to `string.Empty`, since Labels don't have a `.Clear()` method of their own.

The following screenshot shows the clearing code.

![Clearing Fields](Screenshots/Clear.png)

## 2. exitButton_Click

In this step, clicking the `exitButton` control runs code that closes the current form.

`this.Close();` closes the form the code is running in (in this case, `Form1`). `this` refers to the current form instance itself.

The following screenshot shows the close statement.

![Closing the Form](Screenshots/Close.png)

## 3. Parsing the Student ID

In this step, the text entered into `txtstudentid` is converted from a string into a numeric value so it can be used in calculations or comparisons.

`int studentID = int.Parse(txtstudentid.Text);` reads the TextBox's `.Text` property (always a string) and converts it into an `int` using the `Parse` method, storing the result in a new variable named `studentID`.

If the TextBox contains anything other than a valid whole number, `int.Parse()` will throw an exception — this is why Parse calls are often wrapped in a `try-catch` block in a finished application.

The following screenshot shows the parse method in use.

![Parsing Student ID](Screenshots/Parse_Method.png)