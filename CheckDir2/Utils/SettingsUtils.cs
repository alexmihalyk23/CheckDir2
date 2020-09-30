using CheckDir2.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckDir2.Utils
{
    public class SettingsUtils
    {
        public void SaveConfig(Settings config, string fileName)
        {
            using (var writer = new System.IO.StreamWriter(fileName))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(writer, config);
            }
        }
        public Settings LoadConfig(string path)
        {
            return JsonConvert.DeserializeObject<Settings>(File.ReadAllText(path));
        }
        /*
         *  class SettingUtils
    {
        public void Save(string FileName, Settings settings)
        {
            using (var writer = new System.IO.StreamWriter(FileName))
            {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(writer, settings);
                writer.Flush();
            }
        }
        //
        // Сводка:
        //     Сравнивает два указанных объекта System.String (с учетом или без учета регистра)
        //     и возвращает целое число, которое показывает их относительное положение в порядке
        //     сортировки.
        //
        // Параметры:
        //   FileName:
        //     Входная строка.
        //
        // Возврат:
        //     Дезериализованный объект T.
        public Settings Load(string FileName)
        {
            using (var stream = System.IO.File.OpenRead(FileName))
            {
                var serializer = new XmlSerializer(typeof(Settings));
                return serializer.Deserialize(stream) as Settings;
            }
        }
    }
         */
    }
}
