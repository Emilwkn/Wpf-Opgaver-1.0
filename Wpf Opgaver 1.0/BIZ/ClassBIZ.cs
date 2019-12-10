using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Wpf_Opgaver_1._0.Biz
{
    class ClassBIZ
    {

        public void Delopgave12(ListBox listBox)
        {
            listBox.Items.Clear();

            for (int i= 4711; i < 4737; i++)
            {
                listBox.Items.Add(i.ToString());
            }
        }

        public void Delopgave13(ListBox listBox)
        {
            Random random = new Random();

            listBox.Items.Clear();

            for (int i = 0; i < 25; i++)
            {
                int randomTal = random.Next(100000, 1000001);
                listBox.Items.Add(randomTal.ToString());
            }
        }

    }
}
