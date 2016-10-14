using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace playlists16
{
    public partial class Form2 : baseForm
    {
        Form1 opener;
        public Form2(Form1 parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }

     

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

     

        private void modifyOff_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form2 = null;
            opener.Show();
        }

        
    }
}
