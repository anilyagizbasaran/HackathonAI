
namespace WidnowsFormsUI
{
    partial class UploadVideoForm
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
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnVideoPath = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxCategoryLessonId = new System.Windows.Forms.ComboBox();
            this.tbxVideoTitle = new System.Windows.Forms.TextBox();
            this.lblVideoPath = new System.Windows.Forms.Label();
            this.lblCategoryLessonId = new System.Windows.Forms.Label();
            this.lblVideoTitle = new System.Windows.Forms.Label();
            this.dgwVideo = new System.Windows.Forms.DataGridView();
            this.entityCommand2 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.btnRemove = new System.Windows.Forms.Button();
            this.gbxProductAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Controls.Add(this.btnRemove);
            this.gbxProductAdd.Controls.Add(this.lblPath);
            this.gbxProductAdd.Controls.Add(this.btnVideoPath);
            this.gbxProductAdd.Controls.Add(this.btnAdd);
            this.gbxProductAdd.Controls.Add(this.cbxCategoryLessonId);
            this.gbxProductAdd.Controls.Add(this.tbxVideoTitle);
            this.gbxProductAdd.Controls.Add(this.lblVideoPath);
            this.gbxProductAdd.Controls.Add(this.lblCategoryLessonId);
            this.gbxProductAdd.Controls.Add(this.lblVideoTitle);
            this.gbxProductAdd.Location = new System.Drawing.Point(12, 238);
            this.gbxProductAdd.Margin = new System.Windows.Forms.Padding(2);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Padding = new System.Windows.Forms.Padding(2);
            this.gbxProductAdd.Size = new System.Drawing.Size(777, 184);
            this.gbxProductAdd.TabIndex = 13;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Yeni ürün ekle";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(124, 161);
            this.lblPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(0, 13);
            this.lblPath.TabIndex = 11;
            // 
            // btnVideoPath
            // 
            this.btnVideoPath.Location = new System.Drawing.Point(127, 132);
            this.btnVideoPath.Margin = new System.Windows.Forms.Padding(2);
            this.btnVideoPath.Name = "btnVideoPath";
            this.btnVideoPath.Size = new System.Drawing.Size(85, 20);
            this.btnVideoPath.TabIndex = 10;
            this.btnVideoPath.Text = "Video Ekle";
            this.btnVideoPath.UseVisualStyleBackColor = true;
            this.btnVideoPath.Click += new System.EventHandler(this.btnVideoPath_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(669, 154);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 26);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxCategoryLessonId
            // 
            this.cbxCategoryLessonId.FormattingEnabled = true;
            this.cbxCategoryLessonId.Location = new System.Drawing.Point(127, 87);
            this.cbxCategoryLessonId.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCategoryLessonId.Name = "cbxCategoryLessonId";
            this.cbxCategoryLessonId.Size = new System.Drawing.Size(174, 21);
            this.cbxCategoryLessonId.TabIndex = 6;
            this.cbxCategoryLessonId.SelectedIndexChanged += new System.EventHandler(this.cbxCategoryLessonId_SelectedIndexChanged);
            // 
            // tbxVideoTitle
            // 
            this.tbxVideoTitle.Location = new System.Drawing.Point(127, 41);
            this.tbxVideoTitle.Margin = new System.Windows.Forms.Padding(2);
            this.tbxVideoTitle.Name = "tbxVideoTitle";
            this.tbxVideoTitle.Size = new System.Drawing.Size(174, 20);
            this.tbxVideoTitle.TabIndex = 5;
            // 
            // lblVideoPath
            // 
            this.lblVideoPath.AutoSize = true;
            this.lblVideoPath.Location = new System.Drawing.Point(16, 139);
            this.lblVideoPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVideoPath.Name = "lblVideoPath";
            this.lblVideoPath.Size = new System.Drawing.Size(58, 13);
            this.lblVideoPath.TabIndex = 2;
            this.lblVideoPath.Text = "Video Yolu";
            // 
            // lblCategoryLessonId
            // 
            this.lblCategoryLessonId.AutoSize = true;
            this.lblCategoryLessonId.Location = new System.Drawing.Point(16, 90);
            this.lblCategoryLessonId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoryLessonId.Name = "lblCategoryLessonId";
            this.lblCategoryLessonId.Size = new System.Drawing.Size(49, 13);
            this.lblCategoryLessonId.TabIndex = 1;
            this.lblCategoryLessonId.Text = "İlgili Ders";
            // 
            // lblVideoTitle
            // 
            this.lblVideoTitle.AutoSize = true;
            this.lblVideoTitle.Location = new System.Drawing.Point(16, 44);
            this.lblVideoTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVideoTitle.Name = "lblVideoTitle";
            this.lblVideoTitle.Size = new System.Drawing.Size(67, 13);
            this.lblVideoTitle.TabIndex = 0;
            this.lblVideoTitle.Text = "Video Başlığı";
            // 
            // dgwVideo
            // 
            this.dgwVideo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwVideo.Location = new System.Drawing.Point(12, 29);
            this.dgwVideo.Margin = new System.Windows.Forms.Padding(2);
            this.dgwVideo.Name = "dgwVideo";
            this.dgwVideo.RowHeadersWidth = 51;
            this.dgwVideo.RowTemplate.Height = 24;
            this.dgwVideo.Size = new System.Drawing.Size(777, 192);
            this.dgwVideo.TabIndex = 12;
            // 
            // entityCommand2
            // 
            this.entityCommand2.CommandTimeout = 0;
            this.entityCommand2.CommandTree = null;
            this.entityCommand2.Connection = null;
            this.entityCommand2.EnablePlanCaching = true;
            this.entityCommand2.Transaction = null;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(539, 154);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(108, 26);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // UploadVideoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 477);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.dgwVideo);
            this.Name = "UploadVideoForm";
            this.Text = "UploadVideoForm";
            this.Load += new System.EventHandler(this.UploadVideoForm_Load);
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbxCategoryLessonId;
        private System.Windows.Forms.TextBox tbxVideoTitle;
        private System.Windows.Forms.Label lblVideoPath;
        private System.Windows.Forms.Label lblCategoryLessonId;
        private System.Windows.Forms.Label lblVideoTitle;
        private System.Windows.Forms.DataGridView dgwVideo;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand2;
        private System.Windows.Forms.Button btnVideoPath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnRemove;
    }
}