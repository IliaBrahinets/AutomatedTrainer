using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedTrainer.WindowsFormsUI.Helpers
{
    static class ComboBoxExtension
    {
        static public TEnum ParseEnum<TEnum>(this ListBox listBox) where TEnum : struct
        {
            TEnum answer;

            Enum.TryParse(listBox.SelectedItem.ToString(), out answer);

            return answer;
        }
    }
}
