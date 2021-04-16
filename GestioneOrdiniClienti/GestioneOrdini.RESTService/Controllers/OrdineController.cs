using GestioneOrdiniClienti.BusinessLayer;
using GestioneOrdiniClienti.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestioneOrdini.RESTService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdineController : ControllerBase
    {
        //Dependence Injection
        private readonly IGestioneOrdClientiBL bl;
        public OrdineController(IGestioneOrdClientiBL bl)
        {
            this.bl = bl;
        }

        //Metodi CRUD per Gestione Ordine

        //CREATE
        [HttpPost]
        public ActionResult CreateNewOrdine([FromBody] Ordine newOrdine)
        {
            var ordine = bl.CreateOrdine(newOrdine);

            if (!ordine)
            {
                return BadRequest();
            }
            else
            {
                //ritorno come conferma l'ordine creato
                return Ok(ordine);
            }
        }

        //UPDATE
        [HttpPut("{id}")]
        public ActionResult UpdateOrdine([FromBody] Ordine ordine)
        {
            if (ordine == null)
            {
                return BadRequest();
            }
            var result = bl.UpdateOrdine(ordine);

            return Ok();
        }

        //DELETE
        [HttpDelete("{id}")]
        public ActionResult DeleteOrdine(int id)
        {
            var ordine = bl.GetAllOrdini().FirstOrDefault(o => o.ID == id);
            if (ordine == null)
            {
                return NotFound();
            }

            var result = bl.DeleteOrdine(ordine);
            if (!result)
            {
                return BadRequest();
            }
            return Ok();
        }

        //GetByID
        [HttpGet("{id}")]
        public ActionResult GetOrdineById(int id)
        {
            var ordine = bl.GetAllOrdini().FirstOrDefault(o => o.ID == id);
            if (ordine == null)
            {
                return NotFound();
            }
            return Ok(ordine);
        }

        [HttpGet]
        public ActionResult GetAllOrdini()
        {
            return Ok(bl.GetAllOrdini());
        }
    }
}
