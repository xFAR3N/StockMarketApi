# StockMarketApi

A **Stock Market API** built in C# using ASP.NET Core. This project serves as a backend service that provides stock data (real-time quotes, historical data) with secure access and a clean architecture — a showcase project for my portfolio.

## Features

- **Real-Time Stock Quotes** – fetch current prices for given stock symbols.
- **Secure Access** – JWT-based authentication and authorization for protected endpoints.
- **CRUD Operations** – manage favorite stocks, user portfolios, etc.
- **Extensible & Modular** – layered architecture with Controllers, Services, Repositories, DTOs for maintainability and testing.

## Tech Stack

- **Language**: C#
- **Framework**: ASP.NET Core Web API
- **ORM**: Entity Framework Core
- **Authentication**: JSON Web Tokens (JWT)
- **Database**: MS SQL
- **Development Tools**: Visual Studio 2022, .NET 8+ (adjust as needed)

- ## Getting Started

1. Clone the repository 
2. Set up the database connection string in appsettings.json:
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=StockMarketDb;Trusted_Connection=True;"
  }
3. Apply migrations and update the database:
  dotnet ef database update
4. Run the application:
  dotnet run
