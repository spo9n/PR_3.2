using System;
using System.Collections.Generic;
using System.Text;

namespace PR_3._2_Surgai
{
    class RetailProperty : Property
    {
        private string purpose;

        public RetailProperty(decimal _price, String _propertyAddress, State _propertyStatus, Owner _owner, uint _square, DateTime _changeDate, string _purpose)
                  : base(_price, _propertyAddress, _propertyStatus, _owner, _square, _changeDate)
        {
            this.purpose = _purpose;
        }

        public decimal getCostPerSquareMeter()
        {
            return getPrice() / getSquare();
        }

    }
}
