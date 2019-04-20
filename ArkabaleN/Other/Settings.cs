using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkabaleN.Settings
{
    internal class Settings
    {
        public static DateTime update = new DateTime(2019, 04, 19);

        public static GlowSettings GlowEsp = new GlowSettings();
        public class GlowSettings
        {
            public GlowSettings()
            {
                Enabled = false;
                ShowEnemy = true;
                ShowTeam = true;
                ShowHealth = false;
                Red = 60;
                Green = 25;
                Blue = 234;
                Opacity = 254;
            }
            public bool Enabled { get; set; }
            public bool ShowEnemy { get; set; }
            public bool ShowTeam { get; set; }
            public bool ShowHealth { get; set; }
            public float Red { get; set; }
            public float Green { get; set; }
            public float Blue { get; set; }
            public float Opacity { get; set; }
        }
    }
}
