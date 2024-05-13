using System;
using System.Windows.Forms;

namespace ProjetoWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //string texto = "mensagem do botao";
        minhabiblioteca.MinhaClasse minhaClasse = new minhabiblioteca.MinhaClasse();  
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(minhaClasse.texto);
        }
    }
}


// classe basica inicial
namespace minhabiblioteca
{
    public class MinhaClasse
    {
        public string texto = "mensagem botão 2";
    }
}