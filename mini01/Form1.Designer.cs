namespace mini01
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tabControl = new TabControl();
            tabVotar = new TabPage();
            btnVotar = new Button();
            gbPapeleta = new GroupBox();
            chkSociedad = new CheckBox();
            cmbSociedad = new ComboBox();
            txtWriteSociedad = new TextBox();
            chkConsejoU = new CheckBox();
            cmbConsejoU = new ComboBox();
            txtWriteConsejoU = new TextBox();
            chkConsejoR = new CheckBox();
            cmbConsejoR = new ComboBox();
            txtWriteConsejoR = new TextBox();
            gbVotante = new GroupBox();
            lblMatricula = new Label();
            txtMatricula = new TextBox();
            lblGrupo = new Label();
            txtGrupo = new TextBox();
            lblCarrera = new Label();
            txtCarrera = new TextBox();
            lblCentro = new Label();
            txtCentro = new TextBox();
            tabResultados = new TabPage();
            lstResultados = new ListBox();
            btnActualizar = new Button();
            btnExportar = new Button();
            lblTotal = new Label();
            tabControl.SuspendLayout();
            tabVotar.SuspendLayout();
            gbPapeleta.SuspendLayout();
            gbVotante.SuspendLayout();
            tabResultados.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabVotar);
            tabControl.Controls.Add(tabResultados);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(4, 5, 4, 5);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1093, 862);
            tabControl.TabIndex = 0;
            // 
            // tabVotar
            // 
            tabVotar.Controls.Add(btnVotar);
            tabVotar.Controls.Add(gbPapeleta);
            tabVotar.Controls.Add(gbVotante);
            tabVotar.Location = new Point(4, 29);
            tabVotar.Margin = new Padding(4, 5, 4, 5);
            tabVotar.Name = "tabVotar";
            tabVotar.Padding = new Padding(4, 5, 4, 5);
            tabVotar.Size = new Size(1085, 829);
            tabVotar.TabIndex = 0;
            tabVotar.Text = "Emitir Voto";
            tabVotar.UseVisualStyleBackColor = true;
            // 
            // btnVotar
            // 
            btnVotar.BackColor = Color.FromArgb(30, 144, 255);
            btnVotar.FlatAppearance.BorderSize = 0;
            btnVotar.FlatStyle = FlatStyle.Flat;
            btnVotar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVotar.ForeColor = Color.White;
            btnVotar.Location = new Point(20, 708);
            btnVotar.Margin = new Padding(4, 5, 4, 5);
            btnVotar.Name = "btnVotar";
            btnVotar.Size = new Size(267, 77);
            btnVotar.TabIndex = 2;
            btnVotar.Text = "✔ Emitir Voto";
            btnVotar.UseVisualStyleBackColor = false;
            btnVotar.Click += btnVotar_Click;
            // 
            // gbPapeleta
            // 
            gbPapeleta.Controls.Add(chkSociedad);
            gbPapeleta.Controls.Add(cmbSociedad);
            gbPapeleta.Controls.Add(txtWriteSociedad);
            gbPapeleta.Controls.Add(chkConsejoU);
            gbPapeleta.Controls.Add(cmbConsejoU);
            gbPapeleta.Controls.Add(txtWriteConsejoU);
            gbPapeleta.Controls.Add(chkConsejoR);
            gbPapeleta.Controls.Add(cmbConsejoR);
            gbPapeleta.Controls.Add(txtWriteConsejoR);
            gbPapeleta.Location = new Point(20, 192);
            gbPapeleta.Margin = new Padding(4, 5, 4, 5);
            gbPapeleta.Name = "gbPapeleta";
            gbPapeleta.Padding = new Padding(4, 5, 4, 5);
            gbPapeleta.Size = new Size(1027, 492);
            gbPapeleta.TabIndex = 1;
            gbPapeleta.TabStop = false;
            gbPapeleta.Text = "Papeleta Electoral (seleccione las convocatorias a votar)";
            // 
            // chkSociedad
            // 
            chkSociedad.AutoSize = true;
            chkSociedad.Location = new Point(27, 46);
            chkSociedad.Margin = new Padding(4, 5, 4, 5);
            chkSociedad.Name = "chkSociedad";
            chkSociedad.Size = new Size(176, 24);
            chkSociedad.TabIndex = 0;
            chkSociedad.Text = "Sociedad de Alumnos";
            chkSociedad.UseVisualStyleBackColor = true;
            chkSociedad.CheckedChanged += chkSociedad_CheckedChanged;
            // 
            // cmbSociedad
            // 
            cmbSociedad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSociedad.Enabled = false;
            cmbSociedad.FormattingEnabled = true;
            cmbSociedad.Location = new Point(267, 43);
            cmbSociedad.Margin = new Padding(4, 5, 4, 5);
            cmbSociedad.Name = "cmbSociedad";
            cmbSociedad.Size = new Size(265, 28);
            cmbSociedad.TabIndex = 1;
            cmbSociedad.FlatStyle = FlatStyle.Flat;
            cmbSociedad.BackColor = Color.WhiteSmoke;
            cmbSociedad.Font = new Font("Segoe UI", 9F);
            // 
            // txtWriteSociedad
            // 
            txtWriteSociedad.Enabled = false;
            txtWriteSociedad.Location = new Point(547, 43);
            txtWriteSociedad.Margin = new Padding(4, 5, 4, 5);
            txtWriteSociedad.Name = "txtWriteSociedad";
            txtWriteSociedad.PlaceholderText = "Candidato no registrado (opcional)";
            txtWriteSociedad.Size = new Size(265, 27);
            txtWriteSociedad.TabIndex = 2;
            txtWriteSociedad.BorderStyle = BorderStyle.FixedSingle;
            txtWriteSociedad.BackColor = Color.White;
            txtWriteSociedad.Font = new Font("Segoe UI", 9F);
            // 
            // chkConsejoU
            // 
            chkConsejoU.AutoSize = true;
            chkConsejoU.Location = new Point(27, 185);
            chkConsejoU.Margin = new Padding(4, 5, 4, 5);
            chkConsejoU.Name = "chkConsejoU";
            chkConsejoU.Size = new Size(171, 24);
            chkConsejoU.TabIndex = 3;
            chkConsejoU.Text = "Consejo Universitario";
            chkConsejoU.UseVisualStyleBackColor = true;
            chkConsejoU.CheckedChanged += chkConsejoU_CheckedChanged;
            // 
            // cmbConsejoU
            // 
            cmbConsejoU.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbConsejoU.Enabled = false;
            cmbConsejoU.FormattingEnabled = true;
            cmbConsejoU.Location = new Point(267, 182);
            cmbConsejoU.Margin = new Padding(4, 5, 4, 5);
            cmbConsejoU.Name = "cmbConsejoU";
            cmbConsejoU.Size = new Size(265, 28);
            cmbConsejoU.TabIndex = 4;
            cmbConsejoU.FlatStyle = FlatStyle.Flat;
            cmbConsejoU.BackColor = Color.WhiteSmoke;
            cmbConsejoU.Font = new Font("Segoe UI", 9F);
            // 
            // txtWriteConsejoU
            // 
            txtWriteConsejoU.Enabled = false;
            txtWriteConsejoU.Location = new Point(547, 182);
            txtWriteConsejoU.Margin = new Padding(4, 5, 4, 5);
            txtWriteConsejoU.Name = "txtWriteConsejoU";
            txtWriteConsejoU.PlaceholderText = "Candidato no registrado (opcional)";
            txtWriteConsejoU.Size = new Size(265, 27);
            txtWriteConsejoU.TabIndex = 5;
            txtWriteConsejoU.BorderStyle = BorderStyle.FixedSingle;
            txtWriteConsejoU.BackColor = Color.White;
            txtWriteConsejoU.Font = new Font("Segoe UI", 9F);
            // 
            // chkConsejoR
            // 
            chkConsejoR.AutoSize = true;
            chkConsejoR.Location = new Point(27, 323);
            chkConsejoR.Margin = new Padding(4, 5, 4, 5);
            chkConsejoR.Name = "chkConsejoR";
            chkConsejoR.Size = new Size(210, 24);
            chkConsejoR.TabIndex = 6;
            chkConsejoR.Text = "Consejo de Representantes";
            chkConsejoR.UseVisualStyleBackColor = true;
            chkConsejoR.CheckedChanged += chkConsejoR_CheckedChanged;
            // 
            // cmbConsejoR
            // 
            cmbConsejoR.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbConsejoR.Enabled = false;
            cmbConsejoR.FormattingEnabled = true;
            cmbConsejoR.Location = new Point(267, 320);
            cmbConsejoR.Margin = new Padding(4, 5, 4, 5);
            cmbConsejoR.Name = "cmbConsejoR";
            cmbConsejoR.Size = new Size(265, 28);
            cmbConsejoR.TabIndex = 7;
            cmbConsejoR.FlatStyle = FlatStyle.Flat;
            cmbConsejoR.BackColor = Color.WhiteSmoke;
            cmbConsejoR.Font = new Font("Segoe UI", 9F);
            // 
            // txtWriteConsejoR
            // 
            txtWriteConsejoR.Enabled = false;
            txtWriteConsejoR.Location = new Point(547, 320);
            txtWriteConsejoR.Margin = new Padding(4, 5, 4, 5);
            txtWriteConsejoR.Name = "txtWriteConsejoR";
            txtWriteConsejoR.PlaceholderText = "Candidato no registrado (opcional)";
            txtWriteConsejoR.Size = new Size(265, 27);
            txtWriteConsejoR.TabIndex = 8;
            txtWriteConsejoR.BorderStyle = BorderStyle.FixedSingle;
            txtWriteConsejoR.BackColor = Color.White;
            txtWriteConsejoR.Font = new Font("Segoe UI", 9F);
            // 
            // gbVotante
            // 
            gbVotante.Controls.Add(lblMatricula);
            gbVotante.Controls.Add(txtMatricula);
            gbVotante.Controls.Add(lblGrupo);
            gbVotante.Controls.Add(txtGrupo);
            gbVotante.Controls.Add(lblCarrera);
            gbVotante.Controls.Add(txtCarrera);
            gbVotante.Controls.Add(lblCentro);
            gbVotante.Controls.Add(txtCentro);
            gbVotante.Location = new Point(20, 23);
            gbVotante.Margin = new Padding(4, 5, 4, 5);
            gbVotante.Name = "gbVotante";
            gbVotante.Padding = new Padding(4, 5, 4, 5);
            gbVotante.Size = new Size(1027, 154);
            gbVotante.TabIndex = 0;
            gbVotante.TabStop = false;
            gbVotante.Text = "Datos del Votante";
            gbVotante.ForeColor = Color.FromArgb(80, 80, 80);
            gbVotante.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(20, 46);
            lblMatricula.Margin = new Padding(4, 0, 4, 0);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(74, 20);
            lblMatricula.TabIndex = 0;
            lblMatricula.Text = "Matrícula:";
            lblMatricula.ForeColor = Color.FromArgb(64, 64, 64);
            lblMatricula.Font = new Font("Segoe UI", 9F);
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(120, 42);
            txtMatricula.Margin = new Padding(4, 5, 4, 5);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(159, 27);
            txtMatricula.TabIndex = 1;
            txtMatricula.BorderStyle = BorderStyle.FixedSingle;
            txtMatricula.BackColor = Color.White;
            txtMatricula.Font = new Font("Segoe UI", 9F);
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.Location = new Point(307, 46);
            lblGrupo.Margin = new Padding(4, 0, 4, 0);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(53, 20);
            lblGrupo.TabIndex = 2;
            lblGrupo.Text = "Grupo:";
            lblGrupo.ForeColor = Color.FromArgb(64, 64, 64);
            lblGrupo.Font = new Font("Segoe UI", 9F);
            // 
            // txtGrupo
            // 
            txtGrupo.Location = new Point(387, 42);
            txtGrupo.Margin = new Padding(4, 5, 4, 5);
            txtGrupo.Name = "txtGrupo";
            txtGrupo.Size = new Size(105, 27);
            txtGrupo.TabIndex = 3;
            txtGrupo.BorderStyle = BorderStyle.FixedSingle;
            txtGrupo.BackColor = Color.White;
            txtGrupo.Font = new Font("Segoe UI", 9F);
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Location = new Point(520, 46);
            lblCarrera.Margin = new Padding(4, 0, 4, 0);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(60, 20);
            lblCarrera.TabIndex = 4;
            lblCarrera.Text = "Carrera:";
            lblCarrera.ForeColor = Color.FromArgb(64, 64, 64);
            lblCarrera.Font = new Font("Segoe UI", 9F);
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(600, 42);
            txtCarrera.Margin = new Padding(4, 5, 4, 5);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(185, 27);
            txtCarrera.TabIndex = 5;
            txtCarrera.BorderStyle = BorderStyle.FixedSingle;
            txtCarrera.BackColor = Color.White;
            txtCarrera.Font = new Font("Segoe UI", 9F);
            // 
            // lblCentro
            // 
            lblCentro.AutoSize = true;
            lblCentro.Location = new Point(20, 92);
            lblCentro.Margin = new Padding(4, 0, 4, 0);
            lblCentro.Name = "lblCentro";
            lblCentro.Size = new Size(140, 20);
            lblCentro.TabIndex = 6;
            lblCentro.Text = "Centro Universitario";
            lblCentro.ForeColor = Color.FromArgb(64, 64, 64);
            lblCentro.Font = new Font("Segoe UI", 9F);
            // 
            // txtCentro
            // 
            txtCentro.Location = new Point(168, 92);
            txtCentro.Margin = new Padding(4, 5, 4, 5);
            txtCentro.Name = "txtCentro";
            txtCentro.Size = new Size(265, 27);
            txtCentro.TabIndex = 7;
            txtCentro.BorderStyle = BorderStyle.FixedSingle;
            txtCentro.BackColor = Color.White;
            txtCentro.Font = new Font("Segoe UI", 9F);
            txtCentro.TextChanged += txtCentro_TextChanged;
            // 
            // tabResultados
            // 
            tabResultados.Controls.Add(lstResultados);
            tabResultados.Controls.Add(btnActualizar);
            tabResultados.Controls.Add(btnExportar);
            tabResultados.Controls.Add(lblTotal);
            tabResultados.Location = new Point(4, 29);
            tabResultados.Margin = new Padding(4, 5, 4, 5);
            tabResultados.Name = "tabResultados";
            tabResultados.Padding = new Padding(4, 5, 4, 5);
            tabResultados.Size = new Size(1085, 829);
            tabResultados.TabIndex = 1;
            tabResultados.Text = "Resultados";
            tabResultados.UseVisualStyleBackColor = true;
            // 
            // lstResultados
            // 
            lstResultados.Font = new Font("Consolas", 10F);
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(20, 92);
            lstResultados.Margin = new Padding(4, 5, 4, 5);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(1039, 644);
            lstResultados.TabIndex = 1;
            lstResultados.BorderStyle = BorderStyle.None;
            lstResultados.BackColor = Color.White;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(20, 754);
            btnActualizar.Margin = new Padding(4, 5, 4, 5);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(200, 54);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "🔄 Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.BackColor = Color.WhiteSmoke;
            btnActualizar.ForeColor = Color.FromArgb(64, 64, 64);
            btnActualizar.Font = new Font("Segoe UI", 9F);
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(240, 754);
            btnExportar.Margin = new Padding(4, 5, 4, 5);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(200, 54);
            btnExportar.TabIndex = 3;
            btnExportar.Text = "💾 Exportar CSV";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.FlatAppearance.BorderSize = 0;
            btnExportar.BackColor = Color.WhiteSmoke;
            btnExportar.ForeColor = Color.FromArgb(64, 64, 64);
            btnExportar.Font = new Font("Segoe UI", 9F);
            btnExportar.Click += btnExportar_Click;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotal.Location = new Point(20, 31);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(933, 46);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total de votantes registrados: 0";
            lblTotal.ForeColor = Color.FromArgb(44, 44, 44);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 862);
            Controls.Add(tabControl);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SDVE - Sistema Digital de Votación Estudiantil";
            BackColor = Color.White;
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.FromArgb(44, 44, 44);
            tabControl.ResumeLayout(false);
            tabVotar.ResumeLayout(false);
            gbPapeleta.ResumeLayout(false);
            gbPapeleta.PerformLayout();
            gbVotante.ResumeLayout(false);
            gbVotante.PerformLayout();
            tabResultados.ResumeLayout(false);
            ResumeLayout(false);
        }

        // ─────────────────────────────────────────────
        // Declaración de controles
        // ─────────────────────────────────────────────
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabVotar;
        private System.Windows.Forms.TabPage tabResultados;
        private System.Windows.Forms.GroupBox gbVotante;
        private System.Windows.Forms.GroupBox gbPapeleta;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.TextBox txtCentro;
        private System.Windows.Forms.TextBox txtWriteSociedad;
        private System.Windows.Forms.TextBox txtWriteConsejoU;
        private System.Windows.Forms.TextBox txtWriteConsejoR;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblCentro;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chkSociedad;
        private System.Windows.Forms.CheckBox chkConsejoU;
        private System.Windows.Forms.CheckBox chkConsejoR;
        private System.Windows.Forms.ComboBox cmbSociedad;
        private System.Windows.Forms.ComboBox cmbConsejoU;
        private System.Windows.Forms.ComboBox cmbConsejoR;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ListBox lstResultados;
    }
}