using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Model
{
    public class Card
    {
        #region Fields
        private string m_CardValue;
        private string m_SuitValue;
        #endregion

        #region Cons
        public Card(string value, string suit)
        {
            m_CardValue = value;
            m_SuitValue = suit;
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return "Card -> " + m_SuitValue + " " + m_CardValue;
        }
        #endregion
    }
}
