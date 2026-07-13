# Employee Salary Calculator

## Project Overview

This project demonstrates the implementation of the SOLID Principles using a simple Employee Salary Calculator application developed in C#.

The application calculates an employee's salary based on employee type and demonstrates how software design can be improved using SOLID principles.

---

## Technologies Used

- C#
- .NET 8 Console Application
- Visual Studio 2022

---

# Commit 1 - SRP & ISP

## Single Responsibility Principle (SRP)

Each class has only one responsibility.

### EmployeeRepository

Responsible for employee operations.

Example:
- Add Employee
- View Employee

### SalaryService

Responsible only for salary calculation.

### EmailNotification

Responsible only for sending email notifications.

---

## Interface Segregation Principle (ISP)

Instead of creating one large interface, multiple small interfaces are created.

Example

IEmployeeRepository

ISalaryCalculator

INotification

Each class implements only the interface it requires.

---

# Commit 2 - Open Closed Principle (OCP)

The salary calculation logic is refactored using the Strategy Pattern.

Instead of writing:

if(EmployeeType == "Permanent")
{
}
else if(EmployeeType == "Contract")
{
}

Different salary calculator classes are introduced.

PermanentSalaryCalculator

ContractSalaryCalculator

InternSalaryCalculator

Now a new employee type can be added without modifying existing code.

---

# Commit 3 - Liskov Substitution Principle (LSP)

The classic Rectangle-Square example is implemented.

Initially:

Square inherits Rectangle

This causes an LSP violation.

The design is corrected by making both Rectangle and Square implement the IShape interface independently.

---

# Commit 3 - Dependency Inversion Principle (DIP)

EmployeeManager depends on an abstraction instead of a concrete notification class.

Instead of:

EmailNotification email = new EmailNotification();

The following abstraction is used:

INotification

Implementations:

EmailNotification

SMSNotification

This makes the application loosely coupled and easier to extend.

---

# Folder Structure

EmployeeSalaryCalculator

│

├── Models

│     Employee.cs

│

├── Interfaces

│     IEmployeeRepository.cs

│     ISalaryCalculator.cs

│     INotification.cs

│     IShape.cs

│

├── Services

│     EmployeeRepository.cs

│     SalaryService.cs

│     EmailNotification.cs

│

├── Strategies

│     PermanentSalaryCalculator.cs

│     ContractSalaryCalculator.cs

│     InternSalaryCalculator.cs

│

├── Shapes

│     Rectangle.cs

│     Square.cs

│

├── Program.cs

│

└── README.md

---

## SOLID Principles Covered

| Principle | Description |
|-----------|-------------|
| SRP | One class should have only one responsibility |
| ISP | Create small and focused interfaces |
| OCP | Extend functionality without modifying existing code |
| LSP | Derived classes should be replaceable by base classes |
| DIP | Depend on abstractions instead of concrete implementations |

---
