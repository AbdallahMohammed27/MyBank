using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Repos
    {
        public static IEnumerable<Empolyee> LoadEmpoyees()
        {
            return new List<Empolyee>
            {
                new Empolyee
                {
                    Id=1,
                    Fname="abdallah",
                    Lname="mohammed",
                    Title="Luxor",
                    Salary=334.32m,
                    Birth_Date=new DateTime(2003,7,2)
                },

                new Empolyee
                {
                    Id=2,
                    Fname="mohammed",
                    Lname="mostafa",
                    Title="Luxor",
                    Salary=3340.32m,
                    Birth_Date=new DateTime(1990,7,2)
                },


                new Empolyee
                {
                    Id=3,
                    Fname="ali",
                    Lname="ayman",
                    Title="Aswan",
                    Salary=3144.32m,
                    Birth_Date=new DateTime(1890,4,1)
                },

                new Empolyee
                {
                    Id=4,
                    Fname="omer",
                    Lname="mohammed",
                    Title="Gaza",
                    Salary=1034.32m,
                    Birth_Date=new DateTime(2023,10,2)
                },


                new Empolyee
                {
                    Id=5,
                    Fname="othman",
                    Lname="ahmed",
                    Title="Gaze",
                    Salary=393930.32m,
                    Birth_Date=new DateTime(1830,9,1)
                },


                new Empolyee
                {
                    Id=6,
                    Fname="hitham",
                    Lname="ahmed",
                    Title="Alex",
                    Salary=550.0m,
                    Birth_Date=new DateTime(2006,1,1)
                },

                new Empolyee
                {
                    Id=7,
                    Fname="ahmed",
                    Lname="mostafa",
                    Title="Sohag",
                    Salary=2002.32m,
                    Birth_Date=new DateTime(2010,3,2)
                },

                new Empolyee
                {
                    Id=8,
                    Fname="hazam",
                    Lname="gamal",
                    Title="Cairo",
                    Salary=990.32m,
                    Birth_Date=new DateTime(2021,4,1)
                },

                new Empolyee
                {
                    Id=9,
                    Fname="salah",
                    Lname="mohammed",
                    Title="Aussit",
                    Salary=9990.32m,
                    Birth_Date=new DateTime(2017,7,2)
                },

                new Empolyee
                {
                    Id=10,
                    Fname="ali",
                    Lname="mohammed",
                    Title="Qina",
                    Salary=9903.32m,
                    Birth_Date=new DateTime(1990,4,2)
                }

            };
        }
    }
}
