using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcOfBuild
{
    public partial class CoB : Form
    {
        
        private Button currentButton;
        private Form activeForm;
        public CoB()
        {
            InitializeComponent();
            btnToHomePanel.Visible = false;
        }

        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                DisableButton();
                if (currentButton != (Button)btnSender)
                {
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(112, 118, 149);
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    btnToHomePanel.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previosBtn in panelMenu.Controls)
            {
                if(previosBtn.GetType() == typeof(Button))
                {
                    previosBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previosBtn.ForeColor = Color.Gainsboro;
                    previosBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }
        
        public void UOpenPanelForms(Form glavForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            ActiveButton(btnSender);
            activeForm = glavForm;
            glavForm.TopLevel = false;
            glavForm.FormBorderStyle = FormBorderStyle.None;
            glavForm.Dock = DockStyle.Fill;
            this.OpenPanelForms.Controls.Add(glavForm);
            this.OpenPanelForms.Tag = glavForm;
            glavForm.BringToFront();
            glavForm.Show();
            
        }

        private void Plits_Click(object sender, EventArgs e)
        {
            UOpenPanelForms(new Forms.FormTilesdCalc(), sender);
            HomeTitle.Text = "Калькулятор плитки";
        }

        private void Wallpaper_Click(object sender, EventArgs e)
        {
            UOpenPanelForms(new Forms.FormWallpaperCalc(), sender);
            HomeTitle.Text = "Калькулятор обоев";
        }

        private void Paint_Click(object sender, EventArgs e)
        {
            UOpenPanelForms(new Forms.PaintForm(), sender);
            HomeTitle.Text = "Калькулятор краски";
        }

        private void skirtingBoard_Click(object sender, EventArgs e)
        {
            UOpenPanelForms(new Forms.FormSkirtingBoard(), sender);
            HomeTitle.Text = "Калькулятор плинтуса";
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            UOpenPanelForms(new Forms.SettingsPanelForm(), sender);
        }

        private void btnToHonePanel_Click(object sender, EventArgs e)
        {

            if(activeForm != null)
            {
                activeForm.Close();
            }
            Reset();

        }

        private void Reset()
        {

            DisableButton();
            HomeTitle.Text = "Домашняя страница";

            currentButton = null;

            btnToHomePanel.Visible = false;
        }
    }
}
