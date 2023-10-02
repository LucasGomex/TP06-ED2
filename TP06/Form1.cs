using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Lucas Gomes e Miguel Pataro

namespace TP06
{
    public partial class Form1 : Form
    {
        private Senhas senhas;
        private Guiches guiches;
        private int qtdGuiches = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView(dataGridView1);
            InitializeDataGridView(dataGridView2);
            this.senhas = new Senhas();
            this.guiches = new Guiches();
        }

        private void InitializeDataGridView(DataGridView dataGridView)
        {
            dataGridView.Columns.Add("senha", "Senha");
            dataGridView.RowHeadersVisible = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.senhas.gerar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (Senha senha in this.senhas.FilaSenhas)
            {
                dataGridView1.Rows.Add(senha.dadosParciais());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.guiches.adicionar(new Guiche(this.qtdGuiches));
            label2.Text = (++qtdGuiches).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            Guiche guiche = this.guiches.buscar(id);
            if (guiche != null)
            {
                guiche.chamar(this.senhas.FilaSenhas);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            foreach (Guiche guiche in this.guiches.ListaGuiches)
            {
                foreach (Senha senha in guiche.Atendimentos)
                {
                    dataGridView2.Rows.Add(senha.dadosCompletos());
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
