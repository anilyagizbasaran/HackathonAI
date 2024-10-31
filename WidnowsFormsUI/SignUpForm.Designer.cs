
namespace WidnowsFormsUI
{
    partial class SignUpForm
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
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxDepartment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbTeacher = new System.Windows.Forms.RadioButton();
            this.rdbStudent = new System.Windows.Forms.RadioButton();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.dgwSignUp = new System.Windows.Forms.DataGridView();
            this.btnrRemove = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSignUp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(139, 66);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Şifre";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(139, 99);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(100, 20);
            this.tbxPassword.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bölümü / Departmanı";
            // 
            // tbxDepartment
            // 
            this.tbxDepartment.Location = new System.Drawing.Point(139, 136);
            this.tbxDepartment.Name = "tbxDepartment";
            this.tbxDepartment.Size = new System.Drawing.Size(100, 20);
            this.tbxDepartment.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fotoğraf";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnrRemove);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnSignUp);
            this.groupBox1.Controls.Add(this.pbPhoto);
            this.groupBox1.Controls.Add(this.tbxPassword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxDepartment);
            this.groupBox1.Controls.Add(this.tbxName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(75, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 375);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı İşlemleri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbTeacher);
            this.groupBox2.Controls.Add(this.rdbStudent);
            this.groupBox2.Location = new System.Drawing.Point(15, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 61);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kullanıcı Tipi";
            // 
            // rdbTeacher
            // 
            this.rdbTeacher.AutoSize = true;
            this.rdbTeacher.Location = new System.Drawing.Point(124, 30);
            this.rdbTeacher.Name = "rdbTeacher";
            this.rdbTeacher.Size = new System.Drawing.Size(71, 17);
            this.rdbTeacher.TabIndex = 8;
            this.rdbTeacher.TabStop = true;
            this.rdbTeacher.Text = "Öğretmen";
            this.rdbTeacher.UseVisualStyleBackColor = true;
            this.rdbTeacher.CheckedChanged += new System.EventHandler(this.rdbTeacher_CheckedChanged);
            // 
            // rdbStudent
            // 
            this.rdbStudent.AutoSize = true;
            this.rdbStudent.Location = new System.Drawing.Point(6, 30);
            this.rdbStudent.Name = "rdbStudent";
            this.rdbStudent.Size = new System.Drawing.Size(62, 17);
            this.rdbStudent.TabIndex = 7;
            this.rdbStudent.TabStop = true;
            this.rdbStudent.Text = "Öğrenci";
            this.rdbStudent.UseVisualStyleBackColor = true;
            this.rdbStudent.CheckedChanged += new System.EventHandler(this.rdbStudent_CheckedChanged);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(270, 346);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(75, 23);
            this.btnSignUp.TabIndex = 4;
            this.btnSignUp.Text = "Kaydet";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // pbPhoto
            // 
            this.pbPhoto.Location = new System.Drawing.Point(139, 260);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(100, 76);
            this.pbPhoto.TabIndex = 2;
            this.pbPhoto.TabStop = false;
            // 
            // dgwSignUp
            // 
            this.dgwSignUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSignUp.Location = new System.Drawing.Point(441, 49);
            this.dgwSignUp.Name = "dgwSignUp";
            this.dgwSignUp.Size = new System.Drawing.Size(637, 369);
            this.dgwSignUp.TabIndex = 4;
            // 
            // btnrRemove
            // 
            this.btnrRemove.Location = new System.Drawing.Point(189, 346);
            this.btnrRemove.Name = "btnrRemove";
            this.btnrRemove.Size = new System.Drawing.Size(75, 23);
            this.btnrRemove.TabIndex = 5;
            this.btnrRemove.Text = "Sil";
            this.btnrRemove.UseVisualStyleBackColor = true;
            this.btnrRemove.Click += new System.EventHandler(this.btnrRemove_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 467);
            this.Controls.Add(this.dgwSignUp);
            this.Controls.Add(this.groupBox1);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSignUp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxDepartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbTeacher;
        private System.Windows.Forms.RadioButton rdbStudent;
        private System.Windows.Forms.DataGridView dgwSignUp;
        private System.Windows.Forms.Button btnrRemove;
    }
}