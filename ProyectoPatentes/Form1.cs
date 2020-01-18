using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPatentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            string rutaDirectorio = string.Empty;

            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                rutaDirectorio = fbd.SelectedPath;
            }
            DirectoryInfo di = new DirectoryInfo(@rutaDirectorio);




            foreach (var item in di.GetFiles())
            {

                lvArchivos.Items.Add(item.Name);
                lvArchivos.Items.Add(item.LastWriteTime.ToString(), 1);
                

            }
        }
    }
}
