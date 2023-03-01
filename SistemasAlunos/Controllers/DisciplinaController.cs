using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemasAlunos.Models;
using SistemasAlunos.Repositorios;
using SistemasAlunos.Repositorios.Interfaces;

namespace SistemasAlunos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisciplinaController : ControllerBase
    {
        private readonly IDisciplinaRepositorio _disciplinaRepositorio;

        public DisciplinaController(IDisciplinaRepositorio disciplinaRepositorio)
        {
            _disciplinaRepositorio = disciplinaRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<DisciplinaModel>>> BuscarDisciplinas()
        {
            List<DisciplinaModel> disciplinas = await _disciplinaRepositorio.BuscarDisciplinas();
            return Ok(disciplinas);
        }

        [HttpGet("{nome}")]
        public async Task<ActionResult<DisciplinaModel>> BuscarDisciplinaPorNome(string nome)
        {
            DisciplinaModel disciplinas = await _disciplinaRepositorio.BuscarDisciplinaPorNome(nome);
            return Ok(disciplinas);
        }

        [HttpPost]
        public async Task<ActionResult<DisciplinaModel>> AdicionarDisciplina([FromBody] DisciplinaModel disciplinaModel)
        {
            DisciplinaModel disciplina = await _disciplinaRepositorio.AdicionarDisciplina(disciplinaModel);
            return Ok(disciplina);
        }
    }
}
