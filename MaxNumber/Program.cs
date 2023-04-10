using MaxNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            number numbers = new number();
            numbers.CariNilaiMin(12, 76);
            numbers.CariNilaiMin(18, 49, 89);
            numbers.CariNilaiMax(87, 99);
            numbers.CariNilaiMax(35, 23, 45);
        }
    }
}