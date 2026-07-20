# Handson 5 - JWT Authentication and CORS in ASP.NET Core Web API

## Objective

This project demonstrates:

- CORS Configuration
- JWT Authentication
- Bearer Token Authentication
- Role Based Authorization
- Claims
- Token Expiration
- Swagger Integration
- POSTMAN Testing

---

## Technologies Used

- ASP.NET Core 8.0
- C#
- JWT Bearer Authentication
- Swagger
- Postman

---

## NuGet Packages

- Microsoft.AspNetCore.Authentication.JwtBearer
- Microsoft.IdentityModel.Tokens
- System.IdentityModel.Tokens.Jwt
- Swashbuckle.AspNetCore

---

## Project Structure

```
EmployeeWebAPI
│
├── Controllers
│   ├── AuthController.cs
│   └── EmployeeController.cs
│
├── Models
│   ├── Employee.cs
│   ├── Department.cs
│   └── Skill.cs
│
├── Properties
│   └── launchSettings.json
│
├── Program.cs
├── EmployeeWebAPI.csproj
├── EmployeeWebAPI.http
├── appsettings.json
├── appsettings.Development.json
└── README.md
```

---

## API Endpoints

### Generate JWT Token

```
GET /api/Auth
```

Returns JWT Token.

---

### Get All Employees

```
GET /api/Employee
```

Authorization Required

```
Bearer Token
```

---

### Get Employee By Id

```
GET /api/Employee/{id}
```

---

### Create Employee

```
POST /api/Employee
```

---

### Update Employee

```
PUT /api/Employee/{id}
```

---

### Delete Employee

```
DELETE /api/Employee/{id}
```

---

## JWT Configuration

Security Key

```
mysuperdupersecret
```

Issuer

```
mySystem
```

Audience

```
myUsers
```

Token Expiry

```
10 Minutes
```

---

## Authentication Flow

1. Call Auth API.
2. Copy JWT Token.
3. Click **Authorize** in Swagger or add the token in Postman.
4. Access Employee APIs.
5. Without token → 401 Unauthorized.
6. Invalid token → 401 Unauthorized.
7. Expired token → 401 Unauthorized.

---

## Role Based Authorization

Allowed Roles

```
Admin
POC
```

Only users having these roles can access Employee APIs.

---

## CORS

CORS is enabled using:

```
AllowAnyOrigin()
AllowAnyHeader()
AllowAnyMethod()
```

---

## Expected Outputs

- JWT Generated Successfully
- Employee APIs return 200 OK
- Missing Token returns 401 Unauthorized
- Invalid Token returns 401 Unauthorized
- Expired Token returns 401 Unauthorized
- Role Validation works successfully

---

## Author

Md Arif Ansari