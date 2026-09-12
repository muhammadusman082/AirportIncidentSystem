# ✈️ Airport Incident Management System

A robust, enterprise-grade ASP.NET Core MVC web application designed for real-time reporting, tracking, and management of airport incidents and operational logs across multi-device networks.

---

## 📌 Features & Key Capabilities

- **Responsive & Dynamic Reporting Form**: Built using **Bootstrap 5** and enhanced with **FontAwesome** iconography and responsive CSS layout rules to deliver an optimized experience on mobile devices, tablets, and desktop workstations.
- **Dynamic Field Management**: Adapts incident data fields dynamically based on incident severity, type, and operational needs.
- **Relational Data Storage**: Powered by **Entity Framework Core / ADO.NET** and **SQL Server**, featuring clean schema separation and robust repository configurations.
- **Multi-Network & Public Access Ready**: Designed to operate within local airport intranet topologies (via IIS hosting) as well as public edge deployments (via Cloud Services, Reverse Proxies, or Secure Tunnels).
- **Production-Ready Deployment Structure**: Pre-configured for IIS Hosting with ASP.NET Core 8.0 Hosting Bundle integration.

---

## 🛠️ Tech Stack & Architecture

| Layer | Technology / Tool |
| :--- | :--- |
| **Framework** | .NET 8.0 (ASP.NET Core MVC) |
| **Language** | C# 12 |
| **Frontend** | Razor Views (`.cshtml`), Bootstrap 5, FontAwesome 6, Custom CSS |
| **Database** | Microsoft SQL Server / SQL Express, Entity Framework Core |
| **Web Server** | Internet Information Services (IIS) / Kestrel |
| **Version Control** | Git & GitHub |

---

## 🚀 Getting Started (Local Development)

### Prerequisites
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/sql-server/) (or SQL Server Express) / SSMS
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (with ASP.NET and web development workload)

### Installation & Setup

1. **Clone the Repository**
   ```bash
   git clone https://github.com/muhammadusman082/AirportIncidentSystem.git
   cd AirportIncidentSystem
   ```

2. **Configure Database Connection**
   Open `appsettings.json` and update your connection string to point to your local SQL Server instance:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=AirportIncidentDb;Trusted_Connection=True;TrustServerCertificate=True;"
   }
   ```

3. **Apply Database Migrations**
   Run the following command in the Package Manager Console or Terminal:
   ```bash
   dotnet ef database update
   ```

4. **Run the Application**
   ```bash
   dotnet run
   ```
   Navigate to `https://localhost:7001/Incident/Create` in your browser.

---

## 🌐 IIS Deployment Guide (Intranet Hosting)

To host this application on a local server for airport staff access:

1. **Install ASP.NET Core Hosting Bundle**:
   Download and install the **ASP.NET Core 8.0 Hosting Bundle** on the server host machine, then restart IIS via Command Prompt:
   ```cmd
   iisreset
   ```

2. **Publish the Project**:
   In Visual Studio, right-click the project -> **Publish** -> Select **Folder Target** -> Set output path (e.g. `C:\PublishedAirportApp`).

3. **Add Website in IIS Manager**:
   - Open **IIS Manager** (`inetmgr`).
   - Right-click **Sites** -> **Add Website**.
   - Set **Site Name**: `AirportIncidentSystem`
   - Set **Physical Path**: `C:\PublishedAirportApp`
   - Set **Port**: `8080`

4. **Network Access**:
   Access the system across the local airport LAN via:
   ```http
   http://<SERVER_IP>:8080/Incident/Create
   ```

---

## 📂 Project Structure

```text
AirportIncidentSystem/
├── Controllers/
│   ├── HomeController.cs
│   └── IncidentController.cs      # Core incident logic & CRUD actions
├── Models/
│   └── Incident.cs               # Incident entity definition
├── Data/
│   └── ApplicationDbContext.cs   # Entity Framework Context
├── Views/
│   ├── Incident/
│   │   └── Create.cshtml         # Redesigned responsive reporting UI
│   └── Shared/
│       └── _Layout.cshtml        # Base application layout
├── wwwroot/
│   ├── css/                      # Custom stylesheets
│   └── js/                       # Dynamic form interactions
├── Program.cs                    # Dependency Injection & Middleware config
└── appsettings.json              # System configuration
```

---

## 🛡️ License & Project Status

Developed for airport management and operational incident resolution.  
**Status**: Active / In Continuous Integration.
