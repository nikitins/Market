namespace Market
{
    partial class Main
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
            this.logoutButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.sale = new System.Windows.Forms.Button();
            this.registration = new System.Windows.Forms.Button();
            this.properties = new System.Windows.Forms.Button();
            this.addAgent = new System.Windows.Forms.Button();
            this.changePassword = new System.Windows.Forms.Button();
            this.common = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(120, 278);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(116, 23);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "Выход";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logout_Click);
            // 
            // historyButton
            // 
            this.historyButton.Location = new System.Drawing.Point(120, 220);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(116, 23);
            this.historyButton.TabIndex = 1;
            this.historyButton.Text = "История операций";
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.history_Click);
            // 
            // sale
            // 
            this.sale.Location = new System.Drawing.Point(120, 191);
            this.sale.Name = "sale";
            this.sale.Size = new System.Drawing.Size(116, 23);
            this.sale.TabIndex = 2;
            this.sale.Text = "Новая покупка";
            this.sale.UseVisualStyleBackColor = true;
            // 
            // registration
            // 
            this.registration.Location = new System.Drawing.Point(120, 162);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(116, 23);
            this.registration.TabIndex = 3;
            this.registration.Text = "Зарегистрировать";
            this.registration.UseVisualStyleBackColor = true;
            this.registration.Click += new System.EventHandler(this.registration_Click);
            // 
            // properties
            // 
            this.properties.Location = new System.Drawing.Point(120, 133);
            this.properties.Name = "properties";
            this.properties.Size = new System.Drawing.Size(116, 23);
            this.properties.TabIndex = 4;
            this.properties.Text = "Настройки";
            this.properties.UseVisualStyleBackColor = true;
            // 
            // addAgent
            // 
            this.addAgent.Location = new System.Drawing.Point(120, 104);
            this.addAgent.Name = "addAgent";
            this.addAgent.Size = new System.Drawing.Size(116, 23);
            this.addAgent.TabIndex = 5;
            this.addAgent.Text = "Добавить агента";
            this.addAgent.UseVisualStyleBackColor = true;
            // 
            // changePassword
            // 
            this.changePassword.Location = new System.Drawing.Point(120, 249);
            this.changePassword.Name = "changePassword";
            this.changePassword.Size = new System.Drawing.Size(116, 23);
            this.changePassword.TabIndex = 6;
            this.changePassword.Text = "Изменить пароль";
            this.changePassword.UseVisualStyleBackColor = true;
            // 
            // common
            // 
            this.common.Location = new System.Drawing.Point(120, 75);
            this.common.Name = "common";
            this.common.Size = new System.Drawing.Size(116, 23);
            this.common.TabIndex = 7;
            this.common.Text = "Общие накопления";
            this.common.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 385);
            this.Controls.Add(this.common);
            this.Controls.Add(this.changePassword);
            this.Controls.Add(this.addAgent);
            this.Controls.Add(this.properties);
            this.Controls.Add(this.registration);
            this.Controls.Add(this.sale);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.logoutButton);
            this.Name = "Main";
            this.Text = "Главное Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button sale;
        private System.Windows.Forms.Button registration;
        private System.Windows.Forms.Button properties;
        private System.Windows.Forms.Button addAgent;
        private System.Windows.Forms.Button changePassword;
        private System.Windows.Forms.Button common;
    }
}