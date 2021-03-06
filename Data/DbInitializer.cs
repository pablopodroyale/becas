﻿using Beca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Beca.Data
{
    public class DbInitializer
    {
        public static void Initialize(BecaContext context)
        {
            context.Database.EnsureCreated();
            // Busca si existe encuestas en la BD.
            if (context.Encuesta.Any())
            {
                return; // Si existe registros la BD Ha sido creada
            }
            var encuestas = new Encuesta[]
            {
                new Encuesta{Nombre="Pablo",Apellido="Podgaiz",Dni_Libreta=31090777,Domicilio="Salguero 1547 6 21",Localidad="capital",Telefono="48239999",Email="pod@pod.com",Pregunta_Aumento_Transporte="una banda",Pregunta_Boleto_Edu="si",Pregunta_Beca_Transporte="si",Pregunta_Politica_Permanencia="si",Pregunta_Politica_Iniciativas="menu",Pregunta_Comentarios="me gusta que hagaan esta encuesta",Chequeado=false}
            };
            foreach (Encuesta c in encuestas)
            {
                context.Encuesta.Add(c);
            }
            context.SaveChanges();
        }
    }
}
