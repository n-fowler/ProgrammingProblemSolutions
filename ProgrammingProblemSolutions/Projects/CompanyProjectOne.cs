#region Instructions
/*
 * You are tasked with writing an algorithm that determines the value of a used car, 
 * given several factors.
 * 
 *    AGE:    Given the number of months of how old the car is, reduce its value one-half 
 *            (0.5) percent.
 *            After 10 years, it's value cannot be reduced further by age. This is not 
 *            cumulative.
 *            
 *    MILES:    For every 1,000 miles on the car, reduce its value by one-fifth of a
 *              percent (0.2). Do not consider remaining miles. After 150,000 miles, it's 
 *              value cannot be reduced further by miles.
 *            
 *    PREVIOUS OWNER:    If the car has had more than 2 previous owners, reduce its value 
 *                       by twenty-five (25) percent. If the car has had no previous  
 *                       owners, add ten (10) percent of the FINAL car value at the end.
 *                    
 *    COLLISION:        For every reported collision the car has been in, remove two (2) 
 *                      percent of it's value up to five (5) collisions.
 *                    
 * 
 *    Each factor should be off of the result of the previous value in the order of
 *        1. AGE
 *        2. MILES
 *        3. PREVIOUS OWNER
 *        4. COLLISION
 *        
 *    E.g., Start with the current value of the car, then adjust for age, take that  
 *    result then adjust for miles, then collision, and finally previous owner. 
 *    Note that if previous owner, had a positive effect, then it should be applied 
 *    AFTER step 4. If a negative effect, then BEFORE step 4.
 */
#endregion

using NUnit.Framework;
using System;

namespace CarPricer
{
    public class Car
    {
        public decimal PurchaseValue { get; set; }
        public int AgeInMonths { get; set; }
        public int NumberOfMiles { get; set; }
        public int NumberOfPreviousOwners { get; set; }
        public int NumberOfCollisions { get; set; }
    }

    public class PriceDeterminator
    {
        private const int MAX_AGE_DEPRECIATION_MONTHS = 120;
        private const int MAX_MILEAGE_DEPRECIATION_MILES = 150000;
        private const int MIN_PREVIOUSOWNER_DEPRECIATION_TRIGGER = 2;
        private const int MAX_COLLISION_DEPRECIATION_COUNT = 5;
        private const decimal AGE_DEPRECIATION_PERCENTAGE = 0.005m;
        private const decimal MILEAGE_DEPRECIATION_PERCENTAGE = 0.002m;
        private const decimal NO_PREVIOUS_OWNER_APPRECIATION_PERCENTAGE = 0.10m;
        private const decimal PREVIOUS_OWNER_DEPRECIATION_PERCENTAGE = 0.25m;
        private const decimal COLLISION_DEPRECIATION_PERCENTAGE = 0.02m;


        public decimal DetermineCarPrice(Car car)
        {
            decimal currentCarPrice = car.PurchaseValue;

            CalculateAgeBasedDepreciation(ref currentCarPrice, car.AgeInMonths);
            CalculateMileageBasedDepreciation(ref currentCarPrice, car.NumberOfMiles);

            if (car.NumberOfPreviousOwners > MIN_PREVIOUSOWNER_DEPRECIATION_TRIGGER)
            {
                CalculateOwnershipBasedDepreciation(ref currentCarPrice, car.NumberOfPreviousOwners);
                CalculateCollisionBasedDepreciation(ref currentCarPrice, car.NumberOfCollisions);
            }
            else
            {
                CalculateCollisionBasedDepreciation(ref currentCarPrice, car.NumberOfCollisions);
                CalculateOwnershipBasedDepreciation(ref currentCarPrice, car.NumberOfPreviousOwners);
            }

            return currentCarPrice;
        }

