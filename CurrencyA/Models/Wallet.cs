using System;
namespace CurrencyA.Models
{
    public class Wallet
    {
       

        // Number of coins 

        public double OneDollarCoins { get; set; }

        public double FiftyCentCoins { get; set; }

        public double TenCentCoins { get; set; }

        public double FiveCentCoins { get; set; }




        public double Total { get; set; }


        //Returns the total value of the coins in the wallet

        public double TotalValue()
        {
            Total = OneDollarCoins + (0.5 * FiftyCentCoins) + (0.1 * TenCentCoins) + (0.05 * FiveCentCoins);
            return Total;
        }


        // $1 methods

        public void AddOneDollar()
        {
            OneDollarCoins += 1;
            
        

        }

        public void SubtractOneDollar()
        {
            
            OneDollarCoins -= 1;
            
        }

        public void OneDollarExchangedToFiftyCents()
        {
            OneDollarCoins -= 1;
            FiftyCentCoins += 2;

            TotalValue();

        }

       

        // 50 cent methods


        public void AddFiftyCents()
        {
            FiftyCentCoins += 1;
        }

        public void SubtractFiftyCents()
        {
            FiftyCentCoins -= 1;
        }

        public void FiftyCentsExchangedToOneDollar()
        {
            FiftyCentCoins -= 2;
            OneDollarCoins += 1;

            TotalValue();
        }

        public void FiftyCentsExchangedToTenCents()
        {
            FiftyCentCoins -= 1;
            TenCentCoins += 5;

            TotalValue();
        }



        // 10 cent methods


        public void AddTenCents()
        {
            TenCentCoins += 1;

        }

        public void SubtractTenCents()
        {
            TenCentCoins -= 1;
        }

        public void TenCentsExchangedToFiftyCents()
        {
            TenCentCoins -= 5;
            FiftyCentCoins += 1;

            TotalValue();
        }

        public void TenCentsExchangedToFiveCents()
        {
            TenCentCoins -= 1;
            FiveCentCoins += 2;

            TotalValue();
        }


        // 5 cent methods


        public void AddFiveCents()
        {
            FiveCentCoins += 1;
        }

        public void SubtractFiveCents()
        {
            FiveCentCoins -= 1;
        }

        public void FiveCentsExchangedToTenCents()
        {
            FiveCentCoins -= 2;
            TenCentCoins += 1;

            TotalValue();
        }

        

    }
}
