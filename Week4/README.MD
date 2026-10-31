# Chapter 3 – Making Decisions (C#)

These notes explain how a C# program makes decisions: testing conditions, choosing between paths, validating input, and using controls such as radio buttons, check boxes, and list boxes. (Source: Starting Out with Visual C#, 6th Edition, Gaddis.)

## Topics
1. Decision structures and the `if` statement
2. The `if-else` statement
3. Nested decision structures
4. Logical operators
5. `bool` variables and flags
6. Comparing strings
7. Preventing conversion exceptions with `TryParse`
8. Input validation
9. Radio buttons and check boxes
10. The `switch` statement
11. List boxes

---

## 1. Decision Structures and the if Statement
- A **control structure** controls the order in which statements run.
- A **sequence structure** runs statements in the order they appear.
- A **decision structure** (also called a *selection structure*) runs statements only when a certain condition exists.

The **single-alternative** decision structure has only one path: if the condition is true, the statements inside the braces run; otherwise they are skipped. The condition is a **Boolean expression**, meaning it evaluates to either `true` or `false`.

General format: `if (expression) { statements }`

Example: `if (sales > 50000) { bonus = 500; }` gives a bonus only when sales exceed 50,000.

### Relational Operators
A relational operator checks whether a relationship exists between two values and returns true or false.

| Operator | Meaning | Example question |
|---|---|---|
| `>` | Greater than | Is x greater than y? |
| `<` | Less than | Is x less than y? |
| `>=` | Greater than or equal to | Is x greater than or equal to y? |
| `<=` | Less than or equal to | Is x less than or equal to y? |
| `==` | Equal to | Is x equal to y? |
| `!=` | Not equal to | Is x not equal to y? |

**Tip:** `==` compares values; a single `=` assigns a value.

## 2. The if-else Statement
An `if-else` statement has two parts: an **if clause** and an **else clause**. If the condition is true, the `if` block runs; if it is false, the `else` block runs. Exactly one of the two blocks always executes.

General format: `if (expression) { statements } else { statements }`

## 3. Nested Decision Structures
*Nested* means one structure inside another. Use nesting to test more than one condition: the inner `if` is only checked when the outer condition is true (or false, depending on which block it sits in).

### The if-else-if Statement
An `if-else-if` chain tests several conditions in order. The first condition that is true runs its block, and the rest are skipped. The final `else` (optional) runs when none of the conditions are true. This is cleaner than deep nesting when you have several mutually exclusive choices (for example, grade ranges).

## 4. Logical Operators
Logical operators connect Boolean expressions into a compound expression.

| Operator | Name | Meaning |
|---|---|---|
| `&&` | AND | Both sides must be true |
| `\|\|` | OR | One or both sides must be true |
| `!` | NOT | Reverses true to false and false to true |

Examples:
- `x > y && a < b`: is x greater than y AND is a less than b?
- `x == y || x == z`: is x equal to y OR to z?
- `!(x > y)`: is x > y NOT true?

Sample uses:
- `&&`: `temperature < 20 && minutes > 12` is true only when both conditions hold (danger zone).
- `||`: `temperature < 20 || temperature > 100` is true when the temperature is outside the safe range.
- `!`: `!(temperature > 100)` is true when the temperature is not above the maximum.

## 5. bool Variables and Flags
A `bool` variable stores `true` or `false`. A **flag** is a `bool` variable that signals whether some condition exists in the program:
- `false`: the condition does not exist.
- `true`: the condition exists.

For example, a flag can record that the user's input was valid so that later code can check it.

## 6. Comparing Strings
You can compare strings in several ways:
- The `==` operator compares two string variables: `name1 == name2`.
- You can compare a variable with a literal: `name1 != "bob"`.
- `String.Compare(name1, name2) == 0` is true when the two strings are equal.

## 7. Preventing Data Conversion Exceptions with TryParse
Exceptions should be prevented when possible. `Parse()` crashes on invalid text, but the **TryParse** methods avoid this: `int.TryParse`, `double.TryParse`, and `decimal.TryParse`.

