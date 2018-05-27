using System.Collections.Generic;

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
            this.nameLabel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sumBox = new System.Windows.Forms.NumericUpDown();
            this.bonusBox = new System.Windows.Forms.NumericUpDown();
            this.buyButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bonusesLabel = new System.Windows.Forms.TextBox();
            this.AllSpendLabel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TAbonusSumSpend = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.spendTAButton = new System.Windows.Forms.Button();
            this.f1FriendListComboBox = new System.Windows.Forms.ComboBox();
            this.friendSendButton = new System.Windows.Forms.Button();
            this.friendSendSumBox = new System.Windows.Forms.NumericUpDown();
            this.TABonusLabel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.friendSendCheckBox = new System.Windows.Forms.CheckBox();
            this.makeTAbutton = new System.Windows.Forms.Button();
            this.makeUserbutton = new System.Windows.Forms.Button();
            this.makeSTAbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.adminModeButton = new System.Windows.Forms.Button();
            this.userModeButton = new System.Windows.Forms.Button();
            this.newUserButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.MegaBonusLabel = new System.Windows.Forms.TextBox();
            this.label99 = new System.Windows.Forms.Label();
            this.SpendedMegaBonusLabel = new System.Windows.Forms.TextBox();
            this.spendMegaBonusSum = new System.Windows.Forms.NumericUpDown();
            this.spendMegaBonusButton = new System.Windows.Forms.Button();
            this.sentMegaSum = new System.Windows.Forms.NumericUpDown();
            this.sentMegaToUserButton = new System.Windows.Forms.Button();
            this.megaBonusTACheckBox = new System.Windows.Forms.CheckBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.HideButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.sentHistoryButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.AITextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sumBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonusBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAbonusSumSpend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendSendSumBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendMegaBonusSum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sentMegaSum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTextBox.Location = new System.Drawing.Point(65, 60);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(138, 21);
            this.phoneTextBox.TabIndex = 1;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.phoneTextChanged);
            // 
            // usersListBox
            // 
            this.usersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.ItemHeight = 15;
            this.usersListBox.Location = new System.Drawing.Point(22, 158);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.Size = new System.Drawing.Size(276, 229);
            this.usersListBox.TabIndex = 2;
            this.usersListBox.SelectedIndexChanged += new System.EventHandler(this.usersSelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя";
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(54, 121);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.ReadOnly = true;
            this.nameLabel.Size = new System.Drawing.Size(149, 21);
            this.nameLabel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(347, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Сумма";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(347, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Бон Оплата";
            // 
            // sumBox
            // 
            this.sumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumBox.Location = new System.Drawing.Point(350, 56);
            this.sumBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.sumBox.Name = "sumBox";
            this.sumBox.Size = new System.Drawing.Size(73, 21);
            this.sumBox.TabIndex = 8;
            this.sumBox.ValueChanged += new System.EventHandler(this.sumChanged);
            // 
            // bonusBox
            // 
            this.bonusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bonusBox.Location = new System.Drawing.Point(350, 117);
            this.bonusBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.bonusBox.Name = "bonusBox";
            this.bonusBox.Size = new System.Drawing.Size(73, 21);
            this.bonusBox.TabIndex = 9;
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(348, 156);
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
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(226, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Бонусы";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(226, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Траты";
            // 
            // bonusesLabel
            // 
            this.bonusesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bonusesLabel.Location = new System.Drawing.Point(229, 119);
            this.bonusesLabel.Name = "bonusesLabel";
            this.bonusesLabel.ReadOnly = true;
            this.bonusesLabel.Size = new System.Drawing.Size(69, 21);
            this.bonusesLabel.TabIndex = 13;
            this.bonusesLabel.Text = "0";
            // 
            // AllSpendLabel
            // 
            this.AllSpendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllSpendLabel.Location = new System.Drawing.Point(229, 58);
            this.AllSpendLabel.Name = "AllSpendLabel";
            this.AllSpendLabel.ReadOnly = true;
            this.AllSpendLabel.Size = new System.Drawing.Size(69, 21);
            this.AllSpendLabel.TabIndex = 14;
            this.AllSpendLabel.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(465, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Счет ТА";
            // 
            // TAbonusSumSpend
            // 
            this.TAbonusSumSpend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TAbonusSumSpend.Location = new System.Drawing.Point(468, 117);
            this.TAbonusSumSpend.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.TAbonusSumSpend.Name = "TAbonusSumSpend";
            this.TAbonusSumSpend.Size = new System.Drawing.Size(75, 21);
            this.TAbonusSumSpend.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(611, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Перевод другу";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(465, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "Списать ТА";
            // 
            // spendTAButton
            // 
            this.spendTAButton.Location = new System.Drawing.Point(468, 156);
            this.spendTAButton.Name = "spendTAButton";
            this.spendTAButton.Size = new System.Drawing.Size(75, 23);
            this.spendTAButton.TabIndex = 19;
            this.spendTAButton.Text = "Списать";
            this.spendTAButton.UseVisualStyleBackColor = true;
            this.spendTAButton.Click += new System.EventHandler(this.spendTAButton_Click);
            // 
            // f1FriendListComboBox
            // 
            this.f1FriendListComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f1FriendListComboBox.FormattingEnabled = true;
            this.f1FriendListComboBox.Location = new System.Drawing.Point(578, 54);
            this.f1FriendListComboBox.Name = "f1FriendListComboBox";
            this.f1FriendListComboBox.Size = new System.Drawing.Size(173, 23);
            this.f1FriendListComboBox.TabIndex = 20;
            // 
            // friendSendButton
            // 
            this.friendSendButton.Location = new System.Drawing.Point(671, 119);
            this.friendSendButton.Name = "friendSendButton";
            this.friendSendButton.Size = new System.Drawing.Size(80, 23);
            this.friendSendButton.TabIndex = 21;
            this.friendSendButton.Text = "Перевести";
            this.friendSendButton.UseVisualStyleBackColor = true;
            this.friendSendButton.Click += new System.EventHandler(this.friendSendButton_Click);
            // 
            // friendSendSumBox
            // 
            this.friendSendSumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.friendSendSumBox.Location = new System.Drawing.Point(578, 91);
            this.friendSendSumBox.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.friendSendSumBox.Name = "friendSendSumBox";
            this.friendSendSumBox.Size = new System.Drawing.Size(74, 21);
            this.friendSendSumBox.TabIndex = 23;
            // 
            // TABonusLabel
            // 
            this.TABonusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TABonusLabel.Location = new System.Drawing.Point(468, 56);
            this.TABonusLabel.Name = "TABonusLabel";
            this.TABonusLabel.ReadOnly = true;
            this.TABonusLabel.Size = new System.Drawing.Size(75, 21);
            this.TABonusLabel.TabIndex = 24;
            this.TABonusLabel.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(14, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Статус";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.Location = new System.Drawing.Point(79, 19);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(12, 16);
            this.statusLabel.TabIndex = 27;
            this.statusLabel.Text = "-";
            // 
            // friendSendCheckBox
            // 
            this.friendSendCheckBox.AutoSize = true;
            this.friendSendCheckBox.Location = new System.Drawing.Point(671, 94);
            this.friendSendCheckBox.Name = "friendSendCheckBox";
            this.friendSendCheckBox.Size = new System.Drawing.Size(80, 17);
            this.friendSendCheckBox.TabIndex = 28;
            this.friendSendCheckBox.Text = "ТА бонусы";
            this.friendSendCheckBox.UseVisualStyleBackColor = true;
            // 
            // makeTAbutton
            // 
            this.makeTAbutton.Location = new System.Drawing.Point(771, 357);
            this.makeTAbutton.Name = "makeTAbutton";
            this.makeTAbutton.Size = new System.Drawing.Size(91, 23);
            this.makeTAbutton.TabIndex = 29;
            this.makeTAbutton.Text = "ТА";
            this.makeTAbutton.UseVisualStyleBackColor = true;
            this.makeTAbutton.Click += new System.EventHandler(this.makeTAbutton_Click);
            // 
            // makeUserbutton
            // 
            this.makeUserbutton.Location = new System.Drawing.Point(771, 415);
            this.makeUserbutton.Name = "makeUserbutton";
            this.makeUserbutton.Size = new System.Drawing.Size(91, 23);
            this.makeUserbutton.TabIndex = 30;
            this.makeUserbutton.Text = "Пользователь";
            this.makeUserbutton.UseVisualStyleBackColor = true;
            this.makeUserbutton.Click += new System.EventHandler(this.makeUserbutton_Click);
            // 
            // makeSTAbutton
            // 
            this.makeSTAbutton.Location = new System.Drawing.Point(771, 386);
            this.makeSTAbutton.Name = "makeSTAbutton";
            this.makeSTAbutton.Size = new System.Drawing.Size(91, 23);
            this.makeSTAbutton.TabIndex = 31;
            this.makeSTAbutton.Text = "СТА";
            this.makeSTAbutton.UseVisualStyleBackColor = true;
            this.makeSTAbutton.Click += new System.EventHandler(this.makeSTAbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(757, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Изменить статус";
            // 
            // adminModeButton
            // 
            this.adminModeButton.Location = new System.Drawing.Point(921, 346);
            this.adminModeButton.Name = "adminModeButton";
            this.adminModeButton.Size = new System.Drawing.Size(101, 23);
            this.adminModeButton.TabIndex = 33;
            this.adminModeButton.Text = "Администратор";
            this.adminModeButton.UseVisualStyleBackColor = true;
            this.adminModeButton.Click += new System.EventHandler(this.adminModeButton_Click);
            // 
            // userModeButton
            // 
            this.userModeButton.Location = new System.Drawing.Point(921, 375);
            this.userModeButton.Name = "userModeButton";
            this.userModeButton.Size = new System.Drawing.Size(101, 23);
            this.userModeButton.TabIndex = 34;
            this.userModeButton.Text = "Пользователь";
            this.userModeButton.UseVisualStyleBackColor = true;
            this.userModeButton.Click += new System.EventHandler(this.userModeButton_Click);
            // 
            // newUserButton
            // 
            this.newUserButton.Location = new System.Drawing.Point(920, 441);
            this.newUserButton.Name = "newUserButton";
            this.newUserButton.Size = new System.Drawing.Size(101, 23);
            this.newUserButton.TabIndex = 35;
            this.newUserButton.Text = "Регистрация";
            this.newUserButton.UseVisualStyleBackColor = true;
            this.newUserButton.Click += new System.EventHandler(this.newUserButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(920, 470);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(101, 23);
            this.exitButton.TabIndex = 36;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(939, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 16);
            this.label9.TabIndex = 37;
            this.label9.Text = "Режим";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(777, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 16);
            this.label13.TabIndex = 38;
            this.label13.Text = "Счет ОК";
            // 
            // MegaBonusLabel
            // 
            this.MegaBonusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MegaBonusLabel.Location = new System.Drawing.Point(847, 27);
            this.MegaBonusLabel.Name = "MegaBonusLabel";
            this.MegaBonusLabel.ReadOnly = true;
            this.MegaBonusLabel.Size = new System.Drawing.Size(79, 21);
            this.MegaBonusLabel.TabIndex = 39;
            this.MegaBonusLabel.Text = "0";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label99.Location = new System.Drawing.Point(771, 63);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(70, 16);
            this.label99.TabIndex = 40;
            this.label99.Text = "Вычет ОК";
            // 
            // SpendedMegaBonusLabel
            // 
            this.SpendedMegaBonusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpendedMegaBonusLabel.Location = new System.Drawing.Point(847, 60);
            this.SpendedMegaBonusLabel.Name = "SpendedMegaBonusLabel";
            this.SpendedMegaBonusLabel.ReadOnly = true;
            this.SpendedMegaBonusLabel.Size = new System.Drawing.Size(79, 21);
            this.SpendedMegaBonusLabel.TabIndex = 41;
            this.SpendedMegaBonusLabel.Text = "0";
            // 
            // spendMegaBonusSum
            // 
            this.spendMegaBonusSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spendMegaBonusSum.Location = new System.Drawing.Point(942, 27);
            this.spendMegaBonusSum.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.spendMegaBonusSum.Name = "spendMegaBonusSum";
            this.spendMegaBonusSum.Size = new System.Drawing.Size(80, 21);
            this.spendMegaBonusSum.TabIndex = 42;
            // 
            // spendMegaBonusButton
            // 
            this.spendMegaBonusButton.Location = new System.Drawing.Point(941, 60);
            this.spendMegaBonusButton.Name = "spendMegaBonusButton";
            this.spendMegaBonusButton.Size = new System.Drawing.Size(80, 23);
            this.spendMegaBonusButton.TabIndex = 43;
            this.spendMegaBonusButton.Text = "Списать";
            this.spendMegaBonusButton.UseVisualStyleBackColor = true;
            this.spendMegaBonusButton.Click += new System.EventHandler(this.spendMegaBonusButton_Click);
            // 
            // sentMegaSum
            // 
            this.sentMegaSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sentMegaSum.Location = new System.Drawing.Point(847, 92);
            this.sentMegaSum.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.sentMegaSum.Name = "sentMegaSum";
            this.sentMegaSum.Size = new System.Drawing.Size(79, 21);
            this.sentMegaSum.TabIndex = 44;
            // 
            // sentMegaToUserButton
            // 
            this.sentMegaToUserButton.Location = new System.Drawing.Point(847, 119);
            this.sentMegaToUserButton.Name = "sentMegaToUserButton";
            this.sentMegaToUserButton.Size = new System.Drawing.Size(174, 23);
            this.sentMegaToUserButton.TabIndex = 45;
            this.sentMegaToUserButton.Text = "Перевести пользователю";
            this.sentMegaToUserButton.UseVisualStyleBackColor = true;
            this.sentMegaToUserButton.Click += new System.EventHandler(this.sentMegaToUserButton_Click);
            // 
            // megaBonusTACheckBox
            // 
            this.megaBonusTACheckBox.AutoSize = true;
            this.megaBonusTACheckBox.Location = new System.Drawing.Point(942, 96);
            this.megaBonusTACheckBox.Name = "megaBonusTACheckBox";
            this.megaBonusTACheckBox.Size = new System.Drawing.Size(80, 17);
            this.megaBonusTACheckBox.TabIndex = 46;
            this.megaBonusTACheckBox.Text = "ТА бонусы";
            this.megaBonusTACheckBox.UseVisualStyleBackColor = true;
            // 
            // treeView
            // 
            this.treeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView.Location = new System.Drawing.Point(348, 230);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(403, 263);
            this.treeView.TabIndex = 47;
            // 
            // HideButton
            // 
            this.HideButton.Location = new System.Drawing.Point(348, 201);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(75, 23);
            this.HideButton.TabIndex = 48;
            this.HideButton.Text = "Свернуть";
            this.HideButton.UseVisualStyleBackColor = true;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // historyButton
            // 
            this.historyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyButton.Location = new System.Drawing.Point(22, 440);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(101, 23);
            this.historyButton.TabIndex = 49;
            this.historyButton.Text = "История";
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // sentHistoryButton
            // 
            this.sentHistoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sentHistoryButton.Location = new System.Drawing.Point(22, 469);
            this.sentHistoryButton.Name = "sentHistoryButton";
            this.sentHistoryButton.Size = new System.Drawing.Size(101, 23);
            this.sentHistoryButton.TabIndex = 50;
            this.sentHistoryButton.Text = "Переводы";
            this.sentHistoryButton.UseVisualStyleBackColor = true;
            this.sentHistoryButton.Click += new System.EventHandler(this.sentHistoryButton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(28, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 16);
            this.label14.TabIndex = 51;
            this.label14.Text = "AI";
            // 
            // AITextBox
            // 
            this.AITextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AITextBox.Location = new System.Drawing.Point(54, 91);
            this.AITextBox.Name = "AITextBox";
            this.AITextBox.ReadOnly = true;
            this.AITextBox.Size = new System.Drawing.Size(149, 21);
            this.AITextBox.TabIndex = 52;
            // 
            // AllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(1046, 517);
            this.Controls.Add(this.AITextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.sentHistoryButton);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.HideButton);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.megaBonusTACheckBox);
            this.Controls.Add(this.sentMegaToUserButton);
            this.Controls.Add(this.sentMegaSum);
            this.Controls.Add(this.spendMegaBonusButton);
            this.Controls.Add(this.spendMegaBonusSum);
            this.Controls.Add(this.SpendedMegaBonusLabel);
            this.Controls.Add(this.label99);
            this.Controls.Add(this.MegaBonusLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.newUserButton);
            this.Controls.Add(this.userModeButton);
            this.Controls.Add(this.adminModeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.makeSTAbutton);
            this.Controls.Add(this.makeUserbutton);
            this.Controls.Add(this.makeTAbutton);
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
            ((System.ComponentModel.ISupportInitialize)(this.spendMegaBonusSum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sentMegaSum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.ListBox usersListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown sumBox;
        private System.Windows.Forms.NumericUpDown bonusBox;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox bonusesLabel;
        private System.Windows.Forms.TextBox AllSpendLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown TAbonusSumSpend;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button spendTAButton;
        private System.Windows.Forms.ComboBox f1FriendListComboBox;
        private System.Windows.Forms.Button friendSendButton;
        private System.Windows.Forms.NumericUpDown friendSendSumBox;
        private System.Windows.Forms.TextBox TABonusLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.CheckBox friendSendCheckBox;
        private System.Windows.Forms.Button makeTAbutton;
        private System.Windows.Forms.Button makeUserbutton;
        private System.Windows.Forms.Button makeSTAbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button adminModeButton;
        private System.Windows.Forms.Button userModeButton;
        private System.Windows.Forms.Button newUserButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox MegaBonusLabel;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.TextBox SpendedMegaBonusLabel;
        private System.Windows.Forms.NumericUpDown spendMegaBonusSum;
        private System.Windows.Forms.Button spendMegaBonusButton;
        private System.Windows.Forms.NumericUpDown sentMegaSum;
        private System.Windows.Forms.Button sentMegaToUserButton;
        private System.Windows.Forms.CheckBox megaBonusTACheckBox;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button HideButton;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button sentHistoryButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox AITextBox;
    }
}