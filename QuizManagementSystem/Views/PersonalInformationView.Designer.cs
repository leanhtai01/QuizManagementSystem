
namespace QuizManagementSystem.Views
{
    partial class PersonalInformationView
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxRole = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonEditName = new System.Windows.Forms.Button();
            this.buttonEditDateOfBirth = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.labelClass = new System.Windows.Forms.Label();
            this.textBoxClass = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.labelUsername, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelRole, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelID, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelName, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxUsername, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxRole, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxID, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonEditName, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonSave, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.buttonChangePassword, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.buttonCancel, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelDateOfBirth, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerDateOfBirth, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonEditDateOfBirth, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelClass, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxClass, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(401, 350);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(39, 18);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(58, 13);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username:";
            // 
            // labelRole
            // 
            this.labelRole.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(65, 67);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(32, 13);
            this.labelRole.TabIndex = 1;
            this.labelRole.Text = "Role:";
            // 
            // labelID
            // 
            this.labelID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(76, 116);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 13);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "ID:";
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(59, 165);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name:";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(29, 263);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(68, 13);
            this.labelDateOfBirth.TabIndex = 4;
            this.labelDateOfBirth.Text = "Date of birth:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxUsername.Location = new System.Drawing.Point(103, 14);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(194, 20);
            this.textBoxUsername.TabIndex = 5;
            // 
            // textBoxRole
            // 
            this.textBoxRole.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxRole.Location = new System.Drawing.Point(103, 63);
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.Size = new System.Drawing.Size(194, 20);
            this.textBoxRole.TabIndex = 6;
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxID.Location = new System.Drawing.Point(103, 112);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(194, 20);
            this.textBoxID.TabIndex = 7;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxName.Location = new System.Drawing.Point(103, 161);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(194, 20);
            this.textBoxName.TabIndex = 8;
            // 
            // buttonEditName
            // 
            this.buttonEditName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonEditName.Location = new System.Drawing.Point(303, 158);
            this.buttonEditName.Name = "buttonEditName";
            this.buttonEditName.Size = new System.Drawing.Size(48, 27);
            this.buttonEditName.TabIndex = 10;
            this.buttonEditName.Text = "Edit";
            this.buttonEditName.UseVisualStyleBackColor = true;
            // 
            // buttonEditDateOfBirth
            // 
            this.buttonEditDateOfBirth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonEditDateOfBirth.Location = new System.Drawing.Point(303, 256);
            this.buttonEditDateOfBirth.Name = "buttonEditDateOfBirth";
            this.buttonEditDateOfBirth.Size = new System.Drawing.Size(48, 27);
            this.buttonEditDateOfBirth.TabIndex = 11;
            this.buttonEditDateOfBirth.Text = "Edit";
            this.buttonEditDateOfBirth.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSave.Location = new System.Drawing.Point(7, 303);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(85, 38);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancel.Location = new System.Drawing.Point(308, 303);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(85, 38);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonChangePassword.Location = new System.Drawing.Point(112, 303);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(176, 38);
            this.buttonChangePassword.TabIndex = 14;
            this.buttonChangePassword.Text = "Change Password";
            this.buttonChangePassword.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(103, 259);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(194, 20);
            this.dateTimePickerDateOfBirth.TabIndex = 15;
            // 
            // labelClass
            // 
            this.labelClass.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(62, 214);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(35, 13);
            this.labelClass.TabIndex = 16;
            this.labelClass.Text = "Class:";
            // 
            // textBoxClass
            // 
            this.textBoxClass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxClass.Location = new System.Drawing.Point(103, 210);
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.Size = new System.Drawing.Size(194, 20);
            this.textBoxClass.TabIndex = 17;
            // 
            // PersonalInformationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 350);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PersonalInformationView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Information";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxRole;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonEditName;
        private System.Windows.Forms.Button buttonEditDateOfBirth;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.TextBox textBoxClass;
    }
}