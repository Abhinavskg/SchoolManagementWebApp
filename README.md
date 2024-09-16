# School Management System Web Application

This project is a **School Management System** web application built using **ASP.NET Core 7 MVC**. It is designed to help developers learn how to build scalable, cross-platform web applications, and manage core school activities such as student enrollment, teacher management, and class schedules.

## Table of Contents
- [Technologies](#technologies)
- [Getting Started](#getting-started)
- [Project Structure](#project-structure)
- [Features](#features)
- [Documentation](#documentation)
- [Contributing](#contributing)

## Technologies
The project leverages the following technologies:
- **ASP.NET Core 7 MVC**: The framework for building web applications.
- **Entity Framework Core**: Used for database access and management.
- **SQL Server**: The relational database management system.
- **Bootstrap**: CSS framework for responsive web design.
- **jQuery**: JavaScript library for interactive features.
- **AutoMapper**: Object-to-object mapping tool.

## Getting Started
Follow these steps to set up and run the project locally:

1. **Clone the repository**:
   ```bash
   git clone https://github.com/your-repo/school-management-system.git
   ```

2. **Install dependencies**:
   Ensure you have the latest version of the .NET Core SDK and SQL Server installed.

3. **Update the connection string**:
   Modify the `appsettings.json` file in the project to reflect your SQL Server connection details:
   ```json
   "ConnectionStrings": {
      "DefaultConnection": "Server=your_server;Database=SchoolDb;Trusted_Connection=True;"
   }
   ```

4. **Set up the database**:
   Run the following commands to create the database schema:
   ```bash
   dotnet ef database update --project SchoolManagementSystem.Infrastructure --startup-project SchoolManagementSystem.Web
   ```

5. **Run the application**:
   Start the web application using the following command:
   ```bash
   dotnet run --project SchoolManagementSystem.Web
   ```

## Project Structure
The solution contains the following projects:

- **SchoolManagementSystem.Web**: Handles the MVC controllers, views, and web app logic.
- **SchoolManagementSystem.Infrastructure**: Manages the data models, database, and Entity Framework configurations.

## Features
The application provides a range of functionalities for managing a school system:

1. **Authentication and Authorization**:
   - OAuth and cookie-based authentication system.
   - Role-based access control (e.g., Admin, Teacher, Student).
   
2. **CRUD Operations**:
   - Full CRUD support for Students, Teachers, and Classes.
   
3. **Search Functionality**:
   - Search through the list of Students, Teachers, and Classes.

4. **Form Validation**:
   - Server-side and client-side form validation to ensure data integrity.

5. **Exception Handling**:
   - Middleware for handling application-wide exceptions.

6. **Responsive Design**:
   - Bootstrap is used for a responsive and mobile-friendly UI.

## Documentation
This repository includes comprehensive documentation for all key features, including:

- **Authentication**: How to implement and customize user authentication.
- **CRUD Operations**: Detailed explanations of controllers and views for managing data.
- **Search**: Instructions on how the search functionality is implemented.
- **Form Validation**: Ensuring data accuracy with model binding and validation attributes.

## Contributing
We welcome contributions to the project. To contribute:

1. **Fork the repository**.
2. **Create a new branch** for your feature or fix.
3. **Commit your changes** and ensure they are well-documented.
4. **Submit a pull request** and explain your changes.

All contributions should adhere to coding standards and best practices.
