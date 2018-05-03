using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sztf2_mintazh02
{
    internal interface IEgitest
    {
        double Tavolsag { get; set; }
        double Gravitacio { get; set; }
        int Legkor { get; set; }

        //        Készítsünk egy IEgitest interfészt, amely az alábbiakat tartalmazza: (2 pont)
        // double Tavolsag – Tulajdonság, a Földtől való távolságot tárolja fényévekben(a Proxima Centauri a
        //legközelebbi csillag, melynek távolsága a Naptól 4.25 fényév).
        // double Gravitacio – Tulajdonság, az égitest gravitációs vonzását határozza meg N/Kg-ban(a Föld
        //esetében ez az érték ~10 N/Kg).
        // int Legkor – Tulajdonság, az égitest légkörének nyomása millibarban.Ha az égitestnek nincs légköre,
        //akkor ez az érték 0 (a Föld esetében ez az érték ~1000 millibar).
    }
}