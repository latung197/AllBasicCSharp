using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LopClass
{
    public class SinhVien
    {
        public SinhVien()
        {
        }
        public SinhVien (string Id, string Name,int Tuoi)
        {
            this.Id = Id;
            this.Name = Name;
            this.Tuoi = Tuoi;
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public int Tuoi { get; set; }
    }
}
