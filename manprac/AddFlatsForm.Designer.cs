﻿namespace manprac
{
    partial class AddFlatsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFlatsForm));
            this.addRecordButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.contractTextBox = new System.Windows.Forms.TextBox();
            this.rentersComboBox = new System.Windows.Forms.ComboBox();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.amountRentTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.vatTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.areaTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.amountPaymentTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addRecordButton
            // 
            this.addRecordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addRecordButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addRecordButton.Location = new System.Drawing.Point(144, 348);
            this.addRecordButton.Name = "addRecordButton";
            this.addRecordButton.Size = new System.Drawing.Size(182, 32);
            this.addRecordButton.TabIndex = 3;
            this.addRecordButton.Text = "Добавить запись";
            this.addRecordButton.UseVisualStyleBackColor = true;
            this.addRecordButton.Click += new System.EventHandler(this.addFlatsButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(71, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Договор:";
            // 
            // contractTextBox
            // 
            this.contractTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractTextBox.Location = new System.Drawing.Point(157, 120);
            this.contractTextBox.Name = "contractTextBox";
            this.contractTextBox.Size = new System.Drawing.Size(309, 29);
            this.contractTextBox.TabIndex = 8;
            this.contractTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.contractTextBox_KeyDown);
            // 
            // rentersComboBox
            // 
            this.rentersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rentersComboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rentersComboBox.FormattingEnabled = true;
            this.rentersComboBox.Location = new System.Drawing.Point(157, 46);
            this.rentersComboBox.Name = "rentersComboBox";
            this.rentersComboBox.Size = new System.Drawing.Size(309, 29);
            this.rentersComboBox.TabIndex = 6;
            this.rentersComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rentersComboBox_KeyDown);
            // 
            // monthComboBox
            // 
            this.monthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthComboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Location = new System.Drawing.Point(157, 83);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(309, 29);
            this.monthComboBox.TabIndex = 7;
            this.monthComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.monthComboBox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(88, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Месяц:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(54, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Арендатор:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(22, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Сумма аренды:";
            // 
            // amountRentTextBox
            // 
            this.amountRentTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountRentTextBox.Location = new System.Drawing.Point(157, 157);
            this.amountRentTextBox.Name = "amountRentTextBox";
            this.amountRentTextBox.Size = new System.Drawing.Size(309, 29);
            this.amountRentTextBox.TabIndex = 12;
            this.amountRentTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.amountRentTextBox_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(42, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Сумма НДС:";
            // 
            // vatTextBox
            // 
            this.vatTextBox.Enabled = false;
            this.vatTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vatTextBox.Location = new System.Drawing.Point(157, 271);
            this.vatTextBox.Name = "vatTextBox";
            this.vatTextBox.Size = new System.Drawing.Size(309, 29);
            this.vatTextBox.TabIndex = 22;
            this.vatTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vatTextBox_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(40, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Дата оплаты:";
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(157, 309);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(309, 29);
            this.datePicker.TabIndex = 28;
            this.datePicker.Value = new System.DateTime(2020, 6, 3, 0, 0, 0, 0);
            this.datePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.datePicker_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Тип помещения:";
            // 
            // areaTypeComboBox
            // 
            this.areaTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.areaTypeComboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.areaTypeComboBox.FormattingEnabled = true;
            this.areaTypeComboBox.Location = new System.Drawing.Point(157, 10);
            this.areaTypeComboBox.Name = "areaTypeComboBox";
            this.areaTypeComboBox.Size = new System.Drawing.Size(309, 29);
            this.areaTypeComboBox.TabIndex = 30;
            this.areaTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.areaTypeComboBox_SelectedIndexChanged);
            this.areaTypeComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.areaTypeComboBox_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(24, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Сумма оплаты:";
            // 
            // amountPaymentTextBox
            // 
            this.amountPaymentTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountPaymentTextBox.Location = new System.Drawing.Point(157, 194);
            this.amountPaymentTextBox.Name = "amountPaymentTextBox";
            this.amountPaymentTextBox.Size = new System.Drawing.Size(309, 29);
            this.amountPaymentTextBox.TabIndex = 14;
            this.amountPaymentTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.amountPaymentTextBox_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(77, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "Заметка:";
            // 
            // noteTextBox
            // 
            this.noteTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noteTextBox.Location = new System.Drawing.Point(157, 233);
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(309, 29);
            this.noteTextBox.TabIndex = 20;
            this.noteTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.noteTextBox_KeyDown);
            // 
            // AddFlatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(478, 391);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.amountPaymentTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.areaTypeComboBox);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.vatTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.amountRentTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.rentersComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contractTextBox);
            this.Controls.Add(this.addRecordButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddFlatsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление записи";
            this.Load += new System.EventHandler(this.AddFlatsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addRecordButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox contractTextBox;
        private System.Windows.Forms.ComboBox rentersComboBox;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox amountRentTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox vatTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox areaTypeComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox amountPaymentTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox noteTextBox;
    }
}