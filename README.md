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

All tests were executed and passed.

## Security Fixes Applied
- SQL Injection: Fixed using Entity Framework Core parameterized queries
- XSS Attacks: Fixed with proper output encoding and sanitization
- Unauthorized Access: Fixed with strict role-based authorization middleware

Repository created for peer review.
