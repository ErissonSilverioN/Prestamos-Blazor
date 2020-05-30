using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prestamos_Blazor.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using Prestamos_Blazor.Models;


namespace Prestamos_Blazor.BLL.Tests
{
    [TestClass()]
    public class PrestamoBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Prestamos prestamos = new Prestamos()
            {
                PrestamoId = 1,
                PersonaId = 2,
                Persona = " ",
                Concepto = "Probando Guardar",
                Monto = 500,
                Fecha = DateTime.Now,
                Balance = 0

            };

            Assert.IsTrue(PrestamoBLL.Guardar(prestamos));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Prestamos prestamos = new Prestamos()
            {
                PrestamoId = 1,
                PersonaId = 2,
                Persona = " ",
                Concepto = "Probando Modificar",
                Monto = 1000,
                Fecha = DateTime.Now,
                Balance = 0

            };

            Assert.IsTrue(PrestamoBLL.Guardar(prestamos));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.IsTrue(PrestamoBLL.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.IsNotNull(PrestamoBLL.Buscar(1));
        }


        [TestMethod()]
        public void GetListTest()
        {
            PrestamoBLL bll = new PrestamoBLL();
            Assert.IsNotNull(bll.GetList(t => true));
        }
    }
}