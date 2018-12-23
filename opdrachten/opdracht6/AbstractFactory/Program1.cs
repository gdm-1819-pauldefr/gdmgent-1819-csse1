using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GKies een figuur Cirkel/Vierkant/Rechthoek/Trapezium/Parrallelogram");
            string type = Console.ReadLine();
            Vorm obj = CreateVorm.getobject(type);
            Console.WriteLine(obj.Teken());
            Console.ReadLine();
        }
    }
    public class CreateVorm{
        public static Vorm getobject(string typeofobject){
            Vorm obj = null;
            if(typeofobject.ToLower()=="cirkel"){
                obj = new Cirkel();
            }else if (typeofobject.ToLower()=="vierkant"){
                obj = new Vierkant();
            }else if (typeofobject.ToLower()=="rechthoek"){   
                obj = new Rechthoek();
            }else if (typeofobject.ToLower()=="trapezium"){   
                obj = new Trapezium();
            }else{
                obj = new Parrallelogram();
            }
            return obj;
        }
    }
   public interface Vorm{
        string Teken();
    }

    class Cirkel: Vorm{
        public virtual string Teken(){
            return "Dit is een cirkel";
            
        }
    }
    class Vierkant: Vorm{
        public virtual string Teken(){
            return "Dit is een vierkant";
        }
    }
    class Rechthoek: Vorm{
        public virtual string Teken(){
            return "Dit is een rechthoek";
        }
    }
     class Trapezium: Vorm{
        public virtual string Teken(){
            return "Dit is een trapezium";
        }
    }
     class Parrallelogram: Vorm{
        public virtual string Teken(){
            return "Dit is een parrallelogram";
        }
    }
    
}