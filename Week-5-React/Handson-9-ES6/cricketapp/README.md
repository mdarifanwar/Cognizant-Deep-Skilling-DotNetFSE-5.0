# Week 5 - Handson 9: ES6 Features in React

## Objective

This hands-on demonstrates the implementation of ES6 features in a React application. It covers the use of **map()**, **arrow functions**, **destructuring**, and the **spread operator** by displaying cricket player information.

---

# Technologies Used

- React JS
- JavaScript (ES6)
- HTML5
- CSS3
- Node.js
- Visual Studio Code

---

# Project Structure

```
cricketapp
│
├── src
│   ├── Components
│   │   ├── ListofPlayers.js
│   │   ├── ScoreBelow70.js
│   │   ├── IndianPlayers.js
│   │   └── ListofIndianPlayers.js
│   │
│   ├── App.js
│   ├── App.css
│   ├── index.js
│   └── index.css
│
├── public
├── package.json
└── README.md
```

---

# Features Implemented

## 1. Display List of Players

- Created an array containing 11 cricket players.
- Displayed all players using the ES6 **map()** method.
- Displayed both player name and score.

### ES6 Concept Used

- map()
- Arrow Function

---

## 2. Display Players with Score Less Than or Equal to 70

Filtered the player list and displayed players whose score is less than or equal to **70**.

### ES6 Concept Used

- Arrow Functions
- Conditional Filtering

---

## 3. Display Odd and Even Players

Used **Array Destructuring** to separate players into:

- Odd Players
- Even Players

### ES6 Concept Used

- Array Destructuring

Example

```
Odd Players

Sachin1
Virat3
Yuvaraj5

Even Players

Dhoni2
Rohit4
Raina6
```

---

## 4. Merge Two Player Arrays

Created two arrays:

- T20 Players
- Ranji Trophy Players

Merged both arrays using the **Spread Operator**.

### ES6 Concept Used

- Spread Operator (...)

---

# ES6 Features Demonstrated

- map()
- Arrow Functions
- Array Destructuring
- Spread Operator
- Functional Components
- Props

---

# Components Description

## App.js

- Main component
- Stores player data
- Renders all child components

---

## ListofPlayers.js

Displays all cricket players using the **map()** function.

---

## ScoreBelow70.js

Displays players whose score is less than or equal to **70**.

---

## IndianPlayers.js

Implements:

- Odd Player List
- Even Player List
- Array Destructuring
- Spread Operator

---

## ListofIndianPlayers.js

Displays the merged player list.

---

# Output

### Output 1

- List of Players
- Players with Score Less Than or Equal to 70

### Output 2

- Odd Players
- Even Players
- List of Merged Indian Players

---

# How to Run

Install dependencies

```
npm install
```

Start the application

```
npm start
```

The application will run at

```
http://localhost:3000
```

---

# Screenshots

The following screenshots are included in the project:

- App.js
- ListofPlayers.js
- ScoreBelow70.js
- IndianPlayers.js
- ListofIndianPlayers.js
- Application Running
- Output 1
- Output 2
- Folder Structure

---

# Learning Outcomes

After completing this hands-on, I learned:

- How to use ES6 features in React.
- How to render lists using map().
- How to use arrow functions.
- How to perform array destructuring.
- How to merge arrays using the spread operator.
- How to build reusable React components using props.

---

# Author

**Md Arif Ansari**

B.Tech - Computer Science and Engineering

Vignan University

Cognizant Digital Nurture 5.0