namespace verifica
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        string[] v = new string[15];

        private char decifC(char c)
        {

            if (c >= 'A' && c <= 'Z')
            {
                char dec = (char)(c - 3);
                if (dec <= 'A')
                {
                    dec = (char)(dec + 26);
                }
                return dec;
            }
            return c;
        }
        private string decF(string frase)
        {
            char[] car = frase.ToCharArray();
            carica(frase);
            for (int i = 0; i < car.Length; i++)
            {
               
                car[i] = decifC(car[i]);
            }
            return frase;
        }

        private void carica(string nomf)
        {
             nomf = "par.csv";

            if (File.Exists(nomf))
            {
                v = new string[nomf.Length];
                int i = 0;
                using (StreamReader sr = new StreamReader(nomf))
                {
                    while (!sr.EndOfStream)
                    {
                        string riga = sr.ReadLine();
                        v[i] = riga;
                        i++;

                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lst1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            using(StreamWriter sw=new StreamWriter("parDec.txt"))
            {
                
            }

        }
    }
}
