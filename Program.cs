using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace Proyecto_Final___Wingo
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 
        //C:\Users\matia\OneDrive\Escritorio\d\bin\Debug
        static string[] partsPath = AppDomain.CurrentDomain.BaseDirectory.Split(System.IO.Path.DirectorySeparatorChar);
        static List<string> projectPath = new List<string>(partsPath);
        static public string pathConfig;
        static public PrivateFontCollection pfc = new PrivateFontCollection();
        static public string pathFont;
        static public System.Drawing.Font titles;
        static public System.Drawing.Font enviarConfig;
        static public System.Drawing.Font labels;
        static public System.Drawing.Font buttons;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            pathConfig = "";
            foreach (string folder in projectPath)
            {
                if (folder != "bin" && folder != "Debug")
                {
                    if (!string.IsNullOrEmpty(pathConfig))
                    {
                        pathConfig += System.IO.Path.DirectorySeparatorChar;
                    }

                    pathConfig += folder;
                }
            }
            pathFont = pathConfig;
            pathConfig += "config.txt";
            pfc.AddFontFile(pathFont + "SFSportsNight.ttf");
            pfc.AddFontFile(pathFont + "SpeedAttackDemoRegular.ttf");
            pfc.AddFontFile(pathFont + "ShadowsIntoLight-Regular.ttf");
            pfc.AddFontFile(pathFont + "Better-Faster.ttf");
            List<string> fontFamilies = pfc.Families.Select(f => f.Name).ToList();
            fontFamilies.Sort();
            titles = new System.Drawing.Font(pfc.Families[fontFamilies.IndexOf("SF Sports Night")], 25f);
            enviarConfig = new System.Drawing.Font(pfc.Families[fontFamilies.IndexOf("Speed Attack Demo")],13f);
            labels = new System.Drawing.Font(pfc.Families[fontFamilies.IndexOf("Shadows Into Light")], 15f);
            buttons = new System.Drawing.Font(pfc.Families[fontFamilies.IndexOf("Better Faster")], 13f);

            Application.Run(new Pantalla_principal());
        }
    }
}
