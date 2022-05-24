using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Linq;

namespace FileSysSim
{
    class Simulaator
    {
        public List<Fail> Failid { get; } 
        public List<List<Fail>> Sammud { get; }
        public string Arvutus { get; set; }

        private List<Fail> AktiivneSamm { get; set; }
        private readonly Color[] colors;
        private string colorNameCorr;
        private readonly Dictionary<String, int> failideHulk;

        public Simulaator()
        {
            Failid = new List<Fail>();
            AktiivneSamm = new List<Fail>();
            for (int i = 0; i < 48; i++) AktiivneSamm.Add(new Fail());
            Sammud = new List<List<Fail>>();
            Arvutus = "";
            failideHulk = new Dictionary<string, int>();
            colors = new Color[10] { Color.DarkRed,  Color.Red, Color.Orange, Color.Yellow,
                                     Color.Green, Color.SpringGreen, Color.Cyan, Color.Blue,
                                     Color.CadetBlue, Color.BlueViolet};
            colorNameCorr = "";
        }

        public void Simuleeri()
        {
            for (int samm = 0; samm < Failid.Count; samm++)
            {
                Fail uusFail = Failid[samm];
                if (uusFail.Operatsioon == null || uusFail.Operatsioon.Equals("+"))
                {
                    // Add new file to the list
                    for (int i = 0; i < AktiivneSamm.Count; i++)
                    {
                        if (uusFail.Remaining == 0) break;
                        Fail vaadeldav = AktiivneSamm[i];
                        if (vaadeldav.OnNull)
                        {
                            AktiivneSamm[i] = uusFail;
                            uusFail.Remaining--;
                        }
                    }
                    if (uusFail.Remaining > 0)
                    {
                        // Fail ei mahu 
                        var finalBlocks = new List<Fail>();
                        for (int k = 0; k < 48; k++) finalBlocks.Add(new Fail("x", -1, null, Color.Black));
                        Sammud.Add(finalBlocks);
                        return;
                    }

                }
                else if (uusFail.Operatsioon.Equals("-"))
                {
                    if (failideHulk.ContainsKey(uusFail.Nimi)) failideHulk.Remove(uusFail.Nimi);

                    // Remove file from list
                    for (int i = 0; i < AktiivneSamm.Count; i++)
                    {
                        Fail vaadeldav = AktiivneSamm[i];
                        if (vaadeldav.OnNull) continue;

                        if (vaadeldav.Nimi.Equals(uusFail.Nimi))
                        {
                            AktiivneSamm[i] = new Fail();
                        }
                    }
                }

                // Add the current state to all steps
                var sammBlocks = new List<Fail>();
                foreach (var Fail in AktiivneSamm) sammBlocks.Add(Fail);
                Sammud.Add(sammBlocks);
            }

            Arvuta();
        }

        private void Arvuta()
        {
            List<string> allesJaanudStr = new List<string>();
            foreach (Fail f in Sammud[^1]) { if (!f.OnNull) allesJaanudStr.Add(f.Nimi); }

            int totalFiles = failideHulk.Count;
            int totalRuum = allesJaanudStr.Count;
            int fragRuum = 0;
            int fragFiles = 0;

            foreach (string f in allesJaanudStr.Distinct())
            {
                int vastavF = failideHulk[f];
                if (Math.Abs(allesJaanudStr.LastIndexOf(f) - allesJaanudStr.IndexOf(f)) + 1 != vastavF)
                {
                    fragFiles++;
                    fragRuum += vastavF;
                }
            }
            Arvutus = String.Format("Allesjäänud failidest on fragmenteerunud {0:0.0#}%. Fragmenteerunud failidele kuulub {1:0.0#}% kasutatud ruumist.",
                (fragFiles * 1.0 / totalFiles) *100, (fragRuum * 1.0 / totalRuum) *100);
        }

        public void LoadFromString(string str)
        {

            String[] failid;
            try { failid = str.Trim().Split(';'); } 
            catch (FormatException) { throw; }

            foreach (string fail in failid)
            {
                string[] failiOsad = fail.Split(',');

                string failiNimi = failiOsad[0];
                if (!colorNameCorr.Contains(failiNimi)) colorNameCorr += failiNimi;
                string info = failiOsad[1];
                if (info.Equals("-"))
                {
                    // Ploki Eemaldamine [A,-]
                    Failid.Add(new Fail(failiNimi, -1, "-", colors[colorNameCorr.IndexOf(failiNimi)]));
                }
                else if (info[0].Equals('+'))
                {
                    // Ploki suurendamine [A,+3]
                    Failid.Add(new Fail(failiNimi, int.Parse(info.Substring(1)), "+", colors[colorNameCorr.IndexOf(failiNimi)]));
                    failideHulk[failiNimi] += int.Parse(info.Substring(1));
                }
                else
                {
                    // Ploki lisamine [A,5]
                    Failid.Add(new Fail(failiNimi, int.Parse(info), null, colors[colorNameCorr.IndexOf(failiNimi)]));
                    failideHulk.TryAdd(failiNimi, int.Parse(info));
                }
            }
        }

        public void Clear()
        {
            Failid.Clear();
            AktiivneSamm.Clear();
            for (int i = 0; i < 48; i++) AktiivneSamm.Add(new Fail());
            Sammud.Clear();
            Arvutus = "";
            colorNameCorr = "";
            failideHulk.Clear();
        }
    }
}
