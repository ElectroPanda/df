using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using argt;


namespace argt
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string ver;
            string[] far;


            ver = "v. 0.2.1 SharpDevelop 3.2.1 Build";
            label6.Text = ver;
            far = Environment.GetCommandLineArgs();
            //BitVal.Text = ""+far.Length;
            stArr fae = new stArr(far);
            if (far.Length > 2)
            {
                BitVal.Text = far[1];
                if (far.Length > 2) { LoLiScale.Text = far[2]; }
                if (far.Length > 3) { UpLiScale.Text = far[3];}
                if (far.Length > 4) { qvant.Text = far[4]; }
            }

            //Resultt.Text = far.Length + "";

            switch (far.Length) //Выбор в зависимости от количества аргументов переданных командной строке
            {

                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    Eval obQ = new Eval(Convert.ToSingle(far[1]), Convert.ToSingle(far[2]));


                    obQ.CalcEval();
                    Resultt.Text = obQ.sRes;
                    UpLiScale.Text = obQ.iRend + "";
                    qvant.Text = obQ.iCodRange+"";

                    break;

                case 4:
                    Eval obA = new Eval(Convert.ToSingle(far[1]), Convert.ToSingle(far[2]), Convert.ToSingle(far[3]));


                    obA.CalcEval();
                    Resultt.Text = obA.sRes;
                    qvant.Text = obA.iCodRange + "";
                    break;

                case 5:
                    Eval obB = new Eval(Convert.ToSingle(far[1]), Convert.ToSingle(far[2]), Convert.ToSingle(far[3]), Convert.ToSingle(far[4]));


                    obB.CalcEval();
                    Resultt.Text = obB.sRes;

                    break;

                default:

                    break;

            } //end swith


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                Eval obT = new Eval(Convert.ToSingle(BitVal.Text), Convert.ToSingle(LoLiScale.Text), Convert.ToSingle(UpLiScale.Text), Convert.ToSingle(qvant.Text));
                obT.CalcEval();
                Resultt.Text = obT.sRes + "";

            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Eval obU = new Eval(Convert.ToSingle(BitVal.Text), Convert.ToSingle(LoLiScale.Text), Convert.ToSingle(UpLiScale.Text), Convert.ToSingle(qvant.Text));
            obU.CalcEval();
            Resultt.Text = obU.sRes + "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
