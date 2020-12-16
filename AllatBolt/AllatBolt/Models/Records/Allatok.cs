using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllatBolt.Models.Manager;

namespace AllatBolt.Models.Records
{
    class Allatok
    {
        private string _idszam;
        public string idszam
        {
            get { return _idszam; }
            set
            {
                if (value == null)
                    throw new Exception("Az id nem lehet üres!");
                if (value.Length != 4)
                    throw new Exception("Az id-nek 4 karakterből kell állnia!");
                if (VanBetu(value))
                    throw new Exception("Csak számot tartalmazhat az ID!");
                _idszam = value;
            }
        }

        private string _faj;
        public string faj
        {
            get { return _faj; }
            set 
            {
                if (value == null)
                    throw new Exception("Nem lehet üres a mező!");
                if (VanSzam(value))
                    throw new Exception("A faj nem tartalmazhat számot!");
                if (value.Length > 200)
                    throw new ArgumentOutOfRangeException("A faj maximum 200 karakter hosszú lehet!");
                _faj = value;
            }
        }

        private string _nem;
        public string nem
        {
            get { return _nem; }
            set
            {
                _nem = value;
            }
        }

        private string _etkezes;
        public string etkezes
        {
            get { return _etkezes; }
            set
            {               
                _etkezes = value;
            }
        }

        private string _ar;
        public string ar
        {
            get { return _ar; }
            set
            {
                if (value.Length == 0)
                    throw new Exception("Nincs ingyen elvihető állat!");
                if (VanBetu(value))
                    throw new Exception("Csak számot tartalmazhat az Ár!");
                _ar = value;
            }
        }

        private int _bolt_id;
        public int bolt_id
        {
            get { return _bolt_id; }
            set
            {
                if (value < 0 || value >= 4)
                {
                    throw new Exception("3 bolt van az adatbázisban!");
                }
                _bolt_id = value;
            }
        }
        public bool VanSzam(string betu)
        {
            foreach (char a in betu)
                if (int.TryParse(a.ToString(), out _))
                    return true;
            return false;
        }
        public bool VanBetu(string betu)
        {
            foreach (char a in betu)
                if (!int.TryParse(a.ToString(), out _))
                    return true;
            return false;
        }
    }
}
