using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PicceriaPro1.Models
{
    public partial class s17041Context : DbContext
    {
        public s17041Context()
        {
        }

        public s17041Context(DbContextOptions<s17041Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Administrator> Administrator { get; set; }
        public virtual DbSet<Emp> Emp { get; set; }
        public virtual DbSet<Klient> Klient { get; set; }
        public virtual DbSet<KlientZamowienie> KlientZamowienie { get; set; }
        public virtual DbSet<Napoj> Napoj { get; set; }
        public virtual DbSet<NapojZamowienie> NapojZamowienie { get; set; }
        public virtual DbSet<Picca> Picca { get; set; }
        public virtual DbSet<PiccaSkladniki> PiccaSkladniki { get; set; }
        public virtual DbSet<Pracownik> Pracownik { get; set; }
        public virtual DbSet<PracownikZamowienie> PracownikZamowienie { get; set; }
        public virtual DbSet<Skladniki> Skladniki { get; set; }
        public virtual DbSet<Sos> Sos { get; set; }
        public virtual DbSet<SosZamowienie> SosZamowienie { get; set; }
        public virtual DbSet<StanZamowienia> StanZamowienia { get; set; }
        public virtual DbSet<Zamowienie> Zamowienie { get; set; }

        // Unable to generate entity type for table 'dbo.DEPT'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SALGRADE'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=db-mssql;Initial Catalog=s17041;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Administrator>(entity =>
            {
                entity.HasKey(e => e.IdAdmina)
                    .HasName("Administrator_pk");

                entity.Property(e => e.IdAdmina)
                    .HasColumnName("idAdmina")
                    .ValueGeneratedNever();

                entity.Property(e => e.HasloAdmina)
                    .IsRequired()
                    .HasColumnName("hasloAdmina")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Imie)
                    .IsRequired()
                    .HasColumnName("imie")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("login")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nazwisko)
                    .IsRequired()
                    .HasColumnName("nazwisko")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Emp>(entity =>
            {
                entity.HasKey(e => e.Empno)
                    .HasName("PK__EMP__14CCF2EE13B1DA37");

                entity.ToTable("EMP");

                entity.Property(e => e.Empno)
                    .HasColumnName("EMPNO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Comm).HasColumnName("COMM");

                entity.Property(e => e.Deptno).HasColumnName("DEPTNO");

                entity.Property(e => e.Ename)
                    .HasColumnName("ENAME")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Hiredate)
                    .HasColumnName("HIREDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Job)
                    .HasColumnName("JOB")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Mgr).HasColumnName("MGR");

                entity.Property(e => e.Sal).HasColumnName("SAL");
            });

            modelBuilder.Entity<Klient>(entity =>
            {
                entity.HasKey(e => e.IdKlienta)
                    .HasName("Klient_pk");

                entity.Property(e => e.IdKlienta)
                    .HasColumnName("idKlienta")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdresEmail)
                    .HasColumnName("adresEmail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HasloKlienta)
                    .HasColumnName("hasloKlienta")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Imie)
                    .IsRequired()
                    .HasColumnName("imie")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Login)
                    .HasColumnName("login")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nazwisko)
                    .IsRequired()
                    .HasColumnName("nazwisko")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KlientZamowienie>(entity =>
            {
                entity.HasKey(e => new { e.IdKlienta, e.IdZamowienia })
                    .HasName("Klient_Zamowienie_pk");

                entity.ToTable("Klient_Zamowienie");

                entity.Property(e => e.IdKlienta).HasColumnName("idKlienta");

                entity.Property(e => e.IdZamowienia).HasColumnName("idZamowienia");
            });

            modelBuilder.Entity<Napoj>(entity =>
            {
                entity.HasKey(e => e.IdNapoju)
                    .HasName("Napoj_pk");

                entity.Property(e => e.IdNapoju)
                    .HasColumnName("idNapoju")
                    .ValueGeneratedNever();

                entity.Property(e => e.CenaNapoju)
                    .HasColumnName("cenaNapoju")
                    .HasColumnType("money");

                entity.Property(e => e.NazwaNapoju)
                    .IsRequired()
                    .HasColumnName("nazwaNapoju")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NapojZamowienie>(entity =>
            {
                entity.HasKey(e => new { e.IdNapoju, e.IdZamowienia })
                    .HasName("Napoj_Zamowienie_pk");

                entity.ToTable("Napoj_Zamowienie");

                entity.Property(e => e.IdNapoju).HasColumnName("idNapoju");

                entity.Property(e => e.IdZamowienia).HasColumnName("idZamowienia");
            });

            modelBuilder.Entity<Picca>(entity =>
            {
                entity.HasKey(e => e.IdPiccy)
                    .HasName("Picca_pk");

                entity.Property(e => e.IdPiccy)
                    .HasColumnName("idPiccy")
                    .ValueGeneratedNever();

                entity.Property(e => e.CenaPiccy)
                    .HasColumnName("cenaPiccy")
                    .HasColumnType("money");

                entity.Property(e => e.NazwaPiccy)
                    .IsRequired()
                    .HasColumnName("nazwaPiccy")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rozmiar)
                    .HasColumnName("rozmiar")
                    .HasColumnType("decimal(3, 1)");
            });

            modelBuilder.Entity<PiccaSkladniki>(entity =>
            {
                entity.HasKey(e => new { e.IdPiccy, e.IdSkladnika })
                    .HasName("Picca_Skladniki_pk");

                entity.ToTable("Picca_Skladniki");

                entity.Property(e => e.IdPiccy).HasColumnName("idPiccy");

                entity.Property(e => e.IdSkladnika).HasColumnName("idSkladnika");

                entity.HasOne(d => d.IdPiccyNavigation)
                    .WithMany(p => p.PiccaSkladniki)
                    .HasForeignKey(d => d.IdPiccy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Picca_Skladniki_Picca");

                entity.HasOne(d => d.IdSkladnikaNavigation)
                    .WithMany(p => p.PiccaSkladniki)
                    .HasForeignKey(d => d.IdSkladnika)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Picca_Skladniki_Skladniki");
            });

            modelBuilder.Entity<Pracownik>(entity =>
            {
                entity.HasKey(e => e.IdPracownika)
                    .HasName("Pracownik_pk");

                entity.Property(e => e.IdPracownika)
                    .HasColumnName("idPracownika")
                    .ValueGeneratedNever();

                entity.Property(e => e.HasloPracownika)
                    .IsRequired()
                    .HasColumnName("hasloPracownika")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdAdmina).HasColumnName("idAdmina");

                entity.Property(e => e.Imie)
                    .IsRequired()
                    .HasColumnName("imie")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("login")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nazwisko)
                    .IsRequired()
                    .HasColumnName("nazwisko")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAdminaNavigation)
                    .WithMany(p => p.Pracownik)
                    .HasForeignKey(d => d.IdAdmina)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Pracownik_Administrator");
            });

            modelBuilder.Entity<PracownikZamowienie>(entity =>
            {
                entity.HasKey(e => new { e.IdPracownika, e.IdZamowienia })
                    .HasName("Pracownik_Zamowienie_pk");

                entity.ToTable("Pracownik_Zamowienie");

                entity.Property(e => e.IdPracownika).HasColumnName("idPracownika");

                entity.Property(e => e.IdZamowienia).HasColumnName("idZamowienia");
            });

            modelBuilder.Entity<Skladniki>(entity =>
            {
                entity.HasKey(e => e.IdSkladnika)
                    .HasName("Skladniki_pk");

                entity.Property(e => e.IdSkladnika)
                    .HasColumnName("idSkladnika")
                    .ValueGeneratedNever();

                entity.Property(e => e.CenaSkladnika)
                    .HasColumnName("cenaSkladnika")
                    .HasColumnType("money");

                entity.Property(e => e.NazwaSkladnika)
                    .IsRequired()
                    .HasColumnName("nazwaSkladnika")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sos>(entity =>
            {
                entity.HasKey(e => e.IdSosu)
                    .HasName("Sos_pk");

                entity.Property(e => e.IdSosu)
                    .HasColumnName("idSosu")
                    .ValueGeneratedNever();

                entity.Property(e => e.CenaSosu)
                    .HasColumnName("cenaSosu")
                    .HasColumnType("money");

                entity.Property(e => e.NazwaSosu).HasColumnName("nazwaSosu");
            });

            modelBuilder.Entity<SosZamowienie>(entity =>
            {
                entity.HasKey(e => new { e.IdSosu, e.IdZamowienia })
                    .HasName("Sos_Zamowienie_pk");

                entity.ToTable("Sos_Zamowienie");

                entity.Property(e => e.IdSosu).HasColumnName("idSosu");

                entity.Property(e => e.IdZamowienia).HasColumnName("idZamowienia");
            });

            modelBuilder.Entity<StanZamowienia>(entity =>
            {
                entity.HasKey(e => e.IdStanu)
                    .HasName("StanZamowienia_pk");

                entity.Property(e => e.IdStanu)
                    .HasColumnName("idStanu")
                    .ValueGeneratedNever();

                entity.Property(e => e.NazwaStanu)
                    .IsRequired()
                    .HasColumnName("nazwaStanu")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Zamowienie>(entity =>
            {
                entity.HasKey(e => e.IdZamowienia)
                    .HasName("Zamowienie_pk");

                entity.Property(e => e.IdZamowienia)
                    .HasColumnName("idZamowienia")
                    .ValueGeneratedNever();

                entity.Property(e => e.Adres)
                    .IsRequired()
                    .HasColumnName("adres")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DataRealizacji)
                    .HasColumnName("dataRealizacji")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataZamowienia)
                    .HasColumnName("dataZamowienia")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdPiccy).HasColumnName("idPiccy");

                entity.Property(e => e.IdStanu).HasColumnName("idStanu");
            });
        }
    }
}
