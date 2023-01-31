namespace Distancia_Puntos2
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
            this.Txt_Resultado = new System.Windows.Forms.TextBox();
            this.Btn_Calcular = new System.Windows.Forms.Button();
            this.Txt_YB = new System.Windows.Forms.TextBox();
            this.Txt_XB = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Txt_YA = new System.Windows.Forms.TextBox();
            this.Txt_XA = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_Resultado
            // 
            this.Txt_Resultado.Location = new System.Drawing.Point(208, 165);
            this.Txt_Resultado.Name = "Txt_Resultado";
            this.Txt_Resultado.Size = new System.Drawing.Size(100, 20);
            this.Txt_Resultado.TabIndex = 23;
            // 
            // Btn_Calcular
            // 
            this.Btn_Calcular.Location = new System.Drawing.Point(122, 162);
            this.Btn_Calcular.Name = "Btn_Calcular";
            this.Btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.Btn_Calcular.TabIndex = 22;
            this.Btn_Calcular.Text = "Calcular";
            this.Btn_Calcular.UseVisualStyleBackColor = true;
            this.Btn_Calcular.Click += new System.EventHandler(this.Btn_Calcular_Click);
            // 
            // Txt_YB
            // 
            this.Txt_YB.Location = new System.Drawing.Point(256, 100);
            this.Txt_YB.Name = "Txt_YB";
            this.Txt_YB.Size = new System.Drawing.Size(100, 20);
            this.Txt_YB.TabIndex = 21;
            // 
            // Txt_XB
            // 
            this.Txt_XB.Location = new System.Drawing.Point(255, 77);
            this.Txt_XB.Name = "Txt_XB";
            this.Txt_XB.Size = new System.Drawing.Size(100, 20);
            this.Txt_XB.TabIndex = 20;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(235, 108);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(14, 13);
            this.Label4.TabIndex = 19;
            this.Label4.Text = "Y";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(235, 77);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(14, 13);
            this.Label5.TabIndex = 18;
            this.Label5.Text = "X";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(235, 50);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(45, 13);
            this.Label6.TabIndex = 17;
            this.Label6.Text = "Punto B";
            // 
            // Txt_YA
            // 
            this.Txt_YA.Location = new System.Drawing.Point(73, 100);
            this.Txt_YA.Name = "Txt_YA";
            this.Txt_YA.Size = new System.Drawing.Size(100, 20);
            this.Txt_YA.TabIndex = 16;
            // 
            // Txt_XA
            // 
            this.Txt_XA.Location = new System.Drawing.Point(72, 77);
            this.Txt_XA.Name = "Txt_XA";
            this.Txt_XA.Size = new System.Drawing.Size(100, 20);
            this.Txt_XA.TabIndex = 15;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(52, 108);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(14, 13);
            this.Label3.TabIndex = 14;
            this.Label3.Text = "Y";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(52, 77);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(14, 13);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "X";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(52, 50);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(45, 13);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Punto A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 243);
            this.Controls.Add(this.Txt_Resultado);
            this.Controls.Add(this.Btn_Calcular);
            this.Controls.Add(this.Txt_YB);
            this.Controls.Add(this.Txt_XB);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Txt_YA);
            this.Controls.Add(this.Txt_XA);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox Txt_Resultado;
        internal System.Windows.Forms.Button Btn_Calcular;
        internal System.Windows.Forms.TextBox Txt_YB;
        internal System.Windows.Forms.TextBox Txt_XB;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox Txt_YA;
        internal System.Windows.Forms.TextBox Txt_XA;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}

