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

        protected override void Dispose(bool disposing)
        {
            System.Diagnostics.Debug.WriteLine($"Disposed AlertButton {count}");

            base.Dispose(disposing);
        }

        ~AlertButton()
        {
            System.Diagnostics.Debug.WriteLine($"Finalized AlertButton {count}");
        }

    }
}
