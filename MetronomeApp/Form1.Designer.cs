namespace MetronomeApp
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
            btn_start = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            tbar_bpm = new TrackBar();
            lbl_bpm = new Label();
            lbl_title = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbar_bpm).BeginInit();
            SuspendLayout();
            // 
            // btn_start
            // 
            btn_start.BackColor = SystemColors.ButtonShadow;
            btn_start.FlatStyle = FlatStyle.System;
            btn_start.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_start.ForeColor = SystemColors.Desktop;
            btn_start.Location = new Point(161, 369);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(146, 64);
            btn_start.TabIndex = 0;
            btn_start.Text = "INICIAR";
            btn_start.UseVisualStyleBackColor = false;
            btn_start.Click += btn_start_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 534);
            panel1.Name = "panel1";
            panel1.Size = new Size(468, 16);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(168, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 120);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // tbar_bpm
            // 
            tbar_bpm.Location = new Point(72, 266);
            tbar_bpm.Maximum = 240;
            tbar_bpm.Name = "tbar_bpm";
            tbar_bpm.Size = new Size(324, 45);
            tbar_bpm.TabIndex = 3;
            tbar_bpm.TickStyle = TickStyle.Both;
            tbar_bpm.Value = 120;
            tbar_bpm.Scroll += tbar_bpm_Scroll;
            // 
            // lbl_bpm
            // 
            lbl_bpm.AutoSize = true;
            lbl_bpm.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_bpm.Location = new Point(209, 242);
            lbl_bpm.Name = "lbl_bpm";
            lbl_bpm.Size = new Size(48, 21);
            lbl_bpm.TabIndex = 4;
            lbl_bpm.Text = "BPM:";
            lbl_bpm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_title.Location = new Point(151, 44);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(166, 29);
            lbl_title.TabIndex = 5;
            lbl_title.Text = "METRÔNOMO";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 550);
            Controls.Add(lbl_title);
            Controls.Add(lbl_bpm);
            Controls.Add(tbar_bpm);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(btn_start);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbar_bpm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_start;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TrackBar tbar_bpm;
        private Label lbl_bpm;
        private Label lbl_title;

    }
}
