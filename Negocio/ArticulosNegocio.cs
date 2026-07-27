using Dominio;
using Dominio.Interfaces;
using Data.Repositories;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class ArticulosNegocio
    {
        private readonly IArticuloRepository _repository;

        public ArticulosNegocio(IArticuloRepository repository)
        {
            _repository = repository;
        }

        public List<Articulo> GetAll()
        {
            try
            {
                return _repository.GetAll();
            }
            catch (Exception exc)
            {
                throw new Exception("No se ha podido obtener los articulos", exc);
            }
        }
        public void Add(Articulo articulo)
        {
            try
            {
                if (articulo == null)
                    throw new NullReferenceException();

                if (string.IsNullOrEmpty(articulo.Codigo))
                    throw new Exception("Código inválido");
                if (string.IsNullOrEmpty(articulo.Nombre))
                    throw new Exception("Un articulo debe tener un nombre");

                _repository.Add(articulo);
            }
            catch (Exception exc)
            {
                throw new Exception("No se ha podido agregar artículo", exc);
            }
        }
        public void AddArticuloEncargo(ArticuloEncargo articuloEncargo)
        {
            try
            {
                if (articuloEncargo == null)
                    throw new NullReferenceException();

                if (string.IsNullOrEmpty(articuloEncargo.ArticuloCodigo))
                    throw new Exception("Código inválido");
                if (string.IsNullOrEmpty(articuloEncargo.ArticuloNombre))
                    throw new Exception("Un articulo debe tener un nombre");

                _repository.Add(articuloEncargo.Articulo);
            }
            catch (Exception exc)
            {
                throw new Exception("No se ha podido agregar artículo", exc);
            }
        }
        public void Update(Articulo articulo)
        {
            try
            {
                if (articulo == null)
                    throw new NullReferenceException();
                if (string.IsNullOrEmpty(articulo.Codigo))
                    throw new Exception("Código inválido");
                if (string.IsNullOrEmpty(articulo.Nombre))
                    throw new Exception("Un articulo debe tener un nombre");

                _repository.Update(articulo);
            }
            catch (Exception exc)
            {
                throw new Exception("No se ha podido actualizar artículo", exc);
            }
        }
        public void Delete(int Id)
        {
            try
            {
                if (Id <= 0)
                    throw new Exception("Id inválido");

                _repository.Delete(Id);
            }
            catch (Exception exc)
            {
                throw new Exception("No se ha podido eliminar artículo", exc);
            }
        }
    }
}