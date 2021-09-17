/*
 * Created by SharpDevelop.
 * User: uJão
 * Date: 06/07/2021
 * Time: 11:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Atividade_2
{
	partial class FrmSecundario
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.PicFoto = new System.Windows.Forms.PictureBox();
			this.Btn1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.OfdJanela = new System.Windows.Forms.OpenFileDialog();
			this.TmrContador = new System.Windows.Forms.Timer(this.components);
			this.LblAtual = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.PicFoto)).BeginInit();
			this.SuspendLayout();
			// 
			// PicFoto
			// 
			this.PicFoto.Location = new System.Drawing.Point(109, 36);
			this.PicFoto.Name = "PicFoto";
			this.PicFoto.Size = new System.Drawing.Size(150, 150);
			this.PicFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PicFoto.TabIndex = 0;
			this.PicFoto.TabStop = false;
			// 
			// Btn1
			// 
			this.Btn1.Location = new System.Drawing.Point(109, 216);
			this.Btn1.Name = "Btn1";
			this.Btn1.Size = new System.Drawing.Size(150, 23);
			this.Btn1.TabIndex = 1;
			this.Btn1.Text = "Mudar Foto";
			this.Btn1.UseVisualStyleBackColor = true;
			this.Btn1.Click += new System.EventHandler(this.Btn1Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(109, 277);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Hora atual:";
			// 
			// OfdJanela
			// 
			this.OfdJanela.FileName = "OfdJanela";
			// 
			// TmrContador
			// 
			this.TmrContador.Enabled = true;
			this.TmrContador.Interval = 1000;
			this.TmrContador.Tick += new System.EventHandler(this.TmrContadorTick);
			// 
			// LblAtual
			// 
			this.LblAtual.Location = new System.Drawing.Point(185, 277);
			this.LblAtual.Name = "LblAtual";
			this.LblAtual.Size = new System.Drawing.Size(74, 22);
			this.LblAtual.TabIndex = 3;
			this.LblAtual.Text = "LblAtual";
			this.LblAtual.Click += new System.EventHandler(this.LblAtualClick);
			// 
			// FrmSecundario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 362);
			this.Controls.Add(this.LblAtual);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Btn1);
			this.Controls.Add(this.PicFoto);
			this.Name = "FrmSecundario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmSecundario";
			this.Load += new System.EventHandler(this.FrmSecundarioLoad);
			((System.ComponentModel.ISupportInitialize)(this.PicFoto)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label LblAtual;
		private System.Windows.Forms.Timer TmrContador;
		private System.Windows.Forms.OpenFileDialog OfdJanela;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Btn1;
		private System.Windows.Forms.PictureBox PicFoto;
	}
}
