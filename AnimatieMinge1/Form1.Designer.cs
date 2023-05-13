namespace AnimatieMinge1
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            btnSchimbaCuloarea = new Button();
            colorDialog1 = new ColorDialog();
            label1 = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btnSchimbaCuloarea
            // 
            btnSchimbaCuloarea.BackColor = Color.BlanchedAlmond;
            btnSchimbaCuloarea.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSchimbaCuloarea.ForeColor = Color.Black;
            btnSchimbaCuloarea.Location = new Point(631, 327);
            btnSchimbaCuloarea.Name = "btnSchimbaCuloarea";
            btnSchimbaCuloarea.Size = new Size(85, 55);
            btnSchimbaCuloarea.TabIndex = 0;
            btnSchimbaCuloarea.Text = "COLOR";
            btnSchimbaCuloarea.UseVisualStyleBackColor = false;
            btnSchimbaCuloarea.Click += btnSchimbaCuloarea_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(315, 33);
            label1.Name = "label1";
            label1.Size = new Size(160, 35);
            label1.TabIndex = 1;
            label1.Text = "Mini Game";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnSchimbaCuloarea);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Paint += Form1_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button btnSchimbaCuloarea;
        private ColorDialog colorDialog1;
        private Label label1;
    }
}