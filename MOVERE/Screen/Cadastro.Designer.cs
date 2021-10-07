
namespace MOVERE.Screen
{
    partial class Cadastro
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
            this.label_email = new System.Windows.Forms.Label();
            this.label_nome = new System.Windows.Forms.Label();
            this.label_senha = new System.Windows.Forms.Label();
            this.button_cadastro = new System.Windows.Forms.Button();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_senha = new System.Windows.Forms.TextBox();
            this.label_confSenha = new System.Windows.Forms.Label();
            this.textBox_confSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(63, 86);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(39, 15);
            this.label_email.TabIndex = 0;
            this.label_email.Text = "Email:";
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Location = new System.Drawing.Point(59, 36);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(43, 15);
            this.label_nome.TabIndex = 1;
            this.label_nome.Text = "Nome:";
            this.label_nome.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_senha
            // 
            this.label_senha.AutoSize = true;
            this.label_senha.Location = new System.Drawing.Point(63, 141);
            this.label_senha.Name = "label_senha";
            this.label_senha.Size = new System.Drawing.Size(42, 15);
            this.label_senha.TabIndex = 2;
            this.label_senha.Text = "Senha:";
            // 
            // button_cadastro
            // 
            this.button_cadastro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_cadastro.Location = new System.Drawing.Point(187, 231);
            this.button_cadastro.Name = "button_cadastro";
            this.button_cadastro.Size = new System.Drawing.Size(87, 42);
            this.button_cadastro.TabIndex = 3;
            this.button_cadastro.Text = "Cadastre-se";
            this.button_cadastro.UseVisualStyleBackColor = true;
            this.button_cadastro.Click += new System.EventHandler(this.button_cadastro_Click);
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(127, 33);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(271, 23);
            this.textBox_nome.TabIndex = 5;
            this.textBox_nome.TextChanged += new System.EventHandler(this.textBox_nome_TextChanged);
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(127, 83);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(271, 23);
            this.textBox_email.TabIndex = 6;
            // 
            // textBox_senha
            // 
            this.textBox_senha.Location = new System.Drawing.Point(127, 138);
            this.textBox_senha.Name = "textBox_senha";
            this.textBox_senha.PasswordChar = '*';
            this.textBox_senha.Size = new System.Drawing.Size(271, 23);
            this.textBox_senha.TabIndex = 7;
            // 
            // label_confSenha
            // 
            this.label_confSenha.AutoSize = true;
            this.label_confSenha.Location = new System.Drawing.Point(12, 194);
            this.label_confSenha.Name = "label_confSenha";
            this.label_confSenha.Size = new System.Drawing.Size(98, 15);
            this.label_confSenha.TabIndex = 8;
            this.label_confSenha.Text = "Confirmar senha:";
            this.label_confSenha.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_confSenha
            // 
            this.textBox_confSenha.Location = new System.Drawing.Point(127, 191);
            this.textBox_confSenha.Name = "textBox_confSenha";
            this.textBox_confSenha.PasswordChar = '*';
            this.textBox_confSenha.Size = new System.Drawing.Size(271, 23);
            this.textBox_confSenha.TabIndex = 9;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 298);
            this.Controls.Add(this.textBox_confSenha);
            this.Controls.Add(this.label_confSenha);
            this.Controls.Add(this.textBox_senha);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.button_cadastro);
            this.Controls.Add(this.label_senha);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.label_email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.Label label_senha;
        private System.Windows.Forms.Button button_cadastro;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_senha;
        private System.Windows.Forms.Label label_confSenha;
        private System.Windows.Forms.TextBox textBox_confSenha;
    }
}