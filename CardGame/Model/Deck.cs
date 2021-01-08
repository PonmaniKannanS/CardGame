using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Model
{
    public class Deck
    {
        #region Fields
        private List<Card> m_Card;
        private List<Card> m_PlayedCard;

        private readonly string[] m_CardValues = 
        {
            "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"
        };

        private readonly string[] m_SuitValues = 
        {
            "Clubs", "Hearts", "Spades", "Diamond"
        };
        #endregion

        #region Cons
        public Deck()
        {
            m_PlayedCard = new List<Card>();
            m_Card = new List<Card>();

            foreach (var suit in m_SuitValues)
            {
                foreach (var cardValue in m_CardValues)
                {
                    m_Card.Add(new Card(cardValue, suit));
                }
            }
        }
        #endregion

        #region Public methods
        public string PlayACard()
        {
            string currentCardText = string.Empty;
            try
            {
                if (m_Card.Count == 0)
                {
                    return "Game over!!! Please restart the game.";
                }

                var currentCard = m_Card.FirstOrDefault();
                currentCardText = currentCard?.ToString();
                m_PlayedCard.Add(currentCard);
                m_Card.Remove(currentCard);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Null reference exception!!!");
            }
            catch 
            {
                Console.WriteLine("General exception!!!");
            }

            return currentCardText;
        }

        public void ShuffleDeck()
        {
            Random rnd = new Random();
            m_Card = m_Card.OrderBy<Card, int>((item) => rnd.Next(0, m_Card.Count)).ToList();
            Console.WriteLine("Deck shuffled!!!");
        }

        public void RestartGame()
        {
            Console.WriteLine("Game restarted!!!");
            m_Card.AddRange(m_PlayedCard);
        }
        #endregion
    }
}
