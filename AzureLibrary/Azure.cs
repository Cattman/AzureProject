using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("AzureTest")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
namespace AzureLibrary
{
    public class Azure
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
