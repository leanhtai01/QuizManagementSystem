
namespace QuizManagementSystem.Views
{
    partial class NonAdminDashboardView
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
            this.buttonContributeQuestion = new System.Windows.Forms.Button();
            this.buttonPractice = new System.Windows.Forms.Button();
            this.buttonTakeQuiz = new System.Windows.Forms.Button();
            this.buttonPersonalInfo = new System.Windows.Forms.Button();
            this.buttonManagement = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.buttonManagement, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonContributeQuestion, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonPractice, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonTakeQuiz, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonPersonalInfo, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 434);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonContributeQuestion
            // 
            this.buttonContributeQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonContributeQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContributeQuestion.Location = new System.Drawing.Point(69, 270);
            this.buttonContributeQuestion.Name = "buttonContributeQuestion";
            this.buttonContributeQuestion.Size = new System.Drawing.Size(293, 62);
            this.buttonContributeQuestion.TabIndex = 3;
            this.buttonContributeQuestion.Text = "Contribute Question";
            this.buttonContributeQuestion.UseVisualStyleBackColor = true;
            // 
            // buttonPractice
            // 
            this.buttonPractice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPractice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPractice.Location = new System.Drawing.Point(69, 184);
            this.buttonPractice.Name = "buttonPractice";
            this.buttonPractice.Size = new System.Drawing.Size(293, 62);
            this.buttonPractice.TabIndex = 2;
            this.buttonPractice.Text = "Practice";
            this.buttonPractice.UseVisualStyleBackColor = true;
            // 
            // buttonTakeQuiz
            // 
            this.buttonTakeQuiz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTakeQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTakeQuiz.Location = new System.Drawing.Point(69, 98);
            this.buttonTakeQuiz.Name = "buttonTakeQuiz";
            this.buttonTakeQuiz.Size = new System.Drawing.Size(293, 62);
            this.buttonTakeQuiz.TabIndex = 1;
            this.buttonTakeQuiz.Text = "Take Quiz";
            this.buttonTakeQuiz.UseVisualStyleBackColor = true;
            // 
            // buttonPersonalInfo
            // 
            this.buttonPersonalInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPersonalInfo.Location = new System.Drawing.Point(69, 12);
            this.buttonPersonalInfo.Name = "buttonPersonalInfo";
            this.buttonPersonalInfo.Size = new System.Drawing.Size(293, 62);
            this.buttonPersonalInfo.TabIndex = 0;
            this.buttonPersonalInfo.Text = "Personal Information";
            this.buttonPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // buttonManagement
            // 
            this.buttonManagement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManagement.Location = new System.Drawing.Point(69, 358);
            this.buttonManagement.Name = "buttonManagement";
            this.buttonManagement.Size = new System.Drawing.Size(293, 62);
            this.buttonManagement.TabIndex = 4;
            this.buttonManagement.Text = "Management";
            this.buttonManagement.UseVisualStyleBackColor = true;
            // 
            // NonAdminDashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 434);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NonAdminDashboardView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonContributeQuestion;
        private System.Windows.Forms.Button buttonPractice;
        private System.Windows.Forms.Button buttonTakeQuiz;
        private System.Windows.Forms.Button buttonPersonalInfo;
        private System.Windows.Forms.Button buttonManagement;
    }
}