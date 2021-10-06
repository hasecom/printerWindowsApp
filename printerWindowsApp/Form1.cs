using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace printerWindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getPrinterInfo_Click(object sender, EventArgs e)
        {

            Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = @"C:\dev\printerWebApp\getPrinterInfo.bat";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardInput = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.Arguments = @"/c dir c:\ /w";
            p.Start();
            string results = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            p.Close();

            MatchCollection matche = Regex.Matches(results, @"プリンター名\s(?<pn>(.*))|ドライバー名\s(?<dn>(.*))|ポート名\s(?<pp>(.*))");

            int i = 0;
            string printerInfoStr = "";
            foreach (Match m in matche)
            {
                i++;
                printerInfoStr += m.Result("${pn}${dn}");
                if (i % 3 == 0) {
                    printerInfoStr += m.Result("${pp}");
                    printerList.Items.Add(printerInfoStr);
                    printerInfoStr = "";
                }
                
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
