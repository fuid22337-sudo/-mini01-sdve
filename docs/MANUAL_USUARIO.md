**Sistema Digital de Votación Estudiantil (mini01)**

**Repositorio oficial:** https://github.com/fuid22337-sudo/-mini01-sdve

---

## Índice

1. [Introducción](#1-introducción)
2. [Requisitos del sistema](#2-requisitos-del-sistema)
3. [Inicio de la aplicación](#3-inicio-de-la-aplicación)
4. [Interfaz principal](#4-interfaz-principal)
5. [Emitir un voto](#5-emitir-un-voto)
6. [Candidatos oficiales, write-in y abstención](#6-candidatos-oficiales-write-in-y-abstención)
7. [Ver resultados](#7-ver-resultados)
8. [Exportar resultados](#8-exportar-resultados)
9. [Preguntas frecuentes](#9-preguntas-frecuentes)

---

1. Introducción

El **Sistema Digital de Votación Estudiantil (SDVE)** es una aplicación de
escritorio desarrollada en C# con Windows Forms que permite gestionar
procesos de votación escolar para hasta **tres convocatorias simultáneas**:

- Sociedad de Alumnos
- Consejo Universitario
- Consejo de Representantes

El sistema permite votar por candidatos oficiales precargados o registrar
**candidatos no registrados** (write-in) por iniciativa del propio votante.
Además, calcula y muestra los resultados agrupados por **Grupo**, **Carrera**
y **Centro Universitario**, y permite exportar los datos a formato CSV.

---

2. Requisitos del sistema

| Recurso | Mínimo |
|---------|--------|
| Sistema operativo | Windows 10 o superior (64 bits) |
| Memoria RAM | 2 GB |
| Espacio en disco | 100 MB |
| Conexión a internet | No requerida |
| Permisos | Usuario estándar (no requiere admin) |

> La aplicación funciona **100 % offline** una vez instalada.

---

## 3. Inicio de la aplicación

### 3.1 Instalación

1. Descarga el archivo `mini01.exe` desde el repositorio o recíbelo en el
   paquete de instalación.
2. Extrae el archivo en cualquier carpeta de tu preferencia (por ejemplo,
   `C:\SDVE\`).
3. No es necesario instalar dependencias adicionales.

### 3.2 Ejecución

1. Haz **doble clic** sobre `mini01.exe`.
2. Si Windows muestra la advertencia **"Windows protegió tu PC"**:
   - Clic en **Más información**.
   - Clic en **Ejecutar de todas formas**.
3. Se abrirá la ventana principal con el título:
   **"SDVE - Sistema Digital de Votación Estudiantil"**.

---

## 4. Interfaz principal

La ventana principal está organizada en **dos pestañas**:

| Pestaña | Función |
|---------|---------|
| **Emitir Voto** | Registro de votos de los alumnos |
| **Resultados** | Consulta, agregación y exportación de resultados |

### 4.1 Pestaña "Emitir Voto"

Contiene dos secciones:

- **Datos del Votante:** Matrícula, Grupo, Carrera y Centro Universitario.
- **Papeleta Electoral:** lista de las 3 convocatorias con sus respectivos
  controles de selección (checkbox, combo de candidatos oficiales y campo
  de texto para write-in).

Al final se encuentra el botón **✔ Emitir Voto**.

### 4.2 Pestaña "Resultados"

Contiene:

- Un contador de votantes totales.
- Un panel con el desglose completo de resultados.
- Botones **Actualizar** y **Exportar CSV**.

---

## 5. Emitir un voto

### Paso 1 — Capturar los datos del votante

Completa los cuatro campos obligatorios:

| Campo | Ejemplo |
|-------|---------|
| Matrícula | `A001` |
| Grupo | `6A` |
| Carrera | `Ingeniería` |
| Centro Universitario | `Centro Norte` |

> Todos los campos son obligatorios. Si alguno queda vacío, el sistema
> mostrará un mensaje de error.

### Paso 2 — Seleccionar las convocatorias

Marca con **una o varias** convocatorias. El sistema permite combinaciones
libres:

- Solo Sociedad de Alumnos.
- Solo Consejo Universitario.
- Solo Consejo de Representantes.
- Cualquier combinación de 2.
- Las 3 simultáneamente.

Al marcar cada convocatoria, se habilitan automáticamente sus controles.

### Paso 3 — Elegir el candidato

Para cada convocatoria marcada, tienes **dos opciones**:

**Opción A — Candidato oficial:**
Selecciona el nombre del menú desplegable.

**Opción B — Candidato write-in:**
Escribe el nombre en el campo de texto ubicado a la derecha del combo.

> Si escribes algo en el campo write-in, **tiene prioridad** sobre el
> candidato seleccionado en el combo.

### Paso 4 — Confirmar el voto

Clic en el botón **✔ Emitir Voto**.

Aparecerá un mensaje de confirmación como:
¡Voto registrado correctamente!
Votante: A001
Convocatorias votadas: 3

text

### Validaciones del sistema

El sistema rechaza el voto si:

| Situación | Mensaje |
|-----------|---------|
| Algún campo del votante está vacío | "Complete todos los datos del votante." |
| No se marcó ninguna convocatoria | "Seleccione al menos una convocatoria para votar." |
| La matrícula ya votó antes | "Esta matrícula ya emitió su voto." |

> **Regla clave:** un alumno solo puede votar **una vez**.

---

## 6. Candidatos oficiales, write-in y abstención

| Tipo de voto | Cómo se emite |
|--------------|---------------|
| **Candidato oficial** | Seleccionar del menú desplegable |
| **Write-in** | Escribir el nombre en el campo de texto derecho |
| **Abstención** | Dejar el combo en `(Voto en blanco / Abstención)` |

### Reglas de prioridad

1. Si hay texto en el campo **write-in**, se usa ese nombre.
2. Si el write-in está vacío y hay un candidato seleccionado, se usa ese.
3. Si el combo está en `(Voto en blanco / Abstención)`, se cuenta como
   abstención.

---

## 7. Ver resultados

1. Ve a la pestaña **Resultados**.
2. Clic en el botón **Actualizar**.
3. La información se muestra en el panel, organizada así:

### 7.1 Por convocatoria

Para cada convocatoria activa:
══════ SOCIEDADALUMNOS ══════
Participación: 6 votos
Ana López → 2 votos (33.33%)
Pedro Candidato Inventado [WRITE-IN] → 2 votos (33.33%)
Carlos Ruiz → 1 voto (16.67%)
(Abstención) [ABSTENCIÓN] → 1 voto (16.67%)

text

### 7.2 Desglose por Grupo
── Desglose por Grupo ──
Grupo 6A: 3 votos
Grupo 6B: 1 voto
Grupo 4A: 2 votos

text

### 7.3 Desglose por Carrera
── Desglose por Carrera ──
Ingeniería: 3 votos
Medicina: 1 voto
Derecho: 2 votos

text

### 7.4 Desglose por Centro Universitario
── Desglose por Centro Universitario ──
Centro Norte: 4 votos
Centro Sur: 2 votos

text

### Etiquetas especiales

| Etiqueta | Significado |
|----------|-------------|
| `[WRITE-IN]` | Candidato no registrado |
| `[ABSTENCIÓN]` | Voto en blanco |

---

## 8. Exportar resultados

1. En la pestaña **Resultados**, clic en **💾 Exportar CSV**.
2. Se abrirá una ventana para elegir dónde guardar el archivo.
3. Escribe el nombre (por defecto: `resultados_sdve.csv`).
4. Clic en **Guardar**.
5. Aparecerá el mensaje: *"Datos exportados correctamente."*

### Formato del archivo CSV

El archivo contiene una fila por **cada voto emitido** (no por votante):

```csv
Matricula,Grupo,Carrera,CentroUniversitario,Convocatoria,Candidato,Tipo
A001,6A,Ingeniería,Centro Norte,SociedadAlumnos,Ana López,Oficial
A001,6A,Ingeniería,Centro Norte,ConsejoUniversitario,María Pérez,Oficial
A001,6A,Ingeniería,Centro Norte,ConsejoRepresentantes,Luis Torres,Oficial
A002,6A,Ingeniería,Centro Norte,SociedadAlumnos,Ana López,Oficial
A003,6B,Medicina,Centro Sur,SociedadAlumnos,Carlos Ruiz,Oficial
B001,4A,Derecho,Centro Norte,SociedadAlumnos,Pedro Candidato Inventado,WriteIn
C001,6A,Ingeniería,Centro Norte,SociedadAlumnos,(Abstención),Abstencion
Valores de la columna "Tipo"
Valor	Significado
Oficial	Candidato registrado en la lista oficial
WriteIn	Candidato no registrado propuesto por el votante
Abstencion	Voto en blanco
9. Preguntas frecuentes
¿Puedo votar solo por una convocatoria?
Sí. Marca solo la que te interese y deja las demás sin marcar.

¿Qué pasa si no marco ninguna convocatoria?
El sistema muestra un error y no permite emitir el voto.

¿Puedo votar dos veces con la misma matrícula?
No. El sistema bloquea el segundo intento con el mensaje
"Esta matrícula ya emitió su voto."

¿Puedo votar por alguien que no está en la lista?
Sí, usando el campo de texto write-in a la derecha de cada combo.

¿Los votos se guardan al cerrar el programa?
No. Los votos se mantienen solo en memoria mientras el programa está
abierto. Exporta el CSV antes de cerrar para no perder los datos.

¿Necesito conexión a internet?
No. La aplicación funciona completamente offline.

¿Puedo modificar un voto ya emitido?
No. Los votos son definitivos una vez registrados.

