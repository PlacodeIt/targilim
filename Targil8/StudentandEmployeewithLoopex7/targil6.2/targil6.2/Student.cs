using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Targil5_2NEW
{
    class Student
    {
        private string m_FName;
        private string m_LName;
        private string m_StudID;
        private double m_AcadPoints;
        
        public Student(string FName,string LNmame,string ID,double points)
        {
            m_AcadPoints = points;
            m_FName = FName;
            m_LName = LNmame;
            m_StudID = ID;
        }
        public double Get_AcademicPoints()
        {
            return m_AcadPoints;
        }
        public void Set_AcademicPoints(int AP)
        {
            m_AcadPoints = AP;
        }

        public string Get_FirstName()
        {
            return m_FName;
        }
        public string Get_LastName()
        {
            return m_LName;
        }
        public string Get_StudentID()
        {
            return m_StudID;
        }

        public double NeedToPay()
        {
            const double MaxPoints = 22;
            const double Tuition = 10000;
            if (m_AcadPoints < 0 || m_AcadPoints > MaxPoints)
                return -1;
            double needToPay = (MaxPoints - m_AcadPoints) / MaxPoints * Tuition;
            return needToPay;
        }
    }
}

