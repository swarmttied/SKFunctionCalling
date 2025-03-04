using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKFunctionCallingWinform
{
    public static class ControlExtensions
    {
        static public void AutoScrollToBottom(this ListBox listbox)
        {
            if (listbox.Items == null || listbox.Items.Count == 0)
                return;
            listbox.TopIndex = listbox.Items.Count - 1;
        }
    }
}
