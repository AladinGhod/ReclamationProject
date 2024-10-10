
namespace GestionReclamation
{
    partial class COI_F
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(COI_F));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.btnReclamation = new Guna.UI.WinForms.GunaButton();
            this.btnRecAtel = new Guna.UI.WinForms.GunaButton();
            this.btnLogout = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.AddPanelReclam = new Guna.UI.WinForms.GunaPanel();
            this.btnrefresh = new System.Windows.Forms.PictureBox();
            this.dGviewInter = new Zuby.ADGV.AdvancedDataGridView();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.labelRecl = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.reclamationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSReclamV1 = new GestionReclamation.DSReclamV1();
            this.reclamationTableAdapter = new GestionReclamation.DSReclamV1TableAdapters.ReclamationTableAdapter();
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.gunaElipsePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.AddPanelReclam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnrefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGviewInter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reclamationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReclamV1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gunaPanel1.Controls.Add(this.btnMinimize);
            this.gunaPanel1.Controls.Add(this.btnClose);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1561, 38);
            this.gunaPanel1.TabIndex = 75;
            this.gunaPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.YourForm_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1457, 7);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(23, 23);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimize.TabIndex = 57;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1488, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 23);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 56;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel2.BaseColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gunaElipsePanel2.Controls.Add(this.btnReclamation);
            this.gunaElipsePanel2.Controls.Add(this.btnRecAtel);
            this.gunaElipsePanel2.Controls.Add(this.btnLogout);
            this.gunaElipsePanel2.Controls.Add(this.pictureBox1);
            this.gunaElipsePanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaElipsePanel2.Location = new System.Drawing.Point(0, 38);
            this.gunaElipsePanel2.Margin = new System.Windows.Forms.Padding(2);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Radius = 2;
            this.gunaElipsePanel2.Size = new System.Drawing.Size(262, 794);
            this.gunaElipsePanel2.TabIndex = 74;
            this.gunaElipsePanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.YourForm_MouseDown);
            // 
            // btnReclamation
            // 
            this.btnReclamation.AnimationHoverSpeed = 0.07F;
            this.btnReclamation.AnimationSpeed = 0.03F;
            this.btnReclamation.BackColor = System.Drawing.Color.Transparent;
            this.btnReclamation.BaseColor = System.Drawing.Color.LightSkyBlue;
            this.btnReclamation.BorderColor = System.Drawing.Color.Black;
            this.btnReclamation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReclamation.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReclamation.FocusedColor = System.Drawing.Color.Empty;
            this.btnReclamation.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReclamation.ForeColor = System.Drawing.Color.Black;
            this.btnReclamation.Image = ((System.Drawing.Image)(resources.GetObject("btnReclamation.Image")));
            this.btnReclamation.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReclamation.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReclamation.Location = new System.Drawing.Point(0, 242);
            this.btnReclamation.Margin = new System.Windows.Forms.Padding(2);
            this.btnReclamation.Name = "btnReclamation";
            this.btnReclamation.OnHoverBaseColor = System.Drawing.Color.SteelBlue;
            this.btnReclamation.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReclamation.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReclamation.OnHoverImage = null;
            this.btnReclamation.OnPressedColor = System.Drawing.Color.Black;
            this.btnReclamation.Size = new System.Drawing.Size(258, 44);
            this.btnReclamation.TabIndex = 74;
            this.btnReclamation.Text = "RECLAMATION";
            this.btnReclamation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRecAtel
            // 
            this.btnRecAtel.AnimationHoverSpeed = 0.07F;
            this.btnRecAtel.AnimationSpeed = 0.03F;
            this.btnRecAtel.BackColor = System.Drawing.Color.Transparent;
            this.btnRecAtel.BaseColor = System.Drawing.Color.LightSkyBlue;
            this.btnRecAtel.BorderColor = System.Drawing.Color.Black;
            this.btnRecAtel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecAtel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRecAtel.FocusedColor = System.Drawing.Color.Empty;
            this.btnRecAtel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecAtel.ForeColor = System.Drawing.Color.Black;
            this.btnRecAtel.Image = ((System.Drawing.Image)(resources.GetObject("btnRecAtel.Image")));
            this.btnRecAtel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRecAtel.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRecAtel.Location = new System.Drawing.Point(0, 352);
            this.btnRecAtel.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecAtel.Name = "btnRecAtel";
            this.btnRecAtel.OnHoverBaseColor = System.Drawing.Color.SteelBlue;
            this.btnRecAtel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRecAtel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRecAtel.OnHoverImage = null;
            this.btnRecAtel.OnPressedColor = System.Drawing.Color.Black;
            this.btnRecAtel.Size = new System.Drawing.Size(258, 44);
            this.btnRecAtel.TabIndex = 73;
            this.btnRecAtel.Text = "RECLAMATION EXCEL";
            this.btnRecAtel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRecAtel.Click += new System.EventHandler(this.btnRecAtel_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.AnimationHoverSpeed = 0.07F;
            this.btnLogout.AnimationSpeed = 0.03F;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BaseColor = System.Drawing.Color.LightSkyBlue;
            this.btnLogout.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogout.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Image = global::GestionReclamation.Properties.Resources.se_deconnecter__2_;
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogout.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogout.Location = new System.Drawing.Point(0, 750);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnHoverBaseColor = System.Drawing.Color.SteelBlue;
            this.btnLogout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogout.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogout.OnHoverImage = null;
            this.btnLogout.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogout.Size = new System.Drawing.Size(262, 44);
            this.btnLogout.TabIndex = 72;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 20;
            this.gunaElipse1.TargetControl = this;
            // 
            // AddPanelReclam
            // 
            this.AddPanelReclam.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddPanelReclam.Controls.Add(this.btnrefresh);
            this.AddPanelReclam.Controls.Add(this.dGviewInter);
            this.AddPanelReclam.Controls.Add(this.pictureBox4);
            this.AddPanelReclam.Controls.Add(this.label14);
            this.AddPanelReclam.Controls.Add(this.panel1);
            this.AddPanelReclam.Controls.Add(this.label13);
            this.AddPanelReclam.Controls.Add(this.pictureBox3);
            this.AddPanelReclam.Controls.Add(this.lblRowCount);
            this.AddPanelReclam.Controls.Add(this.pictureBox2);
            this.AddPanelReclam.Controls.Add(this.label11);
            this.AddPanelReclam.Controls.Add(this.label);
            this.AddPanelReclam.Controls.Add(this.textBox7);
            this.AddPanelReclam.Controls.Add(this.label9);
            this.AddPanelReclam.Controls.Add(this.label10);
            this.AddPanelReclam.Controls.Add(this.textBox8);
            this.AddPanelReclam.Controls.Add(this.textBox13);
            this.AddPanelReclam.Controls.Add(this.label1);
            this.AddPanelReclam.Controls.Add(this.label6);
            this.AddPanelReclam.Controls.Add(this.textBox6);
            this.AddPanelReclam.Controls.Add(this.label2);
            this.AddPanelReclam.Controls.Add(this.label4);
            this.AddPanelReclam.Controls.Add(this.label3);
            this.AddPanelReclam.Controls.Add(this.label7);
            this.AddPanelReclam.Controls.Add(this.label8);
            this.AddPanelReclam.Controls.Add(this.textBox5);
            this.AddPanelReclam.Controls.Add(this.textBox4);
            this.AddPanelReclam.Controls.Add(this.textBox3);
            this.AddPanelReclam.Controls.Add(this.textBox2);
            this.AddPanelReclam.Controls.Add(this.textBox1);
            this.AddPanelReclam.Controls.Add(this.label5);
            this.AddPanelReclam.Font = new System.Drawing.Font("Verdana", 9F);
            this.AddPanelReclam.Location = new System.Drawing.Point(239, 33);
            this.AddPanelReclam.Name = "AddPanelReclam";
            this.AddPanelReclam.Size = new System.Drawing.Size(1319, 799);
            this.AddPanelReclam.TabIndex = 75;
            // 
            // btnrefresh
            // 
            this.btnrefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnrefresh.Image")));
            this.btnrefresh.Location = new System.Drawing.Point(394, 443);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(26, 26);
            this.btnrefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnrefresh.TabIndex = 106;
            this.btnrefresh.TabStop = false;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // dGviewInter
            // 
            this.dGviewInter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGviewInter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGviewInter.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGviewInter.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dGviewInter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGviewInter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGviewInter.FilterAndSortEnabled = true;
            this.dGviewInter.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dGviewInter.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dGviewInter.Location = new System.Drawing.Point(50, 506);
            this.dGviewInter.MaxFilterButtonImageHeight = 23;
            this.dGviewInter.Name = "dGviewInter";
            this.dGviewInter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGviewInter.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGviewInter.RowHeadersWidth = 51;
            this.dGviewInter.Size = new System.Drawing.Size(1163, 236);
            this.dGviewInter.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dGviewInter.TabIndex = 105;
            this.dGviewInter.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGviewInter_CellClick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(988, 419);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 103;
            this.pictureBox4.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(878, 355);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(223, 18);
            this.label14.TabIndex = 102;
            this.label14.Text = "Durée reclamation ouvert:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.labelRecl);
            this.panel1.Location = new System.Drawing.Point(559, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 108);
            this.panel1.TabIndex = 101;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(25, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 18);
            this.label12.TabIndex = 87;
            this.label12.Text = "Etat Reclamation";
            // 
            // labelRecl
            // 
            this.labelRecl.AutoSize = true;
            this.labelRecl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecl.Location = new System.Drawing.Point(28, 61);
            this.labelRecl.Name = "labelRecl";
            this.labelRecl.Size = new System.Drawing.Size(0, 20);
            this.labelRecl.TabIndex = 88;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(878, 385);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 18);
            this.label13.TabIndex = 100;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(262, 142);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 99;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lblRowCount
            // 
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRowCount.ForeColor = System.Drawing.Color.Red;
            this.lblRowCount.Location = new System.Drawing.Point(93, 443);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(30, 18);
            this.lblRowCount.TabIndex = 98;
            this.lblRowCount.Text = "**";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1426, 280);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 96;
            this.pictureBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(858, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 20);
            this.label11.TabIndex = 95;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(854, 140);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(127, 20);
            this.label.TabIndex = 94;
            this.label.Text = "Reclamation";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.Location = new System.Drawing.Point(559, 145);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(227, 26);
            this.textBox7.TabIndex = 93;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(560, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 18);
            this.label9.TabIndex = 92;
            this.label9.Text = "Date Reclamation";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(561, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 18);
            this.label10.TabIndex = 91;
            this.label10.Text = "Date Traitement";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.White;
            this.textBox8.Location = new System.Drawing.Point(559, 207);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(227, 26);
            this.textBox8.TabIndex = 90;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.Color.White;
            this.textBox13.Location = new System.Drawing.Point(115, 294);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(134, 26);
            this.textBox13.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 84;
            this.label1.Text = "Quantité";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 83;
            this.label6.Text = "Statut";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(310, 294);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(134, 26);
            this.textBox6.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 81;
            this.label2.Text = "Banc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 80;
            this.label4.Text = "Produit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 18);
            this.label3.TabIndex = 79;
            this.label3.Text = "Date Livraison";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(124, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 78;
            this.label7.Text = "Atelier";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(124, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 18);
            this.label8.TabIndex = 77;
            this.label8.Text = "OF";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(310, 141);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(134, 26);
            this.textBox5.TabIndex = 76;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(116, 373);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(336, 26);
            this.textBox4.TabIndex = 75;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(310, 222);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(134, 26);
            this.textBox3.TabIndex = 74;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(112, 222);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(134, 26);
            this.textBox2.TabIndex = 73;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(112, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(134, 26);
            this.textBox1.TabIndex = 72;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(504, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(401, 34);
            this.label5.TabIndex = 13;
            this.label5.Text = "GESTION RECLAMATION";
            // 
            // reclamationBindingSource
            // 
            this.reclamationBindingSource.DataMember = "Reclamation";
            this.reclamationBindingSource.DataSource = this.dSReclamV1;
            // 
            // dSReclamV1
            // 
            this.dSReclamV1.DataSetName = "DSReclamV1";
            this.dSReclamV1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reclamationTableAdapter
            // 
            this.reclamationTableAdapter.ClearBeforeFill = true;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 20;
            this.gunaElipse2.TargetControl = this;
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.Radius = 5;
            this.gunaElipse3.TargetControl = this;
            // 
            // COI_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1561, 832);
            this.Controls.Add(this.gunaElipsePanel2);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.AddPanelReclam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "COI_F";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COI_F";
            this.Load += new System.EventHandler(this.COI_F_Load);
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.gunaElipsePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.AddPanelReclam.ResumeLayout(false);
            this.AddPanelReclam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnrefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGviewInter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reclamationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReclamV1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMinimize;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private Guna.UI.WinForms.GunaButton btnReclamation;
        private Guna.UI.WinForms.GunaButton btnRecAtel;
        private Guna.UI.WinForms.GunaButton btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel AddPanelReclam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label labelRecl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DSReclamV1 dSReclamV1;
        private System.Windows.Forms.BindingSource reclamationBindingSource;
        private DSReclamV1TableAdapters.ReclamationTableAdapter reclamationTableAdapter;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private System.Windows.Forms.Label lblRowCount;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Zuby.ADGV.AdvancedDataGridView dGviewInter;
        private System.Windows.Forms.PictureBox btnrefresh;
    }
}