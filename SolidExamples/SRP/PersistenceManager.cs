using System.IO;

namespace SRP
{
    public class PersistenceManager
    {
        public void SaveToFile(Journal journal, string fileName,
            bool overwrite = false)
        {
            if (overwrite || !File.Exists(fileName))
                File.WriteAllText(fileName, journal.ToString());
        }
    }
}
