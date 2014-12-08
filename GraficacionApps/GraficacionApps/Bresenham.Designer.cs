namespace GraficacionApps
{
    partial class Bresenham
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
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pxlBtn = new System.Windows.Forms.Button();
            this.dibujarBtn = new System.Windows.Forms.Button();
            this.pointSecond = new System.Windows.Forms.TextBox();
            this.pointFirst = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.drawArea = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drawArea)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Puntos Anteriores";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Limpiar Pantalla";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pxlBtn
            // 
            this.pxlBtn.Location = new System.Drawing.Point(290, 237);
            this.pxlBtn.Name = "pxlBtn";
            this.pxlBtn.Size = new System.Drawing.Size(119, 23);
            this.pxlBtn.TabIndex = 15;
            this.pxlBtn.Text = "Dibujar un Pixel";
            this.pxlBtn.UseVisualStyleBackColor = true;
            this.pxlBtn.Click += new System.EventHandler(this.pxlBtn_Click_1);
            // 
            // dibujarBtn
            // 
            this.dibujarBtn.Location = new System.Drawing.Point(290, 120);
            this.dibujarBtn.Name = "dibujarBtn";
            this.dibujarBtn.Size = new System.Drawing.Size(119, 23);
            this.dibujarBtn.TabIndex = 14;
            this.dibujarBtn.Text = "Dibujar";
            this.dibujarBtn.UseVisualStyleBackColor = true;
            this.dibujarBtn.Click += new System.EventHandler(this.dibujarBtn_Click_1);
            // 
            // pointSecond
            // 
            this.pointSecond.Location = new System.Drawing.Point(290, 93);
            this.pointSecond.Name = "pointSecond";
            this.pointSecond.Size = new System.Drawing.Size(119, 20);
            this.pointSecond.TabIndex = 13;
            // 
            // pointFirst
            // 
            this.pointFirst.Location = new System.Drawing.Point(290, 67);
            this.pointFirst.Name = "pointFirst";
            this.pointFirst.Size = new System.Drawing.Size(119, 20);
            this.pointFirst.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Puntos (Ej. 10, 20)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Coordenadas ";
            // 
            // drawArea
            // 
            this.drawArea.Location = new System.Drawing.Point(19, 22);
            this.drawArea.Name = "drawArea";
            this.drawArea.Size = new System.Drawing.Size(260, 238);
            this.drawArea.TabIndex = 9;
            this.drawArea.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 19;
            // 
            // Bresenham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 283);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pxlBtn);
            this.Controls.Add(this.dibujarBtn);
            this.Controls.Add(this.pointSecond);
            this.Controls.Add(this.pointFirst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drawArea);
            this.Name = "Bresenham";
            this.Text = "Algoritmo de Bresenham";
            ((System.ComponentModel.ISupportInitialize)(this.drawArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button pxlBtn;
        private System.Windows.Forms.Button dibujarBtn;
        private System.Windows.Forms.TextBox pointSecond;
        private System.Windows.Forms.TextBox pointFirst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox drawArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}