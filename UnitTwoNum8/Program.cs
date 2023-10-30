using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTwoNum8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creation of objects of children classes
           Step legs = new Step();
           SwayArms arms = new SwayArms();
            MyMethod(legs);
            MyMethod(arms);
        }

        static void MyMethod(object obj)
        {
            ((Walk)obj).StartWalk();
            ((Walk)obj).StopWalk();
            if (obj.GetType() == typeof(Step))
            {
                ((WalkInterface)obj).RightFootUp();
            }
            else if (obj.GetType() == typeof(SwayArms))
            {
                ((ArmInterface)obj).LeftArmInFront();
            }
        }
    }

    public abstract class Walk
    {
        private string startLocation;
        private string destination;
        private string currentLocation;

        public string Destination
        {
            get;
            set;
            
            
        }

        public abstract void StartWalk();
        public abstract void StopWalk();
        
    }

    


    //controls how the feet will hit the ground
    public interface WalkInterface
    {
        void RightFootUp();
        void LeftFootUp();
    }

    //controls how the arms will move
    public interface ArmInterface
    {
        void RightArmInFront();
        void LeftArmInFront();
    }

    public class Step : Walk, WalkInterface
    {
        private bool rightFootUp;
        private bool leftFootUp;

        void WalkInterface.RightFootUp()
        {
            rightFootUp = true;
        }

        void WalkInterface.LeftFootUp()
        {
            leftFootUp = true;
        }

        public override void StartWalk()
        {

        }

        public override void StopWalk()
        {

        }
    }

    public class SwayArms :  Walk , ArmInterface
    {
        private bool rightArmInFront;
        private bool leftArmInFront;

        void ArmInterface.RightArmInFront()
        {
            rightArmInFront = true;
        }

        void ArmInterface.LeftArmInFront()
        {
            leftArmInFront = true;
        }

        public override void StartWalk()
        {
            
        }

        public override void StopWalk()
        {
            
        }
    }

    
}
