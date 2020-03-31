namespace PcnTela
{
    partial class Form1
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorMinimo = new System.Windows.Forms.TextBox();
            this.txtValorMaximo = new System.Windows.Forms.TextBox();
            this.txtQuantidadeVagas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ckZapImoveis = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTipoResidencia = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQuantidadeQuartos = new System.Windows.Forms.TextBox();
            this.txtErro = new System.Windows.Forms.Label();
            this.txtErroLog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(12, 233);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(776, 48);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fonte de Pesquisa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Faixa de Preço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantidade de Vagas";
            // 
            // txtValorMinimo
            // 
            this.txtValorMinimo.Location = new System.Drawing.Point(53, 118);
            this.txtValorMinimo.Name = "txtValorMinimo";
            this.txtValorMinimo.Size = new System.Drawing.Size(100, 22);
            this.txtValorMinimo.TabIndex = 4;
            this.txtValorMinimo.Text = "0";
            this.txtValorMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValorMaximo
            // 
            this.txtValorMaximo.Location = new System.Drawing.Point(212, 118);
            this.txtValorMaximo.Name = "txtValorMaximo";
            this.txtValorMaximo.Size = new System.Drawing.Size(100, 22);
            this.txtValorMaximo.TabIndex = 5;
            this.txtValorMaximo.Text = "0";
            this.txtValorMaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQuantidadeVagas
            // 
            this.txtQuantidadeVagas.Location = new System.Drawing.Point(16, 196);
            this.txtQuantidadeVagas.Name = "txtQuantidadeVagas";
            this.txtQuantidadeVagas.Size = new System.Drawing.Size(41, 22);
            this.txtQuantidadeVagas.TabIndex = 6;
            this.txtQuantidadeVagas.Text = "1";
            this.txtQuantidadeVagas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Min.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Max.";
            // 
            // ckZapImoveis
            // 
            this.ckZapImoveis.AutoSize = true;
            this.ckZapImoveis.Location = new System.Drawing.Point(16, 43);
            this.ckZapImoveis.Name = "ckZapImoveis";
            this.ckZapImoveis.Size = new System.Drawing.Size(106, 21);
            this.ckZapImoveis.TabIndex = 9;
            this.ckZapImoveis.Text = "Zap Imóveis";
            this.ckZapImoveis.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(424, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cidade";
            // 
            // cbCidade
            // 
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Location = new System.Drawing.Point(430, 43);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(234, 24);
            this.cbCidade.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(427, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tipo de Residência";
            // 
            // cbTipoResidencia
            // 
            this.cbTipoResidencia.FormattingEnabled = true;
            this.cbTipoResidencia.Location = new System.Drawing.Point(430, 114);
            this.cbTipoResidencia.Name = "cbTipoResidencia";
            this.cbTipoResidencia.Size = new System.Drawing.Size(234, 24);
            this.cbTipoResidencia.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(427, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Quantidade de Quartos";
            // 
            // txtQuantidadeQuartos
            // 
            this.txtQuantidadeQuartos.Location = new System.Drawing.Point(430, 195);
            this.txtQuantidadeQuartos.Name = "txtQuantidadeQuartos";
            this.txtQuantidadeQuartos.Size = new System.Drawing.Size(41, 22);
            this.txtQuantidadeQuartos.TabIndex = 19;
            this.txtQuantidadeQuartos.Text = "2";
            this.txtQuantidadeQuartos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtErro
            // 
            this.txtErro.AutoSize = true;
            this.txtErro.Location = new System.Drawing.Point(16, 301);
            this.txtErro.Name = "txtErro";
            this.txtErro.Size = new System.Drawing.Size(0, 17);
            this.txtErro.TabIndex = 21;
            // 
            // txtErroLog
            // 
            this.txtErroLog.AutoSize = true;
            this.txtErroLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtErroLog.Location = new System.Drawing.Point(16, 318);
            this.txtErroLog.Name = "txtErroLog";
            this.txtErroLog.Size = new System.Drawing.Size(27, 17);
            this.txtErroLog.TabIndex = 22;
            this.txtErroLog.Text = "log";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 456);
            this.Controls.Add(this.txtErroLog);
            this.Controls.Add(this.txtErro);
            this.Controls.Add(this.txtQuantidadeQuartos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbTipoResidencia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbCidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ckZapImoveis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuantidadeVagas);
            this.Controls.Add(this.txtValorMaximo);
            this.Controls.Add(this.txtValorMinimo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsultar);
            this.Name = "Form1";
            this.Text = "Projeto Casa Nova";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorMinimo;
        private System.Windows.Forms.TextBox txtValorMaximo;
        private System.Windows.Forms.TextBox txtQuantidadeVagas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckZapImoveis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTipoResidencia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQuantidadeQuartos;
        private System.Windows.Forms.Label txtErro;
        private System.Windows.Forms.Label txtErroLog;
    }
}

