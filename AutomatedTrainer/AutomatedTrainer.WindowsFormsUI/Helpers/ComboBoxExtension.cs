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
        static public TEnum ParseEnum<TEnum>(this ComboBox comboBox) where TEnum : struct
        {
            TEnum answer;

            Enum.TryParse(comboBox.ToString(), out answer);

            return answer;
        }
    }
}
