
namespace MOVERE.Screen
{
    partial class Adicionar
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
            this.button_addSaldo = new System.Windows.Forms.Button();
            this.textBox_valor = new System.Windows.Forms.TextBox();
            this.label_valor = new System.Windows.Forms.Label();
            this.label_contaID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_addSaldo
            // 
            this.button_addSaldo.Location = new System.Drawing.Point(305, 102);
            this.button_addSaldo.Name = "button_addSaldo";
            this.button_addSaldo.Size = new System.Drawing.Size(91, 36);
            this.button_addSaldo.TabIndex = 3;
            this.button_addSaldo.Text = "Adicionar";
            this.button_addSaldo.UseVisualStyleBackColor = true;
            this.button_addSaldo.Click += new System.EventHandler(this.button_addSaldo_Click);
            // 
            // textBox_valor
            // 
            this.textBox_valor.Location = new System.Drawing.Point(30, 63);
            this.textBox_valor.Multiline = true;
            this.textBox_valor.Name = "textBox_valor";
            this.textBox_valor.Size = new System.Drawing.Size(113, 23);
            this.textBox_valor.TabIndex = 5;
            // 
            // label_valor
            // 
            this.label_valor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_valor.AutoSize = true;
            this.label_valor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_valor.Location = new System.Drawing.Point(39, 20);
            this.label_valor.Name = "label_valor";
            this.label_valor.Size = new System.Drawing.Size(73, 32);
            this.label_valor.TabIndex = 4;
            this.label_valor.Text = "Valor";
            this.label_valor.Click += new System.EventHandler(this.label_saldo_Click);
            // 
            // label_contaID
            // 
            this.label_contaID.AutoSize = true;
            this.label_contaID.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_contaID.Location = new System.Drawing.Point(183, 20);
            this.label_contaID.Name = "label_contaID";
            this.label_contaID.Size = new System.Drawing.Size(124, 32);
            this.label_contaID.TabIndex = 7;
            this.label_contaID.Text = "Categoria";
            this.label_contaID.Click += new System.EventHandler(this.label_contaID_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Adicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 153);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_contaID);
            this.Controls.Add(this.textBox_valor);
            this.Controls.Add(this.label_valor);
            this.Controls.Add(this.button_addSaldo);
            this.Name = "Adicionar";
            this.Text = "Adicionar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_addSaldo;
        private System.Windows.Forms.TextBox textBox_valor;
        private System.Windows.Forms.Label label_valor;
        private System.Windows.Forms.Label label_contaID;
        private System.Windows.Forms.TextBox textBox1;
    }
}