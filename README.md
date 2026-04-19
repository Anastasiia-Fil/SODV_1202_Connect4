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

  Design Approach
The project was developed using a step-by-step approach:
- Initial game structure and classes were created
- Core game logic was implemented (board, turns, moves)
- Win and draw conditions were added
- User interface improvements were made
- Code was refactored for better readability

Key Learning Outcomes
- Understanding how to structure a program using OOP
- Applying abstraction with the Player base class
- Using inheritance for different player types
- Implementing polymorphism through method overriding
- Managing game state and user input
- Working with Git and version control

Future Improvements
- Add ComputerPlayer (AI opponent)
- Improve console graphics
- Add score tracking
- Convert to GUI application

Author
Student project for SODV 1202 course


