namespace Market.Forms
{
    partial class AllForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.usersListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sumBox = new System.Windows.Forms.NumericUpDown();
            this.bonusBox = new System.Windows.Forms.NumericUpDown();
            this.buyButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bonusesLabel = new System.Windows.Forms.Label();
            this.AllSpendLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TAbonusSumSpend = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.spendTAButton = new System.Windows.Forms.Button();
            this.f1FriendListComboBox = new System.Windows.Forms.ComboBox();
            this.friendSendButton = new System.Windows.Forms.Button();
            this.friendSendSumBox = new System.Windows.Forms.NumericUpDown();
            this.TABonusLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.friendSendCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.sumBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonusBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAbonusSumSpend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendSendSumBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AI";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(70, 37);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 1;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.phoneTextChanged);
            // 
            // usersListBox
            // 
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.Location = new System.Drawing.Point(32, 130);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.Size = new System.Drawing.Size(182, 95);
            this.usersListBox.TabIndex = 2;
            this.usersListBox.SelectedIndexChanged += new System.EventHandler(this.usersSelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(70, 70);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(10, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Сумма покупки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Оплата бонусами";
            // 
            // sumBox
            // 
            this.sumBox.Location = new System.Drawing.Point(232, 63);
            this.sumBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.sumBox.Name = "sumBox";
            this.sumBox.Size = new System.Drawing.Size(73, 20);
            this.sumBox.TabIndex = 8;
            this.sumBox.ValueChanged += new System.EventHandler(this.sumChanged);
            // 
            // bonusBox
            // 
            this.bonusBox.Location = new System.Drawing.Point(350, 63);
            this.bonusBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.bonusBox.Name = "bonusBox";
            this.bonusBox.Size = new System.Drawing.Size(73, 20);
            this.bonusBox.TabIndex = 9;
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(445, 60);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(75, 23);
            this.buyButton.TabIndex = 10;
            this.buyButton.Text = "Оплатить";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Бонусы";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Траты";
            // 
            // bonusesLabel
            // 
            this.bonusesLabel.AutoSize = true;
            this.bonusesLabel.Location = new System.Drawing.Point(229, 122);
            this.bonusesLabel.Name = "bonusesLabel";
            this.bonusesLabel.Size = new System.Drawing.Size(10, 13);
            this.bonusesLabel.TabIndex = 13;
            this.bonusesLabel.Text = "-";
            // 
            // AllSpendLabel
            // 
            this.AllSpendLabel.AutoSize = true;
            this.AllSpendLabel.Location = new System.Drawing.Point(236, 175);
            this.AllSpendLabel.Name = "AllSpendLabel";
            this.AllSpendLabel.Size = new System.Drawing.Size(10, 13);
            this.AllSpendLabel.TabIndex = 14;
            this.AllSpendLabel.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(347, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Счет ТА";
            // 
            // TAbonusSumSpend
            // 
            this.TAbonusSumSpend.Location = new System.Drawing.Point(460, 134);
            this.TAbonusSumSpend.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.TAbonusSumSpend.Name = "TAbonusSumSpend";
            this.TAbonusSumSpend.Size = new System.Drawing.Size(75, 20);
            this.TAbonusSumSpend.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(665, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Перевод другу";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(457, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Списать ТА";
            // 
            // spendTAButton
            // 
            this.spendTAButton.Location = new System.Drawing.Point(460, 175);
            this.spendTAButton.Name = "spendTAButton";
            this.spendTAButton.Size = new System.Drawing.Size(75, 23);
            this.spendTAButton.TabIndex = 19;
            this.spendTAButton.Text = "Списать";
            this.spendTAButton.UseVisualStyleBackColor = true;
            this.spendTAButton.Click += new System.EventHandler(this.spendTAButton_Click);
            // 
            // f1FriendListComboBox
            // 
            this.f1FriendListComboBox.FormattingEnabled = true;
            this.f1FriendListComboBox.Location = new System.Drawing.Point(645, 63);
            this.f1FriendListComboBox.Name = "f1FriendListComboBox";
            this.f1FriendListComboBox.Size = new System.Drawing.Size(173, 21);
            this.f1FriendListComboBox.TabIndex = 20;
            // 
            // friendSendButton
            // 
            this.friendSendButton.Location = new System.Drawing.Point(645, 130);
            this.friendSendButton.Name = "friendSendButton";
            this.friendSendButton.Size = new System.Drawing.Size(75, 23);
            this.friendSendButton.TabIndex = 21;
            this.friendSendButton.Text = "Перевести";
            this.friendSendButton.UseVisualStyleBackColor = true;
            this.friendSendButton.Click += new System.EventHandler(this.friendSendButton_Click);
            // 
            // friendSendSumBox
            // 
            this.friendSendSumBox.Location = new System.Drawing.Point(646, 101);
            this.friendSendSumBox.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.friendSendSumBox.Name = "friendSendSumBox";
            this.friendSendSumBox.Size = new System.Drawing.Size(74, 20);
            this.friendSendSumBox.TabIndex = 23;
            // 
            // TABonusLabel
            // 
            this.TABonusLabel.AutoSize = true;
            this.TABonusLabel.Location = new System.Drawing.Point(347, 134);
            this.TABonusLabel.Name = "TABonusLabel";
            this.TABonusLabel.Size = new System.Drawing.Size(10, 13);
            this.TABonusLabel.TabIndex = 24;
            this.TABonusLabel.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Статус";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(76, 103);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(10, 13);
            this.statusLabel.TabIndex = 27;
            this.statusLabel.Text = "-";
            // 
            // friendSendCheckBox
            // 
            this.friendSendCheckBox.AutoSize = true;
            this.friendSendCheckBox.Location = new System.Drawing.Point(738, 104);
            this.friendSendCheckBox.Name = "friendSendCheckBox";
            this.friendSendCheckBox.Size = new System.Drawing.Size(80, 17);
            this.friendSendCheckBox.TabIndex = 28;
            this.friendSendCheckBox.Text = "ТА бонусы";
            this.friendSendCheckBox.UseVisualStyleBackColor = true;
            // 
            // AllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 517);
            this.Controls.Add(this.friendSendCheckBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TABonusLabel);
            this.Controls.Add(this.friendSendSumBox);
            this.Controls.Add(this.friendSendButton);
            this.Controls.Add(this.f1FriendListComboBox);
            this.Controls.Add(this.spendTAButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TAbonusSumSpend);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AllSpendLabel);
            this.Controls.Add(this.bonusesLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.bonusBox);
            this.Controls.Add(this.sumBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usersListBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AllForm";
            this.Text = "AllForm";
            this.Load += new System.EventHandler(this.AllForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sumBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonusBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAbonusSumSpend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendSendSumBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.ListBox usersListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown sumBox;
        private System.Windows.Forms.NumericUpDown bonusBox;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label bonusesLabel;
        private System.Windows.Forms.Label AllSpendLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown TAbonusSumSpend;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button spendTAButton;
        private System.Windows.Forms.ComboBox f1FriendListComboBox;
        private System.Windows.Forms.Button friendSendButton;
        private System.Windows.Forms.NumericUpDown friendSendSumBox;
        private System.Windows.Forms.Label TABonusLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.CheckBox friendSendCheckBox;
    }
}