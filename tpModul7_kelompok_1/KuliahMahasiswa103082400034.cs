using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace tpModul7_kelompok_1
{
    

   
    public class CourseDetail
    {
        public string kode_mk { get; set; }
        public string nama_mk { get; set; }
    }

    
    public class CourseData
    {
        public List<CourseDetail> mata_kuliah { get; set; }
    }

    
    public class KuliahMahasiswa103082400034
    {
        public void ReadJSON()
        {
            string filePath = "tp7_2_103082400034.json";

            try
            {
               
                string jsonString = File.ReadAllText(filePath);

                CourseData data = JsonSerializer.Deserialize<CourseData>(jsonString);

               
                Console.WriteLine("Daftar mata kuliah yang diambil:");

                int urutan = 1;
                foreach (var mk in data.mata_kuliah)
                {
                    Console.WriteLine($"MK {urutan} {mk.kode_mk} - {mk.nama_mk}");
                    urutan++;
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File JSON tidak ditemukan. Pastikan nama dan lokasi file sudah benar.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Terjadi kesalahan: {ex.Message}");
            }
        }
    }
}
