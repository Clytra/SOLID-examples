using System.Collections.Generic;

namespace SRP
{
    public class Journal
    {
        private readonly List<string> _entries = new List<string>();
        private static int _count = 0;

        public void AddEntry(string text)
        {
            _entries.Add($"{++_count}: {text}");
        }

        public void RemoveEntry(int index)
        {
            _entries.RemoveAt(index);
        }
    }
}
