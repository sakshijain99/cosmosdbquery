using cosmosdbquery;
using Microsoft.Azure.Cosmos;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ChoETL;
using Newtonsoft.Json;
using System.Net;
using System.Runtime.CompilerServices;

namespace program
{
    public class mainclass
    {

        
        public static async Task Main(string[] args)
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;
            process methodobject = new process();

            await methodobject.Readfromdb();
       
        }
    }
}


