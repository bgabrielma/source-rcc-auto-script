﻿using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rcc_aulador_v2_metrodesign_master
{
    public partial class ControlForm : MetroForm
    {
        private MetroColorStyle activeColor;
        private WebClient habboManager;
        private Stream webOperations;
        private Bitmap habboImager;

        public ControlForm()
        {
            InitializeComponent();
            inicial_Configs();
        }

        private void inicial_Configs()
        {
            styleComboChoose.SelectedIndex = 14; /* @_param: Yellow*/
            metroTabControl1.SelectedIndex = 1;
            setHelloUser();
            dataNickname.Text = Properties.Settings.Default.nick;
            dataTAG.Text = Properties.Settings.Default.tag;
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
            submitData.Style = activeColor;
            borderInMilitarData.Style = activeColor;
            importOption.Style = activeColor;
            generateOption.Style = activeColor;
            helpOption.Style = activeColor;

            /* Refresh content */
            Refresh();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.nick == String.Empty && Properties.Settings.Default.tag == String.Empty)
                MetroMessageBox.Show(this, "Bem vindo militar, em Dados do Militar deverá indicar o seu Nickname e TAG. É obrigatório para que possa usar o programa", "RCC - Alteração/Inserção de dados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MetroMessageBox.Show(this, $"{Properties.Settings.Default.nick}, em caso de dúvidas basta contactar os seguintes: ,SrGabriel / Goufix. \nObrigado pela sua compreensão e aproveite :) #RCC", "RCC - Sem notificações / ajuda", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private async void metroTabControl1_Click(object sender, EventArgs e)
        {
           if(metroTabControl1.SelectedIndex == 0)
            {
                await Task.Run(() => LoadHabboImageFromAPIAsync(dataNickname.Text));
                rccUser.Image = habboImager;
            }
        }

        private async Task LoadHabboImageFromAPIAsync(string url)
        {
            await Task.Run(() =>
            {
                habboManager = new WebClient();
                habboManager.Headers
                    .Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

                url = (url == null || url == String.Empty) ? ",SrGabriel" : url;

                /**
                 * @param {string}
                 *  => get nickname and generate an url in order to get the image
                 * */
                var url_habbo_image = $"https://www.habbo.com.br/habbo-imaging/avatarimage?img_format=gif&user={url}&action=crr=6&direction=2&head_direction=2&gesture=std&size=l&headonly=1";

                try
                {
                    webOperations = habboManager.OpenRead(url_habbo_image);
                    habboImager = new Bitmap(webOperations);
                }
                catch (WebException e)
                {
                    if (e.Status == WebExceptionStatus.ProtocolError)
                    {
                        if (((HttpWebResponse)e.Response).StatusCode == HttpStatusCode.NotFound)
                        {
                            MetroMessageBox.Show(this, "Lamentamos mas não existe nenhum habbo com referencia ao nick inserido.",
                                "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                finally
                {
                    webOperations.Close();
                    habboManager.Dispose();
                    Thread.Sleep(1000);
                }
            });
        }

        private void setHelloUser()
        {
            if (Properties.Settings.Default.nick == String.Empty)
            {
                helloUser.Text = $"Olá, Convidado...";
                notificationsNumber.Text = "(1)";
            }
            else
            {
                helloUser.Text = $"Olá, {Properties.Settings.Default.nick}...";
                notificationsNumber.Text = "(0)";
            }
        }

        private async void submitData_Click(object sender, EventArgs e)
        {
            if(dataNickname.Text != String.Empty && dataTAG.Text != String.Empty)
            {
                Properties.Settings.Default.nick = dataNickname.Text;
                Properties.Settings.Default.tag = dataTAG.Text;
                Properties.Settings.Default.Save();
                setHelloUser();
                notificationsNumber.Text = "(0)";
                MetroMessageBox.Show(this, "Dados inseridos com sucesso!",
                    "RCC - Inserção de dados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                rccUser.Image = Properties.Resources.Loading_icon;
                await Task.Run(() => LoadHabboImageFromAPIAsync(Properties.Settings.Default.nick));
                rccUser.Image = habboImager;
                return;
            }

            MetroMessageBox.Show(this, "Os campos em questão são obrigatórios! Tente novamente", 
                "RCC - Inserção de dados", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}