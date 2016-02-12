using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Configuration;
using Microsoft.Owin.FileSystems;
using Microsoft.Owin.StaticFiles;

namespace SehoOne
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var siteRoot = Settings.Instance.SiteRoot;
            var physicalFileSystem = new PhysicalFileSystem(siteRoot); 
            var options = new FileServerOptions
            {
                EnableDefaultFiles = true,
                FileSystem = physicalFileSystem
            };
            options.StaticFileOptions.FileSystem = physicalFileSystem;
            options.StaticFileOptions.ServeUnknownFileTypes = true;
            options.DefaultFilesOptions.DefaultFileNames = new[]
            {
                "index.html"
            };

            app.UseFileServer(options);
        }
    }
}
