namespace KPZ_Lab3.Adapter
{
    internal class FileLoggerAdapter : Logger
    {
        private readonly FileWriter _writer;

        public FileLoggerAdapter(FileWriter writer)
        {
            _writer = writer;
        }

        public override void Log(string message)
        {
            _writer.WriteLine("[LOG] " + message);
        }

        public override void Error(string message)
        {
            _writer.WriteLine("[ERROR] " + message);
        }

        public override void Warn(string message)
        {
            _writer.WriteLine("[WARN] " + message);
        }
    }
}
