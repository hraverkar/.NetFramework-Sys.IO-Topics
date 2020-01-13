using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ConsoleApp197
{
  internal static class Program
  {
    private static void Main()
    {

      var data = new[]
      {
        new
        {
          name = "William", email = "eu.tellus.eu@sedsem.ca", ph = "056 6338 2502",
          company = "Vel Turpis Aliquam Industries"
        },
        new
        {
          name = "Mason", email = "orci.Phasellus.dapibus@ullamcorperDuiscursus.co.uk", ph = "07624 902047",
          company = "Leo Consulting"
        },
        new
        {
          name = "Kuame", email = "lorem.tristique@tellusfaucibus.net", ph = "0312 006 8044",
          company = "Ante Blandit Ltd"
        },
        new
        {
          name = "Abel", email = "nascetur.ridiculus.mus@maurisblandit.co.uk", ph = "056 8153 2422",
          company = "Quis Industries"
        },
        new
        {
          name = "Gil", email = "pharetra@lectuspede.org", ph = "(0110) 498 7965", company = "Ac Urna Ut Industries"
        },
        new
        {
          name = "Kane", email = "in.magna@pedeCrasvulputate.org", ph = "0800 127695",
          company = "Vestibulum Accumsan Neque Foundation"
        },
        new
        {
          name = "Aaron", email = "amet.massa.Quisque@nonfeugiat.edu", ph = "0800 546 3889",
          company = "Aenean Euismod Mauris Inc."
        },
        new
        {
          name = "Coby", email = "rhoncus@elitelitfermentum.net", ph = "07624 646463", company = "Duis At Consulting"
        },
        new
        {
          name = "Anthony", email = "cursus.luctus.ipsum@Craspellentesque.net", ph = "(01902) 458249",
          company = "Eu Foundation"
        },
        new
        {
          name = "Tyrone", email = "dis@etpedeNunc.net", ph = "(016977) 4756",
          company = "Natoque Penatibus Et Corporation"
        },
        new
        {
          name = "Raymond", email = "Phasellus@cursuseteros.org", ph = "056 9442 9618",
          company = "Accumsan Sed Facilisis Inc."
        },
        new {name = "Jared", email = "id.erat@aliquetmolestie.net", ph = "0814 189 9772", company = "A Ltd"},
        new
        {
          name = "Vincent", email = "Quisque.libero@amalesuadaid.ca", ph = "07624 713481",
          company = "Fermentum Convallis Ligula Incorporated"
        },
        new
        {
          name = "Bevis", email = "vestibulum.lorem@laoreetlibero.ca", ph = "0500 610799", company = "Felis Corporation"
        },
        new
        {
          name = "George", email = "ac.fermentum.vel@fermentumarcu.com", ph = "07160 391651",
          company = "Dignissim Magna A Consulting"
        },
        new
        {
          name = "Colorado", email = "quis.tristique.ac@dapibusidblandit.ca", ph = "056 0344 1885",
          company = "Fringilla Ornare Inc."
        },
        new {name = "Palmer", email = "elit.dictum@idenim.net", ph = "0800 072 8780", company = "Malesuada Limited"},
        new {name = "Stephen", email = "tincidunt.pede@sollicitudin.edu", ph = "056 6775 8442", company = "Magna LLP"},
        new
        {
          name = "Drake", email = "iaculis.aliquet.diam@ascelerisquesed.org", ph = "(01943) 76258",
          company = "Quis Massa Mauris LLP"
        },
        new {name = "Burton", email = "aliquet@mi.org", ph = "0996 207 3349", company = "Euismod Est LLP"},
        new
        {
          name = "Allistair", email = "venenatis.a.magna@ametdiameu.org", ph = "0800 303 4615", company = "Odio LLC"
        },
        new
        {
          name = "Laith", email = "sed.dui.Fusce@utodio.org", ph = "0800 713 9725", company = "Mauris Sagittis Corp."
        },
        new {name = "Leroy", email = "leo.Cras@vitaeeratvel.edu", ph = "0500 528916", company = "Fringilla Mi PC"},
        new
        {
          name = "Nash", email = "montes@aliquamenim.org", ph = "(016977) 1572",
          company = "Varius Ultrices Mauris Corporation"
        },
        new
        {
          name = "Wang", email = "imperdiet.erat@ametconsectetueradipiscing.com", ph = "0995 730 2867",
          company = "Elit Foundation"
        },
        new {name = "Eagan", email = "libero@diamDuismi.edu", ph = "0800 1111", company = "Massa Quisque LLC"},
        new
        {
          name = "Lewis", email = "tellus@natoquepenatibuset.ca", ph = "076 2511 0048",
          company = "Aliquam Nisl Nulla Consulting"
        },
        new
        {
          name = "Oren", email = "scelerisque.mollis.Phasellus@Vestibulumaccumsanneque.ca", ph = "055 3898 3562",
          company = "Egestas Ltd"
        },
        new
        {
          name = "Callum", email = "sed.consequat.auctor@facilisis.co.uk", ph = "0800 752470",
          company = "Malesuada Associates"
        },
        new
        {
          name = "Rafael", email = "Integer.tincidunt@tincidunt.com", ph = "0800 683 0558",
          company = "Et Ultrices Corporation"
        },
        new
        {
          name = "Addison", email = "Aliquam.erat.volutpat@ultriciessemmagna.co.uk", ph = "055 1837 0899",
          company = "Fusce Company"
        },
        new {name = "Ciaran", email = "Vivamus.euismod.urna@erateget.net", ph = "07458 638908", company = "Eu LLC"},
        new
        {
          name = "Paul", email = "semper.rutrum.Fusce@orciadipiscingnon.edu", ph = "0388 887 1233",
          company = "Elit Erat Ltd"
        },
        new
        {
          name = "Jameson", email = "nisl.Quisque.fringilla@ipsum.co.uk", ph = "(022) 9584 3966",
          company = "Faucibus Ut Associates"
        },
        new
        {
          name = "Nasim", email = "suscipit.nonummy@aliquam.co.uk", ph = "0500 677444",
          company = "Eu Placerat Eget Incorporated"
        },
        new
        {
          name = "Talon", email = "Suspendisse@aliquamerosturpis.ca", ph = "(0111) 629 7945", company = "Et Magnis Inc."
        },
        new {name = "Ciaran", email = "lacus.pede@facilisi.ca", ph = "0800 1111", company = "Sed PC"},
        new
        {
          name = "August", email = "vitae.sodales@scelerisque.co.uk", ph = "076 6196 5597",
          company = "Quisque Ac Institute"
        },
        new
        {
          name = "Acton", email = "Maecenas.malesuada.fringilla@ametante.co.uk", ph = "(0111) 831 5500",
          company = "Ac Company"
        },
        new
        {
          name = "Colt", email = "dui.Fusce.diam@DonecegestasAliquam.edu", ph = "07663 732675",
          company = "Nunc Sollicitudin Commodo PC"
        },
        new
        {
          name = "Donovan", email = "eleifend@Nullamlobortis.ca", ph = "056 7776 4062", company = "Ultricies Sem PC"
        },
        new {name = "Silas", email = "at@pede.net", ph = "(01873) 844464", company = "Elit Aliquam Auctor Corporation"},
        new
        {
          name = "Harrison", email = "adipiscing.lobortis.risus@magna.ca", ph = "(0119) 589 1405",
          company = "In Consequat Enim PC"
        },
        new {name = "Hedley", email = "bibendum@egetnisi.edu", ph = "0500 345321", company = "A Felis Institute"},
        new {name = "Arthur", email = "quis@vitae.co.uk", ph = "0800 870 6060", company = "Curabitur Ut Foundation"},
        new
        {
          name = "Keith", email = "et.pede.Nunc@pharetra.co.uk", ph = "(0113) 357 6181",
          company = "Metus Aenean Sed Inc."
        },
        new
        {
          name = "Reed", email = "ullamcorper@accumsanlaoreetipsum.co.uk", ph = "(017138) 07234",
          company = "Dictum Inc."
        },
        new
        {
          name = "Colton", email = "fringilla.Donec.feugiat@ut.com", ph = "(029) 0593 1513",
          company = "Egestas Aliquam LLC"
        },
        new
        {
          name = "Matthew", email = "fringilla.euismod.enim@ametconsectetueradipiscing.org", ph = "(020) 3258 4941",
          company = "Rutrum Justo LLC"
        },
        new
        {
          name = "Ferdinand", email = "sit.amet.consectetuer@quis.com", ph = "(019392) 82828",
          company = "Magna Phasellus Dolor Corporation"
        },
        new
        {
          name = "Francis", email = "lobortis.quam.a@nibhDonec.net", ph = "(018779) 85689",
          company = "Ac Risus Associates"
        },
        new {name = "Brody", email = "dictum@sed.co.uk", ph = "0800 806261", company = "Iaculis Corporation"},
        new {name = "Judah", email = "mi@iaculis.ca", ph = "055 9253 7625", company = "Libero Proin Institute"},
        new
        {
          name = "James", email = "aliquet.libero.Integer@tempus.net", ph = "(0114) 053 1466",
          company = "Metus In Lorem Consulting"
        },
        new
        {
          name = "Chester", email = "ipsum.cursus@diam.co.uk", ph = "0800 566719",
          company = "Tellus Nunc Lectus Limited"
        },
        new {name = "Keaton", email = "Cras.eget@Pellentesque.net", ph = "0500 249901", company = "Curabitur PC"},
        new
        {
          name = "Troy", email = "nunc.ullamcorper@Cumsociis.ca", ph = "(0151) 106 9931",
          company = "Phasellus At Augue Ltd"
        },
        new
        {
          name = "Tucker", email = "et@tristiquepellentesque.com", ph = "055 0121 0658", company = "Quis Diam Company"
        },
        new
        {
          name = "Jelani", email = "Vivamus.rhoncus.Donec@tellus.co.uk", ph = "070 3458 5175",
          company = "Imperdiet Inc."
        },
        new {name = "Tucker", email = "nisi.magna@faucibusleoin.net", ph = "0800 963 5547", company = "Donec LLP"},
        new
        {
          name = "Kibo", email = "sollicitudin.orci.sem@Aliquamtincidunt.net", ph = "07337 403347",
          company = "Convallis Foundation"
        },
        new
        {
          name = "Dillon", email = "Curabitur@iaculisquispede.ca", ph = "(016977) 2409",
          company = "Elit Elit Fermentum Corporation"
        },
        new
        {
          name = "Seth", email = "Aenean.gravida.nunc@tortor.co.uk", ph = "0800 684410",
          company = "Vehicula Aliquet Libero Industries"
        },
        new {name = "Simon", email = "nec.leo@miloremvehicula.com", ph = "076 5127 7058", company = "Elit Consulting"},
        new {name = "Benjamin", email = "ante.Vivamus@tincidunt.ca", ph = "(016977) 9348", company = "Fames PC"},
        new
        {
          name = "Dominic", email = "eu.tellus@Phasellusliberomauris.com", ph = "0800 670 6222",
          company = "In Tempus Inc."
        },
        new
        {
          name = "Henry", email = "convallis@ullamcorperDuisat.net", ph = "0800 690 8668",
          company = "Accumsan Laoreet Consulting"
        },
        new {name = "Hunter", email = "accumsan.laoreet@Duisami.net", ph = "(01954) 05051", company = "Ut Institute"},
        new
        {
          name = "Camden", email = "sem.magna.nec@rhoncusid.co.uk", ph = "056 8267 1071",
          company = "Pede Suspendisse LLP"
        },
        new {name = "August", email = "Etiam@Mauris.co.uk", ph = "0800 652344", company = "Non Company"},
        new
        {
          name = "Slade", email = "ligula.Aenean@risusDonecegestas.com", ph = "070 3170 7044",
          company = "Nisi Cum Sociis Limited"
        },
        new
        {
          name = "Lance", email = "magna.et.ipsum@nequetellusimperdiet.net", ph = "(0111) 278 5896", company = "Orci PC"
        },
        new {name = "Tad", email = "Cum@urnaNullam.org", ph = "056 5675 2205", company = "Fusce Aliquet Magna LLP"},
        new {name = "Fulton", email = "nec.imperdiet@dictummagnaUt.org", ph = "076 8829 6333", company = "Arcu LLC"},
        new
        {
          name = "Wang", email = "mollis.non.cursus@Fusce.com", ph = "0835 771 6595", company = "Nec Enim Institute"
        },
        new {name = "Octavius", email = "Fusce@Nullam.ca", ph = "0379 978 6786", company = "Proin Vel Nisl LLP"},
        new {name = "Chandler", email = "nec@asollicitudinorci.co.uk", ph = "055 5050 3562", company = "Sed Limited"},
        new
        {
          name = "Cole", email = "vulputate.ullamcorper.magna@vellectus.ca", ph = "(021) 8880 0273",
          company = "Magnis Dis Inc."
        },
        new
        {
          name = "Jack", email = "consectetuer.adipiscing.elit@euismodest.co.uk", ph = "(0118) 615 3051",
          company = "Tempor Lorem LLP"
        },
        new
        {
          name = "Demetrius", email = "vitae.diam.Proin@loremvehicula.co.uk", ph = "(0118) 080 7625",
          company = "Velit Aliquam Nisl Company"
        },
        new
        {
          name = "Ulysses", email = "parturient.montes@risus.net", ph = "070 2980 0669",
          company = "Cras Lorem Lorem Ltd"
        },
        new {name = "Caesar", email = "Sed@sodales.org", ph = "0800 644 1530", company = "Quis Arcu Vel Company"},
        new
        {
          name = "Aristotle", email = "arcu.Vestibulum@libero.com", ph = "(021) 5939 0702",
          company = "Curabitur Foundation"
        },
        new
        {
          name = "Nissim", email = "nisl.Quisque.fringilla@ametmetusAliquam.edu", ph = "0800 485 4927",
          company = "Cursus Luctus Ipsum PC"
        },
        new {name = "Kenneth", email = "id@atvelitCras.net", ph = "(022) 5822 7610", company = "Eu Tellus Institute"},
        new
        {
          name = "Emmanuel", email = "purus.ac.tellus@aliquet.org", ph = "(0117) 417 3432",
          company = "Eu Neque Pellentesque Corp."
        },
        new
        {
          name = "Addison", email = "eget@Pellentesquetincidunttempus.ca", ph = "(0113) 569 0548",
          company = "Orci Adipiscing Non Company"
        },
        new
        {
          name = "Hedley", email = "ligula@mattisornarelectus.co.uk", ph = "0500 551771", company = "Turpis Corporation"
        },
        new
        {
          name = "Samson", email = "arcu.vel@vitaealiquam.co.uk", ph = "(0119) 214 6187", company = "Nostra Industries"
        },
        new {name = "Zeph", email = "magna@Aenean.com", ph = "056 8619 0498", company = "Mi Eleifend Corporation"},
        new
        {
          name = "Finn", email = "lectus.Nullam@semperauctorMauris.net", ph = "(01044) 932174",
          company = "Faucibus Ut Nulla Ltd"
        },
        new {name = "Kuame", email = "diam.Proin.dolor@fringillami.co.uk", ph = "076 3346 2122", company = "Nec Inc."},
        new {name = "Garrett", email = "eget@eu.com", ph = "(01854) 943126", company = "Ut Aliquam Iaculis Institute"},
        new
        {
          name = "Gary", email = "orci.luctus@vestibulumMauris.net", ph = "0800 258 9536", company = "Leo Elementum LLP"
        },
        new {name = "Slade", email = "at@ligula.net", ph = "0500 928227", company = "Accumsan Interdum Incorporated"},
        new
        {
          name = "Colby", email = "vestibulum@tempus.ca", ph = "0500 171811", company = "Maecenas Iaculis Institute"
        },
        new {name = "Cain", email = "ut.pharetra.sed@nunc.edu", ph = "0800 1111", company = "Nulla Vulputate Corp."},
        new
        {
          name = "Lane", email = "Morbi.quis.urna@aliquetlibero.com", ph = "(019683) 74633",
          company = "Fames Ac Turpis Corp."
        },
        new {name = "Patrick", email = "eget.magna@euneque.co.uk", ph = "(015782) 40570", company = "Donec PC"},
        new {name = "Byron", email = "nec@Duiscursus.net", ph = "07976 048144", company = "Vitae Purus Foundation"}
      };



      var watch = Stopwatch.StartNew();
      /*var a = from b in data
              where b.name == "Gary"
              select b;*/

      var a = data.Where(b => b.name == "Gary");
      foreach (var VARIABLE in a.ToList())
      {
        Console.WriteLine(VARIABLE.name);
        Console.WriteLine(VARIABLE.email);
        Console.WriteLine(VARIABLE.ph);
        Console.WriteLine(VARIABLE.company);
      }
      watch.Stop();
      Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
    }
  }
}
