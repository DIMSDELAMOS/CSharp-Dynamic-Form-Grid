# Dynamic Form Grid Generator 🪟🎨

A **C# Windows Forms** application that demonstrates dynamic control creation and screen coordinate manipulation. The program generates a grid of smaller forms that progressively cover the entire screen based on user-defined dimensions.

## 🚀 Features

* **Dynamic Instantiation:** Creates new Form instances programmatically at runtime.
* **Grid Logic:** Calculates the precise width, height, and position ($X, Y$) of each form to fit perfectly within the user's screen resolution (`Screen.PrimaryScreen.Bounds`).
* **Timer-Based Animation:** Uses a `Timer` to generate forms sequentially, creating a visual "filling" effect.
* **Randomized Properties:** Assigns a unique, random background RGB color to each generated form.
* **Coordinate Labeling:** Each form displays its specific matrix coordinates (Row, Column).

## 🛠️ How It Works

1.  **User Input:** The user specifies the number of **Rows** and **Columns**.
2.  **Calculation:** The app divides the screen resolution by the inputs to determine the size of each tile.
3.  **Generation:**
    * A timer triggers the creation of a new form.
    * The position is calculated using modulo and division logic:
        * `Column = Index % TotalColumns`
        * `Row = Index / TotalColumns`
    * The form is placed at `(Column * Width, Row * Height)`.

## 📦 How to Run

1.  Clone the repository.
2.  Open the solution file (`.sln`) in **Visual Studio**.
3.  Press **Start**.
4.  Enter the desired number of Rows (e.g., 3) and Columns (e.g., 4).
5.  Click the button and watch the screen fill up!

## 💻 Tech Stack
* **Language:** C#
* **Framework:** .NET Windows Forms
* **Key Concepts:** `System.Drawing`, `System.Windows.Forms.Timer`, `Screen Bounds`

---
*University of Piraeus Project*
