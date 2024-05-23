namespace _220601006_SERDARŞAHİN_FinalProjesi
{
    partial class FilmTuru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmTuru));
            dataGridView1 = new DataGridView();
            tureslesmebtn = new Button();
            Turadıtxt = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            geridonbtn = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(252, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(826, 390);
            dataGridView1.TabIndex = 6;
            // 
            // tureslesmebtn
            // 
            tureslesmebtn.BackColor = Color.SaddleBrown;
            tureslesmebtn.Location = new Point(29, 130);
            tureslesmebtn.Name = "tureslesmebtn";
            tureslesmebtn.Size = new Size(136, 60);
            tureslesmebtn.TabIndex = 5;
            tureslesmebtn.Text = "Filmleri Getir";
            tureslesmebtn.UseVisualStyleBackColor = false;
            tureslesmebtn.Click += tureslesmebtn_Click;
            // 
            // Turadıtxt
            // 
            Turadıtxt.Location = new Point(109, 51);
            Turadıtxt.Name = "Turadıtxt";
            Turadıtxt.Size = new Size(125, 27);
            Turadıtxt.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 58);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 7;
            label1.Text = "Film Türü";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(161, 130);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // geridonbtn
            // 
            geridonbtn.BackColor = Color.SaddleBrown;
            geridonbtn.Location = new Point(11, 358);
            geridonbtn.Name = "geridonbtn";
            geridonbtn.Size = new Size(94, 38);
            geridonbtn.TabIndex = 9;
            geridonbtn.Text = "Geri Dön";
            geridonbtn.UseVisualStyleBackColor = false;
            geridonbtn.Click += geridonbtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(100, 358);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // FilmTuru
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1081, 408);
            Controls.Add(pictureBox2);
            Controls.Add(geridonbtn);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(tureslesmebtn);
            Controls.Add(Turadıtxt);
            Name = "FilmTuru";
            Text = "FilmTuru";
            Load += FilmTuru_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button tureslesmebtn;
        private TextBox Turadıtxt;
        private Label label1;
        private PictureBox pictureBox1;
        private Button geridonbtn;
        private PictureBox pictureBox2;
    }
}