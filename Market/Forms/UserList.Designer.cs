using Market.Models;
using System.Windows.Forms;

namespace Market.Forms
{
    partial class UserList
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.treeView = new System.Windows.Forms.TreeView();
            this.makeAgentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(282, 423);
            this.cancelButton.Name = "button1";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Назад";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancel_Click);
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(35, 31);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(465, 370);
            this.treeView.TabIndex = 1;
            // 
            // makeAgentButton
            // 
            this.makeAgentButton.Location = new System.Drawing.Point(164, 423);
            this.makeAgentButton.Name = "button2";
            this.makeAgentButton.Size = new System.Drawing.Size(75, 23);
            this.makeAgentButton.TabIndex = 2;
            this.makeAgentButton.Text = "Сделать агентом";
            this.makeAgentButton.UseVisualStyleBackColor = true;
            this.makeAgentButton.Click += new System.EventHandler(this.makeAgent_Click);
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 504);
            this.Controls.Add(this.makeAgentButton);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.cancelButton);
            this.Name = "UserList";
            this.Text = "UserList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TreeView treeView;
        private Button makeAgentButton;
    }
}