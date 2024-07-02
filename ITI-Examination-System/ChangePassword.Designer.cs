namespace ITI_ExaminationSystem
{
    partial class Change_Password
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbl_new = new Label();
            close_btn = new Button();
            btn_changepassword = new MaterialSkin.Controls.MaterialButton();
            lbl_old = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            cb = new MaterialSkin.Controls.MaterialCheckbox();
            txt_oldpassword = new MaterialSkin.Controls.MaterialTextBox2();
            txt_newpassword = new MaterialSkin.Controls.MaterialTextBox2();
            txt_confirmpassword = new MaterialSkin.Controls.MaterialTextBox2();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(170, 466);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 4;
            label1.Text = "Old Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(170, 551);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 5;
            label2.Text = "New Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(170, 611);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 6;
            label3.Text = "Confirm Password";
            // 
            // lbl_new
            // 
            lbl_new.AutoSize = true;
            lbl_new.ForeColor = Color.Red;
            lbl_new.Location = new Point(417, 647);
            lbl_new.Name = "lbl_new";
            lbl_new.Size = new Size(194, 20);
            lbl_new.TabIndex = 7;
            lbl_new.Text = "❌ Passwords do not match";
            lbl_new.Visible = false;
            // 
            // close_btn
            // 
            close_btn.BackColor = SystemColors.ButtonFace;
            close_btn.BackgroundImage = ITI_Examination_System.Properties.Resources.left_arrow;
            close_btn.BackgroundImageLayout = ImageLayout.Zoom;
            close_btn.FlatAppearance.BorderSize = 0;
            close_btn.FlatStyle = FlatStyle.Flat;
            close_btn.Location = new Point(17, 82);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(49, 41);
            close_btn.TabIndex = 15;
            close_btn.UseVisualStyleBackColor = false;
            close_btn.Click += close_btn_Click;
            // 
            // btn_changepassword
            // 
            btn_changepassword.AutoSize = false;
            btn_changepassword.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_changepassword.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            btn_changepassword.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_changepassword.Depth = 0;
            btn_changepassword.HighEmphasis = true;
            btn_changepassword.Icon = null;
            btn_changepassword.Location = new Point(317, 732);
            btn_changepassword.Margin = new Padding(4, 6, 4, 6);
            btn_changepassword.MouseState = MaterialSkin.MouseState.HOVER;
            btn_changepassword.Name = "btn_changepassword";
            btn_changepassword.NoAccentTextColor = Color.Empty;
            btn_changepassword.Size = new Size(146, 49);
            btn_changepassword.TabIndex = 16;
            btn_changepassword.Text = "Change Password";
            btn_changepassword.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_changepassword.UseAccentColor = false;
            btn_changepassword.UseVisualStyleBackColor = true;
            btn_changepassword.Click += btn_changepassword_Click;
            // 
            // lbl_old
            // 
            lbl_old.AutoSize = true;
            lbl_old.ForeColor = Color.Red;
            lbl_old.Location = new Point(417, 499);
            lbl_old.Name = "lbl_old";
            lbl_old.Size = new Size(179, 20);
            lbl_old.TabIndex = 7;
            lbl_old.Text = "❌ Password  not correct ";
            lbl_old.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = ITI_Examination_System.Properties.Resources.Reset_password_bro;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(101, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(548, 326);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = ITI_Examination_System.Properties.Resources.unlocked;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(135, 461);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 32);
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = ITI_Examination_System.Properties.Resources.padlock;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(135, 546);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(29, 32);
            pictureBox4.TabIndex = 23;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = ITI_Examination_System.Properties.Resources.random;
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(282, 732);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(40, 49);
            pictureBox5.TabIndex = 24;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = ITI_Examination_System.Properties.Resources.padlock;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(135, 606);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 32);
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            // 
            // cb
            // 
            cb.AutoSize = true;
            cb.Depth = 0;
            cb.Location = new Point(561, 667);
            cb.Margin = new Padding(0);
            cb.MouseLocation = new Point(-1, -1);
            cb.MouseState = MaterialSkin.MouseState.HOVER;
            cb.Name = "cb";
            cb.ReadOnly = false;
            cb.Ripple = true;
            cb.Size = new Size(35, 37);
            cb.TabIndex = 26;
            cb.UseVisualStyleBackColor = true;
            cb.CheckedChanged += cb_CheckedChanged;
            // 
            // txt_oldpassword
            // 
            txt_oldpassword.AnimateReadOnly = false;
            txt_oldpassword.BackgroundImageLayout = ImageLayout.None;
            txt_oldpassword.CharacterCasing = CharacterCasing.Normal;
            txt_oldpassword.Depth = 0;
            txt_oldpassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_oldpassword.HideSelection = true;
            txt_oldpassword.LeadingIcon = null;
            txt_oldpassword.Location = new Point(417, 448);
            txt_oldpassword.MaxLength = 32767;
            txt_oldpassword.MouseState = MaterialSkin.MouseState.OUT;
            txt_oldpassword.Name = "txt_oldpassword";
            txt_oldpassword.PasswordChar = '*';
            txt_oldpassword.PrefixSuffixText = null;
            txt_oldpassword.ReadOnly = false;
            txt_oldpassword.RightToLeft = RightToLeft.No;
            txt_oldpassword.SelectedText = "";
            txt_oldpassword.SelectionLength = 0;
            txt_oldpassword.SelectionStart = 0;
            txt_oldpassword.ShortcutsEnabled = true;
            txt_oldpassword.Size = new Size(210, 48);
            txt_oldpassword.TabIndex = 27;
            txt_oldpassword.TabStop = false;
            txt_oldpassword.TextAlign = HorizontalAlignment.Left;
            txt_oldpassword.TrailingIcon = null;
            txt_oldpassword.UseSystemPasswordChar = false;
            // 
            // txt_newpassword
            // 
            txt_newpassword.AnimateReadOnly = false;
            txt_newpassword.BackgroundImageLayout = ImageLayout.None;
            txt_newpassword.CharacterCasing = CharacterCasing.Normal;
            txt_newpassword.Depth = 0;
            txt_newpassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_newpassword.HideSelection = true;
            txt_newpassword.LeadingIcon = null;
            txt_newpassword.Location = new Point(417, 540);
            txt_newpassword.MaxLength = 32767;
            txt_newpassword.MouseState = MaterialSkin.MouseState.OUT;
            txt_newpassword.Name = "txt_newpassword";
            txt_newpassword.PasswordChar = '*';
            txt_newpassword.PrefixSuffixText = null;
            txt_newpassword.ReadOnly = false;
            txt_newpassword.RightToLeft = RightToLeft.No;
            txt_newpassword.SelectedText = "";
            txt_newpassword.SelectionLength = 0;
            txt_newpassword.SelectionStart = 0;
            txt_newpassword.ShortcutsEnabled = true;
            txt_newpassword.Size = new Size(210, 48);
            txt_newpassword.TabIndex = 28;
            txt_newpassword.TabStop = false;
            txt_newpassword.TextAlign = HorizontalAlignment.Left;
            txt_newpassword.TrailingIcon = null;
            txt_newpassword.UseSystemPasswordChar = false;
            // 
            // txt_confirmpassword
            // 
            txt_confirmpassword.AnimateReadOnly = false;
            txt_confirmpassword.BackgroundImageLayout = ImageLayout.None;
            txt_confirmpassword.CharacterCasing = CharacterCasing.Normal;
            txt_confirmpassword.Depth = 0;
            txt_confirmpassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_confirmpassword.HideSelection = true;
            txt_confirmpassword.LeadingIcon = null;
            txt_confirmpassword.Location = new Point(417, 594);
            txt_confirmpassword.MaxLength = 32767;
            txt_confirmpassword.MouseState = MaterialSkin.MouseState.OUT;
            txt_confirmpassword.Name = "txt_confirmpassword";
            txt_confirmpassword.PasswordChar = '*';
            txt_confirmpassword.PrefixSuffixText = null;
            txt_confirmpassword.ReadOnly = false;
            txt_confirmpassword.RightToLeft = RightToLeft.No;
            txt_confirmpassword.SelectedText = "";
            txt_confirmpassword.SelectionLength = 0;
            txt_confirmpassword.SelectionStart = 0;
            txt_confirmpassword.ShortcutsEnabled = true;
            txt_confirmpassword.Size = new Size(210, 48);
            txt_confirmpassword.TabIndex = 29;
            txt_confirmpassword.TabStop = false;
            txt_confirmpassword.TextAlign = HorizontalAlignment.Left;
            txt_confirmpassword.TrailingIcon = null;
            txt_confirmpassword.UseSystemPasswordChar = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = ITI_Examination_System.Properties.Resources.eye;
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.ImeMode = ImeMode.NoControl;
            pictureBox6.Location = new Point(599, 667);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(33, 37);
            pictureBox6.TabIndex = 30;
            pictureBox6.TabStop = false;
            pictureBox6.Visible = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = ITI_Examination_System.Properties.Resources.hidden;
            pictureBox7.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox7.ImeMode = ImeMode.NoControl;
            pictureBox7.Location = new Point(599, 667);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(33, 37);
            pictureBox7.TabIndex = 31;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = ITI_Examination_System.Properties.Resources.output_onlinegiftools__4_;
            pictureBox8.ImeMode = ImeMode.NoControl;
            pictureBox8.Location = new Point(101, 94);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(548, 337);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 48;
            pictureBox8.TabStop = false;
            // 
            // Change_Password
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 804);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(txt_confirmpassword);
            Controls.Add(txt_newpassword);
            Controls.Add(txt_oldpassword);
            Controls.Add(cb);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btn_changepassword);
            Controls.Add(close_btn);
            Controls.Add(lbl_new);
            Controls.Add(lbl_old);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Change_Password";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change Password";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbl_new;
        private Button close_btn;
        private MaterialSkin.Controls.MaterialButton btn_changepassword;
        private Label lbl_old;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialCheckbox cb;
        private MaterialSkin.Controls.MaterialTextBox2 txt_oldpassword;
        private MaterialSkin.Controls.MaterialTextBox2 txt_newpassword;
        private MaterialSkin.Controls.MaterialTextBox2 txt_confirmpassword;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
    }
}