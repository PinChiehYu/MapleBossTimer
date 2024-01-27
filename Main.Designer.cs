namespace MapleBossTimer
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCreateBossConfig = new System.Windows.Forms.Button();
            this.txtboxBossName = new System.Windows.Forms.TextBox();
            this.txtboxBossRespawnMinutes = new System.Windows.Forms.TextBox();
            this.btnRemoveBossConfig = new System.Windows.Forms.Button();
            this.labelBossName = new System.Windows.Forms.Label();
            this.labelRespawnMinutes = new System.Windows.Forms.Label();
            this.richTextBoxIntro = new System.Windows.Forms.RichTextBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(5, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(530, 282);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBoxIntro);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(522, 256);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Intro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCreateBossConfig
            // 
            this.btnCreateBossConfig.Location = new System.Drawing.Point(541, 232);
            this.btnCreateBossConfig.Name = "btnCreateBossConfig";
            this.btnCreateBossConfig.Size = new System.Drawing.Size(100, 23);
            this.btnCreateBossConfig.TabIndex = 3;
            this.btnCreateBossConfig.Text = "Add New Tab";
            this.btnCreateBossConfig.UseVisualStyleBackColor = true;
            this.btnCreateBossConfig.Click += new System.EventHandler(this.btnCreateBossConfig_Click);
            // 
            // txtboxBossName
            // 
            this.txtboxBossName.Location = new System.Drawing.Point(541, 163);
            this.txtboxBossName.MaxLength = 10;
            this.txtboxBossName.Name = "txtboxBossName";
            this.txtboxBossName.Size = new System.Drawing.Size(100, 22);
            this.txtboxBossName.TabIndex = 4;
            // 
            // txtboxBossRespawnMinutes
            // 
            this.txtboxBossRespawnMinutes.Location = new System.Drawing.Point(541, 205);
            this.txtboxBossRespawnMinutes.MaxLength = 4;
            this.txtboxBossRespawnMinutes.Name = "txtboxBossRespawnMinutes";
            this.txtboxBossRespawnMinutes.Size = new System.Drawing.Size(100, 22);
            this.txtboxBossRespawnMinutes.TabIndex = 5;
            // 
            // btnRemoveBossConfig
            // 
            this.btnRemoveBossConfig.Location = new System.Drawing.Point(541, 261);
            this.btnRemoveBossConfig.Name = "btnRemoveBossConfig";
            this.btnRemoveBossConfig.Size = new System.Drawing.Size(100, 23);
            this.btnRemoveBossConfig.TabIndex = 6;
            this.btnRemoveBossConfig.Text = "Remove Boss Tab";
            this.btnRemoveBossConfig.UseVisualStyleBackColor = true;
            // 
            // labelBossName
            // 
            this.labelBossName.AutoSize = true;
            this.labelBossName.Location = new System.Drawing.Point(539, 148);
            this.labelBossName.Name = "labelBossName";
            this.labelBossName.Size = new System.Drawing.Size(57, 12);
            this.labelBossName.TabIndex = 7;
            this.labelBossName.Text = "Boss Name";
            // 
            // labelRespawnMinutes
            // 
            this.labelRespawnMinutes.AutoSize = true;
            this.labelRespawnMinutes.Location = new System.Drawing.Point(539, 190);
            this.labelRespawnMinutes.Name = "labelRespawnMinutes";
            this.labelRespawnMinutes.Size = new System.Drawing.Size(87, 12);
            this.labelRespawnMinutes.TabIndex = 8;
            this.labelRespawnMinutes.Text = "Respawn Minutes";
            // 
            // richTextBoxIntro
            // 
            this.richTextBoxIntro.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBoxIntro.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxIntro.Name = "richTextBoxIntro";
            this.richTextBoxIntro.ReadOnly = true;
            this.richTextBoxIntro.Size = new System.Drawing.Size(522, 256);
            this.richTextBoxIntro.TabIndex = 0;
            this.richTextBoxIntro.Text = "After creating a new tab, each channel will have a button. Pressing the correspon" +
    "ding button will start the countdown, and pressing it again will reset the timer" +
    ".";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 290);
            this.Controls.Add(this.labelRespawnMinutes);
            this.Controls.Add(this.labelBossName);
            this.Controls.Add(this.btnRemoveBossConfig);
            this.Controls.Add(this.txtboxBossRespawnMinutes);
            this.Controls.Add(this.txtboxBossName);
            this.Controls.Add(this.btnCreateBossConfig);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Maple Boss Timer";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button btnCreateBossConfig;
        private System.Windows.Forms.TextBox txtboxBossName;
        private System.Windows.Forms.TextBox txtboxBossRespawnMinutes;
        private System.Windows.Forms.Button btnRemoveBossConfig;
        private System.Windows.Forms.Label labelBossName;
        private System.Windows.Forms.Label labelRespawnMinutes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBoxIntro;
    }
}

