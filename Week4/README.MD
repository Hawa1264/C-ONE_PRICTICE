#chapter three#

Making Decisions

Topics Covered
4.1 Decision Structures and the if Statement 4.2 The if-else Statement 4.3 Nested Decision Structures 4.4 Logical Operators 4.5 bool Variables and Flags 4.6 Comparing Strings 4.7 Preventing Data Conversion Exceptions with the TryParse Method 4.8 Input Validation 4.9 Radio Buttons and Check Boxes 4.10 The switch Statement 4.11 Introduction to List Boxes

4.1 Decision Structures and the if Statement
A control structure is a logical design that controls the order in which statements execute.

A sequence structure is a set of statements that execute in the order that they appear.

A decision structure executes statements only under certain circumstances. A specific action is performed only if a certain condition exists. It is also known as a selection structure.

A Simple Decision Structure
A single-alternative decision structure provides only one alternative path of execution.

In C#, the if statement is used to write such structures.

Generic format:

if (expression) { statement; statement; etc. }

The expression is a Boolean expression that can be evaluated as either true or false.

Relational Operators
A relational operator determines whether a specific relationship exists between two values.

Operator Meaning Example Question
> Greater than x > y Is x greater than y?
< Less than x < y Is x less than y?
>= Greater than or equal to x >= y Is x greater than or equal to y?
<= Less than or equal to x <= y Is x less than or equal to y?
== Equal to x == y Is x equal to y?
!= Not equal to x != y Is x not equal to y?

An if Statement with a Boolean Expression

if (sales > 50000) { bonus = 500; }

4.2 The if-else Statement
An if-else statement executes one block of statements if its Boolean expression is true, or another block if its Boolean expression is false.

It has two parts: an if clause and an else clause.

Generic format:

if (expression) { statements } else { statements }

4.3 Nested Decision Structures
A nested decision structure is a decision structure inside another one. It is used to test more than one condition.

Nested means "one inside another".

Generic format:

if (expression) { if (expression) { statements } else { statements } } else { statements }

The if-else-if Statement
The if-else-if statement evaluates multiple conditions to make the final decision.

Generic format:

if (expression) { statements } else if (expression) { statements } else if (expression) { statements } else { statements }

4.4 Logical Operators
Logical operators connect multiple Boolean expressions to create a compound expression.

Operator Meaning Description
&& AND Both subexpressions must be true for the compound expression to be true
|| OR One or both subexpressions must be true for the compound expression to be true
! NOT Reverses the value of a Boolean expression

Example Meaning
x > y && a < b Is x greater than y AND is a less than b?
x == y || x == z Is x equal to y OR is x equal to z?
!(x > y) Is the expression x > y NOT true?

Sample Decision Structures with Logical Operators

The && operator

if (temperature < 20 && minutes > 12) { MessageBox.Show("The temperature is in the danger zone."); }

The || operator

if (temperature < 20 || temperature > 100) { MessageBox.Show("The temperature is in the danger zone."); }

The ! operator

if (!(temperature > 100)) { MessageBox.Show("The temperature is below the maximum."); }

4.5 bool Variables and Flags
A bool variable can store the value true or false.

bool variables are commonly used as flags. A flag is a variable that signals when some condition exists in the program.

false indicates the condition does not exist. true indicates the condition exists.

4.6 Comparing Strings
Relational operators and methods can be used to compare strings.

The == operator can compare two strings:

if (name1 == name2) { }

A string variable can be compared with a string literal:

if (name1 != "bob") { }

The String.Compare method can also compare two strings:

if (String.Compare(name1, name2) == 0) { }

4.7 Preventing Data Conversion Exceptions with the TryParse Method
Exceptions should be prevented when possible.

The TryParse methods prevent exceptions caused by users entering invalid data:

int.TryParse double.TryParse decimal.TryParse

Generic syntax:

dataType.TryParse(string input, out targetVariable)

The out keyword is required. It specifies that targetVariable is an output variable.

Example

