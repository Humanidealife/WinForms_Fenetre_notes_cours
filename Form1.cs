using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Fenetre_notes_cours
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Déclancher lors du chargement de la fenêtre
        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Bienvenue au programme !");
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vous avez cliqué sur la feêntre !");
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            MessageBox.Show("Fin du redimentionnement de la fenêtre !");
        }
    }
}
