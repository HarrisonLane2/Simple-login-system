using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace loginsystem
{
    public partial class AddUserForm : Form //declaring the adduserform
    {
        UserLogInForm login;      
        public AddUserForm(UserLogInForm y)
        {
            login = y;
            InitializeComponent();//loading the form
        }

        private void AddUsernameBox_TextChanged(object sender, EventArgs e) //run when the text in addusernamebox is changed so they cant submit the form empty
        {
            AddUserButton.Enabled = (AddUsernameBox.Text.Trim() != "" && AddPasswordBox.Text.Trim() != "");//takeing the text that was inputed in the textboxes 
        }

        private void AddUserButton_Click(object sender, EventArgs e)//run when adduserbutton is clicked on
        {
            string[] credentials = { AddUsernameBox.Text, AddPasswordBox.Text };//storing the text box text from the form under credidentials
            if (File.Exists(login.path + "/user.login"))//checking to see if the file is there
                File.Delete(login.path + "/iser.login");//delete the file if there is one 
            File.WriteAllLines(login.path + "/user.login", credentials);//input the users credidentials into the file 
            login.userExists = true;// user now is in the system
            MessageBox.Show("The user " + credentials[0] + " has been added");//message bos saying "The user "the users username" has been added"
            this.Close();//close the form
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
