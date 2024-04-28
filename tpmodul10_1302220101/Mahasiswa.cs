using System.Reflection.Metadata.Ecma335;

namespace tpmodul10_1302220101
{
    public class Mahasiswa
    {
        private String nama;
        private String nim;
        public String Nama {  get => nama; set => nama = value; }
        public String Nim {  get => nim; set => nim = value; }

        public Mahasiswa(String Nama, String Nim)
        {
            this.nama = Nama;
            this.nim = Nim;
        }
    }
}
