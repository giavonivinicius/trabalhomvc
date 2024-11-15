using Microsoft.AspNetCore.Mvc;
using PimUrbanGreen.Repositories;
using PimUrbanGreen.Models;

namespace PimUrbanGreen.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserRepository _userRepository;

        public AccountController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _userRepository.GetUserByCredentials(model.Usuario, model.Senha);
                if (user != null)
                {
                    // Após o login bem-sucedido, redireciona para a tela de boas-vindas
                    return RedirectToAction("Wellcome", "Account");
                }
                ModelState.AddModelError("", "Usuário ou senha inválidos");
            }
            return View(model);
        }

        // Ação que renderiza a tela de boas-vindas após login bem-sucedido
        [HttpGet]
        public IActionResult Wellcome()
        {
            return View();
        }
    }
}
