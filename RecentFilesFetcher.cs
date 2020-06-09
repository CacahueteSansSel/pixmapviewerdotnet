using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nightek.PBM
{
    public static class RecentFilesFetcher
    {
        static List<string> fetchedFiles;
        public static bool AutoSave { get; set; } = true;

        public static string[] Fetch()
        {
            if (fetchedFiles != null)
                return fetchedFiles.ToArray();

            if (File.Exists(Application.StartupPath + "/recent"))
            {
                fetchedFiles = new List<string>();
                string[] files = File.ReadAllLines(Application.StartupPath + "/recent");
                foreach (string file in files)
                {
                    if (!File.Exists(file)) continue;
                    fetchedFiles.Add(file);
                }
            }

            return fetchedFiles == null ? new string[0] : fetchedFiles.ToArray();
        }

        public static void Append(string Filename)
        {
            fetchedFiles.Add(Filename);

            if (AutoSave)
                Save();
        }

        public static bool Contains(string Filename)
            => fetchedFiles.Count(file => file == Filename) > 0;

        public static void Save()
        {
            File.WriteAllLines(Application.StartupPath + "/recent", fetchedFiles.ToArray());
        }
    }
}
