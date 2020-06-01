namespace loginsystem
{
    partial class AddUserForm
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
            this.AddPasswordText = new System.Windows.Forms.Label();
            this.AddPasswordBox = new System.Windows.Forms.TextBox();
            this.AddUsernameBox = new System.Windows.Forms.TextBox();
            this.AddUsernameText = new System.Windows.Forms.Label();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddPasswordText
            // 
            this.AddPasswordText.AutoSize = true;
            this.AddPasswordText.Location = new System.Drawing.Point(21, 71);
            this.AddPasswordText.Name = "AddPasswordText";
            this.AddPasswordText.Size = new System.Drawing.Size(53, 13);
            this.AddPasswordText.TabIndex = 9;
            this.AddPasswordText.Text = "Password";
            // 
            // AddPasswordBox
            // 
            this.AddPasswordBox.Location = new System.Drawing.Point(82, 68);
            this.AddPasswordBox.MaxLength = 15;
            this.AddPasswordBox.Name = "AddPasswordBox";
            this.AddPasswordBox.Size = new System.Drawing.Size(194, 20);
            this.AddPasswordBox.TabIndex = 8;
            this.AddPasswordBox.UseSystemPasswordChar = true;
            this.AddPasswordBox.TextChanged += new System.EventHandler(this.AddUsernameBox_TextChanged);
            // 
            // AddUsernameBox
            // 
            this.AddUsernameBox.Location = new System.Drawing.Point(82, 26);
            this.AddUsernameBox.MaxLength = 15;
            this.AddUsernameBox.Name = "AddUsernameBox";
            this.AddUsernameBox.Size = new System.Drawing.Size(194, 20);
            this.AddUsernameBox.TabIndex = 7;
            this.AddUsernameBox.TextChanged += new System.EventHandler(this.AddUsernameBox_TextChanged);
            // 
            // AddUsernameText
            // 
            this.AddUsernameText.AutoSize = true;
            this.AddUsernameText.Location = new System.Drawing.Point(21, 29);
            this.AddUsernameText.Name = "AddUsernameText";
            this.AddUsernameText.Size = new System.Drawing.Size(55, 13);
            this.AddUsernameText.TabIndex = 6;
            this.AddUsernameText.Text = "Username";
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(121, 107);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(75, 23);
            this.AddUserButton.TabIndex = 10;
            this.AddUserButton.Text = "Add User";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // AddUserForm
            // 
            this.AcceptButton = this.AddUserButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 142);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.AddPasswordText);
            this.Controls.Add(this.AddPasswordBox);
            this.Controls.Add(this.AddUsernameBox);
            this.Controls.Add(this.AddUsernameText);
            this.Name = "AddUserForm";
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddPasswordText;
        private System.Windows.Forms.TextBox AddPasswordBox;
        private System.Windows.Forms.TextBox AddUsernameBox;
        private System.Windows.Forms.Label AddUsernameText;
        private System.Windows.Forms.Button AddUserButton;
    }
}