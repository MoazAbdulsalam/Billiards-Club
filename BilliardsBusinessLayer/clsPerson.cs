using System.Data;
using BilliardsDataAccessLayer;
using BilliardsDataAccessLayer.DTOs;
namespace BilliardsBusinessLayer
{
    public class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int PersonID { get; private set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string? ThirdName { get; set; }
        public string LastName { get; set; }
        public string FullName()
        {
            return FirstName + " " + SecondName + " " + (ThirdName == null? "" : ThirdName)+ (ThirdName == null ? "" : " ") + LastName;
        }
        public string NationalNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte Gender { get; set; }// 0 = male 1= female
        public string Address { get; set; }
        public string Phone { get; set; }
        public string? Email { get; set; }
        public string? ImagePath { get; set; }

        public clsPerson()
        {
            PersonID = -1;
            FirstName = "";
            SecondName = "";
            ThirdName = null;
            LastName = "";
            NationalNo = "";
            DateOfBirth = DateTime.Now;
            Gender = 0;
            Address = "";
            Phone = "";
            Email = null;
            ImagePath = null;
        }
        private clsPerson(clsPersonDTO Person)
        {
            this.PersonID = Person.PersonID;
            this.NationalNo = Person.NationalNo;
            this.FirstName = Person.FirstName;
            this.SecondName = Person.SecondName;
            this.ThirdName = Person.ThirdName;
            this.LastName = Person.LastName;
            this.DateOfBirth = Person.DateOfBirth;
            this.Gender = Person.Gender;
            this.Address = Person.Address;
            this.Phone = Person.Phone;
            this.Email = Person.Email;
            this.ImagePath = Person.ImagePath;
            this.Mode = enMode.Update;


        }
        public static async Task<clsPerson?> FindAsync(int PersonID)
        {
            clsPersonDTO? PersonDto = await clsPeopleData.GetPersonInfoByIdAsync(PersonID);
            if (PersonDto == null)
                return null;

            return new clsPerson(PersonDto);
        }
        public static async Task<clsPerson?> FindAsync(string NationalNo)
        {
            clsPersonDTO? PersonDto = await clsPeopleData.GetPersonInfoByNationalNoAsync(NationalNo);
            if (PersonDto == null)
                return null;

            return new clsPerson(PersonDto);
        }

        private async Task<bool> _AddNewPerson()
        {
            int? ID = await clsPeopleData.AddNewPersonAsync(this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gender, this.Address, this.Phone, this.Email,  this.ImagePath);
            if (ID == null)
                return false;
            this.PersonID = ID.Value;
            
            
            return true;
        }
        //الداله دي  مش متعلمه انها غسر متزامنه من ناحيه كتابه الكود ولكنها غير متزامنه عشان بترجع تاسك
        private Task<bool> _UpdatePerson()
        {
            return clsPeopleData.UpdatePersonAsync(this.PersonID, this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gender, this.Address, this.Phone, this.Email,this.ImagePath);
        }

        public async Task<bool> SaveAsync()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if ( await _AddNewPerson())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return await _UpdatePerson();

            }

            return false;
        }
        public static Task<DataTable>GetAllPeople()
        {
            return clsPeopleData.GetAllPeopleAsync();

        }

        public static Task<bool> DeletePerson(int ID)
        {
            return clsPeopleData.DeletePerson(ID);
        }

        public static Task<bool> isPersonExist(int ID)
        {
            return clsPeopleData.IsPersonExist(ID);
        }
        public static Task<bool> isPersonExist(string NationalNo)
        {
            return clsPeopleData.IsPersonExist(NationalNo);
        }


    }
}
