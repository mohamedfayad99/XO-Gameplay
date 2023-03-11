namespace XOGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtp1 = new System.Windows.Forms.TextBox();
            this.rado1 = new System.Windows.Forms.RadioButton();
            this.radx1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtp2 = new System.Windows.Forms.TextBox();
            this.rado2 = new System.Windows.Forms.RadioButton();
            this.radx2 = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtp1);
            this.groupBox1.Controls.Add(this.rado1);
            this.groupBox1.Controls.Add(this.radx1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.Location = new System.Drawing.Point(105, 135);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(276, 265);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // txtp1
            // 
            this.txtp1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtp1.ForeColor = System.Drawing.Color.Maroon;
            this.txtp1.Location = new System.Drawing.Point(25, 94);
            this.txtp1.Name = "txtp1";
            this.txtp1.Size = new System.Drawing.Size(167, 32);
            this.txtp1.TabIndex = 2;
            // 
            // rado1
            // 
            this.rado1.AutoSize = true;
            this.rado1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rado1.ForeColor = System.Drawing.Color.Maroon;
            this.rado1.Location = new System.Drawing.Point(168, 201);
            this.rado1.Name = "rado1";
            this.rado1.Size = new System.Drawing.Size(53, 35);
            this.rado1.TabIndex = 1;
            this.rado1.TabStop = true;
            this.rado1.Text = "O";
            this.rado1.UseVisualStyleBackColor = true;
            this.rado1.Click += new System.EventHandler(this.rado1_Click);
            // 
            // radx1
            // 
            this.radx1.AutoSize = true;
            this.radx1.BackColor = System.Drawing.Color.SandyBrown;
            this.radx1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radx1.ForeColor = System.Drawing.Color.Maroon;
            this.radx1.Location = new System.Drawing.Point(25, 201);
            this.radx1.Name = "radx1";
            this.radx1.Size = new System.Drawing.Size(51, 35);
            this.radx1.TabIndex = 0;
            this.radx1.TabStop = true;
            this.radx1.Text = "X";
            this.radx1.UseVisualStyleBackColor = false;
            this.radx1.Click += new System.EventHandler(this.radx1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtp2);
            this.groupBox2.Controls.Add(this.rado2);
            this.groupBox2.Controls.Add(this.radx2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox2.Location = new System.Drawing.Point(505, 135);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(288, 265);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // txtp2
            // 
            this.txtp2.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtp2.ForeColor = System.Drawing.Color.Maroon;
            this.txtp2.Location = new System.Drawing.Point(27, 94);
            this.txtp2.Name = "txtp2";
            this.txtp2.Size = new System.Drawing.Size(167, 32);
            this.txtp2.TabIndex = 4;
            // 
            // rado2
            // 
            this.rado2.AutoSize = true;
            this.rado2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rado2.ForeColor = System.Drawing.Color.Maroon;
            this.rado2.Location = new System.Drawing.Point(171, 201);
            this.rado2.Name = "rado2";
            this.rado2.Size = new System.Drawing.Size(53, 35);
            this.rado2.TabIndex = 1;
            this.rado2.TabStop = true;
            this.rado2.Text = "O";
            this.rado2.UseVisualStyleBackColor = true;
            this.rado2.Click += new System.EventHandler(this.rado2_Click);
            // 
            // radx2
            // 
            this.radx2.AutoSize = true;
            this.radx2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radx2.ForeColor = System.Drawing.Color.Maroon;
            this.radx2.Location = new System.Drawing.Point(27, 201);
            this.radx2.Name = "radx2";
            this.radx2.Size = new System.Drawing.Size(51, 35);
            this.radx2.TabIndex = 0;
            this.radx2.TabStop = true;
            this.radx2.Text = "X";
            this.radx2.UseVisualStyleBackColor = true;
            this.radx2.Click += new System.EventHandler(this.radx2_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStart.BackColor = System.Drawing.Color.SandyBrown;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnStart.Font = new System.Drawing.Font("Narkisim", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnStart.ForeColor = System.Drawing.Color.Maroon;
            this.btnStart.Location = new System.Drawing.Point(308, 457);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Padding = new System.Windows.Forms.Padding(12);
            this.btnStart.Size = new System.Drawing.Size(220, 58);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.MouseLeave += new System.EventHandler(this.btnStart_MouseLeave);
            this.btnStart.MouseHover += new System.EventHandler(this.btnStart_MouseHover);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.SandyBrown;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(223, 25);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(17, 10, 5, 10);
            this.label1.Size = new System.Drawing.Size(405, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome in our Game";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(750, 40);
            this.AutoScrollMinSize = new System.Drawing.Size(100, 60);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(908, 556);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(25);
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox1;
        private RadioButton rado1;
        private RadioButton radx1;
        private GroupBox groupBox2;
        private RadioButton rado2;
        private RadioButton radx2;
        private Label label2;
        private TextBox txtp1;
        private Label label3;
        private TextBox txtp2;
        private Button btnStart;
        private Label label1;
    }
}