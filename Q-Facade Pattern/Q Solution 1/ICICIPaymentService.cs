﻿namespace Q_Solution_1
{
    public class ICICIPaymentService : IPaymentService
    {
        public bool pay(float amount, int cardno, int cvv)
        {
            return new System.Random().Next(5) > 5 ? true : false;
        }
    }
}