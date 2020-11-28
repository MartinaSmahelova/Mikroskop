using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Mikroskop
{
    class Mikroskop
    {
       // 1. Ovládanie Komory
       // Pomocná premenná pre otvorenie/zatvorenie komory.
        private bool jeKormoraOtevrena;

        /// <summary>
        /// Otevření komory mikroskopu.
        /// </summary>
        public bool OtevritKomoru()
        {
            return jeKormoraOtevrena = true;  
        }

        /// <summary>
        /// Zatvoření komory mikroskopu. 
        /// </summary>
        public bool UzavritKomoru()
        {
            return jeKormoraOtevrena = false;
        }

        /// <summary>
        /// Overenie toho, či je možné komoru otvoriť.
        /// Používané pri tlačítkach a riadení ich klikateľnosti.
        /// </summary>
        /// <returns></returns>
        public bool JeMozneOtevritKomoru()
        {
            if (tlakVKomore == 101325 && tlakVTubusu == 101325 && !jeKormoraOtevrena)
                return true;
     
            else if (tlakVKomore == 10 && tlakVTubusu == 10)
                return false;

            else
                return false;
        }

        /// <summary>
        /// Overenie toho, či je možné komoru zatvoriť.
        /// Používané pri tlačítkach a riadení ich klikateľnosti.
        /// </summary>
        /// <returns></returns>
        public bool JeMozneUzavritKomoru()
        {
            if (tlakVKomore == 101325 && tlakVTubusu == 101325 && jeKormoraOtevrena)
                return true;
            else
                return false;
        }


        //2. Ovládanie Vákua 
        //Napustená komora má tlak 101325 Pascalov (Pa).
        public int tlakVKomore = 101325;
        public int tlakVTubusu = 101325;
        //Random pre simuláciu vyčerpávania a napúšťania vzduchu do komory
        Random random = new Random();

        /// <summary>
        /// Meranie tlaku v komore mikroskopu.
        /// </summary>
        /// <returns></returns>
        public int ZmerTlakVKomore()
        {
            if (tlakVKomore < 5000)
                return tlakVKomore = 10;

            else if (tlakVKomore > 96500)
                return tlakVKomore = 101325;

            else
                return tlakVKomore;
        }

        /// <summary>
        /// Meranie tlaku v tubuse mikroskopu.
        /// </summary>
        /// <returns></returns>
        public int ZmertlakVTubusu()
        {
            if (tlakVTubusu < 5000)
                return tlakVTubusu = 10;

            else if (tlakVTubusu > 96500)
                return tlakVTubusu = 101325;

            else
                return tlakVTubusu;
        }

        /// <summary>
        /// Vyčerpanie vzduchu z komory a tubusu mikroskopu.
        /// Po vyčerpaní je v komore aj tubuse mikroskopu 10 Pascalov (Pa).
        /// </summary>
        public void VycerpatVzduchZKomoryATubusu()
        {
            UzavritKomoru();
                
            tlakVKomore -= 5000;
            tlakVTubusu -= 4990;

            tlakVKomore = random.Next(tlakVKomore, tlakVTubusu);
            tlakVTubusu = random.Next(tlakVKomore, tlakVTubusu);
            
            ZmerTlakVKomore();
            ZmertlakVTubusu();
        }

        /// <summary>
        /// Napustenie vzduchu do komory a tubusu mikroskopu.
        /// Po napustení je v komore aj tubuse mikroskopu 101325 Pascalov (Pa).
        /// </summary>
        public void NapustitVzduchDoKomoryATubusu()
        {
            VypnoutNapajeniZdrojeElektronu();

            tlakVKomore += 5000;
            tlakVTubusu += 4990;

            tlakVKomore = random.Next(tlakVTubusu, tlakVKomore);
            tlakVTubusu = random.Next(tlakVTubusu, tlakVKomore);

            ZmerTlakVKomore();
            ZmertlakVTubusu();
        }

        /// <summary>
        /// Overenie možnosti vyčerpať vzduch z komory a tubusu mikroskopu.
        /// Používané pri tlačítkach a riadení ich klikateľnosti.
        /// </summary>
        /// <returns></returns>
        public bool JeMozneVycerpatVzduchZKomoryATubusu()
        {
            if (tlakVKomore == 101325 && tlakVTubusu == 101325 && !jeKormoraOtevrena)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Overenie možnosti napustiť vzduch do komory a tubusu mikroskopu. 
        /// Používané pri tlačítkach a riadení ich klikateľnosti.
        /// </summary>
        /// <returns></returns>
        public bool JeMozneNapustitVzduchDoKomoryATubusu()
        {
            if (tlakVKomore == 10 && tlakVTubusu == 10 && !jeKormoraOtevrena)
                return true;
            else
                return false;
        }


       //3. Ovládanie zvazku elektrónov
       //Pomocná premenná pri zapnutí/vypnutí napájania zdroja mikroskopu.
        bool JeZapnuteNapajeniZdrojuMikroskopu;

        /// <summary>
        /// Zapnutie napájania zdroja mikroskopu.
        /// </summary>
        /// <returns></returns>
        public bool ZapnoutNapajeniZdrojeElektronu()
        {
            if (tlakVKomore == 10 && tlakVTubusu == 10)
                return JeZapnuteNapajeniZdrojuMikroskopu = true;
            else
                return false;
        }

        /// <summary>
        /// Vypnutie napájania zdroja mikroskopu.
        /// </summary>
        /// <returns></returns>
        public bool VypnoutNapajeniZdrojeElektronu()
        {
            return JeZapnuteNapajeniZdrojuMikroskopu = false;
        }

        /// <summary>
        /// Overnie možnosti zapnúť napájanie zdroja elektronov.
        /// Používané pri checkboxe a riadení jeho klikateľnosti.
        /// </summary>
        /// <returns></returns>
        public bool JeMozneZapnutNapajeniZdrojuElektornu()
        {
            if (tlakVKomore == 10 && tlakVTubusu == 10 && JeZapnuteNapajeniZdrojuMikroskopu)
                return true;
            else
                return false;
        }


        /// <summary>
        /// Meranie urýchľovača napatia. 
        /// </summary>
        public int Napeti;
        public int ZmerUrychlovaciNapeti()
        {
            if (Napeti >= 25)
                return Napeti = 25;
         
            else if (Napeti <= 0)
                return Napeti = 0;
           
            else
                return Napeti;
        }

        /// <summary>
        /// Nastavenie urýchlovača napatie.
        /// Nadobúda hodnoty v rozmedzí od 0 do 25 vrátane.
        /// </summary>
        /// <param name="napeti"></param>
        /// <returns></returns>
        public int NastavUrychlovaciNapeti(int napeti)
        {
            Napeti = napeti;

            ZmerUrychlovaciNapeti();
            return Napeti;     
        }


        //4. Pracovná vzdialenosť 
        int PracovniVzdalenost;

        /// <summary>
        /// Meranie pracovnej vzdilenosti.
        /// </summary>
        /// <returns></returns>
        public int ZmerPracovniVzdalenost()
        {
            if (PracovniVzdalenost >= 10)
                return PracovniVzdalenost = 10;
           
            else if (PracovniVzdalenost <= 0)
                return PracovniVzdalenost = 0;

            else
                return PracovniVzdalenost;
        }

        /// <summary>
        /// Nastavenie pracovnej vzdialenosti.
        /// Nadobúda hodnoti 1 až 10 vrátane.
        /// </summary>
        /// <param name="pracovniVzdalenos"></param>
        public int NastavPracovniVzdalenost(int pracovniVzdalenos)
        {
            PracovniVzdalenost = pracovniVzdalenos;

            ZmerPracovniVzdalenost();
            return PracovniVzdalenost;
        }

       // 5. Deterktory mikroskopu 
        public string NazevDetektoru;

        /// <summary>
        /// Vyber detektoru.
        /// z možnosti "SED" alebo "BSED".
        /// </summary>
        /// <returns></returns>
        public string VybranyDetektor()
        {
            if (NazevDetektoru == "SED")
                return NazevDetektoru = "SED";

            else if (NazevDetektoru == "BSED")
                return NazevDetektoru = "BSED";

            else
                return "";
        }

        /// <summary>
        /// Vyber detektoru.
        /// z možnosti "SED" alebo "BSED".
        /// </summary>
        /// <returns></returns>
        public void VyberDetektor(string nazevDetektoru)
        {
            NazevDetektoru = nazevDetektoru;

            VybranyDetektor();
        }

        /// <summary>
        /// Overenie toho, či je možné použiť detektor SED.
        /// Používané pri tlačítkach a riadení ich klikateľnosti.
        /// </summary>
        /// <returns></returns>
        public bool JeMoznePouzitSED()
        {
            if (JeZapnuteNapajeniZdrojuMikroskopu && Napeti > 0 && NazevDetektoru == "BSED")
                return true;
            else
                return false;

        }

        /// <summary>
        /// Overenie toho, či je možné použiť detektor BSED.
        /// Používané pri tlačítkach a riadení ich klikateľnosti.
        /// </summary>
        /// <returns></returns>
        public bool JeMoznePouzitBSED()
        {
            if (JeZapnuteNapajeniZdrojuMikroskopu && Napeti > 0 && NazevDetektoru == "SED")
                return true;
            else
                return false;
        }

        //6. Skenování vzorku 
        /// <summary>
        /// Skenovanie vzorku mikroskopu.
        /// </summary>
        /// <returns></returns>
        public Image NaskenujVzorekMikroskopu()
        {
            if (jeKormoraOtevrena == false && tlakVKomore == 10 && tlakVTubusu == 10
                && JeZapnuteNapajeniZdrojuMikroskopu && Napeti > 0 && PracovniVzdalenost >= 5 
                && NazevDetektoru == "SED")
            {
                return Properties.Resources.obrazek_SED_ostry;
            }

            else if (jeKormoraOtevrena == false && tlakVKomore == 10 && tlakVTubusu == 10
                 && JeZapnuteNapajeniZdrojuMikroskopu && Napeti > 0 && PracovniVzdalenost < 5 
                 && NazevDetektoru == "SED")
            {
                return Properties.Resources.obrazek_SED_rozostreny;
            }

            else if (jeKormoraOtevrena == false && tlakVKomore == 10 && tlakVTubusu == 10
                 && JeZapnuteNapajeniZdrojuMikroskopu && Napeti > 0 && PracovniVzdalenost >= 5 
                 && NazevDetektoru == "BSED")
            {
                return Properties.Resources.obrazek_BSED_ostry;
            }

            else if (jeKormoraOtevrena == false && tlakVKomore == 10 && tlakVTubusu == 10
                 && JeZapnuteNapajeniZdrojuMikroskopu && Napeti > 0 && PracovniVzdalenost < 5 
                 && NazevDetektoru == "BSED")
            {
                return Properties.Resources.obrazek_BSED_rozostreny;
            }

            else
            {
                return null;
            }
        }

    }

}

   

