using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGamePyatnashki
{
    public partial class Form1 : Form
    {
        Game game;
        public Form1()
        {
            InitializeComponent();
            game = new Game(4);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int position = Convert.ToInt16(((Button)sender).Tag);
            game.shift(position);
            refresh();
        }

        private Button button(int position)
        {
            switch (position)
            {
                case 0: return button1;
                case 1: return button2;
                case 2: return button3;
                case 3: return button4;
                case 4: return button5;
                case 5: return button6;
                case 6: return button7;
                case 7: return button8;
                case 8: return button9;
                case 9: return button10;
                case 10: return button11;
                case 11: return button12;
                case 12: return button13;
                case 13: return button14;
                case 14: return button15;
                case 15: return button16;

                default:
                    return null;
            }
        }

        private void start_game()
        {
            game.start();
            for(int j=0; j<100; j++)
            {
                game.shift_random();
            }
            refresh();
        }

        
        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            start_game();
        }

        private void refresh()
        {
            for (int position = 0; position < 16; position++) {
                int nr = game.get_number(position);
                button(position).Text = nr.ToString();
                button(position).Visible = (nr > 0);
                }
        }
    }
}
