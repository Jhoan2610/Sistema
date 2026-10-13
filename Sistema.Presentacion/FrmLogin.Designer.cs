namespace Sistema.Presentacion
{
    partial class FrmLogin
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            TxtUsername = new TextBox();
            TxtPassword = new TextBox();
            label3 = new Label();
            btnAcceder = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 371);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(483, 23);
            label1.Name = "label1";
            label1.Size = new Size(233, 40);
            label1.TabIndex = 1;
            label1.Text = "Iniciar Sesion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label2.Location = new Point(354, 94);
            label2.Name = "label2";
            label2.Size = new Size(100, 27);
            label2.TabIndex = 2;
            label2.Text = "Usuario:";
            // 
            // TxtUsername
            // 
            TxtUsername.BorderStyle = BorderStyle.FixedSingle;
            TxtUsername.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            TxtUsername.Location = new Point(354, 124);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(515, 36);
            TxtUsername.TabIndex = 3;
            // 
            // TxtPassword
            // 
            TxtPassword.BorderStyle = BorderStyle.FixedSingle;
            TxtPassword.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            TxtPassword.Location = new Point(354, 223);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '*';
            TxtPassword.Size = new Size(515, 36);
            TxtPassword.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label3.Location = new Point(354, 193);
            label3.Name = "label3";
            label3.Size = new Size(148, 27);
            label3.TabIndex = 4;
            label3.Text = "Contraseña:";
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.SteelBlue;
            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcceder.ForeColor = Color.White;
            btnAcceder.Location = new Point(354, 314);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(515, 38);
            btnAcceder.TabIndex = 6;
            btnAcceder.Text = "ACCEDER";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(882, 6);
            button1.Name = "button1";
            button1.Size = new Size(81, 68);
            button1.TabIndex = 7;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(966, 371);
            Controls.Add(button1);
            Controls.Add(btnAcceder);
            Controls.Add(TxtPassword);
            Controls.Add(label3);
            Controls.Add(TxtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox TxtUsername;
        private TextBox TxtPassword;
        private Label label3;
        private Button btnAcceder;
        private Button button1;
    }
}