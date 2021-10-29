using System;

using Microsoft.Win32;

namespace _5Sem_Seti_Lab3
{
    internal class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            var f = new OpenFileDialog();
            f.ShowDialog();
            Console.WriteLine();
            uint poly = 0xA097;
            var degree = 16;
            Console.WriteLine($"Файл - {f.FileName} CRC - {Convert.ToString(CRC.GetCRC(f.FileName, poly, 16), degree)},Полином - {Convert.ToString(poly, 16)}");
            Console.ReadKey();
        }
    }
}