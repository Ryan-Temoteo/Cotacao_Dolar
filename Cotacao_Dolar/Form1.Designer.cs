namespace Cotacao_Dolar
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
            label1 = new Label();
            label2 = new Label();
            btnPesquisar = new Button();
            label3 = new Label();
            label4 = new Label();
            lblCompra = new Label();
            lblVenda = new Label();
            lblVariacao = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.RoyalBlue;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(508, 50);
            label1.TabIndex = 0;
            label1.Text = "Dólar";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(76, 118);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 1;
            label2.Text = "Compra:";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(383, 386);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(129, 40);
            btnPesquisar.TabIndex = 2;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(76, 205);
            label3.Name = "label3";
            label3.Size = new Size(106, 28);
            label3.TabIndex = 4;
            label3.Text = "Venda:";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(76, 303);
            label4.Name = "label4";
            label4.Size = new Size(106, 28);
            label4.TabIndex = 5;
            label4.Text = "Variação:";
            // 
            // lblCompra
            // 
            lblCompra.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            lblCompra.Location = new Point(198, 118);
            lblCompra.Name = "lblCompra";
            lblCompra.Size = new Size(209, 51);
            lblCompra.TabIndex = 6;
            lblCompra.Text = "0,0";
            lblCompra.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVenda
            // 
            lblVenda.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            lblVenda.Location = new Point(198, 205);
            lblVenda.Name = "lblVenda";
            lblVenda.Size = new Size(209, 47);
            lblVenda.TabIndex = 7;
            lblVenda.Text = "0,0";
            lblVenda.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVariacao
            // 
            lblVariacao.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            lblVariacao.Location = new Point(198, 303);
            lblVariacao.Name = "lblVariacao";
            lblVariacao.Size = new Size(209, 45);
            lblVariacao.TabIndex = 8;
            lblVariacao.Text = "0,0";
            lblVariacao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 441);
            Controls.Add(lblVariacao);
            Controls.Add(lblVenda);
            Controls.Add(lblCompra);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnPesquisar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnPesquisar;
        private Label label3;
        private Label label4;
        private Label lblCompra;
        private Label lblVenda;
        private Label lblVariacao;
    }
}