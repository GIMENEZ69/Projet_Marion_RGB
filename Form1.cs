/**
 * Titre : Changement de couleur + compteur de " Clique " et réinitialisation des compteurs.
 * By : GIMENEZ Robert
 * Date : 17/07/2021
 **/
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RGB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Bouton pour changement de couleur Rouge et initialisation du compteur.
        int cliqueR = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.BackColor = Color.Red;
            cliqueR++;
            nbclickRouge.Text = ""+ cliqueR;
        }
        
        // Bouton pour changement de couleur Vert et initialisation du compteur.
        int cliqueV = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.BackColor = Color.Green;
            cliqueV++;
            nbclickVert.Text = "" + cliqueV;
        }
        
        // Bouton pour changement de couleur Bleu et initialisation du compteur.
        int cliqueB = 0;
        private void buttonBleu_Click(object sender, EventArgs e)
        {
            listBox1.BackColor = Color.Blue;
            cliqueB++;
            nbclickBleu.Text = "" + cliqueB;
        }

        // Un clique dans la listBox et retour à sa couleur initial.
        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            listBox1.BackColor = Color.White;
        }

        // Bouton de remise à 0 des 3 compteurs.
        private void button2_Click_1(object sender, EventArgs e)
        {
             nbclickRouge.Text = "0";
             cliqueR = 0;
             nbclickVert.Text = "0";
             cliqueV = 0;
             nbclickBleu.Text = "0";
             cliqueB = 0;
        }
        
        // Bouton pour fermerture de l'application.
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
