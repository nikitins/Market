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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bonusesLabel = new System.Windows.Forms.Label();
            this.AllSpendLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.f1FriendListComboBox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
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
            this.usersListBox.Location = new System.Drawing.Point(32, 109);
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(645, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(232, 63);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(73, 20);
            this.numericUpDown1.TabIndex = 8;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(350, 63);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(73, 20);
            this.numericUpDown2.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(445, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.label10.Location = new System.Drawing.Point(350, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Счет ТА";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(460, 134);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown3.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(642, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "label11";
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(460, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // f1FriendListComboBox
            // 
            this.f1FriendListComboBox.FormattingEnabled = true;
            this.f1FriendListComboBox.Location = new System.Drawing.Point(645, 63);
            this.f1FriendListComboBox.Name = "f1FriendListComboBox";
            this.f1FriendListComboBox.Size = new System.Drawing.Size(121, 21);
            this.f1FriendListComboBox.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(645, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // AllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 517);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.f1FriendListComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AllSpendLabel);
            this.Controls.Add(this.bonusesLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox2);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(Login.appClose);

            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label bonusesLabel;
        private System.Windows.Forms.Label AllSpendLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox f1FriendListComboBox;
        private System.Windows.Forms.Button button3;
    }
}