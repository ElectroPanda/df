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


            ver = "v. 0.3.1 (SharpDevelop 4.4)";
            label6.Text = ver;
            
            far = Environment.GetCommandLineArgs();
            stArr fae = new stArr(far);
            
            if (far.Length > 2) //Заполнение текстовых полей формы аргументами командной строки
            {
                BitVal.Text = far[1];
                if (far.Length > 2) { LoLiScale.Text = far[2]; }
                if (far.Length > 3) { UpLiScale.Text = far[3];}
                if (far.Length > 4) { qvant.Text = far[4]; }
            }
            else
            {
            	Calc.Enabled=false;
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
                    
                    UpLiScale.Text = obQ.iRend + "";
                    qvant.Text = obQ.iCodRange+"";
                    Resultt.Text = obQ.sRes;
                    break;

                case 4:
                    Eval obA = new Eval(Convert.ToSingle(far[1]), Convert.ToSingle(far[2]), Convert.ToSingle(far[3]));


                    obA.CalcEval();
                    
                    qvant.Text = obA.iCodRange + "";
                    Resultt.Text = obA.sRes;
                    
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
        
        void ef(object sender, KeyEventArgs e)
        {
        	//Calc.Enabled=true;
        	//if (UpLiScale.Text=="" & LoLiScale.Text!="") {UpLiScale.Text=Convert.ToString(-1*(Convert.ToSingle(LoLiScale.Text)));}
        }
        
        void dfg(object sender, EventArgs e)
        {
        	//Calc.Enabled=true;
        	//if (UpLiScale.Text=="" & LoLiScale.Text!="") {UpLiScale.Text=Convert.ToString(-1*(Convert.ToSingle(LoLiScale.Text)));}
        }
        
        void erte(object sender, EventArgs e)
        {
        	
        	if (UpLiScale.Text=="" & LoLiScale.Text!="") {UpLiScale.Text=Convert.ToString(-1*(Convert.ToSingle(LoLiScale.Text)));}
        }
        
        void sgdh(object sender, EventArgs e)
        {
        	Calc.Enabled=true;
        	button1.Enabled=true;
        	button2.Enabled=true;
        	qvant.Text="65536";
        }
        
        void Button1Click(object sender, EventArgs e)
        {
        	//Заморозка
        	Calc.Enabled=false;
        	BitVal.Enabled=false;
        	LoLiScale.Enabled=false;
        	UpLiScale.Enabled=false;
        	qvant.Enabled=false;
        	Resultt.Enabled=false;
        	button1.Enabled=false;
        	
        }
    }
}
