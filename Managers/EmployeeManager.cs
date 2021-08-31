using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Managers
{
    public class YearManager
    {
        private static readonly sbyte monthsAmount = 12;
        private static List<sbyte> GenerateRandomEmployeeData()
        {
            var result = new List<sbyte>();
            for (sbyte i = 0; i < monthsAmount; i++)
            {
                Random rnd = new Random();
                result.Add((sbyte)rnd.Next(3, 50));
            }
            return result;
        }

        public static async Task<List<sbyte>> GetEmpData() => await Task.Run(() => GenerateRandomEmployeeData());
    }
}
