using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int x=0;
            int y = 0;
            byte[] b;
            String gs="";
            String gss = "";
            String fname = "";
            int bbb=0;
            int nnn = 0;
            button1.Text= "loading wait...";
            openFileDialog1.ShowDialog();
            fname = openFileDialog1.FileName;

            Application.DoEvents();
            gs = File.ReadAllText(fname);
            for (y = 0; y < gs.Length; y++)
            {
                bbb = (((int)gs[y])& 0xff);
                gss = gss + bbb.ToString()+" , ";
                nnn = y / 16;
                if (nnn * 16 == y && y!=0) gss = gss + "\r\n";

            }

            gss = gss + "0";
            textBox1.Text =gss;
            button1.Text = "open resource";
        }
    }
}