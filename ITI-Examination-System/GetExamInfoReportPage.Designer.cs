namespace ExamQuestionsAndChoices
{
    partial class GetExamInfoReportPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetExamInfoReportPage));
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            show_btn = new MaterialSkin.Controls.MaterialButton();
            exam_cb = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            back_btn = new Button();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reportViewer1.Location = new Point(0, 122);
            reportViewer1.Margin = new Padding(3, 2, 3, 2);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(2424, 679);
            reportViewer1.TabIndex = 0;
            // 
            // show_btn
            // 
            show_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            show_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            show_btn.Depth = 0;
            show_btn.HighEmphasis = true;
            show_btn.Icon = null;
            show_btn.Location = new Point(823, 74);
            show_btn.Margin = new Padding(4, 4, 4, 4);
            show_btn.MouseState = MaterialSkin.MouseState.HOVER;
            show_btn.Name = "show_btn";
            show_btn.NoAccentTextColor = Color.Empty;
            show_btn.Size = new Size(64, 36);
            show_btn.TabIndex = 13;
            show_btn.Text = "Show";
            show_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            show_btn.UseAccentColor = false;
            show_btn.UseVisualStyleBackColor = true;
            show_btn.Click += show_btn_click;
            // 
            // exam_cb
            // 
            exam_cb.AutoResize = false;
            exam_cb.BackColor = Color.FromArgb(255, 255, 255);
            exam_cb.Depth = 0;
            exam_cb.DrawMode = DrawMode.OwnerDrawVariable;
            exam_cb.DropDownHeight = 174;
            exam_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            exam_cb.DropDownWidth = 121;
            exam_cb.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            exam_cb.ForeColor = Color.FromArgb(222, 0, 0, 0);
            exam_cb.FormattingEnabled = true;
            exam_cb.IntegralHeight = false;
            exam_cb.ItemHeight = 43;
            exam_cb.Location = new Point(582, 74);
            exam_cb.Margin = new Padding(3, 2, 3, 2);
            exam_cb.MaxDropDownItems = 4;
            exam_cb.MouseState = MaterialSkin.MouseState.OUT;
            exam_cb.Name = "exam_cb";
            exam_cb.Size = new Size(201, 49);
            exam_cb.StartIndex = 0;
            exam_cb.TabIndex = 15;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(469, 86);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(91, 19);
            materialLabel1.TabIndex = 16;
            materialLabel1.Text = "Exam Name:";
            // 
            // back_btn
            // 
            back_btn.BackColor = SystemColors.ButtonFace;
            back_btn.BackgroundImage = ITI_Examination_System.Properties.Resources.back_red_button_icon_227868;
            back_btn.BackgroundImageLayout = ImageLayout.Zoom;
            back_btn.FlatAppearance.BorderColor = Color.Black;
            back_btn.FlatAppearance.BorderSize = 0;
            back_btn.FlatStyle = FlatStyle.Flat;
            back_btn.Location = new Point(15, 64);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(29, 26);
            back_btn.TabIndex = 17;
            back_btn.UseVisualStyleBackColor = false;
            back_btn.Click += back_btn_Click;
            // 
            // GetExamInfoReportPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1213, 591);
            Controls.Add(back_btn);
            Controls.Add(materialLabel1);
            Controls.Add(exam_cb);
            Controls.Add(show_btn);
            Controls.Add(reportViewer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "GetExamInfoReportPage";
            Padding = new Padding(3, 48, 3, 2);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exam Information";
            Load += GetExamInfoReportPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MaterialSkin.Controls.MaterialButton show_btn;
        private MaterialSkin.Controls.MaterialComboBox exam_cb;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Button back_btn;
    }
}