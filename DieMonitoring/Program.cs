using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DieMonitoring
{
    static class Program
    {
        private static Font bigfont;
        private static Font titlefont;
        private static Font descriptionfont;
        private static Font normalfont;

        public static Font TitleFont { get => titlefont; }
        public static Font BigFont { get => bigfont; }
        public static Font DescriptionFont { get => descriptionfont; }
        public static Font Normalfont { get => normalfont; }

        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {

            PrivateFontCollection privateFonts = new PrivateFontCollection();


            //폰트명이 아닌 폰트의 파일명을 적음
            privateFonts.AddFontFile("Resources/GodoM.ttf");


            Font font = new Font(privateFonts.Families[0], 30f);
            bigfont = font;
            font = new Font(privateFonts.Families[0], 24f);
            titlefont = font;
            font = new Font(privateFonts.Families[0], 20f);
            normalfont = font;
            font = new Font(privateFonts.Families[0], 14f);
            descriptionfont = font;
          



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MonitoringForm());
        }
    }
}
