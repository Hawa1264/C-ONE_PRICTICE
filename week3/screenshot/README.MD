# C# Windows Forms Code Examples

This README document contains 10 structured C# Windows Forms programming examples. Each example includes a title, placeholder image, source code with syntax highlighting, and a concise explanation.

---

## 1. ListBox Remove Item

![ListBox Remove Item](images/01-listbox-remove-item.png)

```csharp
if (listBox1.SelectedIndex != -1)
{
    // Remove the selected item.
    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
}
else
{
    MessageBox.Show("Please select an item to remove.");
}
```

**Explanation:**
- `SelectedIndex` returns `-1` when no item is selected in the `ListBox`.
- `RemoveAt(index)` removes the item located at the specified position.
- If no item is selected, a `MessageBox` alerts the user.

---

## 2. Fuel Economy Program

![Fuel Economy Program](images/02-fuel-economy-program.png)

```csharp
using System;
using System.Windows.Forms;

namespace FuelEconomy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double miles;
                double gallons;
                double mpg;

                // Get the miles driven.
                miles = double.Parse(milesTextBox.Text);

                // Get the gallons of fuel used.
                gallons = double.Parse(gallonsTextBox.Text);

                // Validate input values.
                if (miles < 0 || gallons <= 0)
                {
                    MessageBox.Show(
                        "Miles cannot be negative, and gallons must be greater than zero."
                    );
                    return;
                }

                // Calculate miles per gallon.
                mpg = miles / gallons;

                // Display result rounded to 1 decimal place.
                mpgLabel.Text = mpg.ToString("n1");
            }
            catch
            {
                MessageBox.Show("Invalid data was entered.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
```

**Explanation:**
- `double.Parse()` converts input text into floating-point numbers.
- Input validation ensures `miles >= 0` and `gallons > 0`.
- `.ToString("n1")` formats the number to one decimal place.
- The `try-catch` block catches non-numeric inputs.

---

## 3. Field Demo Program

![Field Demo Program](images/03-field-demo-program.png)

```csharp
using System;
using System.Windows.Forms;

namespace FieldDemo
{
    public partial class Form1 : Form
    {
        // Declare a private field at class level.
        private string name = "Charles";

        public Form1()
        {
            InitializeComponent();
        }

        private void showNameButton_Click(object sender, EventArgs e)
        {
            // Display the current name.
            MessageBox.Show(name);
        }

        private void dariusButton_Click(object sender, EventArgs e)
        {
            // Change the field value to Darius.
            name = "Darius";
        }

        private void carmenButton_Click(object sender, EventArgs e)
        {
            // Change the field value to Carmen.
            name = "Carmen";
        }
    }
}
```

**Explanation:**
- `name` is declared as a **field** (class-level variable), so it retains its value across different methods.
- Clicking **Darius** or **Carmen** updates the value of `name`.
- Clicking **Show Name** displays whatever value `name` currently holds.

---

## 4. Locals Window

![Locals Window](images/04-locals-window.png)

| Name | Value | Type |
| :--- | :--- | :--- |
| `this` | Current form instance | `AverageRaceTimes.Form1` |
| `sender` | Button object triggering the event | `object` |
| `e` | Event arguments | `System.EventArgs` |
| `runner1` – `runner3` | Assigned numeric values | `double` |
| `average` | Calculated result | `double` |

**Explanation:**
- The Visual Studio **Locals** window shows all active local variables during execution break mode.
- Access it via **Debug → Windows → Locals** while debugging.

---

## 5. Break Mode Data Tip

![Break Mode Data Tip](images/05-break-mode-data-tip.png)

```csharp
// Get the times entered by the user.
runner1 = double.Parse(runner1TextBox.Text);
runner2 = double.Parse(runner2TextBox.Text);
runner3 = double.Parse(runner3TextBox.Text);
```

**Explanation:**
- Pausing execution with a breakpoint allows hovering over variable names or property references (like `runner1TextBox.Text`) to inspect values in real time.

---

## 6. Breakpoint and Logic Error

