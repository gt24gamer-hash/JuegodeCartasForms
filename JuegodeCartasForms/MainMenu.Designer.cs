namespace JuegodeCartasForms
{
    partial class MainMenu
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
            btnJugar = new Button();
            btnMazo = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnJugar
            // 
            btnJugar.Location = new Point(353, 223);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(173, 55);
            btnJugar.TabIndex = 0;
            btnJugar.Text = "Jugar";
            btnJugar.UseVisualStyleBackColor = true;
            btnJugar.Click += btnJugar_Click;
            // 
            // btnMazo
            // 
            btnMazo.Location = new Point(353, 316);
            btnMazo.Name = "btnMazo";
            btnMazo.Size = new Size(173, 55);
            btnMazo.TabIndex = 1;
            btnMazo.Text = "Seleccionar Mazo";
            btnMazo.UseVisualStyleBackColor = true;
            btnMazo.Click += btnMazo_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(353, 414);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(173, 55);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 587);
            Controls.Add(btnSalir);
            Controls.Add(btnMazo);
            Controls.Add(btnJugar);
            Name = "MainMenu";
            Text = "ArenaElemental";
            ResumeLayout(false);
        }

        #endregion

        private Button btnJugar;
        private Button btnMazo;
        private Button btnSalir;
    }
}