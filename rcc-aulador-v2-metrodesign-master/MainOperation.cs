using MetroFramework.Components;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rcc_aulador_v2_metrodesign_master
{
    public partial class MainOperation : MetroForm
    {
        public MainOperation(MetroStyleManager metroStyleManager)
        {
            InitializeComponent();
            configureComponents(metroStyleManager);
        }

        private void configureComponents(MetroStyleManager metroStyleManager)
        {
            // Components
            StyleManager = metroStyleManager;

        }

        private void MainOperation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }
    }
}
