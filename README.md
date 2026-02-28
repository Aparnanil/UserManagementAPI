# UserManagementAPI - Capstone Project (Security & Authentication with Microsoft Copilot)

A secure ASP.NET Core RESTful API for managing user records. Built as part of the **three-phase capstone** using **Microsoft Copilot**.

## How Microsoft Copilot Assisted (All 3 Phases)

**Phase 1 – Writing Secure Code**  
Copilot generated the User model with `[Required]` and `[StringLength]` attributes for input validation and helped write parameterized Entity Framework Core queries to **prevent SQL injection**.

**Phase 2 – Authentication & Authorization**  
Copilot created a custom `AuthMiddleware.cs` and JWT-based authentication with **RBAC** (User/Admin roles). It also added `[Authorize(Roles = "Admin")]` attributes to protect admin endpoints.

**Phase 3 – Debugging Security Issues**  
Initial code had:
- Raw SQL string concatenation (SQL injection risk)
- No input sanitization (XSS risk on responses)
- Missing authorization checks

**Fixes Applied:**
- Switched to EF Core LINQ queries (SQL injection fixed)
- Added `HtmlEncoder` and response headers for XSS protection
- Implemented role-based middleware + JWT validation

## Tests
Unit tests were generated with Copilot (xUnit) to verify login, role-based access, and input validation. All tests pass.

## Vulnerabilities Fixed Summary
- **SQL Injection** → Fixed with parameterized queries (Copilot prompt: "Convert this raw SQL to safe EF Core query")
- **XSS** → Fixed with proper encoding in responses
- **Unauthorized access** → Fixed with JWT + RBAC middleware

Repository created specifically for peer review. All code was generated/debugged with Microsoft Copilot in Visual Studio.
