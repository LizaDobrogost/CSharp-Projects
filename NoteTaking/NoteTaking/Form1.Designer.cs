namespace NoteTaking
{
    partial class Form1
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
            this.Title = new System.Windows.Forms.Label();
            this.Massage = new System.Windows.Forms.Label();
            this.texttitle = new System.Windows.Forms.TextBox();
            this.textmassage = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttnew = new System.Windows.Forms.Button();
            this.butsave = new System.Windows.Forms.Button();
            this.butread = new System.Windows.Forms.Button();
            this.butdelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(37, 287);
            this.Title.MaximumSize = new System.Drawing.Size(100, 50);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(100, 50);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title";
            this.Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // Massage
            // 
            this.Massage.AutoSize = true;
            this.Massage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Massage.Location = new System.Drawing.Point(37, 437);
            this.Massage.Name = "Massage";
            this.Massage.Size = new System.Drawing.Size(150, 38);
            this.Massage.TabIndex = 1;
            this.Massage.Text = "Massage";
            this.Massage.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // texttitle
            // 
            this.texttitle.Location = new System.Drawing.Point(192, 287);
            this.texttitle.Name = "texttitle";
            this.texttitle.Size = new System.Drawing.Size(363, 35);
            this.texttitle.TabIndex = 2;
            // 
            // textmassage
            // 
            this.textmassage.Location = new System.Drawing.Point(192, 431);
            this.textmassage.Multiline = true;
            this.textmassage.Name = "textmassage";
            this.textmassage.Size = new System.Drawing.Size(363, 218);
            this.textmassage.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(736, 287);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 92;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(398, 362);
            this.dataGridView1.TabIndex = 4;
            // 
            // buttnew
            // 
            this.buttnew.BackColor = System.Drawing.Color.OldLace;
            this.buttnew.Location = new System.Drawing.Point(155, 771);
            this.buttnew.Name = "buttnew";
            this.buttnew.Size = new System.Drawing.Size(136, 57);
            this.buttnew.TabIndex = 5;
            this.buttnew.Text = "New";
            this.buttnew.UseVisualStyleBackColor = false;
            this.buttnew.Click += new System.EventHandler(this.buttnew_Click);
            // 
            // butsave
            // 
            this.butsave.BackColor = System.Drawing.Color.OldLace;
            this.butsave.Location = new System.Drawing.Point(419, 771);
            this.butsave.Name = "butsave";
            this.butsave.Size = new System.Drawing.Size(136, 57);
            this.butsave.TabIndex = 6;
            this.butsave.Text = "Save";
            this.butsave.UseVisualStyleBackColor = false;
            this.butsave.Click += new System.EventHandler(this.butsave_Click);
            // 
            // butread
            // 
            this.butread.BackColor = System.Drawing.Color.OldLace;
            this.butread.Location = new System.Drawing.Point(694, 771);
            this.butread.Name = "butread";
            this.butread.Size = new System.Drawing.Size(136, 57);
            this.butread.TabIndex = 7;
            this.butread.Text = "Read";
            this.butread.UseVisualStyleBackColor = false;
            this.butread.Click += new System.EventHandler(this.butread_Click);
            // 
            // butdelete
            // 
            this.butdelete.BackColor = System.Drawing.Color.OldLace;
            this.butdelete.Location = new System.Drawing.Point(972, 771);
            this.butdelete.Name = "butdelete";
            this.butdelete.Size = new System.Drawing.Size(136, 57);
            this.butdelete.TabIndex = 8;
            this.butdelete.Text = "Delete";
            this.butdelete.UseVisualStyleBackColor = false;
            this.butdelete.Click += new System.EventHandler(this.butdelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 100);
            this.label1.TabIndex = 9;
            this.label1.Text = "Note App";
            this.label1.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1287, 922);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butdelete);
            this.Controls.Add(this.butread);
            this.Controls.Add(this.butsave);
            this.Controls.Add(this.buttnew);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textmassage);
            this.Controls.Add(this.texttitle);
            this.Controls.Add(this.Massage);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Massage;
        private System.Windows.Forms.TextBox texttitle;
        private System.Windows.Forms.TextBox textmassage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttnew;
        private System.Windows.Forms.Button butsave;
        private System.Windows.Forms.Button butread;
        private System.Windows.Forms.Button butdelete;
        private System.Windows.Forms.Label label1;
    }
}

