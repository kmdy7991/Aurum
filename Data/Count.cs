using System;

namespace AURUM.Data
{
    public class Count
    {
        public int Num1 { get; set; } = 0;
        public int Num2 { get; set; } = 0;
        public int Num3 { get; set; } = 0;
        public int Sum { get; set; } = 0;

        public void ClearSet()
        {
            Num1 = 0;
            Num2 = 0;
            Num3 = 0;
            Sum = 0;
        }
        public string Percent(int num, int sum) 
        {
            return string.Format("{0:f3}%", (double)num / (double)sum * 100);
        }
    }
}
