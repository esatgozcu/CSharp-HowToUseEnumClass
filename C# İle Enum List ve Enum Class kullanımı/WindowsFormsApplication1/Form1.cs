//www.esatgozcu.com
//05.11.2017

using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public enum aylar
        {
            Ocak,
            Şubat,
            Mart,
            Nisan,
            Mayıs,
            Haziran,
            Temmuz,
            Ağustos,
            Eylül,
            Ekim,
            Kasım,
            Aralık           
        }

        //Verileri çekme için birinci yol
        private void button1_Click(object sender, EventArgs e)
        {
            byte i = Convert.ToByte(textBox1.Text);        
            i--;  //i-- dememizin sebebi enum içerisindeki elemanlar 0 numarasından başlar
            aylar ayAdı;          
            ayAdı = (aylar)i;
            MessageBox.Show(ayAdı.ToString());
        }

        //İkinci Yol
        private void button2_Click(object sender, EventArgs e)
        {
            //-1 dememizin sebebi enum içerisindeki elemanlar 0 numarasından başlar
            string ay = Enum.GetName(typeof(aylar),Convert.ToInt32(textBox2.Text)-1);
            MessageBox.Show(ay);
        }

        //İsimden sayı değerini çekme
        private void button3_Click(object sender, EventArgs e)
        {
            int personelValue = (int)Enum.Parse(typeof(aylar),textBox3.Text.ToString());
            //+1 dememizin sebebi enum içerisindeki elemanlar 0 numarasından başlar
            personelValue++;
            MessageBox.Show(personelValue.ToString());
        }

        //Enumdaki bütün verileri çekmek için
        private void button4_Click(object sender, EventArgs e)
        {
            var enumList = Enum.GetNames(typeof(aylar));

            foreach (var item in enumList)
            {
                MessageBox.Show(item);
            }
        }
    }
}
