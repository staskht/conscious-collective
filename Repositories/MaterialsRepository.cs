using Entities;
using RepositoryContracts;

namespace Repositories
{
    public class MaterialsRepository : IMaterialsRepository
    {
        Dictionary<string, MaterialImpact> materialImpacts =
    new()
    {
        ["Organic Cotton"] = new MaterialImpact
        {
            Co2Score = 75,
            WaterScore = 60,
            ChemicalScore = 75,
            RecyclabilityScore = 80,
            AnimalWelfareScore = 100
        },

        ["Cotton"] = new MaterialImpact
        {
            Co2Score = 55,
            WaterScore = 35,
            ChemicalScore = 45,
            RecyclabilityScore = 75,
            AnimalWelfareScore = 100
        },

        ["Recycled Cotton"] = new MaterialImpact
        {
            Co2Score = 70,
            WaterScore = 70,
            ChemicalScore = 65,
            RecyclabilityScore = 85,
            AnimalWelfareScore = 100
        },

        ["Linen"] = new MaterialImpact
        {
            Co2Score = 85,
            WaterScore = 80,
            ChemicalScore = 80,
            RecyclabilityScore = 90,
            AnimalWelfareScore = 100
        },

        ["Hemp"] = new MaterialImpact
        {
            Co2Score = 90,
            WaterScore = 85,
            ChemicalScore = 85,
            RecyclabilityScore = 90,
            AnimalWelfareScore = 100
        },

        ["Bamboo Mechanical"] = new MaterialImpact
        {
            Co2Score = 80,
            WaterScore = 75,
            ChemicalScore = 75,
            RecyclabilityScore = 80,
            AnimalWelfareScore = 100
        },

        ["Bamboo Viscose"] = new MaterialImpact
        {
            Co2Score = 45,
            WaterScore = 60,
            ChemicalScore = 20,
            RecyclabilityScore = 50,
            AnimalWelfareScore = 100
        },

        ["Wool"] = new MaterialImpact
        {
            Co2Score = 45,
            WaterScore = 55,
            ChemicalScore = 70,
            RecyclabilityScore = 80,
            AnimalWelfareScore = 35
        },

        ["Recycled Wool"] = new MaterialImpact
        {
            Co2Score = 65,
            WaterScore = 70,
            ChemicalScore = 75,
            RecyclabilityScore = 85,
            AnimalWelfareScore = 40
        },

        ["Cashmere"] = new MaterialImpact
        {
            Co2Score = 20,
            WaterScore = 40,
            ChemicalScore = 65,
            RecyclabilityScore = 75,
            AnimalWelfareScore = 20
        },

        ["Alpaca"] = new MaterialImpact
        {
            Co2Score = 55,
            WaterScore = 65,
            ChemicalScore = 75,
            RecyclabilityScore = 80,
            AnimalWelfareScore = 45
        },

        ["Silk"] = new MaterialImpact
        {
            Co2Score = 50,
            WaterScore = 60,
            ChemicalScore = 70,
            RecyclabilityScore = 75,
            AnimalWelfareScore = 15
        },

        ["Leather"] = new MaterialImpact
        {
            Co2Score = 15,
            WaterScore = 25,
            ChemicalScore = 15,
            RecyclabilityScore = 50,
            AnimalWelfareScore = 5
        },

        ["Vegan Leather"] = new MaterialImpact
        {
            Co2Score = 40,
            WaterScore = 60,
            ChemicalScore = 30,
            RecyclabilityScore = 35,
            AnimalWelfareScore = 100
        },

        ["Mushroom Leather"] = new MaterialImpact
        {
            Co2Score = 80,
            WaterScore = 75,
            ChemicalScore = 75,
            RecyclabilityScore = 75,
            AnimalWelfareScore = 100
        },

        ["Polyester"] = new MaterialImpact
        {
            Co2Score = 25,
            WaterScore = 70,
            ChemicalScore = 35,
            RecyclabilityScore = 45,
            AnimalWelfareScore = 100
        },

        ["Recycled Polyester"] = new MaterialImpact
        {
            Co2Score = 65,
            WaterScore = 75,
            ChemicalScore = 55,
            RecyclabilityScore = 70,
            AnimalWelfareScore = 100
        },

        ["Nylon"] = new MaterialImpact
        {
            Co2Score = 20,
            WaterScore = 60,
            ChemicalScore = 35,
            RecyclabilityScore = 40,
            AnimalWelfareScore = 100
        },

        ["Recycled Nylon"] = new MaterialImpact
        {
            Co2Score = 60,
            WaterScore = 70,
            ChemicalScore = 55,
            RecyclabilityScore = 65,
            AnimalWelfareScore = 100
        },

        ["Acrylic"] = new MaterialImpact
        {
            Co2Score = 15,
            WaterScore = 65,
            ChemicalScore = 25,
            RecyclabilityScore = 30,
            AnimalWelfareScore = 100
        },

        ["Elastane"] = new MaterialImpact
        {
            Co2Score = 10,
            WaterScore = 50,
            ChemicalScore = 25,
            RecyclabilityScore = 20,
            AnimalWelfareScore = 100
        },

        ["Rayon"] = new MaterialImpact
        {
            Co2Score = 40,
            WaterScore = 55,
            ChemicalScore = 25,
            RecyclabilityScore = 45,
            AnimalWelfareScore = 100
        },

        ["Modal"] = new MaterialImpact
        {
            Co2Score = 65,
            WaterScore = 70,
            ChemicalScore = 60,
            RecyclabilityScore = 70,
            AnimalWelfareScore = 100
        },

        ["Lyocell"] = new MaterialImpact
        {
            Co2Score = 90,
            WaterScore = 85,
            ChemicalScore = 85,
            RecyclabilityScore = 90,
            AnimalWelfareScore = 100
        },

        ["Acetate"] = new MaterialImpact
        {
            Co2Score = 45,
            WaterScore = 60,
            ChemicalScore = 35,
            RecyclabilityScore = 40,
            AnimalWelfareScore = 100
        },

        ["Fur"] = new MaterialImpact
        {
            Co2Score = 5,
            WaterScore = 20,
            ChemicalScore = 20,
            RecyclabilityScore = 40,
            AnimalWelfareScore = 0
        },

        ["Down"] = new MaterialImpact
        {
            Co2Score = 35,
            WaterScore = 50,
            ChemicalScore = 70,
            RecyclabilityScore = 75,
            AnimalWelfareScore = 10
        }
    };
        public async Task<MaterialImpact> GetMaterialImpact(string materialName)
        {
            return materialImpacts[materialName];
        }
    }
}
