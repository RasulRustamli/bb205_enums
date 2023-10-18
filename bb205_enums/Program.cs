using bb205_enums.Models;

namespace bb205_enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Departament departament = new Departament("Samsung");

            Person person = new Person("Ismayil","Ceferov",PositionEnum.Employe);
            Person person2 = new Person("Ilkin","Recebov", PositionEnum.Employe);
            Person person3 = new Person("Esed","Abbasov", PositionEnum.Director);
            Person person4 = new Person("Narmin","Sivaxanova", PositionEnum.Boss);

            departament.AddPerson(person,person2, person3,person4);

            foreach (var item in departament.FilterPosition(1))
            {
                Console.WriteLine(item.Name+" "+item.Position);
            }





        }
        
    }


   

}