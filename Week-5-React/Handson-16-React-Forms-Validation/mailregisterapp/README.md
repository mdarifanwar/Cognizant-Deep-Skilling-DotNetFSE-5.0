# Week-5 Handson-16: React Forms Validation

## Project Name

**mailregisterapp**

---

# Objective

The objective of this hands-on is to understand how React Forms Validation works using Controlled Components and Event Handling. This application validates user inputs before allowing form submission.

---

# Learning Outcomes

After completing this hands-on, you will be able to:

- Understand React Form Validation.
- Differentiate between HTML Forms and React Forms.
- Implement Controlled Components.
- Validate form inputs using React State.
- Handle user input using Event Handling.
- Perform validation during form submission.
- Display validation messages using JavaScript Alerts.

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

---

# Project Structure

```
mailregisterapp/
│
├── public/
│
├── src/
│   ├── Components/
│   │      └── Register.js
│   │
│   ├── App.js
│   ├── App.css
│   ├── index.js
│   └── index.css
│
├── Screenshots/
│   ├── Folder.png
│   ├── App.js.png
│   ├── Register.js.png
│   ├── App.css.png
│   ├── Application Running.png
│   ├── Output1.png
│   ├── Output2.png
│   ├── Output3.png
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
- Imports the Register component.
- Renders the Register component.

---

## Register.js

This is the main component of the application.

Responsibilities:

- Creates the Registration Form.
- Accepts Full Name.
- Accepts Email.
- Accepts Password.
- Stores form values using React State.
- Uses Controlled Components.
- Performs validation using handleChange().
- Handles form submission using handleSubmit().
- Displays appropriate validation messages.
- Displays "Valid Form" when all validations pass.

---

## App.css

This stylesheet provides the user interface styling.

It includes:

- Center aligned registration form.
- Red heading.
- Input field styling.
- Table layout.
- Submit button styling.
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

Provides global styling for the application.

Includes:

- Default font family.
- White background.
- Removes default browser margin.
- Uses border-box sizing.

---

# Validation Rules

The application validates the following fields before submission:

### Full Name

- Must contain at least **5 characters**.

### Email

- Must contain a valid email format.
- Should include **@** and **.**

### Password

- Must contain at least **8 characters**.

---

# Features

- Registration Form
- Controlled Components
- React State Management
- Event Handling
- Form Validation
- Email Validation using Regular Expression
- Password Validation
- Name Validation
- Success Alert
- Error Alert Messages

---

# Application Workflow

1. User enters Full Name.
2. User enters Email Address.
3. User enters Password.
4. User clicks the Submit button.
5. React validates all fields.
6. If validation fails, an alert displays the corresponding error message.
7. If all validations pass, an alert displays:

```
Valid Form
```

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
- Form Validation
- Regular Expressions (Regex)

---

# Screenshots

## 1. Folder Structure

This screenshot shows the complete project directory, including the `public` folder, `src` folder, `Components` folder, `Screenshots` folder, `package.json`, and `README.md`. It confirms that the project is organized according to the required React application structure.

---

## 2. App.js

This screenshot displays the root component of the application. It imports the `Register` component and renders it, serving as the entry point for the registration form.

---

## 3. Register.js

This screenshot shows the complete implementation of the registration form. It contains the state variables, `handleChange()` method, `handleSubmit()` method, validation logic, regular expression for email validation, and rendering of the form.

---

## 4. App.css

This screenshot displays the CSS used to style the application. It includes the red heading, centered layout, input field styling, spacing, and button styling to match the expected output.

---

## 5. Application Running

This screenshot confirms that the React application is successfully compiled and running on the local development server without any errors.

---

## 6. Output 1

This screenshot demonstrates the validation for the **Full Name** field. When the entered name contains fewer than five characters, the application displays an alert indicating that the full name must be at least five characters long.

---

## 7. Output 2

This screenshot demonstrates the **Email Validation**. If the entered email does not contain a valid format with `@` and `.`, the application displays an alert stating that the email is not valid.

---

## 8. Output 3

This screenshot demonstrates the **Password Validation**. If the entered password contains fewer than eight characters, the application displays an alert indicating that the password must be at least eight characters long.

---

# Expected Output

The application displays:

- A red heading:

```
Register Here!!!
```

The registration form contains:

- Full Name
- Email
- Password
- Submit Button

The application validates:

- Name (minimum 5 characters)
- Email (valid format)
- Password (minimum 8 characters)

If all validations are successful:

```
Valid Form
```

Otherwise, an appropriate validation message is displayed.

---

# Conclusion

This hands-on demonstrates how to build a React Form with validation using Controlled Components and Event Handling. The project validates user input in real time, manages form data through React state, and performs validation during form submission. It provides practical experience in creating secure and user-friendly forms using React.

---

# Author

**Md Arif Ansari**

B.Tech – Computer Science and Engineering

Vignan University

Cognizant Digital Nurture 5.0