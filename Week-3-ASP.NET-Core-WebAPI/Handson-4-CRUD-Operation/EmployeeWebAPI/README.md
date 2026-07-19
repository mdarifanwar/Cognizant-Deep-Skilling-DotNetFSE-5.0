# Handson 4 - ASP.NET Core Web API CRUD Operations

## Objective

This project demonstrates CRUD (Create, Read, Update and Delete) operations using ASP.NET Core Web API.

### Features

- GET All Employees
- GET Employee By Id
- POST Create Employee
- PUT Update Employee
- DELETE Employee
- Uses FromBody attribute
- Returns ActionResult
- Uses hardcoded employee list
- Tested using Swagger and POSTMAN

---

## Technologies Used

- ASP.NET Core 8.0
- C#
- Swagger (Swashbuckle)

---

## API Endpoints

### Get All Employees

```
GET /api/Employee
```

---

### Get Employee By Id

```
GET /api/Employee/{id}
```

Example

```
GET /api/Employee/1
```

---

### Create Employee

```
POST /api/Employee
```

Sample JSON

```json
{
  "id": 3,
  "name": "Rohit",
  "salary": 55000,
  "permanent": true,
  "department": {
    "id": 3,
    "name": "Finance"
  },
  "skills": [
    {
      "id": 5,
      "name": "Accounting"
    }
  ],
  "dateOfBirth": "2000-08-20T00:00:00"
}
```

---

### Update Employee

```
PUT /api/Employee/{id}
```

Example

```
PUT /api/Employee/1
```

Sample JSON

```json
{
  "id": 1,
  "name": "Arif Updated",
  "salary": 70000,
  "permanent": true,
  "department": {
    "id": 1,
    "name": "IT"
  },
  "skills": [
    {
      "id": 1,
      "name": "ASP.NET Core"
    }
  ],
  "dateOfBirth": "2002-05-10T00:00:00"
}
```

---

### Delete Employee

```
DELETE /api/Employee/{id}
```

Example

```
DELETE /api/Employee/1
```

---

## Validation

- If id <= 0

Returns

```
400 Bad Request

Invalid employee id
```

- If employee id does not exist

Returns

```
400 Bad Request

Invalid employee id
```

---

## Expected Output

- Employee data updated successfully.
- Employee deleted successfully.
- Invalid id returns BadRequest.
- APIs tested successfully using Swagger and POSTMAN.