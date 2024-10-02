namespace Teste_M_10
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Iniciar = new System.Windows.Forms.Button();
            this.button_Limpar = new System.Windows.Forms.Button();
            this.button_Valor_Pagar = new System.Windows.Forms.Button();
            this.textBox_Categoria = new System.Windows.Forms.TextBox();
            this.textBox_Nome_Jogo = new System.Windows.Forms.TextBox();
            this.textBox_Quantidade = new System.Windows.Forms.TextBox();
            this.textBox_Preço = new System.Windows.Forms.TextBox();
            this.textBox_Valor_Pagar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_xBox = new System.Windows.Forms.RadioButton();
            this.radioButton_Playstation = new System.Windows.Forms.RadioButton();
            this.radioButton_wii = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoria Selecionada ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome Jogo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(314, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(485, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Valor a Pagar";
            // 
            // button_Iniciar
            // 
            this.button_Iniciar.BackColor = System.Drawing.Color.LightGreen;
            this.button_Iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Iniciar.Location = new System.Drawing.Point(62, 362);
            this.button_Iniciar.Name = "button_Iniciar";
            this.button_Iniciar.Size = new System.Drawing.Size(119, 53);
            this.button_Iniciar.TabIndex = 6;
            this.button_Iniciar.Text = "Iniciar";
            this.button_Iniciar.UseVisualStyleBackColor = false;
            this.button_Iniciar.Click += new System.EventHandler(this.button_Iniciar_Click);
            // 
            // button_Limpar
            // 
            this.button_Limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Limpar.Location = new System.Drawing.Point(328, 362);
            this.button_Limpar.Name = "button_Limpar";
            this.button_Limpar.Size = new System.Drawing.Size(117, 53);
            this.button_Limpar.TabIndex = 7;
            this.button_Limpar.Text = "Limpar";
            this.button_Limpar.UseVisualStyleBackColor = false;
            this.button_Limpar.Click += new System.EventHandler(this.button_Limpar_Click);
            // 
            // button_Valor_Pagar
            // 
            this.button_Valor_Pagar.BackColor = System.Drawing.Color.Olive;
            this.button_Valor_Pagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Valor_Pagar.Location = new System.Drawing.Point(587, 362);
            this.button_Valor_Pagar.Name = "button_Valor_Pagar";
            this.button_Valor_Pagar.Size = new System.Drawing.Size(116, 53);
            this.button_Valor_Pagar.TabIndex = 8;
            this.button_Valor_Pagar.Text = "Valor a pagar";
            this.button_Valor_Pagar.UseVisualStyleBackColor = false;
            this.button_Valor_Pagar.Click += new System.EventHandler(this.button_Valor_Pagar_Click);
            // 
            // textBox_Categoria
            // 
            this.textBox_Categoria.Location = new System.Drawing.Point(187, 115);
            this.textBox_Categoria.Name = "textBox_Categoria";
            this.textBox_Categoria.Size = new System.Drawing.Size(601, 20);
            this.textBox_Categoria.TabIndex = 9;
          
            // 
            // textBox_Nome_Jogo
            // 
            this.textBox_Nome_Jogo.Location = new System.Drawing.Point(140, 195);
            this.textBox_Nome_Jogo.Name = "textBox_Nome_Jogo";
            this.textBox_Nome_Jogo.Size = new System.Drawing.Size(648, 20);
            this.textBox_Nome_Jogo.TabIndex = 10;
            // 
            // textBox_Quantidade
            // 
            this.textBox_Quantidade.Location = new System.Drawing.Point(408, 255);
            this.textBox_Quantidade.Name = "textBox_Quantidade";
            this.textBox_Quantidade.Size = new System.Drawing.Size(153, 20);
            this.textBox_Quantidade.TabIndex = 11;
            // 
            // textBox_Preço
            // 
            this.textBox_Preço.Location = new System.Drawing.Point(140, 255);
            this.textBox_Preço.Name = "textBox_Preço";
            this.textBox_Preço.Size = new System.Drawing.Size(147, 20);
            this.textBox_Preço.TabIndex = 12;
            // 
            // textBox_Valor_Pagar
            // 
            this.textBox_Valor_Pagar.Location = new System.Drawing.Point(603, 310);
            this.textBox_Valor_Pagar.Name = "textBox_Valor_Pagar";
            this.textBox_Valor_Pagar.Size = new System.Drawing.Size(100, 20);
            this.textBox_Valor_Pagar.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_xBox);
            this.groupBox1.Controls.Add(this.radioButton_Playstation);
            this.groupBox1.Controls.Add(this.radioButton_wii);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(62, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 96);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categoria";
            // 
            // radioButton_xBox
            // 
            this.radioButton_xBox.AutoSize = true;
            this.radioButton_xBox.Location = new System.Drawing.Point(32, 38);
            this.radioButton_xBox.Name = "radioButton_xBox";
            this.radioButton_xBox.Size = new System.Drawing.Size(54, 20);
            this.radioButton_xBox.TabIndex = 15;
            this.radioButton_xBox.TabStop = true;
            this.radioButton_xBox.Text = "xBox";
            this.radioButton_xBox.UseVisualStyleBackColor = true;
        
            // 
            // radioButton_Playstation
            // 
            this.radioButton_Playstation.AutoSize = true;
            this.radioButton_Playstation.Location = new System.Drawing.Point(266, 39);
            this.radioButton_Playstation.Name = "radioButton_Playstation";
            this.radioButton_Playstation.Size = new System.Drawing.Size(91, 20);
            this.radioButton_Playstation.TabIndex = 16;
            this.radioButton_Playstation.TabStop = true;
            this.radioButton_Playstation.Text = "Playstation";
            this.radioButton_Playstation.UseVisualStyleBackColor = true;
            
            // 
            // radioButton_wii
            // 
            this.radioButton_wii.AutoSize = true;
            this.radioButton_wii.Location = new System.Drawing.Point(525, 36);
            this.radioButton_wii.Name = "radioButton_wii";
            this.radioButton_wii.Size = new System.Drawing.Size(40, 20);
            this.radioButton_wii.TabIndex = 17;
            this.radioButton_wii.TabStop = true;
            this.radioButton_wii.Text = "wii";
            this.radioButton_wii.UseVisualStyleBackColor = true;
      
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(603, 254);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 20);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Desconto 10%";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_Valor_Pagar);
            this.Controls.Add(this.textBox_Preço);
            this.Controls.Add(this.textBox_Quantidade);
            this.Controls.Add(this.textBox_Nome_Jogo);
            this.Controls.Add(this.textBox_Categoria);
            this.Controls.Add(this.button_Valor_Pagar);
            this.Controls.Add(this.button_Limpar);
            this.Controls.Add(this.button_Iniciar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_Iniciar;
        private System.Windows.Forms.Button button_Limpar;
        private System.Windows.Forms.Button button_Valor_Pagar;
        private System.Windows.Forms.TextBox textBox_Categoria;
        private System.Windows.Forms.TextBox textBox_Nome_Jogo;
        private System.Windows.Forms.TextBox textBox_Quantidade;
        private System.Windows.Forms.TextBox textBox_Preço;
        private System.Windows.Forms.TextBox textBox_Valor_Pagar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_xBox;
        private System.Windows.Forms.RadioButton radioButton_Playstation;
        private System.Windows.Forms.RadioButton radioButton_wii;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

