﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Product.API.Infrastructure;

namespace Product.API.Migrations
{
    [DbContext(typeof(ProductContext))]
    partial class ProductContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("public")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("Relational:Sequence:public.product_id_seq", "'product_id_seq', 'public', '1', '1', '', '', 'Int64', 'False'");

            modelBuilder.Entity("Product.API.Model.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ProductID")
                        .HasDefaultValueSql("nextval('account.product_id_seq'::regclass)");

                    b.Property<decimal>("Price")
                        .HasColumnName("Price");

                    b.Property<string>("ProductDescription")
                        .HasColumnName("ProductDescription")
                        .HasMaxLength(500);

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnName("ProductName")
                        .HasMaxLength(200);

                    b.HasKey("ProductID");

                    b.ToTable("Products","public");
                });
#pragma warning restore 612, 618
        }
    }
}
