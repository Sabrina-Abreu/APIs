using Microsoft.AspNetCore.Mvc; // Importa as funcionalidades da API do .NET

namespace MinhaApi.Controllers;

[ApiController] // Marca esta classe como um Controller de API
[Route("api/[controller]")] // Define a URL base para este controller: "api/produtos"
public class ProdutosController : ControllerBase
{
    // Nossa lista de dados fictícios (nosso "estoque" na cozinha)
    private static readonly List<Produto> _produtos = new List<Produto>
    {
        new Produto { Id = 1, Nome = "Caderno", Preco = 15.90m },
        new Produto { Id = 2, Nome = "Caneta", Preco = 3.50m },
        new Produto { Id = 3, Nome = "Borracha", Preco = 2.00m }
    };

    // Este método vai responder a um pedido GET para "api/produtos"
    [HttpGet]
    public IActionResult GetTodos()
    {
        // Retorna um código de sucesso (200 OK) e a lista de produtos
        return Ok(_produtos);
    }
}