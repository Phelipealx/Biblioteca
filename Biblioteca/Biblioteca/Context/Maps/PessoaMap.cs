using Biblioteca.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biblioteca.Context.Maps
{
    public class PessoaMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("livro");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.NomeLivro).HasColumnName("nome_livro");
            builder.Property(x => x.Autor).HasColumnName("autor");
            builder.Property(x => x.Editora).HasColumnName("editora");
            builder.Property(x => x.IdPessoa).HasColumnName("id_pessoa");
            builder.HasOne(x => x.Pessoa).WithMany().HasForeignKey(x => x.IdPessoa);
        }
    }
}
