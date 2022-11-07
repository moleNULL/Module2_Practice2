namespace Module2_Practice2.Printers
{
    public class FilePrinter : IPrinter
    {
        private string _path;

        public FilePrinter(string path)
        {
            _path = path;
        }

        public void Print(string data)
        {
            File.AppendAllText(_path, data + "\n");
        }
    }
}
