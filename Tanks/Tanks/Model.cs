using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;

namespace Tanks
{
    public delegate void DelChnSt();
    class Model
    {
        int ApplesForWin;
        int sizeField;
        int amountTanks;
        int amountAppeles;
        public int speedGame;
        private SoundPlayer soundPlayer;

        public DelChnSt ParamChg;
        public List<Tank> tanks;
        public List<FireTank> fireTanks;
        public List<Apple> apples;
        public List<Wall> walls;
        public Packman packman;
        public Projectile projectile;
        public GameStatus gamestatus;
        Random r;
        int step = 10;
        private int Number_Apples;

        public Model(int sizeField, int amountTanks, int amountAppeles, int speedGame, int ApplesForWin)
        {
            soundPlayer = new SoundPlayer(Properties.Resources.Tanks);
            soundPlayer.Load();
            r = new Random();
            NewGame(sizeField, amountTanks, amountAppeles, speedGame, ApplesForWin);
        }
        private void CreateApples()
        {
            int x, y;
            for (int i = 0; i < amountAppeles; i++)
            {
                x = y = 0;
                RetPosNewApl(out x, out y);
                apples.Add(new Apple(x, y));
            }
        }
        private void RetPosNewApl(out int x, out int y)
        {
            x = y = 0;
            bool flag = true;
            while (flag)
            {
                flag = false;
                x = r.Next(0, sizeField / 40 + 1) * 40;
                y = r.Next(0, sizeField / 40 + 1) * 40;
                for (int i = 0; i < apples.Count; i++)
                    if ((apples[i].X == x) && (apples[i].Y == y))
                        flag = true;
            }
        }
        private void CreateTanks()
        {
            int dirext_x, dirext_y, x, y;
            for(int i = 0; i < amountTanks + 1; i++)
            {
                x = y = dirext_x = dirext_y = 0;
                bool flag = true;
                while (flag)
                {
                    flag = false;
                    x = r.Next(0, sizeField / 40 + 1) * 40;
                    y = r.Next(0, sizeField / 40 + 1) * 40;
                    if ((x == (sizeField - 20)/2) && (y == sizeField - 20))
                        flag = true;
                    for (int j = 0; j < tanks.Count; j++)
                        if ((tanks[j].X == x) && (tanks[j].Y == y))
                            flag = true;
                }
                if (r.Next(1000) < 500)//Turn of vertical
                {
                    dirext_x = 0;
                    while (dirext_y == 0)
                        dirext_y = r.Next(-1, 2);
                }
                else//Turn of horizontal
                {
                    dirext_y = 0;
                    while (dirext_x == 0)
                        dirext_x = r.Next(-1, 2);
                }
                if (tanks.Count == 0)
                    tanks.Add(new Hunter(sizeField,x,y,dirext_x,dirext_y));
                else
                    tanks.Add(new Tank(sizeField, x, y, dirext_x, dirext_y));
            }
        }
        public void Play()
        {
            while (gamestatus == GameStatus.plainning)
            {
                Thread.Sleep(speedGame);

                CollisionTanks();
                CollisionTanksAndPackman();
                MovementAllObject();               
                MovementProjectile();
                PickUpApples();
                
                if (Number_Apples >= ApplesForWin)
                {
                    gamestatus = GameStatus.winner;
                    if (ParamChg != null)
                        ParamChg();
                }
            }
        }
        private void MovementAllObject()
        {
            ((Hunter)tanks[0]).Run(packman.X, packman.Y);
            for (int i = 1; i < tanks.Count; i++)
                tanks[i].Run();
            projectile.Run();
            packman.Run();
            for (int i = 0; i < fireTanks.Count; i++)
                fireTanks[i].Fire();
        }
        private void PickUpApples()
        {
            for (int i = 0; i < apples.Count; i++)
                if ((packman.X == apples[i].X) && (packman.Y == apples[i].Y))
                {
                    apples[i].X = Number_Apples * 20 + step;
                    apples[i].Y = sizeField + step;
                    Number_Apples++;
                    int x = 0, y = 0;
                    RetPosNewApl(out x, out y);
                    apples.Add(new Apple(x, y));
                }
        }
        private void MovementProjectile()
        {
            for (int i = 1; i < tanks.Count; i++)
                if ((Math.Abs(tanks[i].X + 10 - projectile.X) < 5) && (Math.Abs(tanks[i].Y + 10 - projectile.Y) < 5))
                {
                    fireTanks.Add(new FireTank(tanks[i].X, tanks[i].Y));
                    tanks.RemoveAt(i);
                    projectile.DefaultSeting();
                }
        }
        private void CollisionTanksAndPackman()
        {
            for (int i = 0; i < tanks.Count; i++)
                if (((Math.Abs(tanks[i].X - packman.X) <= 19) && (tanks[i].Y == packman.Y)) ||
                    ((Math.Abs(tanks[i].Y - packman.Y) <= 19) && (tanks[i].X == packman.X)) ||
                    ((Math.Abs(tanks[i].Y - packman.Y) <= 19) && (Math.Abs(tanks[i].X - packman.X) <= 19)) ||
                    ((Math.Abs(tanks[i].Y - packman.Y) == 19) && (Math.Abs(tanks[i].X - packman.X) == 19))
                    )
                {
                    gamestatus = GameStatus.looser;
                    if (ParamChg != null)
                        ParamChg();
                }
        }
        private void CollisionTanks()
        {
            for (int i = 0; i < tanks.Count; i++)
                for (int j = i + 1; j < tanks.Count; j++)
                    if (((Math.Abs(tanks[i].X - tanks[j].X) <= 20) && (tanks[i].Y == tanks[j].Y)) ||
                        ((Math.Abs(tanks[i].Y - tanks[j].Y) <= 20) && (tanks[i].X == tanks[j].X)) ||
                        ((Math.Abs(tanks[i].Y - tanks[j].Y) == 20) && (Math.Abs(tanks[i].X - tanks[j].X) == 20))
                        )
                    {
                        if (i == 0)
                            ((Hunter)tanks[i]).TurnArround();
                        else
                            tanks[i].TurnArround();
                        tanks[j].TurnArround();
                    }
        }
        public void NewGame(int sizeField, int amountTanks, int amountAppeles, int speedGame, int ApplesForWin)
        {
            this.sizeField = sizeField;
            this.amountTanks = amountTanks;
            this.amountAppeles = amountAppeles;
            this.speedGame = speedGame;
            this.ApplesForWin = ApplesForWin;
            Number_Apples = 0;
            tanks = new List<Tank>();
            fireTanks = new List<FireTank>();
            apples = new List<Apple>();
            walls = new List<Wall>();
            packman = new Packman(sizeField);
            projectile = new Projectile();
            CreateTanks();
            CreateApples();
            CreateWalls();
            gamestatus = GameStatus.stopped;
        }
        private void CreateWalls()
        {
            for (int i = 20; i < sizeField; i += 40)
                for (int j = 20; j < sizeField; j += 40)
                    walls.Add(new Wall(i, j));
        }
        public void MusicPlayChange(bool st)
        {
            if (st)
                soundPlayer.PlayLooping();
            else
                soundPlayer.Stop();
        }
    }
}
