using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                else if (value.Length != 4)
                    throw new ArgumentOutOfRangeException("Az id-nek 4 karakterből kell állnia!");
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
                else if (value.Length > 200)
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
                if (value == null)
                    throw new Exception("Nem lehet üres a mező!");
                else if (value.Length > 20)
                    throw new ArgumentOutOfRangeException("A nem max 20 karakterből állhat!");
                _nem = value;
            }
        }

        private string _etkezes;
        public string etkezes
        {
            get { return _etkezes; }
            set
            {
                if (value == null)
                    throw new Exception("A mező nem lehet üres!");
                else if (value.Length > 20)
                    throw new ArgumentOutOfRangeException("Az étkezés mező maximum 20 karakterből állhat!");
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
                _ar = value;
            }
        }

        private int _bolt_id;
        public int bolt_id
        {
            get { return _bolt_id; }
            set
            {
                _bolt_id = value;
            }
        }
    }
}
