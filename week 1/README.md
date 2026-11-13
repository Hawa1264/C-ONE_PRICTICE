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












## Topics Covered

1.1 Objects  
1.2 The Program Development Process  
1.8 Getting Started with Visual Studio  
2.1 Getting Started with Forms and Controls  
2.2 Creating the GUI for Your First Visual C# Application  
2.3 Introduction to C# Code  
2.4 Writing Code for the Hello World Application  
2.5 Label Controls  
2.6 Making Sense of IntelliSense  
2.7 PictureBox Controls  
2.8 Comments, Blank Lines, and Indentation  
2.9 Writing the Code to Close an Application's Form  
2.10 Dealing with Syntax Errors  

---

# 1.1 OBJECTS

An object is a program component that contains data and performs operations.

Objects have two important features:

**1. Properties:** Store information about an object.

**2. Methods:** Define the operations an object can perform.

Example:

A Button has properties such as Text, Name, and Size.

### Controls

Controls are objects that appear in a program's Graphical User Interface (GUI).

Common controls include:
- Label
- Button
- TextBox
- CheckBox
- ComboBox
- ListBox

Some objects are invisible, such as:
- Timer
- OpenFileDialog

**Class:** A class is code that describes a particular type of object.

### .NET Framework

.NET is a collection of classes and other code used to create Windows applications.

C# is a programming language supported by .NET.

Developers can use existing .NET classes or create their own classes.

**Important Exam Points**
- Object = Contains data and performs operations.
- Properties = Store information.
- Methods = Perform operations.
- Class = Describes a type of object.
- Controls = Objects visible in a GUI.

---

# 1.2 THE PROGRAM DEVELOPMENT PROCESS

**Important note:** The uploaded PowerPoint lists this topic in its Topics section but does not provide its detailed explanation or steps.

Review the original lecture or textbook for the exact course explanation.

---

# 1.8 GETTING STARTED WITH VISUAL STUDIO

Visual Studio is an Integrated Development Environment (IDE) used to create applications.

### Main Components of Visual Studio

1. Designer Window – Used to design the application's interface.
2. Solution Explorer – Displays project files and components.
3. Properties Window – Displays and changes object properties.
4. Toolbox – Contains controls used to design applications.
5. Code Editor – Used to write C# code.

### Solution Explorer

Solution Explorer displays the files and components of a project in an expandable list.

It helps developers organize and access project files.

### Auto Hide

Auto Hide allows a window to appear as a tab along the edge of Visual Studio.

It provides additional workspace by hiding windows when they are not being used.

### Menu Bar and Standard Toolbar

**Menu Bar:** Contains menus such as:
- File
- Edit
- View
- Project

**Standard Toolbar:** Provides quick access to frequently used commands:
- Save
- Undo
- Redo
- Start Debugging

### Toolbox

The Toolbox is a window containing controls used to design applications.

It normally appears on the left side of Visual Studio.

Common controls include:
- Button
- CheckBox
- ComboBox
- Label
- ListBox
- DateTimePicker

### Tooltips

A Tooltip is a small information box that appears when the mouse pointer hovers over an item.

Tooltips help users understand the functions of toolbar buttons and Toolbox controls.

### Docked and Floating Windows

**Docked Window:** Attached to one of the edges of Visual Studio.

**Floating Window:** Can be moved freely around the screen.

A window cannot float while it is in Auto Hide mode.

### Projects and Solutions

**Project:** An application containing files such as Form1.cs and Program.cs.

**Solution:** A container that can hold one or more projects.

Remember:

- Solution = Entire container.
- Project = Application inside the solution.
- Files = Code and resources used by the application.

### Specifying the Project Name

When creating a project, developers specify:

- Project Name
- Location
- Solution Name

### Displaying the Designer

To open the Form Designer:

1. Open Solution Explorer.
2. Right-click Form1.cs.
3. Select View Designer.

