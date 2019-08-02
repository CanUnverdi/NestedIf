using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NestedIf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*Şartlar:
         1.Normal: İndirim Yok - 5Tl
         2.Öğrenci: %50 indirim- Yaşı 30'dan büyükse indirim yok. 2.5TL
         3.Öğretmen: %30 indirim- Yaşı 20'den küçükse indirim yok. 3.5TL
         4.Asker: %50 indiirm - Yaşı 20'den küçğkse ve 65'den büüykse indirm yok. 2.5 TL
         5.ENgelli: %75 indirm - 1.25TL
         6.Yaşlı: %25 indirm yaşı 60'tan küçükse indirim yok 3.75 tl
         /Ücret hesaplayınız.Eğer seçim yapmamışsa hata mesajı gösteriniz
             */

        //cmbDurum.SelectedIndex == -1 gelirse hiçbir değer seçilmmiş demektir
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int yas = int.Parse(txtYas.Text);

            if (cmbDurum.SelectedIndex ==-1)
            {
                lblUcret.Text = "Seçim Yapmadınız!";
            }
            else if (cmbDurum.SelectedIndex==0)
            {
                lblUcret.Text = "5TL";
            }
            else if (cmbDurum.SelectedIndex==1)
            {
                if (yas <30)
                {
                    lblUcret.Text = "2.5TL";
                }
                else
                {
                    lblUcret.Text = "5TL";
                }
            }
            else if (cmbDurum.SelectedIndex==2)
            {
                if (yas <20)
                {
                    lblUcret.Text = "5TL";
                }
                else
                {
                    lblUcret.Text = "3.5TL";
                }
            }
            else if (cmbDurum.SelectedIndex == 3)
            {
                if (yas <20 && yas>65)
                {
                    lblUcret.Text = "5TL";
                }
                else
                {
                    lblUcret.Text = "2.5TL";
                }
            }
            else if (cmbDurum.SelectedIndex == 4)
            {
                if (yas <60)
                {
                    lblUcret.Text = "5TL";
                }
                else
                {
                    lblUcret.Text = "3.75TL";
                }
            }
            else if (cmbDurum.SelectedIndex == 5)
            {
                if (yas <60)
                {
                    lblUcret.Text = "5TL";
                }
                else
                {
                    lblUcret.Text = "3.75";
                }
            }
        }

        private void cmbDurum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
