# Handson-1 : JWT Authentication in ASP.NET Core Web API

## Objective

Implement JWT (JSON Web Token) Authentication in an ASP.NET Core Web API application to secure API endpoints using Authentication and Authorization.

---

# Technology Stack

- ASP.NET Core Web API (.NET 8)
- C#
- JWT Authentication
- Swagger UI
- Swashbuckle.AspNetCore
- Visual Studio 2022

---

# Project Structure

```
Handson-1-Microservices-JWT
│
├── JwtAuthApi
│   ├── Controllers
│   │   ├── AuthController.cs
│   │   └── EmployeeController.cs
│   │
│   ├── Models
│   │   ├── LoginModel.cs
│   │   └── User.cs
│   │
│   ├── Properties
│   │   └── launchSettings.json
│   │
│   ├── Program.cs
│   ├── appsettings.json
│   ├── JwtAuthApi.csproj
│   └── JwtAuthApi.slnx
│
├── Screenshots
│   ├── Swagger Home.png
│   ├── JWT Token Generated.png
│   ├── Authorized Endpoint.png
│   └── Login API.png
│
└── README.md
```

---

# Features

- User Login API
- JWT Token Generation
- Secure API using Authorization
- Protected Endpoint using `[Authorize]`
- Swagger UI Integration
- Swagger JWT Authorization Support

---

# NuGet Packages

- Microsoft.AspNetCore.Authentication.JwtBearer
- Swashbuckle.AspNetCore
- System.IdentityModel.Tokens.Jwt

---

# API Endpoints

## Login

**POST**

```
/api/Auth/login
```

Request

```json
{
  "username": "admin",
  "password": "admin123"
}
```

Response

```json
{
  "message": "Login Successful",
  "token": "JWT Token"
}
```

---

## Protected Endpoint

**GET**

```
/api/Employee
```

Authorization Header

```
Bearer <JWT Token>
```

Response

```json
[
  {
    "id": 1,
    "name": "Arif",
    "department": "IT"
  },
  {
    "id": 2,
    "name": "Rahul",
    "department": "HR"
  },
  {
    "id": 3,
    "name": "Amit",
    "department": "Finance"
  }
]
```

---

# How to Run

## Restore Packages

```bash
dotnet restore
```

## Build Project

```bash
dotnet build
```

## Run Project

```bash
dotnet run
```

Open Swagger

```
http://localhost:5000/swagger
```

---

# Testing Steps

1. Open Swagger UI.
2. Execute **POST /api/Auth/login**.
3. Copy the generated JWT Token.
4. Click **Authorize**.
5. Enter:

```
Bearer <JWT Token>
```

6. Execute **GET /api/Employee**.
7. Verify the protected endpoint returns employee data.

---

# Screenshots

- Swagger Home
- Login API
- JWT Token Generated
- Authorized Endpoint

---

# Learning Outcomes

- JWT Authentication
- JWT Token Generation
- Authentication and Authorization
- Securing ASP.NET Core Web APIs
- Swagger Integration with JWT
- Protecting API Endpoints using `[Authorize]`

---

# Result

Successfully implemented JWT Authentication and Authorization in an ASP.NET Core Web API using JSON Web Tokens (JWT). The application generates a JWT token after successful login and allows authenticated users to access protected API endpoints through Swagger.