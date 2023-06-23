

namespace _2048WinFormsApp
{
    public partial class PlayersResults : Form
    {
        public PlayersResults()
        {
            InitializeComponent();
        }

        private void PlayersResults_Load(object sender, EventArgs e)
        {
            var results = PlayersResultsStorage.GetPlayersResults().OrderByDescending(x => x.Score);
            foreach (var player in results)
            {
                resultTable.Rows.Add(player.Name, player.Score);
            }
        }

    }
}
