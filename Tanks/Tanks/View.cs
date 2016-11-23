using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Tanks
{
    partial class View : UserControl
    {
        Model model;

        public View(Model model)
        {
            InitializeComponent();
            this.model = model;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Draw(e);            
        }
        private void Draw(PaintEventArgs e)
        {        
            DrawWall(e);
            DrawProjectile(e);
            DrawApple(e);
            DrawFireTank(e);
            DrawTank(e);
            DrawPackman(e);
            if (model.gamestatus != GameStatus.plainning)
                return;
            Thread.Sleep(model.speedGame);
            Invalidate();
        }
        private void DrawWall(PaintEventArgs e)
        {
            for (int i = 0; i < model.walls.Count; i++)
                e.Graphics.DrawImage(model.walls[i].CurrentImg, new Point(model.walls[i].X, model.walls[i].Y));
        }
        private void DrawTank(PaintEventArgs e)
        {
            for (int i = 0; i < model.tanks.Count; i++)
                e.Graphics.DrawImage(model.tanks[i].CurrentImg, new Point(model.tanks[i].X, model.tanks[i].Y));
        }      
        private void DrawFireTank(PaintEventArgs e)
        {
            for (int i = 0; i < model.fireTanks.Count; i++)
                e.Graphics.DrawImage(model.fireTanks[i].CurrentImg, new Point(model.fireTanks[i].X, model.fireTanks[i].Y));
        }
        private void DrawProjectile(PaintEventArgs e)
        {
            e.Graphics.DrawImage(model.projectile.CurrentImage, new Point(model.projectile.X, model.projectile.Y));
        }
        private void DrawPackman(PaintEventArgs e)
        {
            e.Graphics.DrawImage(model.packman.CurrentImg, new Point(model.packman.X, model.packman.Y));
        }
        private void DrawApple(PaintEventArgs e)
        {
            for(int i = 0; i < model.apples.Count; i++)
                e.Graphics.DrawImage(model.apples[i].Img, new Point(model.apples[i].X, model.apples[i].Y));
        }
        
    }
}
