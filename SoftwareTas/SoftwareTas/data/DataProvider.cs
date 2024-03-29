﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTas.data
{
   public class DataProvider
    {
       public static Departement GiveCollegeData()
        {
            Departement collegeLeNil = new Departement
            {
                Name = "College Charles de Gaulles"
            ,
                Parent = null
            };

            //Ajout Principaux sous-departements;
            Departement classrooms = new Departement
            {
                Name = "Les Salle de classes"
            };

            for(int i= 0; i< 5; i++)
            {
                Departement classe = new Departement
                {
                    Name = "CM " + i,
                };
                classe.AddELeves(getEleves(20, classe.Name));
                classrooms.AddDepartement(classe);

              
            }

            collegeLeNil.AddDepartement(classrooms);
            return collegeLeNil;
        }


       static List<Eleve> getEleves(int i, string nameDpt)
        {
            List<Eleve> eleves = new List<Eleve>();
            if (i < 10) i = 10;

            for(int n =0; n<i; n++)
            {
                eleves.Add(new Eleve
                {
                    Name = $"Nom Eleve {n} {nameDpt}",
                    Surname="Prenom eleve "+n,
                    Matricule="Mat "+n
                });
            }
            return eleves;
        }
        
        public Departement DepartementTreeFromDatabase()
        {
            imsdbDataSet imsdbDataSet= new SoftwareTas.imsdbDataSet();

            imsdbDataSet.departmentDataTable departments = new imsdbDataSet.departmentDataTable();
            return new Departement();
        }

        public static List<Eleve> GetStudentData()
        {
            List<Eleve> liste = new List<Eleve>();

            for(int i=0; i< 20; i++)
            {
                liste.Add(new Eleve {
                    Departement = new Departement { Name = "Cm2" },
                    Id = i,
                    Surname="Kamga "+i,
                    Name="Bruno "+i,
                    Matricule="CM"+i
                });
            }

            return liste;
        }
    }
}
