# Week-5 Handson-17: React REST API Integration

## Project Name

**fetchuserapp**

---

# Objective

The objective of this hands-on is to understand how to consume REST APIs in a React application using the Fetch API. The application retrieves user information from an external REST API and displays the user's title, first name, last name, and profile picture.

---

# Learning Outcomes

After completing this hands-on, you will be able to:

- Understand REST APIs in React.
- Consume external APIs using the Fetch API.
- Use the React component lifecycle method `componentDidMount()`.
- Handle asynchronous operations using `async` and `await`.
- Store API responses in React State.
- Display dynamic data retrieved from an API.

---

# Prerequisites

Before running this project, ensure the following software is installed:

- Node.js
- npm (Node Package Manager)
- Visual Studio Code
- React 17

---

# Technologies Used

- React JS
- JavaScript (ES6)
- HTML5
- CSS3
- Fetch API
- REST API

---

# Project Structure

```
fetchuserapp/
│
├── public/
│
├── src/
│   ├── Components/
│   │      └── Getuser.js
│   │
│   ├── App.js
│   ├── App.css
│   ├── index.js
│   └── index.css
│
├── Screenshots/
│   ├── Folder.png
│   ├── App.js.png
│   ├── Getuser.js.png
│   ├── App.css.png
│   ├── Application Running.png
│   └── Output.png
│
├── package.json
└── README.md
```

---

# Component Description

## App.js

The App component is the root component of the application.

Responsibilities:

- Imports App.css.
- Imports the Getuser component.
- Renders the Getuser component.

---

## Getuser.js

This is the main component of the application.

Responsibilities:

- Uses the `componentDidMount()` lifecycle method.
- Fetches user data from the Random User REST API.
- Uses the Fetch API with asynchronous programming (`async` and `await`).
- Converts the response into JSON format.
- Stores the user information in the component state.
- Displays:
  - User Title
  - First Name
  - Last Name
  - Profile Image

---

## App.css

Provides styling for the application.

Features include:

- Center-aligned content.
- Styled heading.
- User information layout.
- Image styling.
- Proper spacing and alignment.

---

## index.js

The entry point of the React application.

Responsibilities:

- Imports React.
- Imports ReactDOM.
- Imports App component.
- Renders the application inside the root element.

---

## index.css

Provides global styling.

Includes:

- Default font family.
- White background.
- Removes browser default margin.
- Uses border-box sizing.

---

# Features

- REST API Integration
- Fetch API
- Asynchronous Programming
- componentDidMount()
- React State Management
- Dynamic Data Rendering
- User Profile Display
- Profile Image Display

---

# Application Workflow

1. The React application starts.
2. The `Getuser` component is rendered.
3. The `componentDidMount()` lifecycle method is executed.
4. A request is sent to the Random User REST API.
5. The API returns user details in JSON format.
6. The response is stored in the component state.
7. The application displays:
   - User Title
   - First Name
   - Last Name
   - Profile Picture

---

# React Concepts Used

- Class Components
- State
- setState()
- Lifecycle Methods
- componentDidMount()
- Fetch API
- REST API
- Async / Await
- JSON Parsing
- Dynamic Rendering

---

# API Used

```
https://api.randomuser.me/
```

The application fetches random user details from this public REST API and displays the information on the webpage.

---

# Screenshots

## 1. Folder Structure

This screenshot shows the complete project directory, including the `public` folder, `src` folder, `Components` folder, `Screenshots` folder, `package.json`, and `README.md`.

---

## 2. App.js

This screenshot displays the root component of the application. It imports the `Getuser` component and renders it to display user information fetched from the API.

---

## 3. Getuser.js

This screenshot contains the complete implementation of the `Getuser` component. It demonstrates the use of the `componentDidMount()` lifecycle method, the Fetch API, asynchronous programming with `async`/`await`, state management, and rendering the fetched user details.

---

## 4. App.css

This screenshot shows the CSS used to style the application, including the layout, heading, user details, profile image, spacing, and alignment.

---

## 5. Application Running

This screenshot confirms that the React application is successfully compiled and running on the local development server without any errors.

---

## 6. Output

This screenshot displays the final output of the application. It shows the user information retrieved from the Random User API, including the title, first name, last name, and profile picture.

---

# Expected Output

The application displays:

- User Title
- First Name
- Last Name
- Profile Image

Example:

```
Title : Mr

First Name : Donato

Last Name : Nunes

(Profile Image)
```

**Note:** The displayed user details may change every time the application is refreshed because the Random User API returns a randomly generated user.

---

# Conclusion

This hands-on demonstrates how to integrate a REST API into a React application using the Fetch API. It explains how to use the `componentDidMount()` lifecycle method to retrieve data asynchronously, store the API response in React state, and dynamically render user information on the webpage. This project provides a strong foundation for working with external APIs in React applications.

---

# Author

**Md Arif Ansari**

B.Tech – Computer Science and Engineering

Vignan University

Cognizant Digital Nurture 5.0