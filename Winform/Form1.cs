using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Winform
{
    public partial class Form1 : Form
    {
        private string excelFilePath;
        private string imagesDirectory;
        private string outputDirectory;

        public Form1()
        {
            InitializeComponent();
            LoadSettings();
        }
        private void LoadSettings()
        { 
            excelFilePath = ConfigurationManager.AppSettings["ExcelFilePath"];
            imagesDirectory = ConfigurationManager.AppSettings["ImagesDirectory"];
            outputDirectory = ConfigurationManager.AppSettings["OutputDirectory"];

            txtPathExcel.Text = excelFilePath;
            txtPathInput.Text = imagesDirectory;
            txtPathOutput.Text = outputDirectory;
        }

        private void SaveSettings()
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["ExcelFilePath"].Value = excelFilePath;
            config.AppSettings.Settings["ImagesDirectory"].Value = imagesDirectory;
            config.AppSettings.Settings["OutputDirectory"].Value = outputDirectory;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        public void ProcessImage(string inputPathImg, string outPutPathImg, string textTop, string textButton)
        {
            int newWidth = 1080;
            int newHeight = 1920;
            int resizedWidth = 1080;
            int resizedHeight = 640;
            textTop = WordWrap(textTop, 4);
            textButton = WordWrap(textButton, 9);
            // Đọc ảnh gốc
            Image originalImage = Image.FromFile(inputPathImg);
            // Tạo ảnh nền mới với kích thước 1920 x 1080
            Bitmap newImage = new Bitmap(newWidth, newHeight);
            // Tạo ảnh nền mới với kích thước 1920 x 1080
            using (Graphics graphics = Graphics.FromImage(newImage))
            { // Tô màu nền (ở đây là màu đen)
                graphics.Clear(Color.Black);
                // Tính toán vị trí để đặt ảnh gốc vào giữa nền
                int x = (newWidth - resizedWidth) / 2;
                int y = (newHeight - resizedHeight) / 2;
                // Vẽ ảnh gốc đã được co lại lên ảnh nền mới
                graphics.DrawImage(originalImage, x, y, resizedWidth, resizedHeight);
                // Thiết lập thông tin chữ
                Font font = new Font("Arial", 65);
                Brush brush = new SolidBrush(Color.White);

                // Căn giữa và vẽ chữ trên theo từng dòng
                var topTextLines = textTop.Split('\n');
                // Vị trí chữ ngay trên ảnh, cách ảnh 10 pixel
                float topTextY = y - (topTextLines.Length * graphics.MeasureString("Sample", font).Height) - 10; 
                foreach (var line in topTextLines)
                {
                    SizeF topTextSize = graphics.MeasureString(line, font);
                    PointF topTextPosition = new PointF((newWidth - topTextSize.Width) / 2, topTextY);
                    graphics.DrawString(line, font, brush, topTextPosition);
                    topTextY += topTextSize.Height;
                }

                //Font chữ phía dưới
                Font fontButton = new Font("Arial", 30);
                // Căn giữa khi có nhiều dòng
                var bottomTextLines = textButton.Split('\n');
                float bottomTextY = y + resizedHeight + 10; // Vị trí chữ ngay dưới ảnh, cách ảnh 10 pixel
                foreach (var line in bottomTextLines)
                {
                    SizeF bottomTextSize = graphics.MeasureString(line, fontButton);
                    PointF bottomTextPosition = new PointF((newWidth - bottomTextSize.Width) / 2, bottomTextY);
                    graphics.DrawString(line, fontButton, brush, bottomTextPosition);
                    bottomTextY += bottomTextSize.Height;
                }
            }
            // Lưu ảnh đã ghép
            newImage.Save(outPutPathImg);
        }

        static string WordWrap(string input, int wordsPerLine)
        {
            StringBuilder result = new StringBuilder();
            string[] words = input.Split(' ');
            int wordCount = 0;
            foreach (string word in words)
            {
                result.Append(word + " ");
                wordCount++;
                if (wordCount == wordsPerLine)
                {
                    result.Append(Environment.NewLine); wordCount = 0;
                }
            }
            return result.ToString().Trim();
        }

        private void btnPathExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                excelFilePath = openFileDialog.FileName;
                txtPathExcel.Text = excelFilePath;
                SaveSettings();
            }
        }

        private async void btnCreateImage(object sender, EventArgs e)
        {

            if (!Directory.Exists(outputDirectory))
            {
                Directory.CreateDirectory(outputDirectory);
            }

            // Đọc nội dung từ file Excel
            using (var workbook = new XLWorkbook(excelFilePath))
            {
                var worksheet = workbook.Worksheet(1);

                // Duyệt qua các hàng trong file Excel
                int row = 2;

                int totalRows = worksheet.LastRowUsed().RowNumber();
                prbTienTrinh.Maximum = totalRows - 1; // Cập nhật giá trị tối đa của thanh tiến trình
                prbTienTrinh.Value = 0;

                while (!worksheet.Cell(row, 1).IsEmpty())
                {
                    string topText = worksheet.Cell(row, 1).GetValue<string>();
                    string bottomText = worksheet.Cell(row, 2).GetValue<string>();
                    string imagePath = Path.Combine(imagesDirectory, worksheet.Cell(row, 3).GetValue<string>());
                    string outputPath = Path.Combine(outputDirectory, $"output_image_{row}.jpg");

                    // Xử lý ảnh
                   await Task.Run( ()=> ProcessImage(imagePath, outputPath, topText, bottomText));
                    prbTienTrinh.Value = row - 1;
                    // Tải ảnh lên Google Drive
                    //UploadToGoogleDrive(outputPath);

                    row++;
                }
            }
        }

        private void btnPathImageInput_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imagesDirectory = folderBrowserDialog.SelectedPath;
                txtPathInput.Text = imagesDirectory;
                SaveSettings();
            }
        }

        private void btnPathImageOutput_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                outputDirectory = folderBrowserDialog.SelectedPath;
                txtPathOutput.Text = outputDirectory;
                SaveSettings();
            }
        }

        private void btnCreateTemplateExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Sheet1");
                    worksheet.Cell(1, 1).Value = "Tiêu đề";
                    worksheet.Cell(1, 2).Value = "Nội dung";
                    worksheet.Cell(1, 3).Value = "Tên ảnh";
                    workbook.SaveAs(saveFileDialog.FileName);
                }
                MessageBox.Show("Excel template created successfully!", "Success", MessageBoxButtons.OK);
            }
        }
    }
}
