namespace login_signup_mysql
{
    partial class Form1
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabSignUp1 = new login_signup_mysql.tabSignUp();
            this.tabProfile1 = new login_signup_mysql.tabProfile();
            this.tabSignIn1 = new login_signup_mysql.tabSignIn();
            this.imageListValidatorIcons = new System.Windows.Forms.ImageList(this.components);
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.SuspendLayout();
            // 
            // tabSignUp1
            // 
            this.bunifuTransition1.SetDecoration(this.tabSignUp1, BunifuAnimatorNS.DecorationType.None);
            this.tabSignUp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSignUp1.Location = new System.Drawing.Point(0, 0);
            this.tabSignUp1.Name = "tabSignUp1";
            this.tabSignUp1.Size = new System.Drawing.Size(750, 550);
            this.tabSignUp1.TabIndex = 0;
            // 
            // tabProfile1
            // 
            this.bunifuTransition1.SetDecoration(this.tabProfile1, BunifuAnimatorNS.DecorationType.None);
            this.tabProfile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabProfile1.Location = new System.Drawing.Point(0, 0);
            this.tabProfile1.Name = "tabProfile1";
            this.tabProfile1.Size = new System.Drawing.Size(750, 550);
            this.tabProfile1.TabIndex = 1;
            // 
            // tabSignIn1
            // 
            this.bunifuTransition1.SetDecoration(this.tabSignIn1, BunifuAnimatorNS.DecorationType.None);
            this.tabSignIn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSignIn1.Location = new System.Drawing.Point(0, 0);
            this.tabSignIn1.Name = "tabSignIn1";
            this.tabSignIn1.Size = new System.Drawing.Size(750, 550);
            this.tabSignIn1.TabIndex = 2;
            // 
            // imageListValidatorIcons
            // 
            this.imageListValidatorIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListValidatorIcons.ImageStream")));
            this.imageListValidatorIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListValidatorIcons.Images.SetKeyName(0, "Checkmark_48px.png");
            this.imageListValidatorIcons.Images.SetKeyName(1, "error.png");
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormResizing = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.BunifuWindowState = Bunifu.UI.WinForms.BunifuFormDock.BunifuWindowStates.Normal;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = true;
            this.bunifuFormDock1.ShowDockingIndicators = true;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(750, 550);
            this.Controls.Add(this.tabSignUp1);
            this.Controls.Add(this.tabProfile1);
            this.Controls.Add(this.tabSignIn1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private tabSignUp tabSignUp1;
        private tabProfile tabProfile1;
        private tabSignIn tabSignIn1;
        private System.Windows.Forms.ImageList imageListValidatorIcons;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
    }
}

