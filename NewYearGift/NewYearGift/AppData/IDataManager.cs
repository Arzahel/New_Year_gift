using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearGift.AppData
{
    public interface IDataManager
    {
        void SaveXml<T>(ref T item, string fname);
        T ReadXml<T>(string fname);

        void SaveJson<T>(ref T item, string fname);
        T ReadJson<T>(string fname);
    }
}
