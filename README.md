# training-circle-square

## This is repository source for training excercise

**What You get:**
* Simple backend based on SignalR
* Simple frontend based on RiotJS and SignalR

**Board field id map:**
|   |   1   |   2   |   3   |
|---|:-----:|:-----:|:-----:|
| a |   a1  |   a2  |   a3  |
| b |   b1  |   b2  |   b3  |
| c |   c1  |   b3  |   c3  |

**What we expect from You:**
* Setting fields to O or X on click 
* Implementation of end game rules:
    * Three same symbols (O or X) in column ends game
    * Three same symbols (O or X) in row ends game
    * Three same symbols (O or X) in diagonal line ends game 
* Showing whos has won (O or X)
* Lock OX fields on victory or draw
* "New Game" functionality
* Showing whos turn to move it is now (O or X)

**Nice to have:**
* UnitTests
* Counter of OX victories visible on frontend

**Running backend**
* Open ./backend/Training.CircleSquareGame.sln
* Build and run Debug

**Running frontend**
* Go to ./frontend and run ```npm install```
* Wait for installation to end
* Run ```npm run start```
* Open browser on http://localhost:1234

**Pointers:**
* On backend Your work should start with looking at XOHub.cs
* On frontend all actions related to messages are implemented in index.js
* On frontend all components have extension *.riot
* On frontend all components are attached to appState
* On frontend all componets can invoke SignalR functions by calling this.hub

**Links:**
* https://riot.js.org/ 
* https://milligram.io/
* https://parceljs.org/
* https://learn.microsoft.com/en-us/aspnet/core/signalr/introduction?WT.mc_id=dotnet-35129-website&view=aspnetcore-7.0