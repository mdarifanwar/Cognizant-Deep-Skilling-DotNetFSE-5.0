# Handson 1 - First Web API using ASP.NET Core 8.0

## Objective

Create a simple ASP.NET Core 8.0 Web API with CRUD endpoints using HTTP action verbs.

---

## Technologies

- ASP.NET Core 8.0
- C#
- Swagger

---

## HTTP Verbs

- GET
- POST
- PUT
- DELETE

---

## Endpoints

GET

```
/api/values
```

GET by ID

```
/api/values/{id}
```

POST

```
/api/values
```

PUT

```
/api/values/{id}
```

DELETE

```
/api/values/{id}
```

---

## Run

```bash
dotnet build
dotnet run
```

---

## Swagger

```
https://localhost:7020/swagger
```

---

## Expected Output

GET

```json
[
  "Value 1",
  "Value 2",
  "Value 3"
]
```

---

## Result

Successfully created the first ASP.NET Core 8.0 Web API and tested all CRUD endpoints.