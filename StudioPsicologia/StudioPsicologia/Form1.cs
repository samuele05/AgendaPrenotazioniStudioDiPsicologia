using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace StudioPsicologia
{
    public partial class Form1 : Form
    {
        // Angoli arrotondati
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        // Sposta Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public static Form1 instance;
        public Form1()
        {
            instance = this;
            InitializeComponent();
        }













        private void Form1_Load(object sender, EventArgs e)
        {
            // bottoni
            btnAggiungiPaziente.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAggiungiPaziente.Width, btnAggiungiPaziente.Height, 10, 10));
            btnAggiungiMedico.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAggiungiMedico.Width, btnAggiungiMedico.Height, 10, 10));
            btnRimuoviMedico.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnRimuoviMedico.Width, btnRimuoviMedico.Height, 10, 10));
        }





        private void btnAggiungiPaziente_Click(object sender, EventArgs e)
        {
            AggiuntaPaziente aggiuntaPaziente = new AggiuntaPaziente();
            aggiuntaPaziente.ShowDialog();
        }

        private void btnAggiungiMedico_Click(object sender, EventArgs e)
        {
            AggiuntaMedico aggiuntaMedico = new AggiuntaMedico();
            aggiuntaMedico.ShowDialog();
        }

        private void btnRimuoviMedico_Click(object sender, EventArgs e)
        {
            RimuoviMedico rimuoviMedico = new RimuoviMedico();
            rimuoviMedico.ShowDialog(); 
        }
    }
}
