using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rcc_aulador_v2_metrodesign_master
{
    public partial class ControlForm : MetroForm
    {
        private MetroColorStyle activeColor;

        public ControlForm()
        {
            InitializeComponent();
            inicial_Configs();
        }

        private void inicial_Configs()
        {
            styleComboChoose.SelectedIndex = 14; /* @_param: Yellow*/
        }

        private void updateTheme_Click(object sender, EventArgs e)
        {
            controlPanelStyleManager.Theme =
                (controlPanelStyleManager.Theme == MetroThemeStyle.Light)
                    ? MetroThemeStyle.Dark : MetroThemeStyle.Light;

            updateTheme.Text =
                (controlPanelStyleManager.Theme == MetroThemeStyle.Light)
                    ? " Modo noite" : "Modo dia";

            Refresh();
        }

        private void metroTabPage3_Click(object sender, EventArgs e)
        {

        }

        private void ControlForm_Load(object sender, EventArgs e)
        {
            StyleManager = controlPanelStyleManager;
        }

        private void styleComboChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeColor = (MetroColorStyle)Convert.ToInt32(styleComboChoose.SelectedIndex);
            updateStyle_Components();
        }

        private void updateStyle_Components()
        {
            controlPanelStyleManager.Style = activeColor;
            metroTabControl1.Style = activeColor;
            updateTheme.Style = activeColor;
            styleComboChoose.Style = activeColor;

            /* Refresh content */
            Refresh();
        }
    }
}
