

namespace GeniyIdiotWinFormsApp
{
    
    public partial class UserNameForm : Form
    {
        
        public string UserName = "Неизвестно";
        public UserNameForm()
        {
            InitializeComponent();        
        }

        

        private void okButton_Click(object sender, EventArgs e)
        {
            var name = userNameTextBox.Text;

            if (name == "")
            {
                MessageBox.Show("Введите имя!");
            }
            else
            {
                UserName = name;
                Close();
            }
        }

    }
}
