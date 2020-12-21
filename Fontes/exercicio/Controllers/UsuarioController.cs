using Dominio;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using Services.Interfaces;
using System;

namespace exercicio.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _usuarioService;
        private readonly IToastNotification _toastNotification;

        public UsuarioController(IUsuarioService usuarioService, IToastNotification toastNotification)
        {
            _usuarioService = usuarioService;
            _toastNotification = toastNotification;
        }

        public IActionResult Index()
        {
            return View(_usuarioService.ObterTodos());
        }

        // GET: Usuario/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id, Nome, Sobrenome, Cpf, Cidade, Estado, Cep, Complemento, Endereco, DataNascimento, Numero")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _usuarioService.Inserir(usuario);
                    _toastNotification.AddSuccessToastMessage("Operação realizada com sucesso!");
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    _toastNotification.AddErrorToastMessage("Ocorreu um erro ao realizar a operação.");
                }
            }

            return View(usuario);
        }
    }
}
