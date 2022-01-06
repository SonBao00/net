using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QlyDanhba
{
    public class Danhba
    {
        private string sodth;
        private string diachi;
        private string ten;
        private string ghichu;

        public string Sodth { get => sodth; set => sodth = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }

        public Danhba(string sodth, string diachi, string ten, string ghichu)
        {
            Sodth = sodth;
            Diachi = diachi;
            Ten = ten;
            Ghichu = ghichu;
        }
        public Danhba(DataRow row)
        {
            Sodth = row["Sodth"].ToString();
            Diachi = row["Diachi"].ToString();
            Ten = row["Ten"].ToString();
            Ghichu = row["Ghichu"].ToString();
        }
    }
}
