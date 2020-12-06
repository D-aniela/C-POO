using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //--Arrange
            //Creamos una instancia de la clase customer
            //La clase customer que creamos es un tipo entonces se crea una variable de ese tipo que define la variable
            //del objeto que va a referenciar nuestro objeto

            //Esto crea una instancia de la clase Customer y lo asigna a una variable objeto definida como tipo Customer
            Customer customer = new Customer
            {
                //usamos el objeto variable para establecer la propiedad FirstName a un valor de prueba (Test value)
                //Tambien con LastName
                //FirstName = "Daniela",
                LastName = "Estrada"
            };
            //Definimos el valor que se espera
            string expected = "Estrada";

            //--Act
            //Obtenemos el valor de la propiedad FullName
            string actual = customer.FullName;

            //--Assert
            //Se verifica que que el valor que se espera es igual al valor actual
            Assert.AreEqual(expected, actual);
        }

        public void StaticTest()
        {
            //--Arrange
            var c1 = new Customer();
            //Para acceder a una propiedad static utilizamos la clase misma
            //Customer.InstanceCount;
            c1.FirstName = "Daniela";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Claudia";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Javier";
            Customer.InstanceCount += 1;

            //--Act

            //--Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }
    }
}
