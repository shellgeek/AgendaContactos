﻿using AgendaContactos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContactos
{
    public class dataBaseContext
    {
        public dataBaseContext()
        {
            //base de datos
            this.Contactos = new List<classContacto>()
            {
                new classContacto(){Id=0001, Nombres="Cristhian",Apellidos ="De Castro",Sexo="Masculino",Direccion="WinstonArnaud # 98",Ciudad="Santo Domigno",Email="Cristhiancastro01@gmail.com",Pais="Rep.Dom",TelefonoMovil="849-916-8407"},
                new classContacto(){Id=0002,Nombres="John",Apellidos="Wick",Sexo="Masculino",Direccion="1091 IN-49",Ciudad="Indiana",Email="JohnWickBestKiller@gmail.com",Pais="United States",TelefonoMovil="(917)-JohnWick"},
                new classContacto(){Id=0003,Nombres="John",Apellidos="Cena",Sexo="Masculino",Direccion=" West Newbury",Ciudad="Massachusetts",Email="It'sJohnCena@gmail.com",Pais="United States",TelefonoMovil="(917)-JohnCena"},
                new classContacto(){Id=0004,Nombres="Arnold",Apellidos="schwarzenegger",Sexo="Masculino",Direccion="Thal",Ciudad="Graz",Email="Mr.schwarzenegger@gmail.com",Pais="Austria",TelefonoMovil="(917)-schwarzenegger"},
                new classContacto(){Id=0005,Nombres="Rosa",Apellidos="Melano",Sexo="Femenino",Direccion="Su casa",Ciudad="Hato Mayor",Email="Rasamelano@gmail.com",Pais="Republica Dominicana",TelefonoMovil="809-555-2575"},
                new classContacto(){Id=0006,Nombres="Matilde",Apellidos="Ramos",Sexo="Femenino",Direccion="Su apartamento",Ciudad="Puerto Plata",Email="Marramos@correo.com",Pais="Republica Dominicana",TelefonoMovil="809-754-8852"},
                new classContacto(){Id=0007,Nombres="Carolina",Apellidos="Mejia",Sexo="Masculino",Direccion="Calle B",Ciudad="Samana",Email="Carmejia@yahoo.com",Pais="Republica Dominicana",TelefonoMovil="809-372-9987" },
                new classContacto(){Id=0008,Nombres="Amanda",Apellidos="Merrywheter",Sexo="Femenino",Direccion="Zona universitaria",Ciudad="Santo Domingo",Email="AmandaCampos@correorandom.com",Pais="Republica Dominicana",TelefonoMovil="809-620-8879" },
                new classContacto(){Id=0009,Nombres="Tony",Apellidos="Stark",Sexo="Masculino",Direccion="The Stak Mansion",Ciudad="New York",Email="TStark@Ironman.com",Pais="Estados Unidos",TelefonoMovil="916-852-741" },
                new classContacto(){Id=0010,Nombres="Maria",Apellidos="Del Carmen",Sexo="Femenino",Direccion="La torre eifel",Ciudad="Santo Domingo",Email="MDelCarmenV@Virgencita.com",Pais="Republica Dominicana",TelefonoMovil="849-056-2103"}
            };
        }
        //Lista base de datos
        public List<classContacto> Contactos;
    }
        
}
