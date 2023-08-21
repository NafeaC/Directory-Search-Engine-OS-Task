using System.ComponentModel;

namespace task_os
{
    public partial class Form1 : Form
    {
        private Searcher searcher;

        public Form1()
        {
            InitializeComponent();
            this.searcher = new Searcher(null, null);
            this.searcher.OnFilleFound += FilleFound;
            bgWorker.DoWork += WorkInbachground;
            bgWorker.RunWorkerCompleted += WorkerCompleted;



        }

        private void FilleFound(string path)
        {

            lbFilleFound.BeginInvoke((Action)delegate ()
            {
                lbFilleFound.Items.Add(path);
            });
            
             
        }
        private void WorkerCompleted(object sender, RunWorkerCompletedEventArgs args)
        {
            MessageBox.Show("Done!");
        }
        private void WorkInbachground(object sender, DoWorkEventArgs args)
        {
            searcher.search();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.searcher.Term = tpTerm.Text;
            this.searcher.Dir = tbSearchDir.Text;
            bgWorker.RunWorkerAsync();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}