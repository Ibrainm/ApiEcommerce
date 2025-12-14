# API E-Commerce .NET 8

Una API RESTful completa para la gestión de un sistema de e-commerce construida con .NET 8, Entity Framework Core y autenticación basada en JWT.

## 📋 Descripción General

Esta API proporciona funcionalidades para:
- **Gestión de Productos**: Crear, actualizar, listar y eliminar productos del catálogo
- **Categorías**: Organizar productos por categorías
- **Usuarios**: Administración de usuarios y roles (Admin)
- **Autenticación y Autorización**: Sistema seguro con JWT Bearer tokens
- **Versionado de API**: Soporte para múltiples versiones de endpoints

## 🛠️ Tecnologías

- **.NET 8.0** - Framework principal
- **ASP.NET Core 8** - Framework web
- **Entity Framework Core 9.0.5** - ORM para acceso a datos
- **SQL Server** - Base de datos
- **ASP.NET Core Identity** - Autenticación y autorización
- **JWT (JSON Web Tokens)** - Autenticación mediante tokens
- **AutoMapper 15.0.1** - Mapeo automático de DTOs
- **Swagger/Swashbuckle** - Documentación interactiva de API
- **API Versioning** - Gestión de versiones de endpoints

## 📦 Requisitos Previos

- **SDK de .NET 8** o superior
- **SQL Server** (instalado localmente o en un servidor remoto)
- **Visual Studio 2022** o **VS Code** (opcional)

## 🚀 Guía de Inicio Rápido

### 1. Clonar el Repositorio

```bash
git clone https://github.com/tu-usuario/ApiEcommerce.git
cd ApiEcommerce
```

### 2. Restaurar Dependencias

```powershell
dotnet restore
```

O si utilizas bash/git bash:

```bash
dotnet restore
```

### 3. Compilar el Proyecto

```powershell
dotnet build
```

### 4. Ejecutar Migraciones de Base de Datos

Asegúrate de haber configurado la cadena de conexión en `appsettings.json` (sección `ConnectionStrings`).

```powershell
dotnet ef database update
```

### 5. Ejecutar el Proyecto

**Opción A: Ejecución Normal**

```powershell
dotnet run
```

**Opción B: Modo Watch (con recarga automática)**

```powershell
dotnet watch run
```

El servidor estará disponible en `https://localhost:5001` (o en el puerto configurado en `launchSettings.json`).

## ⚙️ Configuración

### Cadena de Conexión a Base de Datos

Edita el archivo `appsettings.json` en la raíz del proyecto y configura:

```json
{
  "ConnectionStrings": {
    "ConexionSql": "Server=localhost;Database=ApiEcommerceNET8;User ID=SA;Password=your_password;TrustServerCertificate=true;MultipleActiveResultSets=true"
  }
}
```

**Variables importantes:**
- `Server` - Servidor SQL Server
- `Database` - Nombre de la base de datos
- `User ID` - Usuario de autenticación
- `Password` - Contraseña del usuario

### Clave Secreta para JWT

En `appsettings.json`, configura una clave secreta robusta:

```json
{
  "ApiSettings": {
    "SecretKey": "una-clave-secreta-extensa-con-minimo-32-caracteres"
  }
}
```

## 📚 Estructura del Proyecto

```
ApiEcommerce/
├── Controllers/          # Controladores REST API
│   ├── ProductsController.cs
│   ├── UsersController.cs
│   ├── CategoriesController.cs (V1 y V2)
│   └── ApplicationUser.cs
├── Models/              # Modelos de datos
│   ├── Product.cs
│   ├── Category.cs
│   ├── User.cs
│   └── Dtos/            # Data Transfer Objects
├── Data/                # Contexto y configuración de BD
│   ├── ApplicationDbContext.cs
│   └── DataSeeder.cs
├── Repository/          # Implementación del patrón Repository
│   ├── ProductRepository.cs
│   ├── CategoryRepository.cs
│   ├── UserRepository.cs
│   └── IRepository/     # Interfaces
├── Migrations/          # Migraciones de Entity Framework
├── Mapping/             # Perfiles de AutoMapper
├── Constants/           # Constantes de configuración
└── Program.cs           # Configuración de servicios y middleware
```

## 🔐 Autenticación

La API utiliza **JWT (JSON Web Tokens)** para autenticación. 

### Endpoints de Autenticación

- **Login**: `POST /api/auth/login`
- **Register**: `POST /api/auth/register`

### Uso de Tokens

Incluye el token en el encabezado `Authorization`:

```
Authorization: Bearer <tu_token_jwt>
```

## 📖 Documentación de API

Una vez que ejecutes el proyecto, accede a **Swagger UI** en:

```
https://localhost:5001/swagger/index.html
```

Aquí encontrarás la documentación interactiva de todos los endpoints disponibles.

## 🔄 Versionado de API

La API soporta múltiples versiones:

- **V1**: `/api/v1/categories`
- **V2**: `/api/v2/categories`

Se especifica la versión en la ruta del endpoint.

## 🧪 Ejecutar Pruebas

Si el proyecto incluye pruebas unitarias:

```powershell
dotnet test
```

## 📝 Archivos Clave

- [`Program.cs`](Program.cs) - Configuración de servicios y middleware
- [`appsettings.json`](appsettings.json) - Configuración de la aplicación
- [`appsettings.Development.json`](appsettings.Development.json) - Configuración para desarrollo
- [`ApiEcommerce.http`](ApiEcommerce.http) - Colección de requests HTTP para pruebas

## 🤝 Contribuciones

Si deseas contribuir al proyecto, por favor:

1. Fork el repositorio
2. Crea una rama para tu feature (`git checkout -b feature/nueva-funcionalidad`)
3. Commit tus cambios (`git commit -m 'Agrega nueva funcionalidad'`)
4. Push a la rama (`git push origin feature/nueva-funcionalidad`)
5. Abre un Pull Request

## 📄 Licencia

Este proyecto está bajo la Licencia MIT. Consulta el archivo `LICENSE` para más detalles.

## 📧 Contacto

Para preguntas o sugerencias, contacta al equipo de desarrollo.

---

**Última actualización:** Diciembre 2025
