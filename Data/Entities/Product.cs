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
    public string TipCredit { get; set; }
    public string SumaImp { get; set; }
    public decimal DurataCr { get; set; }
    public string VenitLunar { get; set; }
    public string DobandaAnuala { get; set; }
    public string Varsta { get; set; }
    public string ArtId { get; set; }
    public string Comision { get; set; }
    public DateTime DataInceput { get; set; }
    public DateTime DataFinal { get; set; }
    public string Nationalitate { get; set; }
  }
}