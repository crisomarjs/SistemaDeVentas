# 🛒 Sistema De Ventas - C# (.NET 8)

Este es un sistema de ventas desarrollado en **C#** con **.NET 8**, usando el enfoque de **arquitectura en capas (n capas)** y programación orientada a objetos. El proyecto está diseñado para gestionar operaciones relacionadas con ventas, productos y usuarios en un entorno de escritorio, con persistencia de datos a través de **SQL Server** utilizando **ADO.NET**.

---

## 🏗️ Arquitectura del Proyecto

El proyecto está dividido en tres capas principales, cumpliendo con los principios de separación de responsabilidades:

### 📦 1. SVPresentation
Capa de presentación (WinForms):
- Formularios de interfaz gráfica del usuario.
- Lógica de visualización y captura de datos.

### 🧩 2. SVRepository
Capa de acceso a datos:
- Acceso y persistencia de datos usando **ADO.NET**.
- Contiene las entidades y modelos que representan las tablas de la base de datos.
- Lógica de conexión a SQL Server y ejecución de comandos SQL.
- Carpetas principales: `DB`, `Entities`, `Implementation`, `Interfaces`.

### ⚙️ 3. SVServices
Capa de lógica de negocio:
- Implementa las reglas y validaciones del sistema.
- Se comunica con `SVRepository` para acceder a los datos.
- Expone métodos para ser utilizados por la capa de presentación.
- Carpetas principales: `Implementation`, `Interfaces`.

---

## 💾 Tecnologías Utilizadas

- **Lenguaje:** C# (.NET 8)
- **Base de datos:** SQL Server
- **Persistencia:** ADO.NET
- **Arquitectura:** N-Capas
---

