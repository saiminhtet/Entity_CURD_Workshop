using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework_CURD
{
    public partial class frm_movie_lst : Form
    {
        DafestyVideoEntities context = new DafestyVideoEntities();
        public frm_movie_lst()
        {
            InitializeComponent();
        }

        private void btn_retrieve_Click(object sender, EventArgs e)
        {
            //TEsting Git Push by Han
            //4a. Retrieve the movie with code 5 (Nemesis)
            dtaGV.DataSource = context.Movies.Where(x => x.VideoCode == 11).ToList();
            toolStripLabel1.Text = "Retrieved!";


        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //4b. Update the rental cost of this movie to $1.80
            Movie m = context.Movies.Where(x => x.VideoCode == 5).First();
            m.RentalCost = (float)1.8;
            context.SaveChanges();
            toolStripLabel1.Text = "Updated!";
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            //4c. Create a new Movie with id 400, name of the movie is Sully, genere is Drama,
           // Producer is Warner Brothers, rental price is $2.50, Rating is U, number of copies
           //(total stock) is 4.
            Movie m = new Movie();
            m.VideoCode = 400;
            m.MovieTitle = "Sully";
            m.Genre = "Drama";
            m.ProducerID = "Warner";
            m.RentalCost = (float)2.5;
            m.TotalStock = 4;

            context.Movies.Add(m);
            context.SaveChanges();

            toolStripLabel1.Text = "Created!";
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            //4d. Modify the Producer of Demolition Man (code 4) from Universal to Pixar. Alter the
            //association from Movie object(1 - side).

            Movie m = context.Movies.Where(x => x.VideoCode == 4).First();
            m.ProducerID = "Pixar";
            context.SaveChanges();
            toolStripLabel1.Text = "Changed!";
        }

        private void btn_edit_die_hard_Click(object sender, EventArgs e)
        {
            //4e.Modify the Producer of Die Hard 2(code 11) from Pixar to Warner.Alter the
            //association from the Producer side(n - side)
            Movie m = context.Movies.Where(x => x.VideoCode == 11).First();
            m.ProducerID = "Warner";
            context.SaveChanges();
            toolStripLabel1.Text = "Changed!";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //4f. Delete the movie with code 400.
            Movie m = context.Movies.Where(x => x.VideoCode == 400).First();
            context.Movies.Remove(m);
            context.SaveChanges();

            toolStripLabel1.Text = "Deleted!";
        }
    }
}
