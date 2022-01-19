using System;
using System.Collections.Generic;
using System.Text;

namespace PR_3._2_Surgai
{
    class Apartment : Property
    {
        private uint maxNumberOfInhabitants;

        Apartment(decimal _price, String _propertyAddress, State _propertyStatus, Owner _owner, uint _square, DateTime _changeDate, uint _maxNumberOfInhabitants)
                  : base(_price, _propertyAddress, _propertyStatus, _owner, _square, _changeDate)
        {
            this.maxNumberOfInhabitants = _maxNumberOfInhabitants;
        }

        public decimal getCostPerSquareMeter()
        {
            return getPrice() / getSquare();
        }

    }
}
