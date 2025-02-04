# SkillsSprint Project
(In development)

## Overview
This project is built to practice and explore ASP.NET MVC, Business Logic Layer (BLL), and Data Access Layer (DAL) patterns. The goal is to develop a user registration system, utilizing various ASP.NET concepts like controllers, views, models, and services.

For the time being, a fake database will be used to simulate real data interactions.

## Structure
The solution follows a clean separation of concerns by organizing the code into different layers:

- **ASP-MVC**: The web application layer (UI, Controllers, Views).
- **BLL**: The Business Logic Layer (handles business rules, validation).
- **DAL**: The Data Access Layer (handles data interaction, simulated using a fake DB).
- **Common** (optional): For shared helpers, constants, etc.
- **Tests** (optional): For unit and integration tests.

## Project Layers

### 1. ASP-MVC (Web Layer)
- **Controllers**: Handle HTTP requests and responses.
- **Views**: Render user interfaces.
- **Models**: Represent data structures.

### 2. BLL (Business Logic Layer)
- Contains business services and logic.
- Manages entities and performs validation.

### 3. DAL (Data Access Layer)
- Responsible for interaction with the database.
- For now, **a fake database will be used** to simulate database operations.

## Features
- User registration form with validation (via `UserCreateForm`).
- Simulated database operations (CRUD) for user entities.
- A well-structured separation between MVC (UI), BLL (logic), and DAL (data).

## Setup

1. Clone the repository to your local machine.
2. Open the solution in Visual Studio.
3. Build and run the application.
4. The default database interactions will be simulated by a fake DB.

## Dependencies
- **.NET Core / .NET Framework** (based on the version used).
- **ASP.NET MVC** for web-related components.

## Known Issues
- The solution currently uses a fake database for data interaction, as no real database is set up.

## License
This project is for educational purposes only.
