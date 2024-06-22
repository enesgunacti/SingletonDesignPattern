using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
     sealed class UploadService
    {
        private UploadService()
        {
            
        }
        public int Id { get; set; }
        private static readonly object _lock = new object();

        private static UploadService _instance;

        public static UploadService Instance (int id)
        {
            if (_instance == null)
            {
               lock (_lock)
                {
                    if(_instance == null) 
                    {
                        _instance = new UploadService(); 
                        _instance.Id = id;
                    }                   
                }              
            }
            return _instance;
        }
    }
}
