using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakeDataOlusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Classlar.FakeDataOlusturma> kayıtlar = new List<Classlar.FakeDataOlusturma>();


        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classlar.FakeDataOlusturma fakeData = new Classlar.FakeDataOlusturma();
            dataGridView1.DataSource = fakeData.KarmalariGetir(100);
        }
    }
}
