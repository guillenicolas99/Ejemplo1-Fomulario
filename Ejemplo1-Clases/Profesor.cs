﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1_Clases
{
    //Implementamos la herenciA
    public class Profesor:Persona
    {
        //campo
        string iNSS;
        double salario;
        //Composición,
        //Un profesr imparte clases en varios centros
        public List<Centro> Centros = new List<Centro>();
        //Constructor
        public Profesor()
        { }
        public Profesor(string id, string nombre, string direccion, string telf, string email, string iNSS, double salario):base(id, nombre, direccion, telf, email)
        {
            this.iNSS = iNSS;
            this.salario = salario;
            
        }
        //Propiedades
        public string INSS
        {
            get
            {
                return iNSS;
            }

            set
            {
                iNSS = value;
            }
        }

        public double Salario
        {
            get
            {
                return salario;
            }

            set
            {
                salario = value;
            }
        }
    }
}
