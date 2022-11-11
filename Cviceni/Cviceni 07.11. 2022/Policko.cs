using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Cviceni_07._11._2022.Enums;
using Cviceni_07._11._2022.Policka;

namespace Cviceni_07._11._2022
{
    class Policko
    {
        #region Vlastnosti
        private Karkulka karkulka = null;

        private Typ typ;
        #endregion
        
        #region Gettery a settery
        public Typ Typ
        {
            get => typ;
            set{
                typ = value;
            }
        }

        public Karkulka Karkulka
        {
            get => karkulka;
            set
            {
                karkulka = value;
            }

        }

        #endregion

        #region Konstruktory
        public Policko(Typ typ)
        {
            Typ = typ;
        }

        #endregion

        #region Metody


        public virtual void SplnUcel()
        {
            
        }

        public override string ToString()
        {
            return " ";
        }


        #endregion
    }
}
