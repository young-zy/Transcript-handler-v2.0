namespace XOD Subtitle Group Transcript Handler V2.0
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mlbTrans = new MaterialSkin.Controls.MaterialLabel();
            this.mdTextTrans = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mdlbTimeline = new MaterialSkin.Controls.MaterialLabel();
            this.mdTextTimeline = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mdRBttSlec = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mdlbPath = new MaterialSkin.Controls.MaterialLabel();
            this.mdtextPath = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mdRbttImp = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chinese = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.English = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrbCnup = new MaterialSkin.Controls.MaterialRadioButton();
            this.mrbEnup = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbResolution = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.mdTextChecker = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mlbTrans
            // 
            this.mlbTrans.AutoSize = true;
            this.mlbTrans.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mlbTrans.Depth = 0;
            this.mlbTrans.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.mlbTrans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlbTrans.Location = new System.Drawing.Point(13, 76);
            this.mlbTrans.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlbTrans.Name = "mlbTrans";
            this.mlbTrans.Size = new System.Drawing.Size(87, 25);
            this.mlbTrans.TabIndex = 1;
            this.mlbTrans.Text = "翻   译：";
            this.mlbTrans.Click += new System.EventHandler(this.mlbTrans_Click);
            // 
            // mdTextTrans
            // 
            this.mdTextTrans.Depth = 0;
            this.mdTextTrans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mdTextTrans.Hint = "";
            this.mdTextTrans.Location = new System.Drawing.Point(106, 76);
            this.mdTextTrans.MaxLength = 32767;
            this.mdTextTrans.MouseState = MaterialSkin.MouseState.HOVER;
            this.mdTextTrans.Name = "mdTextTrans";
            this.mdTextTrans.PasswordChar = '\0';
            this.mdTextTrans.SelectedText = "";
            this.mdTextTrans.SelectionLength = 0;
            this.mdTextTrans.SelectionStart = 0;
            this.mdTextTrans.Size = new System.Drawing.Size(592, 30);
            this.mdTextTrans.TabIndex = 2;
            this.mdTextTrans.TabStop = false;
            this.mdTextTrans.Text = "请输入翻译昵称，多个用分号隔开";
            this.mdTextTrans.UseSystemPasswordChar = false;
            this.mdTextTrans.Click += new System.EventHandler(this.mdTextTrans_Click);
            this.mdTextTrans.Leave += new System.EventHandler(this.mdTextTrans_Leave);
            // 
            // mdlbTimeline
            // 
            this.mdlbTimeline.AutoSize = true;
            this.mdlbTimeline.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mdlbTimeline.Depth = 0;
            this.mdlbTimeline.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.mdlbTimeline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mdlbTimeline.Location = new System.Drawing.Point(13, 148);
            this.mdlbTimeline.MouseState = MaterialSkin.MouseState.HOVER;
            this.mdlbTimeline.Name = "mdlbTimeline";
            this.mdlbTimeline.Size = new System.Drawing.Size(88, 25);
            this.mdlbTimeline.TabIndex = 3;
            this.mdlbTimeline.Text = "时间轴：";
            // 
            // mdTextTimeline
            // 
            this.mdTextTimeline.Depth = 0;
            this.mdTextTimeline.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mdTextTimeline.Hint = "";
            this.mdTextTimeline.Location = new System.Drawing.Point(106, 148);
            this.mdTextTimeline.MaxLength = 32767;
            this.mdTextTimeline.MouseState = MaterialSkin.MouseState.HOVER;
            this.mdTextTimeline.Name = "mdTextTimeline";
            this.mdTextTimeline.PasswordChar = '\0';
            this.mdTextTimeline.SelectedText = "";
            this.mdTextTimeline.SelectionLength = 0;
            this.mdTextTimeline.SelectionStart = 0;
            this.mdTextTimeline.Size = new System.Drawing.Size(592, 30);
            this.mdTextTimeline.TabIndex = 4;
            this.mdTextTimeline.TabStop = false;
            this.mdTextTimeline.Text = "请输入时间轴昵称，多个用分号隔开";
            this.mdTextTimeline.UseSystemPasswordChar = false;
            this.mdTextTimeline.Click += new System.EventHandler(this.mdTextTimeline_Click);
            this.mdTextTimeline.Leave += new System.EventHandler(this.mdTextTimeline_Leave_1);
            // 
            // mdRBttSlec
            // 
            this.mdRBttSlec.AutoSize = true;
            this.mdRBttSlec.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mdRBttSlec.Depth = 0;
            this.mdRBttSlec.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mdRBttSlec.Icon = null;
            this.mdRBttSlec.Location = new System.Drawing.Point(622, 178);
            this.mdRBttSlec.MouseState = MaterialSkin.MouseState.HOVER;
            this.mdRBttSlec.Name = "mdRBttSlec";
            this.mdRBttSlec.Primary = true;
            this.mdRBttSlec.Size = new System.Drawing.Size(76, 36);
            this.mdRBttSlec.TabIndex = 5;
            this.mdRBttSlec.Text = "选择";
            this.mdRBttSlec.UseVisualStyleBackColor = true;
            this.mdRBttSlec.Click += new System.EventHandler(this.mdRaiseBttImp_Click);
            // 
            // mdlbPath
            // 
            this.mdlbPath.AutoSize = true;
            this.mdlbPath.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mdlbPath.Depth = 0;
            this.mdlbPath.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.mdlbPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mdlbPath.Location = new System.Drawing.Point(13, 184);
            this.mdlbPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.mdlbPath.Name = "mdlbPath";
            this.mdlbPath.Size = new System.Drawing.Size(87, 25);
            this.mdlbPath.TabIndex = 8;
            this.mdlbPath.Text = "地   址：";
            // 
            // mdtextPath
            // 
            this.mdtextPath.Depth = 0;
            this.mdtextPath.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mdtextPath.Hint = "";
            this.mdtextPath.Location = new System.Drawing.Point(106, 184);
            this.mdtextPath.MaxLength = 32767;
            this.mdtextPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.mdtextPath.Name = "mdtextPath";
            this.mdtextPath.PasswordChar = '\0';
            this.mdtextPath.SelectedText = "";
            this.mdtextPath.SelectionLength = 0;
            this.mdtextPath.SelectionStart = 0;
            this.mdtextPath.Size = new System.Drawing.Size(511, 30);
            this.mdtextPath.TabIndex = 9;
            this.mdtextPath.TabStop = false;
            this.mdtextPath.UseSystemPasswordChar = false;
            // 
            // mdRbttImp
            // 
            this.mdRbttImp.AutoSize = true;
            this.mdRbttImp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mdRbttImp.Depth = 0;
            this.mdRbttImp.Icon = null;
            this.mdRbttImp.Location = new System.Drawing.Point(487, 233);
            this.mdRbttImp.MouseState = MaterialSkin.MouseState.HOVER;
            this.mdRbttImp.Name = "mdRbttImp";
            this.mdRbttImp.Primary = true;
            this.mdRbttImp.Size = new System.Drawing.Size(99, 36);
            this.mdRbttImp.TabIndex = 10;
            this.mdRbttImp.Text = "导   入";
            this.mdRbttImp.UseVisualStyleBackColor = true;
            this.mdRbttImp.Click += new System.EventHandler(this.mdRbttImp_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNum,
            this.Chinese,
            this.English});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(21, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(680, 350);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // cNum
            // 
            this.cNum.DataPropertyName = "id";
            this.cNum.HeaderText = "#";
            this.cNum.Name = "cNum";
            this.cNum.ReadOnly = true;
            // 
            // Chinese
            // 
            this.Chinese.DataPropertyName = "Cn";
            this.Chinese.HeaderText = "中文";
            this.Chinese.Name = "Chinese";
            // 
            // English
            // 
            this.English.DataPropertyName = "En";
            this.English.HeaderText = "英文";
            this.English.Name = "English";
            // 
            // mrbCnup
            // 
            this.mrbCnup.AutoSize = true;
            this.mrbCnup.Depth = 0;
            this.mrbCnup.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.mrbCnup.Location = new System.Drawing.Point(596, 223);
            this.mrbCnup.Margin = new System.Windows.Forms.Padding(0);
            this.mrbCnup.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbCnup.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbCnup.Name = "mrbCnup";
            this.mrbCnup.Ripple = true;
            this.mrbCnup.Size = new System.Drawing.Size(114, 30);
            this.mrbCnup.TabIndex = 13;
            this.mrbCnup.TabStop = true;
            this.mrbCnup.Text = "中文在上";
            this.mrbCnup.UseVisualStyleBackColor = true;
            // 
            // mrbEnup
            // 
            this.mrbEnup.AutoSize = true;
            this.mrbEnup.Depth = 0;
            this.mrbEnup.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.mrbEnup.Location = new System.Drawing.Point(596, 248);
            this.mrbEnup.Margin = new System.Windows.Forms.Padding(0);
            this.mrbEnup.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbEnup.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbEnup.Name = "mrbEnup";
            this.mrbEnup.Ripple = true;
            this.mrbEnup.Size = new System.Drawing.Size(114, 30);
            this.mrbEnup.TabIndex = 14;
            this.mrbEnup.TabStop = true;
            this.mrbEnup.Text = "英文在上";
            this.mrbEnup.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(603, 637);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(107, 36);
            this.materialRaisedButton1.TabIndex = 15;
            this.materialRaisedButton1.Text = "导    出";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // cbResolution
            // 
            this.cbResolution.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbResolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbResolution.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbResolution.FormattingEnabled = true;
            this.cbResolution.Items.AddRange(new object[] {
            "480p",
            "720p",
            "1080p"});
            this.cbResolution.Location = new System.Drawing.Point(476, 637);
            this.cbResolution.Name = "cbResolution";
            this.cbResolution.Size = new System.Drawing.Size(121, 36);
            this.cbResolution.TabIndex = 16;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(13, 112);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(87, 25);
            this.materialLabel1.TabIndex = 17;
            this.materialLabel1.Text = "校   对：";
            // 
            // mdTextChecker
            // 
            this.mdTextChecker.Depth = 0;
            this.mdTextChecker.Hint = "";
            this.mdTextChecker.Location = new System.Drawing.Point(106, 112);
            this.mdTextChecker.MaxLength = 32767;
            this.mdTextChecker.MouseState = MaterialSkin.MouseState.HOVER;
            this.mdTextChecker.Name = "mdTextChecker";
            this.mdTextChecker.PasswordChar = '\0';
            this.mdTextChecker.SelectedText = "";
            this.mdTextChecker.SelectionLength = 0;
            this.mdTextChecker.SelectionStart = 0;
            this.mdTextChecker.Size = new System.Drawing.Size(593, 30);
            this.mdTextChecker.TabIndex = 18;
            this.mdTextChecker.TabStop = false;
            this.mdTextChecker.Text = "请输入校对昵称，多个用分号隔开";
            this.mdTextChecker.UseSystemPasswordChar = false;
            this.mdTextChecker.Click += new System.EventHandler(this.mdTextChecker_Click);
            this.mdTextChecker.Leave += new System.EventHandler(this.mdTextChecker_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(722, 686);
            this.Controls.Add(this.mdTextChecker);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cbResolution);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.mrbEnup);
            this.Controls.Add(this.mrbCnup);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mdRbttImp);
            this.Controls.Add(this.mdtextPath);
            this.Controls.Add(this.mdlbPath);
            this.Controls.Add(this.mdRBttSlec);
            this.Controls.Add(this.mdTextTimeline);
            this.Controls.Add(this.mdlbTimeline);
            this.Controls.Add(this.mdTextTrans);
            this.Controls.Add(this.mlbTrans);
            this.Name = "Form1";
            this.Text = "时间轴转换脚本";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel mlbTrans;
        private MaterialSkin.Controls.MaterialSingleLineTextField mdTextTrans;
        private MaterialSkin.Controls.MaterialLabel mdlbTimeline;
        private MaterialSkin.Controls.MaterialSingleLineTextField mdTextTimeline;
        private MaterialSkin.Controls.MaterialRaisedButton mdRBttSlec;
        private MaterialSkin.Controls.MaterialLabel mdlbPath;
        private MaterialSkin.Controls.MaterialSingleLineTextField mdtextPath;
        private MaterialSkin.Controls.MaterialRaisedButton mdRbttImp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chinese;
        private System.Windows.Forms.DataGridViewTextBoxColumn English;
        private MaterialSkin.Controls.MaterialRadioButton mrbCnup;
        private MaterialSkin.Controls.MaterialRadioButton mrbEnup;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        public System.Windows.Forms.ComboBox cbResolution;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField mdTextChecker;
    }
}

