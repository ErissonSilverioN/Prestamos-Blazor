using Prestamos_Blazor.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Prestamos_Blazor.Models;

namespace Prestamos_Blazor.BLL.Tests
{
    [TestClass()]
    public class PersonaBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            
            Personas personas = new Personas()
            {
                PersonaId = 1,
                Nombre = "Erisson",
                Cedula = "402-345232-2",
                Telefono = "809-434-2323",
                Direccion = "SFM",
                FechaNacimiento = DateTime.Now,
                Balance = 0

            };

            Assert.IsTrue(PersonaBLL.Guardar(personas));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Personas personas = new Personas()
            {
                PersonaId = 1,
                Nombre = "Erisson Silverio",
                Cedula = "402-345232-2",
                Telefono = "809-434-2323",
                Direccion = "Santo Domingo",
                FechaNacimiento = DateTime.Now,
                Balance = 0
            };

            Assert.IsTrue(PersonaBLL.Modificar(personas));
        }




        [TestMethod()]
        public void EliminarTest()
        {
            Assert.IsTrue(PersonaBLL.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.IsNotNull(PersonaBLL.Buscar(1));
        }

      

        [TestMethod()]
        public void GetListTest()
        {
            PersonaBLL bll = new PersonaBLL();
            Assert.IsNotNull(bll.GetList(t => true));
        }
    }
}