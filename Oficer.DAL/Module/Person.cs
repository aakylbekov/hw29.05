using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficer.DAL.Module
{
    //(код ранга, адрес и номер телефона для любой будущей справки)
    //(Например, офицер – только для происшествий в городе, Следователь – для криминальных 
    //        происшествий, прапорщик, лейтенант – для мелких правонарушений и т.д.)
    public enum Rank
    {
        Letitnant, Praporshik, Sledovatel, Oficer
    }
    public class Person : Cariers
    {
        public string Name { get; set; }
        public Rank Rank
        {
            get { return Rank; }
            set
            {
                Rank = value;
                if (Rank == Rank.Letitnant)
                    salary_ = 80000;
                else if (Rank == Rank.Praporshik)
                    salary_ = 100000;
                else if (Rank == Rank.Sledovatel)
                    salary_ = 120000;
                else if (Rank == Rank.Oficer)
                    salary_ = 150000;
            }
        }
        private double salary_;
        public double Salary
        {
            get { return salary_; }
        }
    }
}
