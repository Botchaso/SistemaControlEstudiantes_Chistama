namespace SistemaControlEstudiantes_Chistama
{
    partial class AgregarEstudiante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarEstudiante));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bdpFechaNacAlumn = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bmtNombreAlumno = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bmtApellidosAlumno = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bmtDniAlumno = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bmtCarreraAlumn = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bdtEspecialidadAlumn = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtComentariosAlumno = new System.Windows.Forms.TextBox();
            this.bfbRegistrarAlumno = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCards1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.bunifuCards1.Controls.Add(this.bunifuCards2);
            this.bunifuCards1.Controls.Add(this.panel1);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(936, 637);
            this.bunifuCards1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Location = new System.Drawing.Point(1, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 112);
            this.panel1.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(23, 27);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnVolver.Size = new System.Drawing.Size(235, 60);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Tomato;
            this.bunifuCards2.Controls.Add(this.panel2);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(121, 168);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(712, 408);
            this.bunifuCards2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bfbRegistrarAlumno);
            this.panel2.Controls.Add(this.txtComentariosAlumno);
            this.panel2.Controls.Add(this.bmtDniAlumno);
            this.panel2.Controls.Add(this.bdtEspecialidadAlumn);
            this.panel2.Controls.Add(this.bmtApellidosAlumno);
            this.panel2.Controls.Add(this.bmtCarreraAlumn);
            this.panel2.Controls.Add(this.bmtNombreAlumno);
            this.panel2.Controls.Add(this.bdpFechaNacAlumn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(710, 400);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "DNI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha Nac.:";
            // 
            // bdpFechaNacAlumn
            // 
            this.bdpFechaNacAlumn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.bdpFechaNacAlumn.BorderRadius = 0;
            this.bdpFechaNacAlumn.ForeColor = System.Drawing.Color.White;
            this.bdpFechaNacAlumn.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bdpFechaNacAlumn.FormatCustom = null;
            this.bdpFechaNacAlumn.Location = new System.Drawing.Point(59, 252);
            this.bdpFechaNacAlumn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bdpFechaNacAlumn.Name = "bdpFechaNacAlumn";
            this.bdpFechaNacAlumn.Size = new System.Drawing.Size(219, 36);
            this.bdpFechaNacAlumn.TabIndex = 3;
            this.bdpFechaNacAlumn.Value = new System.DateTime(2019, 11, 27, 19, 9, 54, 351);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Carrera:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Especialidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Comentarios:";
            // 
            // bmtNombreAlumno
            // 
            this.bmtNombreAlumno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmtNombreAlumno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmtNombreAlumno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmtNombreAlumno.HintForeColor = System.Drawing.Color.Empty;
            this.bmtNombreAlumno.HintText = "";
            this.bmtNombreAlumno.isPassword = false;
            this.bmtNombreAlumno.LineFocusedColor = System.Drawing.Color.Blue;
            this.bmtNombreAlumno.LineIdleColor = System.Drawing.Color.Gray;
            this.bmtNombreAlumno.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bmtNombreAlumno.LineThickness = 3;
            this.bmtNombreAlumno.Location = new System.Drawing.Point(133, 51);
            this.bmtNombreAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.bmtNombreAlumno.Name = "bmtNombreAlumno";
            this.bmtNombreAlumno.Size = new System.Drawing.Size(171, 33);
            this.bmtNombreAlumno.TabIndex = 0;
            this.bmtNombreAlumno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bmtApellidosAlumno
            // 
            this.bmtApellidosAlumno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmtApellidosAlumno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmtApellidosAlumno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmtApellidosAlumno.HintForeColor = System.Drawing.Color.Empty;
            this.bmtApellidosAlumno.HintText = "";
            this.bmtApellidosAlumno.isPassword = false;
            this.bmtApellidosAlumno.LineFocusedColor = System.Drawing.Color.Blue;
            this.bmtApellidosAlumno.LineIdleColor = System.Drawing.Color.Gray;
            this.bmtApellidosAlumno.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bmtApellidosAlumno.LineThickness = 3;
            this.bmtApellidosAlumno.Location = new System.Drawing.Point(133, 115);
            this.bmtApellidosAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.bmtApellidosAlumno.Name = "bmtApellidosAlumno";
            this.bmtApellidosAlumno.Size = new System.Drawing.Size(171, 33);
            this.bmtApellidosAlumno.TabIndex = 1;
            this.bmtApellidosAlumno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bmtDniAlumno
            // 
            this.bmtDniAlumno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmtDniAlumno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmtDniAlumno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmtDniAlumno.HintForeColor = System.Drawing.Color.Empty;
            this.bmtDniAlumno.HintText = "";
            this.bmtDniAlumno.isPassword = false;
            this.bmtDniAlumno.LineFocusedColor = System.Drawing.Color.Blue;
            this.bmtDniAlumno.LineIdleColor = System.Drawing.Color.Gray;
            this.bmtDniAlumno.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bmtDniAlumno.LineThickness = 3;
            this.bmtDniAlumno.Location = new System.Drawing.Point(133, 170);
            this.bmtDniAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.bmtDniAlumno.Name = "bmtDniAlumno";
            this.bmtDniAlumno.Size = new System.Drawing.Size(171, 33);
            this.bmtDniAlumno.TabIndex = 2;
            this.bmtDniAlumno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bmtCarreraAlumn
            // 
            this.bmtCarreraAlumn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmtCarreraAlumn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmtCarreraAlumn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmtCarreraAlumn.HintForeColor = System.Drawing.Color.Empty;
            this.bmtCarreraAlumn.HintText = "";
            this.bmtCarreraAlumn.isPassword = false;
            this.bmtCarreraAlumn.LineFocusedColor = System.Drawing.Color.Blue;
            this.bmtCarreraAlumn.LineIdleColor = System.Drawing.Color.Gray;
            this.bmtCarreraAlumn.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bmtCarreraAlumn.LineThickness = 3;
            this.bmtCarreraAlumn.Location = new System.Drawing.Point(466, 57);
            this.bmtCarreraAlumn.Margin = new System.Windows.Forms.Padding(4);
            this.bmtCarreraAlumn.Name = "bmtCarreraAlumn";
            this.bmtCarreraAlumn.Size = new System.Drawing.Size(171, 33);
            this.bmtCarreraAlumn.TabIndex = 4;
            this.bmtCarreraAlumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bdtEspecialidadAlumn
            // 
            this.bdtEspecialidadAlumn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bdtEspecialidadAlumn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdtEspecialidadAlumn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bdtEspecialidadAlumn.HintForeColor = System.Drawing.Color.Empty;
            this.bdtEspecialidadAlumn.HintText = "";
            this.bdtEspecialidadAlumn.isPassword = false;
            this.bdtEspecialidadAlumn.LineFocusedColor = System.Drawing.Color.Blue;
            this.bdtEspecialidadAlumn.LineIdleColor = System.Drawing.Color.Gray;
            this.bdtEspecialidadAlumn.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bdtEspecialidadAlumn.LineThickness = 3;
            this.bdtEspecialidadAlumn.Location = new System.Drawing.Point(466, 115);
            this.bdtEspecialidadAlumn.Margin = new System.Windows.Forms.Padding(4);
            this.bdtEspecialidadAlumn.Name = "bdtEspecialidadAlumn";
            this.bdtEspecialidadAlumn.Size = new System.Drawing.Size(171, 33);
            this.bdtEspecialidadAlumn.TabIndex = 5;
            this.bdtEspecialidadAlumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtComentariosAlumno
            // 
            this.txtComentariosAlumno.Location = new System.Drawing.Point(365, 194);
            this.txtComentariosAlumno.MaxLength = 250;
            this.txtComentariosAlumno.Multiline = true;
            this.txtComentariosAlumno.Name = "txtComentariosAlumno";
            this.txtComentariosAlumno.Size = new System.Drawing.Size(272, 94);
            this.txtComentariosAlumno.TabIndex = 6;
            // 
            // bfbRegistrarAlumno
            // 
            this.bfbRegistrarAlumno.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bfbRegistrarAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bfbRegistrarAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbRegistrarAlumno.BorderRadius = 0;
            this.bfbRegistrarAlumno.ButtonText = "Registrar";
            this.bfbRegistrarAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbRegistrarAlumno.DisabledColor = System.Drawing.Color.Gray;
            this.bfbRegistrarAlumno.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbRegistrarAlumno.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbRegistrarAlumno.Iconimage")));
            this.bfbRegistrarAlumno.Iconimage_right = null;
            this.bfbRegistrarAlumno.Iconimage_right_Selected = null;
            this.bfbRegistrarAlumno.Iconimage_Selected = null;
            this.bfbRegistrarAlumno.IconMarginLeft = 0;
            this.bfbRegistrarAlumno.IconMarginRight = 0;
            this.bfbRegistrarAlumno.IconRightVisible = true;
            this.bfbRegistrarAlumno.IconRightZoom = 0D;
            this.bfbRegistrarAlumno.IconVisible = true;
            this.bfbRegistrarAlumno.IconZoom = 90D;
            this.bfbRegistrarAlumno.IsTab = false;
            this.bfbRegistrarAlumno.Location = new System.Drawing.Point(264, 329);
            this.bfbRegistrarAlumno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bfbRegistrarAlumno.Name = "bfbRegistrarAlumno";
            this.bfbRegistrarAlumno.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bfbRegistrarAlumno.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bfbRegistrarAlumno.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbRegistrarAlumno.selected = false;
            this.bfbRegistrarAlumno.Size = new System.Drawing.Size(208, 48);
            this.bfbRegistrarAlumno.TabIndex = 7;
            this.bfbRegistrarAlumno.Text = "Registrar";
            this.bfbRegistrarAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbRegistrarAlumno.Textcolor = System.Drawing.Color.White;
            this.bfbRegistrarAlumno.TextFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // AgregarEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 637);
            this.Controls.Add(this.bunifuCards1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AgregarEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar nuevo estudiante - Alumnia";
            this.bunifuCards1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.bunifuCards2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVolver;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bmtNombreAlumno;
        private Bunifu.Framework.UI.BunifuDatepicker bdpFechaNacAlumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bmtDniAlumno;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bdtEspecialidadAlumn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bmtApellidosAlumno;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bmtCarreraAlumn;
        private System.Windows.Forms.TextBox txtComentariosAlumno;
        private Bunifu.Framework.UI.BunifuFlatButton bfbRegistrarAlumno;
    }
}