**Important Exam Points**
- IDE = Integrated Development Environment.
- Toolbox = Contains controls.
- Solution Explorer = Displays project files.
- Designer = Designs the GUI.
- Properties Window = Changes object properties.
- Auto Hide = Hides windows as tabs.
- Docked = Attached window.
- Floating = Movable window.

---

# 2.1 GETTING STARTED WITH FORMS AND CONTROLS

When you start a new Windows Forms application, an empty Form named Form1 is automatically created.

### Form

A Form is a window where controls are placed.

### Form's Bounding Box and Sizing Handles

A form in Designer is enclosed with thin dotted lines called the Bounding Box.

The Bounding Box has small sizing handles.

These handles are used to resize the form.

### Properties Window

The Properties Window lists the properties of a selected object.

Properties control how an object looks and behaves.

Each property has two columns:

- Left column: Property name.
- Right column: Property value.

### Changing a Property's Value

Steps:

1. Select an object, such as a Form.
2. Open the Properties Window.
3. Find the property you want to change.
4. Change its value.

Example:

Change the Form's Text property from:

Form1

To:

My First Program

The title bar will display My First Program.

### Alphabetical and Categorized Properties

**Alphabetical:** Displays properties in alphabetical order.

**Categorized:** Displays properties in groups.

### Adding Controls to a Form

There are two ways to add a control:

1. Double-click the control in the Toolbox.
2. Click and drag the control onto the Form.

You can:
- Resize a control.
- Move a control.
- Change its properties.

### Deleting a Control

To delete a control:

1. Select the control.
2. Press the Delete key.

### Rules for Naming Controls

Control names are also known as Identifiers.

Naming rules:

1. The first character must be a letter or underscore (_).
2. Other characters can be letters, numbers, or underscores.
3. Names cannot contain spaces.

Valid examples:

- showDayButton
- DisplayTotal
- _ScoreLabel

### camelCase Naming Convention

camelCase is a naming convention used by programmers.

Rules:

- Start with lowercase letters.
- Start each following word with an uppercase letter.

Examples:

- showDayButton
- studentName
- calculateTotal

**Important Exam Points**
- Form = Main application window.
- Bounding Box = Dotted lines around a Form or control.
- Sizing Handles = Used to resize.
- Properties Window = Changes object settings.
- Delete key = Removes a selected control.
- Identifier = Name used to identify a control.
- camelCase = First word lowercase, following words start uppercase.

---

# 2.2 CREATING THE GUI FOR YOUR FIRST VISUAL C# APPLICATION

GUI stands for Graphical User Interface.

A GUI allows users to interact with an application using visual elements.

Examples:
- Windows
- Buttons
- Labels
- TextBoxes
- Pictures
- Menus

### Basic Steps

1. Open Visual Studio.
2. Create a Windows Forms project.
3. Open the Form Designer.
4. Select controls from the Toolbox.
5. Drag controls onto the Form.
6. Change their properties.
7. Write C# code.
8. Run and test the application.

### Example

The first application contains:

- One Form.
- One Button.

When the user clicks the Button, the application displays Hello World.

**Important Exam Points**
- GUI = Graphical User Interface.
- Toolbox = Used to select controls.
- Form Designer = Used to design the application.
- Button = Allows users to perform an action.

---

# 2.3 INTRODUCTION TO C# CODE

C# is an object-oriented programming language developed by Microsoft.

It can be used to create:
- Windows applications.
- Web applications.
- Console applications.
- Other software applications.

### Organization of C# Code

C# code is primarily organized in three ways:

**1. Namespace**

A namespace is a container that holds classes.

**2. Class**

A class is a container that holds methods.

**3. Method**

A method is a group of one or more programming statements that perform operations.

A file that contains program code is called a Source Code File.

### Source Code in Solution Explorer

When a new project is created, two important source code files are automatically created.

**Program.cs**

Contains the application's startup code.

**Form1.cs**

Contains code associated with the Form1 form.

### Organization of Form1.cs

Form1.cs contains:

