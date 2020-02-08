using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace harjoitustyö
{
    public partial class Form1 : Form
    {
        int väriswitch = 1; //  vaalea / tumma moodin säätelyyn
        int tila; // haku, rgx haku, korvaus jne napin säätelyyn

        public void Tallenna()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text File|*.txt";
            saveFile.Title = "Tallenna tiedosto";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFile.OpenFile());
                sw.WriteLine(richTextBox_main.Text);
                sw.Dispose();
                sw.Close();
            }
        }
        public void Tyhjennä() // palauttaa valinnan taustavärin ja deselectaa
        {
            if (väriswitch == 1)
            {
                richTextBox_main.SelectionBackColor = Color.White;
            }
            else
            {
                richTextBox_main.SelectionBackColor = Color.FromArgb(153, 170, 181);
            }
            richTextBox_main.DeselectAll();
        }

        public Form1()
        {
            InitializeComponent();

        }


        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tallenna();
        }

        private void suljeToolStripMenuItem_Click(object sender, EventArgs e) // sulje ohjelma, jos tekstiä kirjotettuna kysy ensin
        {
            if (richTextBox_main.Text.Length != 0)
            {
                DialogResult d = MessageBox.Show("Suljetaanko varmasti?", "Lopeta?", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void hakuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_haku.Visible = true;
            button_haku.Text = "Haku";
            textBox_haku.Visible = true;
            tila = 0;

        }

        private void button_haku_Click(object sender, EventArgs e)
        {

            Tyhjennä();
            string txt = richTextBox_main.Text;
            string txt_input = textBox_haku.Text;
            switch (tila)
            {
                case 0: // Haku

                    txt_input = Regex.Escape(txt_input);
                    if (Regex.IsMatch(txt, txt_input))
                    {
                        int alku = txt.IndexOf(txt_input);

                        richTextBox_main.SelectionStart = alku;
                        richTextBox_main.SelectionLength = txt_input.Length;
                        richTextBox_main.SelectionBackColor = Color.LightBlue;
                        button_kumi.Visible = true;
                        button_kopio.Visible = true;
                    }
                    else
                    {
                        label_matsit.Text = "0 tulosta";
                    }
                    break;
                case 1: // Regex haku
                    Valinnat.valinta = 0; // mones haku tulos valittuna
                    try
                    {
                        Regex r = new Regex(@txt_input);
                        var tulos = r.Matches(txt).Cast<Match>().Select(m => m.Value).ToArray(); // tulokset arrayhyn
                        var indeksit = r.Matches(txt).Cast<Match>().Select(m => m.Index).ToArray(); // tulosten indexit arrayhyn
                        label_matsit.Text = (tulos.Length == 1 ? tulos.Length + " tulos" : tulos.Length + " tulosta"); // Tulosten määrä labeliin

                        if (tulos.Length != 0)
                        {
                            richTextBox_main.SelectionStart = indeksit[Valinnat.valinta];
                            richTextBox_main.SelectionLength = tulos[Valinnat.valinta].Length;
                            richTextBox_main.SelectionBackColor = Color.LightBlue;
                            button_kumi.Visible = true;
                            button_kopio.Visible = true;
                            Valinnat.tulokset = tulos;
                            Valinnat.indeksit = indeksit;

                        }
                        if (tulos.Length < 2)
                        {
                            button_seuraava.Enabled = false;
                            button_takaisin.Enabled = false;
                        }
                        else
                        {
                            button_seuraava.Enabled = true;
                            button_takaisin.Enabled = true;
                        }

                        label_matsit.Visible = true;
                    }
                    catch
                    {

                    }
                    break;
                
            }
        }
        ToolTip ToolTip_ = new ToolTip();
        
        private void button_kumi_MouseHover(object sender, EventArgs e)
        {
            ToolTip_.SetToolTip(button_kumi, "peruuta valinta");
        }

        private void button_kumi_Click(object sender, EventArgs e)
        {
            Tyhjennä();
            Valinnat.valinta = 0;
        }

        private void button_kopio_MouseHover(object sender, EventArgs e)
        {
            ToolTip_.SetToolTip(button_kopio,"kopioi valinta leikepöydälle");
        }

        private void button_kopio_Click(object sender, EventArgs e)
        {
            richTextBox_main.Copy();
        }

        private void toolStripButton_väri_Click(object sender, EventArgs e) //  vaalea / tumma tila
        {
            if (väriswitch%2==1)
            {
                this.BackColor = Color.FromArgb(44, 47, 51);
                richTextBox_main.BackColor = Color.FromArgb(153, 170, 181);
                väriswitch += 1;
                toolStripButton_väri.ToolTipText = "Valkea moodi";
                richTextBox_main.SelectAll(); 
                richTextBox_main.SelectionBackColor = Color.FromArgb(153, 170, 181);
                richTextBox_main.DeselectAll();
                toolStripButton_väri.Image = harjoitustyö.Properties.Resources.kuu;
            }
            else
            {
                
                
                this.BackColor = Color.White;
                richTextBox_main.BackColor = Color.White;
                väriswitch -= 1;
                toolStripButton_väri.ToolTipText = "Tumma moodi";
                richTextBox_main.SelectAll();
                richTextBox_main.SelectionBackColor = Color.White;
                richTextBox_main.DeselectAll();
                toolStripButton_väri.Image = harjoitustyö.Properties.Resources.aurinko;
                
            }
        }

        private void regexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_haku.Visible = true;
            button_haku.Text = "Haku(rgx)";
            textBox_haku.Visible = true;
            tila = 1;
            button_seuraava.Visible = true;
            button_takaisin.Visible = true;
        }

        private void avaaToolStripMenuItem_Click(object sender, EventArgs e) // openfiledialogilla tiedosto polku ja haetaan teksti
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text File|*.txt";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string of = openFile.FileName;
                
                using (StreamReader sr = new StreamReader(of))
                {
                    richTextBox_main.Text = sr.ReadToEnd();

                }
            }
        }

        private void button_seuraava_Click(object sender, EventArgs e) // siirry seuravaan haun tulokseen
        {
            
            try { 
            if (Valinnat.valinta != Valinnat.tulokset.Length-1)
            {
                Tyhjennä();
                Valinnat.valinta++;
                richTextBox_main.SelectionStart = Valinnat.indeksit[Valinnat.valinta];
                richTextBox_main.SelectionLength = Valinnat.tulokset[Valinnat.valinta].Length;
                richTextBox_main.SelectionBackColor = Color.LightBlue;
            }
            }
            catch
            {

            }

        }

        private void button_takaisin_Click(object sender, EventArgs e) // palaa aiempaan haun tulokseen
        {
            if (Valinnat.valinta != 0)
            {
                Tyhjennä();
                Valinnat.valinta--;
                richTextBox_main.SelectionStart = Valinnat.indeksit[Valinnat.valinta];
                richTextBox_main.SelectionLength = Valinnat.tulokset[Valinnat.valinta].Length;
                richTextBox_main.SelectionBackColor = Color.LightBlue;
            }
            
        }

        private void toolStripButton_debug_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://regex101.com/");
        }
    }
}
