# CMCSPrototypeWPF
MOLOGANE MONARE MOSEHLE ST10101825 PROG6212 POE PART 1
Contract Monthly Claim System (CMCS) – Prototype
📖 Project Overview

The Contract Monthly Claim System (CMCS) is designed to simplify the submission, verification, and approval of monthly claims for Independent Contractor (IC) lecturers. This repository contains the prototype built using WPF (.NET Core) in Visual Studio.

At this stage, the system is only a front-end prototype – it provides a visual representation of the intended functionality, without a fully working backend. The final system will allow lecturers, programme coordinators, and academic managers to manage monthly claims in a transparent and efficient way.

Features (Prototype Stage)
Lecturers can:
-Create new claims
-Upload supporting documents (placeholder UI)
-View claim submission status

Programme Coordinators & Academic Managers can:
-View claims in a dashboard
-Approve or reject claims (UI only)

General
-Simple, clean interface for each user role
-Transparent claim tracking flow

CMCSPrototypeWPF/
│
├── Models/               # Business classes (Claim, ClaimItem, Document, User)
│   ├── Claim.cs
│   ├── ClaimItem.cs
│   ├── Document.cs
│   └── User.cs
│
├── Windows/              # GUI Windows (prototypes only)
│   ├── MainWindow.xaml           # Entry screen
│   ├── NewClaimWindow.xaml       # Form for lecturers to submit claims
│   ├── CoordinatorWindow.xaml    # Dashboard for coordinators/managers
│
├── App.xaml              # Application definition
├── App.xaml.cs
└── README.md             # Project documentation

Version Control

This prototype follows best practices in Git version control.
At least 5 commits were made during development with clear messages, for example:
-Initial project setup
-Added Claim, ClaimItem, Document, and User models
-Designed Lecturer UI (NewClaimWindow)
-Created Coordinator Dashboard (CoordinatorWindow)
-Updated documentation and UML diagram

Screenshots (to be included in POE Report)
-Lecturer New Claim Window
-Coordinator Dashboard
-Main Menu

Notes:
-This is only a prototype. The backend logic, database integration, and workflows will be implemented in later phases of the POE.
-All UI forms are clickable mockups to demonstrate functionality but do not perform real data operations.
