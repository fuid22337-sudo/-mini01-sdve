# SDVE - Sistema Digital de Votación Estudiantil (mini01)

🔗 **Repositorio oficial:** https://github.com/fuid22337-sudo/-mini01-sdve

Sistema de escritorio en **C# con Windows Forms** para gestionar procesos
de votación escolar con soporte para 3 convocatorias simultáneas.

## Características

- Votación en 1, 2 o 3 convocatorias: Sociedad de Alumnos, Consejo
  Universitario y Consejo de Representantes.
- Candidatos oficiales + candidatos write-in (no registrados).
- Validación de voto único por matrícula.
- Agregación por Grupo, Carrera y Centro Universitario.
- Cálculo de absolutos, porcentajes y abstencionismo.
- Exportación de resultados a CSV.

## Tecnologías

C# · .NET 6.0+ · Windows Forms · LINQ · Git

## Equipo

| Nombre | Rol |
|--------|-----|
| Ian Paulo Acevedo Aldana | Backend + QA |
| Juan Emiliano Muñoz Ibarra | Frontend + Documentación + DevOps |

Detalle completo en [`CONTRIBUTORS.md`](CONTRIBUTORS.md).

## Documentación

- [Manual de Usuario](docs/MANUAL_USUARIO.md)
- [Documentación Técnica](docs/DOCUMENTACION_TECNICA.md)
- [Instalación](docs/INSTALACION.md)

## Clonar el proyecto

```bash
git clone https://github.com/fuid22337-sudo/-mini01-sdve.git
cd -mini01-sdve
dotnet restore
dotnet run
```