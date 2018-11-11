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
        private Thread th;
        public LoadingScreen()
        {
            InitializeComponent();
            startProcess_OpenForm();
        }

        private async void startProcess_OpenForm()
        {
            await Task.Run(() => Thread.Sleep(2000));
            startProcess();
        }

        public void startProcess()
        {
            th = new Thread(openControl_Form);
            Dispose();
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        public void openControl_Form(object obj)
        {
            Application.Run(new ControlForm());
            th.Abort();
        }
    }
}
