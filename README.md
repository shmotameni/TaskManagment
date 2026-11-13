#Task Management System

A microservices-based Task Management application developed using C# and ASP.NET Core Web API.
The main goal of this project is to explore and practice microservices architecture, distributed systems, service-to-service communication, and modern backend development with .NET.

* Project Overview

The Task Management System allows users to manage their tasks, track task progress, and receive notifications.
The application is designed using a microservices architecture, where each service has a specific business responsibility and can be developed and deployed independently.

* Architecture

The project is planned to consist of the following services:

Service----------------------Responsibility

UserService------------------User management

TaskService------------------Task creation, updating, retrieving, and deletion

NotificationService----------Handling task-related notifications

ApiGateway-------------------Routing client requests to the appropriate services

Each microservice will manage its own data and business logic.

* Technologies

The planned technology stack includes:

- C# – Programming language
- ASP.NET Core Web API – Backend development
- SQL Server – Relational database
- Entity Framework Core – Data access
- RabbitMQ – Asynchronous messaging
- YARP – API Gateway
- Docker – Containerization
- Docker Compose – Container orchestration
- Swagger / OpenAPI – API documentation
- Git – Version control
