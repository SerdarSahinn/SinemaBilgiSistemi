namespace _220601006_SERDARŞAHİN_FinalProjesi
{
    partial class yonetmen_oyuncu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yonetmen_oyuncu));
            label1 = new Label();
            filmsayısıbtn = new Button();
            Yonetmenadtxt = new TextBox();
            dataGridView1 = new DataGridView();
            geridonbtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 73);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 0;
            label1.Text = "Yönetmen Adı";
            // 
            // filmsayısıbtn
            // 
            filmsayısıbtn.BackColor = Color.SaddleBrown;
            filmsayısıbtn.Location = new Point(141, 130);
            filmsayısıbtn.Name = "filmsayısıbtn";
            filmsayısıbtn.Size = new Size(104, 40);
            filmsayısıbtn.TabIndex = 1;
            filmsayısıbtn.Text = "Listele ";
            filmsayısıbtn.UseVisualStyleBackColor = false;
            filmsayısıbtn.Click += filmsayısıbtn_Click;
            // 
            // Yonetmenadtxt
            // 
            Yonetmenadtxt.Location = new Point(131, 66);
            Yonetmenadtxt.Name = "Yonetmenadtxt";
            Yonetmenadtxt.Size = new Size(125, 27);
            Yonetmenadtxt.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(262, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(606, 237);
            dataGridView1.TabIndex = 3;
            // 
            // geridonbtn
            // 
            geridonbtn.BackColor = Color.SaddleBrown;
            geridonbtn.Location = new Point(12, 220);
            geridonbtn.Name = "geridonbtn";
            geridonbtn.Size = new Size(94, 38);
            geridonbtn.TabIndex = 10;
            geridonbtn.Text = "Geri Dön";
            geridonbtn.UseVisualStyleBackColor = false;
            geridonbtn.Click += geridonbtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(103, 220);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // yonetmen_oyuncu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(871, 284);
            Controls.Add(pictureBox1);
            Controls.Add(geridonbtn);
            Controls.Add(dataGridView1);
            Controls.Add(Yonetmenadtxt);
            Controls.Add(filmsayısıbtn);
            Controls.Add(label1);
            Name = "yonetmen_oyuncu";
            Text = "yonetmen_oyuncu";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button filmsayısıbtn;
        private TextBox Yonetmenadtxt;
        private DataGridView dataGridView1;
        private Button geridonbtn;
        private PictureBox pictureBox1;
    }
}