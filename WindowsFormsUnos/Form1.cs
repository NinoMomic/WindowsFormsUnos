using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUnos
{
    public partial class Form1 : Form
    {
        List<Vozilo> voziloList = new List<Vozilo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxVozila_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            Vozilo vozilo = new Vozilo(txtBoxMarka.Text, txtBoxModel.Text, comboBoxVozila.Text);
            try
            {
                if (txtBoxMarka.Text == "" || txtBoxModel.Text == "" || comboBoxVozila.Text == "")
                {
                    MessageBox.Show("Pogrešan unos!","Pogrešan unos!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxMarka.Clear();
                    txtBoxModel.Clear();

                }
                else
                {
                    voziloList.Add(vozilo);
                    txtBoxMarka.Clear();
                    txtBoxModel.Clear();
                }
            }
            catch
            {
                txtBoxMarka.Clear();
                txtBoxModel.Clear();
            }
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            foreach(Vozilo v in voziloList)
            {
                txtBoxIspis.AppendText(v.ToString());
            }
        }

        private void btnObrada_Click(object sender, EventArgs e)
        {
            foreach(Vozilo v in voziloList)
            {
                if(v.Vrsta == "Avion")
                {
                    v.VoziPo = "Zraku";
                }
                else if(v.Vrsta == "Automobil")
                {
                    v.VoziPo = "Cesti";
                }
                else
                {
                    v.VoziPo = "Vodi";
                }
            }
        }
    }
    class Vozilo
    {
        string marka, model, vrsta, voziPo;

        public Vozilo(string marka, string model, string vrsta, string voziPo)
        {
            this.marka = marka;
            this.model = model;
            this.vrsta = vrsta;
            this.voziPo = voziPo;
        }

        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public string Vrsta { get => vrsta; set => vrsta = value; }
        public string VoziPo { get => voziPo; set => voziPo = value; }

        public override string ToString()
        {
            string ispis = "Marka: " + this.marka
                     + "\tModel: " + this.model
                     + "\tVrsta: " + this.vrsta
                     + "\tVozi po: " + this.voziPo;
            return ispis;
        }
    }
}
