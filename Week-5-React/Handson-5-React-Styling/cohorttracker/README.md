# Week-5 React
# Handson-5: React Styling using CSS Modules

## Aim

The objective of this hands-on is to understand how styling is applied in React applications using CSS Modules and inline styles. This exercise demonstrates how to style reusable React components while keeping styles isolated from other components.

---

# Objectives

After completing this hands-on, you will be able to:

- Understand the need for styling React components.
- Learn the advantages of CSS Modules.
- Apply CSS styles using the `className` property.
- Apply inline styles dynamically.
- Build reusable styled React components.
- Improve the appearance of React applications.

---

# Concepts Explained

## 1. Why Styling is Required in React?

React is responsible for building User Interfaces, but without CSS every page looks plain.

Styling helps to:

- Improve user experience.
- Make applications responsive.
- Increase readability.
- Highlight important information.
- Maintain a professional UI.

---

## 2. CSS Module

A CSS Module is a CSS file whose styles are scoped locally.

Instead of applying styles globally, React generates unique class names internally.

Example:

```css
.box{
    border:1px solid black;
}
```

Import in React:

```javascript
import styles from "./CohortDetails.module.css";
```

Usage:

```jsx
<div className={styles.box}>
```

Benefits:

- No class name conflicts.
- Better maintainability.
- Component-specific styling.
- Easy to reuse.

---

## 3. Inline Styling

Inline styling uses JavaScript objects.

Example:

```jsx
<h3 style={{color:"green"}}>
```

Advantages

- Dynamic styling.
- Easy conditional formatting.
- No external CSS required.

---

## 4. className in React

React uses

```jsx
className
```

instead of

```html
class
```

because **class** is a reserved keyword in JavaScript.

Example

```jsx
<div className={styles.box}>
```

---

## 5. Conditional Styling

React can change styles based on conditions.

Example

```jsx
style={{
color: props.cohort.currentStatus==="Ongoing"
? "green"
: "blue"
}}
```

If status is

```
Ongoing
```

Text becomes Green.

Otherwise

```
Blue
```

---

# Project Structure

```
Handson-5-React-Styling
│
├── cohorttracker
│
├── public
│
│   ├── favicon.ico
│   ├── index.html
│   ├── manifest.json
│   └── robots.txt
│
├── src
│   ├── Cohort.js
│   ├── CohortDetails.js
│   ├── CohortDetails.module.css
│   ├── App.js
│   ├── App.css
│   ├── index.js
│   └── index.css
│
├── package.json
├── package-lock.json
└── README.md
```

---

# Implementation Steps

### Step 1

Download and extract the provided React project.

---

### Step 2

Install project dependencies.

```bash
npm install
```

---

### Step 3

Create

```
CohortDetails.module.css
```

---

### Step 4

Create the CSS class

```css
.box
```

Properties used

- Width = 300px
- Display = inline-block
- Margin = 10px
- Padding Top Bottom = 10px
- Padding Left Right = 20px
- Border = 1px solid black
- Border Radius = 10px

---

### Step 5

Style

```css
dt
```

using

```css
font-weight:500;
```

---

### Step 6

Import CSS Module

```javascript
import styles from "./CohortDetails.module.css";
```

---

### Step 7

Apply CSS Module

```jsx
<div className={styles.box}>
```

---

### Step 8

Apply Conditional Styling

```jsx
<h3
style={{
color:
props.cohort.currentStatus==="Ongoing"
? "green"
: "blue"
}}
>
```

---

### Step 9

Run the application

```bash
npm start
```

---

# Output

The application displays

- Cohort Code
- Technology
- Start Date
- Current Status
- Coach
- Trainer

Each cohort appears inside a styled card.

Status colors

- Ongoing → Green
- Scheduled → Blue

---

# Technologies Used

- React JS
- JavaScript
- CSS Modules
- HTML
- Visual Studio Code
- Node.js
- NPM

---

# Screenshots

The following screenshots are included in the project.

- Folder Structure
- npm install
- CohortDetails.module.css
- CohortDetails.js
- App.js
- React Application Running
- Final Output

All screenshots are available inside the **Screenshots** folder.

---

# Learning Outcome

After completing this hands-on, I learned:

- CSS Modules in React.
- Difference between normal CSS and CSS Modules.
- Applying styles using className.
- Applying inline styles.
- Conditional styling.
- Building reusable styled components.
- Running and testing a React application.

---

# Conclusion

This hands-on provided practical experience in styling React components using CSS Modules and inline styles. The application was successfully built and displayed styled cohort information with conditional formatting based on the current status.