using EpsonConnector.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpsonConnector
{
    public partial class SettingsForm : Form
    {
        MyAppContext context;

        public SettingsForm(MyAppContext context)
        {
            InitializeComponent();
            this.context = context;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            var printers = context.printer.GetPrinters();
            foreach (var ptr in printers)
                yaziciAdi.Items.Add(ptr);
            if (!string.IsNullOrEmpty(Settings.Default.PrinterName))
                yaziciAdi.SelectedItem = Settings.Default.PrinterName;

            sunucuIp.Text = Settings.Default.SunucuIp;
            musteriAdi.Text = Settings.Default.MusteriAdi;
            kullaniciAdi.Text = Settings.Default.KullaniciAdi;
            sifre.Text = Settings.Default.Sifre;
            sablonPath.Text = Settings.Default.SablonPath;
            editorPath.Text = Settings.Default.EditorLocation;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (yaziciAdi.SelectedItem != null)
                Settings.Default.PrinterName = yaziciAdi.SelectedItem.ToString();
            else
                Settings.Default.PrinterName = "";
            Settings.Default.SunucuIp = sunucuIp.Text;
            Settings.Default.MusteriAdi = musteriAdi.Text;
            Settings.Default.KullaniciAdi = kullaniciAdi.Text;
            Settings.Default.Sifre = sifre.Text;
            Settings.Default.SablonPath = sablonPath.Text;
            Settings.Default.EditorLocation = editorPath.Text;
            Settings.Default.Save();
            context.trayIcon.ShowBalloonTip(3000, "Yazıcı Ayarları", "Ayarlar kaydedildi", ToolTipIcon.Info);
            context.Initialize();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sablonPath.Text = openFileDialog1.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                editorPath.Text = openFileDialog2.FileName;
            }
        }
    }
}
