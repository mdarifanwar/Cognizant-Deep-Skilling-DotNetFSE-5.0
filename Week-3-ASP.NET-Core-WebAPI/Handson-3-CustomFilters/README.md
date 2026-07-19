# Handson 3 - Custom Model, Authorization Filter & Exception Filter

## Objective

Implement:

- Custom Employee Model
- HTTP GET, POST and PUT APIs
- FromBody Attribute
- Custom Authorization Filter
- Custom Exception Filter
- Swagger Testing

---

## Technologies

- ASP.NET Core 8
- C#
- Swagger
- Action Filters

---

## Models

- Employee
- Department
- Skill

---

## Filters

### CustomAuthFilter

Checks:

- Authorization Header
- Bearer Token

Responses

- 400 Bad Request
- Invalid request - No Auth token
- Invalid request - Token present but Bearer unavailable

---

### CustomExceptionFilter

- Logs exceptions into ExceptionLog.txt
- Returns HTTP 500

---

## Endpoints

| Method | Endpoint |
|---------|----------|
| GET | /api/employee |
| GET | /api/employee/standard |
| POST | /api/employee |
| PUT | /api/employee/{id} |

---

## Run

```bash
dotnet build
dotnet run
```

---

## Swagger

```
http://localhost:5040/swagger
```

---

## Author

Md Arif Ansari