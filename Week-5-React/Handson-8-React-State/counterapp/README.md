# Week-5 Handson-8 : React State

## Aim

To understand the concept of **React State** by creating a React application that counts the number of people entering and exiting a mall.

---

# Objective

- Explain React State.
- Understand how state is managed in a class component.
- Learn how `setState()` updates component data.
- Handle button click events in React.
- Display dynamic data using state.

---

# Prerequisites

- Node.js
- NPM
- Visual Studio Code
- React 17

---

# Project Structure

```
Handson-8-React-State/
│
├── public/
│
├── src/
│   │
│   ├── Components/
│   │     └── CountPeople.js
│   │
│   ├── App.js
│   ├── App.css
│   ├── index.js
│   ├── index.css
│   └── reportWebVitals.js
│
├── Screenshots/
│   ├── Folder Structure.png
│   ├── npm install.png
│   ├── React Application Running.png
│   ├── Output.png
│   └── App.png
│
├── package.json
├── package-lock.json
└── README.md
```

---

# Components Used

## 1. App Component

The `App` component is the root component of the application.

It renders the `CountPeople` component.

```jsx
<App>
    <CountPeople />
</App>
```

---

## 2. CountPeople Component

This is a **Class Component**.

It stores two state variables.

```javascript
this.state = {
    entrycount: 0,
    exitcount: 0
};
```

---

# State Variables

| Variable | Purpose |
|-----------|----------|
| entrycount | Stores number of people entered |
| exitcount | Stores number of people exited |

---

# Methods

## updateEntry()

This method increments the entry count.

```javascript
updateEntry = () => {
    this.setState((prevState) => ({
        entrycount: prevState.entrycount + 1
    }));
};
```

### Working

- Login button clicked
- Previous state is read
- Entry count increases by 1
- UI updates automatically

---

## updateExit()

This method increments the exit count.

```javascript
updateExit = () => {
    this.setState((prevState) => ({
        exitcount: prevState.exitcount + 1
    }));
};
```

### Working

- Exit button clicked
- Previous state is read
- Exit count increases by 1
- UI updates automatically

---

# React State

State is an object that stores data of a component.

Whenever state changes, React automatically re-renders the component.

Example

```javascript
this.state = {
    entrycount: 0,
    exitcount: 0
};
```

State should always be updated using

```javascript
this.setState()
```

Never update state directly.

❌ Wrong

```javascript
this.state.entrycount++;
```

✅ Correct

```javascript
this.setState({
    entrycount: this.state.entrycount + 1
});
```

---

# Event Handling

React handles button click events using `onClick`.

Example

```jsx
<button onClick={this.updateEntry}>
    Login
</button>
```

---

# Application Workflow

1. React application starts.
2. `CountPeople` component is rendered.
3. State is initialized with `entrycount = 0` and `exitcount = 0`.
4. User clicks **Login** button.
5. `updateEntry()` is executed.
6. Entry count increases by 1.
7. User clicks **Exit** button.
8. `updateExit()` is executed.
9. Exit count increases by 1.
10. React automatically updates the UI.

---

# Initial Output

```
Login 0 People Entered!!!
Exit 0 People Left!!!
```

---

# Example

Click Login button 3 times.

```
Login 3 People Entered!!!
```

Click Exit button 2 times.

```
Exit 2 People Left!!!
```

This matches the expected output provided in the Cognizant handson.

---

# React Concepts Learned

- React State
- Class Components
- Constructor
- setState()
- Event Handling
- Button Click Events
- JSX
- Conditional UI Update
- React Rendering

---

# Commands Used

Install dependencies

```bash
npm install
```

Run application

```bash
npm start
```

Create production build

```bash
npm run build
```

---

# Output

The application displays two buttons.

- Login
- Exit

When the Login button is clicked, the entry count increases.

When the Exit button is clicked, the exit count increases.

The values are updated instantly using React State.

---

# Conclusion

In this handson, we learned how React State works inside a Class Component. We used the constructor to initialize state, updated state using `setState()`, handled button click events, and observed React automatically re-render the UI whenever the state changed. This demonstrates how state enables dynamic and interactive React applications.