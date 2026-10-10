using BaobabWildlifeRehab.Data;
using System.Windows.Forms;
using BaobabWildlifeRehab.Models;

namespace BaobabWildlifeRehab.Data
{
    // Data layer base: holds the shared list, the file paths and the parsing helpers.
    // Each feature adds its own methods in AnimalData.<Feature>.cs.
    internal partial class AnimalData
    {
        // The grid binds to this ONCE. Features edit this list AND the file, so the grid stays current.
        public BindingSource DataSource { get; } = new BindingSource();

        // Both files live beside the running .exe.
        public string AnimalsFilePath { get; } = "animals.txt";
        public string SummaryFilePath { get; } = "summary.txt";

        // Converts an Animal to one pipe-separated file line.
        public string ToLine(Animal animal)
        {
            // TODO
            throw new NotImplementedException();
        }

        // Tries to convert a file line to an Animal; returns false if the line is malformed.
        public bool TryParseLine(string line, out Animal animal)
        {
            // TODO
            throw new NotImplementedException();
        }

    }
}