namespace MediaPlayer_0
{
    partial class VideoPlayer
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
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.Volumelbl = new System.Windows.Forms.Label();
            this.ScreenMode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NormalModeToolbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoomCenterModeToolbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoomModeToolbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToFitCenterToolbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ZiseToFitModeToolbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ManualModeToolbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.CenterModeToolbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.CoverCenterModebtn = new System.Windows.Forms.ToolStripMenuItem();
            this.StrectchToolbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PausResbtn = new System.Windows.Forms.Button();
            this.Nxtbtn = new System.Windows.Forms.Button();
            this.VolumeMute = new System.Windows.Forms.Button();
            this.Prebtn = new System.Windows.Forms.Button();
            this.Stalbl = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.Endlbl = new System.Windows.Forms.Label();
            this.VideoLst = new System.Windows.Forms.ListBox();
            this.VideoLstMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OnceVideoLstMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RepeatVideoLstMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RandomVideoLstMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.playAllOnceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reorderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReverseVideoLstMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ByNameVideoLstMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ByCrationTimeVideoLstMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ByLenghtVideoLstMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ByExtensionVideoLstMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Screenpnl = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.VideoControlpnl = new System.Windows.Forms.Panel();
            this.dropDownButton1 = new MediaPlayer_0.DropDownButton();
            this.VideoLstbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.ScreenMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.VideoLstMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Screenpnl.SuspendLayout();
            this.VideoControlpnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar2
            // 
            this.trackBar2.AutoSize = false;
            this.trackBar2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trackBar2.Location = new System.Drawing.Point(198, 25);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(87, 19);
            this.trackBar2.TabIndex = 15;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll_1);
            // 
            // Volumelbl
            // 
            this.Volumelbl.AutoSize = true;
            this.Volumelbl.ForeColor = System.Drawing.Color.White;
            this.Volumelbl.Location = new System.Drawing.Point(336, 25);
            this.Volumelbl.Name = "Volumelbl";
            this.Volumelbl.Size = new System.Drawing.Size(19, 13);
            this.Volumelbl.TabIndex = 17;
            this.Volumelbl.Text = "50";
            // 
            // ScreenMode
            // 
            this.ScreenMode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NormalModeToolbtn,
            this.ZoomCenterModeToolbtn,
            this.ZoomModeToolbtn,
            this.sizeToFitCenterToolbtn,
            this.ZiseToFitModeToolbtn,
            this.ManualModeToolbtn,
            this.CenterModeToolbtn,
            this.CoverCenterModebtn,
            this.StrectchToolbtn,
            this.fullScreenToolStripMenuItem});
            this.ScreenMode.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.ScreenMode.Name = "contextMenuStrip1";
            this.ScreenMode.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ScreenMode.ShowCheckMargin = true;
            this.ScreenMode.ShowImageMargin = false;
            this.ScreenMode.ShowItemToolTips = false;
            this.ScreenMode.Size = new System.Drawing.Size(165, 224);
            // 
            // NormalModeToolbtn
            // 
            this.NormalModeToolbtn.Name = "NormalModeToolbtn";
            this.NormalModeToolbtn.Size = new System.Drawing.Size(164, 22);
            this.NormalModeToolbtn.Text = "Normal";
            this.NormalModeToolbtn.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // ZoomCenterModeToolbtn
            // 
            this.ZoomCenterModeToolbtn.Name = "ZoomCenterModeToolbtn";
            this.ZoomCenterModeToolbtn.Size = new System.Drawing.Size(164, 22);
            this.ZoomCenterModeToolbtn.Text = "Zoom Center";
            this.ZoomCenterModeToolbtn.Click += new System.EventHandler(this.zoomCenterToolStripMenuItem_Click);
            // 
            // ZoomModeToolbtn
            // 
            this.ZoomModeToolbtn.Name = "ZoomModeToolbtn";
            this.ZoomModeToolbtn.Size = new System.Drawing.Size(164, 22);
            this.ZoomModeToolbtn.Text = "Zoom";
            this.ZoomModeToolbtn.Click += new System.EventHandler(this.zoomToolStripMenuItem_Click);
            // 
            // sizeToFitCenterToolbtn
            // 
            this.sizeToFitCenterToolbtn.Name = "sizeToFitCenterToolbtn";
            this.sizeToFitCenterToolbtn.Size = new System.Drawing.Size(164, 22);
            this.sizeToFitCenterToolbtn.Text = "Zise To Fit Center";
            this.sizeToFitCenterToolbtn.Click += new System.EventHandler(this.sizeToFitCenterToolStripMenuItem_Click);
            // 
            // ZiseToFitModeToolbtn
            // 
            this.ZiseToFitModeToolbtn.Name = "ZiseToFitModeToolbtn";
            this.ZiseToFitModeToolbtn.Size = new System.Drawing.Size(164, 22);
            this.ZiseToFitModeToolbtn.Text = "Size To Fit";
            this.ZiseToFitModeToolbtn.Click += new System.EventHandler(this.sizeToFitToolStripMenuItem_Click);
            // 
            // ManualModeToolbtn
            // 
            this.ManualModeToolbtn.Name = "ManualModeToolbtn";
            this.ManualModeToolbtn.Size = new System.Drawing.Size(164, 22);
            this.ManualModeToolbtn.Text = "Manual";
            this.ManualModeToolbtn.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // CenterModeToolbtn
            // 
            this.CenterModeToolbtn.Name = "CenterModeToolbtn";
            this.CenterModeToolbtn.Size = new System.Drawing.Size(164, 22);
            this.CenterModeToolbtn.Text = "Center";
            this.CenterModeToolbtn.Click += new System.EventHandler(this.centerToolStripMenuItem_Click);
            // 
            // CoverCenterModebtn
            // 
            this.CoverCenterModebtn.Name = "CoverCenterModebtn";
            this.CoverCenterModebtn.Size = new System.Drawing.Size(164, 22);
            this.CoverCenterModebtn.Text = "Cover Center";
            this.CoverCenterModebtn.Click += new System.EventHandler(this.coverCenterToolStripMenuItem_Click);
            // 
            // StrectchToolbtn
            // 
            this.StrectchToolbtn.Name = "StrectchToolbtn";
            this.StrectchToolbtn.Size = new System.Drawing.Size(164, 22);
            this.StrectchToolbtn.Text = "Strectch";
            this.StrectchToolbtn.Click += new System.EventHandler(this.strectchToolStripMenuItem_Click);
            // 
            // fullScreenToolStripMenuItem
            // 
            this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            this.fullScreenToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.fullScreenToolStripMenuItem.Text = "Full Screen";
            // 
            // PausResbtn
            // 
            this.PausResbtn.Location = new System.Drawing.Point(9, 25);
            this.PausResbtn.Name = "PausResbtn";
            this.PausResbtn.Size = new System.Drawing.Size(49, 21);
            this.PausResbtn.TabIndex = 6;
            this.PausResbtn.Text = "Pause";
            this.PausResbtn.UseVisualStyleBackColor = true;
            this.PausResbtn.Click += new System.EventHandler(this.PausResbtn_Click);
            // 
            // Nxtbtn
            // 
            this.Nxtbtn.Location = new System.Drawing.Point(130, 26);
            this.Nxtbtn.Name = "Nxtbtn";
            this.Nxtbtn.Size = new System.Drawing.Size(49, 21);
            this.Nxtbtn.TabIndex = 7;
            this.Nxtbtn.Text = "Next";
            this.Nxtbtn.UseVisualStyleBackColor = true;
            this.Nxtbtn.Click += new System.EventHandler(this.Nxtbtn_Click);
            // 
            // VolumeMute
            // 
            this.VolumeMute.Location = new System.Drawing.Point(291, 24);
            this.VolumeMute.Name = "VolumeMute";
            this.VolumeMute.Size = new System.Drawing.Size(39, 20);
            this.VolumeMute.TabIndex = 16;
            this.VolumeMute.Text = "Mute";
            this.VolumeMute.UseVisualStyleBackColor = true;
            this.VolumeMute.Click += new System.EventHandler(this.VolumeMute_Click);
            // 
            // Prebtn
            // 
            this.Prebtn.Location = new System.Drawing.Point(64, 25);
            this.Prebtn.Name = "Prebtn";
            this.Prebtn.Size = new System.Drawing.Size(60, 21);
            this.Prebtn.TabIndex = 8;
            this.Prebtn.Text = "Previoes";
            this.Prebtn.UseVisualStyleBackColor = true;
            this.Prebtn.Click += new System.EventHandler(this.Prebtn_Click);
            // 
            // Stalbl
            // 
            this.Stalbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Stalbl.AutoSize = true;
            this.Stalbl.BackColor = System.Drawing.Color.Transparent;
            this.Stalbl.ForeColor = System.Drawing.Color.White;
            this.Stalbl.Location = new System.Drawing.Point(3, 4);
            this.Stalbl.Name = "Stalbl";
            this.Stalbl.Size = new System.Drawing.Size(51, 13);
            this.Stalbl.TabIndex = 15;
            this.Stalbl.Text = "00:00:00";
            // 
            // trackBar3
            // 
            this.trackBar3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar3.AutoSize = false;
            this.trackBar3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.trackBar3.Location = new System.Drawing.Point(51, 3);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.RightToLeftLayout = true;
            this.trackBar3.Size = new System.Drawing.Size(689, 14);
            this.trackBar3.TabIndex = 11;
            this.trackBar3.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Endlbl
            // 
            this.Endlbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Endlbl.AutoSize = true;
            this.Endlbl.BackColor = System.Drawing.Color.Transparent;
            this.Endlbl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Endlbl.ForeColor = System.Drawing.Color.White;
            this.Endlbl.Location = new System.Drawing.Point(746, 4);
            this.Endlbl.Name = "Endlbl";
            this.Endlbl.Size = new System.Drawing.Size(51, 13);
            this.Endlbl.TabIndex = 18;
            this.Endlbl.Text = "00:00:00";
            // 
            // VideoLst
            // 
            this.VideoLst.BackColor = System.Drawing.Color.White;
            this.VideoLst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VideoLst.ContextMenuStrip = this.VideoLstMenu;
            this.VideoLst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VideoLst.Font = new System.Drawing.Font("Tahoma", 12F);
            this.VideoLst.ForeColor = System.Drawing.Color.Black;
            this.VideoLst.FormattingEnabled = true;
            this.VideoLst.ItemHeight = 19;
            this.VideoLst.Location = new System.Drawing.Point(0, 0);
            this.VideoLst.Name = "VideoLst";
            this.VideoLst.Size = new System.Drawing.Size(208, 397);
            this.VideoLst.TabIndex = 4;
            this.VideoLst.SelectedValueChanged += new System.EventHandler(this.VideoLstbtn_Select);
            this.VideoLst.DoubleClick += new System.EventHandler(this.VideoLstDoubleClick);
            // 
            // VideoLstMenu
            // 
            this.VideoLstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.reorderToolStripMenuItem});
            this.VideoLstMenu.Name = "contextMenuStrip1";
            this.VideoLstMenu.Size = new System.Drawing.Size(116, 48);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OnceVideoLstMenu,
            this.RepeatVideoLstMenu,
            this.RandomVideoLstMenu,
            this.playAllOnceToolStripMenuItem});
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // OnceVideoLstMenu
            // 
            this.OnceVideoLstMenu.Name = "OnceVideoLstMenu";
            this.OnceVideoLstMenu.Size = new System.Drawing.Size(119, 22);
            this.OnceVideoLstMenu.Text = "Once";
            this.OnceVideoLstMenu.Click += new System.EventHandler(this.OnceVideoLstMenu_Click);
            // 
            // RepeatVideoLstMenu
            // 
            this.RepeatVideoLstMenu.Name = "RepeatVideoLstMenu";
            this.RepeatVideoLstMenu.Size = new System.Drawing.Size(119, 22);
            this.RepeatVideoLstMenu.Text = "Repeat";
            this.RepeatVideoLstMenu.Click += new System.EventHandler(this.RepeatVideoLstMenu_Click);
            // 
            // RandomVideoLstMenu
            // 
            this.RandomVideoLstMenu.Name = "RandomVideoLstMenu";
            this.RandomVideoLstMenu.Size = new System.Drawing.Size(119, 22);
            this.RandomVideoLstMenu.Text = "Random";
            this.RandomVideoLstMenu.Click += new System.EventHandler(this.RandomVideoLstMenu_Click);
            // 
            // playAllOnceToolStripMenuItem
            // 
            this.playAllOnceToolStripMenuItem.Name = "playAllOnceToolStripMenuItem";
            this.playAllOnceToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.playAllOnceToolStripMenuItem.Text = "Play All";
            this.playAllOnceToolStripMenuItem.Click += new System.EventHandler(this.playAllOnceToolStripMenuItem_Click);
            // 
            // reorderToolStripMenuItem
            // 
            this.reorderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReverseVideoLstMenu,
            this.ByNameVideoLstMenu,
            this.ByCrationTimeVideoLstMenu,
            this.ByLenghtVideoLstMenu,
            this.ByExtensionVideoLstMenu});
            this.reorderToolStripMenuItem.Name = "reorderToolStripMenuItem";
            this.reorderToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.reorderToolStripMenuItem.Text = "Reorder";
            // 
            // ReverseVideoLstMenu
            // 
            this.ReverseVideoLstMenu.Name = "ReverseVideoLstMenu";
            this.ReverseVideoLstMenu.Size = new System.Drawing.Size(142, 22);
            this.ReverseVideoLstMenu.Text = "Reverse";
            this.ReverseVideoLstMenu.Click += new System.EventHandler(this.ReverseVideoLstMenu_Click);
            // 
            // ByNameVideoLstMenu
            // 
            this.ByNameVideoLstMenu.Name = "ByNameVideoLstMenu";
            this.ByNameVideoLstMenu.Size = new System.Drawing.Size(142, 22);
            this.ByNameVideoLstMenu.Text = "Name";
            this.ByNameVideoLstMenu.Click += new System.EventHandler(this.ByNameVideoLstMenu_Click);
            // 
            // ByCrationTimeVideoLstMenu
            // 
            this.ByCrationTimeVideoLstMenu.Name = "ByCrationTimeVideoLstMenu";
            this.ByCrationTimeVideoLstMenu.Size = new System.Drawing.Size(142, 22);
            this.ByCrationTimeVideoLstMenu.Text = "Cration Time";
            this.ByCrationTimeVideoLstMenu.Click += new System.EventHandler(this.ByCrationTimeVideoLstMenu_Click);
            // 
            // ByLenghtVideoLstMenu
            // 
            this.ByLenghtVideoLstMenu.Name = "ByLenghtVideoLstMenu";
            this.ByLenghtVideoLstMenu.Size = new System.Drawing.Size(142, 22);
            this.ByLenghtVideoLstMenu.Text = "Lenght";
            this.ByLenghtVideoLstMenu.Click += new System.EventHandler(this.ByLenghtVideoLstMenu_Click);
            // 
            // ByExtensionVideoLstMenu
            // 
            this.ByExtensionVideoLstMenu.CheckOnClick = true;
            this.ByExtensionVideoLstMenu.Name = "ByExtensionVideoLstMenu";
            this.ByExtensionVideoLstMenu.Size = new System.Drawing.Size(142, 22);
            this.ByExtensionVideoLstMenu.Text = "Extension";
            this.ByExtensionVideoLstMenu.Click += new System.EventHandler(this.ByExtensionVideoLstMenu_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.VideoLst);
            this.panel2.Location = new System.Drawing.Point(592, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 397);
            this.panel2.TabIndex = 14;
            this.panel2.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            this.panel2.MouseHover += new System.EventHandler(this.panel2_MouseHover);
            // 
            // Screenpnl
            // 
            this.Screenpnl.BackColor = System.Drawing.Color.Black;
            this.Screenpnl.Controls.Add(this.button1);
            this.Screenpnl.Controls.Add(this.VideoControlpnl);
            this.Screenpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Screenpnl.Location = new System.Drawing.Point(0, 0);
            this.Screenpnl.Name = "Screenpnl";
            this.Screenpnl.Size = new System.Drawing.Size(800, 450);
            this.Screenpnl.TabIndex = 15;
            this.Screenpnl.Click += new System.EventHandler(this.Screenpnl_Click);
            this.Screenpnl.Paint += new System.Windows.Forms.PaintEventHandler(this.Screenpnl_Paint);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 34);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // VideoControlpnl
            // 
            this.VideoControlpnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.VideoControlpnl.Controls.Add(this.dropDownButton1);
            this.VideoControlpnl.Controls.Add(this.VideoLstbtn);
            this.VideoControlpnl.Controls.Add(this.Stalbl);
            this.VideoControlpnl.Controls.Add(this.Endlbl);
            this.VideoControlpnl.Controls.Add(this.Volumelbl);
            this.VideoControlpnl.Controls.Add(this.trackBar2);
            this.VideoControlpnl.Controls.Add(this.trackBar3);
            this.VideoControlpnl.Controls.Add(this.VolumeMute);
            this.VideoControlpnl.Controls.Add(this.Nxtbtn);
            this.VideoControlpnl.Controls.Add(this.PausResbtn);
            this.VideoControlpnl.Controls.Add(this.Prebtn);
            this.VideoControlpnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.VideoControlpnl.Location = new System.Drawing.Point(0, 397);
            this.VideoControlpnl.Name = "VideoControlpnl";
            this.VideoControlpnl.Size = new System.Drawing.Size(800, 53);
            this.VideoControlpnl.TabIndex = 0;
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dropDownButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.dropDownButton1.BackColor = System.Drawing.Color.White;
            this.dropDownButton1.BorderColor = System.Drawing.Color.White;
            this.dropDownButton1.ContextMenuStrip = this.ScreenMode;
            this.dropDownButton1.DropDown = this.ScreenMode;
            this.dropDownButton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.dropDownButton1.FlatAppearance.BorderSize = 0;
            this.dropDownButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.dropDownButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.dropDownButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.dropDownButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.dropDownButton1.Location = new System.Drawing.Point(695, 24);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(93, 23);
            this.dropDownButton1.TabIndex = 15;
            this.dropDownButton1.Text = "Screen Mode";
            this.dropDownButton1.UseVisualStyleBackColor = false;
            // 
            // VideoLstbtn
            // 
            this.VideoLstbtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.VideoLstbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.VideoLstbtn.FlatAppearance.BorderSize = 0;
            this.VideoLstbtn.Font = new System.Drawing.Font("Tahoma", 8F);
            this.VideoLstbtn.ForeColor = System.Drawing.Color.Transparent;
            this.VideoLstbtn.Location = new System.Drawing.Point(658, 23);
            this.VideoLstbtn.Name = "VideoLstbtn";
            this.VideoLstbtn.Size = new System.Drawing.Size(26, 23);
            this.VideoLstbtn.TabIndex = 13;
            this.VideoLstbtn.UseVisualStyleBackColor = true;
            this.VideoLstbtn.Click += new System.EventHandler(this.VideoLstbtn_Click);
            // 
            // VideoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Screenpnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VideoPlayer";
            this.ShowIcon = false;
            this.Text = "Video Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VideoPlayer_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VideoPlayer_FormClosed);
            this.Load += new System.EventHandler(this.VideoPlayer_Load);
            this.Click += new System.EventHandler(this.VideoPlayer_Click);
            this.DoubleClick += new System.EventHandler(this.VideoPlayer_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ScreenMode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.VideoLstMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.Screenpnl.ResumeLayout(false);
            this.VideoControlpnl.ResumeLayout(false);
            this.VideoControlpnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button PausResbtn;
        private System.Windows.Forms.Button Prebtn;
        private System.Windows.Forms.Button Nxtbtn;
        private System.Windows.Forms.ListBox VideoLst;
        private System.Windows.Forms.ContextMenuStrip VideoLstMenu;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OnceVideoLstMenu;
        private System.Windows.Forms.ToolStripMenuItem RepeatVideoLstMenu;
        private System.Windows.Forms.ToolStripMenuItem RandomVideoLstMenu;
        private System.Windows.Forms.ToolStripMenuItem playAllOnceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reorderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReverseVideoLstMenu;
        private System.Windows.Forms.ToolStripMenuItem ByNameVideoLstMenu;
        private System.Windows.Forms.ToolStripMenuItem ByCrationTimeVideoLstMenu;
        private System.Windows.Forms.ToolStripMenuItem ByLenghtVideoLstMenu;
        private System.Windows.Forms.ToolStripMenuItem ByExtensionVideoLstMenu;
        private System.Windows.Forms.Button VolumeMute;
        private System.Windows.Forms.Label Volumelbl;
        private System.Windows.Forms.Panel panel2;
        private DropDownButton dropDownButton1;
        private System.Windows.Forms.ContextMenuStrip ScreenMode;
        private System.Windows.Forms.ToolStripMenuItem NormalModeToolbtn;
        private System.Windows.Forms.ToolStripMenuItem ZoomCenterModeToolbtn;
        private System.Windows.Forms.ToolStripMenuItem ZoomModeToolbtn;
        private System.Windows.Forms.ToolStripMenuItem sizeToFitCenterToolbtn;
        private System.Windows.Forms.ToolStripMenuItem ZiseToFitModeToolbtn;
        private System.Windows.Forms.ToolStripMenuItem ManualModeToolbtn;
        private System.Windows.Forms.ToolStripMenuItem CenterModeToolbtn;
        private System.Windows.Forms.ToolStripMenuItem CoverCenterModebtn;
        private System.Windows.Forms.ToolStripMenuItem StrectchToolbtn;
        private System.Windows.Forms.Label Stalbl;
        private System.Windows.Forms.Label Endlbl;
        private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Panel Screenpnl;
        private System.Windows.Forms.Panel VideoControlpnl;
        private System.Windows.Forms.Button VideoLstbtn;
        private System.Windows.Forms.Button button1;
    }
}