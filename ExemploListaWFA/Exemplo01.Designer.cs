namespace ExemploListaWFA
{
    partial class Exemplo01
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
            this.btCadastrar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btProcessar = new System.Windows.Forms.Button();
            this.rtNumeros = new System.Windows.Forms.RichTextBox();
            this.txtPosicaoParaApagar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorParaApagar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSelecioneParaEditar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumeroEditar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número";
            // 
            // btCadastrar
            // 
            this.btCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(445, 23);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(211, 31);
            this.btCadastrar.TabIndex = 2;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(110, 25);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(329, 29);
            this.txtNumero.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Números";
            // 
            // btProcessar
            // 
            this.btProcessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcessar.Location = new System.Drawing.Point(447, 433);
            this.btProcessar.Name = "btProcessar";
            this.btProcessar.Size = new System.Drawing.Size(218, 56);
            this.btProcessar.TabIndex = 4;
            this.btProcessar.Text = "Processar";
            this.btProcessar.UseVisualStyleBackColor = true;
            this.btProcessar.Click += new System.EventHandler(this.btProcessar_Click);
            // 
            // rtNumeros
            // 
            this.rtNumeros.Location = new System.Drawing.Point(31, 130);
            this.rtNumeros.Name = "rtNumeros";
            this.rtNumeros.Size = new System.Drawing.Size(634, 297);
            this.rtNumeros.TabIndex = 3;
            this.rtNumeros.Text = "";
            // 
            // txtPosicaoParaApagar
            // 
            this.txtPosicaoParaApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosicaoParaApagar.Location = new System.Drawing.Point(680, 57);
            this.txtPosicaoParaApagar.Name = "txtPosicaoParaApagar";
            this.txtPosicaoParaApagar.Size = new System.Drawing.Size(192, 26);
            this.txtPosicaoParaApagar.TabIndex = 6;
            this.txtPosicaoParaApagar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPosicaoParaApagar_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(680, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Posição para apagar";
            // 
            // txtValorParaApagar
            // 
            this.txtValorParaApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorParaApagar.Location = new System.Drawing.Point(680, 130);
            this.txtValorParaApagar.Name = "txtValorParaApagar";
            this.txtValorParaApagar.Size = new System.Drawing.Size(192, 26);
            this.txtValorParaApagar.TabIndex = 8;
            this.txtValorParaApagar.Leave += new System.EventHandler(this.txtValorParaApagar_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(680, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor para apagar";
            // 
            // cbSelecioneParaEditar
            // 
            this.cbSelecioneParaEditar.FormattingEnabled = true;
            this.cbSelecioneParaEditar.Location = new System.Drawing.Point(680, 216);
            this.cbSelecioneParaEditar.Name = "cbSelecioneParaEditar";
            this.cbSelecioneParaEditar.Size = new System.Drawing.Size(192, 21);
            this.cbSelecioneParaEditar.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(680, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Selecione para editar";
            // 
            // txtNumeroEditar
            // 
            this.txtNumeroEditar.Enabled = false;
            this.txtNumeroEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroEditar.Location = new System.Drawing.Point(680, 278);
            this.txtNumeroEditar.Name = "txtNumeroEditar";
            this.txtNumeroEditar.Size = new System.Drawing.Size(192, 29);
            this.txtNumeroEditar.TabIndex = 11;
            this.txtNumeroEditar.TextChanged += new System.EventHandler(this.cbSelecioneParaEditar_TextChanged);
            this.txtNumeroEditar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumeroEditar_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(680, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Número";
            // 
            // Exemplo01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 519);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNumeroEditar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbSelecioneParaEditar);
            this.Controls.Add(this.txtValorParaApagar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPosicaoParaApagar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtNumeros);
            this.Controls.Add(this.btProcessar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.label1);
            this.Name = "Exemplo01";
            this.Text = "Exemplo01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btProcessar;
        private System.Windows.Forms.RichTextBox rtNumeros;
        private System.Windows.Forms.TextBox txtPosicaoParaApagar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorParaApagar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSelecioneParaEditar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumeroEditar;
        private System.Windows.Forms.Label label6;
    }
}