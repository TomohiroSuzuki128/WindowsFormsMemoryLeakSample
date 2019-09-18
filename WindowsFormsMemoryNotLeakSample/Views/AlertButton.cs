using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMemoryLeakSample
{
    public class AlertButton : Button
    {

        int count = Counter.Default.Count;

        public AlertButton()
        {
            System.Diagnostics.Debug.WriteLine($"Created AlertButton {count}");
        }

        ~AlertButton()
        {
            System.Diagnostics.Debug.WriteLine($"Finalized AlertButton {count}");
        }

    }
}
