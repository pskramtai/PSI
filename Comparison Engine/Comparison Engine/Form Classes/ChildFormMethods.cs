using System.Windows.Forms;
using Comparison_Engine.Base_Classes;
using Comparison_Engine.Child_Forms;
using Comparison_Engine.Forms;

namespace Comparison_Engine.Form_Classes
{
    class ChildFormMethods
    {
        public static void OpenChildFormMap(Form1 mainApplication)
        {
            MapForm mapForm = new MapForm();
            mainApplication.mainMapForm = mapForm;
            ConfigureChildForm(mapForm, mainApplication);
            mainApplication.map = mapForm.GetMap();
        }


        public static void OpenChildFormBar(Bar bar, Form1 mainApplication)
        {
            BarForm barForm = new BarForm(bar, mainApplication.mainMapForm);
            ConfigureChildForm(barForm, mainApplication);
        }


        public static void OpenChildFormDrink(Drink drink, Form1 mainApplication)
        {
            DrinkForm drinkForm = new DrinkForm(drink, mainApplication.mainMapForm);
            ConfigureChildForm(drinkForm, mainApplication);
        }

        public static void OpenChildFormProfile(Form1 mainApplication)                 //This will probably recieve the user info
        {
            ProfileForm profileForm = new ProfileForm();         //This will probably recieve the user info
            ConfigureChildForm(profileForm, mainApplication);
        }


        private void OpenChildFormUserContribution(Drink drink, Bar bar, Form1 mainApplication)
        {
            Child_Forms.UserContribution userContribution = new UserContribution(drink, bar);
            //CloseActiveForm();            //#commentedarea
            ConfigureChildForm(userContribution, mainApplication);
        }

        public static void ConfigureChildForm(Form childForm, Form1 mainApplication)
        {
            if (mainApplication.activeForm != null && mainApplication.activeForm.GetType() != mainApplication.mainMapForm.GetType())
            {
                CloseActiveForm(mainApplication);
            }
            mainApplication.activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainApplication.panelMain.Controls.Add(childForm);
            mainApplication.panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public static void CloseActiveForm(Form1 mainApplication)
        {
            mainApplication.activeForm.Close();
        }
    }
}
