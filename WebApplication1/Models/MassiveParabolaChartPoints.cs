using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Models
{
    public class MassiveParabolaChartPoints
    {
        public void MassivePoints(FunctionData model)
        {
            var _points = new List<FunctionData.Point>();
            for (double i = model.Range1; i <= model.Range2; i += model.Step)
            {
                _points.Add(new FunctionData.Point { X = i, Y = model.A * i * i + model.B * i + model.C });

            }

            model.Points = _points;
        }
    }
}