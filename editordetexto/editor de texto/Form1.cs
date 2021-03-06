using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace editor_de_texto
{   
    public partial class Form1 : Form
    {
 
        
        public Form1()

        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void imprimirToolStripButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void copiarToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Title = "Abrir archivo";
            dialogo.InitialDirectory = @"C:\Users\Alumno\Desktop\EDITOR";
            dialogo.Filter = "*TXT files (*.txt)|*.txt|*RTF files|*.rtf|All files (*.*)|*.*";
            //dialogo.ShowDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DialogResult r = MessageBox.Show(this, "Esta seguro que quiere guardar?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "*txt files (*.txt)|*RTF files|*.rtf|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Guardar archivo";
            saveFileDialog1.InitialDirectory = @"C:\Users\Alumno\Desktop\EDITOR";
            var resultado = saveFileDialog1.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                StreamWriter escribir = new StreamWriter(saveFileDialog1.FileName);
                foreach (object line in richTextBox1.Lines)
                {
                    escribir.WriteLine(line);
                }
                escribir.Close();
            }
            /*if (r == DialogResult.Yes)
            {
                MessageBox.Show("Guardado con exito");
            }
            */
        }

        private void fuentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1 = new FontDialog();
            fontDialog1.ShowColor = true;

            /*fontDialog1.Font = RichTextBoxStreamType.Font;
            fontDialog1.Color = RichTextBoxStreamType.ForeColor;
            */fontDialog1.ShowDialog();

            /*if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                RichTextBoxStreamType.Font = fontDialog1.Font;
                RichTextBoxStreamType.ForeColor = fontDialog1.Color;
            }*/
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();
            /*if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ColorDialog(colorDialog1.Color, RichTextBoxStreamType.RichText);
            }*/
        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        Bitmap bmp;

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void ayudaToolStripButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/url?sa=i&url=https%3A%2F%2Fm.facebook.com%2FMePasoEnSistemas%2Fphotos%2Fa.498369923640534%2F1265355810275271%2F%3Ftype%3D3%26source%3D44&psig=AOvVaw2BNPXh8uZXuvJyozartRZ-&ust=1631911836182000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCLCKj76vhPMCFQAAAAAdAAAAABAD");
        }
    }
    
    }
