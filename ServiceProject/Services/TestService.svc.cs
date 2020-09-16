using ServiceProject.Helpers;
using ServiceProject.Models;
using System.Collections.Generic;

namespace ServiceProject.Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "TestService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione TestService.svc o TestService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class TestService : ITestService
    {
        public List<Item> SearchTracks(string query)
        {
            SearchManager searchManager = new SearchManager();
            return searchManager.SearchTrackSpotifyItems(query);

        }
    }
}
