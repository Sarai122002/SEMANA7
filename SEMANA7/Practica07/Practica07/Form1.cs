using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            dgData.Columns.Add("idStudent", "CODIGO");
            dgData.Columns.Add("firstName", "NOMBRE");
            dgData.Columns.Add("lastName", "APELLIDO");
            dgData.Columns.Add("age", "EDAD");
            dgData.Columns.Add("genero", "GENERO");

            foreach (var student in selectAllData())
            {
                dgData.Rows.Add(student.idStudent, student.firstName, student.lastName,
                student.age, student.genero);

            }
        }

        //metodo para retornar la coleccion de datos

        private List<Students> selectAllData()
        {
            // crear la consulta 
            List<Students> result = (
                   from student in Students.GetStudents()
                   select new Students()
                   {
                       idStudent = student.idStudent,
                       firstName = student.firstName,
                       lastName = student.lastName,
                       age = student.age,
                       genero = student.genero
                   }

                   ).ToList();

            return result;

        }

    }
}