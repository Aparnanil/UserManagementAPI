# UserManagementAPI

A secure ASP.NET Core Web API for managing user records with robust authentication and authorization.

## Project Overview
This RESTful API provides complete user management functionality including registration, login, and protected endpoints. Security was the primary focus throughout development.

## Features
- User registration and login with secure password hashing
- Role-Based Access Control (RBAC) – User and Admin roles
- JWT authentication
- CRUD operations for user records
- Protected admin endpoints

## Security Measures
- Strong input validation and sanitization
- Parameterized database queries
- Role-based authorization middleware
- Protection against XSS attacks
- Secure session and token handling

## Tests
Unit tests have been added to verify application security.  
All tests are located in the `Tests/` folder and cover:
- Successful and failed login scenarios
- Protection against SQL injection attempts
- Role-based access restrictions
- Input validation rules

Tests were executed and all passed.

## Security Fixes Applied
During development, the following vulnerabilities were identified and resolved:

- **SQL Injection**: Fixed by replacing raw SQL string concatenation with Entity Framework Core parameterized LINQ queries.
- **XSS Attacks**: Fixed through proper output encoding and input sanitization.
- **Unauthorized Access**: Implemented strict role-based authorization checks and middleware.
- **Weak Input Validation**: Added comprehensive model validation attributes.

The application now follows secure coding best practices for authentication, authorization, and data protection.

---

**Repository created for peer review.**
