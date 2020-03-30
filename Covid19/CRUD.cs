using System;
using System.Collections.Generic;

namespace Covid19
{
    public class CRUD
    {
        public CRUD()
        {
        }
        public static readonly SerializeController serializeController = new SerializeController();

        public static void AddS<Datos>(List<Datos> listado, Datos item, string filename)
        {
            listado.Add(item);
            serializeController.Serialize(listado, filename);
        }
        public static void Add<T>(List<T> list, T item)
        {
            list.Add(item);
        }
        public static T GetElement<T>(List<T> list, int index)
        {
            return list[index];
        }
    }
}
