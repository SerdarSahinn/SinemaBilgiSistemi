namespace _220601006_SERDARŞAHİN_FinalProjesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ÖZELLİKGİTBTN = new Button();
            oyuncubtn = new Button();
            Yonetmenbtn = new Button();
            filmbtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ÖZELLİKGİTBTN
            // 
            ÖZELLİKGİTBTN.BackColor = Color.SaddleBrown;
            ÖZELLİKGİTBTN.Location = new Point(12, 359);
            ÖZELLİKGİTBTN.Name = "ÖZELLİKGİTBTN";
            ÖZELLİKGİTBTN.Size = new Size(183, 79);
            ÖZELLİKGİTBTN.TabIndex = 0;
            ÖZELLİKGİTBTN.Text = "Yönetmen Ve Oyuncu ";
            ÖZELLİKGİTBTN.UseVisualStyleBackColor = false;
            ÖZELLİKGİTBTN.Click += ÖZELLİKGİTBTN_Click;
            // 
            // oyuncubtn
            // 
            oyuncubtn.BackColor = Color.SaddleBrown;
            oyuncubtn.Location = new Point(8, 139);
            oyuncubtn.Name = "oyuncubtn";
            oyuncubtn.Size = new Size(183, 79);
            oyuncubtn.TabIndex = 1;
            oyuncubtn.Text = "Oyuncular";
            oyuncubtn.UseVisualStyleBackColor = false;
            oyuncubtn.Click += oyuncubtn_Click;
            // 
            // Yonetmenbtn
            // 
            Yonetmenbtn.BackColor = Color.SaddleBrown;
            Yonetmenbtn.Location = new Point(8, 256);
            Yonetmenbtn.Name = "Yonetmenbtn";
            Yonetmenbtn.Size = new Size(183, 79);
            Yonetmenbtn.TabIndex = 2;
            Yonetmenbtn.Text = "Yönetmenler";
            Yonetmenbtn.UseVisualStyleBackColor = false;
            Yonetmenbtn.Click += Yonetmenbtn_Click;
            // 
            // filmbtn
            // 
            filmbtn.BackColor = Color.SaddleBrown;
            filmbtn.Location = new Point(8, 24);
            filmbtn.Name = "filmbtn";
            filmbtn.Size = new Size(183, 79);
            filmbtn.TabIndex = 3;
            filmbtn.Text = "Filmler";
            filmbtn.UseVisualStyleBackColor = false;
            filmbtn.Click += filmbtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(201, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(587, 446);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(filmbtn);
            Controls.Add(Yonetmenbtn);
            Controls.Add(oyuncubtn);
            Controls.Add(ÖZELLİKGİTBTN);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button ÖZELLİKGİTBTN;
        private Button oyuncubtn;
        private Button Yonetmenbtn;
        private Button filmbtn;
        private PictureBox pictureBox1;
    }
}