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
        int redClick = 0;
        private void buttonRouge_Click(object sender, EventArgs e)
        {
            Topbox.BackColor = Color.Red;
            redClick++;
            NbRedClick.Text = "" + redClick;
        }
        
        // Bouton pour changement de couleur Vert et initialisation du compteur.
        int greenClick = 0;
        private void buttonVert_Click(object sender, EventArgs e)
        {
            Topbox.BackColor = Color.Green;
            greenClick++;
            NbGreenClick.Text = "" + greenClick;
        }
        
        // Bouton pour changement de couleur Bleu et initialisation du compteur.
        int blueClick = 0;
        private void buttonBleu_Click(object sender, EventArgs e)
        {
            Topbox.BackColor = Color.Blue;
            blueClick++;
            NbBlueClick.Text = "" + blueClick;
        }

        // Un clique dans la TopBox et retour à sa couleur initial.
        private void Topbox_MouseClick(object sender, MouseEventArgs e)
        {
            Topbox.BackColor = Color.White;
        }

        // Bouton de remise à 0 des 3 compteurs.
        private void reset_colors_buttons_Click(object sender, EventArgs e)
        {
             NbRedClick.Text = "0";
             redClick = 0;
             NbGreenClick.Text = "0";
             greenClick = 0;
             NbBlueClick.Text = "0";
             blueClick = 0;
        }
        
        // Bouton pour fermerture de l'application.
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
