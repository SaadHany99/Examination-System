namespace ITI_Examination_System
{
    partial class GetStudentsByTrackReportPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetStudentsByTrackReportPage));
            rv = new Microsoft.Reporting.WinForms.ReportViewer();
            show_report_btn = new MaterialSkin.Controls.MaterialButton();
            back_btn = new Button();
            tracks_cb = new MaterialSkin.Controls.MaterialComboBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // rv
            // 
            rv.Location = new Point(300, 64);
            rv.Margin = new Padding(3, 4, 3, 4);
            rv.Name = "ReportViewer";
            rv.ServerReport.BearerToken = null;
            rv.Size = new Size(2000, 2000);
            rv.TabIndex = 0;
            // 
            // show_report_btn
            // 
            show_report_btn.AutoSize = false;
            show_report_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            show_report_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            show_report_btn.Depth = 0;
            show_report_btn.HighEmphasis = true;
            show_report_btn.Icon = null;
            show_report_btn.Location = new Point(99, 294);
            show_report_btn.Margin = new Padding(5);
            show_report_btn.MouseState = MaterialSkin.MouseState.HOVER;
            show_report_btn.Name = "show_report_btn";
            show_report_btn.NoAccentTextColor = Color.Empty;
            show_report_btn.Size = new Size(101, 49);
            show_report_btn.TabIndex = 12;
            show_report_btn.Text = "Show";
            show_report_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            show_report_btn.UseAccentColor = false;
            show_report_btn.UseVisualStyleBackColor = true;
            show_report_btn.Click += show_report_btn_Click;
            // 
            // back_btn
            // 
            back_btn.BackColor = SystemColors.ButtonFace;
            back_btn.BackgroundImage = Properties.Resources.left_arrow;
            back_btn.BackgroundImageLayout = ImageLayout.Zoom;
            back_btn.FlatAppearance.BorderColor = Color.Black;
            back_btn.FlatAppearance.BorderSize = 0;
            back_btn.FlatStyle = FlatStyle.Flat;
            back_btn.Location = new Point(17, 85);
            back_btn.Margin = new Padding(3, 4, 3, 4);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(38, 35);
            back_btn.TabIndex = 14;
            back_btn.UseVisualStyleBackColor = false;
            back_btn.Click += back_btn_Click;
            // 
            // tracks_cb
            // 
            tracks_cb.AutoResize = false;
            tracks_cb.BackColor = Color.FromArgb(255, 255, 255);
            tracks_cb.Depth = 0;
            tracks_cb.DrawMode = DrawMode.OwnerDrawVariable;
            tracks_cb.DropDownHeight = 174;
            tracks_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            tracks_cb.DropDownWidth = 121;
            tracks_cb.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            tracks_cb.ForeColor = Color.FromArgb(222, 0, 0, 0);
            tracks_cb.FormattingEnabled = true;
            tracks_cb.IntegralHeight = false;
            tracks_cb.ItemHeight = 43;
            tracks_cb.Location = new Point(31, 215);
            tracks_cb.MaxDropDownItems = 4;
            tracks_cb.MouseState = MaterialSkin.MouseState.OUT;
            tracks_cb.Name = "tracks_cb";
            tracks_cb.Size = new Size(229, 49);
            tracks_cb.StartIndex = 0;
            tracks_cb.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 165);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 16;
            label1.Text = "Track Name";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Nerd_amico1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(1, 368);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 327);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // GetStudentsByTrackReportPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1625, 694);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(tracks_cb);
            Controls.Add(back_btn);
            Controls.Add(show_report_btn);
            Controls.Add(rv);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "GetStudentsByTrackReportPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Track Students";
            Load += ReportPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv;
        private MaterialSkin.Controls.MaterialButton show_report_btn;
        private Button back_btn;
        private MaterialSkin.Controls.MaterialComboBox tracks_cb;
        private Label label1;
        private PictureBox pictureBox1;
    }
}