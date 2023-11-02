using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using NEW_STATHAM.Models;

namespace NEW_STATHAM.Services
{
    public class readDataJson
    {
        private readonly string PATH;
        public readDataJson(string path)
        {
            PATH = path;
        }
        public BindingList<allPolls> loadData()
        {
            var fileExists = File.Exists(PATH);
            if (!fileExists)
            {
                File.CreateText(PATH).Dispose();
                return new BindingList<allPolls>();
            }
            using (var reader = File.OpenText(PATH))
            {
                var fileText = reader.ReadToEnd();
                return JsonSerializer.Deserialize<BindingList<allPolls>>(fileText);
            }
        }

        public void SaveData(object _allPollsData, string path)
        {
            using (var writer = File.CreateText(path))
            {
                string output = JsonSerializer.Serialize(_allPollsData);
                writer.Write(output);
            }
        }
    }
    public class readDataJson2
    {
        private readonly string PATH;
        public readDataJson2(string path)
        {
            PATH = path;
        }
        public BindingList<allPolls2> loadData()
        {
            var fileExists = File.Exists(PATH);
            if (!fileExists)
            {
                File.CreateText(PATH).Dispose();
                return new BindingList<allPolls2>();
            }
            using (var reader = File.OpenText(PATH))
            {
                var fileText = reader.ReadToEnd();
                return JsonSerializer.Deserialize<BindingList<allPolls2>>(fileText);
            }
        }

        public void SaveData(object _allPollsData, string path)
        {
            using (var writer = File.CreateText(path))
            {
                string output = JsonSerializer.Serialize(_allPollsData);
                writer.Write(output);
            }
        }
    }
}
