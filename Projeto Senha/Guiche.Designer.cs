namespace Projeto_Senha
{
    partial class frmGuiche
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGravarGuiche = new System.Windows.Forms.Button();
            this.clbServicos = new System.Windows.Forms.CheckedListBox();
            this.btnExibirCadastrados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "GUICHÊ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // txbCodigo
            // 
            this.txbCodigo.Location = new System.Drawing.Point(73, 48);
            this.txbCodigo.MaxLength = 4;
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(199, 20);
            this.txbCodigo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Serviços:";
            // 
            // btnGravarGuiche
            // 
            this.btnGravarGuiche.Location = new System.Drawing.Point(158, 189);
            this.btnGravarGuiche.Name = "btnGravarGuiche";
            this.btnGravarGuiche.Size = new System.Drawing.Size(100, 23);
            this.btnGravarGuiche.TabIndex = 5;
            this.btnGravarGuiche.Text = "Gravar";
            this.btnGravarGuiche.UseVisualStyleBackColor = true;
            this.btnGravarGuiche.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // clbServicos
            // 
            this.clbServicos.FormattingEnabled = true;
            this.clbServicos.Location = new System.Drawing.Point(73, 74);
            this.clbServicos.Name = "clbServicos";
            this.clbServicos.Size = new System.Drawing.Size(199, 109);
            this.clbServicos.TabIndex = 6;
            // 
            // btnExibirCadastrados
            // 
            this.btnExibirCadastrados.Location = new System.Drawing.Point(27, 189);
            this.btnExibirCadastrados.Name = "btnExibirCadastrados";
            this.btnExibirCadastrados.Size = new System.Drawing.Size(100, 23);
            this.btnExibirCadastrados.TabIndex = 7;
            this.btnExibirCadastrados.Text = "Listar";
            this.btnExibirCadastrados.UseVisualStyleBackColor = true;
            this.btnExibirCadastrados.Click += new System.EventHandler(this.btnExibirCadastrados_Click);
            // 
            // frmGuiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 228);
            this.Controls.Add(this.btnExibirCadastrados);
            this.Controls.Add(this.clbServicos);
            this.Controls.Add(this.btnGravarGuiche);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmGuiche";
            this.Text = "Guichê";
            this.Load += new System.EventHandler(this.frmGuiche_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGravarGuiche;
        private System.Windows.Forms.CheckedListBox clbServicos;
        private System.Windows.Forms.Button btnExibirCadastrados;
    }
}

