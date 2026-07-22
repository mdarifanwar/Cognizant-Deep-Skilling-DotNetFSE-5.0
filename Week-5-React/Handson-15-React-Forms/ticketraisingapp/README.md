# Week-5 Handson-15: React Forms

## Project Name
**ticketraisingapp**

---

## Objective

The objective of this hands-on is to understand how React Forms work using Controlled Components. The application demonstrates how to collect user input, manage form data using React state, and handle form submission events.

---

## Learning Outcomes

After completing this hands-on, you will be able to:

- Understand React Forms.
- Implement Controlled Components.
- Handle user input using React state.
- Work with Textbox and Textarea controls.
- Handle form submission events.
- Display dynamic data using React state.
- Generate a unique Transaction ID.
- Show confirmation messages using JavaScript Alert.

---

## Prerequisites

Before running this project, ensure the following are installed:

- Node.js
- npm
- Visual Studio Code
- React 17

---

## Technologies Used

- React JS
- JavaScript (ES6)
- HTML5
- CSS3

---

## Project Structure

```
ticketraisingapp/
│
├── public/
│
├── src/
│   ├── Components/
│   │     └── ComplaintRegister.js
│   │
│   ├── App.js
│   ├── App.css
│   ├── index.js
│   └── index.css
│
├── Screenshots/
│
├── package.json
│
└── README.md
```

---

# Component Description

## App.js

- Main component of the application.
- Imports App.css.
- Loads the ComplaintRegister component.

---

## ComplaintRegister.js

This is the main component of the application.

It performs the following tasks:

- Creates a Complaint Registration Form.
- Accepts Employee Name.
- Accepts Complaint Description.
- Stores values using React State.
- Uses Controlled Components.
- Handles user input through handleChange().
- Handles form submission using handleSubmit().
- Generates a random Transaction ID.
- Displays the confirmation using an Alert Box.
- Clears the form after successful submission.

---

## App.css

Provides styling for the application.

Features include:

- Center aligned form
- Large red heading
- Form spacing
- Styled textbox
- Styled textarea
- Submit button styling

---

## index.js

Entry point of the React application.

Responsibilities:

- Imports React.
- Imports ReactDOM.
- Loads App component.
- Renders the application inside the root element.

---

## index.css

Provides global styling.

Includes:

- Default font
- Removes browser margin
- Border-box sizing
- White background

---

# Features

- Complaint Registration Form
- Employee Name Input
- Complaint Textarea
- Controlled Components
- React State Management
- Form Submission
- Dynamic Transaction ID Generation
- Success Alert Message
- Automatic Form Reset

---

# Application Workflow

1. User enters Employee Name.
2. User enters Complaint Details.
3. Clicks the Submit button.
4. Form submission event is triggered.
5. A random Transaction ID is generated.
6. Alert box displays:

```
Thanks <Employee Name>

Your Complaint was Submitted.

Transaction ID is: <Reference Number>
```

7. Form fields are cleared.

---

# React Concepts Used

- Class Components
- State
- setState()
- Controlled Components
- Forms
- Event Handling
- handleChange()
- handleSubmit()
- Dynamic Rendering

---

# Screenshots

## 1. Project Folder Structure

Shows the complete folder hierarchy of the React project including Components, App.js, CSS files, Screenshots folder, and README.md.

---

## 2. App.js

Displays the root component of the application which imports the ComplaintRegister component and renders it.

---

## 3. ComplaintRegister.js

Contains the complete implementation of the complaint registration form.

This component demonstrates:

- React Forms
- Controlled Components
- State Management
- Event Handling
- Form Submission
- Transaction ID Generation

---

## 4. App.css

Contains all styling used in the application including layout, heading color, form alignment, input styling, textarea styling, and submit button design.

---

## 5. Application Running

Shows the application successfully compiled and running using the React development server.

---

## 6. Output

Displays the final output after submitting the complaint.

The alert box confirms successful complaint registration and shows the generated Transaction ID.

---

# Expected Output

The application displays:

- A red heading:
  **Register your complaints here!!!**

- Employee Name textbox

- Complaint textarea

- Submit button

After submission:

An alert box displays:

```
Thanks <Employee Name>

Your Complaint was Submitted.

Transaction ID is: <Random Number>
```

---

# Conclusion

This hands-on demonstrates the implementation of React Forms using Controlled Components. It shows how React state manages form data, how events are handled using handleChange() and handleSubmit(), and how dynamic values such as Transaction IDs can be generated and displayed to users. This project provides a strong foundation for building interactive form-based React applications.

---

# Author

**Md Arif Ansari**

B.Tech - Computer Science & Engineering

Vignan University

Cognizant Digital Nurture 5.0