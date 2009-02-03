using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DE2_UE_Fahrradkurier
{
    class ComboBoxItem
    {
        private int _key;
        public int Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        private string _value;
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }


        public ComboBoxItem(int key, string value)
        {
            this.Key = key;
            this.Value = value;
        }

        public override string ToString()
        {
            return this.Value;
        }
    }
}
