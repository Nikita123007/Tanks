using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


[assembly:CLSCompliant(true)]
namespace Tanks
{
    delegate void Invoker();
    public partial class ControllerMainForm : Form
    {
        View view;
        Model model;
        Thread modelPlay;
        bool isSound, mouseMove = false;
        int mouseX = 0, mouseY = 0;

        public ControllerMainForm(int sizeField = 260, int amountTanks = 5, int amountAppeles = 5, int speedGame = 28, int ApplesForWin = 5)
        {
            model = new Model(sizeField, amountTanks, amountAppeles, speedGame, ApplesForWin);
            view = new View(model);
            InitializeComponent();
            this.Controls.Add(view);
            isSound = false;
            model.ParamChg = new DelChnSt(ChangeStreep);
        }
        private void Start_Stop_btn_Click(object sender, EventArgs e)
        {
            if (model.gamestatus == GameStatus.plainning)
            {
                modelPlay.Abort();
                model.gamestatus = GameStatus.stopped;
                ChangeStreep();
            }
            else if (model.gamestatus == GameStatus.stopped)
            {
                modelPlay = new Thread(model.Play);
                modelPlay.Start();
                model.gamestatus = GameStatus.plainning;
                ChangeStreep();
                view.Invalidate();
            }
            else
            {
                NewGameToolStripMenuItem1_Click(sender, e);
            }
        }
        private void ControllerMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (modelPlay != null)
            {
                modelPlay.Abort();
                model.gamestatus = GameStatus.stopped;
            }
        }
        private void ManipulatePackman(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'w':
                case 'ц':
                case 'Ц':
                case 'W':
                    model.packman.Next_dirext_x = 0;
                    model.packman.Next_dirext_y = -1;
                    break;
                case 'a':
                case 'A':
                case 'ф':
                case 'Ф':
                    model.packman.Next_dirext_x = -1;
                    model.packman.Next_dirext_y = 0;
                    break;
                case 'ы':
                case 'Ы':
                case 's':
                case 'S':
                    model.packman.Next_dirext_x = 0;
                    model.packman.Next_dirext_y = 1;
                    break;
                case 'd':
                case 'D':
                case 'в':
                case 'В':
                    model.packman.Next_dirext_x = 1;
                    model.packman.Next_dirext_y = 0;
                    break;
                case 'e':
                case 'у':
                case 'E':
                case 'У':
                    GetPositionProjectile();                   
                    break;
                case (char)27: this.Close();
                    break;
            }
        }
        private void GetPositionProjectile()
        {
            model.projectile.X = model.packman.X;
            model.projectile.Y = model.packman.Y;
            if (model.packman.Dirext_x == 0)
                model.projectile.X += model.packman.CurrentImg.Width / 2 - model.projectile.CurrentImage.Width / 2;
            if (model.packman.Dirext_y == 0)
                model.projectile.Y += model.packman.CurrentImg.Height / 2 - model.projectile.CurrentImage.Height / 2;
            if (model.packman.Dirext_x == 1)
                model.projectile.X += model.packman.CurrentImg.Width;
            if (model.packman.Dirext_y == 1)
                model.projectile.Y += model.packman.CurrentImg.Height;

            model.projectile.Dirext_x = model.packman.Dirext_x * 3;
            model.projectile.Dirext_y = model.packman.Dirext_y * 3;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void NewGameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int sizeField = GiveNewSizeField();
            ChangeFormComponent(sizeField);
            model.NewGame(sizeField, Convert.ToInt32(CBTanks.Text), Convert.ToInt32(CBApplesOnMap.Text), RetSpeedOnNum(Convert.ToInt32(CBSpeedGame.Text)), Convert.ToInt32(CBApplesForWin.Text));
            view.Refresh();
            ChangeStreep();
            Start_Stop_btn.Focus();
        }
        private int GiveNewSizeField()
        {
            int size = 0;
            string temp = CBSizeField.Text;
            if (temp == "Small")
                size = 260;
            else if (temp == "Avarage")
                size = 420;
            else
                size = 580;
            return size;
        }
        private void ChangeFormComponent(int size)
        {
            int width = size + 120;
            int height = size + 100;
            Width = width;
            Height = height;
            this.Start_Stop_btn.Location = new Point(size + 30, Start_Stop_btn.Location.Y);
            this.GameStLbl.Location = new Point(size + 10, GameStLbl.Location.Y);
            view.Width = size;
            view.Height = size + 40;
            Size screenSize = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
            this.Location = new Point((screenSize.Width - width)/2, (screenSize.Height - height) / 2 - 20);
        }
        private int RetSpeedOnNum(int N)
        {
            switch (N)
            {
                case 1: return 34;
                case 2: return 28;
                case 3: return 18;
                case 4: return 12;
                case 5: return 6;
            }
            return 25;
        }
        private void AboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"       Версия игры: 1.0
       Разработчик: Забейда Никита

       Для управления используйте 
       клавиши: A, S, D, W, E", "Танки", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }
        private void SoundToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            isSound = !isSound;
            if (isSound)
            {
                soundToolStripMenuItem.Image = Properties.Resources.Sound2;
                model.MusicPlayChange(true);
            }
            else
            {
                soundToolStripMenuItem.Image = Properties.Resources.Sound3;
                model.MusicPlayChange(false);
            }
        }
        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ChangeStreep()
        {
            Invoke(new Invoker(SetValueToStripLabel));
        }
        private void SetValueToStripLabel()
        {
            Main_StatusLabel.Text = model.gamestatus.ToString();
            if (model.gamestatus == GameStatus.winner)
                GameStLbl.Text = "You win!";
            else if (model.gamestatus == GameStatus.looser)
                GameStLbl.Text = "You lose!";
            else
                GameStLbl.Text = "";
            if ((model.gamestatus == GameStatus.looser) || (model.gamestatus == GameStatus.winner))
                Start_Stop_btn.Text = "New" + Convert.ToString((char)13) + Convert.ToString((char)10) + "Game";
            else
                Start_Stop_btn.Text = "Start/" + Convert.ToString((char)13) + Convert.ToString((char)10) + "Pause";
        }
        private void Main_Menu_Strip_MouseUp(object sender, MouseEventArgs e)
        {
            mouseMove = false;
            this.Opacity = 1;
        }
        private void ControllerMainForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
            mouseMove = true;
            this.Opacity = 0.7;
        }
        private void Main_Menu_Strip_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseMove)
                this.Location = new Point(this.Location.X + (e.X - mouseX), this.Location.Y + (e.Y - mouseY));
        }
    }
}
