# 🎮 XO Game – Classic Tic-Tac-Toe with a Modern UI

![Tic-Tac-Toe Screenshot](https://via.placeholder.com/600x400?text=XO+Game+Screenshot)  
*(Replace with actual screenshot when available)*

**XO Game** is a clean, responsive, and user-friendly implementation of the classic **Tic-Tac-Toe** (Noughts and Crosses) game, built with **C#** and **Windows Forms**. Designed for two players, it features intuitive gameplay, real-time turn indicators, win detection with visual feedback, and a seamless restart option—perfect for quick matches and learning C# desktop development.

---

## ✨ Features

- **Two-player local gameplay** (Player 1 = X, Player 2 = O)
- **Dynamic turn indicator** showing whose move is next
- **Win detection** across all 8 possible lines (rows, columns, diagonals)
- **Visual win highlighting** – winning cells glow in **GreenYellow**
- **Game status tracking** (In Progress / Player 1 Wins / Player 2 Wins / Draw)
- **Interactive UI** with custom-drawn grid lines using `Paint` event
- **One-click restart** to reset the board instantly
- **Input validation** – prevents overwriting occupied cells
- **Polished user experience** with informative message boxes and clear labels

---

## 🛠️ Technologies Used

- **Language**: C#
- **Framework**: .NET Framework (Windows Forms)
- **IDE**: Visual Studio
- **Assets**: Embedded resources for X, O, and placeholder icons

---

## 📦 Installation & Setup

1. **Clone the repository**:
   ```bash
   git clone https://github.com/your-username/XoXoGame.git
   cd XoXoGame
   ```

2. **Open in Visual Studio**:
   - Launch `XoXoGame.sln`
   - Restore NuGet packages if prompted (though none are required for this project)

3. **Build & Run**:
   - Press `Ctrl + F5` to run the application
   - Enjoy the game!

> 💡 **Note**: This is a standalone desktop application—no external dependencies or installation required beyond .NET Framework (v4.7.2 or higher recommended).

---

## 🖼️ UI Highlights

- Custom-drawn **thick white grid lines** with rounded caps for a sleek look
- **Transparent cell backgrounds** that turn **GreenYellow** on win
- Clear status labels (`lblProg` and `player`) for real-time feedback
- Responsive `PictureBox`-based cells with embedded icons

---

## 📁 Project Structure

```
XoXoGame/
├── Form1.cs          // Main game logic and event handlers
├── Form1.Designer.cs // UI layout (auto-generated)
├── Resources/        // Embedded images (X, O, question mark)
└── Program.cs        // Application entry point
```

---

## 📝 License

This project is open-source and available under the **MIT License**. Feel free to use, modify, and distribute it for personal or educational purposes.

---

## 🙌 Author

Created with ❤️ by **[Your Name]**  
GitHub: [@your-username](https://github.com/your-username)  
Email: your.email@example.com

---

> 💬 **Enjoy the game—and may the best strategist win!** 🏆

---

### ✅ Ready to play? Just hit **Run** and start your XO duel today!

---

> **Tip for contributors**: Replace placeholder image links, add your name/email, and include an actual screenshot for a complete README before publishing to GitHub.
