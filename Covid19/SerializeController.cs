﻿using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Covid19
{
    public class SerializeController
    {
        public SerializeController()
        {
        }
        /* public void Serialize(object obj , string directory, string filename)
         {
             CreateDirectory(directory);
             IFormatter formatter = new BinaryFormatter();
             Stream stream = new FileStream(@"~/" + directory + "/" + filename, FileMode.Create, FileAccess.Write);

             formatter.Serialize(stream,obj);
             stream.Close();
         }
           public object DesSerialize(string directory, string filename)
           {
               CreateDirectory(directory);

               object re = null;
               if (File.Exists(@"~/" + directory + "/" + filename))
               {
                   IFormatter formatter = new BinaryFormatter();
                   Stream stream = new FileStream(@"~/" + directory + "/" + filename, FileMode.Open, FileAccess.Read);

                   re = formatter.Deserialize(stream);

                   stream.Close();
               }
               return re;


           }


                private void CreateDirectory(string directory)
        {
            if (!Directory.Exists(@"~/" + directory))
            {
                Directory.CreateDirectory(@"~/" + directory);
            }
        }
        */

        public void Serialize(object obj, string filename)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(filename, FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, obj);
            stream.Close();
        }
        public object DesSerialize(string filename)
        {

            object re = null;
            if (File.Exists(filename))
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(filename, FileMode.Open, FileAccess.Read);

                re = formatter.Deserialize(stream);

                stream.Close();
            }
            return re;
        }


    }

}
