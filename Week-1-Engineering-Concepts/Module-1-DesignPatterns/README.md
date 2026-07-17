# Exercise 1: Implementing the Singleton Pattern

## Objective

The objective of this exercise is to implement the Singleton Design Pattern in C#. The Singleton Pattern ensures that a class has only one instance throughout the application's lifecycle and provides a global point of access to that instance.

---

## Scenario

A logging utility is required in an application. Only one instance of the Logger class should exist so that logging remains consistent across the entire application.

---

## Technologies Used

- C#
- .NET 8 Console Application
- Visual Studio 2026

---

## Project Structure

```
SingletonPatternExample
│
├── Logger.cs
├── Program.cs
├── SingletonPatternExample.csproj
├── README.md
└── Output.png
```

---

## Implementation

### Logger Class

- Private static instance of Logger.
- Private constructor to prevent object creation using `new`.
- Public static `GetInstance()` method to return the single instance.
- `Log()` method to display log messages.

### Program Class

- Calls `Logger.GetInstance()` twice.
- Logs two messages.
- Verifies that both references point to the same Logger instance.

---

## Expected Output

```
Logger Instance Created
Log: Application Started
Log: User Logged In

Only one Logger instance exists.
```

---

## Output Screenshot

![Program Output](Output.png)

---

## Conclusion

The Singleton Design Pattern was successfully implemented in C#. The Logger object was created only once, and the same instance was reused throughout the application, fulfilling the Singleton Pattern requirements.