using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Co_caro
{
    public class Manager
    {
        #region Properties
        private Panel chessboard;

        public Panel Chessboard
        {
            get { return chessboard; }
            set { chessboard = value; }
        }

        private List<Player> player;

        public List<Player> Player 
        {
            get { return player; }
            set { player = value; }
        }

        #endregion

        #region Initialize
        public Manager(Panel chessboard)
        {
            this.Chessboard = chessboard;
            this.Player = new List<Player>()
            {
                new Player ("PMD4N", Image.FromFile(Application.StartupPath + "\\..\\..\\Resources\\x.png")),
                new Player ("ATU", Image.FromFile(Application.StartupPath + "\\..\\..\\Resources\\o.png"))
            };
        }


        #endregion

        #region Methods
        public void DrawBoard()//Ve bang; Ve cac o lan luot theo tung hang
        {
            Button oldButton = new Button()
            {
                Width = 0,
                Location = new Point(0, 0)
            };//Khoi tao nut dau tien
            for (int i = 0; i < 50; i++)
            {

                for (int j = 0; j < 50; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.CHESS_WIDTH,//Kich thuoc tung o
                        Height = Cons.CHESS_HEIGHT,
                        Location = new Point(oldButton.Location.X + Cons.CHESS_WIDTH, oldButton.Location.Y), //Giu nguyen toa do hang, dich toa do truc
                        BackgroundImageLayout = ImageLayout.Stretch
                    };

                    btn.Click += btn_Click;

                    Chessboard.Controls.Add(btn);//Them cac nut vao panel Chessboard

                    oldButton = btn;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Cons.CHESS_HEIGHT);// Giu nguyen toa do truc, dich toa do hang
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackgroundImage = Image.FromFile(Application.StartupPath + "\\..\\..\\Resources\\x.png");
        }
        #endregion

        
    }
}
