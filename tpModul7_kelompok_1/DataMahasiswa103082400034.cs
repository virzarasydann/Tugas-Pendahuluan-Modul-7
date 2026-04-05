using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace tpModul7_kelompok_1
{
    internal class DataMahasiswa103082400034
    {
        public string nama { get; set; }
        public long nim { get; set; }
        public string fakultas { get; set; } 

        
        public void ReadJSON()
        {
            string filePath = "tp7_1_103082400034.json";

            try
            {
               
                string jsonString = File.ReadAllText(filePath);

               
                DataMahasiswa103082400034 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa103082400034>(jsonString);

                
                Console.WriteLine($"Nama {mahasiswa.nama} dengan nim {mahasiswa.nim} dari fakultas {mahasiswa.fakultas}");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File JSON tidak ditemukan. Pastikan file berada di folder yang sama dengan program.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Terjadi kesalahan: {ex.Message}");
            }
        }
    }
}
