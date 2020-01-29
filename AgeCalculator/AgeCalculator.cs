using System;

namespace BirthdayCalculator
{
    /// <summary>
    /// Age Calculator
    /// </summary>
    public class AgeCalculator
    {
        public DateTime _currentDateTime;

        public AgeCalculator(DateTime currentDateTime)
        {
            _currentDateTime = currentDateTime;
        }

        /// <summary>
        /// Calculate age based on birth date string
        /// </summary>
        /// <param name="dateOfBirthStr"></param>
        /// <returns></returns>
        public int CalculateAge(string dateOfBirthStr)
        {
            DateTime dateOfBirth;

            try
            {
                dateOfBirth = DateTime.Parse(dateOfBirthStr);
            }
            catch (Exception exc)
            {
                throw new Exception("Date of birth must be correct and in mm/dd/yyyy format.");
            }

            int age = 0;
            age = _currentDateTime.Year - dateOfBirth.Year;
            if (_currentDateTime.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }
    }
}
