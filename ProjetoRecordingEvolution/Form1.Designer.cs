
namespace ProjetoRecordingEvolution
{
    partial class TelaRecordingEvolution
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.caixaDeTexto = new System.Windows.Forms.TextBox();
            this.caixaDeLista = new System.Windows.Forms.ListBox();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSalvar.Location = new System.Drawing.Point(275, 144);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 1;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonExcluir.Location = new System.Drawing.Point(27, 144);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 2;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = false;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // caixaDeTexto
            // 
            this.caixaDeTexto.Location = new System.Drawing.Point(27, 118);
            this.caixaDeTexto.Name = "caixaDeTexto";
            this.caixaDeTexto.Size = new System.Drawing.Size(323, 20);
            this.caixaDeTexto.TabIndex = 3;
            // 
            // caixaDeLista
            // 
            this.caixaDeLista.FormattingEnabled = true;
            this.caixaDeLista.Location = new System.Drawing.Point(27, 12);
            this.caixaDeLista.Name = "caixaDeLista";
            this.caixaDeLista.Size = new System.Drawing.Size(323, 95);
            this.caixaDeLista.TabIndex = 4;
            this.caixaDeLista.SelectedIndexChanged += new System.EventHandler(this.caixaDeLista_SelectedIndexChanged);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(153, 144);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisar.TabIndex = 5;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // TelaRecordingEvolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 176);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.caixaDeLista);
            this.Controls.Add(this.caixaDeTexto);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonSalvar);
            this.Name = "TelaRecordingEvolution";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recording Evolution";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaRecordingEvolution_FormClosing);
            this.Load += new System.EventHandler(this.Tela_Load);
            this.Click += new System.EventHandler(this.TelaRecordingEvolution_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.TextBox caixaDeTexto;
        private System.Windows.Forms.ListBox caixaDeLista;
        private System.Windows.Forms.Button buttonPesquisar;
    }
}

