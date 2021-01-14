
namespace QuizManagementSystem.Views
{
    partial class AdminDashboardView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPersonalInfo = new System.Windows.Forms.Button();
            this.buttonManagement = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonManagement, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonPersonalInfo, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 197);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonPersonalInfo
            // 
            this.buttonPersonalInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPersonalInfo.Location = new System.Drawing.Point(69, 18);
            this.buttonPersonalInfo.Name = "buttonPersonalInfo";
            this.buttonPersonalInfo.Size = new System.Drawing.Size(293, 62);
            this.buttonPersonalInfo.TabIndex = 1;
            this.buttonPersonalInfo.Text = "Personal Information";
            this.buttonPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // buttonManagement
            // 
            this.buttonManagement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManagement.Location = new System.Drawing.Point(69, 116);
            this.buttonManagement.Name = "buttonManagement";
            this.buttonManagement.Size = new System.Drawing.Size(293, 62);
            this.buttonManagement.TabIndex = 5;
            this.buttonManagement.Text = "Management";
            this.buttonManagement.UseVisualStyleBackColor = true;
            // 
            // AdminDashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 197);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AdminDashboardView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonPersonalInfo;
        private System.Windows.Forms.Button buttonManagement;
    }
}