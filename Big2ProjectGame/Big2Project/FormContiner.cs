using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Big2GameApplication
{
    public partial class FormContiner : Form
    {
        private UserControl1 uc;
        private UserControl2 uc2;

        public FormContiner()
        {
            InitializeComponent();
        }

        private void MyUserControl_UserControlButtonClicked(object sender, EventArgs e)
        {
            // change to usercontroll 2 // 
            this.uc2 = new UserControl2();

            // if player have load the score
            if (uc.getsuccRead() == true)
            {
                int[] r = new int[4];
                for (int i = 0; i < 4; i++)
                {
                    r[i] = uc.getplayerscore()[i];
                    Console.WriteLine("Log : " + r[i]);
                }
                Console.WriteLine("Succ");
                uc2.setFileName(uc.getFileName());
                uc2.setScore(uc.getplayerscore());
                uc2.setSuccRead();
            }
            // set score in second page // 
            uc2.SetConScore();
            this.Controls.Clear();
            this.Controls.Add(uc2);          
        }

        private void PageLoad(object sender, EventArgs e)
        {
 
            uc.UserControlButtonClicked += new EventHandler(MyUserControl_UserControlButtonClicked);
        }
    }
}
