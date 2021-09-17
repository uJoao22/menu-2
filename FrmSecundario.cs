using System;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_2
{
	public partial class FrmSecundario : Form
	{
		public FrmSecundario()
		{
			InitializeComponent();
			
		}
		
		void FrmSecundarioLoad(object sender, EventArgs e)
		{
			PicFoto.Image = Image.FromFile ("C:/Users/uJão/Desktop/Escola/Programção/C#/Fotos/imagens/Logo01.jpg");
		}
		
		void Btn1Click(object sender, EventArgs e)
		{
			try{
				OfdJanela.ShowDialog();
				PicFoto.Image = Image.FromFile(OfdJanela.FileName);
			}
			catch{
				MessageBox.Show("Nenhuma foto escolhida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void TmrContadorTick(object sender, EventArgs e)
		{
			LblAtual.Text = DateTime.Now.ToLongTimeString();
		}
		
		void LblAtualClick(object sender, EventArgs e)
		{
			
		}
	}
}
