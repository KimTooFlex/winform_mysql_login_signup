namespace login_signup_mysql
{
    partial class tabProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tabProfile));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowSignIn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lblname = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblBio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnShowSignIn);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(318, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 550);
            this.panel1.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.DarkGray;
            this.lblEmail.Location = new System.Drawing.Point(37, 148);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(166, 21);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "email@company.com";
            this.lblEmail.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(33, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(49, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Online";
            // 
            // lblBio
            // 
            this.lblBio.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.lblBio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblBio.ForeColor = System.Drawing.Color.DarkGray;
            this.lblBio.Location = new System.Drawing.Point(32, 266);
            this.lblBio.Name = "lblBio";
            this.lblBio.Size = new System.Drawing.Size(358, 199);
            this.lblBio.TabIndex = 14;
            this.lblBio.Text = resources.GetString("lblBio.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(31)))), ((int)(((byte)(144)))));
            this.label1.Location = new System.Drawing.Point(29, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 40);
            this.label1.TabIndex = 13;
            this.label1.Text = "Bio";
            // 
            // btnShowSignIn
            // 
            this.btnShowSignIn.BackColor = System.Drawing.Color.Transparent;
            this.btnShowSignIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowSignIn.BackgroundImage")));
            this.btnShowSignIn.ButtonText = "LOG OUT";
            this.btnShowSignIn.ButtonTextMarginLeft = 0;
            this.btnShowSignIn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnShowSignIn.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnShowSignIn.DisabledForecolor = System.Drawing.Color.White;
            this.btnShowSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnShowSignIn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnShowSignIn.IconPadding = 10;
            this.btnShowSignIn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnShowSignIn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(31)))), ((int)(((byte)(144)))));
            this.btnShowSignIn.IdleBorderRadius = 40;
            this.btnShowSignIn.IdleBorderThickness = 0;
            this.btnShowSignIn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.btnShowSignIn.IdleIconLeftImage = null;
            this.btnShowSignIn.IdleIconRightImage = null;
            this.btnShowSignIn.Location = new System.Drawing.Point(214, 489);
            this.btnShowSignIn.Name = "btnShowSignIn";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(31)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 40;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(31)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnShowSignIn.onHoverState = stateProperties1;
            this.btnShowSignIn.Size = new System.Drawing.Size(176, 40);
            this.btnShowSignIn.TabIndex = 9;
            this.btnShowSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShowSignIn.Click += new System.EventHandler(this.btnShowSignIn_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(31)))), ((int)(((byte)(144)))));
            this.lblname.Location = new System.Drawing.Point(31, 110);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(163, 40);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Name Here";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(394, 6);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 550);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tabProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "tabProfile";
            this.Size = new System.Drawing.Size(750, 550);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnShowSignIn;
        private System.Windows.Forms.Label lblname;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmail;
    }
}
