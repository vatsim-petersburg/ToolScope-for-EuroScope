﻿namespace ToolScope_for_EuroScope
{
    partial class PSEditor
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PSEditor));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.closebtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.minimizebtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.codeeditor = new ScintillaNET.Scintilla();
            this.pagenametxt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.savebtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.loadoldscriptbtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.maximizebtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // closebtn
            // 
            this.closebtn.AllowAnimations = true;
            this.closebtn.AllowMouseEffects = true;
            this.closebtn.AllowToggling = false;
            this.closebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closebtn.AnimationSpeed = 200;
            this.closebtn.AutoGenerateColors = false;
            this.closebtn.AutoRoundBorders = false;
            this.closebtn.AutoSizeLeftIcon = true;
            this.closebtn.AutoSizeRightIcon = true;
            this.closebtn.BackColor = System.Drawing.Color.Transparent;
            this.closebtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.closebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closebtn.BackgroundImage")));
            this.closebtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.closebtn.ButtonText = "X";
            this.closebtn.ButtonTextMarginLeft = 0;
            this.closebtn.ColorContrastOnClick = 45;
            this.closebtn.ColorContrastOnHover = 45;
            this.closebtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.closebtn.CustomizableEdges = borderEdges4;
            this.closebtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.closebtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.closebtn.DisabledFillColor = System.Drawing.Color.Empty;
            this.closebtn.DisabledForecolor = System.Drawing.Color.Empty;
            this.closebtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.closebtn.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(150)))), ((int)(((byte)(153)))));
            this.closebtn.IconLeft = null;
            this.closebtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closebtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.closebtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.closebtn.IconMarginLeft = 11;
            this.closebtn.IconPadding = 10;
            this.closebtn.IconRight = null;
            this.closebtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closebtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.closebtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.closebtn.IconSize = 25;
            this.closebtn.IdleBorderColor = System.Drawing.Color.Empty;
            this.closebtn.IdleBorderRadius = 0;
            this.closebtn.IdleBorderThickness = 0;
            this.closebtn.IdleFillColor = System.Drawing.Color.Empty;
            this.closebtn.IdleIconLeftImage = null;
            this.closebtn.IdleIconRightImage = null;
            this.closebtn.IndicateFocus = false;
            this.closebtn.Location = new System.Drawing.Point(1116, 0);
            this.closebtn.Name = "closebtn";
            this.closebtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.closebtn.OnDisabledState.BorderRadius = 0;
            this.closebtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.closebtn.OnDisabledState.BorderThickness = 2;
            this.closebtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.closebtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.closebtn.OnDisabledState.IconLeftImage = null;
            this.closebtn.OnDisabledState.IconRightImage = null;
            this.closebtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.closebtn.onHoverState.BorderRadius = 0;
            this.closebtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.closebtn.onHoverState.BorderThickness = 2;
            this.closebtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.closebtn.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.closebtn.onHoverState.IconLeftImage = null;
            this.closebtn.onHoverState.IconRightImage = null;
            this.closebtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.closebtn.OnIdleState.BorderRadius = 0;
            this.closebtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.closebtn.OnIdleState.BorderThickness = 2;
            this.closebtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.closebtn.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(150)))), ((int)(((byte)(153)))));
            this.closebtn.OnIdleState.IconLeftImage = null;
            this.closebtn.OnIdleState.IconRightImage = null;
            this.closebtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.closebtn.OnPressedState.BorderRadius = 0;
            this.closebtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.closebtn.OnPressedState.BorderThickness = 2;
            this.closebtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.closebtn.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.closebtn.OnPressedState.IconLeftImage = null;
            this.closebtn.OnPressedState.IconRightImage = null;
            this.closebtn.Size = new System.Drawing.Size(46, 33);
            this.closebtn.TabIndex = 2;
            this.closebtn.TabStop = false;
            this.closebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closebtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.closebtn.TextMarginLeft = 0;
            this.closebtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.closebtn.UseDefaultRadiusAndThickness = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // minimizebtn
            // 
            this.minimizebtn.AllowAnimations = true;
            this.minimizebtn.AllowMouseEffects = true;
            this.minimizebtn.AllowToggling = false;
            this.minimizebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizebtn.AnimationSpeed = 200;
            this.minimizebtn.AutoGenerateColors = false;
            this.minimizebtn.AutoRoundBorders = false;
            this.minimizebtn.AutoSizeLeftIcon = true;
            this.minimizebtn.AutoSizeRightIcon = true;
            this.minimizebtn.BackColor = System.Drawing.Color.Transparent;
            this.minimizebtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.minimizebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizebtn.BackgroundImage")));
            this.minimizebtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.minimizebtn.ButtonText = "_";
            this.minimizebtn.ButtonTextMarginLeft = 0;
            this.minimizebtn.ColorContrastOnClick = 45;
            this.minimizebtn.ColorContrastOnHover = 45;
            this.minimizebtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.minimizebtn.CustomizableEdges = borderEdges5;
            this.minimizebtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.minimizebtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.minimizebtn.DisabledFillColor = System.Drawing.Color.Empty;
            this.minimizebtn.DisabledForecolor = System.Drawing.Color.Empty;
            this.minimizebtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.minimizebtn.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold);
            this.minimizebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(150)))), ((int)(((byte)(153)))));
            this.minimizebtn.IconLeft = null;
            this.minimizebtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.minimizebtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.minimizebtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.minimizebtn.IconMarginLeft = 11;
            this.minimizebtn.IconPadding = 10;
            this.minimizebtn.IconRight = null;
            this.minimizebtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.minimizebtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.minimizebtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.minimizebtn.IconSize = 25;
            this.minimizebtn.IdleBorderColor = System.Drawing.Color.Empty;
            this.minimizebtn.IdleBorderRadius = 0;
            this.minimizebtn.IdleBorderThickness = 0;
            this.minimizebtn.IdleFillColor = System.Drawing.Color.Empty;
            this.minimizebtn.IdleIconLeftImage = null;
            this.minimizebtn.IdleIconRightImage = null;
            this.minimizebtn.IndicateFocus = false;
            this.minimizebtn.Location = new System.Drawing.Point(1037, 0);
            this.minimizebtn.Name = "minimizebtn";
            this.minimizebtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.minimizebtn.OnDisabledState.BorderRadius = 0;
            this.minimizebtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.minimizebtn.OnDisabledState.BorderThickness = 2;
            this.minimizebtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.minimizebtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.minimizebtn.OnDisabledState.IconLeftImage = null;
            this.minimizebtn.OnDisabledState.IconRightImage = null;
            this.minimizebtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.minimizebtn.onHoverState.BorderRadius = 0;
            this.minimizebtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.minimizebtn.onHoverState.BorderThickness = 2;
            this.minimizebtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.minimizebtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.minimizebtn.onHoverState.IconLeftImage = null;
            this.minimizebtn.onHoverState.IconRightImage = null;
            this.minimizebtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.minimizebtn.OnIdleState.BorderRadius = 0;
            this.minimizebtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.minimizebtn.OnIdleState.BorderThickness = 2;
            this.minimizebtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.minimizebtn.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(150)))), ((int)(((byte)(153)))));
            this.minimizebtn.OnIdleState.IconLeftImage = null;
            this.minimizebtn.OnIdleState.IconRightImage = null;
            this.minimizebtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.minimizebtn.OnPressedState.BorderRadius = 0;
            this.minimizebtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.minimizebtn.OnPressedState.BorderThickness = 2;
            this.minimizebtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.minimizebtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.minimizebtn.OnPressedState.IconLeftImage = null;
            this.minimizebtn.OnPressedState.IconRightImage = null;
            this.minimizebtn.Size = new System.Drawing.Size(42, 33);
            this.minimizebtn.TabIndex = 3;
            this.minimizebtn.TabStop = false;
            this.minimizebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minimizebtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.minimizebtn.TextMarginLeft = 0;
            this.minimizebtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.minimizebtn.UseDefaultRadiusAndThickness = true;
            this.minimizebtn.Click += new System.EventHandler(this.minimizebtn_Click);
            // 
            // codeeditor
            // 
            this.codeeditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codeeditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codeeditor.CaretForeColor = System.Drawing.Color.WhiteSmoke;
            this.codeeditor.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.codeeditor.FontQuality = ScintillaNET.FontQuality.AntiAliased;
            this.codeeditor.Lexer = ScintillaNET.Lexer.PowerShell;
            this.codeeditor.Location = new System.Drawing.Point(1, 62);
            this.codeeditor.Name = "codeeditor";
            this.codeeditor.Size = new System.Drawing.Size(1158, 592);
            this.codeeditor.TabIndex = 48;
            this.codeeditor.CharAdded += new System.EventHandler<ScintillaNET.CharAddedEventArgs>(this.scintilla1_CharAdded);
            this.codeeditor.UpdateUI += new System.EventHandler<ScintillaNET.UpdateUIEventArgs>(this.scintilla1_UpdateUI);
            // 
            // pagenametxt
            // 
            this.pagenametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.pagenametxt.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagenametxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.pagenametxt.Location = new System.Drawing.Point(133, 13);
            this.pagenametxt.Name = "pagenametxt";
            this.pagenametxt.Size = new System.Drawing.Size(147, 21);
            this.pagenametxt.TabIndex = 49;
            this.pagenametxt.Text = "PowerShell Editor";
            this.pagenametxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.pictureBox1.BackgroundImage = global::ToolScope_for_EuroScope.Properties.Resources.ToolScope_Banner;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::ToolScope_for_EuroScope.Properties.Resources.ToolScope_Banner;
            this.pictureBox1.Location = new System.Drawing.Point(22, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 32);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.bunifuShadowPanel1.BorderRadius = 20;
            this.bunifuShadowPanel1.BorderThickness = 1;
            this.bunifuShadowPanel1.Controls.Add(this.pagenametxt);
            this.bunifuShadowPanel1.Controls.Add(this.label2);
            this.bunifuShadowPanel1.Controls.Add(this.savebtn);
            this.bunifuShadowPanel1.Controls.Add(this.loadoldscriptbtn);
            this.bunifuShadowPanel1.Controls.Add(this.pictureBox1);
            this.bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(12, 2);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.bunifuShadowPanel1.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.bunifuShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowDepth = 3;
            this.bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Dropped;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(589, 54);
            this.bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Raised;
            this.bunifuShadowPanel1.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 10);
            this.label2.TabIndex = 3;
            this.label2.Text = "for EuroScope";
            // 
            // savebtn
            // 
            this.savebtn.AllowAnimations = true;
            this.savebtn.AllowMouseEffects = true;
            this.savebtn.AllowToggling = false;
            this.savebtn.AnimationSpeed = 200;
            this.savebtn.AutoGenerateColors = false;
            this.savebtn.AutoRoundBorders = false;
            this.savebtn.AutoSizeLeftIcon = true;
            this.savebtn.AutoSizeRightIcon = true;
            this.savebtn.BackColor = System.Drawing.Color.Transparent;
            this.savebtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.savebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("savebtn.BackgroundImage")));
            this.savebtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.savebtn.ButtonText = "Save";
            this.savebtn.ButtonTextMarginLeft = 0;
            this.savebtn.ColorContrastOnClick = 45;
            this.savebtn.ColorContrastOnHover = 45;
            this.savebtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.savebtn.CustomizableEdges = borderEdges2;
            this.savebtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.savebtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.savebtn.DisabledFillColor = System.Drawing.Color.Empty;
            this.savebtn.DisabledForecolor = System.Drawing.Color.Empty;
            this.savebtn.Enabled = false;
            this.savebtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.savebtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(252)))), ((int)(((byte)(159)))));
            this.savebtn.IconLeft = null;
            this.savebtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savebtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.savebtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.savebtn.IconMarginLeft = 11;
            this.savebtn.IconPadding = 10;
            this.savebtn.IconRight = null;
            this.savebtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.savebtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.savebtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.savebtn.IconSize = 25;
            this.savebtn.IdleBorderColor = System.Drawing.Color.Empty;
            this.savebtn.IdleBorderRadius = 0;
            this.savebtn.IdleBorderThickness = 0;
            this.savebtn.IdleFillColor = System.Drawing.Color.Empty;
            this.savebtn.IdleIconLeftImage = null;
            this.savebtn.IdleIconRightImage = null;
            this.savebtn.IndicateFocus = false;
            this.savebtn.Location = new System.Drawing.Point(296, 10);
            this.savebtn.Name = "savebtn";
            this.savebtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.savebtn.OnDisabledState.BorderRadius = 15;
            this.savebtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.savebtn.OnDisabledState.BorderThickness = 2;
            this.savebtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.savebtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.savebtn.OnDisabledState.IconLeftImage = null;
            this.savebtn.OnDisabledState.IconRightImage = null;
            this.savebtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.savebtn.onHoverState.BorderRadius = 15;
            this.savebtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.savebtn.onHoverState.BorderThickness = 2;
            this.savebtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(87)))), ((int)(((byte)(28)))));
            this.savebtn.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(252)))), ((int)(((byte)(159)))));
            this.savebtn.onHoverState.IconLeftImage = null;
            this.savebtn.onHoverState.IconRightImage = null;
            this.savebtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(207)))), ((int)(((byte)(6)))));
            this.savebtn.OnIdleState.BorderRadius = 15;
            this.savebtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.savebtn.OnIdleState.BorderThickness = 2;
            this.savebtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(64)))), ((int)(((byte)(22)))));
            this.savebtn.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(252)))), ((int)(((byte)(159)))));
            this.savebtn.OnIdleState.IconLeftImage = null;
            this.savebtn.OnIdleState.IconRightImage = null;
            this.savebtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(207)))), ((int)(((byte)(6)))));
            this.savebtn.OnPressedState.BorderRadius = 15;
            this.savebtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.savebtn.OnPressedState.BorderThickness = 2;
            this.savebtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(64)))), ((int)(((byte)(22)))));
            this.savebtn.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(252)))), ((int)(((byte)(159)))));
            this.savebtn.OnPressedState.IconLeftImage = null;
            this.savebtn.OnPressedState.IconRightImage = null;
            this.savebtn.Size = new System.Drawing.Size(60, 29);
            this.savebtn.TabIndex = 52;
            this.savebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.savebtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.savebtn.TextMarginLeft = 0;
            this.savebtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.savebtn.UseDefaultRadiusAndThickness = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // loadoldscriptbtn
            // 
            this.loadoldscriptbtn.AllowAnimations = true;
            this.loadoldscriptbtn.AllowMouseEffects = true;
            this.loadoldscriptbtn.AllowToggling = false;
            this.loadoldscriptbtn.AnimationSpeed = 200;
            this.loadoldscriptbtn.AutoGenerateColors = false;
            this.loadoldscriptbtn.AutoRoundBorders = false;
            this.loadoldscriptbtn.AutoSizeLeftIcon = true;
            this.loadoldscriptbtn.AutoSizeRightIcon = true;
            this.loadoldscriptbtn.BackColor = System.Drawing.Color.Transparent;
            this.loadoldscriptbtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.loadoldscriptbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loadoldscriptbtn.BackgroundImage")));
            this.loadoldscriptbtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loadoldscriptbtn.ButtonText = "Load unsaved PowerShell Script";
            this.loadoldscriptbtn.ButtonTextMarginLeft = 0;
            this.loadoldscriptbtn.ColorContrastOnClick = 45;
            this.loadoldscriptbtn.ColorContrastOnHover = 45;
            this.loadoldscriptbtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.loadoldscriptbtn.CustomizableEdges = borderEdges3;
            this.loadoldscriptbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.loadoldscriptbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.loadoldscriptbtn.DisabledFillColor = System.Drawing.Color.Empty;
            this.loadoldscriptbtn.DisabledForecolor = System.Drawing.Color.Empty;
            this.loadoldscriptbtn.Enabled = false;
            this.loadoldscriptbtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.loadoldscriptbtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadoldscriptbtn.ForeColor = System.Drawing.Color.White;
            this.loadoldscriptbtn.IconLeft = null;
            this.loadoldscriptbtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loadoldscriptbtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.loadoldscriptbtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.loadoldscriptbtn.IconMarginLeft = 11;
            this.loadoldscriptbtn.IconPadding = 10;
            this.loadoldscriptbtn.IconRight = null;
            this.loadoldscriptbtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loadoldscriptbtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.loadoldscriptbtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.loadoldscriptbtn.IconSize = 25;
            this.loadoldscriptbtn.IdleBorderColor = System.Drawing.Color.Empty;
            this.loadoldscriptbtn.IdleBorderRadius = 0;
            this.loadoldscriptbtn.IdleBorderThickness = 0;
            this.loadoldscriptbtn.IdleFillColor = System.Drawing.Color.Empty;
            this.loadoldscriptbtn.IdleIconLeftImage = null;
            this.loadoldscriptbtn.IdleIconRightImage = null;
            this.loadoldscriptbtn.IndicateFocus = false;
            this.loadoldscriptbtn.Location = new System.Drawing.Point(367, 10);
            this.loadoldscriptbtn.Name = "loadoldscriptbtn";
            this.loadoldscriptbtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.loadoldscriptbtn.OnDisabledState.BorderRadius = 15;
            this.loadoldscriptbtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loadoldscriptbtn.OnDisabledState.BorderThickness = 2;
            this.loadoldscriptbtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.loadoldscriptbtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.loadoldscriptbtn.OnDisabledState.IconLeftImage = null;
            this.loadoldscriptbtn.OnDisabledState.IconRightImage = null;
            this.loadoldscriptbtn.onHoverState.BorderColor = System.Drawing.Color.DarkGray;
            this.loadoldscriptbtn.onHoverState.BorderRadius = 15;
            this.loadoldscriptbtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loadoldscriptbtn.onHoverState.BorderThickness = 2;
            this.loadoldscriptbtn.onHoverState.FillColor = System.Drawing.Color.Gray;
            this.loadoldscriptbtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.loadoldscriptbtn.onHoverState.IconLeftImage = null;
            this.loadoldscriptbtn.onHoverState.IconRightImage = null;
            this.loadoldscriptbtn.OnIdleState.BorderColor = System.Drawing.Color.DarkGray;
            this.loadoldscriptbtn.OnIdleState.BorderRadius = 15;
            this.loadoldscriptbtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loadoldscriptbtn.OnIdleState.BorderThickness = 2;
            this.loadoldscriptbtn.OnIdleState.FillColor = System.Drawing.Color.Gray;
            this.loadoldscriptbtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.loadoldscriptbtn.OnIdleState.IconLeftImage = null;
            this.loadoldscriptbtn.OnIdleState.IconRightImage = null;
            this.loadoldscriptbtn.OnPressedState.BorderColor = System.Drawing.Color.DarkGray;
            this.loadoldscriptbtn.OnPressedState.BorderRadius = 15;
            this.loadoldscriptbtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loadoldscriptbtn.OnPressedState.BorderThickness = 2;
            this.loadoldscriptbtn.OnPressedState.FillColor = System.Drawing.Color.Gray;
            this.loadoldscriptbtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.loadoldscriptbtn.OnPressedState.IconLeftImage = null;
            this.loadoldscriptbtn.OnPressedState.IconRightImage = null;
            this.loadoldscriptbtn.Size = new System.Drawing.Size(204, 29);
            this.loadoldscriptbtn.TabIndex = 53;
            this.loadoldscriptbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loadoldscriptbtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.loadoldscriptbtn.TextMarginLeft = 0;
            this.loadoldscriptbtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.loadoldscriptbtn.UseDefaultRadiusAndThickness = true;
            this.loadoldscriptbtn.Click += new System.EventHandler(this.loadoldscriptbtn_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // maximizebtn
            // 
            this.maximizebtn.AllowAnimations = true;
            this.maximizebtn.AllowMouseEffects = true;
            this.maximizebtn.AllowToggling = false;
            this.maximizebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizebtn.AnimationSpeed = 200;
            this.maximizebtn.AutoGenerateColors = false;
            this.maximizebtn.AutoRoundBorders = false;
            this.maximizebtn.AutoSizeLeftIcon = true;
            this.maximizebtn.AutoSizeRightIcon = true;
            this.maximizebtn.BackColor = System.Drawing.Color.Transparent;
            this.maximizebtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.maximizebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maximizebtn.BackgroundImage")));
            this.maximizebtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.maximizebtn.ButtonText = "▢";
            this.maximizebtn.ButtonTextMarginLeft = 0;
            this.maximizebtn.ColorContrastOnClick = 45;
            this.maximizebtn.ColorContrastOnHover = 45;
            this.maximizebtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.maximizebtn.CustomizableEdges = borderEdges1;
            this.maximizebtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.maximizebtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.maximizebtn.DisabledFillColor = System.Drawing.Color.Empty;
            this.maximizebtn.DisabledForecolor = System.Drawing.Color.Empty;
            this.maximizebtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.maximizebtn.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold);
            this.maximizebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(150)))), ((int)(((byte)(153)))));
            this.maximizebtn.IconLeft = null;
            this.maximizebtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.maximizebtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.maximizebtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.maximizebtn.IconMarginLeft = 11;
            this.maximizebtn.IconPadding = 10;
            this.maximizebtn.IconRight = null;
            this.maximizebtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.maximizebtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.maximizebtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.maximizebtn.IconSize = 25;
            this.maximizebtn.IdleBorderColor = System.Drawing.Color.Empty;
            this.maximizebtn.IdleBorderRadius = 0;
            this.maximizebtn.IdleBorderThickness = 0;
            this.maximizebtn.IdleFillColor = System.Drawing.Color.Empty;
            this.maximizebtn.IdleIconLeftImage = null;
            this.maximizebtn.IdleIconRightImage = null;
            this.maximizebtn.IndicateFocus = false;
            this.maximizebtn.Location = new System.Drawing.Point(1077, 0);
            this.maximizebtn.Name = "maximizebtn";
            this.maximizebtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.maximizebtn.OnDisabledState.BorderRadius = 0;
            this.maximizebtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.maximizebtn.OnDisabledState.BorderThickness = 2;
            this.maximizebtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.maximizebtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.maximizebtn.OnDisabledState.IconLeftImage = null;
            this.maximizebtn.OnDisabledState.IconRightImage = null;
            this.maximizebtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.maximizebtn.onHoverState.BorderRadius = 0;
            this.maximizebtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.maximizebtn.onHoverState.BorderThickness = 2;
            this.maximizebtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.maximizebtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.maximizebtn.onHoverState.IconLeftImage = null;
            this.maximizebtn.onHoverState.IconRightImage = null;
            this.maximizebtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.maximizebtn.OnIdleState.BorderRadius = 0;
            this.maximizebtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.maximizebtn.OnIdleState.BorderThickness = 2;
            this.maximizebtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.maximizebtn.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(150)))), ((int)(((byte)(153)))));
            this.maximizebtn.OnIdleState.IconLeftImage = null;
            this.maximizebtn.OnIdleState.IconRightImage = null;
            this.maximizebtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.maximizebtn.OnPressedState.BorderRadius = 0;
            this.maximizebtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.maximizebtn.OnPressedState.BorderThickness = 2;
            this.maximizebtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.maximizebtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.maximizebtn.OnPressedState.IconLeftImage = null;
            this.maximizebtn.OnPressedState.IconRightImage = null;
            this.maximizebtn.Size = new System.Drawing.Size(42, 33);
            this.maximizebtn.TabIndex = 52;
            this.maximizebtn.TabStop = false;
            this.maximizebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.maximizebtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.maximizebtn.TextMarginLeft = 0;
            this.maximizebtn.TextPadding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.maximizebtn.UseDefaultRadiusAndThickness = true;
            this.maximizebtn.Click += new System.EventHandler(this.maximizebtn_Click);
            // 
            // PSEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1162, 657);
            this.Controls.Add(this.maximizebtn);
            this.Controls.Add(this.bunifuShadowPanel1);
            this.Controls.Add(this.codeeditor);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.minimizebtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PSEditor";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PSEditor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.bunifuShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton closebtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton minimizebtn;
        private ScintillaNET.Scintilla codeeditor;
        private System.Windows.Forms.Label pagenametxt;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton loadoldscriptbtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton savebtn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton maximizebtn;
    }
}