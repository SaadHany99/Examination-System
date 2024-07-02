namespace ITI_Examination_System
{
    partial class GetInstructorCoursesReportPage
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
            instReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            getdata = new MaterialSkin.Controls.MaterialButton();
            cm = new MaterialSkin.Controls.MaterialComboBox();
            back_btn = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // instReportViewer
            // 
            instReportViewer.BackColor = SystemColors.ButtonFace;
            instReportViewer.Location = new Point(300, 64);
            instReportViewer.Margin = new Padding(3, 4, 3, 4);
            instReportViewer.Name = "ReportViewer";
            instReportViewer.ServerReport.BearerToken = null;
            instReportViewer.Size = new Size(2000, 1999);
            instReportViewer.TabIndex = 0;
            // 
            // getdata
            // 
            getdata.AutoSize = false;
            getdata.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            getdata.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            getdata.Depth = 0;
            getdata.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            getdata.HighEmphasis = true;
            getdata.Icon = null;
            getdata.Location = new Point(103, 285);
            getdata.Margin = new Padding(5);
            getdata.MouseState = MaterialSkin.MouseState.HOVER;
            getdata.Name = "getdata";
            getdata.NoAccentTextColor = Color.Empty;
            getdata.Size = new Size(99, 51);
            getdata.TabIndex = 12;
            getdata.Text = "Show";
            getdata.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            getdata.UseAccentColor = false;
            getdata.UseVisualStyleBackColor = true;
            getdata.Click += getdata_Click;
            // 
            // cm
            // 
            cm.AutoResize = false;
            cm.BackColor = Color.FromArgb(255, 255, 255);
            cm.Depth = 0;
            cm.DrawMode = DrawMode.OwnerDrawVariable;
            cm.DropDownHeight = 174;
            cm.DropDownStyle = ComboBoxStyle.DropDownList;
            cm.DropDownWidth = 121;
            cm.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cm.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cm.FormattingEnabled = true;
            cm.IntegralHeight = false;
            cm.ItemHeight = 43;
            cm.Location = new Point(39, 213);
            cm.MaxDropDownItems = 4;
            cm.MouseState = MaterialSkin.MouseState.OUT;
            cm.Name = "cm";
            cm.Size = new Size(229, 49);
            cm.StartIndex = 0;
            cm.TabIndex = 14;
            // 
            // back_btn
            // 
            back_btn.BackColor = SystemColors.ButtonFace;
            back_btn.BackgroundImage = Properties.Resources.left_arrow;
            back_btn.BackgroundImageLayout = ImageLayout.Zoom;
            back_btn.FlatAppearance.BorderColor = Color.Black;
            back_btn.FlatAppearance.BorderSize = 0;
            back_btn.FlatStyle = FlatStyle.Flat;
            back_btn.Location = new Point(17, 83);
            back_btn.Margin = new Padding(3, 4, 3, 4);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(38, 32);
            back_btn.TabIndex = 16;
            back_btn.UseVisualStyleBackColor = false;
            back_btn.Click += back_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 160);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 17;
            label1.Text = "Instructor Name";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Bibliophile_amico;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(6, 373);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(293, 294);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // GetInstructorCoursesReportPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 694);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(back_btn);
            Controls.Add(cm);
            Controls.Add(getdata);
            Controls.Add(instReportViewer);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GetInstructorCoursesReportPage";
            Padding = new Padding(3, 85, 3, 4);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Instructor Courses";
            Load += InstructorCourses_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        //private Button getdata;
        private Microsoft.Reporting.WinForms.ReportViewer instReportViewer;
        private MaterialSkin.Controls.MaterialButton getdata;
        private MaterialSkin.Controls.MaterialComboBox cm;
        private Button back_btn;
        private Label label1;
        private PictureBox pictureBox1;
    }
}