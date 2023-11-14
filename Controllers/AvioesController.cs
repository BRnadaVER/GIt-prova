using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoCRUDSQLite.Models;

namespace ProjetoCRUDSQLite.Controllers
{
    public class AvioesController : Controller
    {
        //Passo um criar a variável de contexto para controlar nossas conexões.
        private readonly Contexto _contexto;

        // criar o construtor da classes -> snnipet: ctor
        public AvioesController(Contexto contexto)
        {
            _contexto = contexto;
        }
        // alterar o construtor para funcionar de maneira assíncrona com o banco
        /*
        public IActionResult Index()
        {
            return View();
        }*/
        
        //Operação de READ
        public async Task<IActionResult> Index()
        {
            return View(await _contexto.Avioes.ToListAsync());
        }

        //Operação CREATE
        [HttpGet]
        public IActionResult NovoAviao() { 
            return View();
        }
        //Ação que de fato irá criar o registro no banco de dados de fato
        [HttpPost]
        public async Task<IActionResult> NovoAviao (Aviao aviao)
        {
            await _contexto.Avioes.AddAsync(aviao);
            await _contexto.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        
        [HttpGet]
        public async   Task<IActionResult> AtualizarAviao(int idAviao)
        {
            Aviao aviao = await _contexto.Avioes.FindAsync(idAviao);
            return View(aviao);
        }

        // Ação que de fato irá atualizar o registro
        [HttpPost]
        public async Task<IActionResult> AtualizarAviao (Aviao aviao)
        {
            _contexto.Avioes.Update(aviao);
            await _contexto.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        //Criando a Action de Delete. Neste caso apenas HttpPost, pois apenas redirecionamos.
        [HttpPost] public async Task<IActionResult> ExcluirAviao (int idAviao)
        {
            Aviao aviao = await _contexto.Avioes.FindAsync (idAviao);
            _contexto.Avioes.Remove(aviao);
            await _contexto.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
    }
}
