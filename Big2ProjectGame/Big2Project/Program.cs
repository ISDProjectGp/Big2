using System;
using System.Windows.Forms;

namespace Big2GameApplication
{

    static class Program
    {
        // The starting point of the program // 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form HomeForm = new FormContiner();

            HomeForm.FormBorderStyle = FormBorderStyle.FixedDialog;        // Fixed the border style // 
            HomeForm.StartPosition = FormStartPosition.CenterScreen;       // Set the starting postion of the form // 
            HomeForm.MaximizeBox = false;                                  // Not allow the form change the size // 
            HomeForm.MinimizeBox = false;                                  // Not allow the form change the size // 
            
            // Run the form // 
            Application.Run(HomeForm);
        }
    }

}
