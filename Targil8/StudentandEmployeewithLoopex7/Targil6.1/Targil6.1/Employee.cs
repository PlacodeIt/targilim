using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Targil6_1
{
    class Employee
    {   
        private string m_ID;
        private string m_FName;
        private string m_LName;
        private int m_Vetek;
        private string m_Hascala;
        
  
        public Employee(string FName,string LName,string ID,string hascala,int vetek)
        {
            m_FName=FName;
            m_Hascala=hascala;
            m_ID = ID;
            m_LName = LName;
            m_Vetek = vetek;

        }
        public void Set_Vetek(int Vetek)
        {
            m_Vetek = Vetek;
        }
        public void Set_Hascala(string Hascala)
        {
            m_Hascala = Hascala;
        }
        public int Get_Vetek()
        {
            return m_Vetek;
        }
        public string Get_Hascala()
        {
            return m_Hascala;
        }

        public string Get_ID()
        {
            return m_ID;
        }
        public string GetName()
        {
            return m_FName + " " + m_LName;
        }
        
        public int calculate()
        {
            int salary = 0;
            if (m_Vetek > 30 || m_Vetek < 0)
               Console.WriteLine("Wrong vetek");
            m_Hascala = m_Hascala.ToUpper();
            switch (m_Vetek)
            {
                case 0:
                case 1:
                case 2: salary = 1000;
                    break;
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:switch (m_Hascala)
                    {
                        case "A": salary = 2100; break; 
                        case "B": salary = 2200;break;
                        case "C": salary = 2300; break;
                        case "D": salary = 2400; break;
                        default:Console.WriteLine("wrong education");
                            break;
                    }
                    break;
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20: switch (m_Hascala)
                    {
                        case "A": salary = 3200; break;
                        case "B": salary = 3400; break;
                        case "C": salary = 3600; break;
                        case "D": salary = 3800; break;
                        default: Console.WriteLine("wrong education"); break;
                    }
                    break;
                case 21: salary = 5000; break;
                default: if (m_Vetek>21 && m_Vetek<31)
                            salary = 5000; break;
            }
            return salary;
        }

       
    }
}
