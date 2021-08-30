
namespace Student
{
    partial class frm_addInfo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.rad_male = new System.Windows.Forms.RadioButton();
            this.rad_female = new System.Windows.Forms.RadioButton();
            this.num_age = new System.Windows.Forms.NumericUpDown();
            this.date_birth = new System.Windows.Forms.DateTimePicker();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.combo_class = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_age)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "性别";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "年龄";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "生日";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "住址";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(109, 26);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(200, 23);
            this.txt_name.TabIndex = 5;
            // 
            // rad_male
            // 
            this.rad_male.AutoSize = true;
            this.rad_male.Location = new System.Drawing.Point(109, 73);
            this.rad_male.Name = "rad_male";
            this.rad_male.Size = new System.Drawing.Size(38, 21);
            this.rad_male.TabIndex = 6;
            this.rad_male.TabStop = true;
            this.rad_male.Text = "男";
            this.rad_male.UseVisualStyleBackColor = true;
            // 
            // rad_female
            // 
            this.rad_female.AutoSize = true;
            this.rad_female.Location = new System.Drawing.Point(207, 71);
            this.rad_female.Name = "rad_female";
            this.rad_female.Size = new System.Drawing.Size(38, 21);
            this.rad_female.TabIndex = 7;
            this.rad_female.TabStop = true;
            this.rad_female.Text = "女";
            this.rad_female.UseVisualStyleBackColor = true;
            // 
            // num_age
            // 
            this.num_age.Location = new System.Drawing.Point(109, 120);
            this.num_age.Name = "num_age";
            this.num_age.Size = new System.Drawing.Size(200, 23);
            this.num_age.TabIndex = 8;
            // 
            // date_birth
            // 
            this.date_birth.Location = new System.Drawing.Point(109, 167);
            this.date_birth.Name = "date_birth";
            this.date_birth.Size = new System.Drawing.Size(200, 23);
            this.date_birth.TabIndex = 9;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(109, 214);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(200, 23);
            this.txt_address.TabIndex = 10;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(13, 318);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // combo_class
            // 
            this.combo_class.FormattingEnabled = true;
            this.combo_class.Location = new System.Drawing.Point(109, 258);
            this.combo_class.Name = "combo_class";
            this.combo_class.Size = new System.Drawing.Size(200, 25);
            this.combo_class.TabIndex = 12;
            this.combo_class.SelectedIndexChanged += new System.EventHandler(this.combo_class_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "班级";
            // 
            // frm_addInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 394);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.combo_class);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.date_birth);
            this.Controls.Add(this.num_age);
            this.Controls.Add(this.rad_female);
            this.Controls.Add(this.rad_male);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_addInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "增加学生信息";
            this.Load += new System.EventHandler(this.frm_addInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_age)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.RadioButton rad_male;
        private System.Windows.Forms.RadioButton rad_female;
        private System.Windows.Forms.NumericUpDown num_age;
        private System.Windows.Forms.DateTimePicker date_birth;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox combo_class;
        private System.Windows.Forms.Label label6;
    }
}

