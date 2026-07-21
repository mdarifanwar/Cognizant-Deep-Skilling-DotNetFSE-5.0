# Week-5 React
# Handson-3: React Function Component with Props & CSS

## Objective

This hands-on demonstrates how to create a React Function Component, pass data using Props, apply CSS styling, and render the component to display student details along with the calculated score.

---

# Learning Objectives

After completing this hands-on, you will be able to:

- Explain React Components.
- Identify the difference between React Components and JavaScript Functions.
- Identify the different types of React Components.
- Explain Class Components.
- Explain Function Components.
- Understand the purpose of a Constructor in Class Components.
- Understand the purpose of the render() function.

---

# In this Hands-on, you will learn

- Create a Function Component.
- Apply CSS styles to React Components.
- Pass data using Props.
- Calculate and display values dynamically.
- Render a React Component.

---

# Prerequisites

Before starting this hands-on, make sure the following software is installed:

- Node.js
- NPM (Node Package Manager)
- Visual Studio Code

---

# Estimated Time

30 Minutes

---

# Theory

## 1. What is a React Component?

A React Component is a reusable piece of UI.

Instead of writing HTML repeatedly, React allows us to create components and reuse them throughout the application.

Example:

```jsx
function Welcome() {
    return <h1>Welcome</h1>;
}
```

---

## 2. React Component vs JavaScript Function

| React Component | JavaScript Function |
|-----------------|--------------------|
| Returns JSX | Returns normal values |
| Used to build UI | Used for logic |
| Component names start with Capital Letter | Any valid function name |
| Can receive Props | Receives parameters |

Example:

React Component

```jsx
function Student() {
    return <h2>Student Details</h2>;
}
```

JavaScript Function

```javascript
function add(a,b){
    return a+b;
}
```

---

## 3. Types of Components

React has two types of components.

### Class Component

- Uses ES6 Classes.
- Extends React.Component.
- Contains render() method.
- Supports lifecycle methods.
- Uses Constructor.

Example:

```jsx
class Student extends React.Component {
    render() {
        return <h2>Hello</h2>;
    }
}
```

---

### Function Component

- Simple JavaScript Function.
- Returns JSX.
- Easier to write.
- Faster and recommended in modern React.

Example

```jsx
function Student() {
    return <h2>Hello</h2>;
}
```

---

## 4. Constructor

Constructor is a special method used in Class Components.

Purpose:

- Initialize State.
- Bind Methods.

Example

```javascript
constructor(props){
    super(props);
}
```

Function Components do not use Constructors.

---

## 5. render() Function

render() is used only in Class Components.

It returns JSX that is displayed on the browser.

Example

```jsx
render(){
    return <h1>Hello</h1>;
}
```

Function Components directly return JSX and therefore do not need render().

---

## 6. Props

Props (Properties) are used to pass data from Parent Component to Child Component.

Example

```jsx
<Student name="John" />
```

Inside component

```jsx
function Student(props){
    return <h2>{props.name}</h2>;
}
```

---

## 7. CSS in React

CSS files can be imported into React Components.

Example

```jsx
import "../Stylesheets/mystyle.css";
```

---

# Project Structure

```
Handson-3-React-Function-Component
│
├── scorecalculatorapp
│
├── public
│
├── src
│   │
│   ├── Components
│   │      └── CalculateScore.js
│   │
│   ├── Stylesheets
│   │      └── mystyle.css
│   │
│   ├── App.js
│   ├── App.css
│   ├── index.js
│   └── index.css
│
├── Screenshots
│      ├── App.png
│      ├── CalculateScore.png
│      └── Folder.png
│      ├── Output.png
│      ├── StartingApp.png
│
└── README.md
```

---

# Implementation Steps

### Step 1

Create React Application

```bash
npx create-react-app scorecalculatorapp
```

---

### Step 2

Move inside project

```bash
cd scorecalculatorapp
```

---

### Step 3

Create folders

```
src
│
├── Components
└── Stylesheets
```

---

### Step 4

Create

```
CalculateScore.js
```

inside Components folder.

---

### Step 5

Create

```
mystyle.css
```

inside Stylesheets folder.

---

### Step 6

Update App.js and call

```
<CalculateScore />
```

with Props.

---

### Step 7

Run Application

```bash
npm start
```

---

# Output

The application displays

```
Student Details

Name : Steeve

School : DNV Public School

Total : 284 Marks

Score : 94.67%
```

---

# What is Happening?

The parent component passes

```jsx
Name
School
total
goal
```

to the child component.

The child component calculates

```
Score = total ÷ goal
```

and formats the result as a percentage before displaying it.

CSS is applied to each field to improve appearance.

---

# Screenshots

Save the following screenshots:

- VS Code Project Structure
- Terminal Output
- React Application Running

Store them inside the **Screenshots** folder.

---

# Technologies Used

- React.js
- JavaScript (ES6)
- JSX
- CSS3
- Node.js
- NPM
- Visual Studio Code

---

# Learning Outcome

After completing this hands-on, I learned to:

- Create Function Components.
- Use Props.
- Apply CSS Styling.
- Render Components.
- Calculate values dynamically.
- Build reusable React Components.