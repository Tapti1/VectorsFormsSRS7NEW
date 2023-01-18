using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorsForms
{
    internal class ObjectWatcher
    {
        private static ObjectWatcher _instance = new ObjectWatcher();
        private ObjectWatcher() { }

        public static ObjectWatcher GetInstance()
        {
            return _instance;
        }
        private Dictionary<string, DomainObject> _objectsMap = new Dictionary<string, DomainObject>();
        public DomainObject GetObject(string object_id)
        {
            if (_objectsMap.ContainsKey(object_id))
            {
                Console.WriteLine("Получаем ссылку на объект из списка");
                return _objectsMap[object_id];
            }
            else
            {
                Console.WriteLine("В списке объекта нет");
                return null;
            }
        }
        public void Add(string object_id, DomainObject obj)
        {
            _objectsMap[object_id] = obj;
        }
    }
}
