namespace RepositoryContracts;
using Entities;

public interface IMaterialsRepository
{
    Task<MaterialImpact> GetMaterialImpact(string materialName);
}
