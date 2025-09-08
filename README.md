# 🛒 Sales Management System - Desktop Application

project:
  name: "Sales Management System - Desktop Application"
  
  type: "Windows Forms Desktop App"
  
  language: "C# (.NET Core)"
  
  database: "SQL Server"
  
## 📌 Overview
The **Sales Management System** is a Windows Forms desktop application built with **C#** and **.NET Framework**.  
It provides a complete solution for managing sales operations, including customers, products, categories, stock, and orders.  
The system is designed with a layered architecture:  
- **PL (Presentation Layer)** → Windows Forms UI  
- **BLL (Business Logic Layer)** → Services and business rules  
- **DAL (Data Access Layer)** → Entities and database interaction  

---

## ✨ Features
- 👥 Manage **Customers** (add, update, delete, view).  
- 📦 Manage **Products** and **Categories**.  
- 📑 Manage **Customer Orders** and **Sales Orders**.  
- 📊 Manage **Stock and Stock Details**.  
- 🔄 CRUD operations for all entities.  
- 💾 Database integration with SQL Server.  
- 🏗️ Clean layered architecture (DAL, BLL, PL).

---
## ✨Architecture:

  PL (Presentation Layer): "Windows Forms UI"
  BLL (Business Logic Layer): "Business rules and services"
  DAL (Data Access Layer): "Entities and database access"
  
---
## ✨Project_structure:

  SalesManagementSystem.PL:
    - Forms (UI forms for Customers, Orders, Stock, etc.)
    - Program.cs
  SalesManagementSystem.BLL:
    - Services (Business services for entities)
  SalesManagementSystem.DAL:
    - Entity (Entity classes: Customer, Product, Order, etc.)
    - DatabaseHelper.cs
  readme: "README.md"
  
  ---

## ✨Requirements:

  - Visual Studio 2022
  - .NET Core
  - SQL Server (Express / Standard / Developer)
    
    ---

## ✨Setup:

  steps:
  
      - "Clone the repository: git clone https://github.com/Mostafa-Zhran/Sales-Management-System-Desktop-app.git "
    
        - "Open the solution in Visual Studio"
        
            - "Update the connection string in DatabaseHelper.cs"
            
                - "Build the solution"
                
                    - "Run the application"


    
---

## ✨Database:

  tables:
    - Customers
    - Categories
    - Products
    - SalrOrder
    - SaleOrderProduct
    - Stock
    - Stock Details
    
---
## Aauthor: "[https://mostafazahran.netlify.app/]"
