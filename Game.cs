using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGame
{
    public class Game
    {
        public int Row;
        public int Column;
        public bool IsStart;
        public int Lifes {
            get
            {
                return countLife();
            }
            private set { }
        }
        public bool[][] GameMap;
        public Game()
        {

        }
        public Game(bool[][] GameMap)
        {
            if (GameMap == null)
                throw new NullReferenceException("GameMap is null");

            this.GameMap = GameMap;
            this.Row = GameMap.Length;
            this.Column = GameMap[0].Length;
            this.Lifes = countLife();
        }
        private int countLife()
        {
            int lifes = 0;
            for (int i =0;i<Row;i++)
            {
                for (int j=0;j<Column;j++)
                {
                    if (GameMap[i][j])
                        lifes++;
                }
            }
            return lifes;
        }
        public string GameMapToString()
        {
            string map = "";
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    map += GameMap[i][j] ? "1" : "0";
                    map += " ";
                }
                map += Environment.NewLine;
            }
            return map;
        }
        public void Living()
        {
            bool[][] newGameMap = new bool[Row][];
            for (int k = 0; k < Row; k++)

                newGameMap[k] = new bool[Column];

            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    newGameMap[i][j] = isThereLive(i, j);

                    if (GameMap[i][j])
                        newGameMap[i][j] = isLifeContinue(i, j);

                }
            }
            GameMap = newGameMap;

        }
        private int checkLifeCount(int i,int j)
        {
            int count = 0;
            int left = j == 0 ? Column - 1 : j - 1;
            int right = j == Column - 1 ? 0 : j + 1; ;
            int top = i == 0 ? Row - 1 : i - 1;
            int bottom = i == (Row - 1) ? 0 : i + 1;

            if (GameMap[i][left]) count++;
            if (GameMap[i][right]) count++;
            if (GameMap[top][j]) count++;
            if (GameMap[bottom][j]) count++;
            if (GameMap[top][left]) count++;
            if (GameMap[top][right]) count++;
            if (GameMap[bottom][left]) count++;
            if (GameMap[bottom][right]) count++;

            return count;
        }
        private bool isThereLive(int i,int j)
        {
            bool live = true;
            int countLife = checkLifeCount(i,j);
            live = countLife == 3 ? true : false;
            return live;
        }
        private bool isLifeContinue(int i,int j)
        {
            bool live = true;
            int countLife = checkLifeCount(i,j);
            live = (countLife == 2 || countLife == 3);
            return live;
        }
    }
}
