using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;
using WebApplication1;
using WebApplication1.Models;

namespace WebApplication1.Models
{

    public class FunctionData
    {
        [Required(ErrorMessage = " Вы не ввели коэффицциент A  ")]

        public int A { get; set; }

        [Required(ErrorMessage = "Вы не ввели коэффицциент B")]

        public int B { get; set; }

        public int C { get; set; }



        //[Range(typeof(decimal), "0.01", "100.00", ErrorMessage = "Наименьшее значение 0.01")] /*Этот атрибут не работает с  атрибутом типа  */
        //data-value в HTML.TextBoxFor  Step
        public double Step { get; set; }

        public int Range1 { get; set; }
        public int Range2 { get; set; }

        public List<Point> Points { get; set; }

        public struct Point
        {
            public double X { get; set; }
            public double Y { get; set; }
        }
    }
}