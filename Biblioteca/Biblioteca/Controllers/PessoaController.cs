using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.Context;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers
{
    public class PessoaController : Controller
    {
        private readonly BibliotecaContexto _bibliotecaContexto;

        public PessoaController(BibliotecaContexto bibliotecaContexto)
        {
            _bibliotecaContexto = bibliotecaContexto;
        }

        [HttpGet]
        public IActionResult ListarPessoas()
        {
            return Ok(_bibliotecaContexto.Pessoas.ToList());
        }
    }
}