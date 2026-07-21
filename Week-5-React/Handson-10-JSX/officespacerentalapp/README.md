# Week 5 - Handson 10: React JSX

## Objective

This hands-on demonstrates the implementation of **JSX (JavaScript XML)** in a React application. The project displays office space details using JSX expressions, objects, arrays, inline CSS, and conditional rendering.

---

# Technologies Used

- React JS
- JavaScript (ES6)
- JSX
- HTML5
- CSS3
- Node.js
- Visual Studio Code

---

# Project Structure

```
officespacerentalapp
│
├── public
│   ├── index.html
│   └── office.jpg
│
├── src
│   ├── App.js
│   ├── App.css
│   ├── index.js
│   ├── index.css
│   └── office.jpg (optional)
│
├── Screenshots
│   ├── FolderStructure.png
│   ├── App.js.png
│   ├── Output.png
│   ├── ApplicationRunning.png
│   └── Hint.png
│
├── package.json
├── package-lock.json
└── README.md
```

---

# Objectives Covered

This hands-on demonstrates the following concepts:

- JSX Syntax
- ECMAScript (ES6)
- React.createElement() using JSX
- Rendering JSX into DOM
- JavaScript Expressions inside JSX
- Inline CSS in JSX

---

# Features Implemented

## 1. Display Heading

A heading is created using JSX.

```jsx
<h1>Office Space, at Affordable Range</h1>
```

---

## 2. Display Office Image

An office image is displayed using the `<img>` tag.

```jsx
<img src={officeImage} alt="Office Space" />
```

---

## 3. Create an Office Object

A JavaScript object is created to store office details.

```javascript
const office = {
    Name: "DBS",
    Rent: 50000,
    Address: "Chennai"
};
```

---

## 4. Create a List of Office Objects

Multiple office records are stored inside an array.

```javascript
const officeList = [
    {
        Name: "DBS",
        Rent: 50000,
        Address: "Chennai"
    },
    {
        Name: "Regus",
        Rent: 65000,
        Address: "Bangalore"
    }
];
```

---

## 5. Display Office Details

The office list is displayed using the **map()** method.

```jsx
{
    officeList.map((office, index) => (
        <div key={index}>
            <h2>Name: {office.Name}</h2>
            <h3>Rent: Rs. {office.Rent}</h3>
            <h3>Address: {office.Address}</h3>
        </div>
    ))
}
```

---

## 6. Apply Inline CSS

The Rent value changes color based on the amount.

### Condition

- Rent ≤ 60000 → Red
- Rent > 60000 → Green

```jsx
<h3
style={{
color: office.Rent <= 60000 ? "red" : "green"
}}
>
Rent: Rs. {office.Rent}
</h3>
```

---

# JSX Concepts Used

### JSX

JSX is an extension of JavaScript that allows HTML-like syntax inside JavaScript.

Example

```jsx
<h1>Hello React</h1>
```

---

### JavaScript Expressions

Expressions can be written inside curly braces.

Example

```jsx
<h2>Name: {office.Name}</h2>
```

---

### Object Rendering

JavaScript objects are displayed directly inside JSX.

Example

```jsx
{office.Address}
```

---

### Array Rendering

Arrays are rendered using **map()**.

Example

```jsx
officeList.map(...)
```

---

### Inline CSS

CSS is applied directly inside JSX using the style attribute.

Example

```jsx
style={{ color: "red" }}
```

---

# Components Description

## App.js

Main component of the application.

Responsibilities:

- Displays page heading
- Displays office image
- Stores office data
- Displays office list
- Applies conditional styling

---

## App.css

Contains styling for:

- Heading
- Office Image
- Office Details
- Layout

---

## index.js

Entry point of the React application.

It renders the App component into the DOM.

---

## index.css

Contains global styling for the application.

---

# Output

The application displays:

- Office Space heading
- Office image
- Office Name
- Office Rent
- Office Address
- Multiple office records
- Rent color based on value

---

# Screenshots Included

The project contains the following screenshots:

- Folder Structure
- App.js
- Output
- Application Running
- Hint

---

# How to Run

Install Dependencies

```
npm install
```

Start React Application

```
npm start
```

Application URL

```
http://localhost:3000
```

---

# Learning Outcomes

After completing this hands-on, I learned:

- JSX Syntax
- JavaScript Expressions in JSX
- React Component Structure
- Object Rendering
- Array Rendering using map()
- Conditional Rendering
- Inline CSS in React
- Dynamic Styling using JavaScript Conditions

---

# Author

**Md Arif Ansari**

B.Tech - Computer Science and Engineering

Vignan University

Cognizant Digital Nurture 5.0