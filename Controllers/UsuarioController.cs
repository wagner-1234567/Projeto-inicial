/*using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Biblioteca.Models;
using Microsoft.AspNetCore.Http;

namespace Biblioteca.Controllers
{
    public class UsuarioController : Controller
    {
        
        public IActionResult ListaDeUsuarios()
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificaSeUsuarioEAdmin(this);

            return View(new UsuarioService().Listar());

        }

        public IActionResult editarUsuario(int id)
        {
            Usuario u = new UsuarioService().Listar(id);
            return View(u);
        }

        [HttpPost]
        public IActionResult editarUsuario(Usuario userEditado)
        {
            UsuarioService us = new UsuarioService();
            us.editarUsuario(userEditado);

            return RedirectToAction("ListaDeUsuarios");
        }

       
    }
}
*/