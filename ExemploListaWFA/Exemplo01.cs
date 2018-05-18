using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploListaWFA
{
    public partial class Exemplo01 : Form
    {
        List<Int32> numeros = new List<Int32>();
        public Exemplo01()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                int numero = Convert.ToInt32(txtNumero.Text);
                numeros.Add(numero);
                cbSelecioneParaEditar.Items.Add(numero);
                txtNumero.Text = "";
                MessageBox.Show(
                    string.Format("Número {0} cadastrado com sucesso", numero));
                txtNumero.Focus(); 
            }
            catch
            {
                MessageBox.Show("Número não é um texto aceitável.");
            }
        }

        private void btProcessar_Click(object sender, EventArgs e)
        {
            rtNumeros.Clear();
            for (int i = 0; i < numeros.Count; i++)
            {
                rtNumeros.AppendText(numeros[i] + "\n");
            }
        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btCadastrar.PerformClick();
            }
        }

        private void txtPosicaoParaApagar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult dialogResulto = MessageBox.Show("Você realmente deseja apagar ?", "AVISO",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResulto == DialogResult.Yes)
                {
                    int posicao = Convert.ToInt32(txtPosicaoParaApagar.Text);
                    numeros.RemoveAt(posicao);
                    btProcessar.PerformClick();
                    txtPosicaoParaApagar.Text = "";
                    AtualizarComboBoxParaEditar();
                    MessageBox.Show("Registro apagado com sucesso");
                    txtNumero.Focus();
                }
                else
                {
                    MessageBox.Show("TAIX SALVO NEGO");
                }
            }
        }

        private void txtValorParaApagar_Leave(object sender, EventArgs e)
        {
            if (txtValorParaApagar.Text != "")
            {
                int valor = Convert.ToInt32(txtValorParaApagar.Text);
                while (numeros.Contains(valor))
                {
                    numeros.Remove(valor);
                }
                txtValorParaApagar.Text = "";
                AtualizarComboBoxParaEditar();
                MessageBox.Show(valor + " apagado com sucesso");
                btProcessar.PerformClick();
            }
        }

        private void AtualizarComboBoxParaEditar()
        {
            for (int i = 0; i < numeros.Count; i++)
            {
                cbSelecioneParaEditar.Items.Add(numeros[i]);
            }
        }

        private void cbSelecioneParaEditar_TextChanged(object sender, EventArgs e)
        {
            if (cbSelecioneParaEditar.SelectedIndex > -1)
            {
                txtNumeroEditar.Enabled = true;
                txtNumeroEditar.Focus();
            }
        }

        private void txtNumeroEditar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int posicao = Convert.ToInt32(cbSelecioneParaEditar.SelectedItem.ToString());
                int valorNovo = Convert.ToInt32(txtNumeroEditar.Text);

                numeros[posicao] = valorNovo;

                txtNumeroEditar.Text = "";
                txtNumeroEditar.Enabled = false;
                cbSelecioneParaEditar.SelectedIndex = -1;
                btProcessar.PerformClick();
                AtualizarComboBoxParaEditar();
                MessageBox.Show("Número alterado com sucesso !");
            }
        }
    }
}
