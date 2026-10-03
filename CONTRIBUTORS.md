#  Contribuidores del Proyecto

**SDVE - Sistema Digital de Votación Estudiantil (mini01)**

**Repositorio oficial:** https://github.com/fuid22337-sudo/-mini01-sdve
---

## Equipo de desarrollo

| Integrante | Rol |
|------------|-----|
| **Ian Paulo Acevedo Aldana** | Backend + QA |
| **Juan Emiliano Muñoz Ibarra** | Frontend + Documentación + DevOps |


---

##  Desglose de aportaciones

###  Ian Paulo Acevedo Aldana — Backend + QA

**Partes del proyecto que generó:**

#### Módulo Backend (Lógica de negocio)

- **Modelos de dominio** (`Modelos.cs`):
  - Clase `Votante` (matrícula, grupo, carrera, centro, lista de votos).
  - Clase `Voto` (convocatoria, candidato, indicador de abstención).
  - Clase `Candidato` (nombre, convocatoria, indicador write-in).
  - Enum `Convocatoria` (Sociedad de Alumnos, Consejo Universitario, Consejo de Representantes).

- **Validaciones del sistema:**
  - Verificación de datos completos del votante.
  - Verificación de que se marque al menos una convocatoria.
  - Bloqueo de voto duplicado por matrícula.

- **Motor de votación** (`btnVotar_Click` y `CrearVoto`):
  - Registro de votos por convocatoria.
  - Prioridad de write-in sobre candidato oficial.
  - Detección de abstención (voto en blanco).

- **Motor de agregación y conteo** (`MostrarResultados`):
  - Agrupación de votos por candidato usando LINQ.
  - Cálculo de absolutos y porcentajes.
  - Desglose por Grupo, Carrera y Centro Universitario.
  - Etiquetado automático de `[WRITE-IN]` y `[ABSTENCIÓN]`.

- **Exportación a CSV** (`btnExportar_Click`):
  - Generación de archivo con columnas estructuradas.
  - Clasificación del tipo de voto: `Oficial`, `WriteIn`, `Abstencion`.

#### Módulo de QA (Aseguramiento de calidad)

- Diseño de **13 casos de prueba funcionales**.
- Ejecución de las pruebas y validación de comportamiento esperado.
- Reporte y corrección de bugs detectados durante las pruebas.
- Verificación de bordes (datos vacíos, matrículas duplicadas, votos sin convocatoria).

**Archivos principales que generó:**
- `Modelos.cs`
- `Form1.cs` (métodos backend)

---

###  Juan Emiliano Muñoz Ibarra — Frontend + Documentación + DevOps

**Partes del proyecto que generó:**

#### Módulo Frontend (Interfaz gráfica)

- **Diseño del layout** (`Form1.Designer.cs`):
  - Pestañas `Emitir Voto` y `Resultados`.
  - Distribución de controles en el formulario.
  - Organización de paneles y grupos.

- **Creación de controles:**
  - TextBox para matrícula, grupo, carrera y centro.
  - ComboBox para selección de candidatos oficiales.
  - CheckBox para activar convocatorias.
  - TextBox para candidatos write-in.
  - ListBox para mostrar resultados.
  - Botones de Emitir Voto, Actualizar y Exportar.

- **Eventos de checkboxes dinámicos:**
  - `chkSociedad_CheckedChanged`
  - `chkConsejoU_CheckedChanged`
  - `chkConsejoR_CheckedChanged`
  - Habilitación/deshabilitación automática de controles.

- **Estilos visuales:**
  - Colores (botón verde para Emitir Voto).
  - Fuentes (Consolas para resultados, Segoe UI para títulos).
  - Tamaños y espaciado de controles.

- **Ajustes de usabilidad:**
  - Placeholder text en campos write-in.
  - Habilitación dinámica según convocatorias marcadas.
  - Alineación y agrupación lógica de controles.

#### Módulo de Documentación

- **Manual de Usuario** (`docs/MANUAL_USUARIO.md`):
  - Guía paso a paso para emitir votos.
  - Instrucciones para ver y exportar resultados.
  - Preguntas frecuentes.

- **Documentación Técnica** (`docs/DOCUMENTACION_TECNICA.md`):
  - Diagrama de arquitectura por capas.
  - Estructura del proyecto y clases.
  - Diagrama de flujo del proceso de votación.
  - Guía de mantenimiento y extensiones.

- **Guía de Instalación** (`docs/INSTALACION.md`):
  - Requisitos del sistema.
  - Instalación portátil y desde código fuente.
  - Solución de problemas comunes.

#### Módulo DevOps

- **Configuración del repositorio GitHub:**
  - Archivo `.gitignore` para excluir bin/obj/.vs.
  - `README.md` con presentación del proyecto.
  - `CONTRIBUTORS.md` (este archivo).
  - `LINK_GITHUB.txt` con el enlace al repositorio.
  - `CHANGELOG.md` con historial de versiones.

- **Instalador portátil:**
  - Configuración de Inno Setup.
  - Pruebas de instalación en PC limpia.
  - Empaquetado del Entregable 2.

- **Pruebas de integración UI ↔ lógica:**
  - Verificación de comunicación entre frontend y backend.

**Archivos principales que generó:**
- `Form1.Designer.cs`
- `docs/MANUAL_USUARIO.md`
- `docs/DOCUMENTACION_TECNICA.md`
- `docs/INSTALACION.md`
- `README.md`
- `CONTRIBUTORS.md`
- `LINK_GITHUB.txt`
- `CHANGELOG.md`
- `.gitignore`

---

## Tabla resumen de contribuciones

| Integrante | Rol | Áreas cubiertas |
|------------|-----|-----------------|
| Ian Paulo Acevedo Aldana | Backend + QA | Lógica, validaciones, agregación, exportación, pruebas |
| Juan Emiliano Muñoz Ibarra | Frontend + Docs + DevOps | UI, eventos, estilos, manuales, instalador, GitHub |


El código fuente completo y la documentación asociada pueden verificarse en:

 **** https://github.com/fuid22337-sudo/-mini01-sdve

