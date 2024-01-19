using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Clases
{
    class Estaciones
    {
        public Dictionary<string, string> estaciones;

        public Estaciones()
        {
            this.cargarEstaciones();
        }

        public Dictionary<string, string> getEstaciones()
        {
            return this.estaciones;
        }

        private void cargarEstaciones()
        {
            this.estaciones = new Dictionary<string, string>();
            this.estaciones.Add("0", "Calle 76");
            this.estaciones.Add("1", "Calle 72 ");
            this.estaciones.Add("2", "Flores");
            this.estaciones.Add("3", "Calle 63");
            this.estaciones.Add("4", "Calle 57 ");
            this.estaciones.Add("5", "Marly");
            this.estaciones.Add("6", "Calle 45");
            this.estaciones.Add("7", "Av 39");
            this.estaciones.Add("8", "Calle 34 ");
            this.estaciones.Add("9", "Calle 26 ");
            this.estaciones.Add("10", "Calle 22");
            this.estaciones.Add("11", "Calle 19 ");
            this.estaciones.Add("12", "Av Jimenez");
            this.estaciones.Add("13", "Tercer Milenio");
            this.estaciones.Add("14", "Terminal");
            this.estaciones.Add("15", "Calle 187");
            this.estaciones.Add("16", "Portal Norte");
            this.estaciones.Add("17", "Toberin");
            this.estaciones.Add("18", "Calle 161");
            this.estaciones.Add("19", "Mazuren");
            this.estaciones.Add("20", "Clle 146");
            this.estaciones.Add("21", "Calle 142");
            this.estaciones.Add("22", "Alcala");
            this.estaciones.Add("23", "Prado");
            this.estaciones.Add("24", "Calle 127");
            this.estaciones.Add("25", "Pepe Sierra");
            this.estaciones.Add("26", "Calle 106");
            this.estaciones.Add("27", "Calle 100");
            this.estaciones.Add("28", "Virrey");
            this.estaciones.Add("29", "Calle 85");
            this.estaciones.Add("30", "Heroes");
            this.estaciones.Add("31", "San Martin");
            this.estaciones.Add("32", "Rio Negro");
            this.estaciones.Add("33", "Suba Calle 95");
            this.estaciones.Add("34", "Suba Calle 100");
            this.estaciones.Add("35", "Puente Largo");
            this.estaciones.Add("36", "Av Suba Cll 116");
            this.estaciones.Add("37", "Humedal Cordoba");
            this.estaciones.Add("38", "Nisa Cll 127");
            this.estaciones.Add("39", "Suba Av Boyacá");
            this.estaciones.Add("40", "Gratamira");
            this.estaciones.Add("41", "21 Angeles");
            this.estaciones.Add("42", "Suba Tv 91");
            this.estaciones.Add("43", "La Campiña ");
            this.estaciones.Add("44", "Portal de Suba");
            this.estaciones.Add("45", "Polo");
            this.estaciones.Add("46", "Escuela Militar");
            this.estaciones.Add("47", "Cra 47");
            this.estaciones.Add("48", "Cra 53");
            this.estaciones.Add("49", "Av 68");
            this.estaciones.Add("50", "Ferias");
            this.estaciones.Add("51", "Boyaca");
            this.estaciones.Add("52", "Minuto de Dios");
            this.estaciones.Add("53", "Granja");
            this.estaciones.Add("54", "Av Cali");
            this.estaciones.Add("55", "Cra 90");
            this.estaciones.Add("56", "Quirigua");
            this.estaciones.Add("57", "Portal 80");
            this.estaciones.Add("58", "Castellana");
            this.estaciones.Add("59", "NQS Calle 75");
            this.estaciones.Add("60", "Av Chile");
            this.estaciones.Add("61", "Simon Bolivar");
            this.estaciones.Add("62", "Movistar Arena");
            this.estaciones.Add("63", "Campin");
            this.estaciones.Add("64", "Universidad Nacional");
            this.estaciones.Add("65", "Av el Dorado");
            this.estaciones.Add("66", "CAD");
            this.estaciones.Add("67", "Paloquemao");
            this.estaciones.Add("68", "Ricaurte");
            this.estaciones.Add("69", "Comuneros");
            this.estaciones.Add("70", "Guatoque");
            this.estaciones.Add("71", "Tygua San Jose");
            this.estaciones.Add("72", "De La Sabana");
            this.estaciones.Add("73", "San Facon");
            this.estaciones.Add("74", "CDS Cra 32");
            this.estaciones.Add("75", "Zona Industrial");
            this.estaciones.Add("76", "Cra 43");
            this.estaciones.Add("77", "Puente Aranda");
            this.estaciones.Add("78", "Americas Cra 53 A");
            this.estaciones.Add("79", "Pradera");
            this.estaciones.Add("80", "Marsella");
            this.estaciones.Add("81", "Av Americas");
            this.estaciones.Add("82", "Mandalay");
            this.estaciones.Add("83", "Banderas");
            this.estaciones.Add("84", "Transversal 86");
            this.estaciones.Add("85", "Biblioteca Tintal");
            this.estaciones.Add("86", "Patio Bonito");
            this.estaciones.Add("87", "Portal de las Americas");
            this.estaciones.Add("88", "Santa Isabel");
            this.estaciones.Add("89", "SENA");
            this.estaciones.Add("90", "NQS Calle 30 Sur");
            this.estaciones.Add("91", "NQS Calle 38 A Sur");
            this.estaciones.Add("92", "General Santander");
            this.estaciones.Add("93", "Alqueria");
            this.estaciones.Add("94", "Venecia");
            this.estaciones.Add("95", "Sevillana");
            this.estaciones.Add("96", "Madelena");
            this.estaciones.Add("97", "Perdomo");
            this.estaciones.Add("98", "Portal del Sur");
            this.estaciones.Add("99", "Bosa");
            this.estaciones.Add("100", "La Despensa");
            this.estaciones.Add("101", "Leon 13");
            this.estaciones.Add("102", "Terreros ");
            this.estaciones.Add("103", "San Mateo");
            this.estaciones.Add("104", "Hospital");
            this.estaciones.Add("105", "Hortua");
            this.estaciones.Add("106", "Nariño");
            this.estaciones.Add("107", "Fucha");
            this.estaciones.Add("108", "Restrepo");
            this.estaciones.Add("109", "Olaya");
            this.estaciones.Add("110", "Quiroga");
            this.estaciones.Add("111", "Calle 40 Sur");
            this.estaciones.Add("112", "Santa Lucia");
            this.estaciones.Add("113", "Socorro");
            this.estaciones.Add("114", "Consuelo");
            this.estaciones.Add("115", "Molinos");
            this.estaciones.Add("116", "Portal Usme");
            this.estaciones.Add("117", "Biblioteca");
            this.estaciones.Add("118", "Parque");
            this.estaciones.Add("119", "Portal Tunal");
            this.estaciones.Add("120", "Las Aguas");
            this.estaciones.Add("121", "Museo del Oro");
            this.estaciones.Add("122", "San Victorino");
            this.estaciones.Add("123", "Universidades");
            this.estaciones.Add("124", "San Diego");
            this.estaciones.Add("125", "Centro de Memoria");
            this.estaciones.Add("126", "Concejo de Bogota");
            this.estaciones.Add("127", "Ciudad Universitari");
            this.estaciones.Add("128", "Recinto Feria");
            this.estaciones.Add("129", "Quinta Paredes");
            this.estaciones.Add("130", "Gobernacion");
            this.estaciones.Add("131", "CAN");
            this.estaciones.Add("132", "Salitre el Greco");
            this.estaciones.Add("133", "El Tiempo - Maloka");
            this.estaciones.Add("134", "Av Rojas");
            this.estaciones.Add("135", "Normandia");
            this.estaciones.Add("136", "Portal el Dorado");
            this.estaciones.Add("137", "Las Nieves");
            this.estaciones.Add("138", "Bicentenario");
            this.estaciones.Add("139", "San Bernardo");
            this.estaciones.Add("140", "Policarpa");
            this.estaciones.Add("141", "Ciudad Jardin");
            this.estaciones.Add("142", "Av Primera de Mayo");
            this.estaciones.Add("143", "Country Sur");
            this.estaciones.Add("144", "Portal 20 de Julio");
            this.estaciones.Add("145", "Juan Pablo Segundo");
            this.estaciones.Add("146", "Manitas");
            this.estaciones.Add("147", "Mirador del Paraiso");

        }

    }
}
