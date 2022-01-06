using System;
using System.Collections.Generic;
using System.Text;

namespace QlyDanhba
{
    public class dsDanhba
    {
        private static dsDanhba instance;

        List<Danhba> listSodth;

        public List<Danhba> ListSodth { get => listSodth; set => listSodth = value; }
        public static dsDanhba Instance
        {
            get 
            {
                if (instance == null)
                    instance = new dsDanhba();
                return instance;
            }
          set => instance = value; 
        }

        private dsDanhba()
        {
            listSodth = new List<Danhba>();
        }
    }
}
