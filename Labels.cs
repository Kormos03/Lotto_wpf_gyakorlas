using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Lotto_wpf
{
    public class Labels
    {
        private Random rnd;
        private int tempRND;
        private int lastRandomNumber;
        private List<int> exceptions;

        public Labels()
        {
            rnd = new Random();
            Exceptions = new List<int>();
        }

        public int TempRND { get => tempRND; private set => tempRND = value; }
        public int LastRandomNumber { get => lastRandomNumber; private set => lastRandomNumber = value; }
        public Random Rnd { get => rnd; set => rnd = value; }
        public List<int> Exceptions { get => exceptions; set => exceptions = value; }

        public async Task<int> GenerateRandomNumberAsync(TextBlock eredmeny)
        {
            TempRND = 0;
            for (int i = 0; i < 20; i++)
            {
                TempRND = Rnd.Next(1, 101);
                if(Exceptions.Contains(TempRND))
                {
                    TempRND = Rnd.Next(1, 101);
                }
                UpdateTextBlock(eredmeny, TempRND.ToString());
                await Task.Delay(60);
            }
            LastRandomNumber = TempRND;
            Exceptions.Add(TempRND);
            return TempRND;
        }

        private void UpdateTextBlock(TextBlock textBlock, string text)
        {
            // Check if the textBlock is null to avoid potential issues
            if (textBlock != null)
            {
                textBlock.Text = text;
            }
        }

        public override string ToString()
        {
            return LastRandomNumber.ToString();
        }
    }
}
