namespace ITI_ExaminationSystem
{
    partial class Login
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
        //private void InitializeComponent()
        //{
        //    this.components = new System.ComponentModel.Container();
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(800, 450);
        //    this.Text = "Login";
        //}



        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            linkLabel1 = new LinkLabel();
            txtUser = new MaterialSkin.Controls.MaterialTextBox();
            txtpass = new MaterialSkin.Controls.MaterialTextBox2();
            cb = new MaterialSkin.Controls.MaterialCheckbox();
            login_btn = new MaterialSkin.Controls.MaterialButton();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox8 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            resources.ApplyResources(linkLabel1, "linkLabel1");
            linkLabel1.LinkColor = Color.RoyalBlue;
            linkLabel1.Name = "linkLabel1";
            linkLabel1.TabStop = true;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txtUser
            // 
            txtUser.AnimateReadOnly = false;
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Depth = 0;
            resources.ApplyResources(txtUser, "txtUser");
            txtUser.LeadingIcon = null;
            txtUser.MouseState = MaterialSkin.MouseState.OUT;
            txtUser.Name = "txtUser";
            txtUser.TrailingIcon = null;
            // 
            // txtpass
            // 
            txtpass.AnimateReadOnly = false;
            resources.ApplyResources(txtpass, "txtpass");
            txtpass.CharacterCasing = CharacterCasing.Normal;
            txtpass.Depth = 0;
            txtpass.HideSelection = true;
            txtpass.LeadingIcon = null;
            txtpass.MaxLength = 32767;
            txtpass.MouseState = MaterialSkin.MouseState.OUT;
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '*';
            txtpass.ReadOnly = false;
            txtpass.SelectedText = "";
            txtpass.SelectionLength = 0;
            txtpass.SelectionStart = 0;
            txtpass.ShortcutsEnabled = true;
            txtpass.TabStop = false;
            txtpass.TextAlign = HorizontalAlignment.Left;
            txtpass.TrailingIcon = null;
            txtpass.UseSystemPasswordChar = false;
            // 
            // cb
            // 
            resources.ApplyResources(cb, "cb");
            cb.BackgroundImage = ITI_Examination_System.Properties.Resources.hidden;
            cb.Depth = 0;
            cb.MouseLocation = new Point(-1, -1);
            cb.MouseState = MaterialSkin.MouseState.HOVER;
            cb.Name = "cb";
            cb.ReadOnly = false;
            cb.Ripple = true;
            cb.UseVisualStyleBackColor = true;
            cb.CheckedChanged += cb_CheckedChanged;
            // 
            // login_btn
            // 
            resources.ApplyResources(login_btn, "login_btn");
            login_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            login_btn.Depth = 0;
            login_btn.HighEmphasis = true;
            login_btn.Icon = null;
            login_btn.MouseState = MaterialSkin.MouseState.HOVER;
            login_btn.Name = "login_btn";
            login_btn.NoAccentTextColor = Color.Empty;
            login_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            login_btn.UseAccentColor = false;
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += login_btn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = ITI_Examination_System.Properties.Resources.email10;
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = ITI_Examination_System.Properties.Resources.padlock;
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = ITI_Examination_System.Properties.Resources.hidden1;
            resources.ApplyResources(pictureBox4, "pictureBox4");
            pictureBox4.Name = "pictureBox4";
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = ITI_Examination_System.Properties.Resources.eye;
            resources.ApplyResources(pictureBox5, "pictureBox5");
            pictureBox5.Name = "pictureBox5";
            pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = ITI_Examination_System.Properties.Resources.login;
            resources.ApplyResources(pictureBox7, "pictureBox7");
            pictureBox7.Name = "pictureBox7";
            pictureBox7.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = ITI_Examination_System.Properties.Resources.Login_amico;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.Image = ITI_Examination_System.Properties.Resources.output_onlinegiftools__5_;
            resources.ApplyResources(pictureBox8, "pictureBox8");
            pictureBox8.Name = "pictureBox8";
            pictureBox8.TabStop = false;
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(login_btn);
            Controls.Add(cb);
            Controls.Add(txtpass);
            Controls.Add(txtUser);
            Controls.Add(linkLabel1);
            Name = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtUser;
        private MaterialSkin.Controls.MaterialTextBox2 txtpass;
        private MaterialSkin.Controls.MaterialCheckbox cb;
        private MaterialSkin.Controls.MaterialButton login_btn;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox7;
        private PictureBox pictureBox1;
        private PictureBox pictureBox8;
        //private ComboBox comboBox1;
        //private Label label3;
    }
}