![Breakpoint and Logic Error](images/06-breakpoint-logic-error.png)

```csharp
private void calculateButton_Click(object sender, EventArgs e)
{
    double runner1;
    double runner2;
    double runner3;
    double average;

    // Read user inputs.
    runner1 = double.Parse(runner1TextBox.Text);
    runner2 = double.Parse(runner2TextBox.Text);
    runner3 = double.Parse(runner3TextBox.Text);

    // Correct average calculation using parentheses.
    average = (runner1 + runner2 + runner3) / 3.0;

    // Display result formatted to 1 decimal place.
    averageTimeLabel.Text = average.ToString("n1");
}
```

**Explanation:**
- Operator precedence dictates that `/` executes before `+`.
- **Incorrect:** `average = runner1 + runner2 + runner3 / 3.0;` (Only `runner3` gets divided).
- **Correct:** `average = (runner1 + runner2 + runner3) / 3.0;`

---

## 7. Clear Button Handler

![Clear Button Handler](images/07-clear-button-handler.png)

```csharp
private void btnClear_Click(object sender, EventArgs e)
{
    // Clear input and output controls.
    txttest1.Text = "";
    txttest2.Text = "";
    txttest3.Text = "";
    lblaverage.Text = "";

    // Set cursor focus back to the first TextBox.
    txttest1.Focus();
}
```

**Explanation:**
- Assigning `""` resets control text.
- `.Focus()` moves keyboard focus back to the initial input field.

---

## 8. Exit Button Handler

![Exit Button Handler](images/08-exit-button-handler.png)

```csharp
private void btnExit_Click(object sender, EventArgs e)
{
    // Close the current form.
    this.Close();
}
```

**Explanation:**
- Calling `this.Close()` closes the active form and terminates the application if it is the main form.

---

## 9. Test Average Calculation

![Test Average Calculation](images/09-test-average-calculate.png)

```csharp
private void btncalculate_Click(object sender, EventArgs e)
{
    double test1, test2, test3, average;

    // Validate inputs using TryParse.
    if (!double.TryParse(txttest1.Text, out test1))
    {
        MessageBox.Show("Please enter a valid score for Test 1.");
        return;
    }

    if (!double.TryParse(txttest2.Text, out test2))
    {
        MessageBox.Show("Please enter a valid score for Test 2.");
        return;
    }

    if (!double.TryParse(txttest3.Text, out test3))
    {
        MessageBox.Show("Please enter a valid score for Test 3.");
        return;
    }

    // Compute average.
    average = (test1 + test2 + test3) / 3.0;

    // Display formatted output.
    lblaverage.Text = average.ToString("n1");
}
```

**Explanation:**
- `double.TryParse()` safely parses strings into numbers without throwing runtime exceptions if parsing fails.

---

## 10. try-catch Flow

![try-catch Flow](images/10-try-catch-flow.png)

```csharp
private void calculateButton_Click(object sender, EventArgs e)
{
    try
    {
        double miles = double.Parse(milesTextBox.Text);
        double gallons = double.Parse(gallonsTextBox.Text);

        if (miles < 0 || gallons <= 0)
        {
            MessageBox.Show("Miles cannot be negative, and gallons must be greater than zero.");
            return;
        }

        double mpg = miles / gallons;
        mpgLabel.Text = mpg.ToString("n1");
    }
    catch
    {
        MessageBox.Show("Invalid data was entered.");
    }
}
```

**Explanation:**
- Code inside `try` executes normally. If a parsing error occurs, execution immediately jumps to `catch` to handle the exception without crashing.

---

## Summary

This set of examples covers core C# Windows Forms programming patterns:
1. **Control Manipulation:** TextBoxes, Labels, ListBoxes, and Buttons.
2. **Data Parsing & Formatting:** `Parse()`, `TryParse()`, and `ToString("n1")`.
3. **Error Prevention:** Input validation and `try-catch` blocks.
4. **Debugging:** Breakpoints, Data Tips, and the Locals Window.