
namespace Lab1._4
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFigure = new System.Windows.Forms.Button();
            this.btnBrush = new System.Windows.Forms.Button();
            this.btnPen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnWhite = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnMagenta = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnCyan = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnBlack = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnClean = new System.Windows.Forms.Button();
            this.ShapeView = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.Volume = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.Speed = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShapeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFigure);
            this.groupBox1.Controls.Add(this.btnBrush);
            this.groupBox1.Controls.Add(this.btnPen);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drawing Tool";
            // 
            // btnFigure
            // 
            this.btnFigure.Location = new System.Drawing.Point(7, 113);
            this.btnFigure.Name = "btnFigure";
            this.btnFigure.Size = new System.Drawing.Size(106, 23);
            this.btnFigure.TabIndex = 2;
            this.btnFigure.Text = "MyFigure";
            this.btnFigure.UseVisualStyleBackColor = true;
            // 
            // btnBrush
            // 
            this.btnBrush.Location = new System.Drawing.Point(7, 70);
            this.btnBrush.Name = "btnBrush";
            this.btnBrush.Size = new System.Drawing.Size(106, 23);
            this.btnBrush.TabIndex = 1;
            this.btnBrush.Text = "Brush";
            this.btnBrush.UseVisualStyleBackColor = true;
            this.btnBrush.Click += new System.EventHandler(this.btnBrush_Click);
            // 
            // btnPen
            // 
            this.btnPen.Location = new System.Drawing.Point(7, 31);
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(106, 23);
            this.btnPen.TabIndex = 0;
            this.btnPen.Text = "Pen";
            this.btnPen.UseVisualStyleBackColor = true;
            this.btnPen.Click += new System.EventHandler(this.btnPen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLine);
            this.groupBox2.Controls.Add(this.btnSquare);
            this.groupBox2.Controls.Add(this.btnCircle);
            this.groupBox2.Location = new System.Drawing.Point(12, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 148);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Drawing Shape";
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(7, 20);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(101, 23);
            this.btnLine.TabIndex = 3;
            this.btnLine.Text = "&Line";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Location = new System.Drawing.Point(7, 114);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(101, 23);
            this.btnSquare.TabIndex = 2;
            this.btnSquare.Text = "&Square";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(7, 65);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(101, 23);
            this.btnCircle.TabIndex = 1;
            this.btnCircle.Text = "&Circle";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnWhite);
            this.groupBox3.Controls.Add(this.btnYellow);
            this.groupBox3.Controls.Add(this.btnMagenta);
            this.groupBox3.Controls.Add(this.btnRed);
            this.groupBox3.Controls.Add(this.btnCyan);
            this.groupBox3.Controls.Add(this.btnGreen);
            this.groupBox3.Controls.Add(this.btnBlue);
            this.groupBox3.Controls.Add(this.btnBlack);
            this.groupBox3.Location = new System.Drawing.Point(190, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(116, 343);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Color";
            // 
            // btnWhite
            // 
            this.btnWhite.Location = new System.Drawing.Point(0, 304);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(106, 23);
            this.btnWhite.TabIndex = 8;
            this.btnWhite.Text = "White";
            this.btnWhite.UseVisualStyleBackColor = true;
            this.btnWhite.Click += new System.EventHandler(this.btnWhite_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.Location = new System.Drawing.Point(0, 266);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(106, 23);
            this.btnYellow.TabIndex = 7;
            this.btnYellow.Text = "Yellow";
            this.btnYellow.UseVisualStyleBackColor = true;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnMagenta
            // 
            this.btnMagenta.Location = new System.Drawing.Point(0, 227);
            this.btnMagenta.Name = "btnMagenta";
            this.btnMagenta.Size = new System.Drawing.Size(106, 23);
            this.btnMagenta.TabIndex = 6;
            this.btnMagenta.Text = "Magenta";
            this.btnMagenta.UseVisualStyleBackColor = true;
            this.btnMagenta.Click += new System.EventHandler(this.btnMagenta_Click);
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(0, 182);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(106, 23);
            this.btnRed.TabIndex = 5;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnCyan
            // 
            this.btnCyan.Location = new System.Drawing.Point(0, 144);
            this.btnCyan.Name = "btnCyan";
            this.btnCyan.Size = new System.Drawing.Size(106, 23);
            this.btnCyan.TabIndex = 4;
            this.btnCyan.Text = "Cyan";
            this.btnCyan.UseVisualStyleBackColor = true;
            this.btnCyan.Click += new System.EventHandler(this.btnCyan_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.Location = new System.Drawing.Point(0, 102);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(106, 23);
            this.btnGreen.TabIndex = 3;
            this.btnGreen.Text = "Green";
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.Location = new System.Drawing.Point(0, 59);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(106, 23);
            this.btnBlue.TabIndex = 2;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.Location = new System.Drawing.Point(0, 20);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(106, 23);
            this.btnBlack.TabIndex = 1;
            this.btnBlack.Text = "Black";
            this.btnBlack.UseVisualStyleBackColor = true;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.Red;
            this.btnClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClean.Location = new System.Drawing.Point(685, 23);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(26, 20);
            this.btnClean.TabIndex = 5;
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // ShapeView
            // 
            this.ShapeView.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ShapeView.Location = new System.Drawing.Point(375, 43);
            this.ShapeView.Name = "ShapeView";
            this.ShapeView.Size = new System.Drawing.Size(336, 307);
            this.ShapeView.TabIndex = 4;
            this.ShapeView.TabStop = false;
            this.ShapeView.Paint += new System.Windows.Forms.PaintEventHandler(this.ShapeView_Paint);
            this.ShapeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShapeView_MouseDown);
            this.ShapeView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ShapeView_MouseMove);
            this.ShapeView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShapeView_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(652, 492);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 32);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Volume
            // 
            this.Volume.Location = new System.Drawing.Point(106, 26);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(153, 45);
            this.Volume.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Volume";
            // 
            // Speed
            // 
            this.Speed.Location = new System.Drawing.Point(428, 26);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(149, 45);
            this.Speed.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Speed";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(98, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Voice";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(356, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.Volume);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.Speed);
            this.groupBox4.Location = new System.Drawing.Point(19, 382);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(607, 123);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sound Options";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(763, 535);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.ShapeView);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Audio/Sound";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShapeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFigure;
        private System.Windows.Forms.Button btnBrush;
        private System.Windows.Forms.Button btnPen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnWhite;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnMagenta;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnCyan;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnBlack;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.PictureBox ShapeView;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TrackBar Volume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar Speed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

