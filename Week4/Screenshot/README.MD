# Chapter 3 – Making Decisions (Screenshots)

## 1. Test Score Average with try-catch
In this step, the program reads three test scores, calculates the average, and congratulates the user if the average is higher than the high score.

* `HIGH_SCORE` is a constant (95.0) that stores the limit and cannot be changed.
* `test1`, `test2`, `test3`, and `average` are `double` variables.
* `double.Parse()` converts the text in each TextBox to a number.
* The average is calculated as `(test1 + test2 + test3) / 3.0`.
* `average.ToString("n1")` displays the average in `averageLabel`.

An `if` statement checks whether `average > HIGH_SCORE`. If it is true, a message box shows "Congratulations! Great job!"
All of this code is inside a `try` block. If the user enters invalid text, the `catch (Exception ex)` block shows `ex.Message` in a message box.
The following screenshot shows the try-catch with the if statement.

## 2. Nested if (Loan Qualification)
In this step, one `if` statement is placed inside another `if` statement to test two conditions.

* The outer `if` checks whether `salary >= 40000`.
* The inner `if` checks whether `yearsOnJob >= 2`. It runs only when the salary condition is true.
* If both conditions are true, `decisionLabel.Text` shows "You qualify for the loan".
* If the years condition fails, the label shows "Minimum years at current job not met."
* If the salary condition fails, the outer `else` shows "Minimum salary requirement not met."

The following screenshot shows the nested decision structure.

## 3. if-else-if (Letter Grade)
In this step, the test score is converted to a letter grade using an `if-else-if` chain.

* `int.Parse()` reads the score from `testScoreTextBox`.
* A score of 90 or more gives "A", 80 or more gives "B", 70 or more gives "C", and 60 or more gives "D".
* The final `else` gives "F" for any other score.

The first true condition runs and the rest are skipped.
The following screenshot shows the if-else-if statement.

## 4. Comparing Two Names
In this step, two strings are compared to check whether they are equal.

* `Name1.CompareTo(Name2) == 0` is true when both names are the same.
* A negative result means `Name1` comes before `Name2` alphabetically.
* A positive result means `Name1` comes after `Name2`.

The following screenshot shows the string comparison inside an `if` statement.

## 5. Counting ListBox Items
In this step, the number of items in a list box is counted and displayed.

* `listBox1.Items.Count` returns the number of items in the list box.
* The value is stored in the `int` variable `count_listbox`.
* `MessageBox.Show()` joins the text "Total items is :" and the number using the `+` operator.

The following screenshot shows how the item count is displayed.

## 6. Selected Text in a ListBox
In this step, the item selected by the user in the list box is displayed.

* `listBox1.Text` holds the text of the selected item.
* The text is stored in the string variable `selectedtext`.
* `MessageBox.Show()` displays "your selected" followed by that text.

The following screenshot shows how the selected text is displayed.

## 7. Simple if-else (Temperature)
In this step, the program shows a message depending on the temperature.

* `Temp` is set to 90.
* The condition `Temp > 40` is true, so the `if` block runs and shows "hot".
* The `else` block runs only when the condition is false.

The following screenshot shows the if-else statement.

## 8. bool Flag (Grand Master)
In this step, a `bool` variable is used as a flag to record whether a player is a grand master.

* `points` stores the points read from `txtPoints` using `double.Parse()`.
* `isGrandMaster` is a `bool` flag.
* If `points > 5000`, the flag is set to `true`. Otherwise, it is set to `false`.
* `isGrandMaster.ToString()` converts the flag to "True" or "False" so `lblResult` can display it.

The following screenshot shows the flag being set and displayed.