# HMO

# Health Insurance Fund Management System for Corona Virus

This project is a system designed to manage a health insurance fund during the COVID-19 pandemic. It provides various features, including member management, vaccination management, and graphical functions. The system is built using C# and Entity Framework technology for the server-side, and SQL Server for the database. 

## Features
- Member management
- Vaccination management
- Graphical functions

## Technologies used
- Entity Framework (version 6.0): ORM (Object-Relational Mapping) framework used for data access and management, and the layer model.
- SQL Server (version 18.12.1): Database server used to store and manage the system's data.
- Dependency Injection framework: used to manage dependencies between different components of the system and enable loose coupling between them.

## Layers
The project was done in the layer architecture - 4 layers:
1. Repository
2. Services
3. Controller
4. Entities
5. DTO

Brief explanation of each of the layers:
- Repository: responsible for interacting with the database and managing data access and manipulation.
- Services: responsible for the business logic of the system, and orchestration of data access and manipulation.
- Controller: responsible for handling incoming requests from the client and returning responses to the client.
- Entities:responsible for defining the data models used by the system. They represent the domain objects, and their properties and relationships are mapped to     the database tables using Entity Framework..
- DTOs (Data Transfer Objects):Defines the data structures used for transferring data between layers and APIs.


## Function inputs
The function inputs can be viewed in Swagger.

## Quality Diagnostic Strategy
Part B of the project includes a Fitzgerald quality-diagnostic strategy of the system, RR tests, and quality-validation tests. The quality strategy is available in the repository in a text file called "quality strategy". 

## Installation
To run this project on your local machine, follow these steps:
1. Clone the repository from GitHub.
2. Open the project in Visual Studio.
3. Restore the NuGet packages.
4. Run the project.

## Contributors
This project was developed by Efrat Deutsch.

