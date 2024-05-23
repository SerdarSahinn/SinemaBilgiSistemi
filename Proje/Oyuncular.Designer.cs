namespace _220601006_SERDARŞAHİN_FinalProjesi
{
    partial class Oyuncular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oyuncular));
            button1 = new Button();
            dataGridView1 = new DataGridView();
            oyuncuadtxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            oyuncusoyadtxt = new TextBox();
            oyuncuilişkileribtn = new Button();
            pictureBox1 = new PictureBox();
            geridonbtn = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Location = new Point(133, 117);
            button1.Name = "button1";
            button1.Size = new Size(138, 66);
            button1.TabIndex = 0;
            button1.Text = "Oyuncuyu Ara";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(284, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(896, 342);
            dataGridView1.TabIndex = 1;
            // 
            // oyuncuadtxt
            // 
            oyuncuadtxt.Location = new Point(133, 21);
            oyuncuadtxt.Name = "oyuncuadtxt";
            oyuncuadtxt.Size = new Size(125, 27);
            oyuncuadtxt.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 28);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 3;
            label1.Text = "Oyuncu Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 77);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 5;
            label2.Text = "Oyuncu Soyadı";
            // 
            // oyuncusoyadtxt
            // 
            oyuncusoyadtxt.Location = new Point(133, 74);
            oyuncusoyadtxt.Name = "oyuncusoyadtxt";
            oyuncusoyadtxt.Size = new Size(125, 27);
            oyuncusoyadtxt.TabIndex = 4;
            // 
            // oyuncuilişkileribtn
            // 
            oyuncuilişkileribtn.BackColor = Color.Lime;
            oyuncuilişkileribtn.Location = new Point(5, 222);
            oyuncuilişkileribtn.Name = "oyuncuilişkileribtn";
            oyuncuilişkileribtn.Size = new Size(150, 78);
            oyuncuilişkileribtn.TabIndex = 6;
            oyuncuilişkileribtn.Text = "Birlikte Aynı Filmde Oynayan Oyuncuların Listele";
            oyuncuilişkileribtn.UseVisualStyleBackColor = false;
            oyuncuilişkileribtn.Click += oyuncuilişkileribtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(153, 222);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // geridonbtn
            // 
            geridonbtn.BackColor = Color.SaddleBrown;
            geridonbtn.Location = new Point(5, 316);
            geridonbtn.Name = "geridonbtn";
            geridonbtn.Size = new Size(94, 38);
            geridonbtn.TabIndex = 10;
            geridonbtn.Text = "Geri Dön";
            geridonbtn.UseVisualStyleBackColor = false;
            geridonbtn.Click += geridonbtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(96, 316);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // Oyuncular
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1182, 371);
            Controls.Add(pictureBox2);
            Controls.Add(geridonbtn);
            Controls.Add(pictureBox1);
            Controls.Add(oyuncuilişkileribtn);
            Controls.Add(label2);
            Controls.Add(oyuncusoyadtxt);
            Controls.Add(label1);
            Controls.Add(oyuncuadtxt);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Oyuncular";
            Text = "Oyuncular";
            Load += Oyuncular_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private TextBox oyuncuadtxt;
        private Label label1;
        private Label label2;
        private TextBox oyuncusoyadtxt;
        private Button oyuncuilişkileribtn;
        private PictureBox pictureBox1;
        private Button geridonbtn;
        private PictureBox pictureBox2;
    }
}