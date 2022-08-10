using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Person:IEntity
    {
        public Person()
        {

        }

        public Person(int ıd, string name, string lastName, int ıdentityNumber, string phoneNumber, string emailAddress, DateTime jobEntry, DateTime? jobExit, bool ıSSoldier, bool gender, string education, string addresses, bool ıSTrue)
        {
            Id = ıd;
            Name = name;
            LastName = lastName;
            IdentityNumber = ıdentityNumber;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;
            JobEntry = jobEntry;
            JobExit = jobExit;
            ISSoldier = ıSSoldier;
            Gender = gender;
            Education = education;
            Addresses = addresses;
            ISTrue = ıSTrue;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int IdentityNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public DateTime JobEntry { get; set; }
        public DateTime? JobExit { get; set; }
        //Soldier True
        public bool ISSoldier { get; set; }
        public bool Gender { get; set; }
        public string Education { get; set; }
        public string Addresses { get; set; }
        //Aktif Çalşıyor
        public bool ISTrue { get; set; }



    }
}
