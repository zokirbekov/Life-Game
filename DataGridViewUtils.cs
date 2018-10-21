using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeGame
{
    public static class DataGridViewUtils
    {
        public static void SetColumnAndRow(ref DataGridView gridView, int row, int col)
        {
            gridView.Columns.Clear();
            for (int i = 0;i<col;i++)
            {
                gridView.Columns.Add((i + 1).ToString(), (i + 1).ToString());
            }
            gridView.Rows.Add(row);
        }
        public static void CorrectCellWidthAndHeight(ref DataGridView gridView)
        {
            int width = (gridView.Width - 1) / gridView.Columns.Count;
            int height = (gridView.Height - 1) / gridView.Rows.Count;

            for (int i = 0; i < gridView.Columns.Count; i++)
                gridView.Columns[i].Width = width;

            for (int i = 0; i < gridView.Rows.Count; i++)
                gridView.Rows[i].Height = height;

            gridView.Width = width * gridView.Columns.Count;
            gridView.Height = height * gridView.Rows.Count;

        }
        public static int CountLifes(ref DataGridView gridView)
        {
            int lifes = 0;
            for (int i = 0; i < gridView.Columns.Count; i++)
                for (int j = 0; j < gridView.Rows.Count; j++)
                    if (gridView[i, j].Style.BackColor == Color.Black)
                        lifes++;
            return lifes;
        }
        public static bool[][] GameMapFromDataGrid(ref DataGridView gridView)
        {
            bool[][] map = new bool[gridView.Rows.Count][];

            for (int i = 0; i < map.Length; i++)
                map[i] = new bool[gridView.Columns.Count];

            for (int i=0;i<map.Length;i++)
                for (int j=0;j<map[i].Length;j++)
                {
                    map[i][j] = gridView[j, i].Style.BackColor == Color.Black ? true : false;
                }

            return map;
        }
        public static void GameMapToDataGrid(bool[][] map,ref DataGridView gridView)
        {
            for (int i=0;i<map.Length;i++)
            {
                for (int j=0;j<map[i].Length;j++)
                {
                    gridView[j, i].Style.BackColor = map[i][j] ? Color.Black : Color.White;
                }
            }
        }
    }
}
