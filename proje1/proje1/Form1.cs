using System;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proje1


{
    public partial class YouTube : Form
    {
        public YouTube()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TextBox'tan video linkini al
            string video_url = textBox1.Text;
            string argv2 = "1";
            // Python kodunu çalýþtýrmak için bir iþlem oluþtur
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"C:\Users\Fatih\AppData\Local\Programs\Python\Python312\python.exe"; // Python yolu
            start.Arguments = "E:\\Files\\Projeler\\YoutubeVideoÝndir\\proje1\\deneme.py" + video_url + " " + argv2; // Python dosyasý ve argümaný
            start.UseShellExecute = false; // Kabuk kullanma
            start.RedirectStandardOutput = true; // Çýktýyý yönlendir
            start.CreateNoWindow = true; // Pencere oluþturma

            // Ýþlemi baþlat
            using (Process process = Process.Start(start))
            {
            }
            textBox1.Text = " ";
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // TextBox'tan video linkini al
            string video_url = textBox1.Text;
            string argv2 = "2";
            // Python kodunu çalýþtýrmak için bir iþlem oluþtur
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"C:\Users\Fatih\AppData\Local\Programs\Python\Python312\python.exe"; // Python yolu
            start.Arguments = "C:\\Users\\Fatih\\Desktop\\Ýndirme\\YouTube.py " + video_url + " " + argv2; // Python dosyasý ve argümaný
            start.UseShellExecute = false; // Kabuk kullanma
            start.RedirectStandardOutput = true; // Çýktýyý yönlendir
            start.CreateNoWindow = true; // Pencere oluþturma

            // Ýþlemi baþlat
            using (Process process = Process.Start(start))
            {

            }
            textBox1.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // TextBox'tan video linkini al
            string video_url = textBox1.Text;
            string argv2 = "3";
            // Python kodunu çalýþtýrmak için bir iþlem oluþtur
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"C:\Users\Fatih\AppData\Local\Programs\Python\Python312\python.exe"; // Python yolu
            start.Arguments = "C:\\Users\\Fatih\\Desktop\\Ýndirme\\YouTube.py " + video_url + " " + argv2; // Python dosyasý ve argümaný
            start.UseShellExecute = false; // Kabuk kullanma
            start.RedirectStandardOutput = true; // Çýktýyý yönlendir
            start.CreateNoWindow = true; // Pencere oluþturma

            // Ýþlemi baþlat
            using (Process process = Process.Start(start))
            {

            }
            textBox1.Text = " ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // TextBox'tan video linkini al
            string video_url = textBox1.Text;
            string argv2 = "4";
            // Python kodunu çalýþtýrmak için bir iþlem oluþtur
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"C:\Users\Fatih\AppData\Local\Programs\Python\Python312\python.exe"; // Python yolu
            start.Arguments = "C:\\Users\\Fatih\\Desktop\\Ýndirme\\YouTube.py " + video_url + " " + argv2; // Python dosyasý ve argümaný
            start.UseShellExecute = false; // Kabuk kullanma
            start.RedirectStandardOutput = true; // Çýktýyý yönlendir
            start.CreateNoWindow = true; // Pencere oluþturma

            // Ýþlemi baþlat
            using (Process process = Process.Start(start))
            {

            }
            textBox1.Text = " ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
