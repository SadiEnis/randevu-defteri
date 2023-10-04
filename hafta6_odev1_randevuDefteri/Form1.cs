using System;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace hafta6_odev1_randevuDefteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.Controls.Add(bttn_kaydet);
            //bttn_kaydet.MouseEnter += new EventHandler(bttn_kaydet_MouseEnter);
            //bttn_kaydet.MouseLeave += new EventHandler(bttn_kaydet_MouseLeave);
            InitializeComponent();
            lbl_randevuTarihi.Text = "Randevu Tarihi (örnek: " + DateTime.Now.Day.ToString() + ".0" + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString() + ")";
            // Kullanıcıya örnek tarih verdim ki yanlış input yapıp kayıtta o günün dolu olup olmadığı hakkında yanılmasın. 

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void bttn_kaydet_Click(object sender, EventArgs e)
        {
            string kayit = txt_randevuTarihi.Text + " - " + txt_isimSoyisim.Text + " " + txt_TC.Text;
            string path = "kayit.txt";
            bool sorgu = true;

            using (StreamReader sr = new StreamReader(path))
            {
                string row;
                while ((row = sr.ReadLine()) != null)
                {
                    if (row.Contains(txt_randevuTarihi.Text))
                        sorgu = false;
                    else
                        sorgu = true;
                }
            }

            if (sorgu)
            {
                if (!File.Exists(path))
                {
                    FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                    using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                    {
                        sw.WriteLine(kayit);
                    }
                }
                else
                {
                    FileStream fs = new FileStream(path, FileMode.Append);
                    using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                    {
                        sw.WriteLine(kayit);
                    }
                    txt_isimSoyisim.Text = string.Empty;
                    txt_TC.Text = string.Empty;
                    txt_randevuTarihi.Text = string.Empty;
                    lbl_tamam.Text = "Kaydedildi.";
                    lbl_sorgu.Text = "Müsait.";
                }
            }
            else lbl_sorgu.Text = "Müsait değil.";
        }
        private void bttn_refresh_Click(object sender, EventArgs e)
        {
            string path = "kayit.txt";
            Kayıtlar.Items.Clear();
            int i = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.Peek() > 0)
                {
                    i++;
                    string line = sr.ReadLine();
                    Kayıtlar.Items.Add(i + ".Randevu " + line);
                }
            }
        }
        private void bttn_sorgu_Click(object sender, EventArgs e)
        {
            string path = "kayit.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                string row;
                while ((row = sr.ReadLine()) != null)
                {
                    if (row.Contains(txt_randevuTarihi.Text))
                        lbl_sorgu.Text = "Müsait değil.";
                    else
                        lbl_sorgu.Text = "Müsait.";
                }
            }
        }

        #region imleç değiştirmeyi kodda denemeye çalışmıştım.
        private void bttn_kaydet_MouseEnter(object sender, EventArgs e)
        {
            bttn_kaydet.MouseEnter += new EventHandler(bttn_kaydet_MouseEnter);
            Cursor.Current = Cursors.Hand;
        }
        private void bttn_kaydet_MouseLeave(object sender, EventArgs e)
        {
            bttn_kaydet.MouseLeave += new EventHandler(bttn_kaydet_MouseLeave);
            Cursor.Current = Cursors.Default;
        }
        #endregion
    }
}
