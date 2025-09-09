# Contract Monthly Claim System (CMCS)

## Overview
The **Contract Monthly Claim System (CMCS)** is a .NET-based web application developed as part of the PROG6212 Portfolio of Evidence (PoE). 
It was designed to streamline the process of submitting and approving monthly claims for Independent Contractor (IC) lecturers. 
By simulating a real-world workflow, the CMCS provides lecturers, programme coordinators, and managers with a simplified digital platform for handling claim submissions, pre-approvals, and approvals.

This project demonstrates skills in **C#**, **ASP.NET Core MVC**, **GUI design**, and **project planning**, aligning with the module outcomes for Programming 2B.

---

## Features (Prototype Implementation)
- **Lecturer Features**
  - Submit monthly claims (mock navigation only, no persistence).
  - Upload supporting documents (to be implemented in later iterations).
  - Track claim statuses with sample data provided.

- **Programme Coordinator Features**
  - View lecturer-submitted claims.
  - Verify accuracy of submitted claims.
  - Pre-approve pending claims (sample data available).

- **Programme Manager Features**
  - View pre-approved claims from coordinators.
  - Approve or reject claims (sample data available).

- **Shared Features**
  - Navigation bar with role-based actions.
  - Responsive and user-friendly interface with a red + gray theme.
  - Sample data tables for Track, Pre-Approve, and Approve views.

---

## System Structure
```
YourProject/
├── Controllers/
│   ├── AccountController.cs   # Handles Login & Register (prototype only)
│   ├── HomeController.cs      # Home page with navigation cards
│   ├── ClaimsController.cs    # Lecturer claim submission (placeholder)
│   ├── TrackController.cs     # Claim tracking (sample data)
│   └── ApprovalController.cs  # Coordinator & Manager views (sample data)
│
├── Views/
│   ├── Account/               # Login & Register pages
│   ├── Home/                  # Home page (role navigation)
│   ├── Claims/                # Claim submission page (placeholder)
│   ├── Track/                 # Claim tracking page (sample data)
│   ├── Approval/              # Pre-Approve & Approve pages (sample data)
│   └── Shared/                # Layouts (_Layout, _AuthLayout)
│
├── wwwroot/css/
│   └── site.css               # Custom styling (red + gray theme)
│
└── Program.cs                 # Entry point, routes to Login by default
```

---

## Technology Stack
- **Framework:** ASP.NET Core MVC (.NET 6/7)
- **Language:** C#  
- **Frontend:** Razor Views, HTML5, CSS3  
- **Styling:** Custom CSS (Red + Gray theme, responsive design)  
- **IDE:** Visual Studio 2022 (or later)  

---

## Assumptions and Constraints
- Authentication and data persistence are **not implemented** in this prototype.  
- Sample data is used to simulate system workflows.  
- Users (lecturers, coordinators, managers) are assumed to already have valid credentials.  
- Internet access and modern browsers are required to use the system.  

---

## Setup Instructions
1. Clone the repository or copy the project files into Visual Studio.
2. Ensure you have **.NET 6 SDK** (or higher) installed.
3. Open the solution in Visual Studio.
4. Run the project (`F5`).  
   - The application starts on the **Login page**.  
   - Use the navigation bar to move between **Home**, **Claim**, **Track Claim**, **Pre-Approve**, and **Approve**.  

---

## Project Plan (Prototype Timeline)
- **Week 1:** Gather requirements and design layout.  
- **Week 2:** Build Login and navigation system.  
- **Week 3:** Add role-based Home page cards.  
- **Week 4:** Implement Track Claim, Pre-Approve, and Approve pages with sample data.  
- **Week 5:** Apply red + gray theme styling and refine UI.  
- **Week 6:** Documentation and submission preparation.  

---

## Version Control Practices
- Frequent commits for each feature addition (e.g., *"Added TrackClaim sample table"*).  
- Descriptive commit messages.  
- Git used for version control (can be integrated with GitHub).  

---

## Future Improvements
- Implement real authentication and role-based authorization.  
- Connect to a database for storing and retrieving claims.  
- Add full document upload functionality with validation.  
- Improve error handling with user-friendly feedback.  
- Expand reporting features for managers.  

---

## Author
Developed as part of **PROG6212 — Programming 2B Portfolio of Evidence (PoE)**.  
Year: 2025  
Institution: The Independent Institute of Education (IIE)  

