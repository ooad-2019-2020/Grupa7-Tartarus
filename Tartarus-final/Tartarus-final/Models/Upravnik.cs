﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tartarus_final.Models
{
    public class Upravnik : Korisnik
    {
        public Upravnik(int Id, String ime, String prezime, String username, String em, String loz, DateTime date) : base(Id, ime, prezime, username, em, loz, date)
        {

        }
    }
}
