using System;
using System.Drawing;
using System.Windows.Forms;

namespace EsercizioVisuale
{
    public partial class Visual : Form
    {
        Immagine immagini=new Immagine();
        private System.Windows.Forms.Button BtnClose;
        Point xy = new Point();
        Random Coord = new Random();
        int moscasKilled=0;
        string tipoImg = "";
        public Visual()
        {
            InitializeComponent();

        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Visual_FormClosing(object sender, FormClosingEventArgs e)
        {//finestra di dialogo
            //componente visualizzabile non presente nella palette
            if (MessageBox.Show("Vuoi chiudere il form", "Avviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            uccisioni_Click(sender, e);
            xy.X = Coord.Next(0, (ClientSize.Width) - pictureBox1.Width - 1);
            xy.Y = Coord.Next(0, (ClientSize.Height) - pictureBox1.Height - 1);
            pictureBox1.Location = xy;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            moscasKilled++;
            if (tipoImg == "farfalla")
            {
                pictureBox1.BackgroundImage = Image.FromFile(immagini.FarfallaX);
                MessageBox.Show(tipoImg + " schiacciata", "Congratulazioni", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                pictureBox1.BackgroundImage = Image.FromFile(immagini.Farfalla);
            }
            else if (tipoImg == "ape")
            {
                pictureBox1.BackgroundImage = Image.FromFile(immagini.ApeX);
                MessageBox.Show(tipoImg + " schiacciata", "Congratulazioni", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                pictureBox1.BackgroundImage = Image.FromFile(immagini.Ape);
            }
            else if (tipoImg == "ragno")
            {
                pictureBox1.BackgroundImage = Image.FromFile(immagini.RagnoX);
                MessageBox.Show(tipoImg + " schiacciata", "Congratulazioni", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                pictureBox1.BackgroundImage = Image.FromFile(immagini.Ragno);
            }
            else
            {
                pictureBox1.BackgroundImage = Image.FromFile(immagini.MoscaX);
                MessageBox.Show(tipoImg + " schiacciata", "Congratulazioni", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                pictureBox1.BackgroundImage = Image.FromFile(immagini.Mosca);

            }
            timer1.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uccisioni_Click(object sender, EventArgs e)
        {
            uccisioni.Text = "Uccisioni:"+moscasKilled;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile(immagini.Mosca);
            tipoImg = "mosca";
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tipoImg = "farfalla";
            pictureBox1.BackgroundImage = Image.FromFile(immagini.Farfalla);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tipoImg = "ragno";
            pictureBox1.BackgroundImage = Image.FromFile(immagini.Ragno);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            tipoImg = "ape";
            pictureBox1.BackgroundImage = Image.FromFile(immagini.Ape);
        }

        private void Visual_Load(object sender, EventArgs e)
        {

        }

        private void BottoneProva_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            MessageBox.Show("Insetto Creato");
        }
    }
}
