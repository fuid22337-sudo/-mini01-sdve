using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mini01
{
    public partial class Form1 : Form
    {
        private List<Votante> votantes = new List<Votante>();
        private List<Candidato> candidatosOficiales = new List<Candidato>();

        public Form1()
        {
            InitializeComponent();
            CargarCandidatosOficiales();
        }

        private void CargarCandidatosOficiales()
        {
            candidatosOficiales.Add(new Candidato("Ana López", Convocatoria.SociedadAlumnos));
            candidatosOficiales.Add(new Candidato("Carlos Ruiz", Convocatoria.SociedadAlumnos));
            candidatosOficiales.Add(new Candidato("María Pérez", Convocatoria.ConsejoUniversitario));
            candidatosOficiales.Add(new Candidato("Juan Díaz", Convocatoria.ConsejoUniversitario));
            candidatosOficiales.Add(new Candidato("Luis Torres", Convocatoria.ConsejoRepresentantes));
            candidatosOficiales.Add(new Candidato("Sofía Márquez", Convocatoria.ConsejoRepresentantes));

            CargarCombo(cmbSociedad, Convocatoria.SociedadAlumnos);
            CargarCombo(cmbConsejoU, Convocatoria.ConsejoUniversitario);
            CargarCombo(cmbConsejoR, Convocatoria.ConsejoRepresentantes);
        }

        private void CargarCombo(ComboBox cmb, Convocatoria conv)
        {
            cmb.Items.Clear();
            cmb.Items.Add("(Voto en blanco / Abstención)");
            foreach (var c in candidatosOficiales.Where(x => x.Convocatoria == conv))
                cmb.Items.Add(c.Nombre);
            cmb.SelectedIndex = 0;
        }

      
        //MÉTODOS QUE EL DISEÑADOR INVOCA 

        private void chkSociedad_CheckedChanged(object sender, EventArgs e)
        {
            cmbSociedad.Enabled = txtWriteSociedad.Enabled = chkSociedad.Checked;
        }

        private void chkConsejoU_CheckedChanged(object sender, EventArgs e)
        {
            cmbConsejoU.Enabled = txtWriteConsejoU.Enabled = chkConsejoU.Checked;
        }

        private void chkConsejoR_CheckedChanged(object sender, EventArgs e)
        {
            cmbConsejoR.Enabled = txtWriteConsejoR.Enabled = chkConsejoR.Checked;
        }

   
        // Emitir voto
       
        private void btnVotar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatricula.Text) ||
                string.IsNullOrWhiteSpace(txtGrupo.Text) ||
                string.IsNullOrWhiteSpace(txtCarrera.Text) ||
                string.IsNullOrWhiteSpace(txtCentro.Text))
            {
                MessageBox.Show("Complete todos los datos del votante.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!chkSociedad.Checked && !chkConsejoU.Checked && !chkConsejoR.Checked)
            {
                MessageBox.Show("Seleccione al menos una convocatoria para votar.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (votantes.Any(v => v.Matricula == txtMatricula.Text.Trim()))
            {
                MessageBox.Show("Esta matrícula ya emitió su voto.", "Voto duplicado",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var votante = new Votante
            {
                Matricula = txtMatricula.Text.Trim(),
                Grupo = txtGrupo.Text.Trim(),
                Carrera = txtCarrera.Text.Trim(),
                CentroUniversitario = txtCentro.Text.Trim()
            };

            if (chkSociedad.Checked)
                votante.Votos.Add(CrearVoto(Convocatoria.SociedadAlumnos, cmbSociedad, txtWriteSociedad));
            if (chkConsejoU.Checked)
                votante.Votos.Add(CrearVoto(Convocatoria.ConsejoUniversitario, cmbConsejoU, txtWriteConsejoU));
            if (chkConsejoR.Checked)
                votante.Votos.Add(CrearVoto(Convocatoria.ConsejoRepresentantes, cmbConsejoR, txtWriteConsejoR));

            votantes.Add(votante);

            MessageBox.Show($"¡Voto registrado correctamente!\nVotante: {votante.Matricula}\n" +
                            $"Convocatorias votadas: {votante.Votos.Count}",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarFormulario();
        }

        private Voto CrearVoto(Convocatoria conv, ComboBox cmb, TextBox txtWrite)
        {
            if (!string.IsNullOrWhiteSpace(txtWrite.Text))
            {
                return new Voto
                {
                    Convocatoria = conv,
                    NombreCandidato = txtWrite.Text.Trim(),
                    EsNulo = false
                };
            }

            if (cmb.SelectedIndex <= 0)
                return new Voto { Convocatoria = conv, NombreCandidato = "(Abstención)", EsNulo = true };

            string? seleccionado = cmb.SelectedItem?.ToString();
            return new Voto
            {
                Convocatoria = conv,
                NombreCandidato = seleccionado ?? "(Abstención)",
                EsNulo = false
            };
        }

        private void LimpiarFormulario()
        {
            txtMatricula.Clear(); txtGrupo.Clear(); txtCarrera.Clear(); txtCentro.Clear();
            chkSociedad.Checked = chkConsejoU.Checked = chkConsejoR.Checked = false;
            cmbSociedad.SelectedIndex = cmbConsejoU.SelectedIndex = cmbConsejoR.SelectedIndex = 0;
            txtWriteSociedad.Clear(); txtWriteConsejoU.Clear(); txtWriteConsejoR.Clear();
        }

        // Resultados
        
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MostrarResultados();
        }

        private void MostrarResultados()
        {
            lstResultados.Items.Clear();

            int totalVotantes = votantes.Count;
            lblTotal.Text = $"Total de votantes registrados: {totalVotantes}";

            if (totalVotantes == 0)
            {
                lstResultados.Items.Add("No hay votos registrados aún.");
                return;
            }

            foreach (Convocatoria conv in Enum.GetValues(typeof(Convocatoria)))
            {
                var votosConv = votantes
                    .SelectMany(v => v.Votos)
                    .Where(x => x.Convocatoria == conv)
                    .ToList();

                if (votosConv.Count == 0) continue;

                lstResultados.Items.Add($"══════ {conv.ToString().ToUpper()} ══════");
                lstResultados.Items.Add($"Participación: {votosConv.Count} votos");

                var agrupados = votosConv
                    .GroupBy(v => v.NombreCandidato)
                    .OrderByDescending(g => g.Count());

                foreach (var g in agrupados)
                {
                    double pct = (double)g.Count() / votosConv.Count * 100;
                    string tipo = g.First().EsNulo ? " [ABSTENCIÓN]" :
                                  !candidatosOficiales.Any(c => c.Nombre == g.Key &&
                                      c.Convocatoria == conv) ? " [WRITE-IN]" : "";
                    lstResultados.Items.Add(
                        $"   {g.Key}{tipo} → {g.Count()} votos ({pct:F2}%)");
                }

                lstResultados.Items.Add("   ── Desglose por Grupo ──");
                foreach (var grp in votosConv.GroupBy(v =>
                    votantes.First(x => x.Votos.Contains(v)).Grupo))
                {
                    lstResultados.Items.Add($"     Grupo {grp.Key}: {grp.Count()} votos");
                }

                lstResultados.Items.Add("   ── Desglose por Carrera ──");
                foreach (var grp in votosConv.GroupBy(v =>
                    votantes.First(x => x.Votos.Contains(v)).Carrera))
                {
                    lstResultados.Items.Add($"     {grp.Key}: {grp.Count()} votos");
                }

                lstResultados.Items.Add("   ── Desglose por Centro Universitario ──");
                foreach (var grp in votosConv.GroupBy(v =>
                    votantes.First(x => x.Votos.Contains(v)).CentroUniversitario))
                {
                    lstResultados.Items.Add($"     {grp.Key}: {grp.Count()} votos");
                }

                lstResultados.Items.Add("");
            }
        }

       
        // Exportar CSV
      
        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (votantes.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Exportar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "resultados_sdve.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Matricula,Grupo,Carrera,CentroUniversitario,Convocatoria,Candidato,Tipo");

                    foreach (var v in votantes)
                    {
                        foreach (var voto in v.Votos)
                        {
                            string tipo = voto.EsNulo ? "Abstencion" :
                                candidatosOficiales.Any(c => c.Nombre == voto.NombreCandidato &&
                                    c.Convocatoria == voto.Convocatoria)
                                ? "Oficial" : "WriteIn";

                            sb.AppendLine($"{v.Matricula},{v.Grupo},{v.Carrera}," +
                                          $"{v.CentroUniversitario},{voto.Convocatoria}," +
                                          $"{voto.NombreCandidato},{tipo}");
                        }
                    }

                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Datos exportados correctamente.", "Exportar",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtCentro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}