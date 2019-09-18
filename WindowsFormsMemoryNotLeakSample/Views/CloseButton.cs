using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMemoryLeakSample
{
    public class CloseButton : Button
    {

        int count = Counter.Default.Count;

        public CloseButton()
        {
            System.Diagnostics.Debug.WriteLine($"Created CloseButton {count}");
        }

        ~CloseButton()
        {
            System.Diagnostics.Debug.WriteLine($"Finalized CloseButton {count}");
        }

    }
}
