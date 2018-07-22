namespace CaixaEletronico
{
    partial class CadastroDeContas
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
            this.titularConta = new System.Windows.Forms.TextBox();
            this.numeroConta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titularConta
            // 
            this.titularConta.Location = new System.Drawing.Point(255, 150);
            this.titularConta.Name = "titularConta";
            this.titularConta.Size = new System.Drawing.Size(295, 20);
            this.titularConta.TabIndex = 0;
            // 
            // numeroConta
            // 
            this.numeroConta.Location = new System.Drawing.Point(255, 220);
            this.numeroConta.Name = "numeroConta";
            this.numeroConta.Size = new System.Drawing.Size(295, 20);
            this.numeroConta.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Criar nova conta!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = ">> CADASTRO DE NOVAS CONTAS <<";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "N° da conta:";
            // 
            // CadastroDeContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numeroConta);
            this.Controls.Add(this.titularConta);
            this.Name = "CadastroDeContas";
            this.Text = "CadastroDeContas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titularConta;
        private System.Windows.Forms.TextBox numeroConta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}