using ServiceProject.Helpers;
using ServiceProject.Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace ServiceProject.Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ITestService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ITestService
    {
        [OperationContract]
        List<Item> SearchTracks(string query);
    }
}
