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
        public MaterialsService(IMaterialsRepository materialsRepository) 
        {
            _materialsRepository = materialsRepository;
        }

        public async Task<double> CalculateEnvironmentalIndex(string materialName)
        {
            MaterialImpact materialImpact = await GetMaterialImpact(materialName);

            if (materialImpact == null)
            {
                return 0;
            }

            double result = (
                materialImpact.Co2Score * 0.30 +
                materialImpact.WaterScore * 0.20 +
                materialImpact.ChemicalScore * 0.20 +
                materialImpact.RecyclabilityScore * 0.15 +
                materialImpact.AnimalWelfareScore * 0.15
                ) / 10.0;

            return Math.Round(result, 1);
        }

        private async Task<MaterialImpact> GetMaterialImpact(string name)
        {
            return await _materialsRepository.GetMaterialImpact(name);
        }

       
    }
}
