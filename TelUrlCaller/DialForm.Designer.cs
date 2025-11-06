namespace TelUrlCaller
{
    partial class DialForm
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
            tbPhoneNumber = new TextBox();
            label1 = new Label();
            btnCall = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbPhoneNumber.Font = new Font("Segoe UI", 13F);
            tbPhoneNumber.Location = new Point(12, 37);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(408, 31);
            tbPhoneNumber.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(183, 25);
            label1.TabIndex = 1;
            label1.Text = "Dial a phone number:";
            // 
            // btnCall
            // 
            btnCall.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCall.Font = new Font("Segoe UI", 12F);
            btnCall.Image = Properties.Resources.call_24dp_48752C_FILL0_wght400_GRAD0_opsz24;
            btnCall.ImageAlign = ContentAlignment.MiddleRight;
            btnCall.Location = new Point(222, 74);
            btnCall.Name = "btnCall";
            btnCall.Size = new Size(96, 35);
            btnCall.TabIndex = 2;
            btnCall.Text = "Call";
            btnCall.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCall.UseVisualStyleBackColor = true;
            btnCall.Click += btnCall_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.Font = new Font("Segoe UI", 12F);
            btnCancel.Image = Properties.Resources.cancel_24dp_8B1A10_FILL0_wght400_GRAD0_opsz24;
            btnCancel.ImageAlign = ContentAlignment.MiddleRight;
            btnCancel.Location = new Point(324, 74);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(96, 35);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // DialForm
            // 
            AcceptButton = btnCall;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 117);
            Controls.Add(btnCancel);
            Controls.Add(btnCall);
            Controls.Add(label1);
            Controls.Add(tbPhoneNumber);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "DialForm";
            Text = "Dialer";
            Load += DialForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbPhoneNumber;
        private Label label1;
        private Button btnCall;
        private Button btnCancel;
    }
}