using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
        }

        private void uxFind_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(uxNumber.Text);
                SieveList sieve = new SieveList();

                sieve.BuildList(n);
                sieve.FindPrimes();

                StringBuilder result = new StringBuilder();
                foreach (int num in sieve)
                {
                    result.Append(num + " ");
                }

                uxResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
