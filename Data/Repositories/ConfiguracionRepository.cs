using Dominio;
using Newtonsoft.Json;
using System.IO;

namespace Data.Repositories
{
    public class ConfiguracionRepository
    {
        private readonly string _rutaArchivo;

        public ConfiguracionRepository(string rutaArchivo)
        {
            _rutaArchivo = rutaArchivo;
        }

        public Configuracion Obtener()
        {
            if (!File.Exists(_rutaArchivo))
                return new Configuracion();

            string json = File.ReadAllText(_rutaArchivo);

            return JsonConvert.DeserializeObject<Configuracion>(json);
        }

        public void Guardar(Configuracion configuracion)
        {
            string json = JsonConvert.SerializeObject(
                configuracion,
                Formatting.Indented
            );

            File.WriteAllText(_rutaArchivo, json);
        }
    }
}
