using Data.Repositories;
using Dominio;
using System;

namespace Negocio
{
    public class ConfiguracionNegocio
    {
        private readonly ConfiguracionRepository _repository;

        public ConfiguracionNegocio(ConfiguracionRepository repository)
        {
            _repository = repository;
        }

        public Configuracion ObtenerConfiguracion()
        {
            return _repository.Obtener();
        }

        public void GuardarConfiguracion(Configuracion configuracion)
        {
            if (string.IsNullOrWhiteSpace(configuracion.MensajeEncargo))
                throw new Exception("El mensaje no puede estar vacío.");

            _repository.Guardar(configuracion);
        }
    }
}