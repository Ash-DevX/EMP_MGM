# Employee Management System (EMP_MGM)

A Windows Desktop Application developed using **C# Windows Forms (.NET Framework)** and **Microsoft SQL Server** for managing employee records efficiently. The application provides secure user authentication, employee record management, salary management, and invoice generation through a user-friendly interface.

---

## Project Overview

Employee Management System (EMP_MGM) is designed to simplify employee administration within an organization. It enables administrators to manage employee details while providing employees with access to salary information and printable salary invoices.

The project follows a simple 3-layer workflow:

- Frontend (Windows Forms UI)
- Business Logic (C#)
- Database (MS SQL Server)

---

## Technologies Used

| Technology | Description |
|------------|-------------|
| Language | C# |
| Framework | .NET Framework |
| IDE | Microsoft Visual Studio |
| Database | Microsoft SQL Server |
| UI | Windows Forms |
| SQL | Stored Procedures |
| Library | Guna.UI2 WinForms |
| Version Control | Git & GitHub |

---

# Features

## User Authentication

- User Registration
- User Login
- Create Password
- Forgot Password
- OTP Verification
- Logout

---

## Admin Module

- Add Employee
- Update Employee Details
- Delete Employee
- Search Employee
- Fetch Employee Records
- View Employee List
- Print Employee Details

---

## Employee Module

- Employee Dashboard
- Salary Details
- Bonus Calculation
- Total Salary
- Employee Photo Upload
- Department Selection
- Gender Selection
- Printable Salary Invoice

---

## Invoice Module

- Generate Employee Salary Invoice
- Print Preview
- Print Invoice
- Employee Image Display

---

# Project Structure

```
EMP_MGM/
│
├── Forms/
│   ├── Login
│   ├── Register
│   ├── Dashboard
│   ├── Employee Dashboard
│   ├── Employee Salary
│   ├── Forgot Password
│   ├── Create Password
│   ├── Invoice
│
├── Database/
│   ├── SQL Database
│   ├── Tables
│   ├── Stored Procedures
│
├── Resources/
│
├── App.config
│
└── README.md
```

---

# Database

Database Name

```
EMP_MGM1
```

### Main Tables

- register_tbl1
- EMP_Details1
- Salary

### Stored Procedures

- sp_register1
- sp_login1
- sp_Create
- sp_forgot
- sp_Insert
- sp_Update
- sp_Delete
- sp_Search
- sp_Fetch
- sp_Salary

---

# Frontend

Designed using **Windows Forms (WinForms)** with modern UI components.

### Frontend Features

- Responsive Form Layout
- Dashboard
- Navigation Panels
- Custom Buttons
- DataGridView
- ComboBox
- TextBox Validation
- Picture Upload
- Print Preview
- User-Friendly Interface

---

# Backend Logic

The application logic is written entirely in **C#**.

Main functionalities include:

- CRUD Operations
- Form Validation
- SQL Server Connectivity
- Stored Procedure Execution
- Login Authentication
- Password Verification
- OTP Generation
- Employee Search
- Salary Calculation
- Invoice Generation
- Exception Handling

---

# MS SQL Server

The application uses Microsoft SQL Server for storing all employee information.

### Database Operations

- INSERT
- UPDATE
- DELETE
- SELECT
- SEARCH
- FETCH

All operations are performed using **Stored Procedures**.

---

# Application Workflow

```
Register
      │
      ▼
Login
      │
      ▼
Dashboard
      │
      ├───────────────┐
      ▼               ▼
 Admin           Employee
      │               │
      ▼               ▼
Manage Records   Salary Details
      │               │
      ▼               ▼
 Database     Generate Invoice
```

---

# Screens Included

- Login Page
- Registration Page
- Forgot Password
- Create Password
- Admin Dashboard
- Employee Dashboard
- Employee Salary Form
- Salary Invoice
- Print Preview

---

# Requirements

- Windows 10 / 11
- Visual Studio 2022
- .NET Framework
- Microsoft SQL Server
- SQL Server Management Studio (SSMS)

---

# Installation

## Clone Repository

```bash
git clone https://github.com/your-username/EMP_MGM.git
```

Open the solution in Visual Studio.

Restore NuGet packages.

Open SQL Server Management Studio.

Create the database:

```sql
CREATE DATABASE EMP_MGM1;
```

Execute all table creation scripts.

Execute all stored procedure scripts.

Update the connection string in:

```
App.config
```

Example:

```xml
<connectionStrings>
<add name="con"
connectionString="Data Source=YOUR_SERVER_NAME;
Initial Catalog=EMP_MGM1;
Integrated Security=True;
TrustServerCertificate=True"/>
</connectionStrings>
```

Run the project.

---

# Future Improvements

- Role-Based Authentication
- Dashboard Analytics
- Attendance Management
- Leave Management
- Payroll System
- Email Notifications
- Export to PDF
- Export to Excel
- Cloud Database Support
- Responsive UI Design

---

# Learning Outcomes

This project demonstrates knowledge of:

- C# Programming
- Object-Oriented Programming (OOP)
- Windows Forms Development
- Microsoft SQL Server
- Stored Procedures
- CRUD Operations
- Exception Handling
- Database Connectivity (ADO.NET)
- User Authentication
- Git & GitHub

---

# LinkedIn
(https://www.linkedin.com/in/ashwin-e-a7699b308/)

---
