﻿namespace Project_Store
{
    partial class CreatTeacherProfile
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatTeacherProfile));
            this.birthdate = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UPButton = new System.Windows.Forms.Button();
            this.AddNewButton = new System.Windows.Forms.Button();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.subjectCategoryVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.radiobox2 = new System.Windows.Forms.RadioButton();
            this.radiobox1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.MajorTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectCategoryVMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // birthdate
            // 
            this.birthdate.Checked = false;
            this.birthdate.Font = new System.Drawing.Font("Old English Text MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdate.Location = new System.Drawing.Point(230, 173);
            this.birthdate.Margin = new System.Windows.Forms.Padding(2);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(173, 23);
            this.birthdate.TabIndex = 56;
            this.birthdate.Value = new System.DateTime(2022, 11, 21, 0, 0, 0, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(579, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 162);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // UPButton
            // 
            this.UPButton.BackColor = System.Drawing.Color.Black;
            this.UPButton.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UPButton.Location = new System.Drawing.Point(606, 325);
            this.UPButton.Name = "UPButton";
            this.UPButton.Size = new System.Drawing.Size(102, 36);
            this.UPButton.TabIndex = 54;
            this.UPButton.Text = "Upload Picture";
            this.UPButton.UseVisualStyleBackColor = false;
            this.UPButton.Click += new System.EventHandler(this.UPButton_Click);
            // 
            // AddNewButton
            // 
            this.AddNewButton.BackColor = System.Drawing.Color.Black;
            this.AddNewButton.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AddNewButton.Location = new System.Drawing.Point(255, 454);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(113, 45);
            this.AddNewButton.TabIndex = 50;
            this.AddNewButton.Text = "Add New";
            this.AddNewButton.UseVisualStyleBackColor = false;
            this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DataSource = this.subjectCategoryVMBindingSource;
            this.CategoryComboBox.DisplayMember = "CategoryName";
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(230, 258);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(173, 20);
            this.CategoryComboBox.TabIndex = 48;
            this.CategoryComboBox.ValueMember = "Id";
            // 
            // subjectCategoryVMBindingSource
            // 
            this.subjectCategoryVMBindingSource.DataSource = typeof(Project_Store.models.ViewModels.SubjectCategoryVM);
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(230, 330);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(173, 22);
            this.PhoneTextBox.TabIndex = 47;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(230, 134);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(173, 22);
            this.NameTextBox.TabIndex = 46;
            // 
            // radiobox2
            // 
            this.radiobox2.AutoSize = true;
            this.radiobox2.Font = new System.Drawing.Font("Old English Text MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radiobox2.Location = new System.Drawing.Point(313, 214);
            this.radiobox2.Name = "radiobox2";
            this.radiobox2.Size = new System.Drawing.Size(62, 20);
            this.radiobox2.TabIndex = 44;
            this.radiobox2.TabStop = true;
            this.radiobox2.Text = "Female";
            this.radiobox2.UseVisualStyleBackColor = true;
            // 
            // radiobox1
            // 
            this.radiobox1.AutoSize = true;
            this.radiobox1.Font = new System.Drawing.Font("Old English Text MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radiobox1.Location = new System.Drawing.Point(230, 214);
            this.radiobox1.Name = "radiobox1";
            this.radiobox1.Size = new System.Drawing.Size(51, 20);
            this.radiobox1.TabIndex = 43;
            this.radiobox1.TabStop = true;
            this.radiobox1.Text = "Male";
            this.radiobox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Old English Text MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(87, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 42;
            this.label4.Text = "Gender :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Old English Text MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(87, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 24);
            this.label7.TabIndex = 38;
            this.label7.Text = "Phone No :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Old English Text MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(87, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 24);
            this.label6.TabIndex = 41;
            this.label6.Text = "Course :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Old English Text MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(90, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 37;
            this.label3.Text = "Date of Birth :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Old English Text MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(87, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 24);
            this.label5.TabIndex = 36;
            this.label5.Text = "Department :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Old English Text MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(90, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 40;
            this.label2.Text = "Name :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Old English Text MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(310, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(231, 38);
            this.label9.TabIndex = 39;
            this.label9.Text = "Teacher_Profile";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Old English Text MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(87, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 24);
            this.label8.TabIndex = 38;
            this.label8.Text = "GMail :";
            // 
            // mailTextBox
            // 
            this.mailTextBox.Location = new System.Drawing.Point(230, 368);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(173, 22);
            this.mailTextBox.TabIndex = 47;
            // 
            // MajorTextBox
            // 
            this.MajorTextBox.Location = new System.Drawing.Point(230, 290);
            this.MajorTextBox.Name = "MajorTextBox";
            this.MajorTextBox.Size = new System.Drawing.Size(173, 22);
            this.MajorTextBox.TabIndex = 47;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(606, 368);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 57;
            // 
            // CreatTeacherProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(857, 554);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.birthdate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UPButton);
            this.Controls.Add(this.AddNewButton);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.MajorTextBox);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.radiobox2);
            this.Controls.Add(this.radiobox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreatTeacherProfile";
            this.Text = "CreatTeacherProfile";
            this.Click += new System.EventHandler(this.CreatTeacherProfile_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectCategoryVMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker birthdate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button UPButton;
        private System.Windows.Forms.Button AddNewButton;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.RadioButton radiobox2;
        private System.Windows.Forms.RadioButton radiobox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource subjectCategoryVMBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.TextBox MajorTextBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}