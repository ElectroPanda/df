using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
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
