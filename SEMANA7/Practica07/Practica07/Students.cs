using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica07
{
    class Students
    {
        public int idStudent { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string genero { get; set; }


        //Crear la coleccion de datos 
        public static List<Students> GetStudents()
        {
            List<Students> students = new List<Students>
            {
                new Students{ idStudent= 1001, firstName= "Jasson", lastName="Gomez", age=17, genero= "Masculino"},
                new Students{ idStudent= 1002, firstName= "William", lastName="Rodirguez", age=16, genero= "Masculino" },
                new Students{ idStudent= 1003, firstName= "Daniel", lastName="Silva", age=22, genero= "Masculino" },
                new Students{ idStudent= 1004, firstName= "Xiomara", lastName="Ramos", age=16, genero= "Femenino" },
                new Students{ idStudent= 1005, firstName= "Ada", lastName="Coreas", age=15, genero= "Femenino" },
                new Students{ idStudent= 1006, firstName= "Carolina", lastName="Granados", age=18, genero= "Femenino" },
                new Students{ idStudent= 1007, firstName= "Emely", lastName="Turcios", age=19, genero= "Fememino" }
            };

            //Valor de retorno, sera la lista de estudiantes
            return students;
        }
    }

}

