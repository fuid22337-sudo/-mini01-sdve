# Documentación Técnica — SDVE

**Sistema Digital de Votación Estudiantil (mini01)**

**Repositorio oficial:** https://github.com/fuid22337-sudo/-mini01-sdve

---

## Índice

1. [Arquitectura del sistema](#1-arquitectura-del-sistema)
2. [Estructura del proyecto](#2-estructura-del-proyecto)
3. [Clases y modelos](#3-clases-y-modelos)
4. [Diagrama de flujo](#4-diagrama-de-flujo)
5. [Requisitos para desarrolladores](#5-requisitos-para-desarrolladores)
6. [Clonar el repositorio](#6-clonar-el-repositorio)
7. [Compilar desde código fuente](#7-compilar-desde-código-fuente)
8. [Mantenimiento y extensiones](#8-mantenimiento-y-extensiones)
9. [Glosario](#9-glosario)


---

## 1. Arquitectura del sistema

El sistema sigue una arquitectura monolítica organizada en **tres capas simples**:

CAPA DE PRESENTACIÓN (Windows Forms) 
Form1.cs + Form1.Designer.cs 
│ 
│ Responsable: 
│ - Interacción con el usuario 
│ - Captura de datos 
│ - Visualización de resultados 
│
│ llamadas a métodos
▼
|
│ CAPA DE LÓGICA DE NEGOCIO 
│ Form1.cs (métodos backend) 
│ │
│ Responsable: 
│ - Validaciones 
│ - Motor de votación 
│ - Agregación con LINQ 
│ - Exportación CSV 
|
│
│ uso de modelos
▼
┌
│ CAPA DE MODELOS (Modelos.cs) 
│ Votante · Voto · Candidato · Enum 
│ │
│ Responsable: 
│ - Representación de datos 
│ - Estructuras de dominio 
|

text

### Justificación del diseño

- **Simplicidad:** al ser un proyecto académico, se evitó una arquitectura
  compleja para priorizar claridad y mantenibilidad.
- **Separación lógica:** aunque todo el código está en pocos archivos, cada
  capa tiene responsabilidades claramente definidas.
- **Escalabilidad:** el diseño permite migrar a capas físicas sin reescribir la lógica.

---

## 2. Estructura del proyecto
mini01/
│
├── LINK_GITHUB.txt → Link del repositorio
├── .gitignore → Exclusiones de Git
├── README.md → Presentación del proyecto
├──  CONTRIBUTORS.md → Datos del equipo
├── CHANGELOG.md → Historial de versiones
│
├── mini01.sln → Solución de Visual Studio
├── mini01.csproj → Configuración del proyecto
│
├── Program.cs → Punto de entrada
├── Modelos.cs → Clases de dominio
├── Form1.cs → Lógica del formulario
├── Form1.Designer.cs → Controles de la interfaz
│
└── docs/ → Documentación
├── MANUAL_USUARIO.md
├── DOCUMENTACION_TECNICA.md 
└── INSTALACION.md

text

### Descripción de cada archivo

| Archivo | Tipo | Propósito |
|---------|------|-----------|
| `Program.cs` | C# | Método `Main` que arranca la aplicación |
| `Modelos.cs` | C# | Define `Votante`, `Voto`, `Candidato` y enum `Convocatoria` |
| `Form1.cs` | C# | Lógica del formulario (votar, agregar, exportar) |
| `Form1.Designer.cs` | C# | Controles e interfaz gráfica (autogenerado) |
| `mini01.csproj` | XML | Configuración de compilación (.NET 6.0) |
| `mini01.sln` | Texto | Agrupación del proyecto en Visual Studio |

---

## 3. Clases y modelos

### 3.1 Enum `Convocatoria`

Representa las 3 convocatorias disponibles.

```csharp
public enum Convocatoria
{
    SociedadAlumnos,
    ConsejoUniversitario,
    ConsejoRepresentantes
}
3.2 Clase Candidato
Representa a un candidato participante en una convocatoria.

Propiedad	Tipo	Descripción
Nombre	string	Nombre del candidato
Convocatoria	Convocatoria	Proceso al que pertenece
EsWriteIn	bool	Indica si es candidato no registrado
Constructor:

csharp
public Candidato(string nombre, Convocatoria conv, bool esWriteIn = false)
3.3 Clase Voto
Representa el voto de un alumno en una convocatoria.

Propiedad	Tipo	Descripción
Convocatoria	Convocatoria	Proceso al que corresponde el voto
NombreCandidato	string	Nombre del candidato elegido
EsNulo	bool	true si es abstención o voto en blanco
3.4 Clase Votante
Representa a un alumno que emite su voto.

Propiedad	Tipo	Descripción
Matricula	string	Identificador único del alumno
Grupo	string	Grupo al que pertenece
Carrera	string	Carrera que estudia
CentroUniversitario	string	Centro universitario
Votos	List<Voto>	Votos emitidos por este alumno
- Un mismo votante puede tener 1, 2 o 3 votos dependiendo de cuántas
convocatorias haya marcado.

4. Diagrama de flujo
4.1 Flujo principal — Emitir voto
text
              INICIO
                │
                ▼
      [Capturar datos del votante]
                │
                ▼
      ¿Datos completos? ── No ──▶ [Mostrar error] ──▶ FIN
                │ Sí
                ▼
      ¿Marcó al menos 1 convocatoria? ── No ──▶ [Mostrar error] ──▶ FIN
                │ Sí
                ▼
      ¿Matrícula ya existe? ── Sí ──▶ [Mostrar error] ──▶ FIN
                │ No
                ▼
      [Crear objeto Votante]
                │
                ▼
      [Para cada convocatoria marcada:]
                │
                ├── ¿Hay texto en write-in?
                │       │ Sí ──▶ [Voto con nombre write-in]
                │       │ No
                │       ▼
                ├── ¿Combo en "(Abstención)"?
                │       │ Sí ──▶ [Voto nulo / abstención]
                │       │ No ──▶ [Voto con candidato oficial]
                │
                ▼
      [Agregar Votante a lista]
                │
                ▼
      [Mostrar confirmación]
                │
                ▼
              FIN
4.2 Flujo de agregación — Ver resultados
text
              INICIO
                │
                ▼
      ¿Hay votantes? ── No ──▶ [Mostrar mensaje] ──▶ FIN
                │ Sí
                ▼
      [Para cada convocatoria:]
                │
                ▼
      [Filtrar votos de esa convocatoria]
                │
                ▼
      [Agrupar por candidato → ordenar desc.]
                │
                ▼
      [Calcular absolutos y porcentajes]
                │
                ▼
      [Marcar con [WRITE-IN] o [ABSTENCIÓN]]
                │
                ▼
      [Agrupar por Grupo, Carrera, Centro]
                │
                ▼
      [Mostrar en ListBox]
                │
                ▼
              FIN
5. Requisitos para desarrolladores
Hardware mínimo
Procesador de 1.8 GHz

4 GB de RAM

1 GB de espacio libre en disco

Software obligatorio
Herramienta	Versión mínima
Windows	10 (64 bits)
Visual Studio	2022 Community
Carga de trabajo VS	"Desarrollo de escritorio .NET"
.NET SDK	6.0 o superior
Git	2.30+
Instalación de Visual Studio
Descarga desde https://visualstudio.microsoft.com/es/vs/community/

Durante la instalación, marca:

Desarrollo de escritorio de .NET

Espera a que termine (10-20 min).

Instalación de Git
Descarga desde https://git-scm.com/download/win

Instala con las opciones por defecto.

Verifica con:

bash
git --version
6. Clonar el repositorio
URL del repositorio
text
https://github.com/fuid22337-sudo/-mini01-sdve
Comando para clonar
bash
git clone https://github.com/fuid22337-sudo/-mini01-sdve.git
cd mini01-sdve
Descarga directa como ZIP

Descomprime y abre mini01.sln con Visual Studio 2022.

7. Compilar desde código fuente
Opción A — Visual Studio (recomendado)
Abre mini01.sln con doble clic.

Espera a que Visual Studio restaure los paquetes.

Presiona F5 para compilar y ejecutar.

O bien: menú Compilar → Compilar solución (Ctrl + Shift + B).

Opción B — Línea de comandos
bash
dotnet restore
dotnet build -c Release
dotnet run
Generar ejecutable autónomo (self-contained)
bash
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true
El ejecutable se genera en:

text
bin\Release\net6.0\win-x64\publish\mini01.exe
💡 Este .exe funciona sin necesidad de tener .NET instalado en la
máquina destino.

8. Mantenimiento y extensiones
8.1 Agregar un candidato oficial
Edita el método CargarCandidatosOficiales() en Form1.cs:

csharp
candidatosOficiales.Add(new Candidato("Nombre Nuevo", Convocatoria.SociedadAlumnos));
8.2 Agregar una nueva convocatoria
Requiere 4 cambios:

Modelos.cs: añadir el valor al enum.

csharp
public enum Convocatoria
{
    SociedadAlumnos,
    ConsejoUniversitario,
    ConsejoRepresentantes,
    NuevaConvocatoria    // ← nuevo
}
Form1.Designer.cs: agregar CheckBox + ComboBox + TextBox.

Form1.cs (evento): agregar método chkX_CheckedChanged.

Form1.cs (lógica): extender btnVotar_Click y MostrarResultados.

8.3 Extensiones sugeridas
Extensión	Complejidad	Beneficio
Persistencia JSON	Baja	Los votos no se pierden al cerrar
Gráficas con Chart	Media	Visualización atractiva
Login de admin	Baja	Proteger la pestaña de resultados
Base de datos SQLite	Alta	Historial y auditoría
8.4 Ejemplo — Persistencia JSON
Agregar en Form1.cs:

csharp
private void Form1_FormClosing(object sender, FormClosingEventArgs e)
{
    string json = System.Text.Json.JsonSerializer.Serialize(votantes);
    File.WriteAllText("votos.json", json);
}
Y al abrir, recargar:

csharp
if (File.Exists("votos.json"))
{
    string json = File.ReadAllText("votos.json");
    votantes = System.Text.Json.JsonSerializer.Deserialize<List<Votante>>(json) ?? new();
}
9. Glosario
Término	Significado
Convocatoria	Proceso electoral (Sociedad, Consejo U., Consejo R.)
Write-in	Candidato no registrado propuesto por el votante
Abstención	Voto en blanco o nulo
Participación	Cantidad total de votos emitidos
Agregación	Agrupar votos por criterios (grupo, carrera, etc.)
Self-contained	Ejecutable que incluye el runtime de .NET
LINQ	Language Integrated Query — consultas sobre colecciones
Markdown	Lenguaje de marcado ligero para documentación
CSV	Comma Separated Values — formato de archivo tabular
