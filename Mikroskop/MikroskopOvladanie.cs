using System;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.Remoting.Channels;

namespace Mikroskop
{
    public partial class MikroskopOvladanie : Form
    {
        public MikroskopOvladanie()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           mikroskop.OtevritKomoru();
           NastaveniJednotlivychTlacitiek();
           OvladaciPrvkyNapojeneNaZapnutiVypnutiNapajeni();
        }

        /// <summary>
        /// Nastavenie ovládacích prvkov vo formuláry podľa logiky práce s mikroskopom. 
        /// Nastavuje klikateľnosť jednotlivých tlačítiek a checkboxu. 
        /// Mení farbu tlačítka keď je v stave disabled. 
        /// </summary>
        private void NastaveniJednotlivychTlacitiek()
        {
            btnKomoruOtevrit.Enabled = mikroskop.JeMozneOtevritKomoru();
            btnKomoruZavzdusnit.Enabled = mikroskop.JeMozneNapustitVzduchDoKomoryATubusu();
            btnKomoruVycerpat.Enabled = mikroskop.JeMozneVycerpatVzduchZKomoryATubusu();
            checkBoxNapajeni.Enabled = mikroskop.JeMozneZapnutNapajeniZdrojuElektornu();

            if (!btnKomoruOtevrit.Enabled)
                btnKomoruOtevrit.BackColor = Color.FromArgb(118,118,118);

            if (btnKomoruOtevrit.Enabled)
                btnKomoruOtevrit.BackColor = Color.FromArgb(51, 153, 204);

            if (!btnKomoruZavrit.Enabled)
                btnKomoruZavrit.BackColor = Color.FromArgb(118, 118, 118);

            if (btnKomoruZavrit.Enabled)
                btnKomoruZavrit.BackColor = Color.FromArgb(51, 153, 204);

            if (!btnKomoruZavzdusnit.Enabled)
                btnKomoruZavzdusnit.BackColor = Color.FromArgb(118, 118, 118);

            if (btnKomoruZavzdusnit.Enabled)
                btnKomoruZavzdusnit.BackColor= Color.FromArgb(51, 153, 204);

            if (!btnKomoruVycerpat.Enabled)
                btnKomoruVycerpat.BackColor = Color.FromArgb(118, 118, 118);

            if (btnKomoruVycerpat.Enabled)
                btnKomoruVycerpat.BackColor = Color.FromArgb(51, 153, 204);
        }
        Mikroskop mikroskop = new Mikroskop();

        /// <summary>
        /// Tlačítko pre uzavretie komory. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKomoruZavrit_Click(object sender, EventArgs e)
        {
            mikroskop.UzavritKomoru();
            btnKomoruZavrit.Enabled = mikroskop.JeMozneUzavritKomoru();
            NastaveniJednotlivychTlacitiek();
        }

        /// <summary>
        /// Tlačítko pre otvorenie komory. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKomoruOtevrit_Click(object sender, EventArgs e)
        {
            mikroskop.OtevritKomoru();
            btnKomoruZavrit.Enabled = mikroskop.JeMozneUzavritKomoru();
            NastaveniJednotlivychTlacitiek(); 
        }

        /// <summary>
        /// tlačítko pre Vyčerpanie vzuchu z komory. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKomoruVycerpat_Click(object sender, EventArgs e)
        {
            timerKomoruVycerpat.Start();   
        }

        /// <summary>
        /// Timer naviazaný na vyčerpanie vzduchu z komory. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerKomoruVycerpat_Tick(object sender, EventArgs e)
        {
            
            if (mikroskop.tlakVKomore > 10 && mikroskop.tlakVTubusu > 10)
            {
                NastaveniJednotlivychTlacitiek();

                picBoxVizualizace.Image = Properties.Resources.mikroskop_se_vzduchem_anim;

                mikroskop.VycerpatVzduchZKomoryATubusu();

                lblTlakVKomore.Text = mikroskop.tlakVKomore.ToString();
                lblTlakVTubuse.Text = mikroskop.tlakVTubusu.ToString();
            }
            else
            {
                picBoxVizualizace.Image = Properties.Resources.mikroskop_bez_vzduchu;

                timerKomoruVycerpat.Stop();

                mikroskop.ZapnoutNapajeniZdrojeElektronu();
                NastaveniJednotlivychTlacitiek();
            }
        }

        /// <summary>
        /// Tlačítko pre zavdušnenie komory. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKomoruZavzdusnit_Click(object sender, EventArgs e)
        {
            NastaveniJednotlivychTlacitiek(); 
            timerKomoruZavzdusnit.Start();

            picBoxVizualizace.Image = Properties.Resources.mikroskop_bez_vzduchu;
        }

        /// <summary>
        /// Timer naviazaný na zavzušnenie komory. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerKomoruZavzdusnit_Tick(object sender, EventArgs e)
        {
            mikroskop.VypnoutNapajeniZdrojeElektronu();
            OvladaciPrvkyNapojeneNaZapnutiVypnutiNapajeni();
            VynulovanieTrackBarov();

            NastaveniJednotlivychTlacitiek();

            if (mikroskop.tlakVKomore < 96000 && mikroskop.tlakVTubusu < 96000)
            {
                picBoxVizualizace.Image = Properties.Resources.mikroskop_bez_vzduchu_anim;

                mikroskop.NapustitVzduchDoKomoryATubusu();

                lblTlakVKomore.Text = mikroskop.tlakVKomore.ToString();
                lblTlakVTubuse.Text = mikroskop.tlakVTubusu.ToString();
            }

            else
            {
                picBoxVizualizace.Image = Properties.Resources.mikroskop_se_vzduchem;

                timerKomoruZavzdusnit.Stop();

                NastaveniJednotlivychTlacitiek();
            }
        }

