using System;

namespace Skat
{
    public class Afgift
    {
        // En fejlbesked man får hvis 
        public const string CarPriceIsMinusOrNull = "Bilafgiften kan ikke beregnes, da værdien er enten nul eller minus. Indsæt et positiv tal.";

        /// <summary>
        /// Metoden beregner afgiften på en almindelig bil. Metoden tager parameterværdien pris
        /// og udregne afgiften ved hjælp af formlerne:
        ///      (pris x 0.85) for biler med værdi under 200.000 kr.
        ///      ((pris X 0.85)-130.000) for biler med værdi over 200.000 kr.
        /// Returværdien er afgiften på bilen som en int.
        /// </summary>
        /// <param name="pris"></param>
        /// <returns></returns>
        /// 
        public static int BilAfgift(int pris)
        {
            if (pris >= 0)
            {
                double result = 0;
                if (pris <= 200000)
                {
                    result = (pris * 0.85);
                }

                if (pris > 200000)
                {
                    result = (pris * 1.5) - 130000;
                }
                return Convert.ToInt32(result);
            }
            throw new System.ArgumentOutOfRangeException("pris", pris, CarPriceIsMinusOrNull);

        }
        /// <summary>
        /// Metoden beregner afgiften på en elektrisk bil. Metoden tager parameterværdien pris
        /// og udregne afgiften ved hjælp af formlen:
        ///      (BilAfgift * 0.2)
        /// Returværdien er afgiften på elbilen som en int.
        /// </summary>
        /// <param name="pris"></param>
        /// <returns></returns>
        public static int ElBilAfgift(int pris)
        {
            return Convert.ToInt32(BilAfgift(pris) * 0.2);

        }

    }
}
