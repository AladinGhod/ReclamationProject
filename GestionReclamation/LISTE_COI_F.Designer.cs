
namespace GestionReclamation
{
    partial class LISTE_COI_F
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LISTE_COI_F));
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            this.lbReclCount = new System.Windows.Forms.Label();
            this.DataGridView = new Zuby.ADGV.AdvancedDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcelRej = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExcel = new Guna.UI.WinForms.GunaButton();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.btnAfficher = new Guna.UI.WinForms.GunaButton();
            this.btnAffReject = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(218, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(368, 36);
            this.label5.TabIndex = 76;
            this.label5.Text = "LISTE RECLAMATION";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.FilterAndSortEnabled = true;
            this.dataGridView1.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(19, 139);
            this.dataGridView1.MaxFilterButtonImageHeight = 23;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(739, 167);
            this.dataGridView1.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dataGridView1.TabIndex = 80;
            // 
            // lbReclCount
            // 
            this.lbReclCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbReclCount.AutoSize = true;
            this.lbReclCount.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReclCount.ForeColor = System.Drawing.Color.Red;
            this.lbReclCount.Location = new System.Drawing.Point(354, 98);
            this.lbReclCount.Name = "lbReclCount";
            this.lbReclCount.Size = new System.Drawing.Size(180, 18);
            this.lbReclCount.TabIndex = 81;
            this.lbReclCount.Text = "Reclamation ouvert : 0";
            // 
            // DataGridView
            // 
            this.DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.FilterAndSortEnabled = true;
            this.DataGridView.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.DataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataGridView.Location = new System.Drawing.Point(19, 371);
            this.DataGridView.MaxFilterButtonImageHeight = 23;
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.Size = new System.Drawing.Size(739, 127);
            this.DataGridView.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.DataGridView.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(350, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 18);
            this.label1.TabIndex = 83;
            this.label1.Text = "Reclamation rejetee : 0";
            // 
            // btnExcelRej
            // 
            this.btnExcelRej.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcelRej.AnimationHoverSpeed = 0.07F;
            this.btnExcelRej.AnimationSpeed = 0.03F;
            this.btnExcelRej.BackColor = System.Drawing.Color.Transparent;
            this.btnExcelRej.BaseColor = System.Drawing.Color.White;
            this.btnExcelRej.BorderColor = System.Drawing.Color.Black;
            this.btnExcelRej.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcelRej.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExcelRej.FocusedColor = System.Drawing.Color.Empty;
            this.btnExcelRej.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcelRej.ForeColor = System.Drawing.Color.Black;
            this.btnExcelRej.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelRej.Image")));
            this.btnExcelRej.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExcelRej.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExcelRej.Location = new System.Drawing.Point(638, 311);
            this.btnExcelRej.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcelRej.Name = "btnExcelRej";
            this.btnExcelRej.OnHoverBaseColor = System.Drawing.Color.LightSeaGreen;
            this.btnExcelRej.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExcelRej.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExcelRej.OnHoverImage = null;
            this.btnExcelRej.OnPressedColor = System.Drawing.Color.Black;
            this.btnExcelRej.Radius = 10;
            this.btnExcelRej.Size = new System.Drawing.Size(40, 35);
            this.btnExcelRej.TabIndex = 84;
            this.btnExcelRej.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExcelRej.Click += new System.EventHandler(this.btnExcelRej_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.AnimationHoverSpeed = 0.07F;
            this.btnExcel.AnimationSpeed = 0.03F;
            this.btnExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExcel.BaseColor = System.Drawing.Color.White;
            this.btnExcel.BorderColor = System.Drawing.Color.Black;
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExcel.FocusedColor = System.Drawing.Color.Empty;
            this.btnExcel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExcel.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExcel.Location = new System.Drawing.Point(638, 54);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.OnHoverBaseColor = System.Drawing.Color.LightSeaGreen;
            this.btnExcel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExcel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExcel.OnHoverImage = null;
            this.btnExcel.OnPressedColor = System.Drawing.Color.Black;
            this.btnExcel.Radius = 10;
            this.btnExcel.Size = new System.Drawing.Size(40, 35);
            this.btnExcel.TabIndex = 78;
            this.btnExcel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // dateFrom
            // 
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(194, 64);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(156, 22);
            this.dateFrom.TabIndex = 85;
            this.dateFrom.Value = new System.DateTime(2024, 7, 18, 15, 28, 46, 0);
            // 
            // dateTo
            // 
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Location = new System.Drawing.Point(366, 64);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(156, 22);
            this.dateTo.TabIndex = 86;
            this.dateTo.Value = new System.DateTime(2024, 7, 18, 15, 28, 46, 0);
            // 
            // btnAfficher
            // 
            this.btnAfficher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAfficher.AnimationHoverSpeed = 0.07F;
            this.btnAfficher.AnimationSpeed = 0.03F;
            this.btnAfficher.BackColor = System.Drawing.Color.Transparent;
            this.btnAfficher.BaseColor = System.Drawing.Color.White;
            this.btnAfficher.BorderColor = System.Drawing.Color.Black;
            this.btnAfficher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAfficher.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAfficher.FocusedColor = System.Drawing.Color.Empty;
            this.btnAfficher.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfficher.ForeColor = System.Drawing.Color.Black;
            this.btnAfficher.Image = ((System.Drawing.Image)(resources.GetObject("btnAfficher.Image")));
            this.btnAfficher.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAfficher.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAfficher.Location = new System.Drawing.Point(583, 54);
            this.btnAfficher.Margin = new System.Windows.Forms.Padding(2);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.OnHoverBaseColor = System.Drawing.Color.LightSeaGreen;
            this.btnAfficher.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAfficher.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAfficher.OnHoverImage = null;
            this.btnAfficher.OnPressedColor = System.Drawing.Color.Black;
            this.btnAfficher.Radius = 10;
            this.btnAfficher.Size = new System.Drawing.Size(40, 35);
            this.btnAfficher.TabIndex = 87;
            this.btnAfficher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // btnAffReject
            // 
            this.btnAffReject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAffReject.AnimationHoverSpeed = 0.07F;
            this.btnAffReject.AnimationSpeed = 0.03F;
            this.btnAffReject.BackColor = System.Drawing.Color.Transparent;
            this.btnAffReject.BaseColor = System.Drawing.Color.White;
            this.btnAffReject.BorderColor = System.Drawing.Color.Black;
            this.btnAffReject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAffReject.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAffReject.FocusedColor = System.Drawing.Color.Empty;
            this.btnAffReject.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAffReject.ForeColor = System.Drawing.Color.Black;
            this.btnAffReject.Image = ((System.Drawing.Image)(resources.GetObject("btnAffReject.Image")));
            this.btnAffReject.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAffReject.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAffReject.Location = new System.Drawing.Point(583, 311);
            this.btnAffReject.Margin = new System.Windows.Forms.Padding(2);
            this.btnAffReject.Name = "btnAffReject";
            this.btnAffReject.OnHoverBaseColor = System.Drawing.Color.LightSeaGreen;
            this.btnAffReject.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAffReject.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAffReject.OnHoverImage = null;
            this.btnAffReject.OnPressedColor = System.Drawing.Color.Black;
            this.btnAffReject.Radius = 10;
            this.btnAffReject.Size = new System.Drawing.Size(40, 35);
            this.btnAffReject.TabIndex = 88;
            this.btnAffReject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAffReject.Click += new System.EventHandler(this.btnAffReject_Click);
            // 
            // LISTE_COI_F
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(796, 513);
            this.ControlBox = false;
            this.Controls.Add(this.btnAffReject);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.btnExcelRej);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.lbReclCount);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LISTE_COI_F";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LISTE_COI_F_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaButton btnExcel;
        private System.Windows.Forms.Label label5;
        private Zuby.ADGV.AdvancedDataGridView dataGridView1;
        private System.Windows.Forms.Label lbReclCount;
        private Zuby.ADGV.AdvancedDataGridView DataGridView;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnExcelRej;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
        private Guna.UI.WinForms.GunaButton btnAfficher;
        private Guna.UI.WinForms.GunaButton btnAffReject;
    }
}