int hours; if (int.TryParse(textBox1.Text, out hours)) { // TryParse succeeded, so the input is a number }

4.8 Input Validation
Input validation is the process of inspecting data entered into a program to make sure it is valid before it is used.

TryParse checks whether the data can be converted, but it does not check the integrity of the data.

Examples

Payroll program, validating hours worked:

if (hours > 0 && hours <= 168)

Test scores program, validating the score range of 0 through 100:

if (testScore >= 0 && testScore <= 100)

4.9 Radio Buttons and Check Boxes
Radio buttons allow users to select one choice from several possible choices. Clicking a radio button automatically deselects the others. This is called mutually exclusive selection.

Check boxes allow users to select multiple options.

RadioButton Control
A RadioButton control creates a group of radio buttons.

Common properties:

Text – the text displayed next to the radio button.

Checked – a Boolean property that determines whether the control is selected or deselected.

Example

if (choiceRadioButton.Checked) { } else { }

The == operator is not needed, but this is equivalent:

if (choiceRadioButton.Checked == true) { } else { }

CheckBox Control
A CheckBox control gives the user an option, such as true/false or yes/no.

It has the same common properties as RadioButton: Text and Checked.

Example

if (option1CheckBox.Checked) { } else { }

The CheckedChanged Event
Whenever the Checked property of a radio button or check box changes, a CheckedChanged event is raised.

A CheckedChanged event handler can be written to respond to the event. Double-click the control in the Designer to create an empty handler:

private void yellowRadioButton_CheckedChanged(object sender, EventArgs e) { }

4.10 The switch Statement
The switch statement lets the value of a variable or an expression determine which path of execution the program takes.

It is a multiple-alternative decision structure, and can be used as an alternative to an if-else-if statement that tests the same variable or expression for several different values.

Generic format:

switch (testExpression) { case value_1: statement; break; case value_2: statement; break; default: statement; break; }

General Format of the switch Statement
testExpression is a variable or expression with an int, string, or bool value.

Each case is an individual subsection containing one or more statements, followed by a break statement.

The default section is optional. It is used when testExpression does not match any of the cases.

4.11 Introduction to List Boxes
A ListBox control displays a list of items and allows the user to select an item from the list.

Common Properties

Text – the text of the currently selected item.

Items – the items of the ListBox.

Items.Count – the number of items in the ListBox.

SelectedItem – gets or sets the currently selected item.

SelectedIndex – gets or sets the zero-based index of the currently selected item.

Example

selectedFruit = fruitListBox.SelectedItem.ToString();

Adding Items to a ListBox
The Items.Add method adds an item to the ListBox.

ListBox.Items.Add(NewItem);

Example

daysListBox.Items.Add("Monday"); daysListBox.Items.Add("Tuesday"); daysListBox.Items.Add("Wednesday");

SelectedItem and SelectedIndex
An exception occurs if you get the value of SelectedItem when no item is selected.

Items in a list box are indexed starting at 0. The first item has index 0, and the nth item has index n - 1.

If no item is selected, SelectedIndex is -1.

Example: make sure an item is selected before getting SelectedItem.

if (fruitListBox.SelectedIndex != -1) { }

Difference Between Text and SelectedItem

Property Type Best Use For
Text string Quick access to the selected text; simple lists with text only
SelectedItem object Full access to the selected item; real or data-bound lists (for example Student or Book objects)

Text might return "" if nothing is selected. SelectedItem might be null if nothing is selected.

Removing Items from a ListBox
The Items.Remove method removes a specific item.

ListBox.Items.Remove(Item);

Example

daysListBox.Items.Remove("Tuesday");

The Items.RemoveAt method removes the item at a specific index.

ListBox.Items.RemoveAt(Index);

Example

daysListBox.Items.RemoveAt(2);

The index must be valid: not less than 0, and not greater than or equal to the number of items. An invalid index makes RemoveAt throw an exception.

The Items.Clear method erases all the items in the ListBox.

daysListBox.Items.Clear();