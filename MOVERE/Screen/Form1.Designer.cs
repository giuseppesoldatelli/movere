
namespace MOVERE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_sair = new System.Windows.Forms.Button();
            this.button_login = new System.Windows.Forms.Button();
            this.label_login = new System.Windows.Forms.Label();
            this.label_senha = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_senha = new System.Windows.Forms.TextBox();
            this.button_cadastro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button_sair
            // 
            this.button_sair.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_sair.Location = new System.Drawing.Point(304, 130);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(91, 39);
            this.button_sair.TabIndex = 1;
            this.button_sair.Text = "Sair";
            this.button_sair.UseVisualStyleBackColor = false;
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.SystemColors.Control;
            this.button_login.Location = new System.Drawing.Point(418, 130);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(91, 39);
            this.button_login.TabIndex = 2;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(269, 50);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(39, 15);
            this.label_login.TabIndex = 3;
            this.label_login.Text = "Email:";
            this.label_login.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_senha
            // 
            this.label_senha.AutoSize = true;
            this.label_senha.Location = new System.Drawing.Point(269, 87);
            this.label_senha.Name = "label_senha";
            this.label_senha.Size = new System.Drawing.Size(42, 15);
            this.label_senha.TabIndex = 4;
            this.label_senha.Text = "Senha:";
            this.label_senha.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(320, 47);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(176, 23);
            this.textBox_login.TabIndex = 5;
            // 
            // textBox_senha
            // 
            this.textBox_senha.Location = new System.Drawing.Point(320, 84);
            this.textBox_senha.Name = "textBox_senha";
            this.textBox_senha.PasswordChar = '*';
            this.textBox_senha.Size = new System.Drawing.Size(176, 23);
            this.textBox_senha.TabIndex = 6;
            // 
            // button_cadastro
            // 
            this.button_cadastro.BackColor = System.Drawing.SystemColors.Control;
            this.button_cadastro.Location = new System.Drawing.Point(347, 175);
            this.button_cadastro.Name = "button_cadastro";
            this.button_cadastro.Size = new System.Drawing.Size(119, 48);
            this.button_cadastro.TabIndex = 7;
            this.button_cadastro.Text = "Cadastro";
            this.button_cadastro.UseVisualStyleBackColor = false;
            this.button_cadastro.Click += new System.EventHandler(this.button_cadastro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(561, 235);
            this.Controls.Add(this.button_cadastro);
            this.Controls.Add(this.textBox_senha);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label_senha);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.button_sair);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Controle Financeiro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_senha;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_senha;
        private System.Windows.Forms.Button button_cadastro;
    }
}

