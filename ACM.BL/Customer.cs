using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        //Adding email address property using snippets
        //Right Click > Snippet > Insert Snippet

        //propg
        public int CustomerID { get; private set; }

        //prop
        public string EmailAddress { get; set; }

        //Shortcut syntax
        public string FirstName{get; set;}

        //Property Full name that will return the format
        //required by the specification 
        public string FullName
        {
            get
            {
                //Si solo se define el LastName el fullName es el LastName sin comas
                string fullName = LastName;
                //Si solo hay FirstName, el FullName es inicialmente nulo 
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        //Pero si existen los dos, empezamos con el LastName y una coma y un espacio
                        fullName += ", ";
                    }
                    //Entonces establecemos el fullName como el FirstName
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        //Agregamos una propiedad auto implementada utilizando un snippet
        //Escribir prop -> Tab Tab 
        //Queremos compartirlo con todas las instancias objeto y por eso se agrega el "static modifier"
        public static int InstanceCount { get; set; }

        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
    }
}
