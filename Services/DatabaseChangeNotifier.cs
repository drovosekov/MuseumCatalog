using System;
using System.IO;
using System.Windows.Forms;

namespace MuseumCatalog.Services
{
    public class DatabaseChangeNotifier : IDisposable
    {
        private readonly string _dbPath;
        private readonly string _walPath;
        private readonly Timer _timer;
        private DateTime _lastDbWrite;
        private DateTime _lastWalWrite;
        private bool _paused;

        public bool Paused { get => _paused; set => _paused = value; }

        public event EventHandler DataChanged;

        public DatabaseChangeNotifier(string dbPath, int intervalMs = 3000)
        {
            _dbPath = dbPath;
            _walPath = dbPath + "-wal";
            _timer = new Timer { Interval = intervalMs };
            _timer.Tick += OnTimerTick;
        }

        public void Start()
        {
            _lastDbWrite = SafeGetWriteTime(_dbPath);
            _lastWalWrite = SafeGetWriteTime(_walPath);
            _timer.Start();
        }

        public void Stop() => _timer.Stop();

        public void MarkPaused() => Paused = true;

        public void Unpause()
        {
            Paused = false;
            _lastDbWrite = SafeGetWriteTime(_dbPath);
            _lastWalWrite = SafeGetWriteTime(_walPath);
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            if (Paused) return;

            DateTime dbTime = SafeGetWriteTime(_dbPath);
            DateTime walTime = SafeGetWriteTime(_walPath);

            if (dbTime != _lastDbWrite || walTime != _lastWalWrite)
            {
                _lastDbWrite = dbTime;
                _lastWalWrite = walTime;
                DataChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        private static DateTime SafeGetWriteTime(string path)
        {
            try
            {
                return File.GetLastWriteTime(path);
            }
            catch
            {
                return DateTime.MinValue;
            }
        }

        public void Dispose()
        {
            _timer.Stop();
            _timer.Dispose();
        }
    }
}
