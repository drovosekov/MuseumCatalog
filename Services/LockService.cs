using System;
using MuseumCatalog.Data;

namespace MuseumCatalog.Services
{
    public class LockService
    {
        private readonly LockRepository _repo;

        public LockService(string dbPath)
        {
            _repo = new LockRepository(dbPath);
        }

        public string TryLock(int exhibitId, string pcIdentifier)
        {
            return _repo.TryLock(exhibitId, pcIdentifier);
        }

        public void Unlock(int exhibitId, string pcIdentifier)
        {
            _repo.Unlock(exhibitId, pcIdentifier);
        }

        public void CleanupStaleLocks(TimeSpan maxAge)
        {
            _repo.CleanupStaleLocks(maxAge);
        }
    }
}
