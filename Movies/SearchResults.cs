using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies
{
    public partial class SearchResults : Form
    {
        public SearchResults()
        {
            InitializeComponent();
        }

        private void SearchResults_Load(object sender, EventArgs e)
        {
            var result = Repository.GetAllMovies();

            //TODO: FILTER !!!
            
            lstResults.DataSource = result.ToArray();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = Repository.GetAllMovies().Where(film=>film.ReleaseYear >= 1990 && film.ReleaseYear <= 1999);

            //TODO: FILTER !!!

            lstResults.DataSource = result.ToArray();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //film med 3 actors
            var result = Repository.GetAllMovies().Where(film => film.Actors.Count() == 3 );

            //TODO: FILTER !!!

            lstResults.DataSource = result.ToArray();
        }
    }
}
