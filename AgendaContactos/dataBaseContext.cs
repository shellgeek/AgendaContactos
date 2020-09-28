using AgendaContactos.Models;
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
                new classContacto(){Id="0001", Nombres="Cristhian",Apellidos ="De Castro",Sexo="Masculino",Direccion="WinstonArnaud # 98",Ciudad="Santo Domigno",Email="Cristhiancastro01@gmail.com",Pais="Rep.Dom",TelefonoMovil="849-916-8407",ID=1},
                new classContacto(){Id="0002",Nombres="John",Apellidos="Wick",Sexo="Masculino",Direccion="1091 IN-49",Ciudad="Indiana",Email="JohnWickBestKiller@gmail.com",Pais="United States",TelefonoMovil="(917)-JohnWick",ID=2},
                new classContacto(){Id="0003",Nombres="John",Apellidos="Cena",Sexo="Masculino",Direccion=" West Newbury",Ciudad="Massachusetts",Email="It'sJohnCena@gmail.com",Pais="United States",TelefonoMovil="(917)-JohnCena",ID=3},
                new classContacto(){Id="0004",Nombres="Arnold",Apellidos="schwarzenegger",Sexo="Masculino",Direccion="Thal",Ciudad="Graz",Email="Mr.schwarzenegger@gmail.com",Pais="Austria",TelefonoMovil="(917)-schwarzenegger",ID=4},
                new classContacto(){Id="0005",Nombres="Rosa",Apellidos="Melano",Sexo="Femenino",Direccion="Su casa",Ciudad="Hato Mayor",Email="Rasamelano@gmail.com",Pais="Republica Dominicana",TelefonoMovil="809-555-2575" ,ID=5},
                new classContacto(){Id="0005",Nombres="Matilde",Apellidos="Ramos",Sexo="Femenino",Direccion="Su apartamento",Ciudad="Puerto Plata",Email="Marramos@correo.com",Pais="Republica Dominicana",TelefonoMovil="809-754-8852",ID=6 },
                new classContacto(){Id="0006",Nombres="Carolina",Apellidos="Mejia",Sexo="Masculino",Direccion="Calle B",Ciudad="Samana",Email="Carmejia@yahoo.com",Pais="Republica Dominicana",TelefonoMovil="809-372-9987",ID=7 },
                new classContacto(){Id="0007",Nombres="Amanda",Apellidos="Merrywheter",Sexo="Femenino",Direccion="Zona universitaria",Ciudad="Santo Domingo",Email="AmandaCampos@correorandom.com",Pais="Republica Dominicana",TelefonoMovil="809-620-8879",ID=8 },
                new classContacto(){Id="0008",Nombres="Tony",Apellidos="Stark",Sexo="Masculino",Direccion="The Stak Mansion",Ciudad="New York",Email="TStark@Ironman.com",Pais="Estados Unidos",TelefonoMovil="916-852-741",ID=9 },
                new classContacto(){Id="0009",Nombres="Maria",Apellidos="Del Carmen",Sexo="Femenino",Direccion="La torre eifel",Ciudad="Santo Domingo",Email="MDelCarmenV@Virgencita.com",Pais="Republica Dominicana",TelefonoMovil="849-056-2103",ID=10 }
            };
        }
        //Lista base de datos
        public List<classContacto> Contactos;
    }
        
}