1. Namespace declaration.
2. Class declaration.
3. Methods.

Example:

```csharp
namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
```

### Code Explanation

- namespace HelloWorld: Defines the namespace.
- public partial class Form1: Declares the Form1 class.
- public Form1(): Constructor of the Form.
- InitializeComponent(): Initializes the Form and its controls.

### Adding Your Code

GUI applications are Event-Driven.

This means the application waits for the user to perform an action and then responds.

Examples of events:
- Mouse clicking.
- Key pressing.
- Moving the mouse.

### Event Handler

An Event Handler is a method that executes when a specific event takes place.

For example, when a user clicks a Button, its Click event handler executes.

### Message Boxes

A MessageBox displays a message to the user.

.NET provides a method called:

MessageBox.Show()

Example:

```csharp
private void myButton_Click(object sender, EventArgs e)
{
    MessageBox.Show("Thanks for clicking the button!");
}
```

### Code Explanation

- private void: Defines a method.
- myButton_Click: Event handler name.
- object sender: Identifies the object that generated the event.
- EventArgs e: Contains event information.
- MessageBox.Show(): Displays a message.

**Important Exam Points**
- Namespace = Container for classes.
- Class = Container for methods.
- Method = Group of statements.
- Program.cs = Startup code.
- Form1.cs = Form-related code.
- Event = User action.
- Event Handler = Responds to an event.
- MessageBox.Show() = Displays a message.

---

# 2.4 WRITING CODE FOR THE HELLO WORLD APPLICATION

The Hello World application displays a message when the user clicks a Button.

### Example Code

```csharp
private void btnHello_Click(object sender, EventArgs e)
{
    MessageBox.Show("Hello World!");
}
```

### Explanation

- private void = Defines the event handler.
- btnHello_Click = Button Click event.
- object sender = Object that generated the event.
- EventArgs e = Event information.
- MessageBox.Show() = Displays the message.
- "Hello World!" = Message displayed to the user.

### Output

Hello World!

### Important Exam Points

- MessageBox.Show() displays a message.
- Click event executes when the Button is clicked.
- Event Handler contains the code that responds to an event.

---

# 2.5 LABEL CONTROLS

A Label control displays text on a Form.

Users normally cannot edit the text displayed by a Label.

### Common Label Properties

**1. Text**

Gets or changes the text displayed by a Label.

**2. Name**

Identifies the Label in code.

**3. Font**

Changes the font, font style, and font size.

**4. BorderStyle**

Displays a border around the Label.

**5. AutoSize**

Controls how the Label is resized.

**6. TextAlign**

Controls the alignment of the text.

### Label Text Alignment

TextAlign supports nine positions:

- TopLeft
- TopCenter
- TopRight
- MiddleLeft
- MiddleCenter
- MiddleRight
- BottomLeft
- BottomCenter
- BottomRight

### Using Code to Display Output in a Label

Example:

```csharp
lblMessage.Text = "Welcome!";
```

This displays Welcome! inside the Label.

### Assignment Operator (=)

The equal sign (=) is called the Assignment Operator.

It assigns a value to a variable or property.

Example:

```csharp
lblMessage.Text = "Hello";
```

The Text property receives the value Hello.

### Clearing a Label

Example:

```csharp
lblMessage.Text = "";
```

This clears the Label's text.

**Important Exam Points**
- Label = Displays text.
- Text = Changes displayed text.
- Name = Identifies the Label.
- Font = Changes text appearance.
- TextAlign = Aligns text.
- Assignment Operator = `=`.
- Empty string = `""`.

---

# 2.6 MAKING SENSE OF INTELLISENSE

IntelliSense provides automatic code completion as you write programming statements.

It suggests:
- Keywords.
- Variables.
- Methods.
- Classes.
- Properties.

### Benefits of IntelliSense

1. Helps programmers write code faster.
2. Suggests available code elements.
3. Reduces typing mistakes.
4. Makes programming easier.

### Example

When you type:

```csharp
MessageBox.
```

