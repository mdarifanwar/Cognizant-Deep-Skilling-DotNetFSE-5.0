# Week-5 React
# Handson-2 : React Components

## Aim

Create a React application named **StudentApp** that demonstrates the use of **React Class Components** by creating three components:

- Home
- About
- Contact

Render all three components from the main **App.js** file.

---

# Objectives

## 1. Explain React Components

A **React Component** is an independent, reusable piece of the User Interface (UI). Components allow developers to divide a large application into smaller, manageable, and reusable pieces.

Examples:
- Header
- Footer
- Navigation Bar
- Login Form
- Dashboard

### Advantages
- Reusability
- Easy Maintenance
- Better Code Organization
- Faster Development

---

## 2. Difference Between React Components and JavaScript Functions

| React Component | JavaScript Function |
|-----------------|---------------------|
| Returns JSX | Returns any JavaScript value |
| Used to build UI | Used for programming logic |
| Can receive Props | Receives Parameters |
| Can manage State | Cannot manage React State |
| Reusable UI | Reusable Logic |

---

## 3. Types of React Components

React provides two major types of components.

### Functional Component

A Functional Component is a JavaScript function that returns JSX.

Example:

```jsx
function Home(){
    return <h1>Home Page</h1>;
}
```

### Features

- Easy to write
- Uses React Hooks
- Better performance
- Mostly used in modern React applications

---

### Class Component

A Class Component is created using an ES6 class.

It extends **React.Component** and must contain a **render()** method.

Example:

```jsx
class Home extends React.Component{
    render(){
        return <h1>Home Page</h1>;
    }
}
```

### Features

- Supports State
- Supports Lifecycle Methods
- Uses Constructor
- Uses render() Method

---

## 4. Explain Class Component

A Class Component is a React component written using an ES6 class.

Syntax:

```jsx
class ComponentName extends React.Component{
    render(){
        return(
            <h1>Hello React</h1>
        );
    }
}
```

### Advantages

- Stateful
- Lifecycle Methods
- Reusable
- Easy to Maintain

---

## 5. Explain Function Component

A Function Component is a normal JavaScript function that returns JSX.

Syntax

```jsx
function ComponentName(){
    return(
        <h1>Hello React</h1>
    );
}
```

### Advantages

- Simple
- Lightweight
- Faster
- Supports Hooks

---

## 6. Define Component Constructor

A Constructor is a special method available inside a Class Component.

It is automatically called when the component object is created.

It is mainly used to

- Initialize State
- Bind Methods
- Execute Initial Code

Example

```jsx
constructor(props){
    super(props);

    this.state={
        name:"Student"
    };
}
```

---

## 7. Define render() Function

The **render()** method is mandatory in every Class Component.

It returns JSX which is displayed on the browser.

Example

```jsx
render(){
    return(
        <h2>Welcome to Student Portal</h2>
    );
}
```

Without **render()**, a Class Component cannot display anything.

---

# In this Hands-on Lab You Will Learn

- Create a Class Component
- Create Multiple Components
- Render Components
- Organize Components inside a separate folder
- Import and Export Components
- Build a simple Student Management Portal UI

---

# Prerequisites

Before starting this project, make sure the following software is installed.

- Node.js
- NPM (Node Package Manager)
- Visual Studio Code
- Create React App

---

# Software Used

- React
- JavaScript
- JSX
- HTML
- CSS
- Visual Studio Code
- Node.js

---

# Project Structure

```
Handson-2-React-Components
│
├── StudentApp
│   ├── public
│   ├── src
│   │
│   ├── Components
│   │     ├── Home.js
│   │     ├── About.js
│   │     └── Contact.js
│   │
│   ├── App.js
│   ├── App.css
│   ├── index.js
│   ├── index.css
│   └── ...
│
├── Screenshots
│     ├── About.png
│     ├── Contact.png
│     └── Home.png
│     ├── Output.png
│     └── ReactFolder.png
│     └── StartingApp.png
│
└── README.md
```

---

# Steps Performed

## Step 1

Create React Application

```bash
npx create-react-app StudentApp
```

---

## Step 2

Move inside project

```bash
cd StudentApp
```

---

## Step 3

Create Components folder

```
src
   └── Components
```

---

## Step 4

Create

```
Home.js

About.js

Contact.js
```

---

## Step 5

Write Class Components inside each file.

---

## Step 6

Import all components into **App.js**

```jsx
import Home from "./Components/Home";
import About from "./Components/About";
import Contact from "./Components/Contact";
```

---

## Step 7

Render all components.

```jsx
<Home/>
<About/>
<Contact/>
```

---

## Step 8

Run Application

```bash
npm start
```

---

# Output

The browser displays

```
Welcome to the Home Page of Student Management Portal

Welcome to the About Page of Student Management Portal

Welcome to the Contact Page of Student Management Portal
```

---

# Screenshots

Include the following screenshots inside the **Screenshots** folder.

- VS Code Folder Structure
- Home.js
- About.js
- Contact.js
- App.js
- Terminal Output
- Browser Output

---

# Result

Successfully created a React application named **StudentApp**.

Implemented three **Class Components**:

- Home
- About
- Contact

Imported and rendered all components through **App.js**.

The application executed successfully and displayed all three pages' welcome messages on the browser.

---

# Conclusion

This hands-on demonstrated the fundamentals of React Components. It covered the creation of Class Components, importing and exporting components, rendering multiple components, and understanding React's component-based architecture. This forms the foundation for building scalable and reusable React applications.