        private void CalculateAgeBasedDepreciation(ref decimal purchaseValue, int ageInMonths)
        {
            decimal ageDepreciationAmount;

            if (ageInMonths < MAX_AGE_DEPRECIATION_MONTHS)
            {
                ageDepreciationAmount = purchaseValue * (ageInMonths * AGE_DEPRECIATION_PERCENTAGE);
            }
            else
            {
                ageDepreciationAmount = purchaseValue * (MAX_AGE_DEPRECIATION_MONTHS * AGE_DEPRECIATION_PERCENTAGE);
            }

            purchaseValue -= ageDepreciationAmount;
        }

        private void CalculateMileageBasedDepreciation(ref decimal purchaseValue, int numberOfMiles)
        {
            decimal mileageDepreciationAmount;

            if (numberOfMiles < MAX_MILEAGE_DEPRECIATION_MILES)
            {
                mileageDepreciationAmount = purchaseValue * (Math.Floor((decimal)(numberOfMiles / 1000)) * MILEAGE_DEPRECIATION_PERCENTAGE);
            }
            else
            {
                mileageDepreciationAmount = purchaseValue * (Math.Floor((decimal)(MAX_MILEAGE_DEPRECIATION_MILES / 1000)) * MILEAGE_DEPRECIATION_PERCENTAGE);
            }

            purchaseValue -= mileageDepreciationAmount;
        }

        private void CalculateOwnershipBasedDepreciation(ref decimal purchaseValue, int numberOfOwners)
        {
            decimal ownershipValuationChangeAmount;

            if (numberOfOwners == 0)
            {
                ownershipValuationChangeAmount = purchaseValue * NO_PREVIOUS_OWNER_APPRECIATION_PERCENTAGE;
                purchaseValue += ownershipValuationChangeAmount;
            }

            if (numberOfOwners > MIN_PREVIOUSOWNER_DEPRECIATION_TRIGGER)
            {
                ownershipValuationChangeAmount = purchaseValue * PREVIOUS_OWNER_DEPRECIATION_PERCENTAGE;
                purchaseValue -= ownershipValuationChangeAmount;
            }
        }

        private void CalculateCollisionBasedDepreciation(ref decimal purchaseValue, int numberOfCollisions)
        {
            decimal collisionDepreciationAmount;

            if (numberOfCollisions < MAX_COLLISION_DEPRECIATION_COUNT)
            {
                collisionDepreciationAmount = purchaseValue * (numberOfCollisions * COLLISION_DEPRECIATION_PERCENTAGE);
            }
            else
            {
                collisionDepreciationAmount = purchaseValue * (MAX_COLLISION_DEPRECIATION_COUNT * COLLISION_DEPRECIATION_PERCENTAGE);
            }

            purchaseValue -= collisionDepreciationAmount;
        }
    }

    [TestFixture]
    public class UnitTests
    {
        [TestCase]
        public void CalculateCarValue()
        {
            AssertCarValue(25313.40m, 35000m, 3 * 12, 50000, 1, 1);
            AssertCarValue(19688.20m, 35000m, 3 * 12, 150000, 1, 1);
            AssertCarValue(19688.20m, 35000m, 3 * 12, 250000, 1, 1);
            AssertCarValue(20090.00m, 35000m, 3 * 12, 250000, 1, 0);
            AssertCarValue(21657.02m, 35000m, 3 * 12, 250000, 0, 1);
        }

        private static void AssertCarValue(decimal expectValue, decimal purchaseValue,
            int ageInMonths, int numberOfMiles, int numberOfPreviousOwners, int
                numberOfCollisions)
        {
            Car car = new Car
            {
                AgeInMonths = ageInMonths,
                NumberOfCollisions = numberOfCollisions,
                NumberOfMiles = numberOfMiles,
                NumberOfPreviousOwners = numberOfPreviousOwners,
                PurchaseValue = purchaseValue
            };
            PriceDeterminator priceDeterminator = new PriceDeterminator();
            decimal carPrice = priceDeterminator.DetermineCarPrice(car);
            Assert.AreEqual(expectValue, carPrice);
        }
    }
}