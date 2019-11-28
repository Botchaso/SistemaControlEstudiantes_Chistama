namespace SistemaControlEstudiantes_Chistama
{
    partial class PanelPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelPrincipal));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbBienvenidaUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarEstudiante = new System.Windows.Forms.Button();
            this.btnEditarEstudiante = new System.Windows.Forms.Button();
            this.btnEliminarEstudiante = new System.Windows.Forms.Button();
            this.btnListarEstudiantes = new System.Windows.Forms.Button();
            this.bunifuCards1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.btnListarEstudiantes);
            this.bunifuCards1.Controls.Add(this.btnEliminarEstudiante);
            this.bunifuCards1.Controls.Add(this.btnEditarEstudiante);
            this.bunifuCards1.Controls.Add(this.btnAgregarEstudiante);
            this.bunifuCards1.Controls.Add(this.label2);
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
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbBienvenidaUser);
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 112);
            this.panel1.TabIndex = 1;
            // 
            // lbBienvenidaUser
            // 
            this.lbBienvenidaUser.AutoSize = true;
            this.lbBienvenidaUser.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBienvenidaUser.ForeColor = System.Drawing.Color.White;
            this.lbBienvenidaUser.Location = new System.Drawing.Point(12, 19);
            this.lbBienvenidaUser.Name = "lbBienvenidaUser";
            this.lbBienvenidaUser.Size = new System.Drawing.Size(352, 40);
            this.lbBienvenidaUser.TabIndex = 0;
            this.lbBienvenidaUser.Text = "¡Hola, {nombreUsuario}!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "--:--:--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(466, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Éstas son las acciones que puedes realizar:";
            // 
            // btnAgregarEstudiante
            // 
            this.btnAgregarEstudiante.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEstudiante.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarEstudiante.Image")));
            this.btnAgregarEstudiante.Location = new System.Drawing.Point(23, 247);
            this.btnAgregarEstudiante.Name = "btnAgregarEstudiante";
            this.btnAgregarEstudiante.Size = new System.Drawing.Size(210, 166);
            this.btnAgregarEstudiante.TabIndex = 0;
            this.btnAgregarEstudiante.Text = "Agregar estudiantes";
            this.btnAgregarEstudiante.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarEstudiante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregarEstudiante.UseVisualStyleBackColor = true;
            // 
            // btnEditarEstudiante
            // 
            this.btnEditarEstudiante.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarEstudiante.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarEstudiante.Image")));
            this.btnEditarEstudiante.Location = new System.Drawing.Point(251, 247);
            this.btnEditarEstudiante.Name = "btnEditarEstudiante";
            this.btnEditarEstudiante.Size = new System.Drawing.Size(210, 166);
            this.btnEditarEstudiante.TabIndex = 1;
            this.btnEditarEstudiante.Text = "Editar datos estudiantes";
            this.btnEditarEstudiante.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditarEstudiante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditarEstudiante.UseVisualStyleBackColor = true;
            // 
            // btnEliminarEstudiante
            // 
            this.btnEliminarEstudiante.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEstudiante.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarEstudiante.Image")));
            this.btnEliminarEstudiante.Location = new System.Drawing.Point(479, 247);
            this.btnEliminarEstudiante.Name = "btnEliminarEstudiante";
            this.btnEliminarEstudiante.Size = new System.Drawing.Size(210, 166);
            this.btnEliminarEstudiante.TabIndex = 2;
            this.btnEliminarEstudiante.Text = "Eliminar estudiantes";
            this.btnEliminarEstudiante.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarEstudiante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminarEstudiante.UseVisualStyleBackColor = true;
            // 
            // btnListarEstudiantes
            // 
            this.btnListarEstudiantes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarEstudiantes.Image = ((System.Drawing.Image)(resources.GetObject("btnListarEstudiantes.Image")));
            this.btnListarEstudiantes.Location = new System.Drawing.Point(707, 247);
            this.btnListarEstudiantes.Name = "btnListarEstudiantes";
            this.btnListarEstudiantes.Size = new System.Drawing.Size(210, 166);
            this.btnListarEstudiantes.TabIndex = 3;
            this.btnListarEstudiantes.Text = "Listar estudiantes";
            this.btnListarEstudiantes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListarEstudiantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnListarEstudiantes.UseVisualStyleBackColor = true;
            // 
            // PanelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 637);
            this.Controls.Add(this.bunifuCards1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "PanelPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel de administración - Alumnia";
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbBienvenidaUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnListarEstudiantes;
        private System.Windows.Forms.Button btnEliminarEstudiante;
        private System.Windows.Forms.Button btnEditarEstudiante;
        private System.Windows.Forms.Button btnAgregarEstudiante;
    }
}