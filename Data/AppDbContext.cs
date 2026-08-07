using Microsoft.EntityFrameworkCore;
using SocialConnectApi.Models;

namespace SocialConnectApi.Data;

public class AppDbContext : DbContext
{
    public
    AppDbContext(DbContextOptions<AppDbContext>options)
    : base(options)
    {
    }

    public DbSet<Usuario> Usuarios { get; set; }

    public DbSet<Publicacao> Publicacoes { get; set; }

    public DbSet<Comentario> Comentarios { get; set; }

    public DbSet<Curtida> Curtidas { get; set; }

    public DbSet<Seguidor> Seguidores { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Comentario>()
        .HasOne(c => c.Usuario)
        .WithMany(u => u.Comentarios)
        .HasForeignKey(c => c.UsuarioId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Curtida>()
        .HasOne(c => c.Usuario)
        .WithMany(u => u.Curtidas)
        .HasForeignKey(c => c.UsuarioId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Seguidor>()
        .HasOne(s => s.SeguidorUsuario)
        .WithMany(u => u.Seguindo)
        .HasForeignKey(s => s.SeguidorId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Seguidor>()
        .HasOne(s => s.SeguindoUsuario)
        .WithMany(u => u.Seguidores)
        .HasForeignKey(s => s.SeguindoId)
        .OnDelete(DeleteBehavior.NoAction);

        base.OnModelCreating(modelBuilder);
    }
}