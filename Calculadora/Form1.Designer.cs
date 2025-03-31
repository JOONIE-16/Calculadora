namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnseven = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btneight = new System.Windows.Forms.Button();
            this.btnnine = new System.Windows.Forms.Button();
            this.btnsix = new System.Windows.Forms.Button();
            this.btnfive = new System.Windows.Forms.Button();
            this.btnfour = new System.Windows.Forms.Button();
            this.btnthree = new System.Windows.Forms.Button();
            this.btntwo = new System.Windows.Forms.Button();
            this.btnone = new System.Windows.Forms.Button();
            this.btncero = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnseven
            // 
            this.btnseven.Location = new System.Drawing.Point(12, 86);
            this.btnseven.Name = "btnseven";
            this.btnseven.Size = new System.Drawing.Size(75, 39);
            this.btnseven.TabIndex = 0;
            this.btnseven.Text = "7";
            this.btnseven.UseVisualStyleBackColor = true;
            this.btnseven.Click += new System.EventHandler(this.btnseven_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(12, 44);
            this.txtResultado.MaximumSize = new System.Drawing.Size(500, 500);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(318, 20);
            this.txtResultado.TabIndex = 1;
            // 
            // btneight
            // 
            this.btneight.Location = new System.Drawing.Point(93, 86);
            this.btneight.Name = "btneight";
            this.btneight.Size = new System.Drawing.Size(75, 39);
            this.btneight.TabIndex = 2;
            this.btneight.Text = "8";
            this.btneight.UseVisualStyleBackColor = true;
            this.btneight.Click += new System.EventHandler(this.btneight_Click);
            // 
            // btnnine
            // 
            this.btnnine.Location = new System.Drawing.Point(174, 86);
            this.btnnine.Name = "btnnine";
            this.btnnine.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnnine.Size = new System.Drawing.Size(75, 39);
            this.btnnine.TabIndex = 3;
            this.btnnine.Text = "9";
            this.btnnine.UseVisualStyleBackColor = true;
            this.btnnine.Click += new System.EventHandler(this.btnnine_Click);
            // 
            // btnsix
            // 
            this.btnsix.Location = new System.Drawing.Point(174, 131);
            this.btnsix.Name = "btnsix";
            this.btnsix.Size = new System.Drawing.Size(75, 39);
            this.btnsix.TabIndex = 6;
            this.btnsix.Text = "6";
            this.btnsix.UseVisualStyleBackColor = true;
            this.btnsix.Click += new System.EventHandler(this.btnsix_Click);
            // 
            // btnfive
            // 
            this.btnfive.Location = new System.Drawing.Point(93, 131);
            this.btnfive.Name = "btnfive";
            this.btnfive.Size = new System.Drawing.Size(75, 39);
            this.btnfive.TabIndex = 5;
            this.btnfive.Text = "5";
            this.btnfive.UseVisualStyleBackColor = true;
            this.btnfive.Click += new System.EventHandler(this.btnfive_Click);
            // 
            // btnfour
            // 
            this.btnfour.Location = new System.Drawing.Point(12, 131);
            this.btnfour.Name = "btnfour";
            this.btnfour.Size = new System.Drawing.Size(75, 39);
            this.btnfour.TabIndex = 4;
            this.btnfour.Text = "4";
            this.btnfour.UseVisualStyleBackColor = true;
            this.btnfour.Click += new System.EventHandler(this.btnfour_Click);
            // 
            // btnthree
            // 
            this.btnthree.Location = new System.Drawing.Point(174, 176);
            this.btnthree.Name = "btnthree";
            this.btnthree.Size = new System.Drawing.Size(75, 39);
            this.btnthree.TabIndex = 9;
            this.btnthree.Text = "3";
            this.btnthree.UseVisualStyleBackColor = true;
            this.btnthree.Click += new System.EventHandler(this.btnthree_Click);
            // 
            // btntwo
            // 
            this.btntwo.Location = new System.Drawing.Point(93, 176);
            this.btntwo.Name = "btntwo";
            this.btntwo.Size = new System.Drawing.Size(75, 39);
            this.btntwo.TabIndex = 8;
            this.btntwo.Text = "2";
            this.btntwo.UseVisualStyleBackColor = true;
            this.btntwo.Click += new System.EventHandler(this.btntwo_Click);
            // 
            // btnone
            // 
            this.btnone.Location = new System.Drawing.Point(12, 176);
            this.btnone.Name = "btnone";
            this.btnone.Size = new System.Drawing.Size(75, 39);
            this.btnone.TabIndex = 7;
            this.btnone.Text = "1";
            this.btnone.UseVisualStyleBackColor = true;
            this.btnone.Click += new System.EventHandler(this.btnone_Click);
            // 
            // btncero
            // 
            this.btncero.Location = new System.Drawing.Point(93, 221);
            this.btncero.Name = "btncero";
            this.btncero.Size = new System.Drawing.Size(75, 39);
            this.btncero.TabIndex = 10;
            this.btncero.Text = "0";
            this.btncero.UseVisualStyleBackColor = true;
            this.btncero.Click += new System.EventHandler(this.btncero_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(12, 221);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 39);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "CL";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click_1);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(174, 221);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(75, 39);
            this.btnIgual.TabIndex = 12;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click_1);
            // 
            // btnResta
            // 
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(255, 221);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(75, 39);
            this.btnResta.TabIndex = 16;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(255, 176);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 39);
            this.btnSuma.TabIndex = 15;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.Location = new System.Drawing.Point(255, 131);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(75, 39);
            this.btnMultiplicar.TabIndex = 14;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.Location = new System.Drawing.Point(255, 86);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 39);
            this.btnDividir.TabIndex = 13;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 290);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btncero);
            this.Controls.Add(this.btnthree);
            this.Controls.Add(this.btntwo);
            this.Controls.Add(this.btnone);
            this.Controls.Add(this.btnsix);
            this.Controls.Add(this.btnfive);
            this.Controls.Add(this.btnfour);
            this.Controls.Add(this.btnnine);
            this.Controls.Add(this.btneight);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnseven);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnseven;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btneight;
        private System.Windows.Forms.Button btnnine;
        private System.Windows.Forms.Button btnsix;
        private System.Windows.Forms.Button btnfive;
        private System.Windows.Forms.Button btnfour;
        private System.Windows.Forms.Button btnthree;
        private System.Windows.Forms.Button btntwo;
        private System.Windows.Forms.Button btnone;
        private System.Windows.Forms.Button btncero;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
    }
}

