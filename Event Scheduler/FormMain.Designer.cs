namespace Event_Scheduler
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            Hourglass.HourglassOptions hourglassOptions1 = new Hourglass.HourglassOptions();
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.buttonViewType = new Kimtoo.ButtonGroup();
            this.hgScheduler = new Hourglass.HgScheduler();
            this.btnAdd = new System.Windows.Forms.Button();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkGoogle = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.checkUrgent = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.checkWork = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.checkPersonal = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.calendarControl1 = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Init = new System.Windows.Forms.Timer(this.components);
            this.Alert = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.titleBar = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnGoogle = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.getEvent = new System.Windows.Forms.Timer(this.components);
            this.notifyTimer = new System.Windows.Forms.Timer(this.components);
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.bunifuPanel3.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BorderRadius = 20;
            this.bunifuPanel3.BorderThickness = 1;
            this.bunifuPanel3.Controls.Add(this.buttonViewType);
            this.bunifuPanel3.Controls.Add(this.hgScheduler);
            this.bunifuPanel3.Controls.Add(this.btnAdd);
            this.bunifuPanel3.Location = new System.Drawing.Point(371, 75);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.ShowBorders = true;
            this.bunifuPanel3.Size = new System.Drawing.Size(950, 638);
            this.bunifuPanel3.TabIndex = 6;
            // 
            // buttonViewType
            // 
            this.buttonViewType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonViewType.BackColor = System.Drawing.Color.White;
            this.buttonViewType.BackColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(220)))), ((int)(((byte)(168)))));
            this.buttonViewType.ButtonSpacing = 60;
            this.buttonViewType.CurrentSelection = "Day";
            this.buttonViewType.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewType.FontActive = null;
            this.buttonViewType.ForeColorActive = System.Drawing.Color.White;
            this.buttonViewType.Items = new string[] {
        "Day",
        "Week",
        "Month"};
            this.buttonViewType.Location = new System.Drawing.Point(712, 18);
            this.buttonViewType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonViewType.Name = "buttonViewType";
            this.buttonViewType.Orientation = Kimtoo.ButtonGroup.ButtongrupOrientation.Horizontal;
            this.buttonViewType.Size = new System.Drawing.Size(205, 38);
            this.buttonViewType.TabIndex = 11;
            this.buttonViewType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonViewType.OnSelectionChange += new System.EventHandler(this.buttonViewType_OnSelectionChange);
            // 
            // hgScheduler
            // 
            this.hgScheduler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hgScheduler.BackColor = System.Drawing.Color.White;
            this.hgScheduler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hgScheduler.Location = new System.Drawing.Point(18, 64);
            this.hgScheduler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hgScheduler.Name = "hgScheduler";
            hourglassOptions1.EventArrangement = null;
            hourglassOptions1.EventClickHandling = null;
            hourglassOptions1.EventDeleteHandling = null;
            hourglassOptions1.EventDoubleClickHandling = null;
            hourglassOptions1.HeaderDateFormat = "dddd";
            hourglassOptions1.StartDate = new System.DateTime(2023, 4, 15, 13, 58, 53, 261);
            hourglassOptions1.ViewType = Hourglass.ViewTypes.Day;
            this.hgScheduler.Options = hourglassOptions1;
            this.hgScheduler.Size = new System.Drawing.Size(916, 558);
            this.hgScheduler.TabIndex = 10;
            this.hgScheduler.Theme = resources.GetString("hgScheduler.Theme");
            this.hgScheduler.OnAferRender += new System.EventHandler(this.hgScheduler_OnAferRender);
            this.hgScheduler.OnEventClick += new Hourglass.HgScheduler.CalendarEventHandler(this.hgScheduler_OnEventClick);
            this.hgScheduler.OnEventRightClick += new Hourglass.HgScheduler.CalendarEventHandler(this.hgScheduler_OnEventRightClick);
            this.hgScheduler.OnEventEdit += new Hourglass.HgScheduler.EventCancelableEventHandler(this.hgScheduler_OnEventEdit);
            this.hgScheduler.OnEventMove += new Hourglass.HgScheduler.EventCancelableEventHandler(this.hgScheduler_OnEventEdit);
            this.hgScheduler.OnEventResize += new Hourglass.HgScheduler.EventCancelableEventHandler(this.hgScheduler_OnEventEdit);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(220)))), ((int)(((byte)(168)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(18, 18);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 38);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add Event";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 20;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.label5);
            this.bunifuPanel2.Controls.Add(this.label3);
            this.bunifuPanel2.Controls.Add(this.label2);
            this.bunifuPanel2.Controls.Add(this.label1);
            this.bunifuPanel2.Controls.Add(this.checkGoogle);
            this.bunifuPanel2.Controls.Add(this.checkUrgent);
            this.bunifuPanel2.Controls.Add(this.checkWork);
            this.bunifuPanel2.Controls.Add(this.checkPersonal);
            this.bunifuPanel2.Location = new System.Drawing.Point(15, 394);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(340, 319);
            this.bunifuPanel2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Google Calendar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Urgent Events";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Work Events";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personal Events";
            // 
            // checkGoogle
            // 
            this.checkGoogle.AllowBindingControlAnimation = true;
            this.checkGoogle.AllowBindingControlColorChanges = false;
            this.checkGoogle.AllowBindingControlLocation = true;
            this.checkGoogle.AllowCheckBoxAnimation = false;
            this.checkGoogle.AllowCheckmarkAnimation = true;
            this.checkGoogle.AllowOnHoverStates = true;
            this.checkGoogle.AutoCheck = true;
            this.checkGoogle.BackColor = System.Drawing.Color.Transparent;
            this.checkGoogle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkGoogle.BackgroundImage")));
            this.checkGoogle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkGoogle.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.checkGoogle.BorderRadius = 5;
            this.checkGoogle.Checked = false;
            this.checkGoogle.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.checkGoogle.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkGoogle.CustomCheckmarkImage = null;
            this.checkGoogle.Location = new System.Drawing.Point(72, 244);
            this.checkGoogle.MinimumSize = new System.Drawing.Size(25, 25);
            this.checkGoogle.Name = "checkGoogle";
            this.checkGoogle.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkGoogle.OnCheck.BorderRadius = 5;
            this.checkGoogle.OnCheck.BorderThickness = 2;
            this.checkGoogle.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkGoogle.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.checkGoogle.OnCheck.CheckmarkThickness = 2;
            this.checkGoogle.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.checkGoogle.OnDisable.BorderRadius = 5;
            this.checkGoogle.OnDisable.BorderThickness = 2;
            this.checkGoogle.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkGoogle.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.checkGoogle.OnDisable.CheckmarkThickness = 2;
            this.checkGoogle.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkGoogle.OnHoverChecked.BorderRadius = 5;
            this.checkGoogle.OnHoverChecked.BorderThickness = 2;
            this.checkGoogle.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkGoogle.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.checkGoogle.OnHoverChecked.CheckmarkThickness = 2;
            this.checkGoogle.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.checkGoogle.OnHoverUnchecked.BorderRadius = 5;
            this.checkGoogle.OnHoverUnchecked.BorderThickness = 1;
            this.checkGoogle.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkGoogle.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.checkGoogle.OnUncheck.BorderRadius = 5;
            this.checkGoogle.OnUncheck.BorderThickness = 1;
            this.checkGoogle.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkGoogle.Size = new System.Drawing.Size(25, 25);
            this.checkGoogle.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.checkGoogle.TabIndex = 0;
            this.checkGoogle.ThreeState = false;
            this.checkGoogle.ToolTipText = null;
            this.checkGoogle.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.checkGoogle_CheckedChanged);
            // 
            // checkUrgent
            // 
            this.checkUrgent.AllowBindingControlAnimation = true;
            this.checkUrgent.AllowBindingControlColorChanges = false;
            this.checkUrgent.AllowBindingControlLocation = true;
            this.checkUrgent.AllowCheckBoxAnimation = false;
            this.checkUrgent.AllowCheckmarkAnimation = true;
            this.checkUrgent.AllowOnHoverStates = true;
            this.checkUrgent.AutoCheck = true;
            this.checkUrgent.BackColor = System.Drawing.Color.Transparent;
            this.checkUrgent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkUrgent.BackgroundImage")));
            this.checkUrgent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkUrgent.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.checkUrgent.BorderRadius = 5;
            this.checkUrgent.Checked = true;
            this.checkUrgent.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.checkUrgent.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkUrgent.CustomCheckmarkImage = null;
            this.checkUrgent.Location = new System.Drawing.Point(72, 179);
            this.checkUrgent.MinimumSize = new System.Drawing.Size(25, 25);
            this.checkUrgent.Name = "checkUrgent";
            this.checkUrgent.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(147)))));
            this.checkUrgent.OnCheck.BorderRadius = 5;
            this.checkUrgent.OnCheck.BorderThickness = 2;
            this.checkUrgent.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(147)))));
            this.checkUrgent.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.checkUrgent.OnCheck.CheckmarkThickness = 2;
            this.checkUrgent.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.checkUrgent.OnDisable.BorderRadius = 5;
            this.checkUrgent.OnDisable.BorderThickness = 2;
            this.checkUrgent.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkUrgent.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.checkUrgent.OnDisable.CheckmarkThickness = 2;
            this.checkUrgent.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(147)))));
            this.checkUrgent.OnHoverChecked.BorderRadius = 5;
            this.checkUrgent.OnHoverChecked.BorderThickness = 2;
            this.checkUrgent.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(147)))));
            this.checkUrgent.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.checkUrgent.OnHoverChecked.CheckmarkThickness = 2;
            this.checkUrgent.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.checkUrgent.OnHoverUnchecked.BorderRadius = 5;
            this.checkUrgent.OnHoverUnchecked.BorderThickness = 1;
            this.checkUrgent.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkUrgent.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.checkUrgent.OnUncheck.BorderRadius = 5;
            this.checkUrgent.OnUncheck.BorderThickness = 1;
            this.checkUrgent.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkUrgent.Size = new System.Drawing.Size(25, 25);
            this.checkUrgent.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.checkUrgent.TabIndex = 0;
            this.checkUrgent.ThreeState = false;
            this.checkUrgent.ToolTipText = null;
            this.checkUrgent.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.checkUrgent_CheckedChanged);
            // 
            // checkWork
            // 
            this.checkWork.AllowBindingControlAnimation = true;
            this.checkWork.AllowBindingControlColorChanges = false;
            this.checkWork.AllowBindingControlLocation = true;
            this.checkWork.AllowCheckBoxAnimation = false;
            this.checkWork.AllowCheckmarkAnimation = true;
            this.checkWork.AllowOnHoverStates = true;
            this.checkWork.AutoCheck = true;
            this.checkWork.BackColor = System.Drawing.Color.Transparent;
            this.checkWork.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkWork.BackgroundImage")));
            this.checkWork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkWork.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.checkWork.BorderRadius = 5;
            this.checkWork.Checked = true;
            this.checkWork.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.checkWork.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkWork.CustomCheckmarkImage = null;
            this.checkWork.Location = new System.Drawing.Point(72, 118);
            this.checkWork.MinimumSize = new System.Drawing.Size(25, 25);
            this.checkWork.Name = "checkWork";
            this.checkWork.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.checkWork.OnCheck.BorderRadius = 5;
            this.checkWork.OnCheck.BorderThickness = 2;
            this.checkWork.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.checkWork.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.checkWork.OnCheck.CheckmarkThickness = 2;
            this.checkWork.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.checkWork.OnDisable.BorderRadius = 5;
            this.checkWork.OnDisable.BorderThickness = 2;
            this.checkWork.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkWork.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.checkWork.OnDisable.CheckmarkThickness = 2;
            this.checkWork.OnHoverChecked.BorderColor = System.Drawing.Color.DodgerBlue;
            this.checkWork.OnHoverChecked.BorderRadius = 5;
            this.checkWork.OnHoverChecked.BorderThickness = 2;
            this.checkWork.OnHoverChecked.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.checkWork.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.checkWork.OnHoverChecked.CheckmarkThickness = 2;
            this.checkWork.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.checkWork.OnHoverUnchecked.BorderRadius = 5;
            this.checkWork.OnHoverUnchecked.BorderThickness = 1;
            this.checkWork.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkWork.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.checkWork.OnUncheck.BorderRadius = 5;
            this.checkWork.OnUncheck.BorderThickness = 1;
            this.checkWork.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkWork.Size = new System.Drawing.Size(25, 25);
            this.checkWork.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.checkWork.TabIndex = 0;
            this.checkWork.ThreeState = false;
            this.checkWork.ToolTipText = null;
            this.checkWork.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.checkWork_CheckedChanged);
            // 
            // checkPersonal
            // 
            this.checkPersonal.AllowBindingControlAnimation = true;
            this.checkPersonal.AllowBindingControlColorChanges = false;
            this.checkPersonal.AllowBindingControlLocation = true;
            this.checkPersonal.AllowCheckBoxAnimation = false;
            this.checkPersonal.AllowCheckmarkAnimation = true;
            this.checkPersonal.AllowOnHoverStates = true;
            this.checkPersonal.AutoCheck = true;
            this.checkPersonal.BackColor = System.Drawing.Color.Transparent;
            this.checkPersonal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkPersonal.BackgroundImage")));
            this.checkPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkPersonal.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.checkPersonal.BorderRadius = 5;
            this.checkPersonal.Checked = true;
            this.checkPersonal.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.checkPersonal.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkPersonal.CustomCheckmarkImage = null;
            this.checkPersonal.Location = new System.Drawing.Point(72, 54);
            this.checkPersonal.MinimumSize = new System.Drawing.Size(25, 25);
            this.checkPersonal.Name = "checkPersonal";
            this.checkPersonal.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(220)))), ((int)(((byte)(168)))));
            this.checkPersonal.OnCheck.BorderRadius = 5;
            this.checkPersonal.OnCheck.BorderThickness = 2;
            this.checkPersonal.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(220)))), ((int)(((byte)(168)))));
            this.checkPersonal.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.checkPersonal.OnCheck.CheckmarkThickness = 2;
            this.checkPersonal.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.checkPersonal.OnDisable.BorderRadius = 5;
            this.checkPersonal.OnDisable.BorderThickness = 2;
            this.checkPersonal.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkPersonal.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.checkPersonal.OnDisable.CheckmarkThickness = 2;
            this.checkPersonal.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(220)))), ((int)(((byte)(168)))));
            this.checkPersonal.OnHoverChecked.BorderRadius = 5;
            this.checkPersonal.OnHoverChecked.BorderThickness = 2;
            this.checkPersonal.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(220)))), ((int)(((byte)(168)))));
            this.checkPersonal.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.checkPersonal.OnHoverChecked.CheckmarkThickness = 2;
            this.checkPersonal.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.checkPersonal.OnHoverUnchecked.BorderRadius = 5;
            this.checkPersonal.OnHoverUnchecked.BorderThickness = 1;
            this.checkPersonal.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkPersonal.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.checkPersonal.OnUncheck.BorderRadius = 5;
            this.checkPersonal.OnUncheck.BorderThickness = 1;
            this.checkPersonal.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkPersonal.Size = new System.Drawing.Size(25, 25);
            this.checkPersonal.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.checkPersonal.TabIndex = 0;
            this.checkPersonal.ThreeState = false;
            this.checkPersonal.ToolTipText = null;
            this.checkPersonal.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.checkPersonal_CheckedChanged);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 20;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.calendarControl1);
            this.bunifuPanel1.Location = new System.Drawing.Point(15, 75);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(340, 305);
            this.bunifuPanel1.TabIndex = 8;
            // 
            // calendarControl1
            // 
            this.calendarControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.calendarControl1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calendarControl1.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.ClassicNew;
            this.calendarControl1.DateTime = new System.DateTime(((long)(0)));
            this.calendarControl1.EditValue = new System.DateTime(((long)(0)));
            this.calendarControl1.Location = new System.Drawing.Point(15, 23);
            this.calendarControl1.Name = "calendarControl1";
            this.calendarControl1.ShowFooter = false;
            this.calendarControl1.ShowTodayButton = false;
            this.calendarControl1.Size = new System.Drawing.Size(273, 260);
            this.calendarControl1.TabIndex = 0;
            this.calendarControl1.DateTimeChanged += new System.EventHandler(this.calendarControl1_DateTimeChanged);
            this.calendarControl1.Click += new System.EventHandler(this.calendarControl1_Click);
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteEventToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(163, 28);
            // 
            // deleteEventToolStripMenuItem
            // 
            this.deleteEventToolStripMenuItem.Name = "deleteEventToolStripMenuItem";
            this.deleteEventToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.deleteEventToolStripMenuItem.Text = "Delete Event";
            this.deleteEventToolStripMenuItem.Click += new System.EventHandler(this.deleteEventToolStripMenuItem_Click);
            // 
            // Init
            // 
            this.Init.Interval = 500;
            this.Init.Tick += new System.EventHandler(this.Init_Tick);
            // 
            // Alert
            // 
            this.Alert.AllowDragging = false;
            this.Alert.AllowMultipleViews = true;
            this.Alert.ClickToClose = true;
            this.Alert.DoubleClickToClose = true;
            this.Alert.DurationAfterIdle = 3000;
            this.Alert.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Alert.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Alert.ErrorOptions.ActionBorderRadius = 1;
            this.Alert.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Alert.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Alert.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.Alert.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.Alert.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.Alert.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Alert.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.Alert.ErrorOptions.Icon = null;
            this.Alert.ErrorOptions.IconLeftMargin = 12;
            this.Alert.FadeCloseIcon = false;
            this.Alert.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.Alert.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Alert.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Alert.InformationOptions.ActionBorderRadius = 1;
            this.Alert.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Alert.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Alert.InformationOptions.BackColor = System.Drawing.Color.White;
            this.Alert.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.Alert.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.Alert.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Alert.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.Alert.InformationOptions.Icon = null;
            this.Alert.InformationOptions.IconLeftMargin = 12;
            this.Alert.Margin = 10;
            this.Alert.MaximumSize = new System.Drawing.Size(0, 0);
            this.Alert.MaximumViews = 7;
            this.Alert.MessageRightMargin = 15;
            this.Alert.MinimumSize = new System.Drawing.Size(0, 0);
            this.Alert.ShowBorders = false;
            this.Alert.ShowCloseIcon = false;
            this.Alert.ShowIcon = true;
            this.Alert.ShowShadows = true;
            this.Alert.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Alert.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Alert.SuccessOptions.ActionBorderRadius = 1;
            this.Alert.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Alert.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Alert.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.Alert.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.Alert.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.Alert.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Alert.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.Alert.SuccessOptions.Icon = null;
            this.Alert.SuccessOptions.IconLeftMargin = 12;
            this.Alert.ViewsMargin = 7;
            this.Alert.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Alert.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Alert.WarningOptions.ActionBorderRadius = 1;
            this.Alert.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Alert.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Alert.WarningOptions.BackColor = System.Drawing.Color.White;
            this.Alert.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.Alert.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.Alert.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Alert.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.Alert.WarningOptions.Icon = null;
            this.Alert.WarningOptions.IconLeftMargin = 12;
            this.Alert.ZoomCloseIcon = true;
            // 
            // titleBar
            // 
            this.titleBar.BackgroundColor = System.Drawing.Color.White;
            this.titleBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("titleBar.BackgroundImage")));
            this.titleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.titleBar.BorderColor = System.Drawing.Color.Transparent;
            this.titleBar.BorderRadius = 0;
            this.titleBar.BorderThickness = 1;
            this.titleBar.Controls.Add(this.btnGoogle);
            this.titleBar.Controls.Add(this.btnMinimize);
            this.titleBar.Controls.Add(this.btnNormal);
            this.titleBar.Controls.Add(this.btnMaximize);
            this.titleBar.Controls.Add(this.btnClose);
            this.titleBar.Controls.Add(this.pictureBox1);
            this.titleBar.Controls.Add(this.label4);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.ShowBorders = true;
            this.titleBar.Size = new System.Drawing.Size(1335, 60);
            this.titleBar.TabIndex = 7;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            // 
            // btnGoogle
            // 
            this.btnGoogle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGoogle.BackColor = System.Drawing.Color.Transparent;
            this.btnGoogle.FlatAppearance.BorderSize = 0;
            this.btnGoogle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoogle.Image = ((System.Drawing.Image)(resources.GetObject("btnGoogle.Image")));
            this.btnGoogle.Location = new System.Drawing.Point(1109, 4);
            this.btnGoogle.Name = "btnGoogle";
            this.btnGoogle.Size = new System.Drawing.Size(48, 48);
            this.btnGoogle.TabIndex = 13;
            this.btnGoogle.UseVisualStyleBackColor = false;
            this.btnGoogle.Click += new System.EventHandler(this.btnGoogle_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1161, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(48, 48);
            this.btnMinimize.TabIndex = 13;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNormal.BackColor = System.Drawing.Color.Transparent;
            this.btnNormal.FlatAppearance.BorderSize = 0;
            this.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormal.Image = ((System.Drawing.Image)(resources.GetObject("btnNormal.Image")));
            this.btnNormal.Location = new System.Drawing.Point(1219, 4);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(48, 48);
            this.btnNormal.TabIndex = 13;
            this.btnNormal.UseVisualStyleBackColor = false;
            this.btnNormal.Visible = false;
            this.btnNormal.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(1219, 4);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(48, 48);
            this.btnMaximize.TabIndex = 13;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1277, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 48);
            this.btnClose.TabIndex = 13;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(60, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Event Scheduler";
            this.label4.DoubleClick += new System.EventHandler(this.label4_DoubleClick);
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = false;
            this.bunifuFormDock1.AllowFormDropShadow = true;
            this.bunifuFormDock1.AllowFormResizing = true;
            this.bunifuFormDock1.AllowHidingBottomRegion = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
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
            // getEvent
            // 
            this.getEvent.Enabled = true;
            this.getEvent.Interval = 5000;
            this.getEvent.Tick += new System.EventHandler(this.getEvent_Tick);
            // 
            // notifyTimer
            // 
            this.notifyTimer.Enabled = true;
            this.notifyTimer.Interval = 500;
            this.notifyTimer.Tick += new System.EventHandler(this.notifyTimer_Tick);
            // 
            // notify
            // 
            this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
            this.notify.Text = "notifyIcon1";
            this.notify.Visible = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 726);
            this.Controls.Add(this.bunifuPanel3);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Scheduler";
            this.bunifuPanel3.ResumeLayout(false);
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private System.Windows.Forms.Button btnAdd;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuCheckBox checkUrgent;
        private Bunifu.UI.WinForms.BunifuCheckBox checkWork;
        private Bunifu.UI.WinForms.BunifuCheckBox checkPersonal;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private DevExpress.XtraEditors.Controls.CalendarControl calendarControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteEventToolStripMenuItem;
        private System.Windows.Forms.Timer Init;
        private Bunifu.UI.WinForms.BunifuSnackbar Alert;
        private Bunifu.UI.WinForms.BunifuPanel titleBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNormal;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private System.Windows.Forms.Button btnGoogle;
        private System.Windows.Forms.Label label5;
        private Bunifu.UI.WinForms.BunifuCheckBox checkGoogle;
        private System.Windows.Forms.Timer getEvent;
        private System.Windows.Forms.Timer notifyTimer;
        private System.Windows.Forms.NotifyIcon notify;
        private Hourglass.HgScheduler hgScheduler;
        private Kimtoo.ButtonGroup buttonViewType;
    }
}

