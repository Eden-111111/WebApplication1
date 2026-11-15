using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class MyDataContext : DbContext
    {
        public MyDataContext()
        {
        }

        public MyDataContext(DbContextOptions<MyDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aircraft> Aircraft { get; set; }
        public virtual DbSet<Airlines> Airlines { get; set; }
        public virtual DbSet<Airports> Airports { get; set; }
        public virtual DbSet<Baggage> Baggage { get; set; }
        public virtual DbSet<Bookings> Bookings { get; set; }
        public virtual DbSet<Flights> Flights { get; set; }
        public virtual DbSet<Passengers> Passengers { get; set; }
        public virtual DbSet<Terminals> Terminals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(" Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=S:\\כתה יב\\מדעי המחשב\\עדן\\DataBase\\DataBase.mdf;Integrated Security=True;Connect Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aircraft>(entity =>
            {
                entity.Property(e => e.AircraftId).HasColumnName("AircraftID");

                entity.Property(e => e.AirlineId).HasColumnName("AirlineID");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(50);

                //entity.HasOne(d => d.Airline)
                //    .WithMany(p => p.Aircraft)
                //    .HasForeignKey(d => d.AirlineId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_Aircraft_ToTable");
            });

            modelBuilder.Entity<Airlines>(entity =>
            {
                entity.HasKey(e => e.AirlineId)
                    .HasName("PK__tmp_ms_x__DC458273C7CA37D6");

                entity.Property(e => e.AirlineId).HasColumnName("AirlineID");

                entity.Property(e => e.AirlineName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Airports>(entity =>
            {
                entity.HasKey(e => e.AirportId)
                    .HasName("PK__tmp_ms_x__E3DBE08A2823E1E5");

                entity.Property(e => e.AirportId).HasColumnName("AirportID");

                entity.Property(e => e.AirportName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Baggage>(entity =>
            {
                entity.Property(e => e.BaggageId).HasColumnName("BaggageID");

                entity.Property(e => e.BaggageTag)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BaggageType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BookingId).HasColumnName("BookingID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                //entity.HasOne(d => d.Booking)
                //    .WithMany(p => p.Baggage)
                //    .HasForeignKey(d => d.BookingId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_Baggage_ToTable");
            });

            modelBuilder.Entity<Bookings>(entity =>
            {
                entity.HasKey(e => e.BookingId)
                    .HasName("PK__tmp_ms_x__73951ACDB9F291E7");

                entity.Property(e => e.BookingId).HasColumnName("BookingID");

                entity.Property(e => e.BookingDate)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BookingStatus)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FlightId).HasColumnName("FlightID");

                entity.Property(e => e.PassengerCode).HasColumnName("passengerCode");

                entity.Property(e => e.SeatId).HasColumnName("SeatID");

                //entity.HasOne(d => d.Flight)
                //    .WithMany(p => p.Bookings)
                //    .HasForeignKey(d => d.FlightId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_Bookings_ToTable_1");

                //entity.HasOne(d => d.PassengerCodeNavigation)
                //    .WithMany(p => p.Bookings)
                //    .HasForeignKey(d => d.PassengerCode)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_Bookings_ToTable");
            });

            modelBuilder.Entity<Flights>(entity =>
            {
                entity.HasKey(e => e.FlightId)
                    .HasName("PK__tmp_ms_x__8A9E148E805A6FAC");

                entity.Property(e => e.FlightId).HasColumnName("FlightID");

                entity.Property(e => e.AircraftId).HasColumnName("AircraftID");

                entity.Property(e => e.ArrivalAirportId).HasColumnName("ArrivalAirportID");

                entity.Property(e => e.DepartureAirportId).HasColumnName("DepartureAirportID");

                entity.Property(e => e.DepartureDate)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DepartureTime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                //entity.HasOne(d => d.Aircraft)
                //    .WithMany(p => p.Flights)
                //    .HasForeignKey(d => d.AircraftId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_Flights_ToTable_1");

                //entity.HasOne(d => d.ArrivalAirport)
                //    .WithMany(p => p.FlightsArrivalAirport)
                //    .HasForeignKey(d => d.ArrivalAirportId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_Flights_ToTable_3");

                //entity.HasOne(d => d.DepartureAirport)
                //    .WithMany(p => p.FlightsDepartureAirport)
                //    .HasForeignKey(d => d.DepartureAirportId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_Flights_ToTable_2");
            });

            modelBuilder.Entity<Passengers>(entity =>
            {
                entity.HasKey(e => e.PassengerCode)
                    .HasName("PK__tmp_ms_x__FD015E9BA05A0965");

                entity.Property(e => e.PassengerCode).HasColumnName("passengerCode");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PassengerId).HasColumnName("PassengerID");

                entity.Property(e => e.PassportNumber)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Terminals>(entity =>
            {
                entity.HasKey(e => e.TerminalId)
                    .HasName("PK__tmp_ms_x__6A7263495EE5950A");

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.AirportId).HasColumnName("AirportID");

                //entity.HasOne(d => d.Airport)
                //    .WithMany(p => p.Terminals)
                //    .HasForeignKey(d => d.AirportId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_Terminals_ToTable");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
