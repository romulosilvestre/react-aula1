using BarberTip.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ClienteConfigurations : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("Clientes");
        builder.HasKey(a=>a.Id);
        builder.Property(a=>a.Nome)
               .IsRequired()
               .HasMaxLength(60);
        builder.Property(a=>a.Telefone)
               .IsRequired()
               .HasMaxLength(60);
        builder.Property(a=>a.Email)
               .IsRequired()
               .HasMaxLength(60);
        builder.Property(a=>a.DataNascimento)
               .IsRequired()
               .HasMaxLength(60);
    
    }
}