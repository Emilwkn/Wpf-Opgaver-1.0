using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace Wpf_Opgaver_1._0.Biz
{
    class ClassBIZ
    {
        //List Clear command
        private void ClearList(ListBox listBox)
        {
            if (listBox.ItemsSource != null)
            {
                listBox.ItemsSource = null;
            }
            listBox.Items.Clear();
        }
        //----------------------------------------------------
        //opgave 1.2
        public void Delopgave12(ListBox listBox)
        {
            ClearList(listBox);

            for (int i = 4711; i < 4737; i++)
            {
                listBox.Items.Add(i.ToString());
            }
        }
        //------------------------------------------------------------
        //opgave 1.3
        public void Delopgave13(ListBox listBox)
        {
            Random random = new Random();

            ClearList(listBox);

            for (int i = 0; i < 25; i++)
            {
                int randomTal = random.Next(100000, 1000001);
                listBox.Items.Add(randomTal.ToString());
            }
        }
        //-----------------------------------------------------------------
        //opgave 1.4
        public void Delopgave14(ListBox listBox)
        {
            Random random = new Random();
            List<int> listInt = new List<int>();

            ClearList(listBox);

            for (int i = 0; i < 25; i++)
            {
                int randomTal = random.Next(100000, 1000001);
                listInt.Add(randomTal);
            }
            listInt.Sort();

            foreach (int tal in listInt)
            {
                listBox.Items.Add(tal.ToString());
            }
        }
        //-----------------------------------------------------------
        //opgave 1.5
        public void Delopgave15(ListBox listBox)
        {
            Random random = new Random();
            List<int> listInt1 = new List<int>();
            List<int> listInt2 = new List<int>();

            ClearList(listBox);

            for (int i = 0; i < 25; i++)
            {
                int randomTal = random.Next(100000, 1000001);
                listInt1.Add(randomTal);
                listInt2.Add(randomTal);
            }
            listInt2.Sort();

            for (int i = 0; i < listInt1.Count; i++)
            {
                listBox.Items.Add($"{listInt1[i]} - {listInt2[i]}");
            }
        }
        //----------------------------------------------------------
        // Opgave 1.6
        public void Delopgave16(ListBox listBox)
        {
            Random random = new Random();
            List<int> listInt = new List<int>();

            ClearList(listBox);

            for (int i = 0; i < 25; i++)
            {
                int randomTal = random.Next(100000, 1000001);
                listBox.Items.Add(randomTal);
                listInt.Add(randomTal);
            }

            listBox.Items.Add("");
            listBox.Items.Add($"Gennemsnitsværdi : {GetAvarageValue(listInt)}");
        }
        private int GetAvarageValue(List<int> list)
        {
            int intRes = 0;
            int intCount = 0;

            foreach (int tal in list)
            {
                intRes += tal;
                intCount++;
            }

            intRes = intRes / intCount;

            return intRes;
        }
        //--------------------------------------------------
        //opgave 1.7
        public void Delopgave17(ListBox listBox)
        {
            Random random = new Random();
            List<int> listInt = new List<int>();


            ClearList(listBox);

            for (int i = 0; i < 25; i++)
            {
                int randomTal = random.Next(100000, 1000001);
                listInt.Add(randomTal);
            }
            int intAverage = GetAvarageValue(listInt);
            listInt.Sort();
            foreach (int tal in listInt)
            {
                listBox.Items.Add($"{tal} - {intAverage} = {tal - intAverage}");
            }
        }
        //--------------------------------------------------------
        //opgave 1.8
        public List<string> Delopgave18()
        {
            Random random = new Random();
            List<int> listInt = new List<int>();
            List<string> listRes = new List<string>();

            int intAverage = 0;

            for (int i = 0; i < 25; i++)
            {
                int randomTal = random.Next(100000, 1000001);
                listInt.Add(randomTal);
            }

            intAverage = GetAvarageValue(listInt);

            listInt.Sort();

            foreach (int tal in listInt)
            {
                listRes.Add($"{tal} + {intAverage} = {tal + intAverage}");
            }

            return listRes;
        }
        //-----------------------------------------------------------------------
        //opgave 1.9
        public void Delopgave19(ListBox listBox)
        {
            Random random = new Random();
            List<int> listInt = new List<int>();
            int intAverage = 0;

            ClearList(listBox);

            for (int i = 0; i < 25; i++)
            {
                int randomTal = random.Next(100000, 1000001);
                listInt.Add(randomTal);
            }
            intAverage = GetAvarageValue(listInt);

            listInt.Sort();

            foreach (int tal in listInt)
            {
                ListBoxItem listBoxItem = new ListBoxItem();
                if ((tal % 2) != 0)
                {
                    listBoxItem.Background = Brushes.AliceBlue;
                }
                else
                {
                    listBoxItem.Background = Brushes.HotPink;
                }

                listBoxItem.Content = $"{tal} - {intAverage} = {tal - intAverage}";
                listBox.Items.Add(listBoxItem);
            }
        }
        //----------------------------------------------------------------------------
        //Opgave 1.10
        public void Delopgave110(ListBox listBox)
        {
            Random random = new Random();
            List<int> listInt = new List<int>();
            int intAverage = 0;

            ClearList(listBox);

            for (int i = 0; i < 25; i++)
            {
                int randomTal = random.Next(100000, 1000001);
                listInt.Add(randomTal);
            }
            intAverage = GetAvarageValue(listInt);

            listInt.Sort();

            foreach (int tal in listInt)
            {
                ListBoxItem listBoxItem = new ListBoxItem();
                if ((tal % 2) != 0)
                {
                    listBoxItem.Background = Brushes.AliceBlue;
                }
                else
                {
                    listBoxItem.Background = Brushes.HotPink;
                }

                listBoxItem.Content = $"{tal} - {intAverage} = {tal - intAverage}";
                listBox.Items.Add(listBoxItem);
            }
        }
    }
}
