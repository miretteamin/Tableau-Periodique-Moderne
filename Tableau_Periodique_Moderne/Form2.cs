using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tableau_Periodique_Moderne
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int elNo;
        public Form2(int EN)
        {
            InitializeComponent();
            elNo = EN;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (elNo == 1)
            {
                this.BackColor = Color.Yellow;
                E_symbol.Text = "H";
                Nom.Text = "Hydrogene";
                Nombre_atomique.Text = "1";
                Masse_atomique.Text = "1";
                Nature.Text = "Non-Metal";
                Valence.Text = "1";
                Setrouve.Text = "Groupe : 1A \n Periode : 1\nCategorie : s";
                RE.Text = "K = 1";
            }
            else if (elNo == 2)
            {
                this.BackColor = Color.FromArgb(192, 255, 255);
                E_symbol.Text = "He";
                Nom.Text = "Helium";
                Nombre_atomique.Text = "2";
                Masse_atomique.Text = "4";
                Nature.Text = "Gaz Noble";
                Valence.Text = "0";
                Setrouve.Text = "Groupe : 0 \n Periode : 1\nCategorie : p";
                RE.Text = "K = 2";
            }
            else if (elNo == 3)
            {
                this.BackColor = Color.Salmon;
                E_symbol.Text = "Li";
                Nom.Text = "Lithium";
                Nombre_atomique.Text = "3";
                Masse_atomique.Text = "7";
                Nature.Text = "Metal";
                Valence.Text = "1";
                Setrouve.Text = "Groupe : 1A \n Periode : 2\nCategorie : s";
                RE.Text = "K = 2 \nL = 1";
            }
            else if (elNo == 4)
            {
                this.BackColor = Color.NavajoWhite;
                E_symbol.Text = "Be";
                Nom.Text = "Berillium";
                Nombre_atomique.Text = "4";
                Masse_atomique.Text = "9";
                Nature.Text = "Metal";
                Valence.Text = "2";
                Setrouve.Text = "Groupe : 2A \n Periode : 2\nCategorie : s";
                RE.Text = "K = 2 \nL = 2";
            }
            else if (elNo == 5)
            {
                this.BackColor = Color.FromArgb(218, 187, 131);
                E_symbol.Text = "B";
                Nom.Text = "Bore";
                Nombre_atomique.Text = "5";
                Masse_atomique.Text = "10.81";
                Nature.Text = "Metalloide";
                Valence.Text = "3";
                Setrouve.Text = "Groupe : 3A \n Periode : 2\nCategorie : p";
                RE.Text = "K = 2 \nL = 3";
            }
            else if (elNo == 6)
            {
                this.BackColor = Color.PaleGreen;
                E_symbol.Text = "C";
                Nom.Text = "Carbone";
                Nombre_atomique.Text = "6";
                Masse_atomique.Text = "12";
                Nature.Text = "Non Metal";
                Valence.Text = "4";
                Setrouve.Text = "Groupe : 4A \n Periode : 2\nCategorie : p";
                RE.Text = "K = 2 \nL = 4";
            }
            else if (elNo == 7)
            {
                this.BackColor = Color.PaleGreen;
                E_symbol.Text = "N";
                Nom.Text = "Nitrogene (Azote)";
                Nombre_atomique.Text = "7";
                Masse_atomique.Text = "14";
                Nature.Text = "Non Metal";
                Valence.Text = "3,5";
                Setrouve.Text = "Groupe : 5A \n Periode : 2\nCategorie : p";
                RE.Text = "K = 2 \nL = 5";
            }
            else if (elNo == 8)
            {
                this.BackColor = Color.PaleGreen;
                E_symbol.Text = "O";
                Nom.Text = "Oxygene";
                Nombre_atomique.Text = "8";
                Masse_atomique.Text = "16";
                Nature.Text = "Non Metal";
                Valence.Text = "2";
                Setrouve.Text = "Groupe : 6A \n Periode : 2\nCategorie : p";
                RE.Text = "K = 2 \nL = 6";
            }
            else if (elNo == 9)
            {
                this.BackColor = Color.FromArgb(255, 255, 128);
                E_symbol.Text = "F";
                Nom.Text = "Fluor";
                Nombre_atomique.Text = "9";
                Masse_atomique.Text = "19";
                Nature.Text = "Non Metal";
                Valence.Text = "1";
                Setrouve.Text = "Groupe : 7A \n Periode : 2\nCategorie : p";
                RE.Text = "K = 2 \nL = 7";
            }
            else if (elNo == 10)
            {
                this.BackColor = Color.FromArgb(192, 255, 255);
                E_symbol.Text = "Ne";
                Nom.Text = "Neon";
                Nombre_atomique.Text = "10";
                Masse_atomique.Text = "20";
                Nature.Text = "Gaz Noble";
                Valence.Text = "0";
                Setrouve.Text = "Groupe : 0 \n Periode : 2\nCategorie : p";
                RE.Text = "K = 2 \nL = 8";
            }
            else if (elNo == 11)
            {
                this.BackColor = Color.Salmon;
                E_symbol.Text = "Na";
                Nom.Text = "Sodium (Natrium)";
                Nombre_atomique.Text = "11";
                Masse_atomique.Text = "23";
                Nature.Text = "Metal";
                Valence.Text = "1";
                Setrouve.Text = "Groupe : 1A \n Periode : 3\nCategorie : s";
                RE.Text = "K = 2 \nL = 8\nM = 1";
            }
            else if (elNo == 12)
            {
                this.BackColor = Color.NavajoWhite;
                E_symbol.Text = "Mg";
                Nom.Text = "Magnesium";
                Nombre_atomique.Text = "12";
                Masse_atomique.Text = "24";
                Nature.Text = "Metal";
                Valence.Text = "2";
                Setrouve.Text = "Groupe : 2A \n Periode : 3\nCategorie : s";
                RE.Text = "K = 2 \nL = 8\nM = 2";
            }
            else if (elNo == 13)
            {
                this.BackColor = Color.FromArgb(203, 171, 252);
                E_symbol.Text = "Al";
                Nom.Text = "Alimunium";
                Nombre_atomique.Text = "13";
                Masse_atomique.Text = "27";
                Nature.Text = "Metal";
                Valence.Text = "3";
                Setrouve.Text = "Groupe : 3A \n Periode : 3\nCategorie : p";
                RE.Text = "K = 2 \nL = 8\nM = 3";
            }
            else if (elNo == 14)
            {
                this.BackColor = Color.FromArgb(218, 187, 131);
                E_symbol.Text = "Si";
                Nom.Text = "Silicium (Silicone)";
                Nombre_atomique.Text = "14";
                Masse_atomique.Text = "28";
                Nature.Text = "Metalloide";
                Valence.Text = "4";
                Setrouve.Text = "Groupe : 4A \n Periode : 3\nCategorie : p";
                RE.Text = "K = 2 \nL = 8\nM = 4";
            }
            else if (elNo == 15)
            {
                this.BackColor = Color.PaleGreen;
                E_symbol.Text = "P";
                Nom.Text = "Phosphore";
                Nombre_atomique.Text = "15";
                Masse_atomique.Text = "31";
                Nature.Text = "Non Metal";
                Valence.Text = "3,5";
                Setrouve.Text = "Groupe : 5A \n Periode : 3\nCategorie : p";
                RE.Text = "K = 2 \nL = 8\nM = 5";
            }
            else if (elNo == 16)
            {
                this.BackColor = Color.PaleGreen;
                E_symbol.Text = "S";
                Nom.Text = "Soufre";
                Nombre_atomique.Text = "16";
                Masse_atomique.Text = "32";
                Nature.Text = "Non Metal";
                Valence.Text = "2,4,6";
                Setrouve.Text = "Groupe : 6A \n Periode : 3\nCategorie : p";
                RE.Text = "K = 2 \nL = 8\nM = 6";
            }
            else if (elNo == 17)
            {
                this.BackColor = Color.FromArgb(255, 255, 128);
                E_symbol.Text = "Cl";
                Nom.Text = "Chlore";
                Nombre_atomique.Text = "17";
                Masse_atomique.Text = "35.5";
                Nature.Text = "Non Metal";
                Valence.Text = "1";
                Setrouve.Text = "Groupe : 7A \n Periode : 3\nCategorie : p";
                RE.Text = "K = 2 \nL = 8\nM = 7";
            }
            else if (elNo == 18)
            {
                this.BackColor = Color.FromArgb(192, 255, 255);
                E_symbol.Text = "Ar";
                Nom.Text = "Argon";
                Nombre_atomique.Text = "18";
                Masse_atomique.Text = "40";
                Nature.Text = "Gaz Noble";
                Valence.Text = "0";
                Setrouve.Text = "Groupe : 0 \n Periode : 3\nCategorie : p";
                RE.Text = "K = 2 \nL = 8\nM = 8";
            }
            else if (elNo == 19)
            {
                this.BackColor = Color.Salmon;
                E_symbol.Text = "K";
                Nom.Text = "Potassium (Katrium)";
                Nombre_atomique.Text = "19";
                Masse_atomique.Text = "39";
                Nature.Text = "Metal";
                Valence.Text = "1";
                Setrouve.Text = "Groupe : 1A \n Periode : 4\nCategorie : s";
                RE.Text = "K = 2 \nL = 8\nM = 8\nN = 1";
            }
            else if (elNo == 20)
            {
                this.BackColor = Color.NavajoWhite;
                E_symbol.Text = "Ca";
                Nom.Text = "Calcium";
                Nombre_atomique.Text = "20";
                Masse_atomique.Text = "40";
                Nature.Text = "Metal";
                Valence.Text = "2";
                Setrouve.Text = "Groupe : 2A \n Periode : 4\nCategorie : s";
                RE.Text = "K = 2 \nL = 8\nM = 8\nN = 2";
            }
            else if (elNo == 26)
            {
                this.BackColor = Color.Pink;
                E_symbol.Text = "Fe";
                Nom.Text = "Fer";
                Nombre_atomique.Text = "26";
                Masse_atomique.Text = "55.84";
                Nature.Text = "Metal";
                Valence.Text = "2,3";
                Setrouve.Text = "Groupe : 8 \n Periode : 4\nCategorie : d";
                RE.Text = "K = 2 \nL = 8\nM = 14\nN = 2";
            }
            else if (elNo == 29)
            {
                this.BackColor = Color.Pink;
                E_symbol.Text = "Cu";
                Nom.Text = "Cuivre";
                Nombre_atomique.Text = "29";
                Masse_atomique.Text = "63.55";
                Nature.Text = "Metal";
                Valence.Text = "1,2";
                Setrouve.Text = "Groupe : 1B \n Periode : 4\nCategorie : d";
                RE.Text = "K = 2 \nL = 8\nM = 18\nN = 1";
            }
            else if (elNo == 30)
            {
                this.BackColor = Color.Pink;
                E_symbol.Text = "Zn";
                Nom.Text = "Zinc";
                Nombre_atomique.Text = "30";
                Masse_atomique.Text = "65.39";
                Nature.Text = "Metal";
                Valence.Text = "2";
                Setrouve.Text = "Groupe : 2B \n Periode : 4\nCategorie : d";
                RE.Text = "K = 2 \nL = 8\nM = 18\nN = 2";
            }
            else if (elNo == 35)
            {
                this.BackColor = Color.FromArgb(255, 255, 128);
                E_symbol.Text = "Br";
                Nom.Text = "Brome";
                Nombre_atomique.Text = "35";
                Masse_atomique.Text = "80";
                Nature.Text = "Metal";
                Valence.Text = "1";
                Setrouve.Text = "Groupe : 7A \n Periode : 4\nCategorie : p";
                RE.Text = "K = 2 \nL = 8\nM = 18\nN = 7";
            }
            else if (elNo == 36)
            {
                this.BackColor = Color.FromArgb(192, 255, 255);
                E_symbol.Text = "Kr";
                Nom.Text = "Krypton";
                Nombre_atomique.Text = "36";
                Masse_atomique.Text = "83.8";
                Nature.Text = "Metal";
                Valence.Text = "0";
                Setrouve.Text = "Groupe : 0 \n Periode : 4\nCategorie : p";
                RE.Text = "K = 2 \nL = 8\nM = 18\nN = 8";
            }
            else if (elNo == 47)
            {
                this.BackColor = Color.Pink;
                E_symbol.Text = "Ag";
                Nom.Text = "Argent";
                Nombre_atomique.Text = "47";
                Masse_atomique.Text = "107.9";
                Nature.Text = "Metal";
                Valence.Text = "1,2";
                Setrouve.Text = "Groupe : 1B \n Periode : 5\nCategorie : d";
                RE.Text = "K = 2 \nL = 8\nM = 18\nN = 18\nO = 1";
            }
            else if (elNo == 79)
            {
                this.BackColor = Color.Pink;
                E_symbol.Text = "Au";
                Nom.Text = "Or";
                Nombre_atomique.Text = "79";
                Masse_atomique.Text = "197";
                Nature.Text = "Metal";
                Valence.Text = "3";
                Setrouve.Text = "Groupe : 1B \n Periode : 6\nCategorie : d";
                RE.Text = "K = 2 \nL = 8\nM = 18\nN = 32\nO = 18\nP = 1";
            }
            else if (elNo == 80)
            {
                this.BackColor = Color.Pink;
                E_symbol.Text = "Hg";
                Nom.Text = "Mercure";
                Nombre_atomique.Text = "80";
                Masse_atomique.Text = "200.6";
                Nature.Text = "Metal";
                Valence.Text = "1,2";
                Setrouve.Text = "Groupe : 2B \n Periode : 6\nCategorie : d";
                RE.Text = "K = 2 \nL = 8\nM = 18\nN = 32\nO = 18\nP = 2";
            }
            else if (elNo == 82)
            {
                this.BackColor = Color.FromArgb(203, 171, 252);
                E_symbol.Text = "Pb";
                Nom.Text = "Plomb";
                Nombre_atomique.Text = "82";
                Masse_atomique.Text = "207.2";
                Nature.Text = "Metal";
                Valence.Text = "2,4";
                Setrouve.Text = "Groupe : 4A \n Periode : 6\nCategorie : p";
                RE.Text = "K = 2 \nL = 8\nM = 18\nN = 32\nO = 18\nP = 4";
            }
            else if (elNo == 53)
            {
                this.BackColor = Color.FromArgb(255, 255, 128);
                E_symbol.Text = "I";
                Nom.Text = "Iode";
                Nombre_atomique.Text = "53";
                Masse_atomique.Text = "127";
                Nature.Text = "Non Metal";
                Valence.Text = "1";
                Setrouve.Text = "Groupe : 7A \n Periode : 5\nCategorie : p";
                RE.Text = "K = 2 \nL = 8\nM = 18\nN = 18\nO = 7";
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

    }
}
