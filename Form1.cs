using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeGame
{
    public partial class Form1 : Form
    {
        Game game;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int row = Convert.ToInt32(textBoxOfRow.Text);  
            int col = Convert.ToInt32(textBoxOfColumn.Text);

            DataGridViewUtils.SetColumnAndRow(ref dataGridView1, row, col);
            DataGridViewUtils.CorrectCellWidthAndHeight(ref dataGridView1);
            buttonOfSetup.Enabled = true;
            buttonOfStart.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;
            if (dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor == Color.Black)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                return;
            }
            dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            game = new Game(DataGridViewUtils.GameMapFromDataGrid(ref dataGridView1));
            buttonOfStart.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            game.IsStart = true;
            timer1.Start();
            buttonOfStop.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            game.Living();
            DataGridViewUtils.GameMapToDataGrid(game.GameMap, ref dataGridView1);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labelOfSpeed.Text = trackBar1.Value.ToString();
            timer1.Stop();
            timer1.Interval = 2050 - trackBar1.Value;

            if (game != null)
                if (game.IsStart)
                    timer1.Start();
        }

        private void buttonOfStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
