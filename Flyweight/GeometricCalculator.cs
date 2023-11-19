using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Flyweight;

    public class GeometricCalculator
    {
        public string Equacao { get; set; }
        public Flyweight? Flyweight { get; set; }
        public GeometricCalculator(string equacao, Flyweight? flyweight)
        {
            Equacao = equacao;
            Flyweight = flyweight;
        }
    }
