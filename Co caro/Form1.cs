﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Co_caro
{
    public partial class Form1 : Form
    {

        #region Properties
        Manager DrawBoard;
        #endregion

        public Form1()
        {
            InitializeComponent();

            DrawBoard = new Manager(ChessBoard);

            DrawBoard.DrawBoard();

        }

        

        

        private void Form1_Load(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Maximized;//Hien thi fullscreen khi chay ung dung
            TopMost = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            button3.Visible = true;
            button2.Visible = true;
            button1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
