namespace PetroQuiz
{
    partial class Concurso
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Concurso));
            this.lblNombreEq1 = new System.Windows.Forms.Label();
            this.lblNombreEq2 = new System.Windows.Forms.Label();
            this.btnEq1 = new System.Windows.Forms.Button();
            this.btnEq2 = new System.Windows.Forms.Button();
            this.txtPreguntas = new System.Windows.Forms.RichTextBox();
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.lblPuntosEq1 = new System.Windows.Forms.Label();
            this.lblPuntosEq2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.btnEditarEq2 = new System.Windows.Forms.Button();
            this.btnEditarEq1 = new System.Windows.Forms.Button();
            this.btnIncorrectoEq1 = new System.Windows.Forms.Button();
            this.btnCorrectoEq1 = new System.Windows.Forms.Button();
            this.btnIncorrectoEq2 = new System.Windows.Forms.Button();
            this.btnCorrectoEq2 = new System.Windows.Forms.Button();
            this.imagenEq2 = new System.Windows.Forms.PictureBox();
            this.imagenEq1 = new System.Windows.Forms.PictureBox();
            this.txtAnswer = new System.Windows.Forms.RichTextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAnswer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagenEq2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenEq1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreEq1
            // 
            this.lblNombreEq1.AutoSize = true;
            this.lblNombreEq1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEq1.Location = new System.Drawing.Point(178, 32);
            this.lblNombreEq1.Name = "lblNombreEq1";
            this.lblNombreEq1.Size = new System.Drawing.Size(0, 55);
            this.lblNombreEq1.TabIndex = 2;
            // 
            // lblNombreEq2
            // 
            this.lblNombreEq2.AutoSize = true;
            this.lblNombreEq2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEq2.Location = new System.Drawing.Point(1014, 32);
            this.lblNombreEq2.Name = "lblNombreEq2";
            this.lblNombreEq2.Size = new System.Drawing.Size(0, 55);
            this.lblNombreEq2.TabIndex = 3;
            // 
            // btnEq1
            // 
            this.btnEq1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEq1.Location = new System.Drawing.Point(505, 526);
            this.btnEq1.Name = "btnEq1";
            this.btnEq1.Size = new System.Drawing.Size(75, 23);
            this.btnEq1.TabIndex = 4;
            this.btnEq1.Text = "Team A";
            this.btnEq1.UseVisualStyleBackColor = true;
            this.btnEq1.Click += new System.EventHandler(this.btnEq1_Click);
            // 
            // btnEq2
            // 
            this.btnEq2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEq2.Location = new System.Drawing.Point(760, 526);
            this.btnEq2.Name = "btnEq2";
            this.btnEq2.Size = new System.Drawing.Size(75, 23);
            this.btnEq2.TabIndex = 5;
            this.btnEq2.Text = "Team B";
            this.btnEq2.UseVisualStyleBackColor = true;
            this.btnEq2.Click += new System.EventHandler(this.btnEq2_Click);
            // 
            // txtPreguntas
            // 
            this.txtPreguntas.Font = new System.Drawing.Font("Arial", 19F);
            this.txtPreguntas.Location = new System.Drawing.Point(410, 91);
            this.txtPreguntas.Name = "txtPreguntas";
            this.txtPreguntas.ReadOnly = true;
            this.txtPreguntas.Size = new System.Drawing.Size(519, 243);
            this.txtPreguntas.TabIndex = 6;
            this.txtPreguntas.Text = "";
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEmpezar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpezar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEmpezar.Location = new System.Drawing.Point(620, 510);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(96, 39);
            this.btnEmpezar.TabIndex = 7;
            this.btnEmpezar.Text = "Round 1";
            this.btnEmpezar.UseVisualStyleBackColor = false;
            this.btnEmpezar.Visible = false;
            this.btnEmpezar.Click += new System.EventHandler(this.btnEmpezar_Click);
            // 
            // lblPuntosEq1
            // 
            this.lblPuntosEq1.AutoSize = true;
            this.lblPuntosEq1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntosEq1.Location = new System.Drawing.Point(202, 426);
            this.lblPuntosEq1.Name = "lblPuntosEq1";
            this.lblPuntosEq1.Size = new System.Drawing.Size(80, 55);
            this.lblPuntosEq1.TabIndex = 10;
            this.lblPuntosEq1.Text = "00";
            // 
            // lblPuntosEq2
            // 
            this.lblPuntosEq2.AutoSize = true;
            this.lblPuntosEq2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntosEq2.Location = new System.Drawing.Point(1051, 426);
            this.lblPuntosEq2.Name = "lblPuntosEq2";
            this.lblPuntosEq2.Size = new System.Drawing.Size(80, 55);
            this.lblPuntosEq2.TabIndex = 11;
            this.lblPuntosEq2.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(625, 43);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(103, 42);
            this.btnGenerar.TabIndex = 13;
            this.btnGenerar.Text = "Generate Question";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(582, 585);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(0, 76);
            this.lblTiempo.TabIndex = 14;
            // 
            // btnEditarEq2
            // 
            this.btnEditarEq2.Location = new System.Drawing.Point(1056, 610);
            this.btnEditarEq2.Name = "btnEditarEq2";
            this.btnEditarEq2.Size = new System.Drawing.Size(75, 23);
            this.btnEditarEq2.TabIndex = 19;
            this.btnEditarEq2.Text = "Edit Score";
            this.btnEditarEq2.UseVisualStyleBackColor = true;
            this.btnEditarEq2.Click += new System.EventHandler(this.btnEditarEq2_Click);
            // 
            // btnEditarEq1
            // 
            this.btnEditarEq1.Location = new System.Drawing.Point(207, 611);
            this.btnEditarEq1.Name = "btnEditarEq1";
            this.btnEditarEq1.Size = new System.Drawing.Size(75, 23);
            this.btnEditarEq1.TabIndex = 20;
            this.btnEditarEq1.Text = "Edit Score";
            this.btnEditarEq1.UseVisualStyleBackColor = true;
            this.btnEditarEq1.Click += new System.EventHandler(this.btnEditarEq1_Click);
            // 
            // btnIncorrectoEq1
            // 
            this.btnIncorrectoEq1.BackColor = System.Drawing.Color.DimGray;
            this.btnIncorrectoEq1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIncorrectoEq1.BackgroundImage")));
            this.btnIncorrectoEq1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIncorrectoEq1.FlatAppearance.BorderSize = 5;
            this.btnIncorrectoEq1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncorrectoEq1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncorrectoEq1.ForeColor = System.Drawing.Color.White;
            this.btnIncorrectoEq1.Location = new System.Drawing.Point(283, 524);
            this.btnIncorrectoEq1.Name = "btnIncorrectoEq1";
            this.btnIncorrectoEq1.Size = new System.Drawing.Size(62, 62);
            this.btnIncorrectoEq1.TabIndex = 18;
            this.btnIncorrectoEq1.UseVisualStyleBackColor = false;
            this.btnIncorrectoEq1.Visible = false;
            this.btnIncorrectoEq1.Click += new System.EventHandler(this.btnIncorrectoEq1_Click);
            // 
            // btnCorrectoEq1
            // 
            this.btnCorrectoEq1.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCorrectoEq1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCorrectoEq1.BackgroundImage")));
            this.btnCorrectoEq1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCorrectoEq1.FlatAppearance.BorderSize = 5;
            this.btnCorrectoEq1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorrectoEq1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrectoEq1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCorrectoEq1.Location = new System.Drawing.Point(155, 525);
            this.btnCorrectoEq1.Name = "btnCorrectoEq1";
            this.btnCorrectoEq1.Size = new System.Drawing.Size(62, 60);
            this.btnCorrectoEq1.TabIndex = 17;
            this.btnCorrectoEq1.UseVisualStyleBackColor = false;
            this.btnCorrectoEq1.Visible = false;
            this.btnCorrectoEq1.Click += new System.EventHandler(this.btnCorrectoEq1_Click);
            // 
            // btnIncorrectoEq2
            // 
            this.btnIncorrectoEq2.BackColor = System.Drawing.Color.RosyBrown;
            this.btnIncorrectoEq2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIncorrectoEq2.BackgroundImage")));
            this.btnIncorrectoEq2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIncorrectoEq2.FlatAppearance.BorderSize = 5;
            this.btnIncorrectoEq2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncorrectoEq2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncorrectoEq2.ForeColor = System.Drawing.Color.White;
            this.btnIncorrectoEq2.Location = new System.Drawing.Point(1124, 523);
            this.btnIncorrectoEq2.Name = "btnIncorrectoEq2";
            this.btnIncorrectoEq2.Size = new System.Drawing.Size(62, 62);
            this.btnIncorrectoEq2.TabIndex = 16;
            this.btnIncorrectoEq2.UseVisualStyleBackColor = false;
            this.btnIncorrectoEq2.Visible = false;
            this.btnIncorrectoEq2.Click += new System.EventHandler(this.btnIncorrectoEq2_Click);
            // 
            // btnCorrectoEq2
            // 
            this.btnCorrectoEq2.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCorrectoEq2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCorrectoEq2.BackgroundImage")));
            this.btnCorrectoEq2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCorrectoEq2.FlatAppearance.BorderSize = 5;
            this.btnCorrectoEq2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorrectoEq2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrectoEq2.Location = new System.Drawing.Point(995, 524);
            this.btnCorrectoEq2.Name = "btnCorrectoEq2";
            this.btnCorrectoEq2.Size = new System.Drawing.Size(62, 60);
            this.btnCorrectoEq2.TabIndex = 15;
            this.btnCorrectoEq2.UseVisualStyleBackColor = false;
            this.btnCorrectoEq2.Visible = false;
            this.btnCorrectoEq2.Click += new System.EventHandler(this.btnCorrectoEq2_Click);
            // 
            // imagenEq2
            // 
            this.imagenEq2.Location = new System.Drawing.Point(946, 91);
            this.imagenEq2.Name = "imagenEq2";
            this.imagenEq2.Size = new System.Drawing.Size(286, 286);
            this.imagenEq2.TabIndex = 1;
            this.imagenEq2.TabStop = false;
            // 
            // imagenEq1
            // 
            this.imagenEq1.Location = new System.Drawing.Point(103, 91);
            this.imagenEq1.Name = "imagenEq1";
            this.imagenEq1.Size = new System.Drawing.Size(286, 286);
            this.imagenEq1.TabIndex = 0;
            this.imagenEq1.TabStop = false;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Arial Narrow", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(410, 372);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ReadOnly = true;
            this.txtAnswer.Size = new System.Drawing.Size(519, 132);
            this.txtAnswer.TabIndex = 21;
            this.txtAnswer.Text = "";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(607, 673);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(121, 23);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Save and Close";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAnswer
            // 
            this.btnAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer.Location = new System.Drawing.Point(625, 340);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(103, 26);
            this.btnAnswer.TabIndex = 24;
            this.btnAnswer.Text = "Answer";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // Concurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.btnEditarEq1);
            this.Controls.Add(this.btnEditarEq2);
            this.Controls.Add(this.btnIncorrectoEq1);
            this.Controls.Add(this.btnCorrectoEq1);
            this.Controls.Add(this.btnIncorrectoEq2);
            this.Controls.Add(this.btnCorrectoEq2);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblPuntosEq2);
            this.Controls.Add(this.lblPuntosEq1);
            this.Controls.Add(this.btnEmpezar);
            this.Controls.Add(this.txtPreguntas);
            this.Controls.Add(this.btnEq2);
            this.Controls.Add(this.btnEq1);
            this.Controls.Add(this.lblNombreEq2);
            this.Controls.Add(this.lblNombreEq1);
            this.Controls.Add(this.imagenEq2);
            this.Controls.Add(this.imagenEq1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Concurso";
            this.Text = "PetroTest";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Concurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagenEq2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenEq1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagenEq1;
        private System.Windows.Forms.PictureBox imagenEq2;
        private System.Windows.Forms.Label lblNombreEq1;
        private System.Windows.Forms.Label lblNombreEq2;
        private System.Windows.Forms.Button btnEq1;
        private System.Windows.Forms.Button btnEq2;
        private System.Windows.Forms.RichTextBox txtPreguntas;
        private System.Windows.Forms.Button btnEmpezar;
        private System.Windows.Forms.Label lblPuntosEq1;
        private System.Windows.Forms.Label lblPuntosEq2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Button btnCorrectoEq2;
        private System.Windows.Forms.Button btnIncorrectoEq2;
        private System.Windows.Forms.Button btnCorrectoEq1;
        private System.Windows.Forms.Button btnIncorrectoEq1;
        private System.Windows.Forms.Button btnEditarEq2;
        private System.Windows.Forms.Button btnEditarEq1;
        private System.Windows.Forms.RichTextBox txtAnswer;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAnswer;
    }
}