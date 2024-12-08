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
    public partial class Main : Form
    {
        private string excelFilePath;
        private string imagesDirectory;
        private string outputDirectory;
        private string imgBackgroundFilePath;
        private int newWidth = 0;
        private int newHeight = 0;
        private int resizedWidth = 0;
        private int resizedHeight = 0;
        private int numberWordTitle = 0;
        private int numberWordContent = 0;

        private Image selectedImage;


        public Main()
        {
            InitializeComponent();
            LoadSettings();
        }
        private void LoadSettings()
        {
            excelFilePath = ConfigurationManager.AppSettings["ExcelFilePath"];
            imagesDirectory = ConfigurationManager.AppSettings["ImagesDirectory"];
            outputDirectory = ConfigurationManager.AppSettings["OutputDirectory"];
            imgBackgroundFilePath = ConfigurationManager.AppSettings["imgBackgroundFilePath"];

            newWidth = int.Parse(ConfigurationManager.AppSettings["newWidth"]);
            newHeight = int.Parse(ConfigurationManager.AppSettings["newHeight"]);
            resizedWidth = int.Parse(ConfigurationManager.AppSettings["resizedWidth"]);
            resizedHeight = int.Parse(ConfigurationManager.AppSettings["resizedHeight"]);
            numberWordTitle = int.Parse(ConfigurationManager.AppSettings["numberWordTitle"]);
            numberWordContent = int.Parse(ConfigurationManager.AppSettings["numberWordContent"]);
            nbrHightBackgroud.Value = newHeight;
            nbrWidthBackgroud.Value = newWidth;
            nbrHighImg.Value = resizedHeight;
            nbrWidthImg.Value = newWidth;
            txtPathExcel.Text = excelFilePath;
            txtPathInput.Text = imagesDirectory;
            txtPathOutput.Text = outputDirectory;
            txtPathImgBackground.Text = imgBackgroundFilePath;
            nbrLineContent.Value = numberWordContent;
            nbrLineTitle.Value = numberWordTitle;
        }

        private void SaveSettings()
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["ExcelFilePath"].Value = excelFilePath;
            config.AppSettings.Settings["ImagesDirectory"].Value = imagesDirectory;
            config.AppSettings.Settings["OutputDirectory"].Value = outputDirectory;
            config.AppSettings.Settings["imgBackgroundFilePath"].Value = imgBackgroundFilePath;

            config.AppSettings.Settings["newWidth"].Value = newWidth.ToString();
            config.AppSettings.Settings["newHeight"].Value = newHeight.ToString();
            config.AppSettings.Settings["resizedWidth"].Value = resizedWidth.ToString();
            config.AppSettings.Settings["resizedHeight"].Value = resizedHeight.ToString();
            config.AppSettings.Settings["numberWordTitle"].Value = numberWordTitle.ToString();
            config.AppSettings.Settings["numberWordContent"].Value = numberWordContent.ToString();

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        public void ProcessImage(string inputPathImg, string outPutPathImg, string textTop, string textButton, string imgBackgroundFilePath)
        {

            textTop = WordWrap(textTop, numberWordTitle);
            textButton = WordWrap(textButton, numberWordContent);
            // Đọc ảnh gốc
            Image originalImage = Image.FromFile(inputPathImg);
            // Tạo ảnh nền mới với kích thước 1920 x 1080
            Bitmap newImage = new Bitmap(newWidth, newHeight);
            // Tạo ảnh nền mới với kích thước 1920 x 1080
            Bitmap finalImg;

            selectedImage = Image.FromFile(imgBackgroundFilePath);

            if (ckbImgBackground.Checked)
            {

                finalImg = new Bitmap(selectedImage, new Size(1080, 1920));
            }
            else
            {
                finalImg = newImage;
            }

            using (Graphics graphics = Graphics.FromImage(finalImg))
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
            finalImg.Save(outPutPathImg);

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
            SaveSettings();
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

                while (!worksheet.Cell(row, 3).IsEmpty())
                {
                    string topText = worksheet.Cell(row, 1).GetValue<string>();
                    string bottomText = worksheet.Cell(row, 2).GetValue<string>();
                    string imagePath = Path.Combine(imagesDirectory, worksheet.Cell(row, 3).GetValue<string>());
                    string outputPath = Path.Combine(outputDirectory, $"output_image_{row}.jpg");

                    // Xử lý ảnh
                    await Task.Run(() => ProcessImage(imagePath, outputPath, topText, bottomText, txtPathImgBackground.Text));
                    prbTienTrinh.Value = row - 1;
                    // Tải ảnh lên Google Drive
                    //UploadToGoogleDrive(outputPath);

                    row++;
                }

                LoadAndDisplayImages(outputDirectory);

                //MessageBox.Show("Excel template created successfully!", "Success", MessageBoxButtons.OK);
                //prbTienTrinh.Value = 0;

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
                // MessageBox.Show("Excel template created successfully!", "Success", MessageBoxButtons.OK);
            }
        }

        private void LoadAndDisplayImages(string folderPath)
        { // Xóa các ảnh cũ khỏi
            flpanListImgOutput.Controls.Clear();
            // Lấy danh sách các tệp ảnh trong thư mục
            var imageFiles = Directory.GetFiles(folderPath, "*.*").Where(file => file.ToLower().EndsWith("jpg") || file.ToLower().EndsWith("png") || file.ToLower().EndsWith("bmp")).ToList();
            // Tải và hiển thị ảnh
            foreach (var imageFile in imageFiles)
            {
                Bitmap image = LoadImageWithoutLocking(imageFile);

                PictureBox pictureBox = new PictureBox
                {
                    Image = image,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Width = 500,
                    Height = 800,
                    Margin = new Padding(5)
                };
                flpanListImgOutput.Controls.Add(pictureBox);
            }
        }
        // load lại ảnh
        private Bitmap LoadImageWithoutLocking(string imagePath)
        {
            using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                using (MemoryStream ms = new MemoryStream(buffer))
                {
                    return new Bitmap(ms);
                }
            }
        }

        private void nbrHightBackgroud_Validated(object sender, EventArgs e)
        {
            newHeight = int.Parse(nbrHightBackgroud.Value.ToString());
        }

        private void nbrWidthBackgroud_Validated(object sender, EventArgs e)
        {
            newWidth = int.Parse(nbrWidthBackgroud.Value.ToString());
        }

        private void nbrHighImg_Validated(object sender, EventArgs e)
        {
            resizedHeight = int.Parse(nbrHighImg.Value.ToString());
        }

        private void nbrWidthImg_Validated(object sender, EventArgs e)
        {
            resizedWidth = int.Parse(nbrWidthImg.Value.ToString());
        }

        private void nbrLineTitle_Validated(object sender, EventArgs e)
        {
            numberWordTitle = int.Parse(nbrLineTitle.Value.ToString());
        }

        private void nbrLineContent_Validated(object sender, EventArgs e)
        {
            numberWordContent = int.Parse(nbrLineContent.Value.ToString());
        }

        private void btnImgBackground_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImage = Image.FromFile(openFileDialog.FileName);
                    txtPathImgBackground.Text = openFileDialog.FileName;
                    imgBackgroundFilePath = openFileDialog.FileName;
                    SaveSettings();
                }
            }
        }
    }
}