Syntax: `dataType.TryParse(string input, out targetVariable)`

- It returns `true` if the conversion succeeds and `false` if it fails.
- The converted value is placed in `targetVariable`.
- The `out` keyword is required; it marks the variable as an output.

Example: `int.TryParse(textBox1.Text, out hours)` is true when the text is a valid whole number.

## 8. Input Validation
**Input validation** means checking that entered data is valid before using it.

`TryParse` only confirms that the input is the right *type* (a number). It does not check that the value makes sense. You must also check the *range*:
- Hours worked: `hours > 0 && hours <= 168` (there are 168 hours in a week).
- Test score: `testScore >= 0 && testScore <= 100`.

A typical pattern: use `TryParse` first, and inside its `if` block check the range.

## 9. Radio Buttons and Check Boxes
- **Radio buttons:** the user picks only one choice from a group. Selecting one automatically deselects the others (*mutually exclusive*).
- **Check boxes:** the user may select any number of options (true/false or yes/no).

Common properties for both:
- `Text`: the label shown next to the control.
- `Checked`: a Boolean that tells whether the control is selected.

Test them with an `if` statement, for example `if (choiceRadioButton.Checked)`. You do not need `== true`, though it is equivalent.

### The CheckedChanged Event
Whenever the `Checked` property of a radio button or check box changes, a **CheckedChanged** event is raised. Double-click the control in the Designer to create the empty handler (for example `yellowRadioButton_CheckedChanged`) and write code that responds to the change.

## 10. The switch Statement
The `switch` statement uses the value of a variable or expression to choose a path. It is a **multiple-alternative** decision structure and can replace an `if-else-if` chain that tests the same variable against several values.

Structure:
- `switch (testExpression)`: the expression is an `int`, `string`, or `bool` value.
- Each `case value:` is a section with one or more statements, ending with `break`.
- `default:` is optional and runs when no case matches.

## 11. Introduction to List Boxes
A **ListBox** shows a list of items and lets the user select one.

### Common Properties
- `Items`: the collection of items in the list.
- `Items.Count`: how many items are in the list.
- `SelectedItem`: the currently selected item, e.g. `fruitListBox.SelectedItem.ToString()`.
- `SelectedIndex`: the zero-based index of the selected item.
- `Text`: the text of the selected item.

### Adding Items
`ListBox.Items.Add(NewItem);` for example `daysListBox.Items.Add("Monday");`

### Working with the Selected Item
- Indexes start at 0: the first item is 0, the nth item is n − 1.
- If nothing is selected, `SelectedIndex` is **−1**.
- Reading `SelectedItem` when nothing is selected causes an exception, so check first: `if (fruitListBox.SelectedIndex != -1)`.

### Text vs. SelectedItem

| Feature | Text | SelectedItem |
|---|---|---|
| Type | `string` | `object` |
| Use | Quick access to the selected text | Full access to the selected item |
| Flexibility | Less flexible | More flexible (can hold objects like Student or Book) |
| Nothing selected | Might return `""` | Might be `null` |
| Best for | Simple text-only lists | Complex or data-bound lists |

### Removing Items
- `Items.Remove(Item)`: removes a specific item, e.g. `daysListBox.Items.Remove("Tuesday");`
- `Items.RemoveAt(Index)`: removes the item at an index, e.g. `RemoveAt(2)`. The index must be valid (not below 0 and less than the item count) or an exception is thrown.
- `Items.Clear()`: removes all items.

---

## Quick Review
- `if` runs code when a condition is true; `if-else` chooses between two blocks; `if-else-if` and `switch` choose among many.
- Combine conditions with `&&`, `||`, and `!`.
- Use `TryParse` to avoid crashes, then validate the range.
- Radio buttons = one choice; check boxes = many; both use `Checked`.
- Always check `SelectedIndex != -1` before using a list box's `SelectedItem`.