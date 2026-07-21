# Week 5 - Handson 11: React Events

## Objective

This hands-on demonstrates **React Event Handling** by implementing different types of events such as button click events, event handlers, synthetic events, passing arguments to functions, and a Currency Converter using React.

---

# Technologies Used

- React JS
- JavaScript (ES6)
- React Events
- HTML5
- CSS3
- Node.js
- Visual Studio Code

---

# Project Structure

```
eventexamplesapp
│
├── public
│   ├── index.html
│   └── favicon.ico
│
├── src
│   ├── Components
│   │   └── CurrencyConverter.js
│   │
│   ├── App.js
│   ├── App.css
│   ├── index.js
│   └── index.css
│
├── Screenshots
│   ├── App.js.png
│   ├── CurrencyConverter.png
│   ├── Output.png
│   ├── ApplicationRunning.png
│   └── Folder.png
│
├── package.json
├── package-lock.json
└── README.md
```

---

# Objectives Covered

This hands-on demonstrates the following React concepts:

- React Events
- Event Handlers
- Synthetic Events
- Event Naming Convention
- Passing Arguments to Event Handlers
- Multiple Function Calls
- Class Components
- State Management

---

# Features Implemented

## 1. Counter Application

A counter is displayed on the screen.

Two buttons are provided:

- Increment
- Decrement

### Increment Button

When clicked:

- Counter value increases by 1.
- Displays a greeting message using `alert()`.

### Decrement Button

When clicked:

- Counter value decreases by 1.

---

## 2. Multiple Method Invocation

The **Increment** button invokes multiple methods.

```javascript
handleIncrement(){
    this.increment();
    this.sayHello();
}
```

Functions executed:

- increment()
- sayHello()

---

## 3. Say Welcome Button

A button is created to pass an argument to a function.

Example

```javascript
<button onClick={() => this.sayWelcome("Welcome")}>
    Say Welcome
</button>
```

Displays

```
Welcome
```

using an alert dialog.

---

## 4. Synthetic Event

A button named **Click on me** demonstrates React Synthetic Events.

Example

```javascript
<button onClick={this.handleClick}>
    Click on me
</button>
```

Displays

```
I was clicked
```

using an alert.

---

## 5. Currency Converter

A separate **CurrencyConverter** component is created.

The component accepts

- Amount
- Currency

When **Submit** is clicked,

the entered amount is converted using

```
1 Euro = 80 INR
```

Example

Input

```
Amount : 80
Currency : Euro
```

Output

```
Converting to Euro Amount is 6400
```

using an alert dialog.

---

# Components Description

## App.js

Main component of the application.

Responsibilities

- Counter
- Increment Button
- Decrement Button
- Say Welcome Button
- Synthetic Event
- Currency Converter Component

---

## CurrencyConverter.js

Handles

- Amount Input
- Currency Input
- Form Submission
- Currency Conversion
- Alert Display

---

## App.css

Contains styling for

- Buttons
- Layout
- Inputs
- Headings

---

## index.js

Entry point of the application.

Renders

```
<App />
```

inside the root element.

---

## index.css

Contains global styling.

---

# React Concepts Used

## Event Handling

React handles user interactions using event handlers.

Example

```javascript
<button onClick={this.increment}>
```

---

## Synthetic Events

React wraps browser events into Synthetic Events.

Advantages

- Cross-browser compatibility
- Better performance
- Consistent behavior

---

## State

State stores dynamic data.

Example

```javascript
this.state = {
    count: 5
};
```

---

## setState()

Used to update component state.

Example

```javascript
this.setState({
    count: this.state.count + 1
});
```

---

## Arrow Functions

Arrow functions are used to preserve the `this` context.

Example

```javascript
increment = () => {

}
```

---

## Passing Arguments

Arguments are passed using an arrow function.

Example

```javascript
onClick={() => this.sayWelcome("Welcome")}
```

---

# Output

The application displays

- Counter
- Increment Button
- Decrement Button
- Welcome Button
- Click on me Button
- Currency Converter Form
- Alert Messages
- Currency Conversion Result

---

# Screenshots Included

The project contains the following screenshots:

- App.js
- CurrencyConverter Component
- Output
- Application Running
- Folder Structure

---

# How to Run

## Install Dependencies

```bash
npm install
```

## Start the React Application

```bash
npm start
```

The application runs at

```
http://localhost:3000
```

---

# Learning Outcomes

After completing this hands-on, I learned:

- React Event Handling
- Event Naming Convention
- Synthetic Events
- State Management
- setState()
- Passing Arguments to Functions
- Multiple Method Invocation
- React Class Components
- Form Handling
- Currency Conversion Logic
- Component-Based Development

---

# Author

**Md Arif Ansari**

B.Tech – Computer Science and Engineering

Vignan University

Cognizant Digital Nurture 5.0