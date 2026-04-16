
﻿# 🏥 ClinicaMvc

Sistema web de gerenciamento de consultas médicas desenvolvido com **ASP.NET Core MVC**, seguindo o padrão **Repository Pattern** e com autenticação via **ASP.NET Identity**.

---

## 🖥️ Telas do Sistema

### Login
![Login]!<img width="1919" height="1079" alt="login" src="https://github.com/user-attachments/assets/c205fc80-e5d9-4c2a-b3e0-306e74944c52" />


### Dashboard
![Dashboard]<img width="1919" height="1079" alt="dashboard" src="https://github.com/user-attachments/assets/791f7d27-9714-47c7-bcd0-151b2a5f60f7" />


### Médicos
![Médicos]<img width="1919" height="1079" alt="medicos" src="https://github.com/user-attachments/assets/5c6d63e8-5de6-4d02-a125-832013210a83" />


### Pacientes
![Pacientes]<img width="1919" height="1079" alt="pacientes" src="https://github.com/user-attachments/assets/4f95bb92-54ee-477e-a414-28bc886a2f4a" />


### Consultas
![Consultas]<img width="1919" height="1079" alt="consultas" src="https://github.com/user-attachments/assets/973101e0-bc82-414c-befa-28d12db9dbd0" />


### Detalhes da Consulta
![Detalhes]<img width="1919" height="1079" alt="detalhes" src="https://github.com/user-attachments/assets/f1dc83b2-5cbb-464f-86aa-3b01e1dad18e" />


### Excluir Consulta
![Excluir]<img width="1919" height="1079" alt="excluir" src="https://github.com/user-attachments/assets/06a5c344-f37a-473b-8dce-a9715732a876" />


---

## 🚀 Funcionalidades

- 🔐 Autenticação com login e logout (ASP.NET Identity)
- 📊 Dashboard com totais de médicos, pacientes e consultas
- 📅 Próximas consultas agendadas em destaque no dashboard
- 👨‍⚕️ CRUD completo de Médicos
- 👥 CRUD completo de Pacientes
- 📋 CRUD completo de Consultas com status (Agendada, Realizada, Cancelada)
- 🛡️ Todas as rotas protegidas com `[Authorize]`

---

## 🛠️ Tecnologias

| Tecnologia | Uso |
|---|---|
| ASP.NET Core MVC (.NET 8) | Framework principal |
| Entity Framework Core | ORM e migrations |
| ASP.NET Identity | Autenticação |
| SQL Server | Banco de dados |
| Bootstrap 5 | Estilização base |
| Bootstrap Icons | Ícones |
| HTML/CSS customizado | Layout dark mode |

---

## 🏗️ Arquitetura

```
ClinicaMvc/
├── Controllers/          # Controllers MVC
│   ├── AccountController.cs
│   ├── HomeController.cs
│   ├── MedicosController.cs
│   ├── PacientesController.cs
│   └── ConsultasController.cs
├── Models/               # Entidades do banco
│   ├── Medico.cs
│   ├── Paciente.cs
│   └── Consulta.cs
├── ViewModels/           # Modelos para as Views
│   ├── MedicoViewModel.cs
│   ├── ConsultaViewModel.cs
│   └── LoginViewModel.cs
├── Repositories/         # Repository Pattern
│   ├── IMedicoRepository.cs
│   ├── IPacienteRepository.cs
│   ├── IConsultaRepository.cs
│   ├── MedicoRepository.cs
│   ├── PacienteRepository.cs
│   └── ConsultaRepository.cs
├── Data/
│   └── AppDbContext.cs
└── Views/                # Razor Views
    ├── Account/
    ├── Home/
    ├── Medicos/
    ├── Pacientes/
    └── Consultas/
```

---

## ▶️ Como rodar localmente

### Pré-requisitos
- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- SQL Server (ou SQL Server Express)

### Passo a passo

**1. Clone o repositório**
```bash
git clone https://github.com/RafaelSantana03/ClinicaMvc.git
cd ClinicaMvc
```

**2. Configure a connection string**

Edite o arquivo `appsettings.json` com sua string de conexão:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=SEU_SERVIDOR;Database=ClinicaMvc;Trusted_Connection=True;"
}
```

**3. Aplique as migrations**
```bash
cd ClinicaMvc
dotnet ef database update
```

**4. Rode o projeto**
```bash
dotnet run
```

**5. Acesse no browser**
```
https://localhost:7254
```

---

## 🔑 Credenciais de Acesso

| Campo | Valor |
|---|---|
| E-mail | `admin@clinica.com` |
| Senha | `Admin@123` |

---

## 📌 Padrões utilizados

- **Repository Pattern** — abstração da camada de dados
- **ViewModels** — evita expor entidades diretamente nas views
- **[Authorize]** — proteção de rotas autenticadas
- **[ValidateAntiForgeryToken]** — proteção contra ataques CSRF
- **Data Annotations** — validações nos models

---

## 👨‍💻 Autor

Desenvolvido por **Rafael Santana**

[![GitHub](https://img.shields.io/badge/GitHub-RafaelSantana03-blue?logo=github)](https://github.com/RafaelSantana03)
