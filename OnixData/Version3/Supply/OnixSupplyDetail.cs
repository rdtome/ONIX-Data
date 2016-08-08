﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OnixData.Version3.Price;

namespace OnixData.Version3.Supply
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OnixSupplyDetail
    {
        public OnixSupplyDetail()
        {
            ProductAvailability = "";
            PackQuantity        = -1;

            Price             = new OnixPrice[0];
            Supplier          = new OnixSupplier[0];
            ReturnsConditions = new OnixReturnsConditions[0];
        }

        private OnixSupplier[]          supplierField;
        private OnixReturnsConditions[] returnsConditionsField;
        private string                  productAvailabilityField;
        private int                     packQuantityField;
        private OnixPrice[]             priceField;

        #region Reference Tags

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Supplier", IsNullable = false)]
        public OnixSupplier[] Supplier
        {
            get
            {
                return this.supplierField;
            }
            set
            {
                this.supplierField = value;
            }
        }

        /// <remarks/>
        public string ProductAvailability
        {
            get
            {
                return this.productAvailabilityField;
            }
            set
            {
                this.productAvailabilityField = value;
            }
        }

        /// <remarks/>
        public int PackQuantity
        {
            get
            {
                return this.packQuantityField;
            }
            set
            {
                this.packQuantityField = value;
            }
        }        

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Price", IsNullable = false)]
        public OnixPrice[] Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReturnsConditions", IsNullable = false)]
        public OnixReturnsConditions[] ReturnsConditions
        {
            get
            {
                return this.returnsConditionsField;
            }
            set
            {
                this.returnsConditionsField = value;
            }
        }

        #endregion

        #region Short Tags

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("supplier", IsNullable = false)]
        public OnixSupplier[] supplier
        {
            get { return Supplier; }
            set { Supplier = value; }
        }

        /// <remarks/>
        public string j396
        {
            get { return ProductAvailability; }
            set { ProductAvailability = value; }
        }

        /// <remarks/>
        public int j145
        {
            get { return PackQuantity; }
            set { PackQuantity = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("price", IsNullable = false)]
        public OnixPrice[] price
        {
            get { return Price; }
            set { Price = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("returnsconditions", IsNullable = false)]
        public OnixReturnsConditions[] returnsconditions
        {
            get { return ReturnsConditions; }
            set { ReturnsConditions = value; }
        }        

        #endregion
    }
}
