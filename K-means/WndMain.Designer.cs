namespace K_means
{
    partial class WndMain
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
            this.DataGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numbCernel = new System.Windows.Forms.TextBox();
            this.Points = new System.Windows.Forms.Label();
            this.numbPoits = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DataGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGroup
            // 
            this.DataGroup.Controls.Add(this.label1);
            this.DataGroup.Controls.Add(this.button1);
            this.DataGroup.Controls.Add(this.label2);
            this.DataGroup.Controls.Add(this.numbCernel);
            this.DataGroup.Controls.Add(this.Points);
            this.DataGroup.Controls.Add(this.numbPoits);
            this.DataGroup.Location = new System.Drawing.Point(12, 12);
            this.DataGroup.Name = "DataGroup";
            this.DataGroup.Size = new System.Drawing.Size(800, 74);
            this.DataGroup.TabIndex = 0;
            this.DataGroup.TabStop = false;
            this.DataGroup.Text = "Установка входных значений";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(505, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Расположить точки в случайном порядке и определить кластера";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество кластеров";
            // 
            // numbCernel
            // 
            this.numbCernel.Location = new System.Drawing.Point(378, 30);
            this.numbCernel.Name = "numbCernel";
            this.numbCernel.Size = new System.Drawing.Size(97, 20);
            this.numbCernel.TabIndex = 2;
            this.numbCernel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Points
            // 
            this.Points.AutoSize = true;
            this.Points.Location = new System.Drawing.Point(16, 34);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(97, 13);
            this.Points.TabIndex = 1;
            this.Points.Text = "Количество точек";
            // 
            // numbPoits
            // 
            this.numbPoits.Location = new System.Drawing.Point(119, 30);
            this.numbPoits.Name = "numbPoits";
            this.numbPoits.Size = new System.Drawing.Size(97, 20);
            this.numbPoits.TabIndex = 0;
            this.numbPoits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 400);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // WndMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 503);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DataGroup);
            this.Name = "WndMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кластерный анализ. Кластеризация методом k-средних (k-means)";
            this.DataGroup.ResumeLayout(false);
            this.DataGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DataGroup;
        private System.Windows.Forms.Label Points;
        private System.Windows.Forms.TextBox numbPoits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numbCernel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

