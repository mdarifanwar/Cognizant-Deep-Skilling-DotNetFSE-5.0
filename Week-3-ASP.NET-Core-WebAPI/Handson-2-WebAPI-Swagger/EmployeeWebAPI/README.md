# Handson 2 - ASP.NET Core 8.0 Web API with Swagger

## Objective

Create an ASP.NET Core 8.0 Web API and configure Swagger for API documentation and testing.

---

## Technologies Used

- ASP.NET Core 8.0
- C#
- Swagger (Swashbuckle.AspNetCore)
- Postman

---

## HTTP Methods

- GET
- GET By Id
- POST
- PUT
- DELETE

---

## API Endpoints

| Method | Endpoint |
|---------|----------|
| GET | /api/employee |
| GET | /api/employee/{id} |
| POST | /api/employee |
| PUT | /api/employee/{id} |
| DELETE | /api/employee/{id} |

---

## Swagger URL

```
http://localhost:5020/swagger
```

---

## Route Change

Change

```csharp
[Route("api/[controller]")]
```

to

```csharp
[Route("api/emp")]
```

Then access:

```
http://localhost:5020/api/emp
```

---

## Postman

Test all HTTP methods:

- GET
- POST
- PUT
- DELETE

Verify:

- Status Code
- Response Body

---

## Commands

```bash
dotnet build
dotnet run
```

---

## Result

Successfully created an ASP.NET Core 8.0 Web API, configured Swagger, tested endpoints using Swagger and Postman, and verified route modification.