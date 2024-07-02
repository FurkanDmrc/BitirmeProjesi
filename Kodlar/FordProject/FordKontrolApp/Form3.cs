using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FordKontrolApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChild.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;


        private Color SelectThemeColor()
        {
            int index = random.Next(Renkler.RenkListesi.Count);
            while (tempIndex == index)
            {
              index=  random.Next(Renkler.RenkListesi.Count);
            }
            tempIndex = index;
            string color = Renkler.RenkListesi[index];
            return ColorTranslator.FromHtml(color); 
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender !=null)
            {
                if (currentButton!=(Button)btnSender) 
                {
                    DisableButton();
                    Color color=SelectThemeColor();
                    currentButton=(Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font= new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                    panelBaslik.BackColor = color;
                    panelLogo.BackColor = Renkler.ChangeColorBrightness(color,-0.3);
                    btnCloseChild.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51,51,76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font= new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm !=null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblBaslik.Text = childForm.Text;
        }
        private void btnBilgi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Bilgi_Formu(),sender);
        }

        private void btnServis_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ServisRandevu(), sender);
        }

        private void btnCloseChild_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblBaslik.Text = "HOŞGELDİNİZ";
            panelBaslik.BackColor = Color.FromArgb(0,150,136);
            panelLogo.BackColor = Color.FromArgb(39,39,58);
            currentButton = null;
            btnCloseChild.Visible = false;
        }

        private void lblBaslik_Click(object sender, EventArgs e)
        {

        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelBaslik_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if(WindowState==FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState=FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
