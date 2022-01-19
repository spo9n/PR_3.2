using System;
using System.Collections.Generic;
using System.Text;

namespace PR_3._2_Surgai
{
    class Property
    {
        private decimal price;
        private string propertyAddress;
        private State propertyStatus;
        private Owner owner;
        private DateTime changeDate;
        private uint square;

        public Property(decimal _price, String _propertyAddress, State _propertyStatus, Owner _owner, uint _square, DateTime _changeDate)
        {
            this.price = _price;
            this.propertyAddress = _propertyAddress;
            this.propertyStatus = _propertyStatus;
            this.owner = _owner;
            this.changeDate = _changeDate;
            this.square = _square;
        }

        public decimal getPrice()
        {
            return price;
        }

        public uint getSquare()
        {
            return square;
        }
    }

    enum State
    {
        Rented,
        NotRented
    }

}
