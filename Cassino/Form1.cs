using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cassino
{
    public partial class Form1 : Form
    {
        int[] roleta;
        int[] tempos;
        Label[] tela;
        Random r;
        List<string> todasJogadas = new List<string>();

        public Form1()
        {
            InitializeComponent();
            roleta = new int[3];
            tempos = new int[3];
            tela = new Label[] { lbl1, lbl2, lbl3 };
            r = new Random();

            for (int i = 0; i < roleta.Length; i++)
            {
                roleta[i] = r.Next(0, 10);
                Atualizar(i);
            }
        }

        void Atualizar(int indice)
        {
            tela[indice].Text = roleta[indice].ToString();
        }

        private void btGirar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tempos.Length; i++)
            {
                tempos[i] = r.Next(1, 21);
                tela[i].ForeColor = Color.Black;
            }

            Array.Sort(tempos);
            btGirar.Enabled = false;
            tmrGiro.Enabled = true;
        }

        private void tmrGiro_Tick(object sender, EventArgs e)
        {
            bool parado = true;

            for (int i = 0; i < tempos.Length; i++)
            {
                if (tempos[i] > 0)
                {
                    tempos[i]--;
                    if (tempos[i] == 0)
                    {
                        tela[i].ForeColor = Color.Red;
                    }

                    roleta[i]++;
                    if (roleta[i] == 10)
                    {
                        roleta[i] = 0;
                    }

                    Atualizar(i);
                    parado = false;
                }
            }

            if (parado)
            {
                btGirar.Enabled = true;
                tmrGiro.Enabled = false;

                string resultado = $"{roleta[0]},{roleta[1]},{roleta[2]}";
                todasJogadas.Add(resultado);

                bool vitoria = (roleta[0] == roleta[1] && roleta[1] == roleta[2]);

                if (!chbVitorias.Checked || vitoria)
                {
                    lxUltimos.Items.Add(resultado);
                }

                if (vitoria)
                {
                    MessageBox.Show("Você ganhou!");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Você abriu o cassino");
        }

        private void chbVitorias_CheckedChanged(object sender, EventArgs e)
        {
            lxUltimos.Items.Clear();

            foreach (string item in todasJogadas)
            {
                string[] nums = item.Split(',');

                if (nums.Length == 3 && (!chbVitorias.Checked || (nums[0] == nums[1] && nums[1] == nums[2])))
                {
                    lxUltimos.Items.Add(item);
                }
            }
        }
    }
}
