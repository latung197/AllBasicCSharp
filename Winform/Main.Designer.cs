namespace Winform
{
    partial class Main
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
            this.flpanListImgOutput = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nbrHightBackgroud = new System.Windows.Forms.NumericUpDown();
            this.nbrWidthBackgroud = new System.Windows.Forms.NumericUpDown();
            this.nbrWidthImg = new System.Windows.Forms.NumericUpDown();
            this.nbrHighImg = new System.Windows.Forms.NumericUpDown();
            this.nbrLineTitle = new System.Windows.Forms.NumericUpDown();
            this.nbrLineContent = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ckbImgBackground = new System.Windows.Forms.CheckBox();
            this.btnImgBackground = new System.Windows.Forms.Button();
            this.txtPathImgBackground = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nbrHightBackgroud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrWidthBackgroud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrWidthImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrHighImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrLineTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrLineContent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateImgae
            // 
            this.btnCreateImgae.Location = new System.Drawing.Point(27, 378);
            this.btnCreateImgae.Name = "btnCreateImgae";
            this.btnCreateImgae.Size = new System.Drawing.Size(75, 23);
            this.btnCreateImgae.TabIndex = 1;
            this.btnCreateImgae.Text = "Tạo ảnh";
            this.btnCreateImgae.UseVisualStyleBackColor = true;
            this.btnCreateImgae.Click += new System.EventHandler(this.btnCreateImage);
            // 
            // txtPathExcel
            // 
            this.txtPathExcel.Location = new System.Drawing.Point(27, 160);
            this.txtPathExcel.Name = "txtPathExcel";
            this.txtPathExcel.Size = new System.Drawing.Size(319, 20);
            this.txtPathExcel.TabIndex = 2;
            // 
            // btnPathExcel
            // 
            this.btnPathExcel.Location = new System.Drawing.Point(352, 160);
            this.btnPathExcel.Name = "btnPathExcel";
            this.btnPathExcel.Size = new System.Drawing.Size(136, 23);
            this.btnPathExcel.TabIndex = 3;
            this.btnPathExcel.Text = "File Exel Text";
            this.btnPathExcel.UseVisualStyleBackColor = true;
            this.btnPathExcel.Click += new System.EventHandler(this.btnPathExcel_Click);
            // 
            // txtPathInput
            // 
            this.txtPathInput.Location = new System.Drawing.Point(27, 195);
            this.txtPathInput.Name = "txtPathInput";
            this.txtPathInput.Size = new System.Drawing.Size(319, 20);
            this.txtPathInput.TabIndex = 4;
            // 
            // txtPathOutput
            // 
            this.txtPathOutput.Location = new System.Drawing.Point(27, 228);
            this.txtPathOutput.Name = "txtPathOutput";
            this.txtPathOutput.Size = new System.Drawing.Size(319, 20);
            this.txtPathOutput.TabIndex = 5;
            // 
            // btnPathImageInput
            // 
            this.btnPathImageInput.Location = new System.Drawing.Point(352, 195);
            this.btnPathImageInput.Name = "btnPathImageInput";
            this.btnPathImageInput.Size = new System.Drawing.Size(136, 23);
            this.btnPathImageInput.TabIndex = 6;
            this.btnPathImageInput.Text = "Thư mục ảnh Input";
            this.btnPathImageInput.UseVisualStyleBackColor = true;
            this.btnPathImageInput.Click += new System.EventHandler(this.btnPathImageInput_Click);
            // 
            // btnPathImageOutput
            // 
            this.btnPathImageOutput.Location = new System.Drawing.Point(352, 228);
            this.btnPathImageOutput.Name = "btnPathImageOutput";
            this.btnPathImageOutput.Size = new System.Drawing.Size(136, 23);
            this.btnPathImageOutput.TabIndex = 7;
            this.btnPathImageOutput.Text = "Thư mục ảnh Output";
            this.btnPathImageOutput.UseVisualStyleBackColor = true;
            this.btnPathImageOutput.Click += new System.EventHandler(this.btnPathImageOutput_Click);
            // 
            // btnCreateTemplateExcel
            // 
            this.btnCreateTemplateExcel.Location = new System.Drawing.Point(27, 282);
            this.btnCreateTemplateExcel.Name = "btnCreateTemplateExcel";
            this.btnCreateTemplateExcel.Size = new System.Drawing.Size(136, 23);
            this.btnCreateTemplateExcel.TabIndex = 8;
            this.btnCreateTemplateExcel.Text = "Tạo file Excel mẫu";
            this.btnCreateTemplateExcel.UseVisualStyleBackColor = true;
            this.btnCreateTemplateExcel.Click += new System.EventHandler(this.btnCreateTemplateExcel_Click);
            // 
            // prbTienTrinh
            // 
            this.prbTienTrinh.Location = new System.Drawing.Point(27, 331);
            this.prbTienTrinh.Name = "prbTienTrinh";
            this.prbTienTrinh.Size = new System.Drawing.Size(319, 23);
            this.prbTienTrinh.TabIndex = 9;
            // 
            // flpanListImgOutput
            // 
            this.flpanListImgOutput.AutoScroll = true;
            this.flpanListImgOutput.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpanListImgOutput.Location = new System.Drawing.Point(595, 0);
            this.flpanListImgOutput.Name = "flpanListImgOutput";
            this.flpanListImgOutput.Size = new System.Drawing.Size(540, 517);
            this.flpanListImgOutput.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kích thước nền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Kích thước ảnh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Số từ 1 dòng tiêu đề";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Số từ 1 dòng nội dung";
            // 
            // nbrHightBackgroud
            // 
            this.nbrHightBackgroud.Location = new System.Drawing.Point(205, 11);
            this.nbrHightBackgroud.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nbrHightBackgroud.Name = "nbrHightBackgroud";
            this.nbrHightBackgroud.Size = new System.Drawing.Size(66, 20);
            this.nbrHightBackgroud.TabIndex = 15;
            this.nbrHightBackgroud.Validated += new System.EventHandler(this.nbrHightBackgroud_Validated);
            // 
            // nbrWidthBackgroud
            // 
            this.nbrWidthBackgroud.Location = new System.Drawing.Point(340, 11);
            this.nbrWidthBackgroud.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nbrWidthBackgroud.Name = "nbrWidthBackgroud";
            this.nbrWidthBackgroud.Size = new System.Drawing.Size(66, 20);
            this.nbrWidthBackgroud.TabIndex = 16;
            this.nbrWidthBackgroud.Validated += new System.EventHandler(this.nbrWidthBackgroud_Validated);
            // 
            // nbrWidthImg
            // 
            this.nbrWidthImg.Location = new System.Drawing.Point(340, 36);
            this.nbrWidthImg.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nbrWidthImg.Name = "nbrWidthImg";
            this.nbrWidthImg.Size = new System.Drawing.Size(66, 20);
            this.nbrWidthImg.TabIndex = 18;
            this.nbrWidthImg.Validated += new System.EventHandler(this.nbrWidthImg_Validated);
            // 
            // nbrHighImg
            // 
            this.nbrHighImg.Location = new System.Drawing.Point(205, 36);
            this.nbrHighImg.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nbrHighImg.Name = "nbrHighImg";
            this.nbrHighImg.Size = new System.Drawing.Size(66, 20);
            this.nbrHighImg.TabIndex = 17;
            this.nbrHighImg.Validated += new System.EventHandler(this.nbrHighImg_Validated);
            // 
            // nbrLineTitle
            // 
            this.nbrLineTitle.Location = new System.Drawing.Point(205, 62);
            this.nbrLineTitle.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nbrLineTitle.Name = "nbrLineTitle";
            this.nbrLineTitle.Size = new System.Drawing.Size(66, 20);
            this.nbrLineTitle.TabIndex = 19;
            this.nbrLineTitle.Validated += new System.EventHandler(this.nbrLineTitle_Validated);
            // 
            // nbrLineContent
            // 
            this.nbrLineContent.Location = new System.Drawing.Point(205, 88);
            this.nbrLineContent.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nbrLineContent.Name = "nbrLineContent";
            this.nbrLineContent.Size = new System.Drawing.Size(66, 20);
            this.nbrLineContent.TabIndex = 20;
            this.nbrLineContent.Validated += new System.EventHandler(this.nbrLineContent_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "High";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Width";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(167, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "High";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Width";
            // 
            // ckbImgBackground
            // 
            this.ckbImgBackground.AutoSize = true;
            this.ckbImgBackground.Location = new System.Drawing.Point(340, 64);
            this.ckbImgBackground.Name = "ckbImgBackground";
            this.ckbImgBackground.Size = new System.Drawing.Size(104, 17);
            this.ckbImgBackground.TabIndex = 25;
            this.ckbImgBackground.Text = "Lấy ảnh làm nền";
            this.ckbImgBackground.UseVisualStyleBackColor = true;
            // 
            // btnImgBackground
            // 
            this.btnImgBackground.Location = new System.Drawing.Point(352, 126);
            this.btnImgBackground.Name = "btnImgBackground";
            this.btnImgBackground.Size = new System.Drawing.Size(136, 23);
            this.btnImgBackground.TabIndex = 27;
            this.btnImgBackground.Text = "Ảnh nền";
            this.btnImgBackground.UseVisualStyleBackColor = true;
            this.btnImgBackground.Click += new System.EventHandler(this.btnImgBackground_Click);
            // 
            // txtPathImgBackground
            // 
            this.txtPathImgBackground.Location = new System.Drawing.Point(27, 126);
            this.txtPathImgBackground.Name = "txtPathImgBackground";
            this.txtPathImgBackground.Size = new System.Drawing.Size(319, 20);
            this.txtPathImgBackground.TabIndex = 26;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 517);
            this.Controls.Add(this.btnImgBackground);
            this.Controls.Add(this.txtPathImgBackground);
            this.Controls.Add(this.ckbImgBackground);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nbrLineContent);
            this.Controls.Add(this.nbrLineTitle);
            this.Controls.Add(this.nbrWidthImg);
            this.Controls.Add(this.nbrHighImg);
            this.Controls.Add(this.nbrWidthBackgroud);
            this.Controls.Add(this.nbrHightBackgroud);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpanListImgOutput);
            this.Controls.Add(this.prbTienTrinh);
            this.Controls.Add(this.btnCreateTemplateExcel);
            this.Controls.Add(this.btnPathImageOutput);
            this.Controls.Add(this.btnPathImageInput);
            this.Controls.Add(this.txtPathOutput);
            this.Controls.Add(this.txtPathInput);
            this.Controls.Add(this.btnPathExcel);
            this.Controls.Add(this.txtPathExcel);
            this.Controls.Add(this.btnCreateImgae);
            this.Name = "Main";
            this.Text = "Sinh ảnh tự động";
            ((System.ComponentModel.ISupportInitialize)(this.nbrHightBackgroud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrWidthBackgroud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrWidthImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrHighImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrLineTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrLineContent)).EndInit();
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
        private System.Windows.Forms.FlowLayoutPanel flpanListImgOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nbrHightBackgroud;
        private System.Windows.Forms.NumericUpDown nbrWidthBackgroud;
        private System.Windows.Forms.NumericUpDown nbrWidthImg;
        private System.Windows.Forms.NumericUpDown nbrHighImg;
        private System.Windows.Forms.NumericUpDown nbrLineTitle;
        private System.Windows.Forms.NumericUpDown nbrLineContent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ckbImgBackground;
        private System.Windows.Forms.Button btnImgBackground;
        private System.Windows.Forms.TextBox txtPathImgBackground;
    }
}

