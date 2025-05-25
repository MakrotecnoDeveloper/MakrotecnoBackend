using Microsoft.AspNetCore.Mvc;
using MakrotecnoBackend.Models;

namespace MakrotecnoBackend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsuariosController : ControllerBase
{
    private readonly MakrotecnoDbContext _context;

    public UsuariosController(MakrotecnoDbContext context)
    {
        _context = context;
    }

    // GET: api/usuarios
    [HttpGet]
    public ActionResult<IEnumerable<Usuario>> GetUsuarios()
    {
        return Ok(_context.Usuarios.ToList());
    }

    // POST: api/usuarios
    [HttpPost]
    public ActionResult<Usuario> CrearUsuario([FromBody] Usuario usuario)
    {
        _context.Usuarios.Add(usuario);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetUsuarios), new { id = usuario.Id }, usuario);
    }
}
