using System;
using System.Windows.Forms;

namespace Market.Forms
{
    partial class History
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
          //  this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonusType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.name,
            this.type,
            this.sum,
            this.bonus,
            this.bonusType});
            this.dataGridView.Location = new System.Drawing.Point(22, 30);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(753, 324);
            this.dataGridView.TabIndex = 0;
         //   this.dataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellContentClick);
       //     this.dataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellContentClick);
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Имя";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // type
            // 
            this.type.HeaderText = "Тип";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // sum
            // 
            this.sum.HeaderText = "Сумма";
            this.sum.Name = "sum";
            this.sum.ReadOnly = true;
            // 
            // bonus
            // 
            this.bonus.HeaderText = "Оплачено бонусами";
            this.bonus.Name = "bonus";
            this.bonus.ReadOnly = true;     
            // 
            // bonusType
            // 
            this.bonusType.HeaderText = "Тип бонусов";
            this.bonusType.Name = "bonusType";
            this.bonusType.ReadOnly = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(375, 395);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Назад";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancel_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 475);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.dataGridView);
            this.Name = "History";
            this.Text = "History";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(Login.appClose);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonus;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonusType;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
      //  private DataGridViewTextBoxColumn Id;
    }
}