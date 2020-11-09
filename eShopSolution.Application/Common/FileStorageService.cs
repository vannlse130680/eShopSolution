using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Common
{
    public class FileStorageService : IStorageService
    {
        private readonly string _userContentFolder;
        private const string USER_CONTENT_FOLDER_NAME = "user-content";

        // add frameworkrefference 
        public FileStorageService(IWebHostEnvironment webHostEnvironment)
        {
            _userContentFolder = Path.Combine(webHostEnvironment.WebRootPath, USER_CONTENT_FOLDER_NAME);
        }
        public Task DeleteFileAsync(string fileName)
        {
            throw new NotImplementedException();
        }

        public string GetFileUrl(string fileName)
        {
            throw new NotImplementedException();
        }

        public Task SaveFileAsync(Stream mediaBinaryStream, string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
