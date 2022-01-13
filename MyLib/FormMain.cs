using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLib
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            Login login = new Login();
            login.UserLoggedIn += Login_UserLoggedIn;
            login.Show(this);
        }

        private void Login_UserLoggedIn(object sender, EventArgs e)
        {
            using (DataSet dataSet = new DataSet())
            {
                //Read xml to dataset and pass file path as parameter
                dataSet.ReadXml("popisKnjiga.xml");
                dataGridView.DataSource = dataSet.Tables[0];
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
