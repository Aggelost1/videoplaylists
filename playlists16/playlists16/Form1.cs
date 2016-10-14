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
    //here we inherit from the base class so all but 1 of the keys in this form are of the base class
    public partial class Form1 : baseForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        //this is the mdify bottun it opens form2 and hides this form
        public void modifyBottun_Click(object sender, EventArgs e)
        {
                   this.Hide();
                   form2 = new Form2(this) ;
                   form2.Show();
            
        }
    }
}
