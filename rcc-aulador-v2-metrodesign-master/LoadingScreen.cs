using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 *  @MetroFramework's imports
 * */
using MetroFramework.Forms;

namespace rcc_aulador_v2_metrodesign_master
{
    public partial class LoadingScreen : MetroForm
    {
        public LoadingScreen()
        {
            InitializeComponent();
            startProcess_OpenForm();
        }

        private void startProcess_OpenForm()
        {
            Task loadingTask = Task.Run(() => 
            {
                for (int i = 1; i <= 10; i++)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        metroProgressBar1.Value = i * 10;
                    });
                    Thread.Sleep(570);
                }
            }).ContinueWith(delegate
            {
                Invoke((MethodInvoker)delegate
                {
                    Hide();
                    new ControlForm().ShowDialog();

                    //Release memory
                    Dispose();

                });
            });
        }
    }
}