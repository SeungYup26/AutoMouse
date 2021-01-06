using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Interval = 1;
        }

        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        [Flags]
        public enum MouseEventFlags
        {
            LEFTDOWN = 2,
            LEFTUP = 4,
            MIDDLEDOWN = 20,
            MIDDLEUP = 40,
            MOVE = 1,
            ABSOLUTE = 8000,
            RIGHTDOWN = 8,
            RIGHTUP = 10
        }

        private void LeftClick(Point p)
        {
            Cursor.Position = p;
            mouse_event((int)(MouseEventFlags.LEFTDOWN), 0, 0, 0, 0);
            mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, 0);
        }

        private void RightClick(Point p)
        {
            Cursor.Position = p;
            mouse_event((int)(MouseEventFlags.RIGHTDOWN), 0, 0, 0, 0);
            mouse_event((int)(MouseEventFlags.RIGHTUP), 0, 0, 0, 0);
        }

        private void DoubleRightClick(Point p)
        {
            Cursor.Position = p;
            mouse_event((int)(MouseEventFlags.RIGHTDOWN), 0, 0, 0, 0);
            mouse_event((int)(MouseEventFlags.RIGHTUP), 0, 0, 0, 0);
            mouse_event((int)(MouseEventFlags.RIGHTDOWN), 0, 0, 0, 0);
            mouse_event((int)(MouseEventFlags.RIGHTUP), 0, 0, 0, 0);
        }

        private void HolDownLeft(Point p, int tempo)
        {
            Cursor.Position = p;
            mouse_event((int)(MouseEventFlags.LEFTDOWN), 0, 0, 0, 0);
            Thread.Sleep(tempo);
            mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, 0);
        }

        private void HolDownRight(Point p, int tempo)
        {
            Cursor.Position = p;
            mouse_event((int)(MouseEventFlags.RIGHTDOWN), 0, 0, 0, 0);
            Thread.Sleep(tempo);
            mouse_event((int)(MouseEventFlags.RIGHTUP), 0, 0, 0, 0);
        }

        public void Position()
        {
            timer1.Start();
            timer1.Interval = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point p = new Point();
            p.X = Int32.Parse(xPointBox.Text);
            p.Y = Int32.Parse(yPointBox.Text);
            LeftClick(p);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            xBox.Text = Cursor.Position.X.ToString();
            yBox.Text = Cursor.Position.Y.ToString();
        }
    }
}