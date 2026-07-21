# Week 5 - React
# Handson-4 : React Component Lifecycle

## Aim

Create a React application named **blogapp** that demonstrates the React Component Lifecycle by fetching blog posts from an external REST API using the `componentDidMount()` lifecycle method and handling errors using `componentDidCatch()`.

---

# Objectives

After completing this hands-on, you will be able to:

- Explain the need and benefits of the React Component Lifecycle.
- Identify various lifecycle hook methods.
- Understand the sequence of rendering a React component.
- Implement the `componentDidMount()` lifecycle hook.
- Implement the `componentDidCatch()` lifecycle hook.
- Fetch data from a REST API.
- Render dynamic data using React Class Components.

---

# Theory

## What is React Component Lifecycle?

Every React component goes through different phases from creation to destruction. These phases are known as the **Component Lifecycle**.

React automatically calls lifecycle methods at different stages of a component's life.

The lifecycle consists of three phases:

1. Mounting
2. Updating
3. Unmounting

---

# 1. Mounting Phase

The mounting phase occurs when a component is created and inserted into the DOM.

Lifecycle methods:

- constructor()
- render()
- componentDidMount()

### constructor()

- Initializes the component.
- Initializes the state.
- Binds methods if required.
- Executes only once.

Example:

```javascript
constructor(props) {
    super(props);

    this.state = {
        posts: []
    };
}
```

---

### render()

The render() method returns the JSX that should be displayed on the webpage.

Whenever state changes, React automatically calls render() again.

Example:

```javascript
render() {
    return (
        <div>
            <h2>Posts</h2>
        </div>
    );
}
```

---

### componentDidMount()

This method is executed immediately after the component is rendered on the webpage.

It is the best place for:

- API calls
- Database calls
- Fetching data
- Timers
- Event listeners

Example:

```javascript
componentDidMount() {
    this.loadPosts();
}
```

---

# 2. Updating Phase

Whenever the component state or props change, React updates the UI automatically.

Common updating lifecycle methods are:

- shouldComponentUpdate()
- getSnapshotBeforeUpdate()
- componentDidUpdate()

These methods are not used in this hands-on.

---

# 3. Unmounting Phase

When a component is removed from the DOM, React calls:

```javascript
componentWillUnmount()
```

It is generally used to:

- Remove timers
- Remove event listeners
- Cancel API requests

---

# Error Handling Lifecycle

## componentDidCatch()

This lifecycle method catches runtime errors inside child components.

Instead of crashing the application, it allows React to display an error message.

Example:

```javascript
componentDidCatch(error, info) {
    alert(error);
}
```

Benefits:

- Prevents application crash
- Displays meaningful error messages
- Improves user experience

---

# Working of this Application

This project demonstrates fetching blog posts from a public REST API.

The application performs the following steps:

1. React creates the Posts component.
2. Constructor initializes an empty posts array.
3. React renders the component.
4. componentDidMount() executes automatically.
5. loadPosts() calls the REST API.
6. JSON data is received.
7. JSON objects are converted into Post objects.
8. State is updated.
9. React automatically re-renders the page.
10. Blog posts are displayed.

---

# REST API Used

```
https://jsonplaceholder.typicode.com/posts
```

This API returns dummy blog post data in JSON format.

Example response:

```json
{
    "id": 1,
    "title": "Sample Title",
    "body": "Sample Body"
}
```

---

# Project Structure

```
Handson-4-React-Lifecycle
│
├── blogapp
│   ├── public
│   ├── src
│   │
│   ├── App.js
│   ├── Posts.js
│   ├── Post.js
│   ├── index.js
│   ├── App.css
│   │
│   ├── package.json
│   └── package-lock.json
│
├── Screenshots
│   ├── API_Response.png
│   ├── App.png
│   ├── Folder.png
│   └── NPM_Start.png
│   ├── Output.png
│   ├── Post.png
│   └── Posts.png
│
└── README.md
```

---

# Files Explanation

## App.js

- Root component.
- Loads the Posts component.

---

## Post.js

Model class representing a single blog post.

Contains:

- id
- title
- body

---

## Posts.js

Main React Class Component.

Responsibilities:

- Initializes state.
- Calls REST API.
- Converts JSON into Post objects.
- Stores data in state.
- Displays blog posts.
- Handles runtime errors.

---

# Lifecycle Flow

```
Application Starts
        │
        ▼
Constructor
        │
        ▼
Render
        │
        ▼
Component Mounted
        │
        ▼
componentDidMount()
        │
        ▼
loadPosts()
        │
        ▼
Fetch API
        │
        ▼
Receive JSON
        │
        ▼
Update State
        │
        ▼
Render Again
        │
        ▼
Display Blog Posts
```

---

# Technologies Used

- React
- JavaScript (ES6)
- HTML
- CSS
- Fetch API
- JSONPlaceholder REST API
- Visual Studio Code
- Node.js
- NPM

---

# Output

The application displays:

- Blog Post Title
- Blog Post Description

All posts are loaded dynamically from the REST API.

---

# Advantages of React Lifecycle

- Better organization of code
- Automatic rendering
- Easy API integration
- Improved performance
- Error handling support
- Easy maintenance

---

# Conclusion

In this hands-on, a React Class Component was created to demonstrate the React Component Lifecycle. Blog post data was fetched using the Fetch API inside `componentDidMount()`, stored in the component state, and rendered dynamically. Runtime errors were handled using `componentDidCatch()`, providing a practical understanding of lifecycle methods in React.