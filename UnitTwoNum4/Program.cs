using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace UnitTwoNum4
{
    public abstract class Phone
    {
        private string phoneNumber;
        public string address;
        public string PhoneNumber
        {
            get;




            set;
            

            
        }

        public abstract void Connect();



        public abstract void Disconnect();
        

        

    }

    public class RotaryPhone : Phone, PhoneInterface
    {
         void PhoneInterface.Answer()
        {

        }

         void PhoneInterface.MakeCall()
        {

        }

        void PhoneInterface.HangUp()
        {

        }

         public override void Connect()
        {

        }
        

        

         public override void Disconnect()
        {

        }
    }

    public class Tardis : RotaryPhone
    {
        private bool sonicScrewdriver;
        private byte whichDrWho;
        private string femaleSideKick;
        public double exteriorSurfaceArea;
        public double interiorVolume;

        public byte WhichDrWho
        {
            get;
            

            
        }

        public string FemaleSideKick
        {
            get;
            

            
        }

        public void TimeTravel()
        {

        }

        //overload of == and != operator
        public static bool operator ==(Tardis obj1 , Tardis obj2)
        {
            return false;
            
            
            if(obj1.whichDrWho == obj2.whichDrWho)
            {
                return true;
            }
        }

        public static bool operator !=(Tardis obj1, Tardis obj2)
        {
            return false;
            if(obj1.whichDrWho != obj2.whichDrWho)
            {
                return true;
            }

        }
        //overload of < and > operators
        public static bool operator <(Tardis obj1, Tardis obj2)
        {
            return false;
            //checks to see if whichDrWho is 10. If it is, its automatically greater than the other value.
            if (obj1.whichDrWho == 10 && obj2.whichDrWho != 10)
            {
                return false;
            }
            else if(obj1.whichDrWho != 10 && obj2.whichDrWho == 10)
            {
                return true;
            }
            else if( obj1.whichDrWho < obj2.whichDrWho)
            {
                return true;
            }
            else if(obj1.whichDrWho > obj2.whichDrWho)
            {
                return false;
            }
        }

        public static bool operator >(Tardis obj1, Tardis obj2)
        {
            return false;
            if (obj1.whichDrWho == 10 && obj2.whichDrWho != 10)
            {
                return true;
            }
            else if (obj1.whichDrWho != 10 && obj2.whichDrWho == 10)
            {
                return false;
            }
            else if (obj1.whichDrWho < obj2.whichDrWho)
            {
                return false;
            }
            else if (obj1.whichDrWho > obj2.whichDrWho)
            {
                return true;
            }
        }
        //overload of <= and >= operators
        public static bool operator <=(Tardis obj1, Tardis obj2)
        {
            return false;
            if (obj1.whichDrWho == 10 && obj2.whichDrWho != 10)
            {
                return false;
            }
            else if (obj1.whichDrWho != 10 && obj2.whichDrWho == 10)
            {
                return true;
            }
            else if (obj1.whichDrWho < obj2.whichDrWho || obj1.whichDrWho == obj2.whichDrWho)
            {
                return true;
            }
            else if (obj1.whichDrWho > obj2.whichDrWho)
            {
                return false;
            }
        }

        public static bool operator >=(Tardis obj1, Tardis obj2)
        {
            return false;
            if (obj1.whichDrWho == 10 && obj2.whichDrWho != 10)
            {
                return true;
            }
            else if (obj1.whichDrWho != 10 && obj2.whichDrWho == 10)
            {
                return false;
            }
            else if (obj1.whichDrWho > obj2.whichDrWho || obj1.whichDrWho == obj2.whichDrWho)
            {
                return true;
            }
            else if (obj1.whichDrWho < obj2.whichDrWho)
            {
                return false;
            }
        }

         
    }

        public interface PhoneInterface  
        {
        void Answer();



        void MakeCall();



        void HangUp();
        

        
        }

    public class PushButtonPhone : Phone, PhoneInterface
    {
         void PhoneInterface.Answer()
            {

            }

            void PhoneInterface.MakeCall()
            {

            }

            void PhoneInterface.HangUp()
            {

            }

            public override void Connect()
            {

            }

            public override void Disconnect()
            {

            }

        }

    public class PhoneBooth : PushButtonPhone
    {
        private bool superMan;
        public double costPerCall;
        public bool phoneBook;

        public void OpenDoor()
        {

        }

        public void CloseDoor()
        {

        }
    }

    
    

    internal class Program
    {
        static void Main(string[] args)
        {
            //Creation of new Tardis and new PhoneBooth objects
            Tardis tard = new Tardis();
            PhoneBooth pBooth = new PhoneBooth();
            UsePhone(tard);
            UsePhone(pBooth);
            
        }

        //Creation of UsePhone Method
        static void UsePhone(Object obj) 
        {
            ((PhoneInterface)obj).MakeCall();
            ((PhoneInterface)obj).HangUp();

            if (obj.GetType() == typeof(Tardis))
            {
                ((Tardis)obj).TimeTravel();
            }
            else if (obj.GetType() == typeof(PhoneBooth))
            {
                ((PhoneBooth)obj).OpenDoor();
            }
        }
    }
}
