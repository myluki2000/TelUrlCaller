namespace TelUrlCaller
{
    partial class SettingsForm
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
            label1 = new Label();
            tbActionUri = new TextBox();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cbAskBeforeDial = new CheckBox();
            btnSave = new Button();
            btnCancel = new Button();
            cbAlwaysOnTop = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Action URI:";
            // 
            // tbActionUri
            // 
            tbActionUri.Location = new Point(84, 12);
            tbActionUri.Name = "tbActionUri";
            tbActionUri.Size = new Size(247, 23);
            tbActionUri.TabIndex = 1;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(84, 41);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(247, 23);
            tbUsername.TabIndex = 2;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(84, 70);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(247, 23);
            tbPassword.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 44);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 4;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 73);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // cbAskBeforeDial
            // 
            cbAskBeforeDial.AutoSize = true;
            cbAskBeforeDial.Location = new Point(12, 99);
            cbAskBeforeDial.Name = "cbAskBeforeDial";
            cbAskBeforeDial.Size = new Size(211, 19);
            cbAskBeforeDial.TabIndex = 6;
            cbAskBeforeDial.Text = "Ask for confirmation before dialing";
            cbAskBeforeDial.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(175, 149);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(256, 149);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cbAlwaysOnTop
            // 
            cbAlwaysOnTop.AutoSize = true;
            cbAlwaysOnTop.Location = new Point(12, 124);
            cbAlwaysOnTop.Name = "cbAlwaysOnTop";
            cbAlwaysOnTop.Size = new Size(132, 19);
            cbAlwaysOnTop.TabIndex = 9;
            cbAlwaysOnTop.Text = "Dialer always on top";
            cbAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 180);
            Controls.Add(cbAlwaysOnTop);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cbAskBeforeDial);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(tbActionUri);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SettingsForm";
            Text = "TelUrlCaller Settings";
            Load += SettingsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbActionUri;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Label label2;
        private Label label3;
        private CheckBox cbAskBeforeDial;
        private Button btnSave;
        private Button btnCancel;
        private CheckBox cbAlwaysOnTop;
    }
}