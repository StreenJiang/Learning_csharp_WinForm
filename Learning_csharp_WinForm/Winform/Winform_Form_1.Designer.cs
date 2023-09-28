namespace Learning_csharp_WinForm {
    public partial class Winform_Form_1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Winform_Form_1));
            ProductManagement = new Winform.CustomControls.CustomButton();
            WorkPlace = new Winform.CustomControls.CustomButton();
            mainPanel = new FlowLayoutPanel();
            mainMenuPanel = new FlowLayoutPanel();
            DataQuery = new Winform.CustomControls.CustomButton();
            EventLog = new Winform.CustomControls.CustomButton();
            Configuration = new Winform.CustomControls.CustomButton();
            UserInfo = new Winform.CustomControls.CustomButton();
            Exit = new Winform.CustomControls.CustomButton();
            mainContentPanel = new FlowLayoutPanel();
            childMenuPanel = new FlowLayoutPanel();
            customButton1 = new Winform.CustomControls.CustomButton();
            customButton2 = new Winform.CustomControls.CustomButton();
            mainPanel.SuspendLayout();
            mainMenuPanel.SuspendLayout();
            mainContentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ProductManagement
            // 
            ProductManagement.BackColor = Color.FromArgb(  64,   64,   64);
            ProductManagement.BorderColor = Color.White;
            ProductManagement.BorderRadius = 0;
            ProductManagement.BorderSize = 0;
            ProductManagement.FlatStyle = FlatStyle.Flat;
            ProductManagement.Font = new Font("Microsoft YaHei", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            ProductManagement.ForeColor = Color.FromArgb(  255,   128,   0);
            ProductManagement.HoverForeColor = Color.Empty;
            ProductManagement.HoverImage = null;
            ProductManagement.Image = (Image) resources.GetObject("ProductManagement.Image");
            ProductManagement.Location = new Point(0, 0);
            ProductManagement.Margin = new Padding(0);
            ProductManagement.Name = "ProductManagement";
            ProductManagement.NormalImage = null;
            ProductManagement.OriginalImage = Properties.Resources.分类;
            ProductManagement.Size = new Size(60, 60);
            ProductManagement.TabIndex = 0;
            ProductManagement.Text = "产品管理";
            ProductManagement.TextAlign = ContentAlignment.BottomCenter;
            ProductManagement.TextImageRelation = TextImageRelation.ImageAboveText;
            ProductManagement.UseVisualStyleBackColor = false;
            // 
            // WorkPlace
            // 
            WorkPlace.BackColor = Color.FromArgb(  64,   64,   64);
            WorkPlace.BorderColor = Color.PaleVioletRed;
            WorkPlace.BorderRadius = 0;
            WorkPlace.BorderSize = 0;
            WorkPlace.FlatStyle = FlatStyle.Flat;
            WorkPlace.Font = new Font("Microsoft YaHei", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            WorkPlace.ForeColor = Color.FromArgb(  255,   128,   0);
            WorkPlace.HoverForeColor = Color.Empty;
            WorkPlace.HoverImage = null;
            WorkPlace.Location = new Point(60, 0);
            WorkPlace.Margin = new Padding(0);
            WorkPlace.Name = "WorkPlace";
            WorkPlace.NormalImage = null;
            WorkPlace.OriginalImage = null;
            WorkPlace.Size = new Size(60, 60);
            WorkPlace.TabIndex = 0;
            WorkPlace.Text = "工作台";
            WorkPlace.TextAlign = ContentAlignment.BottomCenter;
            WorkPlace.TextImageRelation = TextImageRelation.ImageAboveText;
            WorkPlace.UseVisualStyleBackColor = false;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(mainMenuPanel);
            mainPanel.Controls.Add(mainContentPanel);
            mainPanel.Location = new Point(0, 0);
            mainPanel.Margin = new Padding(0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(785, 562);
            mainPanel.TabIndex = 1;
            mainPanel.Resize += mainPanel_Resize;
            // 
            // mainMenuPanel
            // 
            mainMenuPanel.BackColor = Color.FromArgb(  63,   63,   63);
            mainMenuPanel.Controls.Add(ProductManagement);
            mainMenuPanel.Controls.Add(WorkPlace);
            mainMenuPanel.Controls.Add(DataQuery);
            mainMenuPanel.Controls.Add(EventLog);
            mainMenuPanel.Controls.Add(Configuration);
            mainMenuPanel.Controls.Add(UserInfo);
            mainMenuPanel.Controls.Add(Exit);
            mainMenuPanel.Controls.Add(customButton2);
            mainMenuPanel.ForeColor = Color.FromArgb(  232,   108,   16);
            mainMenuPanel.Location = new Point(0, 0);
            mainMenuPanel.Margin = new Padding(0);
            mainMenuPanel.Name = "mainMenuPanel";
            mainMenuPanel.Size = new Size(782, 60);
            mainMenuPanel.TabIndex = 1;
            mainMenuPanel.Resize += mainMenuPanel_Resize;
            // 
            // DataQuery
            // 
            DataQuery.BackColor = Color.FromArgb(  64,   64,   64);
            DataQuery.BorderColor = Color.PaleVioletRed;
            DataQuery.BorderRadius = 0;
            DataQuery.BorderSize = 0;
            DataQuery.FlatStyle = FlatStyle.Flat;
            DataQuery.Font = new Font("Microsoft YaHei", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            DataQuery.ForeColor = Color.FromArgb(  255,   128,   0);
            DataQuery.HoverForeColor = Color.Empty;
            DataQuery.HoverImage = null;
            DataQuery.Location = new Point(120, 0);
            DataQuery.Margin = new Padding(0);
            DataQuery.Name = "DataQuery";
            DataQuery.NormalImage = null;
            DataQuery.OriginalImage = null;
            DataQuery.Size = new Size(60, 60);
            DataQuery.TabIndex = 0;
            DataQuery.Text = "数据查询";
            DataQuery.TextAlign = ContentAlignment.BottomCenter;
            DataQuery.TextImageRelation = TextImageRelation.ImageAboveText;
            DataQuery.UseVisualStyleBackColor = false;
            // 
            // EventLog
            // 
            EventLog.BackColor = Color.FromArgb(  64,   64,   64);
            EventLog.BorderColor = Color.PaleVioletRed;
            EventLog.BorderRadius = 0;
            EventLog.BorderSize = 0;
            EventLog.FlatStyle = FlatStyle.Flat;
            EventLog.Font = new Font("Microsoft YaHei", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            EventLog.ForeColor = Color.FromArgb(  255,   128,   0);
            EventLog.HoverForeColor = Color.Empty;
            EventLog.HoverImage = null;
            EventLog.Location = new Point(180, 0);
            EventLog.Margin = new Padding(0);
            EventLog.Name = "EventLog";
            EventLog.NormalImage = null;
            EventLog.OriginalImage = null;
            EventLog.Size = new Size(60, 60);
            EventLog.TabIndex = 0;
            EventLog.Text = "事件日志";
            EventLog.TextAlign = ContentAlignment.BottomCenter;
            EventLog.TextImageRelation = TextImageRelation.ImageAboveText;
            EventLog.UseVisualStyleBackColor = false;
            // 
            // Configuration
            // 
            Configuration.BackColor = Color.FromArgb(  64,   64,   64);
            Configuration.BorderColor = Color.PaleVioletRed;
            Configuration.BorderRadius = 0;
            Configuration.BorderSize = 0;
            Configuration.FlatStyle = FlatStyle.Flat;
            Configuration.Font = new Font("Microsoft YaHei", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            Configuration.ForeColor = Color.FromArgb(  255,   128,   0);
            Configuration.HoverForeColor = Color.Empty;
            Configuration.HoverImage = null;
            Configuration.Location = new Point(240, 0);
            Configuration.Margin = new Padding(0);
            Configuration.Name = "Configuration";
            Configuration.NormalImage = null;
            Configuration.OriginalImage = null;
            Configuration.Size = new Size(60, 60);
            Configuration.TabIndex = 0;
            Configuration.Text = "参数配置";
            Configuration.TextAlign = ContentAlignment.BottomCenter;
            Configuration.TextImageRelation = TextImageRelation.ImageAboveText;
            Configuration.UseVisualStyleBackColor = false;
            // 
            // UserInfo
            // 
            UserInfo.BackColor = Color.FromArgb(  64,   64,   64);
            UserInfo.BorderColor = Color.PaleVioletRed;
            UserInfo.BorderRadius = 0;
            UserInfo.BorderSize = 0;
            UserInfo.FlatStyle = FlatStyle.Flat;
            UserInfo.Font = new Font("Microsoft YaHei", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            UserInfo.ForeColor = Color.FromArgb(  255,   128,   0);
            UserInfo.HoverForeColor = Color.Empty;
            UserInfo.HoverImage = null;
            UserInfo.Location = new Point(300, 0);
            UserInfo.Margin = new Padding(0);
            UserInfo.Name = "UserInfo";
            UserInfo.NormalImage = null;
            UserInfo.OriginalImage = null;
            UserInfo.Size = new Size(60, 60);
            UserInfo.TabIndex = 0;
            UserInfo.Text = "用户信息";
            UserInfo.TextAlign = ContentAlignment.BottomCenter;
            UserInfo.TextImageRelation = TextImageRelation.ImageAboveText;
            UserInfo.UseVisualStyleBackColor = false;
            // 
            // Exit
            // 
            Exit.BackColor = Color.FromArgb(  64,   64,   64);
            Exit.BorderColor = Color.White;
            Exit.BorderRadius = 0;
            Exit.BorderSize = 0;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Microsoft YaHei", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            Exit.ForeColor = Color.FromArgb(  255,   128,   0);
            Exit.HoverForeColor = Color.Empty;
            Exit.HoverImage = null;
            Exit.Location = new Point(360, 0);
            Exit.Margin = new Padding(0);
            Exit.Name = "Exit";
            Exit.NormalImage = null;
            Exit.OriginalImage = null;
            Exit.Size = new Size(60, 60);
            Exit.TabIndex = 0;
            Exit.Text = "退出";
            Exit.TextAlign = ContentAlignment.BottomCenter;
            Exit.TextImageRelation = TextImageRelation.ImageAboveText;
            Exit.UseVisualStyleBackColor = false;
            // 
            // mainContentPanel
            // 
            mainContentPanel.Controls.Add(childMenuPanel);
            mainContentPanel.Controls.Add(customButton1);
            mainContentPanel.Location = new Point(0, 60);
            mainContentPanel.Margin = new Padding(0);
            mainContentPanel.Name = "mainContentPanel";
            mainContentPanel.Size = new Size(782, 502);
            mainContentPanel.TabIndex = 2;
            mainContentPanel.Paint += mainContentPanel_Paint;
            // 
            // childMenuPanel
            // 
            childMenuPanel.Location = new Point(0, 0);
            childMenuPanel.Margin = new Padding(0);
            childMenuPanel.Name = "childMenuPanel";
            childMenuPanel.Size = new Size(104, 502);
            childMenuPanel.TabIndex = 1;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.DimGray;
            customButton1.BorderColor = Color.PapayaWhip;
            customButton1.BorderRadius = 0;
            customButton1.BorderSize = 0;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Microsoft YaHei", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            customButton1.ForeColor = Color.FromArgb(  255,   128,   0);
            customButton1.HoverForeColor = Color.Empty;
            customButton1.HoverImage = null;
            customButton1.Image = (Image) resources.GetObject("customButton1.Image");
            customButton1.Location = new Point(104, 0);
            customButton1.Margin = new Padding(0);
            customButton1.Name = "customButton1";
            customButton1.NormalImage = Properties.Resources.分类;
            customButton1.OriginalImage = Properties.Resources.分类;
            customButton1.Size = new Size(275, 275);
            customButton1.TabIndex = 2;
            customButton1.Text = "任务管理";
            customButton1.TextAlign = ContentAlignment.BottomCenter;
            customButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            customButton1.UseVisualStyleBackColor = false;
            // 
            // customButton2
            // 
            customButton2.BackColor = Color.FromArgb(  64,   64,   64);
            customButton2.BorderColor = Color.PaleVioletRed;
            customButton2.BorderRadius = 0;
            customButton2.BorderSize = 0;
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.Font = new Font("Microsoft YaHei", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            customButton2.ForeColor = Color.FromArgb(  255,   128,   0);
            customButton2.HoverForeColor = Color.Empty;
            customButton2.HoverImage = null;
            customButton2.Image = (Image) resources.GetObject("customButton2.Image");
            customButton2.Location = new Point(420, 0);
            customButton2.Margin = new Padding(0);
            customButton2.Name = "customButton2";
            customButton2.NormalImage = null;
            customButton2.OriginalImage = Properties.Resources.分类;
            customButton2.Size = new Size(60, 60);
            customButton2.TabIndex = 0;
            customButton2.Text = "custom";
            customButton2.TextAlign = ContentAlignment.BottomCenter;
            customButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            customButton2.UseVisualStyleBackColor = false;
            // 
            // Winform_Form_1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(784, 561);
            Controls.Add(mainPanel);
            Name = "Winform_Form_1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Winform_Form_1";
            Resize += Winform_Form_1_Resize;
            mainPanel.ResumeLayout(false);
            mainMenuPanel.ResumeLayout(false);
            mainContentPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel mainPanel;
        private FlowLayoutPanel mainMenuPanel;
        private FlowLayoutPanel mainContentPanel;
        private FlowLayoutPanel childMenuPanel;
        private Winform.CustomControls.CustomButton customButton1;
        private Winform.CustomControls.CustomButton ProductManagement;
        private Winform.CustomControls.CustomButton WorkPlace;
        private Winform.CustomControls.CustomButton DataQuery;
        private Winform.CustomControls.CustomButton EventLog;
        private Winform.CustomControls.CustomButton Configuration;
        private Winform.CustomControls.CustomButton UserInfo;
        private Winform.CustomControls.CustomButton Exit;
        private Winform.CustomControls.CustomButton customButton2;
    }
}