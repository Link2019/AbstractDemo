using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类的学习
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.抽象类不能被实例化
            //Animal a1 = new Animal();

            /*6
            Animal cat = new Cat();
            cat.Bark();
            cat.Same();
            Animal dog = new Dog();
            dog.Bark();
            dog.Same();
            Console.ReadKey();
            */
        }
        /*
        public abstract class Animal
        {
            //1.抽象成员必须标记为abstract,并且不能有任何实现。
            public abstract void Bark();
           
        }
        */
        //2.抽象成员必须在抽象类中。
        /*
        public class T
        {
            public abstract void Bark();
        }
        */

        //4.子类继承抽象类后，必须把父类中的所有抽象成员都重写。
        /*
        public class Cat : Animal
        {
            public override void Bark()
            {
                throw new NotImplementedException();
            }
        }
        */

        //4/（除非子类也是一个抽象类，则可以不重写）
        /*
        public abstract class T2:Animal
        {

        }
        */

        /*
        public abstract class T3
        {
            //5.抽象成员的访问修饰符不能是private
            private abstract void Bark();
        }
        */
        //6.在抽象类中可以包含实例成员。并且抽象类的实例成员可以不被子类实现
        /*
        public abstract class Animal
        {
            public abstract void Bark();
            public virtual void Same()
            {
                Console.WriteLine("我有一条命");
            }
        }
        public class Cat : Animal
        {
            public override void Bark()
            {
                Console.WriteLine("狗狗汪汪叫");
            }
            public override void Same()
            {
                Console.WriteLine("据说我有九条命！");
            }

        }

        public class Dog:Animal
        {
            public override void Bark()
            {
                Console.WriteLine("猫猫喵喵叫");
            }
        }
        */

        //7.抽象类是有构造函数的。虽然不能被实例化。
        /*
        public abstract class Animal
        {
            Animal()
            {

            }
        }
        */

        /*
        public abstract class T
        {
            public abstract string Test(string a);
        }
        public class S : T
        {
            //8、如果父类的抽象方法中有参数，
            //那么。继承这个抽象父类的子类在重写父类的方法的时候必须传入对应的参数。
            //如果抽象父类的抽象方法中有返回值，那么子类在重写这个抽象方法的时候 也必须要传入返回值。
            public override string Test(string a)
            {
                throw new NotImplementedException();
            }
        }
        */

    }
}
