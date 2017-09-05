namespace CS2DHookCS.UI
{
    partial class NewForm
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
            if(disposing && (components != null))
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
            this.nsTheme1 = new NetSeal.NSTheme();
            this.nsTabControl1 = new NetSeal.NSTabControl();
            this.AimbotTab = new System.Windows.Forms.TabPage();
            this.GroupboxHitscan = new NetSeal.NSGroupBox();
            this.TrackBarHitscanRange = new NetSeal.NSTrackBar();
            this.CheckBoxAutoShoot = new NetSeal.NSCheckBox();
            this.CheckBoxAimbotTeam = new NetSeal.NSCheckBox();
            this.ComboBoxHitscan = new NetSeal.NSComboBox();
            this.CheckBoxMultiHitscan = new NetSeal.NSCheckBox();
            this.CheckBoxNoRecoil = new NetSeal.NSCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nsOnOffBox2 = new NetSeal.NSOnOffBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckBoxSilentAim = new NetSeal.NSOnOffBox();
            this.EspTab = new System.Windows.Forms.TabPage();
            this.CheckboxEspHealthColor = new NetSeal.NSCheckBox();
            this.CheckboxEspTeam = new NetSeal.NSCheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CheckboxEspBoxes = new NetSeal.NSOnOffBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckboxEspLines = new NetSeal.NSOnOffBox();
            this.RemovalsTab = new System.Windows.Forms.TabPage();
            this.GroupboxScopeAlpha = new NetSeal.NSGroupBox();
            this.TrackbarScopeAlpha = new NetSeal.NSTrackBar();
            this.Checkboxx2Scope = new NetSeal.NSCheckBox();
            this.CheckboxAntiFX = new NetSeal.NSCheckBox();
            this.CheckboxAntiTree = new NetSeal.NSCheckBox();
            this.CheckboxAntiFlash = new NetSeal.NSCheckBox();
            this.VisualsTab = new System.Windows.Forms.TabPage();
            this.GroupboxMapAlpha = new NetSeal.NSGroupBox();
            this.ButtonMapBgColor = new NetSeal.NSButton();
            this.CheckboxHideMapBg = new NetSeal.NSCheckBox();
            this.TrackbarMapAlpha = new NetSeal.NSTrackBar();
            this.SpeedhackTab = new System.Windows.Forms.TabPage();
            this.GroupBoxSpinBot = new NetSeal.NSGroupBox();
            this.TrackbarSpinbot = new NetSeal.NSTrackBar();
            this.CheckBoxSpinbot = new NetSeal.NSOnOffBox();
            this.GroupboxSpeedhack = new NetSeal.NSGroupBox();
            this.TrackbarSpeedhack = new NetSeal.NSTrackBar();
            this.ButtonExit = new NetSeal.NSControlButton();
            this.nsTheme1.SuspendLayout();
            this.nsTabControl1.SuspendLayout();
            this.AimbotTab.SuspendLayout();
            this.GroupboxHitscan.SuspendLayout();
            this.EspTab.SuspendLayout();
            this.RemovalsTab.SuspendLayout();
            this.GroupboxScopeAlpha.SuspendLayout();
            this.VisualsTab.SuspendLayout();
            this.GroupboxMapAlpha.SuspendLayout();
            this.SpeedhackTab.SuspendLayout();
            this.GroupBoxSpinBot.SuspendLayout();
            this.GroupboxSpeedhack.SuspendLayout();
            this.SuspendLayout();
            // 
            // nsTheme1
            // 
            this.nsTheme1.AccentOffset = 0;
            this.nsTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.nsTheme1.Colors = new Bloom[0];
            this.nsTheme1.Controls.Add(this.nsTabControl1);
            this.nsTheme1.Controls.Add(this.ButtonExit);
            this.nsTheme1.Customization = "";
            this.nsTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nsTheme1.Font = new System.Drawing.Font("Verdana", 8F);
            this.nsTheme1.Image = null;
            this.nsTheme1.Location = new System.Drawing.Point(0, 0);
            this.nsTheme1.Movable = true;
            this.nsTheme1.Name = "nsTheme1";
            this.nsTheme1.NoRounding = false;
            this.nsTheme1.Sizable = false;
            this.nsTheme1.Size = new System.Drawing.Size(455, 251);
            this.nsTheme1.SmartBounds = true;
            this.nsTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.nsTheme1.TabIndex = 0;
            this.nsTheme1.Text = "CS2D Hack by PuL9 [1.0]";
            this.nsTheme1.TransparencyKey = System.Drawing.Color.Empty;
            this.nsTheme1.Transparent = false;
            // 
            // nsTabControl1
            // 
            this.nsTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.nsTabControl1.Controls.Add(this.AimbotTab);
            this.nsTabControl1.Controls.Add(this.EspTab);
            this.nsTabControl1.Controls.Add(this.RemovalsTab);
            this.nsTabControl1.Controls.Add(this.VisualsTab);
            this.nsTabControl1.Controls.Add(this.SpeedhackTab);
            this.nsTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.nsTabControl1.ItemSize = new System.Drawing.Size(28, 115);
            this.nsTabControl1.Location = new System.Drawing.Point(12, 39);
            this.nsTabControl1.Multiline = true;
            this.nsTabControl1.Name = "nsTabControl1";
            this.nsTabControl1.SelectedIndex = 0;
            this.nsTabControl1.Size = new System.Drawing.Size(431, 203);
            this.nsTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.nsTabControl1.TabIndex = 1;
            // 
            // AimbotTab
            // 
            this.AimbotTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.AimbotTab.Controls.Add(this.GroupboxHitscan);
            this.AimbotTab.Controls.Add(this.CheckBoxAutoShoot);
            this.AimbotTab.Controls.Add(this.CheckBoxAimbotTeam);
            this.AimbotTab.Controls.Add(this.ComboBoxHitscan);
            this.AimbotTab.Controls.Add(this.CheckBoxMultiHitscan);
            this.AimbotTab.Controls.Add(this.CheckBoxNoRecoil);
            this.AimbotTab.Controls.Add(this.label2);
            this.AimbotTab.Controls.Add(this.nsOnOffBox2);
            this.AimbotTab.Controls.Add(this.label1);
            this.AimbotTab.Controls.Add(this.CheckBoxSilentAim);
            this.AimbotTab.Location = new System.Drawing.Point(119, 4);
            this.AimbotTab.Name = "AimbotTab";
            this.AimbotTab.Padding = new System.Windows.Forms.Padding(3);
            this.AimbotTab.Size = new System.Drawing.Size(308, 195);
            this.AimbotTab.TabIndex = 0;
            this.AimbotTab.Text = "Aimbot";
            // 
            // GroupboxHitscan
            // 
            this.GroupboxHitscan.Controls.Add(this.TrackBarHitscanRange);
            this.GroupboxHitscan.DrawSeperator = false;
            this.GroupboxHitscan.Location = new System.Drawing.Point(9, 130);
            this.GroupboxHitscan.Name = "GroupboxHitscan";
            this.GroupboxHitscan.Size = new System.Drawing.Size(293, 59);
            this.GroupboxHitscan.SubTitle = "10";
            this.GroupboxHitscan.TabIndex = 9;
            this.GroupboxHitscan.Text = "nsGroupBox1";
            this.GroupboxHitscan.Title = "Multi hitscan range";
            // 
            // TrackBarHitscanRange
            // 
            this.TrackBarHitscanRange.Location = new System.Drawing.Point(3, 35);
            this.TrackBarHitscanRange.Maximum = 16;
            this.TrackBarHitscanRange.Minimum = 1;
            this.TrackBarHitscanRange.Name = "TrackBarHitscanRange";
            this.TrackBarHitscanRange.Size = new System.Drawing.Size(287, 23);
            this.TrackBarHitscanRange.TabIndex = 0;
            this.TrackBarHitscanRange.Value = 10;
            this.TrackBarHitscanRange.Scroll += new NetSeal.NSTrackBar.ScrollEventHandler(this.TrackBarHitscanRange_Scroll);
            // 
            // CheckBoxAutoShoot
            // 
            this.CheckBoxAutoShoot.Checked = true;
            this.CheckBoxAutoShoot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBoxAutoShoot.Location = new System.Drawing.Point(95, 101);
            this.CheckBoxAutoShoot.Name = "CheckBoxAutoShoot";
            this.CheckBoxAutoShoot.Size = new System.Drawing.Size(110, 23);
            this.CheckBoxAutoShoot.TabIndex = 8;
            this.CheckBoxAutoShoot.Text = "Auto shoot";
            // 
            // CheckBoxAimbotTeam
            // 
            this.CheckBoxAimbotTeam.Checked = false;
            this.CheckBoxAimbotTeam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBoxAimbotTeam.Location = new System.Drawing.Point(9, 101);
            this.CheckBoxAimbotTeam.Name = "CheckBoxAimbotTeam";
            this.CheckBoxAimbotTeam.Size = new System.Drawing.Size(110, 23);
            this.CheckBoxAimbotTeam.TabIndex = 7;
            this.CheckBoxAimbotTeam.Text = "Team";
            // 
            // ComboBoxHitscan
            // 
            this.ComboBoxHitscan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ComboBoxHitscan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxHitscan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxHitscan.ForeColor = System.Drawing.Color.White;
            this.ComboBoxHitscan.FormattingEnabled = true;
            this.ComboBoxHitscan.Items.AddRange(new object[] {
            "Pole",
            "Box"});
            this.ComboBoxHitscan.Location = new System.Drawing.Point(211, 72);
            this.ComboBoxHitscan.Name = "ComboBoxHitscan";
            this.ComboBoxHitscan.Size = new System.Drawing.Size(91, 21);
            this.ComboBoxHitscan.TabIndex = 6;
            // 
            // CheckBoxMultiHitscan
            // 
            this.CheckBoxMultiHitscan.Checked = true;
            this.CheckBoxMultiHitscan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBoxMultiHitscan.Location = new System.Drawing.Point(95, 72);
            this.CheckBoxMultiHitscan.Name = "CheckBoxMultiHitscan";
            this.CheckBoxMultiHitscan.Size = new System.Drawing.Size(110, 23);
            this.CheckBoxMultiHitscan.TabIndex = 5;
            this.CheckBoxMultiHitscan.Text = "Multi hitscan";
            // 
            // CheckBoxNoRecoil
            // 
            this.CheckBoxNoRecoil.Checked = true;
            this.CheckBoxNoRecoil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBoxNoRecoil.Location = new System.Drawing.Point(9, 72);
            this.CheckBoxNoRecoil.Name = "CheckBoxNoRecoil";
            this.CheckBoxNoRecoil.Size = new System.Drawing.Size(110, 23);
            this.CheckBoxNoRecoil.TabIndex = 4;
            this.CheckBoxNoRecoil.Text = "No recoil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trigger aimbot";
            // 
            // nsOnOffBox2
            // 
            this.nsOnOffBox2.Checked = false;
            this.nsOnOffBox2.Enabled = false;
            this.nsOnOffBox2.Location = new System.Drawing.Point(249, 33);
            this.nsOnOffBox2.MaximumSize = new System.Drawing.Size(56, 24);
            this.nsOnOffBox2.MinimumSize = new System.Drawing.Size(56, 24);
            this.nsOnOffBox2.Name = "nsOnOffBox2";
            this.nsOnOffBox2.Size = new System.Drawing.Size(56, 24);
            this.nsOnOffBox2.TabIndex = 2;
            this.nsOnOffBox2.Text = "nsOnOffBox2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Silent aimbot";
            // 
            // CheckBoxSilentAim
            // 
            this.CheckBoxSilentAim.Checked = true;
            this.CheckBoxSilentAim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBoxSilentAim.Location = new System.Drawing.Point(249, 3);
            this.CheckBoxSilentAim.MaximumSize = new System.Drawing.Size(56, 24);
            this.CheckBoxSilentAim.MinimumSize = new System.Drawing.Size(56, 24);
            this.CheckBoxSilentAim.Name = "CheckBoxSilentAim";
            this.CheckBoxSilentAim.Size = new System.Drawing.Size(56, 24);
            this.CheckBoxSilentAim.TabIndex = 0;
            this.CheckBoxSilentAim.Text = "nsOnOffBox1";
            // 
            // EspTab
            // 
            this.EspTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EspTab.Controls.Add(this.CheckboxEspHealthColor);
            this.EspTab.Controls.Add(this.CheckboxEspTeam);
            this.EspTab.Controls.Add(this.label4);
            this.EspTab.Controls.Add(this.CheckboxEspBoxes);
            this.EspTab.Controls.Add(this.label3);
            this.EspTab.Controls.Add(this.CheckboxEspLines);
            this.EspTab.Location = new System.Drawing.Point(119, 4);
            this.EspTab.Name = "EspTab";
            this.EspTab.Size = new System.Drawing.Size(308, 195);
            this.EspTab.TabIndex = 1;
            this.EspTab.Text = "ESP";
            // 
            // CheckboxEspHealthColor
            // 
            this.CheckboxEspHealthColor.Checked = true;
            this.CheckboxEspHealthColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckboxEspHealthColor.Location = new System.Drawing.Point(98, 64);
            this.CheckboxEspHealthColor.Name = "CheckboxEspHealthColor";
            this.CheckboxEspHealthColor.Size = new System.Drawing.Size(110, 23);
            this.CheckboxEspHealthColor.TabIndex = 7;
            this.CheckboxEspHealthColor.Text = "Health color";
            // 
            // CheckboxEspTeam
            // 
            this.CheckboxEspTeam.Checked = false;
            this.CheckboxEspTeam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckboxEspTeam.Location = new System.Drawing.Point(12, 64);
            this.CheckboxEspTeam.Name = "CheckboxEspTeam";
            this.CheckboxEspTeam.Size = new System.Drawing.Size(110, 23);
            this.CheckboxEspTeam.TabIndex = 6;
            this.CheckboxEspTeam.Text = "Team";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Boxes";
            // 
            // CheckboxEspBoxes
            // 
            this.CheckboxEspBoxes.Checked = true;
            this.CheckboxEspBoxes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckboxEspBoxes.Location = new System.Drawing.Point(249, 33);
            this.CheckboxEspBoxes.MaximumSize = new System.Drawing.Size(56, 24);
            this.CheckboxEspBoxes.MinimumSize = new System.Drawing.Size(56, 24);
            this.CheckboxEspBoxes.Name = "CheckboxEspBoxes";
            this.CheckboxEspBoxes.Size = new System.Drawing.Size(56, 24);
            this.CheckboxEspBoxes.TabIndex = 4;
            this.CheckboxEspBoxes.Text = "nsOnOffBox3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lines";
            // 
            // CheckboxEspLines
            // 
            this.CheckboxEspLines.Checked = true;
            this.CheckboxEspLines.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckboxEspLines.Location = new System.Drawing.Point(249, 3);
            this.CheckboxEspLines.MaximumSize = new System.Drawing.Size(56, 24);
            this.CheckboxEspLines.MinimumSize = new System.Drawing.Size(56, 24);
            this.CheckboxEspLines.Name = "CheckboxEspLines";
            this.CheckboxEspLines.Size = new System.Drawing.Size(56, 24);
            this.CheckboxEspLines.TabIndex = 2;
            this.CheckboxEspLines.Text = "nsOnOffBox1";
            // 
            // RemovalsTab
            // 
            this.RemovalsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.RemovalsTab.Controls.Add(this.GroupboxScopeAlpha);
            this.RemovalsTab.Controls.Add(this.Checkboxx2Scope);
            this.RemovalsTab.Controls.Add(this.CheckboxAntiFX);
            this.RemovalsTab.Controls.Add(this.CheckboxAntiTree);
            this.RemovalsTab.Controls.Add(this.CheckboxAntiFlash);
            this.RemovalsTab.Location = new System.Drawing.Point(119, 4);
            this.RemovalsTab.Name = "RemovalsTab";
            this.RemovalsTab.Size = new System.Drawing.Size(308, 195);
            this.RemovalsTab.TabIndex = 2;
            this.RemovalsTab.Text = "Removals";
            // 
            // GroupboxScopeAlpha
            // 
            this.GroupboxScopeAlpha.Controls.Add(this.TrackbarScopeAlpha);
            this.GroupboxScopeAlpha.DrawSeperator = false;
            this.GroupboxScopeAlpha.Location = new System.Drawing.Point(9, 66);
            this.GroupboxScopeAlpha.Name = "GroupboxScopeAlpha";
            this.GroupboxScopeAlpha.Size = new System.Drawing.Size(293, 59);
            this.GroupboxScopeAlpha.SubTitle = "100";
            this.GroupboxScopeAlpha.TabIndex = 12;
            this.GroupboxScopeAlpha.Text = "nsGroupBox1";
            this.GroupboxScopeAlpha.Title = "Scope alpha";
            // 
            // TrackbarScopeAlpha
            // 
            this.TrackbarScopeAlpha.Location = new System.Drawing.Point(3, 35);
            this.TrackbarScopeAlpha.Maximum = 100;
            this.TrackbarScopeAlpha.Minimum = 0;
            this.TrackbarScopeAlpha.Name = "TrackbarScopeAlpha";
            this.TrackbarScopeAlpha.Size = new System.Drawing.Size(287, 23);
            this.TrackbarScopeAlpha.TabIndex = 0;
            this.TrackbarScopeAlpha.Value = 100;
            this.TrackbarScopeAlpha.Scroll += new NetSeal.NSTrackBar.ScrollEventHandler(this.TrackbarScopeAlpha_Scroll);
            // 
            // Checkboxx2Scope
            // 
            this.Checkboxx2Scope.Checked = true;
            this.Checkboxx2Scope.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Checkboxx2Scope.Location = new System.Drawing.Point(151, 37);
            this.Checkboxx2Scope.Name = "Checkboxx2Scope";
            this.Checkboxx2Scope.Size = new System.Drawing.Size(136, 23);
            this.Checkboxx2Scope.TabIndex = 11;
            this.Checkboxx2Scope.Text = "x2 Scope";
            this.Checkboxx2Scope.CheckedChanged += new NetSeal.NSCheckBox.CheckedChangedEventHandler(this.Checkboxx2Scope_CheckedChanged);
            // 
            // CheckboxAntiFX
            // 
            this.CheckboxAntiFX.Checked = true;
            this.CheckboxAntiFX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckboxAntiFX.Location = new System.Drawing.Point(9, 37);
            this.CheckboxAntiFX.Name = "CheckboxAntiFX";
            this.CheckboxAntiFX.Size = new System.Drawing.Size(136, 23);
            this.CheckboxAntiFX.TabIndex = 10;
            this.CheckboxAntiFX.Text = "Anti FX";
            this.CheckboxAntiFX.CheckedChanged += new NetSeal.NSCheckBox.CheckedChangedEventHandler(this.CheckboxAntiFX_CheckedChanged);
            // 
            // CheckboxAntiTree
            // 
            this.CheckboxAntiTree.Checked = true;
            this.CheckboxAntiTree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckboxAntiTree.Location = new System.Drawing.Point(151, 8);
            this.CheckboxAntiTree.Name = "CheckboxAntiTree";
            this.CheckboxAntiTree.Size = new System.Drawing.Size(136, 23);
            this.CheckboxAntiTree.TabIndex = 9;
            this.CheckboxAntiTree.Text = "Anti tree";
            this.CheckboxAntiTree.CheckedChanged += new NetSeal.NSCheckBox.CheckedChangedEventHandler(this.CheckboxAntiTree_CheckedChanged);
            // 
            // CheckboxAntiFlash
            // 
            this.CheckboxAntiFlash.Checked = true;
            this.CheckboxAntiFlash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckboxAntiFlash.Location = new System.Drawing.Point(9, 8);
            this.CheckboxAntiFlash.Name = "CheckboxAntiFlash";
            this.CheckboxAntiFlash.Size = new System.Drawing.Size(136, 23);
            this.CheckboxAntiFlash.TabIndex = 8;
            this.CheckboxAntiFlash.Text = "Anti flash & smoke";
            this.CheckboxAntiFlash.CheckedChanged += new NetSeal.NSCheckBox.CheckedChangedEventHandler(this.CheckboxAntiFlash_CheckedChanged);
            // 
            // VisualsTab
            // 
            this.VisualsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.VisualsTab.Controls.Add(this.GroupboxMapAlpha);
            this.VisualsTab.Location = new System.Drawing.Point(119, 4);
            this.VisualsTab.Name = "VisualsTab";
            this.VisualsTab.Size = new System.Drawing.Size(308, 195);
            this.VisualsTab.TabIndex = 3;
            this.VisualsTab.Text = "Visuals";
            // 
            // GroupboxMapAlpha
            // 
            this.GroupboxMapAlpha.Controls.Add(this.ButtonMapBgColor);
            this.GroupboxMapAlpha.Controls.Add(this.CheckboxHideMapBg);
            this.GroupboxMapAlpha.Controls.Add(this.TrackbarMapAlpha);
            this.GroupboxMapAlpha.DrawSeperator = false;
            this.GroupboxMapAlpha.Location = new System.Drawing.Point(7, 6);
            this.GroupboxMapAlpha.Name = "GroupboxMapAlpha";
            this.GroupboxMapAlpha.Size = new System.Drawing.Size(293, 81);
            this.GroupboxMapAlpha.SubTitle = "100";
            this.GroupboxMapAlpha.TabIndex = 14;
            this.GroupboxMapAlpha.Text = "Map alpha";
            this.GroupboxMapAlpha.Title = "Map alpha";
            // 
            // ButtonMapBgColor
            // 
            this.ButtonMapBgColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ButtonMapBgColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMapBgColor.Location = new System.Drawing.Point(189, 58);
            this.ButtonMapBgColor.Name = "ButtonMapBgColor";
            this.ButtonMapBgColor.Size = new System.Drawing.Size(101, 20);
            this.ButtonMapBgColor.TabIndex = 15;
            this.ButtonMapBgColor.Text = "BG Color";
            this.ButtonMapBgColor.Click += new System.EventHandler(this.ButtonMapBgColor_Click);
            // 
            // CheckboxHideMapBg
            // 
            this.CheckboxHideMapBg.Checked = false;
            this.CheckboxHideMapBg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckboxHideMapBg.Location = new System.Drawing.Point(3, 59);
            this.CheckboxHideMapBg.Name = "CheckboxHideMapBg";
            this.CheckboxHideMapBg.Size = new System.Drawing.Size(161, 21);
            this.CheckboxHideMapBg.TabIndex = 1;
            this.CheckboxHideMapBg.Text = "Hide background image";
            this.CheckboxHideMapBg.CheckedChanged += new NetSeal.NSCheckBox.CheckedChangedEventHandler(this.CheckboxHideMapBg_CheckedChanged);
            // 
            // TrackbarMapAlpha
            // 
            this.TrackbarMapAlpha.Location = new System.Drawing.Point(3, 35);
            this.TrackbarMapAlpha.Maximum = 100;
            this.TrackbarMapAlpha.Minimum = 0;
            this.TrackbarMapAlpha.Name = "TrackbarMapAlpha";
            this.TrackbarMapAlpha.Size = new System.Drawing.Size(287, 23);
            this.TrackbarMapAlpha.TabIndex = 0;
            this.TrackbarMapAlpha.Value = 100;
            this.TrackbarMapAlpha.Scroll += new NetSeal.NSTrackBar.ScrollEventHandler(this.TrackbarMapAlpha_Scroll);
            // 
            // SpeedhackTab
            // 
            this.SpeedhackTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SpeedhackTab.Controls.Add(this.GroupBoxSpinBot);
            this.SpeedhackTab.Controls.Add(this.GroupboxSpeedhack);
            this.SpeedhackTab.Location = new System.Drawing.Point(119, 4);
            this.SpeedhackTab.Name = "SpeedhackTab";
            this.SpeedhackTab.Padding = new System.Windows.Forms.Padding(3);
            this.SpeedhackTab.Size = new System.Drawing.Size(308, 195);
            this.SpeedhackTab.TabIndex = 4;
            this.SpeedhackTab.Text = "Speedhack";
            // 
            // GroupBoxSpinBot
            // 
            this.GroupBoxSpinBot.Controls.Add(this.TrackbarSpinbot);
            this.GroupBoxSpinBot.Controls.Add(this.CheckBoxSpinbot);
            this.GroupBoxSpinBot.DrawSeperator = false;
            this.GroupBoxSpinBot.Location = new System.Drawing.Point(7, 71);
            this.GroupBoxSpinBot.Name = "GroupBoxSpinBot";
            this.GroupBoxSpinBot.Size = new System.Drawing.Size(293, 59);
            this.GroupBoxSpinBot.SubTitle = "0";
            this.GroupBoxSpinBot.TabIndex = 14;
            this.GroupBoxSpinBot.Title = "Spinbot";
            // 
            // TrackbarSpinbot
            // 
            this.TrackbarSpinbot.Location = new System.Drawing.Point(3, 35);
            this.TrackbarSpinbot.Maximum = 5000;
            this.TrackbarSpinbot.Minimum = 0;
            this.TrackbarSpinbot.Name = "TrackbarSpinbot";
            this.TrackbarSpinbot.Size = new System.Drawing.Size(287, 23);
            this.TrackbarSpinbot.TabIndex = 0;
            this.TrackbarSpinbot.Value = 0;
            this.TrackbarSpinbot.Scroll += new NetSeal.NSTrackBar.ScrollEventHandler(this.TrackbarSpinbot_Scroll);
            // 
            // CheckBoxSpinbot
            // 
            this.CheckBoxSpinbot.Checked = false;
            this.CheckBoxSpinbot.Location = new System.Drawing.Point(234, 3);
            this.CheckBoxSpinbot.MaximumSize = new System.Drawing.Size(56, 24);
            this.CheckBoxSpinbot.MinimumSize = new System.Drawing.Size(56, 24);
            this.CheckBoxSpinbot.Name = "CheckBoxSpinbot";
            this.CheckBoxSpinbot.Size = new System.Drawing.Size(56, 24);
            this.CheckBoxSpinbot.TabIndex = 1;
            this.CheckBoxSpinbot.CheckedChanged += new NetSeal.NSOnOffBox.CheckedChangedEventHandler(this.CheckBoxSpinbot_CheckedChanged);
            // 
            // GroupboxSpeedhack
            // 
            this.GroupboxSpeedhack.Controls.Add(this.TrackbarSpeedhack);
            this.GroupboxSpeedhack.DrawSeperator = false;
            this.GroupboxSpeedhack.Location = new System.Drawing.Point(9, 6);
            this.GroupboxSpeedhack.Name = "GroupboxSpeedhack";
            this.GroupboxSpeedhack.Size = new System.Drawing.Size(293, 59);
            this.GroupboxSpeedhack.SubTitle = "100";
            this.GroupboxSpeedhack.TabIndex = 13;
            this.GroupboxSpeedhack.Title = "Speedhack";
            // 
            // TrackbarSpeedhack
            // 
            this.TrackbarSpeedhack.Location = new System.Drawing.Point(3, 35);
            this.TrackbarSpeedhack.Maximum = 200;
            this.TrackbarSpeedhack.Minimum = 0;
            this.TrackbarSpeedhack.Name = "TrackbarSpeedhack";
            this.TrackbarSpeedhack.Size = new System.Drawing.Size(287, 23);
            this.TrackbarSpeedhack.TabIndex = 14;
            this.TrackbarSpeedhack.Value = 100;
            this.TrackbarSpeedhack.Scroll += new NetSeal.NSTrackBar.ScrollEventHandler(this.TrackbarSpeedhack_Scroll);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonExit.ControlButton = NetSeal.NSControlButton.Button.Close;
            this.ButtonExit.Location = new System.Drawing.Point(430, 4);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonExit.MaximumSize = new System.Drawing.Size(18, 20);
            this.ButtonExit.MinimumSize = new System.Drawing.Size(18, 20);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(18, 20);
            this.ButtonExit.TabIndex = 0;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // NewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 251);
            this.Controls.Add(this.nsTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewForm";
            this.nsTheme1.ResumeLayout(false);
            this.nsTabControl1.ResumeLayout(false);
            this.AimbotTab.ResumeLayout(false);
            this.AimbotTab.PerformLayout();
            this.GroupboxHitscan.ResumeLayout(false);
            this.EspTab.ResumeLayout(false);
            this.EspTab.PerformLayout();
            this.RemovalsTab.ResumeLayout(false);
            this.GroupboxScopeAlpha.ResumeLayout(false);
            this.VisualsTab.ResumeLayout(false);
            this.GroupboxMapAlpha.ResumeLayout(false);
            this.SpeedhackTab.ResumeLayout(false);
            this.GroupBoxSpinBot.ResumeLayout(false);
            this.GroupboxSpeedhack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NetSeal.NSTheme nsTheme1;
        private NetSeal.NSControlButton ButtonExit;
        private NetSeal.NSTabControl nsTabControl1;
        private System.Windows.Forms.TabPage AimbotTab;
        private System.Windows.Forms.TabPage EspTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private NetSeal.NSOnOffBox nsOnOffBox2;
        public NetSeal.NSOnOffBox CheckBoxSilentAim;
        public NetSeal.NSCheckBox CheckBoxNoRecoil;
        public NetSeal.NSCheckBox CheckBoxMultiHitscan;
        public NetSeal.NSComboBox ComboBoxHitscan;
        public NetSeal.NSCheckBox CheckBoxAimbotTeam;
        public NetSeal.NSCheckBox CheckBoxAutoShoot;
        private NetSeal.NSGroupBox GroupboxHitscan;
        private NetSeal.NSTrackBar TrackBarHitscanRange;
        private System.Windows.Forms.Label label3;
        public NetSeal.NSOnOffBox CheckboxEspLines;
        private System.Windows.Forms.Label label4;
        public NetSeal.NSOnOffBox CheckboxEspBoxes;
        public NetSeal.NSCheckBox CheckboxEspHealthColor;
        public NetSeal.NSCheckBox CheckboxEspTeam;
        private System.Windows.Forms.TabPage RemovalsTab;
        public NetSeal.NSCheckBox CheckboxAntiFlash;
        public NetSeal.NSCheckBox CheckboxAntiFX;
        public NetSeal.NSCheckBox CheckboxAntiTree;
        public NetSeal.NSCheckBox Checkboxx2Scope;
        private NetSeal.NSGroupBox GroupboxScopeAlpha;
        private NetSeal.NSTrackBar TrackbarScopeAlpha;
        private System.Windows.Forms.TabPage VisualsTab;
        private NetSeal.NSGroupBox GroupboxMapAlpha;
        private NetSeal.NSTrackBar TrackbarMapAlpha;
        private NetSeal.NSCheckBox CheckboxHideMapBg;
        private NetSeal.NSButton ButtonMapBgColor;
        private System.Windows.Forms.TabPage SpeedhackTab;
        private NetSeal.NSGroupBox GroupBoxSpinBot;
        private NetSeal.NSGroupBox GroupboxSpeedhack;
        private NetSeal.NSTrackBar TrackbarSpeedhack;
        public NetSeal.NSTrackBar TrackbarSpinbot;
        public NetSeal.NSOnOffBox CheckBoxSpinbot;
    }
}