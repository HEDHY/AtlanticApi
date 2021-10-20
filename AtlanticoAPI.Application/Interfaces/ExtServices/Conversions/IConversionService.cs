using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AtlanticoAPI.Application.Interfaces.ExtServices.Conversions
{
    
    public interface IConversionService
    {
        Task<string> GetRate(string currency);
    }
}
