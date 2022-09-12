//utilização de outros namespaces
using BarberTip.Services;//Add() Remove() Update() Find()
using BarberTip.ViewModels;//Design Pattern - MVVM (cria uma camada de dados para a View)
using Microsoft.AspNetCore.Mvc;//trabalhar com AspNet Core MVC

//definição do namespace
namespace BarberTip.Controllers;

[Route("api/agendamentos")]//caminho sub url
[ApiController] //define como APi porque pode ter outras aplicações web
public class AgendamentoController:ControllerBase{

    private readonly AgendamentoService _agendamentoService;

    public AgendamentoController(AgendamentoService agendamentoService)
    {
        _agendamentoService = agendamentoService;
    }
    [HttpPost]
    public IActionResult AdicionarAgendamento(AdicionarAgendamentoViewModel dados){
        var agendamento = _agendamentoService.AdicionarAgendamento(dados);
        return Ok(agendamento); //Status Http 200.

    }



}