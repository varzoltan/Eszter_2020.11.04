using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Eszter_2020._11._04
{
    class Program
    {
        //Struktúra létrehozásának szabályai
        //1: az osztályon belül, de a main-en kívül hozom létre
        //2: a struct névvel hivatkozunk a struktúrára
        //3: adunk neki egy nevet: bármi lehet, kivéve foglaltszó, kulcsszó
        //4: Nincsenek paraméterei
        //5: Van elje, van vége: {  }
        //6: Adattagokkal kell felruházni
        //7: kötelezően példányosítani kell a main (főprogramban), ahhoz, hogy elérhessük az adattagjait.

        struct Adat
        {
            //adattagok jönnek ide, láthatósággal
            public int szamok;
            public string szavak;
        }

        static void Main(string[] args)
        {
            //Példányosítom a struktúrámat!
            Adat[] Elso_struktura = new Adat[20];
            StreamReader beolvas = new StreamReader(@"C:\Users\Rendszergazda\Downloads\eszter_beolvas.txt");
            int szamlalo = 0;
            while (!beolvas.EndOfStream)
            {
                string sor = beolvas.ReadLine();
                //Létrehozunk egy dinamikus tömböt, majd az elválasztó mentén belrekjuk a tömb megfelelő indexébe
                //Csak String tömbbe tudom beletenni!
                string[] db = sor.Split(' ');//Darabolunk valamilyen karakter mentén!
                Elso_struktura[szamlalo].szamok = int.Parse(db[0]);
                Elso_struktura[szamlalo].szavak = db[1];
                szamlalo++;
            }
            beolvas.Close();

            Console.ReadKey();
        }
    }
}
