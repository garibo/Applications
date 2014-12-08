namespace GraficacionApps
{
    partial class Move
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
            this.teta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.valPR = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ypoint = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.xpoint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.drawArea = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.drawArea)).BeginInit();
            this.SuspendLayout();
            // 
            // teta
            // 
            this.teta.Location = new System.Drawing.Point(596, 296);
            this.teta.Name = "teta";
            this.teta.Size = new System.Drawing.Size(122, 20);
            this.teta.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(594, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Angulo de Rotación";
            // 
            // valPR
            // 
            this.valPR.AutoSize = true;
            this.valPR.Location = new System.Drawing.Point(596, 140);
            this.valPR.Name = "valPR";
            this.valPR.Size = new System.Drawing.Size(65, 13);
            this.valPR.TabIndex = 26;
            this.valPR.Text = "Sin calcular.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(596, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Baricentro";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(596, 328);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "Calcular Baricentro";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(686, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(612, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "X";
            // 
            // ypoint
            // 
            this.ypoint.Location = new System.Drawing.Point(666, 58);
            this.ypoint.Name = "ypoint";
            this.ypoint.Size = new System.Drawing.Size(52, 20);
            this.ypoint.TabIndex = 21;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(596, 387);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Girar el Objeto";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(596, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Dibujar Puntos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Guardar Punto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // xpoint
            // 
            this.xpoint.Location = new System.Drawing.Point(596, 58);
            this.xpoint.Name = "xpoint";
            this.xpoint.Size = new System.Drawing.Size(52, 20);
            this.xpoint.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(616, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Coordenadas";
            // 
            // drawArea
            // 
            this.drawArea.Location = new System.Drawing.Point(12, 12);
            this.drawArea.Name = "drawArea";
            this.drawArea.Size = new System.Drawing.Size(568, 398);
            this.drawArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.drawArea.TabIndex = 15;
            this.drawArea.TabStop = false;
            // 
            // Move
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 422);
            this.Controls.Add(this.teta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valPR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ypoint);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.xpoint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drawArea);
            this.Name = "Move";
            this.Text = "Rotación de Figura 2D";
            ((System.ComponentModel.ISupportInitialize)(this.drawArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label valPR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ypoint;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox xpoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox drawArea;
    }
}