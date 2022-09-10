namespace Cardapio
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
            this.btn_Inicial = new System.Windows.Forms.Button();
            this.txt_restaurante2 = new System.Windows.Forms.TextBox();
            this.txt_Restaurante1 = new System.Windows.Forms.TextBox();
            this.btn_opcao1 = new System.Windows.Forms.Button();
            this.btn_Opcao2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Inicial
            // 
            this.btn_Inicial.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_Inicial.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Inicial.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Inicial.Location = new System.Drawing.Point(96, 45);
            this.btn_Inicial.Name = "btn_Inicial";
            this.btn_Inicial.Size = new System.Drawing.Size(599, 85);
            this.btn_Inicial.TabIndex = 0;
            this.btn_Inicial.Text = "Escolha um restaurante";
            this.btn_Inicial.UseVisualStyleBackColor = false;
            this.btn_Inicial.Click += new System.EventHandler(this.btn_Inicial_Click);
            // 
            // txt_restaurante2
            // 
            this.txt_restaurante2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_restaurante2.Location = new System.Drawing.Point(96, 304);
            this.txt_restaurante2.Name = "txt_restaurante2";
            this.txt_restaurante2.Size = new System.Drawing.Size(491, 39);
            this.txt_restaurante2.TabIndex = 1;
            // 
            // txt_Restaurante1
            // 
            this.txt_Restaurante1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Restaurante1.Location = new System.Drawing.Point(96, 200);
            this.txt_Restaurante1.Name = "txt_Restaurante1";
            this.txt_Restaurante1.Size = new System.Drawing.Size(491, 39);
            this.txt_Restaurante1.TabIndex = 2;
            // 
            // btn_opcao1
            // 
            this.btn_opcao1.BackColor = System.Drawing.Color.Crimson;
            this.btn_opcao1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_opcao1.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_opcao1.Location = new System.Drawing.Point(592, 200);
            this.btn_opcao1.Name = "btn_opcao1";
            this.btn_opcao1.Size = new System.Drawing.Size(103, 39);
            this.btn_opcao1.TabIndex = 3;
            this.btn_opcao1.Text = "Opção 1";
            this.btn_opcao1.UseVisualStyleBackColor = false;
            this.btn_opcao1.Click += new System.EventHandler(this.btn_opcao1_Click);
            // 
            // btn_Opcao2
            // 
            this.btn_Opcao2.BackColor = System.Drawing.Color.Crimson;
            this.btn_Opcao2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Opcao2.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Opcao2.Location = new System.Drawing.Point(592, 304);
            this.btn_Opcao2.Name = "btn_Opcao2";
            this.btn_Opcao2.Size = new System.Drawing.Size(103, 38);
            this.btn_Opcao2.TabIndex = 4;
            this.btn_Opcao2.Text = "Opção 2";
            this.btn_Opcao2.UseVisualStyleBackColor = false;
            this.btn_Opcao2.Click += new System.EventHandler(this.btn_Opcao2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 406);
            this.Controls.Add(this.btn_Opcao2);
            this.Controls.Add(this.btn_opcao1);
            this.Controls.Add(this.txt_Restaurante1);
            this.Controls.Add(this.txt_restaurante2);
            this.Controls.Add(this.btn_Inicial);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escolha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Inicial;
        private TextBox txt_restaurante2;
        private TextBox txt_Restaurante1;
        private Button btn_opcao1;
        private Button btn_Opcao2;
    }
}