using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmissionNew
{
    public class Reservation
    {
        Reservation Reservations = new Reservation();

        public Reservation()
        {
        }

        public Reservation(object name)
        {
            Name = name;
        }

        public object Name { get; }
    }
}
