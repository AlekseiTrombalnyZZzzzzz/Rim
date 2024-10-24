namespace Rim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string romanNumber = textBox1.Text;
            (int number, string symbol)[] table = new (int num, string symbol)[13]
            {
                (1,"I"),   (4,"IV"),   (5,"V"),   (9,"IV"),
                (10,"X"),  (40,"XL"),  (50,"L"),  (90,"XC"),
                (100,"C"), (400,"CD"), (500,"D"), (900,"CM"),
                (1000,"M")
            };

            int i = 12;
            int p = 1;
            int res = 0;

            while (p <= romanNumber.Length)
            {
                while (romanNumber.Substring(p - 1, table[i].symbol.Length) != table[i].symbol)
                {
                    i--;
                    if (i == 0) break;
                }
                res += table[i].number;
                p += table[i].symbol.Length;
            }

            label1.Text = res.ToString();
        }
    }
}
