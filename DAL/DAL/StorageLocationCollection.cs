using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Interface;

namespace DAL
{
    public class StorageLocationCollection : IEnumerable<StorageLocationModel>,
        ISplitePageQuery<StorageLocationModel>
    {


        private List<StorageLocationModel> storageLocations;
        public StorageLocationCollection()
        {
            storageLocations = new List<StorageLocationModel>();
            storageLocations.Add(new StorageLocationModel { ProductName = "1", LocationName = "位置1", ManufacturerName = "厂家1" });
            storageLocations.Add(new StorageLocationModel { ProductName = "2", LocationName = "位置2", ManufacturerName = "厂家2" });
            storageLocations.Add(new StorageLocationModel { ProductName = "3", LocationName = "位置3", ManufacturerName = "厂家3" });
            storageLocations.Add(new StorageLocationModel { ProductName = "4", LocationName = "位置4", ManufacturerName = "厂家4" });
            storageLocations.Add(new StorageLocationModel { ProductName = "5", LocationName = "位置5", ManufacturerName = "厂家5" });
            storageLocations.Add(new StorageLocationModel { ProductName = "6", LocationName = "位置6", ManufacturerName = "厂家6" });
            storageLocations.Add(new StorageLocationModel { ProductName = "7", LocationName = "位置7", ManufacturerName = "厂家7" });
            storageLocations.Add(new StorageLocationModel { ProductName = "8", LocationName = "位置8", ManufacturerName = "厂家8" });
            storageLocations.Add(new StorageLocationModel { ProductName = "9", LocationName = "位置9", ManufacturerName = "厂家9" });
            storageLocations.Add(new StorageLocationModel { ProductName = "10", LocationName = "位置10", ManufacturerName = "厂家10" });
            storageLocations.Add(new StorageLocationModel { ProductName = "11", LocationName = "位置11", ManufacturerName = "厂家11" });
            storageLocations.Add(new StorageLocationModel { ProductName = "12", LocationName = "位置12", ManufacturerName = "厂家12" });
            storageLocations.Add(new StorageLocationModel { ProductName = "13", LocationName = "位置12", ManufacturerName = "厂家12" });
            storageLocations.Add(new StorageLocationModel { ProductName = "14", LocationName = "位置12", ManufacturerName = "厂家12" });
            storageLocations.Add(new StorageLocationModel { ProductName = "15", LocationName = "位置12", ManufacturerName = "厂家12" });
            storageLocations.Add(new StorageLocationModel { ProductName = "16", LocationName = "位置12", ManufacturerName = "厂家12" });
            storageLocations.Add(new StorageLocationModel { ProductName = "17", LocationName = "位置12", ManufacturerName = "厂家12" });
            storageLocations.Add(new StorageLocationModel { ProductName = "18", LocationName = "位置12", ManufacturerName = "厂家12" });
            storageLocations.Add(new StorageLocationModel { ProductName = "19", LocationName = "位置12", ManufacturerName = "厂家12" });
            storageLocations.Add(new StorageLocationModel { ProductName = "20", LocationName = "位置12", ManufacturerName = "厂家12" });
            storageLocations.Add(new StorageLocationModel { ProductName = "21", LocationName = "位置12", ManufacturerName = "厂家12" });
            storageLocations.Add(new StorageLocationModel { ProductName = "22", LocationName = "位置12", ManufacturerName = "厂家12" });

        }

        public List<StorageLocationModel> StorageLocations { get { return storageLocations; } }

        public IEnumerator<StorageLocationModel> GetEnumerator()
        {
            return StorageLocations.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return StorageLocations.GetEnumerator();
        }

        public IEnumerable<StorageLocationModel> MoveNextPage(int pageNum, int size)
        {
            return GetEntities(pageNum, size);
        }

        public IEnumerable<StorageLocationModel> MovePreviousPage(int pageNum, int size)
        {
            return GetEntities(pageNum, size);
        }

        public IEnumerable<StorageLocationModel> MoveLastPage(int pageNum, int size)
        {
            return GetEntities(pageNum, size);
        }

        public IEnumerable<StorageLocationModel> MoveFirstPage(int pageNum, int size)
        {
            return GetEntities(pageNum, size);
        }

        public IEnumerable<StorageLocationModel> GetEntities(int pageNum, int size)
        {
            return StorageLocations.Skip<StorageLocationModel>(pageNum * size).Take(size);
        }


        public long GetCount()
        {
           return StorageLocations.Count;
        }
    }
}
