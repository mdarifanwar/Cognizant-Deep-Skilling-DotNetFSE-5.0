# Handson-1 : React Environment Setup

# Concepts Covered

## 1. Single Page Application (SPA)

A Single Page Application (SPA) is a web application that loads a single HTML page and dynamically updates content without reloading the entire page.

### Benefits
- Faster navigation
- Better user experience
- Reduced server requests
- Smooth page transitions

---

## 2. React

React is an open-source JavaScript library developed by Meta (Facebook) for building fast and interactive user interfaces using reusable components.

### Features of React
- Component-Based Architecture
- Virtual DOM
- One-Way Data Binding
- JSX Support
- High Performance
- Reusable Components
- Easy State Management

---

## 3. SPA vs MPA

| SPA | MPA |
|-----|-----|
| Loads one HTML page | Loads a new page for every request |
| Faster navigation | Slower navigation |
| Better user experience | Page refresh on every request |
| Uses JavaScript heavily | Server-side rendering |

---

## 4. Pros of SPA

- Fast Performance
- Better User Experience
- Less Server Load
- Easy API Integration
- Faster Development

---

## 5. Cons of SPA

- Initial loading time can be higher
- SEO is comparatively difficult
- JavaScript dependency
- Browser history management

---

## 6. Virtual DOM

Virtual DOM is a lightweight copy of the Real DOM.

React first updates the Virtual DOM, compares it with the previous version (Diffing), and updates only the changed elements in the Real DOM.

This improves application performance.

---

## 7. React Working

1. User performs an action.
2. State changes.
3. Virtual DOM is updated.
4. React compares old and new Virtual DOM.
5. Only changed elements are updated in the Real DOM.
6. UI is refreshed efficiently.



## Objective

Create a React application named **myfirstreact** and display:

> Welcome to the first session of React

---

## Technology

- React
- JavaScript
- Node.js
- NPM
- Visual Studio Code

---

## Project Structure

```
Handson-1-React-Setup
│
├── myfirstreact
├── Screenshots
└── README.md
```

---

## Create Project

```bash
npx create-react-app myfirstreact
```

Navigate to project

```bash
cd myfirstreact
```

Open VS Code

```bash
code .
```

Run

```bash
npm start
```

---

## App.js

```javascript
function App() {
  return (
    <div>
      <h1>Welcome to the first session of React</h1>
    </div>
  );
}

export default App;
```

---

## Output

```
Welcome to the first session of React
```

---

## Screenshots

- React Project Created
- App.js Code
- Output

---

## Result

Successfully created a React application using Create React App and displayed the required heading.