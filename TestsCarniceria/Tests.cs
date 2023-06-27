using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Parcial_Biblioteca;

namespace TestsCarniceria
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Test_Agregar_Producto()
        {
            //Arrange
            List<Producto> listaProductos = new List<Producto>();
            string categoria = "Pollo";
            string corte = "Alitas";
            string cantidadKilos = "50";
            string precioPorKilo = "1700";
            string detalles = "Con Piel";

            //Act
            string mensajeSalida = Vendedor.NuevoProducto(listaProductos, categoria, corte, cantidadKilos, precioPorKilo, detalles);

            //Assert
            Assert.AreEqual("Producto Agregado con Exito", mensajeSalida);
        }

        [TestMethod]
        public void Test_Borrar_Producto()
        {
            //Arrange
            List<Producto> listaProductos = new List<Producto>();
            string productoABorrar = "Chuleta";

            //Act
            int idProductoBorrado = Vendedor.BorrarProducto(productoABorrar, listaProductos);

            //Assert
            Assert.AreEqual(0, idProductoBorrado);
        }

        [TestMethod]
        public void Test_Checkeo_Saldo()
        {
            //Arrange
            Cliente cliente = new Cliente(5, "Carlos Martin", "carlitosm@gmail.com", "mart23543", "Cliente");
            cliente.DineroDisponible = 50000;
            decimal montoCompra = 34000;

            //Act
            bool saldoSuficiente = cliente.CheckearSaldo(montoCompra);

            //Assert
            Assert.AreEqual(true, saldoSuficiente);
        }
    }
}
