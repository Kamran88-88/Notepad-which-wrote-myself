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

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult==DialogResult.OK)
            {
                using (StreamReader reader=new StreamReader(openFileDialog1.FileName))
                {
                    richTextBox1.Text = reader.ReadToEnd();
                }
            }   
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            if (openFileDialog1.FileName=="")
            {
                saveFileDialog1.ShowDialog();
            }
            else
            {
                using (StreamWriter writer=new StreamWriter(openFileDialog1.FileName))
                {
                    writer.WriteLine(richTextBox1.Text);
                }
            }
     
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = MessageBox.Show("Save etmək istəyirsiz?", "Sual", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                saveToolStripMenuItem_Click(sender, e);
            }
            else if (a == DialogResult.No)
            {
                richTextBox1.Clear();
            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
          var a=  MessageBox.Show("Save etmək istəyirsiz?", "Sual", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);


            if (a==DialogResult.Yes)
            {
                saveToolStripMenuItem_Click(sender, e);
            }
            else if(a==DialogResult.No)
            {
                Close();
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
           
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }
    }
}
