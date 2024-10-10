
namespace GestionReclamation
{
    partial class REC_ATEL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REC_ATEL));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExcelRej = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridView = new Zuby.ADGV.AdvancedDataGridView();
            this.lbReclCount = new System.Windows.Forms.Label();
            this.dataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            this.btnExcel = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(219, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(368, 36);
            this.label5.TabIndex = 14;
            this.label5.Text = "LISTE RECLAMATION";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnExcelRej
            // 
            this.btnExcelRej.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.btnExcelRej.Location = new System.Drawing.Point(656, 305);
            this.btnExcelRej.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcelRej.Name = "btnExcelRej";
            this.btnExcelRej.OnHoverBaseColor = System.Drawing.Color.LightSeaGreen;
            this.btnExcelRej.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExcelRej.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExcelRej.OnHoverImage = null;
            this.btnExcelRej.OnPressedColor = System.Drawing.Color.Black;
            this.btnExcelRej.Radius = 10;
            this.btnExcelRej.Size = new System.Drawing.Size(119, 24);
            this.btnExcelRej.TabIndex = 90;
            this.btnExcelRej.Text = "Excel";
            this.btnExcelRej.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExcelRej.Click += new System.EventHandler(this.btnExcelRej_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(360, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 18);
            this.label1.TabIndex = 89;
            this.label1.Text = "Reclamation rejetee : 0";
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
            this.DataGridView.Location = new System.Drawing.Point(29, 346);
            this.DataGridView.MaxFilterButtonImageHeight = 23;
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.Size = new System.Drawing.Size(746, 127);
            this.DataGridView.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.DataGridView.TabIndex = 88;
            // 
            // lbReclCount
            // 
            this.lbReclCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbReclCount.AutoSize = true;
            this.lbReclCount.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReclCount.ForeColor = System.Drawing.Color.Red;
            this.lbReclCount.Location = new System.Drawing.Point(364, 101);
            this.lbReclCount.Name = "lbReclCount";
            this.lbReclCount.Size = new System.Drawing.Size(180, 18);
            this.lbReclCount.TabIndex = 87;
            this.lbReclCount.Text = "Reclamation ouvert : 0";
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
            this.dataGridView1.Location = new System.Drawing.Point(29, 142);
            this.dataGridView1.MaxFilterButtonImageHeight = 23;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(746, 139);
            this.dataGridView1.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dataGridView1.TabIndex = 86;
            // 
            // btnExcel
            // 
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
            this.btnExcel.Location = new System.Drawing.Point(656, 57);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.OnHoverBaseColor = System.Drawing.Color.LightSeaGreen;
            this.btnExcel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExcel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExcel.OnHoverImage = null;
            this.btnExcel.OnPressedColor = System.Drawing.Color.Black;
            this.btnExcel.Radius = 10;
            this.btnExcel.Size = new System.Drawing.Size(119, 35);
            this.btnExcel.TabIndex = 85;
            this.btnExcel.Text = "Excel";
            this.btnExcel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // REC_ATEL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(804, 531);
            this.ControlBox = false;
            this.Controls.Add(this.btnExcelRej);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.lbReclCount);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "REC_ATEL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.REC_ATEL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaButton btnExcelRej;
        private System.Windows.Forms.Label label1;
        private Zuby.ADGV.AdvancedDataGridView DataGridView;
        private System.Windows.Forms.Label lbReclCount;
        private Zuby.ADGV.AdvancedDataGridView dataGridView1;
        private Guna.UI.WinForms.GunaButton btnExcel;
    }
}