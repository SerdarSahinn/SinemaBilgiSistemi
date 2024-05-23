namespace _220601006_SERDARŞAHİN_FinalProjesi
{
    partial class Filmer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Filmer));
            DataGridView = new DataGridView();
            filmlerbtn = new Button();
            button1 = new Button();
            filmadıaratxt = new Button();
            geridonbtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DataGridView
            // 
            DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(201, 22);
            DataGridView.Name = "DataGridView";
            DataGridView.RowHeadersWidth = 51;
            DataGridView.RowTemplate.Height = 29;
            DataGridView.Size = new Size(895, 426);
            DataGridView.TabIndex = 5;
            // 
            // filmlerbtn
            // 
            filmlerbtn.BackColor = Color.SaddleBrown;
            filmlerbtn.Location = new Point(27, 57);
            filmlerbtn.Name = "filmlerbtn";
            filmlerbtn.Size = new Size(146, 69);
            filmlerbtn.TabIndex = 4;
            filmlerbtn.Text = "Filmler";
            filmlerbtn.UseVisualStyleBackColor = false;
            filmlerbtn.Click += filmlerbtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SaddleBrown;
            button1.Location = new Point(27, 331);
            button1.Name = "button1";
            button1.Size = new Size(146, 69);
            button1.TabIndex = 6;
            button1.Text = "Türe Göre Ara";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // filmadıaratxt
            // 
            filmadıaratxt.BackColor = Color.SaddleBrown;
            filmadıaratxt.Location = new Point(27, 196);
            filmadıaratxt.Name = "filmadıaratxt";
            filmadıaratxt.Size = new Size(146, 69);
            filmadıaratxt.TabIndex = 7;
            filmadıaratxt.Text = "Film Adı Ara";
            filmadıaratxt.UseVisualStyleBackColor = false;
            filmadıaratxt.Click += filmadıaratxt_Click;
            // 
            // geridonbtn
            // 
            geridonbtn.BackColor = Color.SaddleBrown;
            geridonbtn.Location = new Point(12, 428);
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
            pictureBox1.Location = new Point(99, 428);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Filmer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1099, 510);
            Controls.Add(pictureBox1);
            Controls.Add(geridonbtn);
            Controls.Add(filmadıaratxt);
            Controls.Add(button1);
            Controls.Add(DataGridView);
            Controls.Add(filmlerbtn);
            Name = "Filmer";
            Text = "Filmer";
            Load += Filmer_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGridView;
        private Button filmlerbtn;
        private Button button1;
        private Button filmadıaratxt;
        private Button geridonbtn;
        private PictureBox pictureBox1;
    }
}