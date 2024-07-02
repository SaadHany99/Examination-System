namespace ITI_Examination_System
{
    partial class AddQuestions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuestions));
            qheader_txt = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            tof_rb = new MaterialSkin.Controls.MaterialRadioButton();
            mc_rb = new MaterialSkin.Controls.MaterialRadioButton();
            c1_txt = new TextBox();
            c2_txt = new TextBox();
            c4_txt = new TextBox();
            c3_txt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            false_rb = new RadioButton();
            true_rb = new RadioButton();
            c4_rb = new RadioButton();
            c3_rb = new RadioButton();
            c2_rb = new RadioButton();
            c1_rb = new RadioButton();
            close_btn = new Button();
            add_btn = new MaterialSkin.Controls.MaterialButton();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            courses_cb = new MaterialSkin.Controls.MaterialComboBox();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            materialCard1.SuspendLayout();
            materialCard2.SuspendLayout();
            materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // qheader_txt
            // 
            qheader_txt.Location = new Point(19, 47);
            qheader_txt.Margin = new Padding(3, 4, 3, 4);
            qheader_txt.Name = "qheader_txt";
            qheader_txt.Size = new Size(729, 27);
            qheader_txt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(313, 19);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 1;
            label1.Text = "Question Header";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(tof_rb);
            groupBox1.Controls.Add(mc_rb);
            groupBox1.Location = new Point(14, 4);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(355, 92);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Question Type";
            // 
            // tof_rb
            // 
            tof_rb.AutoSize = true;
            tof_rb.Depth = 0;
            tof_rb.Location = new Point(18, 37);
            tof_rb.Margin = new Padding(0);
            tof_rb.MouseLocation = new Point(-1, -1);
            tof_rb.MouseState = MaterialSkin.MouseState.HOVER;
            tof_rb.Name = "tof_rb";
            tof_rb.Ripple = true;
            tof_rb.Size = new Size(127, 37);
            tof_rb.TabIndex = 21;
            tof_rb.TabStop = true;
            tof_rb.Text = "True or False";
            tof_rb.UseVisualStyleBackColor = true;
            tof_rb.CheckedChanged += rb_CheckedChanged;
            // 
            // mc_rb
            // 
            mc_rb.AutoSize = true;
            mc_rb.Depth = 0;
            mc_rb.Location = new Point(179, 37);
            mc_rb.Margin = new Padding(0);
            mc_rb.MouseLocation = new Point(-1, -1);
            mc_rb.MouseState = MaterialSkin.MouseState.HOVER;
            mc_rb.Name = "mc_rb";
            mc_rb.Ripple = true;
            mc_rb.Size = new Size(152, 37);
            mc_rb.TabIndex = 21;
            mc_rb.TabStop = true;
            mc_rb.Text = "Multiple Choices";
            mc_rb.UseVisualStyleBackColor = true;
            mc_rb.CheckedChanged += rb_CheckedChanged;
            // 
            // c1_txt
            // 
            c1_txt.Location = new Point(70, 503);
            c1_txt.Margin = new Padding(3, 4, 3, 4);
            c1_txt.Name = "c1_txt";
            c1_txt.Size = new Size(381, 27);
            c1_txt.TabIndex = 3;
            // 
            // c2_txt
            // 
            c2_txt.Location = new Point(464, 503);
            c2_txt.Margin = new Padding(3, 4, 3, 4);
            c2_txt.Name = "c2_txt";
            c2_txt.Size = new Size(373, 27);
            c2_txt.TabIndex = 19;
            // 
            // c4_txt
            // 
            c4_txt.Location = new Point(464, 589);
            c4_txt.Margin = new Padding(3, 4, 3, 4);
            c4_txt.Name = "c4_txt";
            c4_txt.Size = new Size(373, 27);
            c4_txt.TabIndex = 4;
            // 
            // c3_txt
            // 
            c3_txt.Location = new Point(70, 589);
            c3_txt.Margin = new Padding(3, 4, 3, 4);
            c3_txt.Name = "c3_txt";
            c3_txt.Size = new Size(381, 27);
            c3_txt.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(234, 467);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 7;
            label2.Text = "Choice 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(234, 553);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 8;
            label3.Text = "Choice 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(619, 467);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 9;
            label4.Text = "Choice 2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(619, 553);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 10;
            label5.Text = "Choice 4";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(false_rb);
            groupBox2.Controls.Add(true_rb);
            groupBox2.Controls.Add(c4_rb);
            groupBox2.Controls.Add(c3_rb);
            groupBox2.Controls.Add(c2_rb);
            groupBox2.Controls.Add(c1_rb);
            groupBox2.Location = new Point(14, 5);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(339, 91);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Model Answer";
            // 
            // false_rb
            // 
            false_rb.AutoSize = true;
            false_rb.Location = new Point(19, 57);
            false_rb.Margin = new Padding(3, 4, 3, 4);
            false_rb.Name = "false_rb";
            false_rb.Size = new Size(62, 24);
            false_rb.TabIndex = 5;
            false_rb.TabStop = true;
            false_rb.Text = "False";
            false_rb.UseVisualStyleBackColor = true;
            // 
            // true_rb
            // 
            true_rb.AutoSize = true;
            true_rb.Location = new Point(19, 27);
            true_rb.Margin = new Padding(3, 4, 3, 4);
            true_rb.Name = "true_rb";
            true_rb.Size = new Size(58, 24);
            true_rb.TabIndex = 4;
            true_rb.TabStop = true;
            true_rb.Text = "True";
            true_rb.UseVisualStyleBackColor = true;
            // 
            // c4_rb
            // 
            c4_rb.AutoSize = true;
            c4_rb.Location = new Point(230, 57);
            c4_rb.Margin = new Padding(3, 4, 3, 4);
            c4_rb.Name = "c4_rb";
            c4_rb.Size = new Size(87, 24);
            c4_rb.TabIndex = 3;
            c4_rb.TabStop = true;
            c4_rb.Text = "Choice 4";
            c4_rb.UseVisualStyleBackColor = true;
            // 
            // c3_rb
            // 
            c3_rb.AutoSize = true;
            c3_rb.Location = new Point(120, 57);
            c3_rb.Margin = new Padding(3, 4, 3, 4);
            c3_rb.Name = "c3_rb";
            c3_rb.Size = new Size(87, 24);
            c3_rb.TabIndex = 2;
            c3_rb.TabStop = true;
            c3_rb.Text = "Choice 3";
            c3_rb.UseVisualStyleBackColor = true;
            // 
            // c2_rb
            // 
            c2_rb.AutoSize = true;
            c2_rb.Location = new Point(230, 28);
            c2_rb.Margin = new Padding(3, 4, 3, 4);
            c2_rb.Name = "c2_rb";
            c2_rb.Size = new Size(87, 24);
            c2_rb.TabIndex = 1;
            c2_rb.TabStop = true;
            c2_rb.Text = "Choice 2";
            c2_rb.UseVisualStyleBackColor = true;
            // 
            // c1_rb
            // 
            c1_rb.AutoSize = true;
            c1_rb.Location = new Point(120, 27);
            c1_rb.Margin = new Padding(3, 4, 3, 4);
            c1_rb.Name = "c1_rb";
            c1_rb.Size = new Size(87, 24);
            c1_rb.TabIndex = 0;
            c1_rb.TabStop = true;
            c1_rb.Text = "Choice 1";
            c1_rb.UseVisualStyleBackColor = true;
            // 
            // close_btn
            // 
            close_btn.BackColor = SystemColors.ButtonFace;
            close_btn.BackgroundImage = Properties.Resources.left_arrow;
            close_btn.BackgroundImageLayout = ImageLayout.Zoom;
            close_btn.FlatAppearance.BorderSize = 0;
            close_btn.FlatStyle = FlatStyle.Flat;
            close_btn.Location = new Point(13, 84);
            close_btn.Margin = new Padding(3, 4, 3, 4);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(48, 46);
            close_btn.TabIndex = 14;
            close_btn.UseVisualStyleBackColor = false;
            close_btn.Click += close_btn_Click;
            // 
            // add_btn
            // 
            add_btn.AutoSize = false;
            add_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            add_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            add_btn.Depth = 0;
            add_btn.HighEmphasis = true;
            add_btn.Icon = null;
            add_btn.Location = new Point(656, 648);
            add_btn.Margin = new Padding(5, 8, 5, 8);
            add_btn.MouseState = MaterialSkin.MouseState.HOVER;
            add_btn.Name = "add_btn";
            add_btn.NoAccentTextColor = Color.Empty;
            add_btn.Size = new Size(181, 43);
            add_btn.TabIndex = 15;
            add_btn.Text = "Add Question";
            add_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            add_btn.UseAccentColor = false;
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(qheader_txt);
            materialCard1.Controls.Add(label1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(69, 192);
            materialCard1.Margin = new Padding(16, 19, 16, 19);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(16, 19, 16, 19);
            materialCard1.Size = new Size(767, 112);
            materialCard1.TabIndex = 17;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(groupBox1);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(69, 323);
            materialCard2.Margin = new Padding(16, 19, 16, 19);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(16, 19, 16, 19);
            materialCard2.Size = new Size(382, 112);
            materialCard2.TabIndex = 18;
            // 
            // courses_cb
            // 
            courses_cb.AutoResize = false;
            courses_cb.BackColor = Color.FromArgb(255, 255, 255);
            courses_cb.Depth = 0;
            courses_cb.DrawMode = DrawMode.OwnerDrawVariable;
            courses_cb.DropDownHeight = 174;
            courses_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            courses_cb.DropDownWidth = 121;
            courses_cb.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            courses_cb.ForeColor = Color.FromArgb(222, 0, 0, 0);
            courses_cb.FormattingEnabled = true;
            courses_cb.IntegralHeight = false;
            courses_cb.ItemHeight = 43;
            courses_cb.Location = new Point(360, 125);
            courses_cb.Margin = new Padding(3, 4, 3, 4);
            courses_cb.MaxDropDownItems = 4;
            courses_cb.MouseState = MaterialSkin.MouseState.OUT;
            courses_cb.Name = "courses_cb";
            courses_cb.Size = new Size(250, 49);
            courses_cb.StartIndex = 0;
            courses_cb.TabIndex = 1;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(groupBox2);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(464, 323);
            materialCard3.Margin = new Padding(16, 19, 16, 19);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(16, 19, 16, 19);
            materialCard3.Size = new Size(372, 112);
            materialCard3.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(152, 134);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 22;
            label6.Text = "Course Name:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.question_mark_bubble_speech_sign_symbol_icon_3d_rendering_prev_ui1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(609, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 125);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.output_onlinegiftools__2_;
            pictureBox2.Location = new Point(609, 68);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(228, 125);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 52;
            pictureBox2.TabStop = false;
            // 
            // AddQuestions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(909, 719);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(materialCard3);
            Controls.Add(courses_cb);
            Controls.Add(close_btn);
            Controls.Add(materialCard2);
            Controls.Add(materialCard1);
            Controls.Add(add_btn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(c4_txt);
            Controls.Add(c3_txt);
            Controls.Add(c2_txt);
            Controls.Add(c1_txt);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddQuestions";
            Padding = new Padding(3, 85, 3, 4);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Questions";
            Load += AddQuestions_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox qheader_txt;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox c1_txt;
        private TextBox c2_txt;
        private TextBox c4_txt;
        private TextBox c3_txt;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox2;
        private RadioButton c4_rb;
        private RadioButton c3_rb;
        private RadioButton c2_rb;
        private RadioButton c1_rb;
        private RadioButton false_rb;
        private RadioButton true_rb;
        private Button close_btn;
        private MaterialSkin.Controls.MaterialButton add_btn;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialComboBox courses_cb;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialRadioButton tof_rb;
        private MaterialSkin.Controls.MaterialRadioButton mc_rb;
        private Label label6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}