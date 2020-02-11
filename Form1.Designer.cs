namespace PetroQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCargarEq1 = new System.Windows.Forms.Button();
            this.btnCargarEq2 = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblEq1 = new System.Windows.Forms.Label();
            this.lblEq2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imagenEq2 = new System.Windows.Forms.PictureBox();
            this.imagenEq1 = new System.Windows.Forms.PictureBox();
            this.btnScore = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagenEq2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenEq1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargarEq1
            // 
            this.btnCargarEq1.Location = new System.Drawing.Point(256, 461);
            this.btnCargarEq1.Name = "btnCargarEq1";
            this.btnCargarEq1.Size = new System.Drawing.Size(97, 26);
            this.btnCargarEq1.TabIndex = 0;
            this.btnCargarEq1.Text = "Select Team";
            this.btnCargarEq1.UseVisualStyleBackColor = true;
            this.btnCargarEq1.Click += new System.EventHandler(this.btnCargarEq1_Click);
            // 
            // btnCargarEq2
            // 
            this.btnCargarEq2.Location = new System.Drawing.Point(941, 461);
            this.btnCargarEq2.Name = "btnCargarEq2";
            this.btnCargarEq2.Size = new System.Drawing.Size(97, 26);
            this.btnCargarEq2.TabIndex = 1;
            this.btnCargarEq2.Text = "Select Team";
            this.btnCargarEq2.UseVisualStyleBackColor = true;
            this.btnCargarEq2.Click += new System.EventHandler(this.btnCargarEq2_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(479, 586);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(125, 33);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Start";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblEq1
            // 
            this.lblEq1.AutoSize = true;
            this.lblEq1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEq1.Location = new System.Drawing.Point(260, 409);
            this.lblEq1.Name = "lblEq1";
            this.lblEq1.Size = new System.Drawing.Size(0, 26);
            this.lblEq1.TabIndex = 5;
            // 
            // lblEq2
            // 
            this.lblEq2.AutoSize = true;
            this.lblEq2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEq2.Location = new System.Drawing.Point(953, 409);
            this.lblEq2.Name = "lblEq2";
            this.lblEq2.Size = new System.Drawing.Size(0, 26);
            this.lblEq2.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Equipo A";
            // 
            // imagenEq2
            // 
            this.imagenEq2.Location = new System.Drawing.Point(866, 89);
            this.imagenEq2.Name = "imagenEq2";
            this.imagenEq2.Size = new System.Drawing.Size(286, 286);
            this.imagenEq2.TabIndex = 4;
            this.imagenEq2.TabStop = false;
            // 
            // imagenEq1
            // 
            this.imagenEq1.Location = new System.Drawing.Point(190, 89);
            this.imagenEq1.Name = "imagenEq1";
            this.imagenEq1.Size = new System.Drawing.Size(286, 286);
            this.imagenEq1.TabIndex = 3;
            this.imagenEq1.TabStop = false;
            // 
            // btnScore
            // 
            this.btnScore.Location = new System.Drawing.Point(732, 586);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(125, 33);
            this.btnScore.TabIndex = 7;
            this.btnScore.Text = "Scores";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(544, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 217);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(528, 360);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(344, 191);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.lblEq2);
            this.Controls.Add(this.lblEq1);
            this.Controls.Add(this.imagenEq2);
            this.Controls.Add(this.imagenEq1);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnCargarEq2);
            this.Controls.Add(this.btnCargarEq1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PetroTest";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagenEq2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenEq1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargarEq1;
        private System.Windows.Forms.Button btnCargarEq2;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.PictureBox imagenEq1;
        private System.Windows.Forms.PictureBox imagenEq2;
        private System.Windows.Forms.Label lblEq1;
        private System.Windows.Forms.Label lblEq2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

