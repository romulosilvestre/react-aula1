/*
   ***PROTOCOLO - HTTP (comunicação)***
      Verbos
      POST - inserir
      PUT  - alterar
      GET  - pegar
      DELETE - apagar
*/

using BarberTip.Services;
using BarberTip.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BarberTip.Controllers;


//Rota - SubCaminho
[Route("api/clientes")]
[ApiController] 
public class ClienteController:ControllerBase{
     
     private readonly ClienteService _clienteService;

    public ClienteController(ClienteService clienteService)
    {
        _clienteService = clienteService;
    }

    [HttpPost]
    public IActionResult AdicionarCliente(AdicionarClienteViewModel dados){
          var cliente = _clienteService.AdicionarCliente(dados);
          return Ok(cliente);
    } 

}


