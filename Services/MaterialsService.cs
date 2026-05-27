using Entities;
using RepositoryContracts;
using ServiceContracts;
using System;
using System.Collections.Generic;
using System.Text;
 

namespace Services
{
    public class MaterialsService : IMaterialsService
    {
        private readonly IMaterialsRepository _materialsRepository;
        private const double Co2Weight = 0.30;
        private const double WaterWeight = 0.20;
        private const double ChemicalWeight = 0.20;
        private const double RecyclabilityWeight = 0.15;
        private const double AnimalWelfareWeight = 0.15;
        public MaterialsService(IMaterialsRepository materialsRepository) 
        {
            _materialsRepository = materialsRepository;
        }

        public async Task<double> CalculateEnvironmentalIndex(string materialName)
        {
            MaterialImpact materialImpact = await _materialsRepository.GetMaterialImpact(materialName);

            if (materialImpact == null)
            {
                return 0;
            }

            double result = (
                materialImpact.Co2Score * Co2Weight +
                materialImpact.WaterScore * WaterWeight +
                materialImpact.ChemicalScore * ChemicalWeight +
                materialImpact.RecyclabilityScore * RecyclabilityWeight +
                materialImpact.AnimalWelfareScore * AnimalWelfareWeight
                ) / 10.0;

            return Math.Round(result, 1);
        }

       
    }
}
