namespace SistemaControlEstudiantes_Chistama
{
    partial class EliminarAlumno
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarAlumno));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bibDarBajaAlumno = new Bunifu.Framework.UI.BunifuImageButton();
            this.cbListaAlumnos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bibDarBajaAlumno)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.bunifuCards1.Controls.Add(this.bibDarBajaAlumno);
            this.bunifuCards1.Controls.Add(this.cbListaAlumnos);
            this.bunifuCards1.Controls.Add(this.label1);
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
            // bibDarBajaAlumno
            // 
            this.bibDarBajaAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(53)))), ((int)(((byte)(74)))));
            this.bibDarBajaAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bibDarBajaAlumno.Image = ((System.Drawing.Image)(resources.GetObject("bibDarBajaAlumno.Image")));
            this.bibDarBajaAlumno.ImageActive = null;
            this.bibDarBajaAlumno.Location = new System.Drawing.Point(379, 361);
            this.bibDarBajaAlumno.Name = "bibDarBajaAlumno";
            this.bibDarBajaAlumno.Size = new System.Drawing.Size(212, 187);
            this.bibDarBajaAlumno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bibDarBajaAlumno.TabIndex = 5;
            this.bibDarBajaAlumno.TabStop = false;
            this.bibDarBajaAlumno.Zoom = 10;
            this.bibDarBajaAlumno.Click += new System.EventHandler(this.bibDarBajaAlumno_Click);
            // 
            // cbListaAlumnos
            // 
            this.cbListaAlumnos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbListaAlumnos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbListaAlumnos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbListaAlumnos.FormattingEnabled = true;
            this.cbListaAlumnos.Location = new System.Drawing.Point(148, 221);
            this.cbListaAlumnos.Name = "cbListaAlumnos";
            this.cbListaAlumnos.Size = new System.Drawing.Size(657, 38);
            this.cbListaAlumnos.TabIndex = 4;
            this.cbListaAlumnos.SelectedIndexChanged += new System.EventHandler(this.cbListaAlumnos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione el estudiante que desea eliminar:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 112);
            this.panel1.TabIndex = 2;
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
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.bibDarBajaAlumno;
            // 
            // EliminarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 637);
            this.Controls.Add(this.bunifuCards1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "EliminarAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dar de baja - Alumnia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EliminarAlumno_FormClosing);
            this.Load += new System.EventHandler(this.EliminarAlumno_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bibDarBajaAlumno)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVolver;
        private Bunifu.Framework.UI.BunifuImageButton bibDarBajaAlumno;
        private System.Windows.Forms.ComboBox cbListaAlumnos;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}