Visual Studio displays available methods and properties.

You can select the required option.

**Important Exam Points**
- IntelliSense = Automatic code completion.
- It suggests methods, classes, keywords, and properties.
- It helps reduce typing mistakes.

---

# 2.7 PICTUREBOX CONTROLS

A PictureBox control displays a graphic image on a Form.

### Common PictureBox Properties

**1. Image**

Specifies the image displayed.

**2. SizeMode**

Specifies how the image fits inside the PictureBox.

**3. Visible**

Determines whether the PictureBox is visible at runtime.

### Example Code

```csharp
pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
```

This makes the image stretch to fit the PictureBox.

### Creating Clickable Images

You can double-click a PictureBox in the Designer to create a Click event handler.

You can then add code to respond when the user clicks the image.

### Sequential Execution of Statements

Statements execute in the order they appear in a method.

Example:

```csharp
private void showBackButton_Click(object sender, EventArgs e)
{
    cardBackPictureBox.Visible = true;
    cardFacePictureBox.Visible = false;
}
```

### Explanation

1. The first statement makes the back image visible.
2. The second statement hides the face image.

The order of statements is important.

Incorrect sequence or values can cause Logic Errors.

**Important Exam Points**
- PictureBox = Displays images.
- Image = Specifies the image.
- SizeMode = Controls image display.
- Visible = Shows or hides the image.
- Sequential Execution = Statements execute in order.
- Incorrect logic can produce Logic Errors.

---

# 2.8 COMMENTS, BLANK LINES, AND INDENTATION

### Comments

Comments are notes placed in source code to explain how parts of a program work.

The compiler ignores comments.

### Single-Line Comment

Example:

```csharp
// This is a comment
```

A single-line comment starts with `//`.

### Multi-Line Comment

Example:

```csharp
/*
This is a
multi-line comment
*/
```

A multi-line comment starts with `/*` and ends with `*/`.

### Blank Lines

Blank lines make code easier to read.

Example:

```csharp
string name = "Hawa";

int age = 23;
```

### Indentation

Indentation means adding spaces at the beginning of code lines to show the structure of the program.

Example:

```csharp
private void btnShow_Click(object sender, EventArgs e)
{
    MessageBox.Show("Welcome!");
}
```

Good indentation makes code:
- Easier to read.
- Easier to understand.
- Easier to maintain.

**Important Exam Points**
- `//` = Single-line comment.
- `/* */` = Multi-line comment.
- Blank Lines = Improve readability.
- Indentation = Organizes code structure.
- Comments are ignored by the compiler.

---

# 2.9 WRITING THE CODE TO CLOSE AN APPLICATION'S FORM

The Close() method is used to close a Form.

### Example 1: Close Current Form

```csharp
private void btnExit_Click(object sender, EventArgs e)
{
    this.Close();
}
```

When the user clicks the Exit Button, the current Form closes.

### Example 2: Close the Entire Application

```csharp
Application.Exit();
```

This closes the entire application.

### Difference Between Close() and Application.Exit()

**this.Close();**

Closes the current Form.

**Application.Exit();**

Closes the entire application.

**Important Exam Points**
- Close() = Closes the current Form.
- Application.Exit() = Exits the application.
- Exit Button = Commonly used to close an application.

---

# 2.10 DEALING WITH SYNTAX ERRORS

A Syntax Error occurs when code does not follow the rules of the C# programming language.

Visual Studio examines statements as you type and reports syntax errors.

A syntax error may be underlined with a red jagged line.

### Common Syntax Errors

1. Missing semicolon.
2. Missing quotation mark.
3. Missing parenthesis.
4. Missing curly brace.
5. Misspelled keywords.
6. Incorrect syntax.

### Incorrect Code

```csharp
MessageBox.Show("Hello World!")
```

The semicolon is missing.

### Correct Code

```csharp
MessageBox.Show("Hello World!");
```

### Error List

Visual Studio provides an Error List that helps programmers identify and correct errors.




