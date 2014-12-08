namespace GraficacionApps
{
    partial class Cubo3D
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tX = new System.Windows.Forms.TrackBar();
            this.tY = new System.Windows.Forms.TrackBar();
            this.tZ = new System.Windows.Forms.TrackBar();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chBottom = new System.Windows.Forms.CheckBox();
            this.chTop = new System.Windows.Forms.CheckBox();
            this.chRight = new System.Windows.Forms.CheckBox();
            this.chLeft = new System.Windows.Forms.CheckBox();
            this.chBack = new System.Windows.Forms.CheckBox();
            this.chFront = new System.Windows.Forms.CheckBox();
            this.chWires = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tZ)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 235);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Z:";
            // 
            // tX
            // 
            this.tX.AutoSize = false;
            this.tX.Location = new System.Drawing.Point(40, 264);
            this.tX.Maximum = 360;
            this.tX.Minimum = -360;
            this.tX.Name = "tX";
            this.tX.Size = new System.Drawing.Size(271, 27);
            this.tX.TabIndex = 4;
            this.tX.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tX.Scroll += new System.EventHandler(this.tX_Scroll);
            // 
            // tY
            // 
            this.tY.AutoSize = false;
            this.tY.Location = new System.Drawing.Point(40, 293);
            this.tY.Maximum = 360;
            this.tY.Minimum = -360;
            this.tY.Name = "tY";
            this.tY.Size = new System.Drawing.Size(271, 27);
            this.tY.TabIndex = 5;
            this.tY.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tY.Scroll += new System.EventHandler(this.tY_Scroll);
            // 
            // tZ
            // 
            this.tZ.AutoSize = false;
            this.tZ.Location = new System.Drawing.Point(40, 320);
            this.tZ.Maximum = 360;
            this.tZ.Minimum = -360;
            this.tZ.Name = "tZ";
            this.tZ.Size = new System.Drawing.Size(271, 27);
            this.tZ.TabIndex = 6;
            this.tZ.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tZ.Scroll += new System.EventHandler(this.tZ_Scroll);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(220, 392);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reiniciar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chBottom);
            this.groupBox1.Controls.Add(this.chTop);
            this.groupBox1.Controls.Add(this.chRight);
            this.groupBox1.Controls.Add(this.chLeft);
            this.groupBox1.Controls.Add(this.chBack);
            this.groupBox1.Controls.Add(this.chFront);
            this.groupBox1.Controls.Add(this.chWires);
            this.groupBox1.Location = new System.Drawing.Point(13, 353);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 154);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de Relleno";
            // 
            // chBottom
            // 
            this.chBottom.AutoSize = true;
            this.chBottom.Location = new System.Drawing.Point(115, 75);
            this.chBottom.Name = "chBottom";
            this.chBottom.Size = new System.Drawing.Size(53, 17);
            this.chBottom.TabIndex = 6;
            this.chBottom.Text = "Abajo";
            this.chBottom.UseVisualStyleBackColor = true;
            this.chBottom.CheckedChanged += new System.EventHandler(this.chBottom_CheckedChanged);
            // 
            // chTop
            // 
            this.chTop.AutoSize = true;
            this.chTop.Location = new System.Drawing.Point(115, 52);
            this.chTop.Name = "chTop";
            this.chTop.Size = new System.Drawing.Size(53, 17);
            this.chTop.TabIndex = 5;
            this.chTop.Text = "Arriba";
            this.chTop.UseVisualStyleBackColor = true;
            this.chTop.CheckedChanged += new System.EventHandler(this.chTop_CheckedChanged);
            // 
            // chRight
            // 
            this.chRight.AutoSize = true;
            this.chRight.Location = new System.Drawing.Point(20, 121);
            this.chRight.Name = "chRight";
            this.chRight.Size = new System.Drawing.Size(67, 17);
            this.chRight.TabIndex = 4;
            this.chRight.Text = "Derecha";
            this.chRight.UseVisualStyleBackColor = true;
            this.chRight.CheckedChanged += new System.EventHandler(this.chRight_CheckedChanged);
            // 
            // chLeft
            // 
            this.chLeft.AutoSize = true;
            this.chLeft.Location = new System.Drawing.Point(20, 98);
            this.chLeft.Name = "chLeft";
            this.chLeft.Size = new System.Drawing.Size(69, 17);
            this.chLeft.TabIndex = 3;
            this.chLeft.Text = "Izquierda";
            this.chLeft.UseVisualStyleBackColor = true;
            this.chLeft.CheckedChanged += new System.EventHandler(this.chLeft_CheckedChanged);
            // 
            // chBack
            // 
            this.chBack.AutoSize = true;
            this.chBack.Location = new System.Drawing.Point(20, 75);
            this.chBack.Name = "chBack";
            this.chBack.Size = new System.Drawing.Size(50, 17);
            this.chBack.TabIndex = 2;
            this.chBack.Text = "Atras";
            this.chBack.UseVisualStyleBackColor = true;
            this.chBack.CheckedChanged += new System.EventHandler(this.chBack_CheckedChanged);
            // 
            // chFront
            // 
            this.chFront.AutoSize = true;
            this.chFront.Location = new System.Drawing.Point(20, 52);
            this.chFront.Name = "chFront";
            this.chFront.Size = new System.Drawing.Size(56, 17);
            this.chFront.TabIndex = 1;
            this.chFront.Text = "Frente";
            this.chFront.UseVisualStyleBackColor = true;
            this.chFront.CheckedChanged += new System.EventHandler(this.chFront_CheckedChanged);
            // 
            // chWires
            // 
            this.chWires.AutoSize = true;
            this.chWires.Location = new System.Drawing.Point(20, 20);
            this.chWires.Name = "chWires";
            this.chWires.Size = new System.Drawing.Size(75, 17);
            this.chWires.TabIndex = 0;
            this.chWires.Text = "Sin Lineas";
            this.chWires.UseVisualStyleBackColor = true;
            this.chWires.CheckedChanged += new System.EventHandler(this.chWires_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cubo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cubo3D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 522);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tZ);
            this.Controls.Add(this.tY);
            this.Controls.Add(this.tX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Cubo3D";
            this.Text = "Cubo3D";
            this.Load += new System.EventHandler(this.Cubo3D_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Cubo3D_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tZ)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tX;
        private System.Windows.Forms.TrackBar tY;
        private System.Windows.Forms.TrackBar tZ;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chBottom;
        private System.Windows.Forms.CheckBox chTop;
        private System.Windows.Forms.CheckBox chRight;
        private System.Windows.Forms.CheckBox chLeft;
        private System.Windows.Forms.CheckBox chBack;
        private System.Windows.Forms.CheckBox chFront;
        private System.Windows.Forms.CheckBox chWires;
        private System.Windows.Forms.Button button1;
    }
}