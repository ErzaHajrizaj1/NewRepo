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
    public partial class RegjistrimiKlientave : Form
    {
        public RegjistrimiKlientave()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm1 = (Form1)Application.OpenForms[0];
            frm1.ShowPanel();     
            frm1.ClearTittle();

        }
    }
}
