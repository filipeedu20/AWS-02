using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LivrosApp.Models;

namespace LivrosApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosApi : ControllerBase
    {
        
        Livros[] livros = new Livros[] {
            new Livros() { Id = 1, Isbn = 8576849941, Nome = "O milagre da manhã !", Autor = "Hal Elrod", Editora = " BestSeller" },
            new Livros() { Id = 2, Isbn = 8595083274, Nome = "Do Mil ao Milhão. Sem Cortar o Cafezinho. ", Autor = "Thiago Nigro", Editora = "HarperCollins" },
            new Livros() { Id = 3, Isbn = 8575422391, Nome = "Os segredos da mente milionária", Autor = "T. Harv Eker", Editora = "Sextante" }
        };

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Livros>> Get()
        {
            return livros;
            
        }

        // GET api/values/5
        [HttpGet("{id}")]
        // public ActionResult<Livros> Get(int id)
        public ActionResult<IEnumerable<Livros>> Get(int id)
        {           
            // Verifica se a id passada existe, caso exista, retorne-a.
            Livros[] livro = new Livros[] {new Livros() { Id = 1, Isbn = 8576849941, Nome = "O milagre da manhã !", Autor = "Hal Elrod", Editora = " BestSeller" }};
            // retorna todos os livros registrados 
            return livro;            
        }

        // POST api/LivrosApi
        [HttpPost]
        public string Post([FromBody] string dados)
        {
            return dados;
        }

        // PUT api/LivrosApi/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/LivrosApi/5
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Livros>> Delete(int Isbn)
        {
            if(Isbn!=null){
                livros = livros.Where(book => book.Isbn != Isbn).ToArray();                        
            }
            return livros;
        }
    }
}
