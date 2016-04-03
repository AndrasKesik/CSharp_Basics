using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerEvents
{
    public partial class Form : System.Windows.Forms.Form
    {
        Timer t;
        public Form()
        {
            InitializeComponent();  
        }
       

        private void Form_Load(object sender, EventArgs e)
        {
            t = new Timer();
            t.Interval = 1000;
            t.Tick += t_Tick;

            t.Start();
        }

        void t_Tick(object sender, EventArgs e)
        {
            progressBar.Value += 10;
            if (progressBar.Value >= 100) t.Stop();
        }
    }
}
