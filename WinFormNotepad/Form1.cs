using System.Text.RegularExpressions;

namespace WinFormNotepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // This is where the code for the button click of "New" is going to go.
            SaveFileDialog sfd = new SaveFileDialog();
            DialogResult dr = MessageBox.Show("Do you want to save the file", "save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr.Equals(DialogResult.Yes)) //Statement that execute when user click on yes button
            {
                string filename = sfd.FileName;
                String filter = "Text Files|*.txt|All Files|*.*";
                sfd.Filter = filter;

                sfd.Title = "Save";

                if (sfd.ShowDialog(this) == DialogResult.OK)
                {

                    //Write all of the text in txtBox to the specified file

                 System.IO.File.WriteAllText(filename, richTextBox1.Text);



                }

                else
                {

                    //Return

                    return;

                }

            }
            else
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open =new OpenFileDialog();
            open.Title = "Open";
            open.Filter = "Text Document(*.txt)|*.txt|All Files (*.*) | *.*";

            if(open.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(open.FileName, RichTextBoxStreamType.UnicodePlainText);
                
            }
            this.Text = open.FileName;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save";
            save.Filter = "Text Document(*.txt)|*.txt|All Files (*.*) | *.*";

            if (save.ShowDialog() == DialogResult.OK)
            {
                // System.IO.File.WriteAllText(save.FileName, richTextBox1.Text);
                  richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.UnicodePlainText);
                 
               /// Stream s = File.Open(save.FileName, FileMode.OpenOrCreate, FileAccess.Write);
            }
            this.Text = save.FileName;


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = System.DateTime.Now.ToString();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //fontdialog font = new fontdialog();
            //if (font.showdialog() == dialogresult.ok)
            //{
            //    regex regexp = new regex("\b(for|next|if|then)\b");

            //    foreach (match match in regexp.matches(richtextbox1.text))
            //{
            //    richtextbox1.select(match.index, match.length);
                
            //}
            //    richtextbox1.selectionfont = font.font;

            
            //}


            
            FontDialog fo = new FontDialog();
            if( fo.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fo.Font;
            }
            



        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ColorDialog color = new ColorDialog();
            //if (color.ShowDialog() == DialogResult.OK)
            //{
            //    Regex regExp = new Regex("\b(For|Next|If|Then)\b");

            //    foreach (Match match in regExp.Matches(richTextBox1.Text))
            //    {
            //        richTextBox1.Select(match.Index, match.Length);

            //    }
            //    richTextBox1.SelectionColor = color.Color;

            //}

            ColorDialog fo = new ColorDialog();
            if (fo.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = fo.Color;
            }

        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Select();
        }

        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            richTextBox1.Text +=" "+ d.ToString();
        }
    }
}