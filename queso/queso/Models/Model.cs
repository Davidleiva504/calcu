using System;
using System.Collections.Generic;
using System.Text;

namespace queso.Models
{
    public class Models
    {
        
            public int n1 { set; get; }   
            public int n2 { set; get; }

            public int sumar()
            {
                int total = 0;
                total = n1 + n2;
                return total;
            }

            public int Resta()
            {
                int total = 0;
                total = n1 - n2;
                return total;
            }

            public int division()
            {
                int total = 0;
                total = n1 / n2;
                return total;
            }

            public int multiplicar()
            {
                int total = 0;
                total = n1 * n2;
                return total;
            }

        
    }
}
