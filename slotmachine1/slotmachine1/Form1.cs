namespace slotmachine1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (credits >= bet)
            {
                credits = credits - bet;
                label1.Text = "Credits: " + credits.ToString();

                for (var i = 0; i < 10; i++)
                {
                    p1 = IntUtil.Random(1, 4);
                    p2 = IntUtil.Random(1, 4);
                    p3 = IntUtil.Random(1, 4);
                    p4 = IntUtil.Random(1, 4);
                    p5 = IntUtil.Random(1, 4);
                    p6 = IntUtil.Random(1, 4);
                    p7 = IntUtil.Random(1, 4);
                    p8 = IntUtil.Random(1, 4);
                    p9 = IntUtil.Random(1, 4);
                }

                if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
                pictureBox1.Image = Image.FromFile(p1.ToString() + ".png");

                if (pictureBox2.Image != null) pictureBox2.Image.Dispose();
                pictureBox2.Image = Image.FromFile(p2.ToString() + ".png");

                if (pictureBox3.Image != null) pictureBox3.Image.Dispose();
                pictureBox3.Image = Image.FromFile(p3.ToString() + ".png");

                if (pictureBox4.Image != null) pictureBox4.Image.Dispose();
                pictureBox4.Image = Image.FromFile(p4.ToString() + ".png");

                if (pictureBox5.Image != null) pictureBox5.Image.Dispose();
                pictureBox5.Image = Image.FromFile(p5.ToString() + ".png");

                if (pictureBox6.Image != null) pictureBox6.Image.Dispose();
                pictureBox6.Image = Image.FromFile(p6.ToString() + ".png");

                if (pictureBox7.Image != null) pictureBox7.Image.Dispose();
                pictureBox7.Image = Image.FromFile(p7.ToString() + ".png");

                if (pictureBox8.Image != null) pictureBox8.Image.Dispose();
                pictureBox8.Image = Image.FromFile(p8.ToString() + ".png");

                if (pictureBox9.Image != null) pictureBox9.Image.Dispose();
                pictureBox9.Image = Image.FromFile(p9.ToString() + ".png");

                total = 0;


                if (p1 == 3) total = total + 5;
                if (p4 == 3) total = total + 5;
                if (p7 == 3) total = total + 5;

                if (p1 == 2 & p2 == 2) total = total + 10;
                if (p1 == 3 & p2 == 3) total = total + 10;
                if (p4 == 2 & p5 == 2) total = total + 10;
                if (p4 == 3 & p5 == 3) total = total + 10;
                if (p7 == 2 & p8 == 2) total = total + 10;
                if (p7 == 3 & p8 == 3) total = total + 10;

                if (p1 == 1 & p2 == 1 & p3 == 1) total = total + 20;
                if (p1 == 2 & p2 == 2 & p3 == 2) total = total + 30;
                if (p1 == 3 & p2 == 3 & p3 == 3) total = total + 50;
                if (p4 == 1 & p5 == 1 & p6 == 1) total = total + 20;
                if (p4 == 2 & p5 == 2 & p6 == 2) total = total + 30;
                if (p4 == 3 & p5 == 3 & p6 == 3) total = total + 50;
                if (p7 == 1 & p8 == 1 & p9 == 1) total = total + 20;
                if (p7 == 2 & p8 == 2 & p9 == 2) total = total + 30;
                if (p7 == 3 & p8 == 3 & p9 == 3) total = total + 50;

                if (p4 == 1 & p2 == 1 & p9 == 1) total = total + 30;
                if (p4 == 2 & p2 == 2 & p9 == 2) total = total + 60;
                if (p4 == 3 & p2 == 3 & p9 == 3) total = total + 90;
                if (p2 == 1 & p6 == 1 & p7 == 1) total = total + 30;
                if (p2 == 2 & p6 == 2 & p7 == 2) total = total + 60;
                if (p2 == 3 & p6 == 3 & p7 == 3) total = total + 90;

                credits = credits + total;
                label3.Text = "Win: " + total.ToString();
                label1.Text = "Credits: " + credits.ToString();
            }
        }
        public static long credits = 100;
        public static long total = 0;
        public static int bet = 5;

        public static int p1;
        public static int p2;
        public static int p3;
        public static int p4;
        public static int p5;
        public static int p6;
        public static int p7;
        public static int p8;
        public static int p9;
        private void Form1_Load_1(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("3.png");
            pictureBox2.Image = Image.FromFile("1.png");
            pictureBox3.Image = Image.FromFile("2.png");
            pictureBox4.Image = Image.FromFile("3.png");
            pictureBox5.Image = Image.FromFile("1.png");
            pictureBox6.Image = Image.FromFile("2.png");
            pictureBox7.Image = Image.FromFile("3.png");
            pictureBox8.Image = Image.FromFile("1.png");
            pictureBox9.Image = Image.FromFile("2.png");
        }
        public static class IntUtil
        {
            private static Random random;

            private static void Init()
            {
                if (random == null) random = new Random();
            }
            public static int Random(int min, int max)
            {
                Init();
                return random.Next(min, max);
            }
        }
    }
}