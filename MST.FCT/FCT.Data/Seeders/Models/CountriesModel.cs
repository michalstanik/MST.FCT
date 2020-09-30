﻿using System.Collections.Generic;

namespace FCT.Data.Seeders.Models
{
    public class CountriesModel
    {
#pragma warning disable IDE1006 // Naming Styles
        public class Nld
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Pap
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Native
        {
            public Nld nld { get; set; }
            public Pap pap { get; set; }
        }

        public class Name
        {
            public string common { get; set; }
            public string official { get; set; }
            public Native native { get; set; }
        }

        public class Idd
        {
            public string root { get; set; }
            public List<string> suffixes { get; set; }
        }

        public class Languages
        {
            public string nld { get; set; }
            public string pap { get; set; }
        }

        public class Ces
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Deu
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Fra
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Hrv
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Ita
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Jpn
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Nld2
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Por
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Rus
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Slk
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Spa
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Fin
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Est
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Zho
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Pol
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Urd
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Kor
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Translations
        {
            public Ces ces { get; set; }
            public Deu deu { get; set; }
            public Fra fra { get; set; }
            public Hrv hrv { get; set; }
            public Ita ita { get; set; }
            public Jpn jpn { get; set; }
            public Nld2 nld { get; set; }
            public Por por { get; set; }
            public Rus rus { get; set; }
            public Slk slk { get; set; }
            public Spa spa { get; set; }
            public Fin fin { get; set; }
            public Est est { get; set; }
            public Zho zho { get; set; }
            public Pol pol { get; set; }
            public Urd urd { get; set; }
            public Kor kor { get; set; }
        }

        public class CountriesDataModel
        {
            public Name name { get; set; }
            public List<string> tld { get; set; }
            public string cca2 { get; set; }
            public string ccn3 { get; set; }
            public string cca3 { get; set; }
            public string cioc { get; set; }
            public bool independent { get; set; }
            public string status { get; set; }
            public List<string> currency { get; set; }
            public Idd idd { get; set; }
            public List<string> capital { get; set; }
            public List<string> altSpellings { get; set; }
            public string region { get; set; }
            public string subregion { get; set; }
            public Languages languages { get; set; }
            public Translations translations { get; set; }
            public List<double> latlng { get; set; }
            public string demonym { get; set; }
            public bool landlocked { get; set; }
            public List<object> borders { get; set; }

            public long area { get; set; }

            public string flag { get; set; }
#pragma warning restore IDE1006 // Naming Styles
        }
    }
}

