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

namespace Codice_Fiscale
{
    public partial class Form1 : Form
    {
        public const string pathFolder = "C:\\Users\\UTENTE";
        public const string path = "ElencoComuni.csv";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var listaComuni = new List<Comune>();
            var allLines = File.ReadAllLines(Path.Combine(pathFolder, path));
            foreach (var line in allLines)
            {
                var split = line.Split(',');
                listaComuni.Add(new Comune(split[0], (split[1])));
            }
            comboBox_comune_nascita.DisplayMember = "Nome";
            comboBox_comune_nascita.DataSource = listaComuni;
        }

        private void btn_calcola_Click(object sender, EventArgs e)
        {
            var nome = tbx_nome.Text;
            var cognome = txb_cognome.Text;
            var dataNascita = dateTimePicker1.Value;
            var sesso = rbtn_maschio.Checked ? "F" : "M";
            var comune = (Comune)comboBox_comune_nascita.SelectedItem;

            var calcolo = new Tecnosoftware.CodiceFiscale.CodiceFiscale(nome, cognome, dataNascita, comune.Codice, sesso);
            MessageBox.Show(calcolo.estraiCF());

            using (var sw = new StreamWriter("C:\\Users\\UTENTE\\CodiceFiscale.csv", true))
            {
                sw.WriteLine(calcolo.estraiCF());

            }
        }
    }
}
