using System;
using System.Collections.Generic;
using System.Text;

namespace tpModul7_kelompok_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa103082400034 data = new DataMahasiswa103082400034();
            data.ReadJSON();

            KuliahMahasiswa103082400034 matkul = new KuliahMahasiswa103082400034();
            matkul.ReadJSON();

        }
    }
}
