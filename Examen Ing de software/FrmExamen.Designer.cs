﻿namespace ExamenDeOndas
{
    partial class Prueba
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prueba));
            this.button1 = new System.Windows.Forms.Button();
            this.opcion1 = new System.Windows.Forms.RadioButton();
            this.opcion2 = new System.Windows.Forms.RadioButton();
            this.opcion3 = new System.Windows.Forms.RadioButton();
            this.opcion4 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pregunta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(193, 420);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // opcion1
            // 
            this.opcion1.AutoSize = true;
            this.opcion1.Location = new System.Drawing.Point(32, 169);
            this.opcion1.Margin = new System.Windows.Forms.Padding(4);
            this.opcion1.Name = "opcion1";
            this.opcion1.Size = new System.Drawing.Size(14, 13);
            this.opcion1.TabIndex = 1;
            this.opcion1.TabStop = true;
            this.opcion1.UseVisualStyleBackColor = true;
            this.opcion1.CheckedChanged += new System.EventHandler(this.opcion1_CheckedChanged);
            // 
            // opcion2
            // 
            this.opcion2.AutoSize = true;
            this.opcion2.Location = new System.Drawing.Point(32, 225);
            this.opcion2.Margin = new System.Windows.Forms.Padding(4);
            this.opcion2.Name = "opcion2";
            this.opcion2.Size = new System.Drawing.Size(14, 13);
            this.opcion2.TabIndex = 2;
            this.opcion2.TabStop = true;
            this.opcion2.UseVisualStyleBackColor = true;
            // 
            // opcion3
            // 
            this.opcion3.AutoSize = true;
            this.opcion3.Location = new System.Drawing.Point(32, 277);
            this.opcion3.Margin = new System.Windows.Forms.Padding(4);
            this.opcion3.Name = "opcion3";
            this.opcion3.Size = new System.Drawing.Size(14, 13);
            this.opcion3.TabIndex = 3;
            this.opcion3.TabStop = true;
            this.opcion3.UseVisualStyleBackColor = true;
            // 
            // opcion4
            // 
            this.opcion4.AutoSize = true;
            this.opcion4.Location = new System.Drawing.Point(32, 332);
            this.opcion4.Margin = new System.Windows.Forms.Padding(4);
            this.opcion4.Name = "opcion4";
            this.opcion4.Size = new System.Drawing.Size(14, 13);
            this.opcion4.TabIndex = 4;
            this.opcion4.TabStop = true;
            this.opcion4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Preguntas de seleccion multiple";
            // 
            // pregunta
            // 
            this.pregunta.AutoSize = true;
            this.pregunta.Location = new System.Drawing.Point(29, 110);
            this.pregunta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pregunta.Name = "pregunta";
            this.pregunta.Size = new System.Drawing.Size(0, 15);
            this.pregunta.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(476, 391);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(604, 499);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Grpor 01 De Ondas ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Selecciona la opción que creas correcta";
            // 
            // Prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(726, 540);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pregunta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.opcion4);
            this.Controls.Add(this.opcion3);
            this.Controls.Add(this.opcion2);
            this.Controls.Add(this.opcion1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Prueba";
            this.Text = "EXAMEN DE ONDAS";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton opcion1;
        private System.Windows.Forms.RadioButton opcion2;
        private System.Windows.Forms.RadioButton opcion3;
        private System.Windows.Forms.RadioButton opcion4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pregunta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

