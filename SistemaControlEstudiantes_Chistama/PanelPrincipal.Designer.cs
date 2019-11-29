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
            this.btnListarEstudiantes = new System.Windows.Forms.Button();
            this.btnEliminarEstudiante = new System.Windows.Forms.Button();
            this.btnEditarEstudiante = new System.Windows.Forms.Button();
            this.btnAgregarEstudiante = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bfbLogout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbHora = new System.Windows.Forms.Label();
            this.lbBienvenidaUser = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.btnListarEstudiantes.Click += new System.EventHandler(this.btnListarEstudiantes_Click);
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
            this.btnEliminarEstudiante.Click += new System.EventHandler(this.btnEliminarEstudiante_Click);
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
            this.btnEditarEstudiante.Click += new System.EventHandler(this.btnEditarEstudiante_Click);
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
            this.btnAgregarEstudiante.Click += new System.EventHandler(this.btnAgregarEstudiante_Click);
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.bfbLogout);
            this.panel1.Controls.Add(this.lbHora);
            this.panel1.Controls.Add(this.lbBienvenidaUser);
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 112);
            this.panel1.TabIndex = 1;
            // 
            // bfbLogout
            // 
            this.bfbLogout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bfbLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bfbLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbLogout.BorderRadius = 0;
            this.bfbLogout.ButtonText = "Cerrar sesión";
            this.bfbLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbLogout.DisabledColor = System.Drawing.Color.Gray;
            this.bfbLogout.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbLogout.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbLogout.Iconimage")));
            this.bfbLogout.Iconimage_right = null;
            this.bfbLogout.Iconimage_right_Selected = null;
            this.bfbLogout.Iconimage_Selected = null;
            this.bfbLogout.IconMarginLeft = 0;
            this.bfbLogout.IconMarginRight = 0;
            this.bfbLogout.IconRightVisible = true;
            this.bfbLogout.IconRightZoom = 0D;
            this.bfbLogout.IconVisible = true;
            this.bfbLogout.IconZoom = 72D;
            this.bfbLogout.IsTab = false;
            this.bfbLogout.Location = new System.Drawing.Point(727, 22);
            this.bfbLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bfbLogout.Name = "bfbLogout";
            this.bfbLogout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bfbLogout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bfbLogout.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbLogout.selected = false;
            this.bfbLogout.Size = new System.Drawing.Size(197, 58);
            this.bfbLogout.TabIndex = 1;
            this.bfbLogout.Text = "Cerrar sesión";
            this.bfbLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbLogout.Textcolor = System.Drawing.Color.White;
            this.bfbLogout.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbLogout.Click += new System.EventHandler(this.bfbLogout_Click);
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.ForeColor = System.Drawing.Color.White;
            this.lbHora.Location = new System.Drawing.Point(12, 67);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(85, 32);
            this.lbHora.TabIndex = 0;
            this.lbHora.Text = "--:--:--";
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
            // timer1
            // 
            this.timer1.Interval = 999;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PanelPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PanelPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.PanelPrincipal_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Label lbBienvenidaUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnListarEstudiantes;
        private System.Windows.Forms.Button btnEliminarEstudiante;
        private System.Windows.Forms.Button btnEditarEstudiante;
        private System.Windows.Forms.Button btnAgregarEstudiante;
        private Bunifu.Framework.UI.BunifuFlatButton bfbLogout;
    }
}