namespace _220601006_SERDARŞAHİN_FinalProjesi
{
    partial class Yonetmen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yonetmen));
            soyadtxt = new TextBox();
            label2 = new Label();
            Aratxt = new TextBox();
            label1 = new Label();
            listelebtn = new Button();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            geridonbtn = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // soyadtxt
            // 
            soyadtxt.Location = new Point(139, 86);
            soyadtxt.Name = "soyadtxt";
            soyadtxt.Size = new Size(125, 27);
            soyadtxt.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 89);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 9;
            label2.Text = "Yönetmen Soyadı";
            // 
            // Aratxt
            // 
            Aratxt.Location = new Point(139, 30);
            Aratxt.Name = "Aratxt";
            Aratxt.Size = new Size(125, 27);
            Aratxt.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 7;
            label1.Text = "Yönetmen Adı";
            // 
            // listelebtn
            // 
            listelebtn.BackColor = Color.SaddleBrown;
            listelebtn.Location = new Point(39, 166);
            listelebtn.Name = "listelebtn";
            listelebtn.Size = new Size(125, 51);
            listelebtn.TabIndex = 6;
            listelebtn.Text = "Listele";
            listelebtn.UseVisualStyleBackColor = false;
            listelebtn.Click += listelebtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(288, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(789, 356);
            dataGridView1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(160, 166);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // geridonbtn
            // 
            geridonbtn.BackColor = Color.SaddleBrown;
            geridonbtn.Location = new Point(12, 344);
            geridonbtn.Name = "geridonbtn";
            geridonbtn.Size = new Size(94, 38);
            geridonbtn.TabIndex = 13;
            geridonbtn.Text = "Geri Dön";
            geridonbtn.UseVisualStyleBackColor = false;
            geridonbtn.Click += geridonbtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(103, 344);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // Yonetmen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1086, 392);
            Controls.Add(pictureBox2);
            Controls.Add(geridonbtn);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(soyadtxt);
            Controls.Add(label2);
            Controls.Add(Aratxt);
            Controls.Add(label1);
            Controls.Add(listelebtn);
            Name = "Yonetmen";
            Text = "Yonetmen";
            Load += Yonetmen_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox soyadtxt;
        private Label label2;
        private TextBox Aratxt;
        private Label label1;
        private Button listelebtn;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Button geridonbtn;
        private PictureBox pictureBox2;
    }
}