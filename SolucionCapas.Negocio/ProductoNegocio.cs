using System;
using SolucionCapas.Datos;

namespace SolucionCapas.Negocio
{
    public class ProductoNegocio
    {
        private ProductoDatos _datos = new ProductoDatos();

        public Producto ObtenerProducto(string codigo)
        {
            // Validar que el código no esté vacío
            if (string.IsNullOrEmpty(codigo))
                return null;

            // Validar que comience con PROD-
            if (!codigo.StartsWith("PROD-"))
                return null;

            // Si pasa las validaciones, consulta a Datos
            var resultado = _datos.BuscarPorCodigo(codigo);

            if (resultado == null)
                return null;

            // Convertir los datos en un objeto Producto
            return new Producto
            {
                Codigo = resultado.Value.Codigo,
                Nombre = resultado.Value.Nombre,
                Precio = resultado.Value.Precio
            };
        }
    }
}