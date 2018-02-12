using SampleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;

namespace StoreApp.Migrations
{
    public class DummyData
    {
        public void Seed(SampleAppContext context)
        {
            context.Contacts.AddOrUpdate(
              p => p.Email, getData()
            );
        }

        private Contact[] getData()
        {
            return new Contact[] {
                new Contact { FirstName = "Baker", LastName = "Cameron", Email = "malesuada@IntegerurnaVivamus.org", Mobile = "(014622) 86899", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Carlos", LastName = "Vincent", Email = "Sed.eu@ultriciesornare.ca", Mobile = "0845 46 40", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Hammett", LastName = "Kinney", Email = "diam@Curabiturconsequat.com", Mobile = "(016977) 2181", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Jarrod", LastName = "Mcguire", Email = "condimentum.Donec@atvelitCras.edu", Mobile = "0937 920 5666", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Porter", LastName = "Osborn", Email = "nec@magna.edu", Mobile = "0900 242 4260", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Marvin", LastName = "Morgan", Email = "at.augue.id@lobortismaurisSuspendisse.co.uk", Mobile = "0904 982 1509", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Arden", LastName = "Johns", Email = "ut.sem@orci.ca", Mobile = "0819 942 0465", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Flynn", LastName = "Martin", Email = "vulputate@anequeNullam.ca", Mobile = "0826 693 0865", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Tate", LastName = "Nichols", Email = "auctor.velit.eget@erat.co.uk", Mobile = "0923 307 3589", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Boris", LastName = "Watson", Email = "Nulla.eu@eueuismod.ca", Mobile = "076 7031 4645", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Tiger", LastName = "Wilcox", Email = "natoque@egestaslacinia.co.uk", Mobile = "0845 46 42", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Dillon", LastName = "Wilkinson", Email = "est.ac.facilisis@sed.com", Mobile = "(0121) 702 2210", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Davis", LastName = "Young", Email = "mollis@tellusPhasellus.co.uk", Mobile = "070 6451 1407", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Hayes", LastName = "Maddox", Email = "mi.Aliquam.gravida@volutpatNullafacilisis.com", Mobile = "(01277) 11925", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Seth", LastName = "Diaz", Email = "erat.volutpat.Nulla@anunc.edu", Mobile = "(025) 6891 8275", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Wylie", LastName = "Woodard", Email = "sit.amet.orci@felis.edu", Mobile = "0800 295295", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Quinn", LastName = "Preston", Email = "in@nuncnulla.org", Mobile = "0994 607 6726", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Hamilton", LastName = "Walls", Email = "congue@nuncrisus.com", Mobile = "076 0370 1980", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Alden", LastName = "Kennedy", Email = "interdum.feugiat@iaculisodio.net", Mobile = "0800 966 0700", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Cullen", LastName = "Morris", Email = "magna@liberoIntegerin.net", Mobile = "056 3578 5226", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Wallace", LastName = "Ellison", Email = "pretium.aliquet.metus@nostraperinceptos.edu", Mobile = "0311 595 3683", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Bradley", LastName = "Martin", Email = "dapibus@idrisusquis.net", Mobile = "(016977) 0480", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Stuart", LastName = "Cooley", Email = "mollis.Duis@purusMaecenas.net", Mobile = "(01032) 257120", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Abel", LastName = "Hoffman", Email = "Nunc.laoreet@enim.org", Mobile = "(0141) 756 6221", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Jeremy", LastName = "Burton", Email = "Integer.mollis.Integer@egestasDuisac.net", Mobile = "(016977) 6954", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Kadeem", LastName = "Clark", Email = "magna.Suspendisse.tristique@eratvolutpat.net", Mobile = "0500 982112", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Ishmael", LastName = "Ramsey", Email = "aliquet.Proin@sed.edu", Mobile = "0800 754 3507", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Gannon", LastName = "Rodgers", Email = "sem@urnaVivamusmolestie.com", Mobile = "(016977) 3331", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Jack", LastName = "Fitzgerald", Email = "magna.a@pellentesquemassa.edu", Mobile = "(01864) 278788", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Hu", LastName = "Crawford", Email = "orci.Phasellus@montesnascetur.edu", Mobile = "0800 1111", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Prescott", LastName = "Franks", Email = "rhoncus.Nullam.velit@sitamet.net", Mobile = "0366 395 4915", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Kirk", LastName = "Griffin", Email = "Morbi.neque.tellus@enim.edu", Mobile = "055 6983 4434", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Troy", LastName = "Lynch", Email = "sem.eget@Integereulacus.co.uk", Mobile = "055 1457 8260", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Giacomo", LastName = "Bentley", Email = "ipsum@adipiscing.net", Mobile = "0500 178395", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Brent", LastName = "Delacruz", Email = "metus@ametornarelectus.co.uk", Mobile = "(01114) 951945", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Fuller", LastName = "Nicholson", Email = "sit.amet.ornare@mollis.org", Mobile = "055 9926 7697", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Travis", LastName = "Hobbs", Email = "ornare.lectus.ante@sem.edu", Mobile = "0500 697128", CreatedOn = DateTime.Now },
                new Contact { FirstName = "James", LastName = "Juarez", Email = "id@sapien.net", Mobile = "055 8228 4451", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Cooper", LastName = "Castro", Email = "Pellentesque@luctusfelispurus.org", Mobile = "0873 047 0816", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Mannix", LastName = "Stokes", Email = "tincidunt.pede@acsemut.org", Mobile = "0976 325 0791", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Lev", LastName = "Pittman", Email = "ullamcorper.eu.euismod@arcu.net", Mobile = "(012030) 87861", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Laith", LastName = "Houston", Email = "nibh.Donec@pulvinar.com", Mobile = "(0115) 161 7528", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Daniel", LastName = "Miles", Email = "adipiscing@quis.com", Mobile = "076 2948 1208", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Devin", LastName = "Glenn", Email = "viverra@iaculisaliquetdiam.net", Mobile = "0954 597 8687", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Price", LastName = "Harvey", Email = "eu.tempor.erat@vehicularisusNulla.co.uk", Mobile = "(012924) 73923", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Hakeem", LastName = "Morrow", Email = "tempor.lorem@tempus.co.uk", Mobile = "0845 46 42", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Dalton", LastName = "Goff", Email = "euismod.ac.fermentum@sedpede.com", Mobile = "(0131) 912 4157", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Chandler", LastName = "Powell", Email = "laoreet.ipsum.Curabitur@Duiscursus.com", Mobile = "070 5680 9418", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Branden", LastName = "Collier", Email = "non.enim.Mauris@mipedenonummy.net", Mobile = "0500 251804", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Keefe", LastName = "Schneider", Email = "lacus.varius.et@magna.net", Mobile = "(0191) 012 3116", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Levi", LastName = "Burnett", Email = "semper@ametanteVivamus.edu", Mobile = "076 3092 2160", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Thaddeus", LastName = "Erickson", Email = "iaculis@luctus.net", Mobile = "(01218) 763230", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Garrett", LastName = "Mcguire", Email = "non.magna.Nam@mi.ca", Mobile = "(016977) 5076", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Elliott", LastName = "Bean", Email = "vitae.semper@Nunc.org", Mobile = "0800 342658", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Alfonso", LastName = "Wilkerson", Email = "malesuada.id.erat@nisidictumaugue.com", Mobile = "(0141) 370 9780", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Vance", LastName = "Bauer", Email = "lobortis.quam@diamat.ca", Mobile = "(016977) 2569", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Kuame", LastName = "England", Email = "volutpat.Nulla.dignissim@lacusMaurisnon.co.uk", Mobile = "(0119) 763 7170", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Gavin", LastName = "Hines", Email = "in.consequat@non.edu", Mobile = "0800 447839", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Baker", LastName = "Raymond", Email = "felis.Nulla.tempor@magna.net", Mobile = "(0119) 489 5768", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Emery", LastName = "Morgan", Email = "arcu@lectus.ca", Mobile = "07624 139607", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Tanek", LastName = "Bryant", Email = "elit@Praesentinterdum.ca", Mobile = "056 1159 2586", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Chadwick", LastName = "Thornton", Email = "interdum.ligula@enimcommodo.ca", Mobile = "(010282) 90771", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Lyle", LastName = "Hansen", Email = "eros.nec.tellus@in.ca", Mobile = "055 7954 5527", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Connor", LastName = "Mckay", Email = "Praesent.eu.nulla@ultricessitamet.ca", Mobile = "055 7447 3512", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Camden", LastName = "Watkins", Email = "ligula@mitemporlorem.co.uk", Mobile = "(029) 4565 1783", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Luke", LastName = "Horton", Email = "Curae.Phasellus.ornare@sapienmolestieorci.edu", Mobile = "07624 726114", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Elliott", LastName = "King", Email = "placerat.eget@orcitincidunt.ca", Mobile = "0910 658 9280", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Elmo", LastName = "Huffman", Email = "porttitor.interdum@disparturient.ca", Mobile = "0845 46 47", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Chaney", LastName = "Farrell", Email = "arcu@elit.org", Mobile = "(0113) 270 3815", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Gavin", LastName = "Marquez", Email = "Donec.tincidunt@liberoettristique.co.uk", Mobile = "0845 46 41", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Dante", LastName = "Horne", Email = "Donec.dignissim.magna@lectusNullamsuscipit.net", Mobile = "(021) 2007 5518", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Michael", LastName = "Hicks", Email = "ultrices@musProinvel.com", Mobile = "(016977) 4433", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Graiden", LastName = "Foreman", Email = "dictum@Integerinmagna.net", Mobile = "076 5077 3980", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Moses", LastName = "Brady", Email = "leo@nonummyFusce.co.uk", Mobile = "0369 458 2494", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Francis", LastName = "Wiley", Email = "nec@placerat.org", Mobile = "0500 327049", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Colin", LastName = "Chan", Email = "urna.justo.faucibus@ornare.com", Mobile = "(01816) 050941", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Baker", LastName = "Ashley", Email = "Vivamus@elit.co.uk", Mobile = "055 2656 6260", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Ira", LastName = "Hammond", Email = "quam.Pellentesque.habitant@montesnascetur.edu", Mobile = "076 9528 1000", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Levi", LastName = "Sanford", Email = "Proin.sed.turpis@maurisutmi.ca", Mobile = "055 2520 6656", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Connor", LastName = "Banks", Email = "consequat.lectus.sit@vestibulum.com", Mobile = "056 3847 9893", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Erasmus", LastName = "Drake", Email = "orci@erat.net", Mobile = "(016977) 8787", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Lucius", LastName = "Gilliam", Email = "at.pretium.aliquet@vel.edu", Mobile = "0987 332 8657", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Richard", LastName = "Burns", Email = "a@cursusNunc.org", Mobile = "(01604) 86654", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Nigel", LastName = "Noel", Email = "turpis.Nulla@Nullaeuneque.org", Mobile = "0800 1111", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Neville", LastName = "Chang", Email = "Donec.elementum.lorem@magnaDuisdignissim.edu", Mobile = "0905 429 2612", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Gabriel", LastName = "Harper", Email = "dignissim.tempor@Utsagittis.ca", Mobile = "07914 988104", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Drake", LastName = "Justice", Email = "velit@sociosquadlitora.ca", Mobile = "0975 825 3824", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Leroy", LastName = "Beasley", Email = "faucibus.lectus.a@nuncestmollis.com", Mobile = "0845 46 44", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Zachery", LastName = "Holden", Email = "lectus.pede.et@dignissimlacusAliquam.co.uk", Mobile = "0500 935157", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Gannon", LastName = "Gonzalez", Email = "consequat@massarutrummagna.ca", Mobile = "0380 291 4207", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Allen", LastName = "Gonzales", Email = "gravida.non@luctusetultrices.edu", Mobile = "0500 782567", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Luke", LastName = "Kirby", Email = "leo.Morbi.neque@aliquamiaculis.edu", Mobile = "07624 018388", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Sylvester", LastName = "Carr", Email = "nec@nibhlaciniaorci.com", Mobile = "055 9783 1478", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Harper", LastName = "Parrish", Email = "est.mollis.non@eulacus.co.uk", Mobile = "0800 1111", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Jarrod", LastName = "Patterson", Email = "malesuada.fames.ac@blanditatnisi.co.uk", Mobile = "0800 1111", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Knox", LastName = "Daniel", Email = "parturient.montes.nascetur@sodalesnisimagna.net", Mobile = "076 5669 3935", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Vincent", LastName = "Walker", Email = "Nam@Donecluctus.ca", Mobile = "0846 721 5065", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Nigel", LastName = "Price", Email = "malesuada.fames.ac@bibendum.ca", Mobile = "0845 46 43", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Adam", LastName = "Noble", Email = "ante.Nunc.mauris@quisdiam.ca", Mobile = "0500 200409", CreatedOn = DateTime.Now },
                new Contact { FirstName = "Roth", LastName = "Gonzales", Email = "tempus.scelerisque.lorem@viverraDonec.ca", Mobile = "0800 510 6789", CreatedOn = DateTime.Now }
            };
        }
    }
}