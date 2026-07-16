# CalculatR 🧮

CalculatR is a C#/.NET based calculator application designed with a clean service-oriented architecture.

The project focuses on separating calculation logic, reporting logic, and application responsibilities into independent components.

---

## ✨ Features

- Basic mathematical calculations
- Calculation service layer
- Report generation
- Clean code structure
- Separation of responsibilities
- Object-oriented programming principles

---

## 🛠 Technologies

- C#
- .NET
- Git
- GitHub
- Object-Oriented Programming (OOP)

---

## 🏗 Architecture

flowchart LR

    User[User] --> App[Application]

    App --> Calc[Calculation Service]

    Calc --> Model[Calculation Model]

    App --> Report[Report Service]

    Report --> Result[Report Result]
---

## 🔄 Application Flow

flowchart TD

    A[User Input] --> B[Input Validation]

    B --> C[Calculation Service]

    C --> D[Perform Operation]

    D --> E[Store Result]

    E --> F[Report Service]

    F --> G[Display Report]
---

## 📁 Project Structure

CalculatR
│
├── Services
│   ├── CalculationService.cs
│   └── ReportService.cs
│
├── Models
│   └── Calculation.cs
│
├── Reports
│   └── Report.cs
│
└── Program.cs
---

## 🚀 Getting Started

### Clone repository

git clone https://github.com/xnosir/CalculatR.git
### Open project

Open the project with Visual Studio or VS Code.

### Run

dotnet run
---

## 🎯 Learning Goals

This project demonstrates:

- C# programming fundamentals
- Service layer design
- Clean architecture principles
- Working with Git and GitHub
- Building maintainable applications

---

## 👨‍💻 Author

Nosirbek Xakimov
