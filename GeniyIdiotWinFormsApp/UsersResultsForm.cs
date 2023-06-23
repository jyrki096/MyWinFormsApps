using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class UsersResultsForm : Form
    {
        public UsersResultsForm()
        {
            InitializeComponent();
            var results = UsersResultStorage.GetUsersResults();

            foreach (var user in results)
            {
                resultTable.Rows.Add(user.Name, user.CountRightAnswers, user.Diagnosis);
            }
        }

        
    }
}
