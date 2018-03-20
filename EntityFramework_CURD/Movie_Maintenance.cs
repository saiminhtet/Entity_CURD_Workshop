using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework_CURD
{
    public partial class frm_Movie_Maintenance : Form
    {
        DafestyVideoEntities ctx = new DafestyVideoEntities();
        public frm_Movie_Maintenance()
        {
            InitializeComponent();
            disable();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            Movie m = ctx.Movies.OrderBy(x => x.VideoCode).First();
            txt_v_code.Text = m.VideoCode.ToString();
            txt_M_title.Text = m.MovieTitle;
            txt_m_genre.Text = m.Genre;
            txt_r_cost.Text = m.RentalCost.ToString();

            toolStripLabel1.Text = "Loaded!";
            enable();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var v_code = Convert.ToInt16(txt_v_code.Text);         
            Movie m = ctx.Movies.Where(x => x.VideoCode == v_code).First();
            m.MovieTitle = txt_M_title.Text;
            m.Genre = txt_m_genre.Text;
            m.RentalCost = float.Parse(txt_r_cost.Text);
            ctx.SaveChanges();
            toolStripLabel1.Text = "Updated!";
            clear();
        }

        
        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                Movie m = new Movie();
                m.VideoCode = Convert.ToInt16(txt_v_code.Text);
                m.MovieTitle = txt_M_title.Text;
                m.Genre = txt_m_genre.Text;
                m.RentalCost = float.Parse(txt_r_cost.Text);

                ctx.Movies.Add(m);
                ctx.SaveChanges();

                toolStripLabel1.Text = "Created!";
                clear();

            }
            catch (Exception)
            {
                MessageBox.Show("Data has already existed!", "Movie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

         private void btn_delete_Click(object sender, EventArgs e)
                {
                    try
                    {

                        DialogResult dr = MessageBox.Show("Are you sure you want to Delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            var v_code = Convert.ToInt16(txt_v_code.Text);
                            Movie m = ctx.Movies.Where(x => x.VideoCode == v_code).First();
                            ctx.Movies.Remove(m);
                            ctx.SaveChanges();

                            toolStripLabel1.Text = "Deleted!";
                            clear();
                        }
                        else
                        {
                            return;
                        }
                       

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No Record Found!", "Movie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

            
                }

        private void btn_search_Click(object sender, EventArgs e)
                {
                    try
                    {
                        var v_code = Convert.ToInt16(txt_search.Text);
                        Movie m = ctx.Movies.Where(x => x.VideoCode == v_code).First();
                        txt_v_code.Text = m.VideoCode.ToString();
                        txt_M_title.Text = m.MovieTitle;
                        txt_m_genre.Text = m.Genre;
                        txt_r_cost.Text = m.RentalCost.ToString();

                        toolStripLabel1.Text = "Loaded!";
                        enable();
            }
                    catch (Exception)
                    {

                        MessageBox.Show("No Record Found!", "Movie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            

        }
        private void btn_first_Click(object sender, EventArgs e)
                {
                    Movie m = ctx.Movies.OrderBy(x => x.VideoCode).First();
                    txt_v_code.Text = m.VideoCode.ToString();
                    txt_M_title.Text = m.MovieTitle;
                    txt_m_genre.Text = m.Genre;
                    txt_r_cost.Text = m.RentalCost.ToString();

                    toolStripLabel1.Text = "Loaded!";
                    enable();

                }
        private void btn_last_Click(object sender, EventArgs e)
                {
                    Movie m = ctx.Movies.OrderByDescending(x => x.VideoCode).First();
                    txt_v_code.Text = m.VideoCode.ToString();
                    txt_M_title.Text = m.MovieTitle;
                    txt_m_genre.Text = m.Genre;
                    txt_r_cost.Text = m.RentalCost.ToString();

                    toolStripLabel1.Text = "Loaded!";
                    enable();

                 }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            try
            {
                var v_code = Convert.ToInt16(txt_v_code.Text);
                Movie m = ctx.Movies.OrderByDescending(x => x.VideoCode).Where(x => x.VideoCode < v_code).First();
                txt_v_code.Text = m.VideoCode.ToString();
                txt_M_title.Text = m.MovieTitle;
                txt_m_genre.Text = m.Genre;
                txt_r_cost.Text = m.RentalCost.ToString();

                toolStripLabel1.Text = "Loaded!";

            }
            catch (Exception)
            {

                MessageBox.Show("No Record Found!", "Movie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            try
            {
                var v_code = Convert.ToInt16(txt_v_code.Text);
                Movie m = ctx.Movies.OrderBy(x => x.VideoCode).Where(x=>x.VideoCode > v_code).First();
                txt_v_code.Text = m.VideoCode.ToString();
                txt_M_title.Text = m.MovieTitle;
                txt_m_genre.Text = m.Genre;
                txt_r_cost.Text = m.RentalCost.ToString();

                toolStripLabel1.Text = "Loaded!";
             

            }
            catch (Exception)
            {

                MessageBox.Show("No Record Found!", "Movie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void clear()
        {
            txt_v_code.ResetText();
            txt_M_title.ResetText();
            txt_m_genre.ResetText();
            txt_r_cost.ResetText();
            txt_search.ResetText();
        }
        public void enable()
        {
            txt_v_code.Enabled = Enabled;
            txt_M_title.Enabled = Enabled;
            txt_m_genre.Enabled = Enabled;
            txt_r_cost.Enabled = Enabled;
            btn_update.Enabled = Enabled;
            btn_insert.Enabled = Enabled;
            btn_delete.Enabled = Enabled;
            btn_next.Enabled = Enabled;
            btn_previous.Enabled = Enabled;
            btn_first.Enabled = Enabled;
            btn_last.Enabled = Enabled;

        }

        public void disable()
        {
            txt_v_code.Enabled = false;
            txt_M_title.Enabled = false;
            txt_m_genre.Enabled = false;
            txt_r_cost.Enabled = false;
            btn_update.Enabled = false;
            btn_insert.Enabled = false;
            btn_delete.Enabled = false;
            btn_next.Enabled = false;
            btn_previous.Enabled = false;
            btn_first.Enabled = false;
            btn_last.Enabled = false;
        }

        
    }
}
