using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Quyen_DTO
    {
        private string iMaQuyen;
        private string sTenQuyen;

        public Quyen_DTO(string iMaQuyen, string sTenQuyen)
        {
            this.IMaQuyen = iMaQuyen;
            this.STenQuyen = sTenQuyen;
        }

        public Quyen_DTO()
        {
        }
        public string IMaQuyen { get => iMaQuyen; set => iMaQuyen = value; }
        public string STenQuyen { get => sTenQuyen; set => sTenQuyen = value; }


    }
}
