namespace MDB_ImageGallery
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.photoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageGalleryDataSet = new MDB_ImageGallery.ImageGalleryDataSet();
            this.photoTableAdapter = new MDB_ImageGallery.ImageGalleryDataSetTableAdapters.PhotoTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.lbHello = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblImageCategory = new System.Windows.Forms.Label();
            this.lblImageAccountName = new System.Windows.Forms.Label();
            this.lblImageId = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.photoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photopathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageGalleryDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.photoidDataGridViewTextBoxColumn,
            this.photopathDataGridViewTextBoxColumn,
            this.accountidDataGridViewTextBoxColumn,
            this.categoryidDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.photoBindingSource;
            this.dataGridView.GridColor = System.Drawing.Color.White;
            this.dataGridView.Location = new System.Drawing.Point(15, 134);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 100;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(406, 606);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // photoBindingSource
            // 
            this.photoBindingSource.DataMember = "Photo";
            this.photoBindingSource.DataSource = this.imageGalleryDataSet;
            // 
            // imageGalleryDataSet
            // 
            this.imageGalleryDataSet.DataSetName = "ImageGalleryDataSet";
            this.imageGalleryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // photoTableAdapter
            // 
            this.photoTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbImage);
            this.groupBox1.Location = new System.Drawing.Point(429, 122);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(874, 618);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(9, 26);
            this.pbImage.Margin = new System.Windows.Forms.Padding(4);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(858, 584);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.RosyBrown;
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(15, 79);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(116, 33);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.RosyBrown;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1192, 24);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 33);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(15, 44);
            this.txtImagePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(229, 27);
            this.txtImagePath.TabIndex = 4;
            this.txtImagePath.TextChanged += new System.EventHandler(this.txtImagePath_TextChanged);
            // 
            // lbHello
            // 
            this.lbHello.AutoSize = true;
            this.lbHello.BackColor = System.Drawing.Color.White;
            this.lbHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHello.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbHello.Location = new System.Drawing.Point(16, 15);
            this.lbHello.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHello.Name = "lbHello";
            this.lbHello.Size = new System.Drawing.Size(115, 25);
            this.lbHello.TabIndex = 5;
            this.lbHello.Text = "Hello, user !";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblImageCategory);
            this.groupBox2.Controls.Add(this.lblImageAccountName);
            this.groupBox2.Controls.Add(this.lblImageId);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBox2.Location = new System.Drawing.Point(429, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(592, 96);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image information:";
            // 
            // lblImageCategory
            // 
            this.lblImageCategory.AutoSize = true;
            this.lblImageCategory.Location = new System.Drawing.Point(294, 28);
            this.lblImageCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImageCategory.Name = "lblImageCategory";
            this.lblImageCategory.Size = new System.Drawing.Size(81, 20);
            this.lblImageCategory.TabIndex = 2;
            this.lblImageCategory.Text = "Category:";
            // 
            // lblImageAccountName
            // 
            this.lblImageAccountName.AutoSize = true;
            this.lblImageAccountName.Location = new System.Drawing.Point(9, 68);
            this.lblImageAccountName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImageAccountName.Name = "lblImageAccountName";
            this.lblImageAccountName.Size = new System.Drawing.Size(117, 20);
            this.lblImageAccountName.TabIndex = 1;
            this.lblImageAccountName.Text = "From account:";
            // 
            // lblImageId
            // 
            this.lblImageId.AutoSize = true;
            this.lblImageId.Location = new System.Drawing.Point(9, 28);
            this.lblImageId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImageId.Name = "lblImageId";
            this.lblImageId.Size = new System.Drawing.Size(81, 20);
            this.lblImageId.TabIndex = 0;
            this.lblImageId.Text = "Image ID:";
            // 
            // photoidDataGridViewTextBoxColumn
            // 
            this.photoidDataGridViewTextBoxColumn.DataPropertyName = "photo_id";
            this.photoidDataGridViewTextBoxColumn.HeaderText = "photo_id";
            this.photoidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.photoidDataGridViewTextBoxColumn.Name = "photoidDataGridViewTextBoxColumn";
            this.photoidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // photopathDataGridViewTextBoxColumn
            // 
            this.photopathDataGridViewTextBoxColumn.DataPropertyName = "photo_path";
            this.photopathDataGridViewTextBoxColumn.HeaderText = "photo_path";
            this.photopathDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.photopathDataGridViewTextBoxColumn.Name = "photopathDataGridViewTextBoxColumn";
            this.photopathDataGridViewTextBoxColumn.Visible = false;
            // 
            // accountidDataGridViewTextBoxColumn
            // 
            this.accountidDataGridViewTextBoxColumn.DataPropertyName = "account_id";
            this.accountidDataGridViewTextBoxColumn.HeaderText = "account_id";
            this.accountidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accountidDataGridViewTextBoxColumn.Name = "accountidDataGridViewTextBoxColumn";
            // 
            // categoryidDataGridViewTextBoxColumn
            // 
            this.categoryidDataGridViewTextBoxColumn.DataPropertyName = "category_id";
            this.categoryidDataGridViewTextBoxColumn.HeaderText = "category_id";
            this.categoryidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryidDataGridViewTextBoxColumn.Name = "categoryidDataGridViewTextBoxColumn";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1318, 755);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbHello);
            this.Controls.Add(this.txtImagePath);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Image Gallery";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageGalleryDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private ImageGalleryDataSet imageGalleryDataSet;
        private System.Windows.Forms.BindingSource photoBindingSource;
        private ImageGalleryDataSetTableAdapters.PhotoTableAdapter photoTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Label lbHello;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblImageCategory;
        private System.Windows.Forms.Label lblImageAccountName;
        private System.Windows.Forms.Label lblImageId;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photopathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryidDataGridViewTextBoxColumn;
    }
}