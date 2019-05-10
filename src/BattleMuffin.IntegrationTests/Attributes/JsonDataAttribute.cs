using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using Xunit.Sdk;

namespace BattleMuffin.IntegrationTests.Attributes
{
    public class JsonDataAttribute : DataAttribute
    {
        private readonly string _filePath;

        /// <summary>
        ///     Load data from a JSON file as the data source for a theory
        /// </summary>
        /// <param name="filePath">The absolute or relative path to the JSON file to load</param>
        public JsonDataAttribute(string filePath)
        {
            _filePath = filePath;
        }

        /// <inheritDoc />
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            if (testMethod == null)
            {
                throw new ArgumentNullException(nameof(testMethod));
            }

            // Get the absolute path to the JSON file
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Data", _filePath);

            if (!File.Exists(path))
            {
                throw new ArgumentException($"Could not find file at path: {path}");
            }

            // Load the file
            var fileData = File.ReadAllText(path);

            // Deserialize the data
            return JsonConvert.DeserializeObject<IEnumerable<object[]>>(fileData);
        }
    }
}
