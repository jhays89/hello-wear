using HelloWear.Handlers;
using HelloWear.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWear.Factories
{
    public static class ClickHanlderFactory
    {
        public static IIncrementClickHanlder CreateIncrementClickHandlerFactory(Activity activity)
        {
            return new IncrementClickHanlder(activity);
        }
    }
}
