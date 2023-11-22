using System;
using System.IO;
using System.Windows.Forms;

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
            string caminho = "C:\\Users\\edilson.csilva10\\source\\repos\\Arquivoemtexto/Dados.txt";
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
            string caminho = "C:\\Users\\edilson.csilva10\\source\\repos\\Arquivoemtexto/Dados.txt";
            string texto = LerArquivo(caminho);
            Array lista = texto.Split('\n');

            foreach (string pessoa in lista)
            {
                string[] dados = pessoa.Split('|');

                //MessageBox.Show(dados[0]);

                cbxnome.Items.Add(dados[0]);

            }

        }
    }
}
