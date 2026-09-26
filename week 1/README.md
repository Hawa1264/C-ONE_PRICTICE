# Introduction to Visual C#
#chapter one#
## Topics Covered

1.1 Objects
1.2 The Program Development Process
1.8 Getting Started with Visual Studio
2.1 Getting Started with Forms and Controls
2.2 Creating the G U I for Your First Visual C# Application
2.3 Introduction to C# code
2.4 Writing Code for the Hello World Application
2.5 Label Controls
2.6 Making Sense of IntelliSense
2.7 PictureBox Controls
2.8 Comments, Blank Lines, and Indentation
2.9 Writing the Code to Close an Application’s Form
2.10 Dealing with Syntax Errors

## 1.1 Objects

_An object is a program component that contains data and performs operations.

Objects have two important features:

**Properties**: Store information about an object.

**Methods**: Define the operations an object can perform.

For example, a Button has properties such as Text and Size.

### controls
Controls are objects that appear in a program's graphical user interface (GUI).

Common controls include Labels, Buttons, and TextBoxes. Some objects, such as Timers and OpenFileDialog, are invisible.

A class is code that describes a particular type of object.

### NET Framework
.NET is a collection of classes and other code used to create Windows applications.

C# is a programming language supported by .NET. Developers can use existing .NET classes or create their own classes.

### Getting Started with Visual Studio 
Visual Studio is an Integrated Development Environment (IDE) used to create applications.

Its main components include the Designer Window, Solution Explorer, and Properties Window.

### Visual Studio Environment
This slide illustrates the Visual Studio environment and shows how its different windows are arranged.

The environment provides tools for designing, writing, and managing applications.

#### Solution Explorer
Solution Explorer displays the files and components of a project in an expandable list.

It helps developers organize and access project files, including forms, properties, and references.

#### Visual Studio Window
This slide illustrates the arrangement of windows in Visual Studio.

These windows allow developers to work with project files, application designs, and settings

#### Auto Hide
Auto Hide allows a window to appear as a tab along the edge of the Visual Studio environment.

It provides additional workspace by hiding windows when they are not being used.

#### Menu Bar and Standard Toolbar

The Menu Bar contains menus such as File, Edit, View, and Project.

The Standard Toolbar provides quick access to frequently used commands, including Save, Undo, Redo, and Start Debugging.


#### The Toolbox (1 of 2)

The Toolbox is a window that contains controls used to design applications.

It normally appears on the left side of Visual Studio and may be in Auto Hide mode.


#### The Toolbox (2 of 2)

The Toolbox is divided into sections, such as All Windows Forms and Common Controls.

It contains controls such as Button, CheckBox, ComboBox, Label, ListBox, and DateTimePicker.

 ### Tooltips

A Tooltip is a small information box that appears when the mouse pointer hovers over an item.

Tooltips help users understand the functions of toolbar buttons and Toolbox controls.

#### Docked and Floating Windows

A Docked Window is attached to one of the edges of the Visual Studio environment.

A Floating Window can be moved freely around the screen.

A window cannot float while it is in Auto Hide mode

#### Projects and Solutions
A Project is an application containing files such as Form1.cs and Program.cs.

A Solution is a container that can hold one or more projects.

Projects help developers organize application code and resources.

#### Specifying the Project Name
When creating or saving a project, developers can specify its name and location.

The main settings include Project Name, Location, and Solution Name.

#### Displaying the Designer

The Designer is used to create and modify the graphical interface of an application.

To open it, right-click Form1.cs in Solution Explorer and select View Designer.

### Creating the GUI for Your First Visual C# Application
GUI stands for Graphical User Interface.

A GUI allows users to interact with an application using visual elements such as:

Windows
Buttons
Labels
TextBoxes
Pictures
Menus

**Basic Steps**

Open Visual Studio.
Create a Windows Forms project.
Open the Form Designer.
Select controls from the Toolbox.
Drag the controls onto the Form.
Change their properties.
Write C# code for the controls.
Run and test the application.

#### Introduction to C# Code

C# is an object-oriented programming language developed by Microsoft.

**It can be used to create**
Windows applications
Web applications
Console applications
Other software applications

**Example**
string name = "Hawa"; int age = 23; MessageBox.Show(name);

**Explantion**
string stores text.
int stores whole numbers.
MessageBox.Show() displays a message.

### Writing Code for the Hello World Application
**Example**

private void btnHello_Click(object sender, EventArgs e)
{
    MessageBox.Show("Hello World!");
}

When the user clicks the button, the application displays:

Hello World!

#### Label Controls

A Label is a control used to display text on a Form.

Users normally cannot edit the text displayed by a Label.

**Common Label Properties**

Property	Purpose
Name	    Identifies the Label in code
Text	    Sets the displayed text
Font	    Changes the font
ForeColor	Changes the text color
BackColor	Changes the background color
AutoSize	Automatically adjusts the Label size

Example

lblMessage.Text = "Welcome!";


### PictureBox Controls
A PictureBox is a Windows Forms control used to display images.

**Common PictureBox Properties**

Image – Specifies the image.
SizeMode – Determines how the image fits inside the PictureBox.
Visible – Shows or hides the PictureBox.
BorderStyle – Sets the border style.

Example:

pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

This makes the image stretch to fit the PictureBox.

####  Comments, Blank Lines, and Indentation
Comments are used to explain code.

The compiler ignores comments.

**Single-Line Comment**
// This is a comment

**Multi-Line Comment**
/*
 This is a
 multi-line comment
*/
**Blank Lines**

Blank lines make code easier to read.

Example:

string name = "Hawa";

int age = 23;

**Indentation**

Indentation makes the structure of code easier to understand.

Example:

private void btnShow_Click(object sender, EventArgs e)
{
    MessageBox.Show("Welcome!");
}

Good indentation makes code more readable and easier to maintain.

#### Writing the Code to Close an Application's Form
The Close() method is used to close a Form.

**Example**

private void btnExit_Click(object sender, EventArgs e)
{
    this.Close();
}

When the user clicks the Exit button, the current Form closes.


#### Dealing with Syntax Errors
A syntax error occurs when code does not follow the rules of the C# programming language.

**Common Syntax Errors**

Missing semicolon
Missing quotation mark
Missing parenthesis
Missing curly brace
Misspelled keywords
Incorrect syntax

**Incorrect Code**
MessageBox.Show("Hello World!")

The semicolon is missing.

**Correct Code**
MessageBox.Show("Hello World!");

Visual Studio provides an Error List that helps programmers identify and correct errors.










