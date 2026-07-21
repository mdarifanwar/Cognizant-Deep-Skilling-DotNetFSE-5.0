# Week-5 React

# Handson-6: Fetching Data from REST API using React

## Aim

The aim of this hands-on is to learn how to consume REST APIs in React using the Fetch API and display the retrieved data in a React component.

---

# Objectives

After completing this hands-on, you will be able to:

- Understand REST APIs.
- Consume REST APIs from React.
- Use Fetch API for HTTP requests.
- Work with asynchronous programming.
- Update React state after receiving API data.
- Display dynamic data in React.

---

# Concepts Explained

## What is REST API?

REST (Representational State Transfer) is an architecture used for communication between client and server.

React applications send HTTP requests to a server and receive data in JSON format.

Example

https://api.randomuser.me/

---

## What is Fetch API?

Fetch API is JavaScript's built-in API used for making HTTP requests.

Example

```javascript
fetch(url)
```

It returns a Promise.

---

## Async and Await

Async/Await makes asynchronous code easier to read.

Example

```javascript
const response = await fetch(url);
```

The program waits until the request completes.

---

## componentDidMount()

componentDidMount() is a React lifecycle method.

It executes automatically after the component is rendered.

It is commonly used for:

- Fetching API data
- Database calls
- Loading external resources

---

## React State

State stores dynamic data.

Example

```javascript
this.state = {
person:null,
loading:true
}
```

After receiving data,

```javascript
this.setState()
```

updates the UI automatically.

---

## JSON Response

The Random User API returns JSON.

Example

```json
{
"results":[
{
"name":{
"title":"Mr",
"first":"John",
"last":"Smith"
}
}
]
}
```

---

# Project Structure

```text
Handson-6-FetchAPI

│

├── fetchuserapp

│

├── public

├── src

│ ├── Components

│ │ └── GetUser.js

│ ├── App.js

│ ├── index.js

│ └── App.css

│

├── package.json

└── README.md
```

---

# Implementation Steps

### Step 1

Create React project

```bash
npx create-react-app fetchuserapp
```

### Step 2

Create Components folder.

### Step 3

Create GetUser.js.

### Step 4

Implement componentDidMount().

### Step 5

Fetch data using Fetch API.

### Step 6

Store data inside state.

### Step 7

Display user title, name and image.

### Step 8

Run project

```bash
npm start
```

---

# Technologies Used

- React JS
- JavaScript
- Fetch API
- REST API
- HTML
- CSS
- Visual Studio Code
- Node.js
- NPM

---

# Screenshots

Include the following screenshots inside the Screenshots folder.

- Folder Structure
- GetUser.js
- App.js
- React Application Running
- Output
- README.md

---

# Learning Outcome

After completing this hands-on, I learned:

- How REST APIs work.
- Fetch API usage.
- componentDidMount().
- Async/Await.
- React State.
- Rendering API data.
- Displaying images from API.

---

# Conclusion

This hands-on demonstrated how React applications communicate with REST APIs using the Fetch API. Data was successfully retrieved from the Random User API, stored in the component state, and rendered dynamically on the webpage.