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
    public partial class FormFirst : Form
    {
        public FormFirst()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("------------------------------------------------");
            System.Diagnostics.Debug.WriteLine("---Open SecondForm------------------------------");

            var formSecond = new FormSecond();
            Counter.Default.CountUp();
            formSecond.ShowDialog(this);
        }
    }
}
