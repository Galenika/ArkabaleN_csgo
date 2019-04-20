using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArkabaleN.Managers;
using ArkabaleN.Other;


namespace ArkabaleN
{
    public partial class Menu : Form
    {
        #region Settings FORM

        //Перетаскивание формы
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        #endregion
        public Menu()
        {
            InitializeComponent();
            this.Hide();
        }

        private void pnlControl_MouseMove(object sender, MouseEventArgs e)
        {
            //Перемещение
            if (e.Button == MouseButtons.Left)
            {
                Imports.ReleaseCapture();
                Imports.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //Перемещение
            if (e.Button == MouseButtons.Left)
            {
                Imports.ReleaseCapture();
                Imports.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void lblNameProgramm_MouseMove(object sender, MouseEventArgs e)
        {
            //Перемещение
            if (e.Button == MouseButtons.Left)
            {
                Imports.ReleaseCapture();
                Imports.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Выход
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; //Свернуть
        }

        private void Menu_Shown(object sender, EventArgs e)
        {
            
            //Когда я последний раз обновлял софт
            lblUpdate.Text += File.GetLastWriteTime(Assembly.GetExecutingAssembly().Location);

            MemoryInstall();
            this.Show();


        }

        //Подготовка памяти
        private void MemoryInstall()
        {
            //Инициализация процесса "ксго"
            MemoryManager.Initialize("csgo");

            //Присваиваем к переменным библиотеки
            Structs.Base.Client = MemoryManager.GetModuleAdress("client_panorama");
            Structs.Base.Engine = MemoryManager.GetModuleAdress("engine");

            //Обновляем адреса памяти
            List<string> outdatedSignatures = Offsets.ScanPatterns();
        }
    }
}
