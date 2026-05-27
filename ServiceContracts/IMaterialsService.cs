using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceContracts
{
    public interface IMaterialsService
    {
        Task<double> CalculateEnvironmentalIndex(string materialName);
    }
}
