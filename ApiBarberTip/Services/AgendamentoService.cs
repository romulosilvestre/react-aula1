using System.Text;
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

    /*public byte[]? GerarTicketSenha(int id){
      
      var agendamento = _context.Agendamentos.Include(c=>c.Cliente)
                                             .FirstOrDefault(a=>a.Id == id);

     if(agendamento!=null){
         //Classe especializa em composição de strings longas
         var builder = new StringBuilder();
         builder.Append($"<h1 style='text-align: center'>Ficha do Voo { voo.Id.ToString().PadLeft(10, '0') }</h1>")
                   .Append($"<hr>")
                   .Append($"<p><b>ORIGEM:</b> { voo.Origem } (saída em { voo.DataHoraPartida:dd/MM/yyyy} às { voo.DataHoraPartida:hh:mm})</p>")
                   .Append($"<p><b>DESTINO:</b> { voo.Destino} (chegada em { voo.DataHoraChegada:dd/MM/yyyy} às { voo.DataHoraChegada:hh:mm})</p>")
                   .Append($"<hr>")
                   .Append($"<p><b>AERONAVE:</b> { voo.Aeronave!.Codigo } ({ voo.Aeronave.Fabricante } { voo.Aeronave.Modelo })</p>")
                   .Append($"<hr>")
                   .Append($"<p><b>PILOTO:</b> { voo.Piloto!.Nome } ({ voo.Piloto.Matricula})</p>")
                   .Append($"<hr>");
            if (voo.Cancelamento != null)
            {
                builder.Append($"<p style='color: red'><b>VOO CANCELADO:</b> { voo.Cancelamento.Motivo }</p>");
            }

            var doc = new HtmlToPdfDocument()
            {
                GlobalSettings = {
                    ColorMode = ColorMode.Color,
                    Orientation = Orientation.Portrait,
                    PaperSize = PaperKind.A4
                },
                Objects = {
                    new ObjectSettings() {
                        PagesCount = true,
                        HtmlContent = builder.ToString(),
                        WebSettings = { DefaultEncoding = "utf-8" }
                    }
                }
            };

            return _converter.Convert(doc);
        }
     

    }*/




}



