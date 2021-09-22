
namespace Ef433_test.Forms
{
    partial class AddUser
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
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(12, 19);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(219, 20);
            this.tbLogin.TabIndex = 0;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(12, 46);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(219, 20);
            this.tbPass.TabIndex = 1;
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(12, 72);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(219, 20);
            this.tbFullName.TabIndex = 2;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(12, 98);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(219, 23);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 138);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbFullName);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbLogin);
            this.Name = "AddUser";
            this.Text = "Adduser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Button btAdd;
    }
}