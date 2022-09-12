using BarberTip.Contexts;//É o banco
using BarberTip.Entities;//Classes de entidades
using BarberTip.ViewModels; //camada de dados da view
using Microsoft.EntityFrameworkCore;//framework de ORM

namespace BarberTip.Services;

public class AgendamentoService
{

    private readonly BarberTipContext _context;

    public AgendamentoService(BarberTipContext context)
    {
        _context = context;
    }
    public ListarAgendamentoViewModel? AdicionarAgendamento(AdicionarAgendamentoViewModel dados)
    {

        var agendamento = new Agendamento
        (
          dados.Data,
          dados.Hora,
          dados.IdCliente
        );
        _context.Add(agendamento);
        _context.SaveChanges();
        return new ListarAgendamentoViewModel
            (
                agendamento.Id,
                agendamento.Data,
                agendamento.Hora,
                agendamento.IdCliente
            );

    }
    public IEnumerable<ListarAgendamentoViewModel> ListarAgendamentos(int idCliente)
    {
        return _context.Agendamentos.Where(a => a.IdCliente == idCliente)
                                    .Select(a => new ListarAgendamentoViewModel(
                                     a.Id,
                                     a.Data,
                                     a.Hora,
                                     a.IdCliente
                                    ));
    }

    public ListarAgendamentoViewModel? AtualizarAgendamento(AtualizarAgendamentoViewModel dados)
    {

        var agendamento = _context.Agendamentos.Find(dados.Id);
        if (agendamento != null)
        {

            agendamento.Data = dados.Data;
            agendamento.Hora = dados.Hora;
            agendamento.IdCliente = dados.IdCliente;
            _context.Update(agendamento);
            _context.SaveChanges();


        }
        return null;
    }
    public void ExcluirAgendamento(int id)
    {

        var agendamento = _context.Agendamentos.Find(id);
        if (agendamento != null)
        {
            _context.Remove(agendamento);
            _context.SaveChanges();
        }

    }



}

