using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace impresionTicket
{
    public class productos
    {

        public String codigo {  get; set; }
        public String ubicacion
        {get; set;}
        public string unidadMedida
        {get; set;}
        public string producto{get; set; }
            public string descripcion{get; set;}
        public double precioVenta { get; set; }
        public int cantidad { get; set; }
        public double subtotal { get; set; }
        public double total { get; set; }
        public double precioCosto
        {
        get; set; }
        
        public int hay
        {
        get; set; }
        public int minimo
        {
        get; set; }
        public int maximo
        {
        get; set;}

    }
}
