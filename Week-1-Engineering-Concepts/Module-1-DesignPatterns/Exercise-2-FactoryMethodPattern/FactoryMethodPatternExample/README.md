# Exercise 2: Implementing the Factory Method Pattern

## Objective

To implement the Factory Method Design Pattern in C# using .NET 8.

## Scenario

A document management system needs to create different types of documents such as Word, PDF, and Excel. Instead of creating document objects directly, factory classes are responsible for creating them.

## Design Pattern Used

Factory Method Pattern

## Technologies Used

- C#
- .NET 8
- Visual Studio 2026

## Project Structure

```
FactoryMethodPatternExample
│
├── Documents
│   ├── IDocument.cs
│   ├── WordDocument.cs
│   ├── PdfDocument.cs
│   └── ExcelDocument.cs
│
├── Factories
│   ├── DocumentFactory.cs
│   ├── WordDocumentFactory.cs
│   ├── PdfDocumentFactory.cs
│   └── ExcelDocumentFactory.cs
│
├── Program.cs
├── FactoryMethodPatternExample.csproj
├── README.md
└── Output.png
```

## Expected Output

```
=== Factory Method Pattern Example ===

Word Document Opened Successfully.
PDF Document Opened Successfully.
Excel Document Opened Successfully.

All documents created successfully using Factory Method Pattern.
```

## Conclusion

The Factory Method Pattern provides an interface for creating objects while allowing subclasses to decide which object to instantiate. It promotes loose coupling, flexibility, and scalability.