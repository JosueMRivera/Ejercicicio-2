
namespace Ejercicio_2
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
            this.components = new System.ComponentModel.Container();
            this.calculatbt = new System.Windows.Forms.Button();
            this.nota4txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nota3txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nota2txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nota1txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // calculatbt
            // 
            this.calculatbt.Location = new System.Drawing.Point(102, 170);
            this.calculatbt.Name = "calculatbt";
            this.calculatbt.Size = new System.Drawing.Size(75, 23);
            this.calculatbt.TabIndex = 27;
            this.calculatbt.Text = "Calcular";
            this.calculatbt.UseVisualStyleBackColor = true;
            this.calculatbt.Click += new System.EventHandler(this.calculatbt_Click);
            // 
            // nota4txt
            // 
            this.nota4txt.Location = new System.Drawing.Point(88, 132);
            this.nota4txt.Name = "nota4txt";
            this.nota4txt.Size = new System.Drawing.Size(107, 20);
            this.nota4txt.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Nota 4:";
            // 
            // nota3txt
            // 
            this.nota3txt.Location = new System.Drawing.Point(88, 96);
            this.nota3txt.Name = "nota3txt";
            this.nota3txt.Size = new System.Drawing.Size(107, 20);
            this.nota3txt.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nota 3:";
            // 
            // nota2txt
            // 
            this.nota2txt.Location = new System.Drawing.Point(88, 56);
            this.nota2txt.Name = "nota2txt";
            this.nota2txt.Size = new System.Drawing.Size(107, 20);
            this.nota2txt.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nota 2:";
            // 
            // nota1txt
            // 
            this.nota1txt.Location = new System.Drawing.Point(88, 18);
            this.nota1txt.Name = "nota1txt";
            this.nota1txt.Size = new System.Drawing.Size(107, 20);
            this.nota1txt.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nota 1:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 262);
            this.Controls.Add(this.calculatbt);
            this.Controls.Add(this.nota4txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nota3txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nota2txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nota1txt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculatbt;
        private System.Windows.Forms.TextBox nota4txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nota3txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nota2txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nota1txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

