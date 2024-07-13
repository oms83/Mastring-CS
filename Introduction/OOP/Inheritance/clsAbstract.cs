using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.OOP.Inheritance
{
    /*
                         ABSTRACT CLASS

        1- we cannot create object from abstract class.
        2- abstract class contains abstract memebers.


                        SEALED CLASS

        1- cannot be inherited

        
                        POLYMORPHISM

        virtual => تستخدم مع المثود في كلاس الاب لجعلها قابلة لتعديل في كلاس ابن او بما يعرف بالاوفررايد
        'function1' : cannot override inherited member 'function2' because it is not marked "virtual", "abstract", or "override"

        virtual + override = polymorphism

        لا تشترط أن تكون في كلاس أبستركت

        
                        Abstract Memeber

        abstract member => تشترط أن تكون في كلاس أبستركت ولا يحتوي على تطبيق خاص فيه تطبيقها يكون في كلاس الذي وارثها
                        => أي كلاس يرث كلاس الابستركت يشترح عليهم بأن يتطبقوا كل المثود الابستراكت الموجودة في الكلاس الاب
    
        sealed memeber => لا يمكن تجاوز العضو المختوف في الكلاس المشتق
                       => أي انا المثود اللي معمولة اوفررايد في كلاس الابن لو عرفنها كسيلد فكلاس الحفيد ما بيقدر يطبقها عنده
                       => وبياخد خطأ وهي مشابهة لمبدأ كلاس السيلد

        

    */
    abstract public class clsAnimal
    {
        public virtual void moving()
        {
            Console.WriteLine("moving");
        }

        public abstract void Moving();

        public void print()
        {

        }
    }


    //sealed public class clsEagle : clsAnimal
    public class clsEagle : clsAnimal
    {
        public void flying()
        {
            Console.WriteLine("the eagle");
        }

        public override void moving()
        {
            base.moving();
            Console.WriteLine("the eagle");
        }

        //public sealed override void Moving() this member prevent this method override the main class method 
        public override void Moving()
        {

        }
    }

    //public class AmericanEagle : clsEagle =====> cannot be inherited
    public class AmericanEagle : clsEagle
    {
        public override void Moving()
        {
            base.Moving();
        }
    }

    public class clsAbstract
    {
        public static void run()
        {
            //clsAnimal a = new clsAnimal(); error

            clsEagle eagle = new clsEagle();
            eagle.moving();
        }
    }
}
