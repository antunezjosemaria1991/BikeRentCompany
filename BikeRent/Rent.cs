using System;
using System.Collections.Generic;

namespace BikeRent
{
    public class Rent
    {
        public Rent(float amount, string desc, RentType type)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException("amount", "Can't be less or equal to 0");
            }

            if(String.IsNullOrWhiteSpace(desc))
            {
                throw new ArgumentNullException("desc", "Can't be null or empty");
            }

            Mode = type;
            Amount = amount;
            Description = desc;

            SubTotal = RentConst.baseCalc[type] * amount;
        }

        public string Description { private set; get; }

        public RentType Mode { private set; get; }

        public float Amount { private set; get; }

        public float SubTotal { private set; get; }
    }
    public enum RentType
    {
        Hour,
        Day,
        Week,
    }
    class RentConst
    {
        public static Dictionary<RentType, float> baseCalc = new Dictionary<RentType, float>()
        {
            { RentType.Hour, 5.0f },
            { RentType.Day, 20.0f },
            { RentType.Week, 60.0f },
        };
        
        public const float FamilyRental = 0.3f;
    }
}
