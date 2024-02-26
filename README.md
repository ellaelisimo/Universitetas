# Universitetas

## Introduction

This is basic application for University. It has database with departments, students and lectures.

## Setup

### Prerequisites

Make sure you have installed the following:

- dotnet 3.1 or later

### Building the application

```bash
dotnet build
```

### Running the application

```bash
dotnet run
```

### Database

The application uses a PostgreSQL database. Here is the database schema:

```sql
CREATE TABLE IF NOT EXISTS studentai
(
    studentas_id SERIAL PRIMARY KEY,
    studentas_name VARCHAR(100) NOT NULL,
    studentas_lastname VARCHAR(100) NOT NULL,
    departamentas_id INT,
    paskaita_id INT,
    FOREIGN KEY (departamentas_id) REFERENCES departamentai (departamentas_id),
    FOREIGN KEY (paskaita_id) REFERENCES paskaitos (paskaita_id)
)

CREATE TABLE IF NOT EXISTS departamentai 
(
    departamentas_id SERIAL PRIMARY KEY,
    departamentas_name VARCHAR(100) NOT NULL,
    studentas_id INT,
    paskaita_id INT,
    FOREIGN KEY (studentas_id) REFERENCES studentai (studentas_id),
    FOREIGN KEY (paskaita_id) REFERENCES paskaitos (paskaita_id)
)

CREATE TABLE IF NOT EXISTS paskaitos
(
    paskaita_id SERIAL PRIMARY KEY,
    paskaita_name VARCHAR(100) NOT NULL,
    departamentas_id INT,
    FOREIGN KEY (departamentas_id) REFERENCES departamentai (departamentas_id)
)
```

## API Documentation

### Endpoints

### Departamentai

- `GET /departamentai`: Returns a list of all departments
- `POST /departamentai`: Creates new department

### Paskaitos

- `GET /paskaitos`: Returns a list of all lectures
- `PUT /paskaitos`: Creates new lecture
- `PUT /paskaitos{id}`: Assignes department to a lecture

### Studentai

- `GET /studentai`: Returns a list of all students
- `PUT /studentai`: Assigns a student to a department
- `GET /studentai{id}`: Returns a student with specified id
