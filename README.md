# Project

A simple Razor Pages web application for managing products and categories with user authentication.

## Features

- **User Registration & Login:** Users can register, log in, and log out. Authentication is session-based.
- **Product Management:** Authenticated users can view, create, edit, and delete products. Each product belongs to a category and supports image uploads.
- **Category Management:** Authenticated users can view, create, edit, and delete categories.
- **Navigation:** The navigation bar dynamically shows "Products" and "Categories" links only when a user is signed in.
- **Data Seeding:** The database is seeded with sample users, categories, and products.

## Technologies

- .NET 9, C# 13
- ASP.NET Core Razor Pages (MVC pattern)
- Entity Framework Core (Code First)
- SQL Server
- Bootstrap 5

## Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- SQL Server (local or remote)

### Setup

1. **Clone the repository:**
   ```bash
   git clone https://github.com/ahmed-atef-gad/ITI-Summer-training-.NET-Project.git
   cd <repository-folder>
   ```

2. **Configure the database:**
   - Update the connection string in `Context/MyContext.cs` if needed.

