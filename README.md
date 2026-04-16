# Connect Four – OOP Term Project  
SODV 1202 – Object-Oriented Programming  
This project is a console-based implementation of the classic Connect Four game.
The objective of the game is to connect four of your symbols horizontally, vertically, or diagonally before your opponent.
The project demonstrates core Object-Oriented Programming principles:
- Abstraction
- Encapsulation
- Inheritance
- Polymorphism

Project Structure
- Program.cs → Entry point
- GameController.cs → Controls game flow
- Board.cs → Handles board logic and win conditions
- Player.cs → Abstract base class
- HumanPlayer.cs → Concrete implementation for human players

Game Rules
- Board size: 7 columns × 6 rows
- Players alternate turns
- Input: numbers 1–7
- Program validates full columns
- Game detects win and prevents crashes


