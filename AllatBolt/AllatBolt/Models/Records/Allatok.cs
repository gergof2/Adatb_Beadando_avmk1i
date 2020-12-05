using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllatBolt.Models.Records
{
    class Allatok
    {
        private string allat_id;
        public string Allat_id
        {
            get { return allat_id; }
            set
            {
                if (value == null)
                    throw new Exception("Az id nem lehet üres!");
                else if (value.Length != 4)
                    throw new ArgumentOutOfRangeException("Az id-nek 4 karakterből kell állnia!");
                allat_id = value;
            }
        }

        private string faj;
        public string Faj
        {
            get { return faj; }
            set 
            {
                if (value == null)
                    throw new Exception("Nem lehet üres a mező!");
                else if (value.Length > 200)
                    throw new ArgumentOutOfRangeException("A faj maximum 200 karakter hosszú lehet!");
                faj = value;
            }
        }

        private string nem;
        public string Nem
        {
            get { return nem; }
            set
            {
                if (value == null)
                    throw new Exception("Nem lehet üres a mező!");
                else if (value.Length > 20)
                    throw new ArgumentOutOfRangeException("A nem max 20 karakterből állhat!");
                nem = value;
            }
        }

        private string etkezes;
        public string Etkezes
        {
            get { return etkezes; }
            set
            {
                if (value == null)
                    throw new Exception("A mező nem lehet üres!");
                else if (value.Length > 20)
                    throw new ArgumentOutOfRangeException("Az étkezés mező maximum 20 karakterből állhat!");
                etkezes = value;
            }
        }

        private int ar;
        public int Ar
        {
            get { return ar; }
            set
            {
                if (value == 0)
                    throw new Exception("Nincs ingyen elvihető állat!");
                ar = value;
            }
        }

        private string bolt;
        public string Bolt
        {
            get { return bolt; }
            set
            {
                if (value == null)
                    throw new Exception("A mező nem lehet üres!");
                bolt = value;
            }
        }
    }
}
