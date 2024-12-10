using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using Tesseract;
namespace ReadTextInImg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Đường dẫn tới ảnh cần nhận dạng
            string imagePath = @"C:\Users\RFVNPC\Desktop\Test2\Screenshot_1.png";
            // Đường dẫn tới tệp ngôn ngữ Tesseract
            string tessDataPath = @"C:\Users\RFVNPC\Desktop\Test1";

            // Tạo đối tượng Tesseract OCR với ngôn ngữ tiếng Việt
            using (var engine = new TesseractEngine(tessDataPath, "vie", EngineMode.Default))
            {
                using (var img = Pix.LoadFromFile(imagePath))
                {
                    using (var page = engine.Process(img))
                    {
                        // Nhận dạng văn bản trên ảnh
                        string text = page.GetText();
                        Console.WriteLine("Text recognized: " + text);

                        // Ghi văn bản ra file
                        string outputPath = @"C:\Users\RFVNPC\Desktop\Test2\recognized_text.txt";
                        File.WriteAllText(outputPath, text);
                        Console.WriteLine("Text has been written to: " + outputPath);
                    }
                }
            }
        }
    }
}
