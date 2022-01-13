using lab1.Models;

namespace lab1.Storage
{
    public class StorageService
    {
        private readonly IStorage<Flat> _storage;

        public StorageService(IStorage<Flat> storage)
        {
            _storage = storage;
        }

        public string GetStorageType()
        {
            return _storage.StorageType;
        }

        public int GetNumberOfItems()
        {
            return _storage.All.Count;
        }
    }
}