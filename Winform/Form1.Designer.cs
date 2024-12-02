namespace Winform
{
    partial class Form1
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
            this.btnCreateImgae = new System.Windows.Forms.Button();
            this.txtPathExcel = new System.Windows.Forms.TextBox();
            this.btnPathExcel = new System.Windows.Forms.Button();
            this.txtPathInput = new System.Windows.Forms.TextBox();
            this.txtPathOutput = new System.Windows.Forms.TextBox();
            this.btnPathImageInput = new System.Windows.Forms.Button();
            this.btnPathImageOutput = new System.Windows.Forms.Button();
            this.btnCreateTemplateExcel = new System.Windows.Forms.Button();
            this.prbTienTrinh = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnCreateImgae
            // 
            this.btnCreateImgae.Location = new System.Drawing.Point(54, 302);
            this.btnCreateImgae.Name = "btnCreateImgae";
            this.btnCreateImgae.Size = new System.Drawing.Size(75, 23);
            this.btnCreateImgae.TabIndex = 1;
            this.btnCreateImgae.Text = "Tạo ảnh";
            this.btnCreateImgae.UseVisualStyleBackColor = true;
            this.btnCreateImgae.Click += new System.EventHandler(this.btnCreateImage);
            // 
            // txtPathExcel
            // 
            this.txtPathExcel.Location = new System.Drawing.Point(54, 52);
            this.txtPathExcel.Name = "txtPathExcel";
            this.txtPathExcel.Size = new System.Drawing.Size(319, 20);
            this.txtPathExcel.TabIndex = 2;
            // 
            // btnPathExcel
            // 
            this.btnPathExcel.Location = new System.Drawing.Point(388, 49);
            this.btnPathExcel.Name = "btnPathExcel";
            this.btnPathExcel.Size = new System.Drawing.Size(136, 23);
            this.btnPathExcel.TabIndex = 3;
            this.btnPathExcel.Text = "File Exel Text";
            this.btnPathExcel.UseVisualStyleBackColor = true;
            this.btnPathExcel.Click += new System.EventHandler(this.btnPathExcel_Click);
            // 
            // txtPathInput
            // 
            this.txtPathInput.Location = new System.Drawing.Point(54, 106);
            this.txtPathInput.Name = "txtPathInput";
            this.txtPathInput.Size = new System.Drawing.Size(319, 20);
            this.txtPathInput.TabIndex = 4;
            // 
            // txtPathOutput
            // 
            this.txtPathOutput.Location = new System.Drawing.Point(54, 164);
            this.txtPathOutput.Name = "txtPathOutput";
            this.txtPathOutput.Size = new System.Drawing.Size(319, 20);
            this.txtPathOutput.TabIndex = 5;
            // 
            // btnPathImageInput
            // 
            this.btnPathImageInput.Location = new System.Drawing.Point(388, 106);
            this.btnPathImageInput.Name = "btnPathImageInput";
            this.btnPathImageInput.Size = new System.Drawing.Size(136, 23);
            this.btnPathImageInput.TabIndex = 6;
            this.btnPathImageInput.Text = "Thư mục ảnh Input";
            this.btnPathImageInput.UseVisualStyleBackColor = true;
            this.btnPathImageInput.Click += new System.EventHandler(this.btnPathImageInput_Click);
            // 
            // btnPathImageOutput
            // 
            this.btnPathImageOutput.Location = new System.Drawing.Point(388, 161);
            this.btnPathImageOutput.Name = "btnPathImageOutput";
            this.btnPathImageOutput.Size = new System.Drawing.Size(136, 23);
            this.btnPathImageOutput.TabIndex = 7;
            this.btnPathImageOutput.Text = "Thư mục ảnh Output";
            this.btnPathImageOutput.UseVisualStyleBackColor = true;
            this.btnPathImageOutput.Click += new System.EventHandler(this.btnPathImageOutput_Click);
            // 
            // btnCreateTemplateExcel
            // 
            this.btnCreateTemplateExcel.Location = new System.Drawing.Point(54, 206);
            this.btnCreateTemplateExcel.Name = "btnCreateTemplateExcel";
            this.btnCreateTemplateExcel.Size = new System.Drawing.Size(136, 23);
            this.btnCreateTemplateExcel.TabIndex = 8;
            this.btnCreateTemplateExcel.Text = "Tạo file Excel mẫu";
            this.btnCreateTemplateExcel.UseVisualStyleBackColor = true;
            this.btnCreateTemplateExcel.Click += new System.EventHandler(this.btnCreateTemplateExcel_Click);
            // 
            // prbTienTrinh
            // 
            this.prbTienTrinh.Location = new System.Drawing.Point(54, 255);
            this.prbTienTrinh.Name = "prbTienTrinh";
            this.prbTienTrinh.Size = new System.Drawing.Size(319, 23);
            this.prbTienTrinh.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 381);
            this.Controls.Add(this.prbTienTrinh);
            this.Controls.Add(this.btnCreateTemplateExcel);
            this.Controls.Add(this.btnPathImageOutput);
            this.Controls.Add(this.btnPathImageInput);
            this.Controls.Add(this.txtPathOutput);
            this.Controls.Add(this.txtPathInput);
            this.Controls.Add(this.btnPathExcel);
            this.Controls.Add(this.txtPathExcel);
            this.Controls.Add(this.btnCreateImgae);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreateImgae;
        private System.Windows.Forms.TextBox txtPathExcel;
        private System.Windows.Forms.Button btnPathExcel;
        private System.Windows.Forms.TextBox txtPathInput;
        private System.Windows.Forms.TextBox txtPathOutput;
        private System.Windows.Forms.Button btnPathImageInput;
        private System.Windows.Forms.Button btnPathImageOutput;
        private System.Windows.Forms.Button btnCreateTemplateExcel;
        private System.Windows.Forms.ProgressBar prbTienTrinh;
    }
}

