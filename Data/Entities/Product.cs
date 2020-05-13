using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanWebApp.Data.Entities
{
  public class Product
  {
    public int Id { get; set; }
    public string Marca { get; set; }
    public string ModelMasina { get; set; }
    public decimal An { get; set; }
    public decimal Price { get; set; }
    public string Asigurare { get; set; }
    public string Varsta { get; set; }
    public string ArtId { get; set; }
    public string Comision { get; set; }
    public DateTime DataInceput { get; set; }
    public DateTime DataFinal { get; set; }
    public string Nationalitate { get; set; }
  }
}