using BarberTip.Contexts;
using BarberTip.Entities;
using BarberTip.ViewModels;

namespace BarberTip.Services;

public class ClienteService{
    
    private readonly BarberTipContext _context;

    public ClienteService(BarberTipContext context)
    {
        _context = context;
    }

    public DetalhesClienteViewModel AdicionarCliente(AdicionarClienteViewModel dados){

        var cliente = new Cliente(dados.Nome,dados.Telefone,dados.Email,
        dados.DataNascimento);
        _context.Add(cliente);
        _context.SaveChanges();

        return new DetalhesClienteViewModel
        (
               cliente.Id,
               cliente.Nome,
               cliente.Email,
               cliente.Telefone,
               cliente.DataNascimento
        );
    }

    public IEnumerable<ListarClienteViewModel> ListarClientes(){
         
         return _context.Clientes.Select(c=> new ListarClienteViewModel(c.Id,c.Nome,c.Telefone));

    }
    


}