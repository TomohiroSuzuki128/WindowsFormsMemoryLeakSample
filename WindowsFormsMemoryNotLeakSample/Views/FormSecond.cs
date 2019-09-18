using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMemoryLeakSample
{
    public partial class FormSecond : Form
    {
        public FormSecond()
        {
            InitializeComponent();
        }

        private void buttonAlert_Click(object sender, EventArgs e)
        {
            MessageBox.Show("アラート");
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("---Close SecondForm-----------------------------");
            this.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

    }
}
