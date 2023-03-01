using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemasAlunos.Enum;
using SistemasAlunos.Models;
using SistemasAlunos.Repositorios.Interfaces;

namespace SistemasAlunos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoRepositorio _alunoRepositorio;

        public AlunoController(IAlunoRepositorio alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<AlunoModel>>> BuscarAlunos()
        {
            List<AlunoModel> alunos = await _alunoRepositorio.BuscarAlunos();
            return Ok(alunos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<AlunoModel>>> BuscarAlunoPorId(int id)
        {
            AlunoModel aluno = await _alunoRepositorio.BuscarAlunoPorId(id);
            return Ok(aluno);
        }

        [HttpGet("/curso/{curso}")]
        public async Task<ActionResult<List<AlunoModel>>> BuscarAlunoPorCurso(string nomeCurso)
        {
            AlunoModel aluno = await _alunoRepositorio.BuscarAlunoPorCurso(nomeCurso);
            return Ok(aluno);
        }

        [HttpGet("/ra/{ra}")]
        public async Task<ActionResult<List<AlunoModel>>> BuscarAlunoPorRA(int ra)
        {
            AlunoModel aluno = await _alunoRepositorio.BuscarAlunoPorRA(ra);
            return Ok(aluno);
        }

        [HttpGet("/status/{status}")]
        public async Task<ActionResult<List<AlunoModel>>> BuscarAlunoPorStatus(StatusAluno status)
        {
            AlunoModel aluno = await _alunoRepositorio.BuscarAlunoPorStatus(status);
            return Ok(aluno);
        }

        [HttpPost]
        public async Task<ActionResult<AlunoModel>> AdicionarAluno([FromBody] AlunoModel alunoModel)
        {
            AlunoModel aluno = await _alunoRepositorio.AdicionarAluno(alunoModel);
            return Ok(aluno);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<AlunoModel>> EditarAluno([FromBody] AlunoModel alunoModel, int id)
        {
            alunoModel.Id = id;
            AlunoModel aluno = await _alunoRepositorio.EditarAluno(alunoModel, id);

            return Ok(aluno);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<AlunoModel>> ExcluirAluno(int id)
        {
            bool excluir = await _alunoRepositorio.ExcluirAluno(id);
            return Ok(excluir);
        }
    }
}
