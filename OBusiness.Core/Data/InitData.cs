using MongoDB.Driver;
using OBusiness.Core.Domain.Models;
using Pluralize.NET.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBusiness.Core.Data
{
    public class InitData
    {

        MongoDatabase db;
        public InitData(MongoDatabase db)
        {
            this.db = db;
        }
        public void GenerateEssentialData()
        {

        }
        public void GenerateTestData(string rootPath)
        {

            var entities = typeof(Category).Assembly.GetTypes().Where(t => typeof(BaseEntity).IsAssignableFrom(t)).ToList();
            foreach (var entity in entities)
            {
                // ImportData(entity, rootPath);
            }

        }
        private void ImportData<T>(T modelType, string rootPath)
        {
            if (db.GetCollection<T>((modelType as Type).Name).EstimatedDocumentCount() == 0)
            {
                var options = new
                {
                    WriteIndented = true,
                };
                Pluralizer pluralizer = new Pluralizer();
                var fileName = pluralizer.Pluralize((modelType as Type).Name);

                var path = Path.Combine(rootPath, "Data", "Test", $"{fileName}.json");
                if (File.Exists(path))
                {
                    var command = $" /d Beauty /c {fileName}  /file {path} /mode:merge --jsonArray";
                    var p = Process.Start("mongoimport", command);
                    p.StartInfo.FileName = "mongoimport.exe";
                    p.StartInfo.Arguments = command;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.CreateNoWindow = true;
                    p.OutputDataReceived += (sender, args) => Console.WriteLine("received output: {0}", args.Data);
                    p.Start();
                    p.BeginOutputReadLine();
                }

            }

        }
        public async Task CreateIndexes()
        {
            //store id index
            var menuCollection = db.GetCollection<Menu>();
            var storeIdIndex = Builders<Menu>.IndexKeys.Ascending(x => x.StoreId);
            var storeIdModel = new CreateIndexModel<Menu>(storeIdIndex);
            await menuCollection.Indexes.CreateOneAsync(storeIdModel);
        }
    }
}
