#Discuss Chapter1
This practice demonstrates how to:

- Create string variables
- Combine two string values
- Store the combined value in another variable
- Display the result using a Label control

---

## 1. Creating Variables

In this step, three string variables are created to store the user's name information.

- `FirstName` stores the first name.
- `SecondName` stores the second name.
- `FullName` stores the complete name after combining the first and second names.

The following screenshot shows how the variables are declared in C#.

![Creating Variables](Screenshots/Creating_Variables.png)

## 2. Concatenating the First Name and Second Name

In this step, the first name and second name are combined using the `+` operator.

A space `" "` is added between the two names so that the final result is displayed correctly.

The result is stored in the `FullName` variable.

The following screenshot shows the string concatenation process.

![String Concatenation](Screenshots/String_Concatinatiin.png)

## 3. Displaying the Full Name

After the first name and second name are combined, the value stored in `FullName` is displayed in a Label control.

The `.Text` property of the label is used to show the result on the Windows Form.

The following screenshot shows how the full name is displayed.

## 4. exitButton_Click
In this step, clicking the exitButton control runs code that closes the current form.

A line comment (//Close the form.) explains what the line below it does — it has no effect on execution, it's just documentation for the programmer.
this.Close(); closes the form the code is running in (in this case, Form1).

### Responding to a Button Click
In this step, clicking a Button control (named myButton) displays a message box confirming the click.

Same MessageBox.Show(...) method as above, but from a Button's Click event instead of a PictureBox's.
The string "Thanks for clicking the button!" is shown to the user.

