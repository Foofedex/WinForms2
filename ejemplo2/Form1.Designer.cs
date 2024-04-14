namespace ejemplo2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.elementos = new System.Windows.Forms.ListView();
            this.Nombre = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.FechaNAcimiento = new System.Windows.Forms.DateTimePicker();
            this.CKBChocolate = new System.Windows.Forms.CheckBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.RBTWizzard = new System.Windows.Forms.RadioButton();
            this.RBTMugle = new System.Windows.Forms.RadioButton();
            this.RBT3 = new System.Windows.Forms.RadioButton();
            this.Tipo = new System.Windows.Forms.GroupBox();
            this.Color = new System.Windows.Forms.Label();
            this.CBOFavorito = new System.Windows.Forms.ComboBox();
            this.NumeroFavorito = new System.Windows.Forms.NumericUpDown();
            this.LBLNumeroFAvorito = new System.Windows.Forms.Label();
            this.BTNVerPerfil = new System.Windows.Forms.Button();
            this.Tipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumeroFavorito)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(156, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(459, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.Location = new System.Drawing.Point(53, 547);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // elementos
            // 
            this.elementos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elementos.HideSelection = false;
            this.elementos.Location = new System.Drawing.Point(53, 384);
            this.elementos.Name = "elementos";
            this.elementos.Size = new System.Drawing.Size(609, 127);
            this.elementos.TabIndex = 7;
            this.elementos.UseCompatibleStateImageBehavior = false;
            this.elementos.View = System.Windows.Forms.View.List;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(93, 67);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 10;
            this.Nombre.Text = "Nombre";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(44, 102);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(93, 13);
            this.Fecha.TabIndex = 11;
            this.Fecha.Text = "Fecha Nacimiento";
            // 
            // FechaNAcimiento
            // 
            this.FechaNAcimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FechaNAcimiento.Location = new System.Drawing.Point(156, 102);
            this.FechaNAcimiento.Name = "FechaNAcimiento";
            this.FechaNAcimiento.Size = new System.Drawing.Size(459, 20);
            this.FechaNAcimiento.TabIndex = 1;
            // 
            // CKBChocolate
            // 
            this.CKBChocolate.AutoSize = true;
            this.CKBChocolate.Location = new System.Drawing.Point(156, 144);
            this.CKBChocolate.Name = "CKBChocolate";
            this.CKBChocolate.Size = new System.Drawing.Size(130, 17);
            this.CKBChocolate.TabIndex = 2;
            this.CKBChocolate.Text = "Te gusta el Chocolate";
            this.CKBChocolate.UseVisualStyleBackColor = true;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(59, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(184, 31);
            this.Titulo.TabIndex = 5;
            this.Titulo.Text = "Perfil Persona";
            // 
            // RBTWizzard
            // 
            this.RBTWizzard.AutoSize = true;
            this.RBTWizzard.Checked = true;
            this.RBTWizzard.Location = new System.Drawing.Point(6, 19);
            this.RBTWizzard.Name = "RBTWizzard";
            this.RBTWizzard.Size = new System.Drawing.Size(63, 17);
            this.RBTWizzard.TabIndex = 0;
            this.RBTWizzard.TabStop = true;
            this.RBTWizzard.Text = "Wizzard";
            this.RBTWizzard.UseVisualStyleBackColor = true;
            // 
            // RBTMugle
            // 
            this.RBTMugle.AutoSize = true;
            this.RBTMugle.Location = new System.Drawing.Point(115, 19);
            this.RBTMugle.Name = "RBTMugle";
            this.RBTMugle.Size = new System.Drawing.Size(60, 17);
            this.RBTMugle.TabIndex = 1;
            this.RBTMugle.Text = "Muggle";
            this.RBTMugle.UseVisualStyleBackColor = true;
            // 
            // RBT3
            // 
            this.RBT3.AutoSize = true;
            this.RBT3.Location = new System.Drawing.Point(228, 19);
            this.RBT3.Name = "RBT3";
            this.RBT3.Size = new System.Drawing.Size(57, 17);
            this.RBT3.TabIndex = 2;
            this.RBT3.Text = "Squibs";
            this.RBT3.UseVisualStyleBackColor = true;
            // 
            // Tipo
            // 
            this.Tipo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Tipo.Controls.Add(this.RBT3);
            this.Tipo.Controls.Add(this.RBTMugle);
            this.Tipo.Controls.Add(this.RBTWizzard);
            this.Tipo.Location = new System.Drawing.Point(176, 167);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(327, 56);
            this.Tipo.TabIndex = 3;
            this.Tipo.TabStop = false;
            this.Tipo.Text = "Tipo";
            // 
            // Color
            // 
            this.Color.AutoSize = true;
            this.Color.Location = new System.Drawing.Point(68, 236);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(69, 13);
            this.Color.TabIndex = 12;
            this.Color.Text = "Color favorito";
            // 
            // CBOFavorito
            // 
            this.CBOFavorito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBOFavorito.FormattingEnabled = true;
            this.CBOFavorito.Location = new System.Drawing.Point(156, 233);
            this.CBOFavorito.Name = "CBOFavorito";
            this.CBOFavorito.Size = new System.Drawing.Size(401, 21);
            this.CBOFavorito.TabIndex = 4;
            // 
            // NumeroFavorito
            // 
            this.NumeroFavorito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumeroFavorito.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumeroFavorito.Location = new System.Drawing.Point(156, 277);
            this.NumeroFavorito.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumeroFavorito.Name = "NumeroFavorito";
            this.NumeroFavorito.Size = new System.Drawing.Size(379, 20);
            this.NumeroFavorito.TabIndex = 5;
            this.NumeroFavorito.ThousandsSeparator = true;
            // 
            // LBLNumeroFAvorito
            // 
            this.LBLNumeroFAvorito.AutoSize = true;
            this.LBLNumeroFAvorito.Location = new System.Drawing.Point(62, 279);
            this.LBLNumeroFAvorito.Name = "LBLNumeroFAvorito";
            this.LBLNumeroFAvorito.Size = new System.Drawing.Size(85, 13);
            this.LBLNumeroFAvorito.TabIndex = 13;
            this.LBLNumeroFAvorito.Text = "Numero Favorito";
            // 
            // BTNVerPerfil
            // 
            this.BTNVerPerfil.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.BTNVerPerfil.FlatAppearance.BorderSize = 2;
            this.BTNVerPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BTNVerPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTNVerPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNVerPerfil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTNVerPerfil.Image = global::ejemplo2.Properties.Resources.Product_BRO126_6350effd_aa9d_4a19_a440_8ca2a87216c2;
            this.BTNVerPerfil.Location = new System.Drawing.Point(53, 337);
            this.BTNVerPerfil.Name = "BTNVerPerfil";
            this.BTNVerPerfil.Size = new System.Drawing.Size(113, 41);
            this.BTNVerPerfil.TabIndex = 6;
            this.BTNVerPerfil.Text = "Ver &Perfil";
            this.BTNVerPerfil.UseVisualStyleBackColor = true;
            this.BTNVerPerfil.Click += new System.EventHandler(this.BTNVerPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(771, 675);
            this.Controls.Add(this.BTNVerPerfil);
            this.Controls.Add(this.LBLNumeroFAvorito);
            this.Controls.Add(this.NumeroFavorito);
            this.Controls.Add(this.CBOFavorito);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.CKBChocolate);
            this.Controls.Add(this.FechaNAcimiento);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.elementos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.MaximumSize = new System.Drawing.Size(1234, 800);
            this.MinimumSize = new System.Drawing.Size(528, 600);
            this.Name = "Form1";
            this.Text = "1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Tipo.ResumeLayout(false);
            this.Tipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumeroFavorito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView elementos;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.DateTimePicker FechaNAcimiento;
        private System.Windows.Forms.CheckBox CKBChocolate;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.RadioButton RBTWizzard;
        private System.Windows.Forms.RadioButton RBTMugle;
        private System.Windows.Forms.RadioButton RBT3;
        private System.Windows.Forms.GroupBox Tipo;
        private System.Windows.Forms.Label Color;
        private System.Windows.Forms.ComboBox CBOFavorito;
        private System.Windows.Forms.NumericUpDown NumeroFavorito;
        private System.Windows.Forms.Label LBLNumeroFAvorito;
        private System.Windows.Forms.Button BTNVerPerfil;
    }
}

