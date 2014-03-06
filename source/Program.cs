using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace argt
{
    class stArr 
    {
        string[] superArr;

        public stArr(string[] asd)
        {
            this.superArr = asd;

        }
    }


    public class Eval //Объявление основного класса
    {
        public float iCodVal, iRstart, iRend, iCodRange;
        public float fRes;
        public string sCodVal;
        public string sRes;



        public Eval(float iA, float iB)
            : this(iA, iB, (iB * (-1)))
        //Конструктор с двумя аргументами (физическое значение, нижняя граница диапазона)
        //Подставляет верхнюю границу диапазона и передают всё конструктрру с тремя аргументами
        { } //End Eval 2arg constr


        public Eval(float iA, float iB, float iC)
            : this(iA, iB, iC, 65536)
        //Конструктор с тремя аргументами подставляет в качестве разрядности АЦП значение по умолчанию 65536
        { }// End Eval 3arg const

        public Eval(float iA, float iB, float iC, float iD)
        //основной конструктор присваивает значения полям класса
        {
            this.iCodVal = iA;
            this.iRstart = iB;
            this.iRend = iC;
            this.iCodRange = iD;
        } //end eval 4arg const



       

        public void CalcEval()
        {

            this.fRes = this.iCodRange / (Math.Abs(this.iRstart) + Math.Abs(this.iRend)); //Рассчёт значения
            this.fRes = this.iCodVal / this.fRes;
            this.fRes = this.fRes + this.iRstart;

            if (this.iCodVal > this.iCodRange) //Проверка на превышение диапазона
            {
                this.sRes = "Invalid value!!! "; //Подложное значение результата в случае проблемы 
              //  this.sCodVal = "Invalid value!!! ";
            }
            else
            {
                this.sRes = this.fRes + ""; //Формирование строчек итоговых значений
                this.sCodVal = this.iCodVal + " binary  value ";
            }



        } //End CalcEval

    
    } 
    
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            stArr GF = new stArr(args);

            
        }
    }
}
