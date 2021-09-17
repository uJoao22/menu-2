using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_2
{
	public partial class FrmPrincipal : Form
	{
		public FrmPrincipal()
		{
			InitializeComponent();
		
		}
		
		void ChamarFormulárioToolStripMenuItemClick(object sender, EventArgs e)
		{
			FrmSecundario f1 = new FrmSecundario();
			f1.Show();
		}
		
		void SairToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("Deseja mesmo sair?","Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			Close();
		}
	}
}