        /// <summary>
        /// Ovládanie detektorov SED a BSED pomocou tlačítok. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDetektory_Click(object sender, EventArgs e)
        {
            Button btnDetektory = sender as Button;

            mikroskop.VyberDetektor(btnDetektory.Text.ToString());
            picBoxObraz.Image = mikroskop.NaskenujVzorekMikroskopu();

            if (mikroskop.NazevDetektoru == "SED" && mikroskop.Napeti > 0)
            {
                picBoxVizualizace.Image = Properties.Resources.mikroskop_se_svazkem_SED;
                btnSED.Enabled = mikroskop.JeMoznePouzitSED();
                btnBSED.Enabled = mikroskop.JeMoznePouzitBSED();
            }

            else if (mikroskop.NazevDetektoru == "BSED" && mikroskop.Napeti > 0)
            {
                picBoxVizualizace.Image = Properties.Resources.mikroskop_se_svazkem_BSED;
                btnBSED.Enabled = false;
                btnSED.Enabled = true;
            }

            if (!btnBSED.Enabled)
                btnBSED.BackColor = Color.FromArgb(118, 118, 118);

            if (btnBSED.Enabled)
                btnBSED.BackColor = Color.FromArgb(51, 153, 204);

            if (!btnSED.Enabled)
                btnSED.BackColor = Color.FromArgb(118, 118, 118);

            if (btnSED.Enabled)
                btnSED.BackColor = Color.FromArgb(51, 153, 204);
        }

        /// <summary>
        /// Ovládanie Pracovnej vzdalenosti a Urýchlovača napatia pomocí trackbarov. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBary_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBary = sender as TrackBar;

            if (trackBarUrychlovavNapeti.Capture)
            {
                mikroskop.NastavUrychlovaciNapeti(trackBary.Value);
                lblUrychlovacNapeti.Text = trackBary.Value.ToString();
            }

            else if (trackBarPracovniVzdalenst.Capture)
            {
                mikroskop.NastavPracovniVzdalenost(trackBary.Value);
                lblPracovniVzdálenost.Text = trackBary.Value.ToString();
                picBoxObraz.Image = mikroskop.NaskenujVzorekMikroskopu();
            }
            
        }

        /// <summary>
        /// trackBarUrychlovavNapeti,trackBarPracovniVzdalenst, btnBSED, btnSED a picBoxObraz.
        /// Súvisia s napájaním zdroja elektrónov. 
        /// Urýchlovač napatia, nastavenie pracovnej vzdialenosti a detektory 
        /// je možné používať len pokiaľ je zapnuté napájanie zdroja elektrónov.
        /// </summary>
        private void OvladaciPrvkyNapojeneNaZapnutiVypnutiNapajeni()
        {
            trackBarUrychlovavNapeti.Enabled = mikroskop.JeMozneZapnutNapajeniZdrojuElektornu();
            trackBarPracovniVzdalenst.Enabled = mikroskop.JeMozneZapnutNapajeniZdrojuElektornu();
            btnBSED.Enabled = mikroskop.JeMozneZapnutNapajeniZdrojuElektornu();
            btnSED.Enabled = mikroskop.JeMozneZapnutNapajeniZdrojuElektornu();
            picBoxObraz.Image = mikroskop.NaskenujVzorekMikroskopu();

            if (!btnBSED.Enabled)
                btnBSED.BackColor = Color.FromArgb(118, 118, 118);

            if (btnBSED.Enabled)
                btnBSED.BackColor = Color.FromArgb(51, 153, 204);

            if (!btnSED.Enabled)
                btnSED.BackColor = Color.FromArgb(118, 118, 118);

            if (btnSED.Enabled)
                btnSED.BackColor = Color.FromArgb(51, 153, 204);

        }

        /// <summary>
        /// Vyulovanie urýchlovača napatia a pracovnej vzdialenosti.
        /// K vynulovaniu dochádza pokiaľ je vypnuté napájanie zdroja elektrónov. 
        /// </summary>
        private void VynulovanieTrackBarov()
        {
            trackBarUrychlovavNapeti.Value = mikroskop.NastavUrychlovaciNapeti(0);
            lblUrychlovacNapeti.Text = trackBarUrychlovavNapeti.Value.ToString();
            trackBarPracovniVzdalenst.Value = mikroskop.NastavPracovniVzdalenost(0);
            lblPracovniVzdálenost.Text = trackBarPracovniVzdalenst.Value.ToString();
        }

        /// <summary>
        /// Ovládanie Napájanie zdroja elektrónov pomocou CheckBoxu. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxNapajeni_Click(object sender, EventArgs e)
        {
            
            if (checkBoxNapajeni.Checked)
            {   
                mikroskop.ZapnoutNapajeniZdrojeElektronu();
                OvladaciPrvkyNapojeneNaZapnutiVypnutiNapajeni();
                
                picBoxVizualizace.Image = Properties.Resources.mikroskop_se_svazkem;
            }

            else
            {
                mikroskop.VypnoutNapajeniZdrojeElektronu();
                OvladaciPrvkyNapojeneNaZapnutiVypnutiNapajeni();
                VynulovanieTrackBarov();

                picBoxVizualizace.Image = Properties.Resources.mikroskop_bez_vzduchu;
            }
            
        }
    }
}
