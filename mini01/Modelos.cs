using System;
using System.Collections.Generic;

namespace mini01
{
    public enum Convocatoria
    {
        SociedadAlumnos,
        ConsejoUniversitario,
        ConsejoRepresentantes
    }

    public class Candidato
    {
        public string Nombre { get; set; } = string.Empty;
        public Convocatoria Convocatoria { get; set; }
        public bool EsWriteIn { get; set; }

        public Candidato(string nombre, Convocatoria conv, bool esWriteIn = false)
        {
            Nombre = nombre;
            Convocatoria = conv;
            EsWriteIn = esWriteIn;
        }
    }

    public class Voto
    {
        public Convocatoria Convocatoria { get; set; }
        public string NombreCandidato { get; set; } = string.Empty;
        public bool EsNulo { get; set; }
    }

    public class Votante
    {
        public string Matricula { get; set; } = string.Empty;
        public string Grupo { get; set; } = string.Empty;
        public string Carrera { get; set; } = string.Empty;
        public string CentroUniversitario { get; set; } = string.Empty;
        public List<Voto> Votos { get; set; } = new List<Voto>();
    }
}