using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
        int sayac;





        double dogru = 0, yanlis = 0, net = 0, puan = 0;
        string dogrucevap = "";

        void sorular()
        {
            if (sayac == 1)
            {

                label2.Text = "Bilgisayarı kapatırken aşağıdaki yöntemlerden hangisi kullanılmalıdır ?";
                button1.Text = "Direk olarak kasa üzerinde bulunan açma kapama düğmesine basılmalıdır.";
                button2.Text = "Bilgisayarın fişi çekilmelidir.";
                button3.Text = "Başlat menüsünden Bilgisayarı Kapat seçeneğine tıklanmalıdır";
                button4.Text = "Sadece ekranın tuşuna basılmalıdır.";
                dogrucevap = button3.Text;


            }
            if (sayac == 2)
            {

                label2.Text = "Aşağıdakilerden hangisi bilgisayar karşısında yanlış oturmaktan kaynaklanan\r\n rahatsızlıklardan değildir ?";
                button1.Text = "Disk Kayması - Dirseklerde Kireçlenme";
                button2.Text = "Bel Fıtığı - Boyun Fıtığı";
                button3.Text = "Omuz Tutulması - Boyun Tutulması";
                button4.Text = "Soğuk Algınlığı";
                dogrucevap = button4.Text;


            }
            if (sayac == 3)
            {

                label2.Text = "Bilgisayarda bulunan bir dosyanın boyutunu azaltmak için \r\n aşağıdakilerden hangisi yapılmalıdır ?";
                button1.Text = "Dosya yeniden adlandırılmalıdır.";
                button2.Text = "Dosya sıkıştırılmalıdır.";
                button3.Text = "Dosyanın kısayolu oluşturulmalıdır.";
                button4.Text = "Dosya kopyalanmalıdır.";
                dogrucevap = button2.Text;



            }
            if (sayac == 4)
            {

                label2.Text = "Aşağıdaki depolama birimleri hangi seçenekte büyükten küçüğe doğru \r\n şekilde sıralanmıştır ?";
                button1.Text = "KB > MB > GB > Byte > TB";
                button2.Text = "Byte > GB > TB > KB > MB";
                button3.Text = "GB > Byte > KB > TB > MB";
                button4.Text = "TB > GB > MB > KB > Byte";
                dogrucevap = button4.Text;


            }
            if (sayac == 5)
            {

                label2.Text = "Bilgisayarın elle tutulup gözle görülen kısmıdır.\r\nBilgisayarda bulunan fiziksel parçalardır.\r\nYukarıda verilen bilgiler aşağıdakilerden hangisinin açıklamasıdır ?";
                button1.Text = "Yazılım";
                button2.Text = "Bilişim Etiği";
                button3.Text = "Program";
                button4.Text = "Donanım";
                dogrucevap = button4.Text;


            }
            if (sayac == 6)
            {

                label2.Text = "'' Cem_Karaca-BuSonOlsun.mp3 '' Dosyasını aşağıdaki programlardan \r\n hangisi ile çalıştırabiliriz ?";
                button1.Text = "Ms Paint";
                button2.Text = "Microsoft Powerpoint";
                button3.Text = "Microsoft Word";
                button4.Text = "Media Player";
                dogrucevap = button4.Text;



            }
            if (sayac == 7)
            {

                label2.Text = "İki ya da daha fazla bilgisayarın birbirine bağlanmasıyla oluşan \r\n yapıya ne ad verilir ?";
                button1.Text = "Bilgisayar Ağı";
                button2.Text = "İnternet";
                button3.Text = "Bilgi Alışverişi";
                button4.Text = "İletişim";
                dogrucevap = button1.Text;



            }
            if (sayac == 8)
            {

                label2.Text = "Bir banka şube binasında kullanılan ağ türü aşağıdakilerden hangisidir ?";
                button1.Text = "NAN ( Olmayan Alan Ağı )";
                button2.Text = "MAN ( Metropol Alan Ağı )";
                button3.Text = "WAN ( Geniş Alan Ağı )";
                button4.Text = "LAN ( Yerel Alan Ağı )";
                dogrucevap = button4.Text;


            }
            if (sayac == 9)
            {

                label2.Text = "Bilgisayarda benzer dosyaları içinde sakladığımız birimlere \r\n ne ad verilir ?";
                button1.Text = "Dosya";
                button2.Text = "Uzantı";
                button3.Text = "Klasör";
                button4.Text = "Program";
                dogrucevap = button3.Text;



            }
            if (sayac == 10)
            {

                label2.Text = "1-Dolandırıcılık yapmak\r\n2-Başkalarının şifresini çalmak\r\n3-Tehdit etmek" +
                    "\r\n4-Lisanslı program kullanmak\r\nYukarıdakilerden hangisi bilişim suçu değildir ?";
                button1.Text = "1";
                button2.Text = "2";
                button3.Text = "3";
                button4.Text = "4";
                dogrucevap = button4.Text;



            }
            if (sayac == 11)
            {

                label2.Text = "Dosya ve klasörlerimizi aşağıdaki programlardan hangisi \r\n ile sıkıştırabiliriz ?";
                button1.Text = "Paint";
                button2.Text = "Winzip";
                button3.Text = "Chrome";
                button4.Text = "Media Player";
                dogrucevap = button2.Text;



            }
            if (sayac == 12)
            {

                label2.Text = "1-İşletim sistemi dosyalara erişimi sağlar.\r\n2-Tüm işletim sistemleri paralıdır.\r\n" +
                    "3-Bir cihaz sadece bir işletim sistemini destekler.\r\n4-Uygulama programları her işletim sistemine kurulabilir.\r\n" +
                    "Yukarıdakilerden hangisi doğrudur ?";
                button1.Text = "1";
                button2.Text = "2";
                button3.Text = "3";
                button4.Text = "4";
                dogrucevap = button1.Text;


            }
            if (sayac == 13)
            {

                label2.Text = ".pptx dosya uzantısı ne tür dosyadır ?";
                button1.Text = "Müzik dosyası";
                button2.Text = "Word dosyası";
                button3.Text = "PowerPoint dosyası";
                button4.Text = "e-kitap";
                dogrucevap = button3.Text;



            }
            if (sayac == 14)
            {

                label2.Text = "Aşağıda verilen internet sitelerinden hangisi yanlış\r\n yazılmıştır ?";
                button1.Text = "www.ilaydanurgülödevi.com";
                button2.Text = "www.facebook.com";
                button3.Text = "www.meb.gov.tr";
                button4.Text = "www.google.com";
                dogrucevap = button1.Text;



            }
            if (sayac == 15)
            {

                label2.Text = "Bir işlemi durdurmak veya iptal etmek için hangi tuş kullanılır ?";
                button1.Text = "Enter";
                button2.Text = "Backspace";
                button3.Text = "Escape";
                button4.Text = "NumLock";
                dogrucevap = button3.Text;



            }
            if (sayac == 16)
            {

                label2.Text = "Tüm kullanma haklarını ücret karşılında satın aldığımız yazılım\r\n hangisidir?";
                button1.Text = "Ücretsiz Yazılım";
                button2.Text = "Demo Yazılım";
                button3.Text = "Paylaşılan yazılım";
                button4.Text = "Lisanslı Yazılım";
                dogrucevap = button4.Text;


            }
            if (sayac == 17)
            {

                label2.Text = "Ortak bir özelliğe sahip dosyaları bir arada bulunduran birimlere ne ad \r\n verilir?";
                button1.Text = "Klasör";
                button2.Text = "Yazılım";
                button3.Text = "Dosya";
                button4.Text = "Bilişim";
                dogrucevap = button1.Text;


            }
            if (sayac == 18)
            {
                label2.Text = "Aşağıdaki dosyalardan hangisi bir resim dosyasıdır ?";
                button1.Text = "Manzara.zip";
                button2.Text = "Manzara.exe";
                button3.Text = "Manzara.mp3";
                button4.Text = "Manzara.jpg";
                dogrucevap = button4.Text;



            }
            if (sayac == 19)
            {

                label2.Text = "Herhangi bir bilgi veya düşünce ürününün kullanılması ve yayılması \r\n ile ilgili hakların, " +
                    "yasalarla belirli kişilere verilmesidir. Bu tanım aşağıdaki \r\n kavramlardan hangisine aittir?";
                button1.Text = "Dijital Yurttaşlık";
                button2.Text = "E-posta";
                button3.Text = "Telif Hakkı";
                button4.Text = "Bilişim Suçu";
                dogrucevap = button3.Text;


            }
            if (sayac == 20)
            {

                label2.Text = "Bulut depolama, internet üzerinde bize verilen bir alanda dosyalarımızı saklamamıza \r\n verilen isimdir." +
                    " Birçok şirket, kullanıcılara dosyalarını internet \r\n üzerinde depolayabilmesi için hizmet vermektedir." +
                    "Aşağıdakilerden hangisi \r\n bulut depolama hizmeti veren firmalardan birisi değildir?";
                button1.Text = "Yandex.Disk";
                button2.Text = "Google Drive";
                button3.Text = "DropBox";
                button4.Text = "WinRaR";
                dogrucevap = button4.Text;


            }

        }

        int saniye = 60;
        int dakika = 0;
       
        private void button5_Click(object sender, EventArgs e)
        {

            button5.Text = "Sonraki Soru";

            Random random = new Random();
            int rsoru = random.Next(1, 21);

            sayac = rsoru;

            
            double a;
            
                for (a = 1; a < 21; a++)
                {
                    label1.Text = "Soru " + a + ".";    //burdan dolayi hep soru 20 diyor

                } 


            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    item.Enabled = true;
                }
            }

            sorular();

            button6.Visible = false;

            timer1.Start();
            dakika = 1;



            button5.Text = "Sonraki Soru";


            {
                Random sorular = new Random();
                (sorular).Next(20);


            }



            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    item.Enabled = true;
                }

            }

            sorular();

            button6.Visible = false;

            timer1.Start();
            dakika = Convert.ToInt32(1);   //ISTEDIGIM SUREYI BURDAN AYARLIYORUM

        }



        private void DortButon(object sender, EventArgs e)
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    item.Enabled = false;
                }

            }

            if ((sender as Button).Text == dogrucevap)
            {
                dogru++;
            }
            else
            {
                yanlis++;
            }
            net = dogru - (yanlis / 3);
            puan = net * 5;
            label3.Text = "Dogru Sayisi= " + dogru;
            label4.Text = "Yanlis Sayisi= " + yanlis;
            label5.Text = "Net Sayisi= " + net.ToString("#.##");
            label6.Text = "Puan= " + puan.ToString("##");


            if (sayac == 20)
            {
                panel1.Visible = false;
                panel2.Visible = true;
                button5.Visible = false;
                button6.Visible = true;
                timer1.Stop();
                MessageBox.Show("Sınav Sona Erdi!");
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Text = "Online Sinav Ekrani";
            Text = "Online Sinav Ekrani";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            saniye = saniye - 1;
            label7.Text = saniye.ToString();
            label9.Text = (dakika - 1).ToString();
            if (saniye == 0)
            {
                dakika = dakika - 1;
                label9.Text = dakika.ToString();
                saniye = 60;

            }
            if (label9.Text == "-1")
            {
                timer1.Stop();
                label9.Text = "0";
                label7.Text = "0";
                this.BackColor = Color.LightSalmon;
                MessageBox.Show("Süreniz Bitti!");
                panel2.Visible = true;
                panel1.Visible = false;
                button5.Visible = false;
                panel3.Visible = false;
                button6.Visible = true;
            }

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 nesne = new Form2();
            nesne.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

            double a;

            for (a = 1; a < 21; a++)
            {
                label1.Text = "Soru " + a + ".";

            }
        }
    }
}

