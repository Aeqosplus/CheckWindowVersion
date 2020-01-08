using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckWindowsVersion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getOS();
        }

        private void getOS()
        {
            OperatingSystem os = Environment.OSVersion;

            Version vs = os.Version;

            string osname = "";

            if (os.Platform == PlatformID.Win32Windows)
            {
                if (vs.Minor == 0)
                {
                    osname = "95";
                }
                else if (vs.Minor == 10)
                {
                    if (vs.Revision.ToString() == "2222A")
                    {
                        osname = "98SE";
                    }
                    else
                    {
                        osname = "98";
                    }
                }
                else if (vs.Minor == 90)
                {
                    osname = "Me";
                }
            }
            else if (os.Platform == PlatformID.Win32NT)
            {
                if (vs.Major == 3)
                {
                    osname = "NT 3.51";
                }
                else if (vs.Major == 4)
                {
                    osname = "NT 4";
                }
                else if (vs.Major == 5)
                {
                    if (vs.Minor == 0)
                    {
                        osname = "2000";
                    }
                    else
                    {
                        osname = "XP";
                    }
                }
                else if (vs.Major == 6)
                {
                    if (vs.Minor == 0)
                    {
                        osname = "Vista";
                    }
                    else if (vs.Minor == 1)
                    {
                        osname = "7";
                    }
                    else if (vs.Minor == 2)
                    {
                        osname = "8";
                    }
                    else
                    {
                        osname = "8.1";
                    }
                }
                else if (vs.Major == 10)
                {
                    osname = "10";
                }
            }

            if (osname != "")
            {
                osname = "Windows " + osname;
                if (os.ServicePack != "")
                {
                    osname += os.ServicePack;
                }
            }


            label1.Text = osname;

        }
    }
}
