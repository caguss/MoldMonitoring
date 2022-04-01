using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DieMonitoring
{
    static class Program
    {
        private static string serverName;
        private static string port;
        private static string databaseName;
        private static string uid;
        private static string pwd;

        public static string ServerName { get => serverName; set => serverName = value; }
        public static string DatabaseName { get => databaseName; set => databaseName = value; }
        public static string Uid { get => uid; set => uid = value; }
        public static string Pwd { get => pwd; set => pwd = value; }
        public static string Port { get => port; set => port = value; }

        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                XmlDocument xml = new XmlDocument();
                xml.Load($"{Environment.CurrentDirectory}\\Resources\\Connection.xml");
                XmlNodeList xmlList = xml.SelectNodes("/root");
                foreach (XmlNode xnl in xmlList)
                {
                    serverName = xnl["server"].InnerText;
                    port = xnl["port"].InnerText;
                    databaseName = xnl["database"].InnerText;
                    uid = xnl["uid"].InnerText;
                    pwd = xnl["pwd"].InnerText;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("네트워크 연결 설정 파일이 존재하지 않습니다. 관리자에게 문의바랍니다.");
            }
     

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MonitoringForm());
        }
    }
}
