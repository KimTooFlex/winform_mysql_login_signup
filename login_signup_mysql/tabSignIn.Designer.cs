namespace login_signup_mysql
{
    partial class tabSignIn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tabSignIn));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.btnSignIn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtUsername = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowSignUp = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCheckBox1 = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.Transparent;
            this.btnSignIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignIn.BackgroundImage")));
            this.btnSignIn.ButtonText = "SIGN IN";
            this.btnSignIn.ButtonTextMarginLeft = 0;
            this.btnSignIn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnSignIn.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnSignIn.DisabledForecolor = System.Drawing.Color.White;
            this.btnSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSignIn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSignIn.IconPadding = 10;
            this.btnSignIn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSignIn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.btnSignIn.IdleBorderRadius = 40;
            this.btnSignIn.IdleBorderThickness = 0;
            this.btnSignIn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.btnSignIn.IdleIconLeftImage = null;
            this.btnSignIn.IdleIconRightImage = null;
            this.btnSignIn.Location = new System.Drawing.Point(287, 400);
            this.btnSignIn.Name = "btnSignIn";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(31)))), ((int)(((byte)(144)))));
            stateProperties5.BorderRadius = 40;
            stateProperties5.BorderThickness = 1;
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(31)))), ((int)(((byte)(144)))));
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.btnSignIn.onHoverState = stateProperties5;
            this.btnSignIn.Size = new System.Drawing.Size(415, 44);
            this.btnSignIn.TabIndex = 13;
            this.btnSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.AcceptsReturn = false;
            this.txtUsername.AcceptsTab = false;
            this.txtUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtUsername.BackgroundImage")));
            this.txtUsername.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtUsername.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtUsername.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtUsername.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(112)))), ((int)(((byte)(123)))));
            this.txtUsername.BorderRadius = 38;
            this.txtUsername.BorderThickness = 2;
            this.txtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUsername.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.DefaultText = "";
            this.txtUsername.FillColor = System.Drawing.Color.White;
            this.txtUsername.HideSelection = true;
            this.txtUsername.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtUsername.IconLeft")));
            this.txtUsername.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtUsername.IconPadding = 12;
            this.txtUsername.IconRight = null;
            this.txtUsername.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtUsername.Location = new System.Drawing.Point(287, 175);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtUsername.Modified = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.ReadOnly = false;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(413, 44);
            this.txtUsername.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtUsername.TabIndex = 12;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.TextMarginLeft = 5;
            this.txtUsername.TextPlaceholder = "Enter Username";
            this.txtUsername.UseSystemPasswordChar = false;
            this.txtUsername.TextChange += new System.EventHandler(this.txtUsername_TextChange);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 21F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(75)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(299, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Login";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.btnShowSignUp);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 550);
            this.panel1.TabIndex = 8;
            // 
            // btnShowSignUp
            // 
            this.btnShowSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnShowSignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowSignUp.BackgroundImage")));
            this.btnShowSignUp.ButtonText = "GET STARTED";
            this.btnShowSignUp.ButtonTextMarginLeft = 0;
            this.btnShowSignUp.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnShowSignUp.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnShowSignUp.DisabledForecolor = System.Drawing.Color.White;
            this.btnShowSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnShowSignUp.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnShowSignUp.IconPadding = 10;
            this.btnShowSignUp.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnShowSignUp.IdleBorderColor = System.Drawing.Color.Gray;
            this.btnShowSignUp.IdleBorderRadius = 40;
            this.btnShowSignUp.IdleBorderThickness = 0;
            this.btnShowSignUp.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.btnShowSignUp.IdleIconLeftImage = null;
            this.btnShowSignUp.IdleIconRightImage = null;
            this.btnShowSignUp.Location = new System.Drawing.Point(33, 288);
            this.btnShowSignUp.Name = "btnShowSignUp";
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(31)))), ((int)(((byte)(144)))));
            stateProperties6.BorderRadius = 40;
            stateProperties6.BorderThickness = 1;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            stateProperties6.IconLeftImage = null;
            stateProperties6.IconRightImage = null;
            this.btnShowSignUp.onHoverState = stateProperties6;
            this.btnShowSignUp.Size = new System.Drawing.Size(176, 40);
            this.btnShowSignUp.TabIndex = 9;
            this.btnShowSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShowSignUp.Click += new System.EventHandler(this.btnShowSignUp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(29, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Don\'t have an account?";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(717, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 25;
            // 
            // bunifuCheckBox1
            // 
            this.bunifuCheckBox1.AllowBindingControlAnimation = true;
            this.bunifuCheckBox1.AllowBindingControlLocation = true;
            this.bunifuCheckBox1.AllowCheckBoxAnimation = false;
            this.bunifuCheckBox1.AllowCheckmarkAnimation = true;
            this.bunifuCheckBox1.AllowOnHoverStates = true;
            this.bunifuCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCheckBox1.BackgroundImage")));
            this.bunifuCheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuCheckBox1.BindingControl = null;
            this.bunifuCheckBox1.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.bunifuCheckBox1.Checked = true;
            this.bunifuCheckBox1.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.bunifuCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCheckBox1.CustomCheckmarkImage = null;
            this.bunifuCheckBox1.Location = new System.Drawing.Point(305, 338);
            this.bunifuCheckBox1.MinimumSize = new System.Drawing.Size(17, 17);
            this.bunifuCheckBox1.Name = "bunifuCheckBox1";
            this.bunifuCheckBox1.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(31)))), ((int)(((byte)(144)))));
            this.bunifuCheckBox1.OnCheck.BorderRadius = 2;
            this.bunifuCheckBox1.OnCheck.BorderThickness = 2;
            this.bunifuCheckBox1.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(31)))), ((int)(((byte)(144)))));
            this.bunifuCheckBox1.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox1.OnCheck.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox1.OnDisable.BorderRadius = 2;
            this.bunifuCheckBox1.OnDisable.BorderThickness = 2;
            this.bunifuCheckBox1.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox1.OnDisable.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.bunifuCheckBox1.OnHoverChecked.BorderRadius = 2;
            this.bunifuCheckBox1.OnHoverChecked.BorderThickness = 2;
            this.bunifuCheckBox1.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.bunifuCheckBox1.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox1.OnHoverChecked.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.bunifuCheckBox1.OnHoverUnchecked.BorderRadius = 2;
            this.bunifuCheckBox1.OnHoverUnchecked.BorderThickness = 2;
            this.bunifuCheckBox1.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.bunifuCheckBox1.OnUncheck.BorderRadius = 2;
            this.bunifuCheckBox1.OnUncheck.BorderThickness = 2;
            this.bunifuCheckBox1.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.Size = new System.Drawing.Size(21, 21);
            this.bunifuCheckBox1.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.bunifuCheckBox1.TabIndex = 14;
            this.bunifuCheckBox1.ThreeState = false;
            this.bunifuCheckBox1.ToolTipText = null;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(332, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Remember me";
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = false;
            this.txtPassword.AcceptsTab = false;
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPassword.BackgroundImage")));
            this.txtPassword.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtPassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(112)))), ((int)(((byte)(123)))));
            this.txtPassword.BorderRadius = 38;
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.DefaultText = "";
            this.txtPassword.FillColor = System.Drawing.Color.White;
            this.txtPassword.HideSelection = true;
            this.txtPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtPassword.IconLeft")));
            this.txtPassword.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtPassword.IconPadding = 12;
            this.txtPassword.IconRight = null;
            this.txtPassword.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtPassword.Location = new System.Drawing.Point(289, 253);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtPassword.Modified = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ReadOnly = false;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(413, 44);
            this.txtPassword.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtPassword.TabIndex = 15;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TextMarginLeft = 5;
            this.txtPassword.TextPlaceholder = "Enter Password";
            this.txtPassword.UseSystemPasswordChar = false;
            this.txtPassword.TextChange += new System.EventHandler(this.txtPassword_TextChange);
            // 
            // lblError
            // 
            this.lblError.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.lblError.AutoSize = true;
            this.lblError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblError.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(305, 137);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 19);
            this.lblError.TabIndex = 16;
            // 
            // tabSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuCheckBox1);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "tabSignIn";
            this.Size = new System.Drawing.Size(750, 550);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSignIn;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnShowSignUp;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.UI.WinForms.BunifuCheckBox bunifuCheckBox1;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtPassword;
        private System.Windows.Forms.Label lblError;
    }
}
