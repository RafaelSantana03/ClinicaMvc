# 🏥 ClinicaMvc

Sistema web de gerenciamento de consultas médicas desenvolvido com **ASP.NET Core MVC**, seguindo o padrão **Repository Pattern** e com autenticação via **ASP.NET Identity**.

---

## 🖥️ Telas do Sistema

### Login
![Login](docs/login.png)

### Dashboard
![Dashboard](docs/dashboard.png)

### Médicos
![Médicos](docs/medicos.png)

### Pacientes
![Pacientes](docs/pacientes.png)

### Consultas
![Consultas](docs/consultas.png)

### Detalhes da Consulta
![Detalhes](docs/detalhes.png)

### Excluir Consulta
![Excluir](docs/excluir.png)

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