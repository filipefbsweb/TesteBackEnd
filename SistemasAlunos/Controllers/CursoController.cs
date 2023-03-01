using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemasAlunos.Models;
using SistemasAlunos.Repositorios.Interfaces;

namespace SistemasAlunos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        private readonly ICursoRepositorio _cursoRepositorio;

        public CursoController(ICursoRepositorio cursoRepositorio)
        {
            _cursoRepositorio = cursoRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<CursoModel>>> BuscarCursos()
        {
            List<CursoModel> cursos = await _cursoRepositorio.BuscarCursos();
            return Ok(cursos);
        }

        [HttpGet("{nome}")]
        public async Task<ActionResult<CursoModel>> BuscarCursoPorNome(string nome)
        {
            CursoModel curso = await _cursoRepositorio.BuscarCursoPorNome(nome);
            return Ok(curso);
        }

        [HttpPost]
        public async Task<ActionResult<CursoModel>> AdicionarNovoCurso([FromBody] CursoModel cursoModel)
        {
            CursoModel curso = await _cursoRepositorio.AdicionarNovoCurso(cursoModel);
            return Ok(curso);
        }
    }
}
