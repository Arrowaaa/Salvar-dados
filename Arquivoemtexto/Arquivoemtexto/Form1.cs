using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Arquivoemtexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
    
        }
        string LerArquivo(string endereco)
        {
            string conteudo = "";
            if (File.Exists(endereco))
            {
                using (StreamReader sr = new StreamReader(endereco))
                {
                    conteudo = sr.ReadToEnd();
                }
            }
            return conteudo;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string texto = txbInput.Text;
            string telefone = txbTelefone.Text;
            string Email = txbEmail.Text;

            if (rbtelefone.Checked)
            {
                telefone = "-";
            }
            else if (rbemail.Checked)
            {
                Email = "-";
            }

            string juncao = texto + " | " + telefone + " | " + Email;
            string caminho = "C:\\Users\\mad_f\\source\\repos\\Salvar-dados\\Arquivoemtexto.txt";
            string textoAntigo = LerArquivo(caminho);

            using(StreamWriter sw = new StreamWriter(caminho))
            {
                sw.WriteLine(textoAntigo + juncao);
            }
            MessageBox.Show("Arquivo Criado com Sucesso! ");
        }

        private void btnler_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string caminho = "C:\\Users\\mad_f\\source\\repos\\Salvar-dados\\Arquivoemtexto.txt";
            string texto = LerArquivo(caminho);
            Array lista = texto.Split('\n');

            foreach (string pessoa in lista)
            {
                string[] dados = pessoa.Split('|');

                //MessageBox.Show(dados[0]);

                cbxnome.Items.Add(dados[0]);

            }

        }

        private void cbxnome_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cbxnome.SelectedItem.ToString();
            string caminho = "C:\\Users\\mad_f\\source\\repos\\Salvar-dados\\Arquivoemtexto.txt";
            string texto = LerArquivo(caminho);
            string[] lista = texto.Split('\n');

            foreach (string pessoa in lista)
            {
                string[] dados = pessoa.Split('|');


                if (selectedItem == dados[0].Trim())
                {
               
                    label5.Text = dados[0].Trim();
                    label7.Text = dados[1].Trim();
                    label9.Text = dados[2].Trim();


                    return;
                }
            }
        }
    }
    
}
