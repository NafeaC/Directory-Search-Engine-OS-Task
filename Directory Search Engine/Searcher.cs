using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_os
{

    delegate void FilleFound(string path);


    internal class Searcher
    {
        private string term;
        private string dir;

        public event FilleFound OnFilleFound;

        public Searcher(string dir, string term )
        {
            this.dir = dir;
            this.term = term;
        }

        private void Scan(string dir)
        {
            string[] files = Directory.GetFiles(dir);
            string[] dirs = Directory.GetDirectories(dir);

            List<string> allfiles = new List<string>();
            allfiles.AddRange(files);
            allfiles.AddRange(dirs);

            foreach (string s in allfiles)
            {

                string _s = s.ToLower();
                string _term = this.term.ToLower();

                if (Directory.Exists(s) && s != "." && s != "..")
                {
                    Scan(s);
                    continue;

                }
                ///-------chech for matches

                if (_s.Contains(_term))
                {
                    // implement a delegate
                    OnFilleFound(s);
                }
            }
        }

        public void search()
        {
            Scan(this.dir);
        }

        public string Term
        {
            set { term = value; }
            get { return this. term; }
        }

        public string Dir
        {
            set { dir = value; }
            get { return this.Dir; }

        }
    }
}
