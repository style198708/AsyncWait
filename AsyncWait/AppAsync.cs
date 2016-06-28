using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncWait
{
    public class AppAsync
    {
        public AppAsync()
        {
            Console.WriteLine("MyClass() End."); 
        }
        /// <summary>
        /// 加法
        /// </summary>
        /// <returns></returns>
        public Task<double> GetValueAsync(double num1, double num2)
        {
            return Task.Run<double>(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    num1 = num1 + num2;
                }
                return num1;
            });
        }

        /// <summary>
        /// 异步方法(例子)
        /// </summary>
        public async Task<double> DisplayValue(double num1, double num2)
        {
            return await Task<double>.Run<double>(() =>
             {
                 for (int i = 0; i < 1000000; i++)
                 {
                     num1 = num1 + num2;
                 }
                 return num1;
             });
        }
    }
}
