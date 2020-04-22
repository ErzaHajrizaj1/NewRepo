using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenaxhimiMallrave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void item1_Click(object sender, System.EventArgs e)
        {
            // Add event handler code here.
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        public void ShowPanel()
        {
            panel1.BringToFront();
        }
        public void ClearTittle()
        {
            LblTittle.Text = "";
        }
        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                if (listBox1.SelectedItem.ToString()== "Regjistrimi i Klientave")
                {
                RegjistrimiKlientave kmsh = new RegjistrimiKlientave();
                kmsh.MdiParent = this;
                ShowForm(kmsh, "Regjistrimi i Klientave");
                }
            }
        }
        public void ShowForm(Form frm,string Tittle)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == frm.Text)
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }


            if (IsOpen == false)
            {
                //Form2 f2 = new Form2();
                //test2
                LblTittle.Text = Tittle;
                frm.MdiParent = this;
                frm.Location = panel1.Location;
                frm.Anchor = panel1.Anchor;
                frm.Size = panel1.Size;
                frm.BringToFront();
                panel1.SendToBack();
                frm.Show();
            }
        }
    }
}
