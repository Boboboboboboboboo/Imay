using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imay.Client
{
    public class Host
    {
        static void Main()
        {
            var service = new ServiceCollection();




        }


        private void Start(IServiceCollection service)
        {
            var provider = service.BuildServiceProvider();


        }
    }
}
