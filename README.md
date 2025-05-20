# DevFreela

## 📌 About the Project

**DevFreela** is a Web API built with .NET Core, Entity Framework Core, and SQL Server, designed to simulate a real-world freelancing platform. The goal of this project is to apply key backend development concepts such as entity modeling, data relationships, and domain-driven design.

This project was developed during the **.NET Start Mentorship lessons** by **[Luis Dev](https://www.luisdev.com.br/)**, under the Entity Framework and Clean Architecture modules.

> 💡 The `main` branch contains the initial version using a traditional Web API structure.  
> 🧱 The `CleanArchitecture` branch contains a refactored version of the project applying **Clean Architecture** principles, with a clear separation of concerns between Core, Application, Infrastructure, and API layers.

---

## The API

The API mimics a freelancing platform where developers can find and work on software projects. It includes core features such as:

- User registration and management
- Project creation and assignment
- Skill tagging
- Commenting on projects

---

## 📘 Entities & Relationships

Here’s an overview of the main entities and how they relate to each other:

- **User**  
  Represents both clients and freelancers.
  - A user can be a **client** (project owner) or a **freelancer** (project executor).
  - A user can **own multiple projects** (as a client).
  - A user can **work on multiple projects** (as a freelancer).
  - A user can **post multiple comments**.
  - A user can have **multiple skills**.

- **Project**
  - Each project is **created/owned by one user** (client).
  - Each project is **assigned to one user** (freelancer).
  - A project can have **multiple comments**.

- **Skill**
  - A skill represents a technology or ability (e.g., C#, SQL, React).
  - Each user can have **multiple skills** (many-to-many relationship).

- **Comment**
  - A comment is posted by a **user** on a **project**.
  - A project can have **multiple comments**.
  - A user can post **multiple comments**.

---

## 💡 Next Steps

- Implement authentication/authorization (JWT)
- Add unit and integration tests
- Swagger/OpenAPI documentation

---

## 👨‍💻 Programming Languages - Frameworks - Technologies - Tools  🛠

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white)
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![Entity Framework Core](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)
![MicrosoftSQLServer](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white)[![Git](https://img.shields.io/badge/Git-121013?style=for-the-badge&logo=git&logoColor=E94D5F)](https://git-scm.com/doc)
![Github](https://img.shields.io/badge/github-121013?style=for-the-badge&logo=github&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)

## 📫 How to reach me:
<div style="display: flex;>

<a href="mailto:andrebass27@gmail.com" style="text-decoration: none;">![Gmail](https://img.shields.io/badge/Gmail-D14836?style=for-the-badge&logo=gmail&logoColor=white)</a>

<a href="https://www.linkedin.com/in/andrearruuda/" style="text-decoration: none;">![LinkedIn](https://img.shields.io/badge/linkedin-%230077B5.svg?style=for-the-badge&logo=linkedin&logoColor=white)</a>

<a href="https://wa.me/5581985851220">![WhatsApp](https://img.shields.io/badge/WhatsApp-25D366?style=for-the-badge&logo=whatsapp&logoColor=white)</a>

<a href="https://www.instagram.com/andrearruuda/">![Instagram](https://img.shields.io/badge/Instagram-%23E4405F.svg?style=for-the-badge&logo=Instagram&logoColor=white)</a>
</div>
