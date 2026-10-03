# Guía de Instalación — SDVE

**Sistema Digital de Votación Estudiantil (mini01)**

**Repositorio oficial:** https://github.com/fuid22337-sudo/-mini01-sdve
---

## Índice

1. [Requisitos del sistema](#1-requisitos-del-sistema)
2. [Instalación portátil](#2-instalación-portátil)
3. [Instalación desde código fuente](#3-instalación-desde-código-fuente)
4. [Descarga directa como ZIP](#4-descarga-directa-como-zip)
5. [Generar tu propio ejecutable](#5-generar-tu-propio-ejecutable)
6. [Solución de problemas](#6-solución-de-problemas)


---

## 1. Requisitos del sistema

### Hardware mínimo

| Recurso | Mínimo |
|---------|--------|
| Procesador | 1.8 GHz o superior |
| Memoria RAM | 2 GB |
| Espacio en disco | 100 MB |
| Pantalla | 1024 × 768 |

### Software

| Recurso | Requerimiento |
|---------|---------------|
| Sistema operativo | Windows 10 o superior (64 bits) |
| .NET Runtime | No requerido (versión self-contained) |
| Conexión a internet | No requerida para ejecutar |
| Permisos | Usuario estándar (no requiere admin) |

>  La aplicación funciona **100 % offline** una vez instalada.

---

## 2. Instalación portátil

**Método recomendado** — No requiere instalación.

### Paso 1 — Obtener el ejecutable

Descarga el archivo `mini01.exe` desde:

- El repositorio: https://github.com/fuid22337-sudo/-mini01-sdve
- O el paquete de instalación entregado por el equipo.

### Paso 2 — Extraer

1. Crea una carpeta donde quieras tener la aplicación (por ejemplo,
   `C:\SDVE\`).
2. Copia `mini01.exe` dentro de esa carpeta.

### Paso 3 — Ejecutar

1. Haz **doble clic** sobre `mini01.exe`.
2. Si Windows muestra la advertencia **"Windows protegió tu PC"**:
   - Clic en **Más información**.
   - Clic en **Ejecutar de todas formas**.

### Paso 4 — Verificar

Se debe abrir la ventana principal con el título:
**"SDVE - Sistema Digital de Votación Estudiantil"**.

### Crear acceso directo (opcional)

1. Clic derecho sobre `mini01.exe`.
2. **Enviar a → Escritorio (crear acceso directo)**.

---

## 3. Instalación desde código fuente

**Para desarrolladores** que quieran modificar el proyecto.

### Paso 1 — Instalar herramientas necesarias

| Herramienta | Enlace de descarga |
|-------------|--------------------|
| Visual Studio 2022 Community | https://visualstudio.microsoft.com/es/vs/community/ |
| .NET 6.0 SDK | https://dotnet.microsoft.com/download |
| Git | https://git-scm.com/download/win |

>  Durante la instalación de Visual Studio, marca la carga de trabajo
> **"Desarrollo de escritorio de .NET"**.

### Paso 2 — Verificar instalaciones

Abre **PowerShell** y ejecuta:

```powershell
git --version
dotnet --version
```

Ambos comandos deben devolver un número de versión.

### Paso 3 — Clonar el repositorio

```bash
git clone https://github.com/fuid22337-sudo/-mini01-sdve.git
cd mini01-sdve
```

### Paso 4 — Restaurar dependencias

```bash
dotnet restore
```

### Paso 5 — Compilar y ejecutar

**Opción A — Visual Studio:**
1. Doble clic sobre `mini01.sln`.
2. Presiona **F5** o **Compilar → Compilar solución** (`Ctrl + Shift + B`).

**Opción B — Línea de comandos:**
```bash
dotnet build -c Release
dotnet run
```

---

## 4. Descarga directa como ZIP

Si **no tienes Git instalado**, puedes descargar el proyecto como ZIP.

### Paso 1 — Descargar

🔗 https://github.com/fuid22337-sudo/mini01-sdve/archive/refs/heads/main.zip

### Paso 2 — Descomprimir

1. Clic derecho sobre el archivo descargado.
2. **Extraer todo...**
3. Elige una carpeta de destino.

### Paso 3 — Abrir con Visual Studio

1. Entra a la carpeta extraída.
2. Doble clic en `mini01.sln`.
3. Visual Studio abrirá el proyecto automáticamente.

### Paso 4 — Compilar

Presiona **F5** para compilar y ejecutar.

---

## 5. Generar tu propio ejecutable

Si quieres crear tu propio `mini01.exe` autónomo (sin necesidad de tener
.NET instalado):

### Comando único

```bash
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true
```

### Resultado

El ejecutable se genera en:

```
bin\Release\net6.0\win-x64\publish\mini01.exe
```

### Características del ejecutable

| Característica | Valor |
|----------------|-------|
| Tamaño aproximado | 70 MB |
| Requiere .NET instalado |  No |
| Requiere dependencias |  No |
| Funciona en | Windows 10/11 (64 bits) |

---

## 6. Solución de problemas

### 6.1 Al ejecutar la aplicación

| Problema | Causa | Solución |
|----------|-------|----------|
| Windows bloquea el .exe | SmartScreen | "Más información → Ejecutar de todas formas" |
| No abre el programa | .exe dañado | Descarga una copia nueva |
| La ventana se ve cortada | Resolución baja | Ajustar a 125 % o superior en Windows |

### 6.2 Al compilar desde código fuente

| Problema | Causa | Solución |
|----------|-------|----------|
| `dotnet: command not found` | Falta el SDK | Instalar .NET 6.0 SDK |
| `git: command not found` | Falta Git | Instalar Git |
| Error `MSB...` al compilar | Dependencias faltantes | Ejecutar `dotnet restore` |
| El diseñador visual falla | Bug de .NET 6 | Ignorar — el código funciona igual |
| `C# 8.0 no soportado` | SDK antiguo | Actualizar a .NET 6.0 o superior |

### 6.3 Al publicar el ejecutable

| Problema | Solución |
|----------|----------|
| El .exe pesa mucho | Es normal (self-contained ≈ 70 MB) |
| No funciona en 32 bits | Compilar con `-r win-x86` |
| Faltan archivos DLL | No usar `-p:PublishSingleFile=true` |

---

## 7. Soporte

### Documentación relacionada

- [Manual de Usuario](MANUAL_USUARIO.md)
- [Documentación Técnica](DOCUMENTACION_TECNICA.md)

### Repositorio oficial

 https://github.com/fuid22337-sudo/-mini01-sdve




