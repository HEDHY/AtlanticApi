using Atlantico.Business.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business2
{
    public class CardsService
    {
        public List<CardDDO> GetUserCards(string clientId)
        {
            return GetAllCards().Where(card => card.ClientId.Contains(clientId)).ToList();
        }


        public List<CardDDO> GetMaskedUserCards(string clientId)
        {
            var cardList = GetCardsFromBd().Where(card => card.IsValid()).ToList();

            foreach(var card in cardList)
            {
                card.PhoneNumber = MaskPhoneNumber(card.PhoneNumber);
            }
            return cardList;
        }

        /// <summary>
        /// Este metodo recebe uma string e aplica uma mascara, substitui todos os caracteres por X excepto os 2 primeiros e os ultimos 2.
        /// Exemplo: 911111121 -> 91XXXXX21
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        private string MaskPhoneNumber(string phone)
        {
            //TODO
            return "";
        }

        private List<CardDDO> GetAllCards()
        {
            var cardList = GetCardsFromBd();
            return cardList.Where(card => card.IsValid()).ToList();
        }


        /// <summary>
        /// Este metodo simula a ida à BD ou serviço externo para obter os cartões
        /// </summary>
        /// <returns></returns>
        private List<CardDDO> GetCardsFromBd()
        {
            var cardList = new List<CardDDO>();
            cardList.Add(new CardDDO { Pan = "89183888111", Name = "JOAO SAMPAIO", ClientId = "1234578", Type = CardType.DEBIT, PhoneNumber = "911111121" });
            cardList.Add(new CardDDO { Pan = "87563888111", Name = "JORGE MENDES", ClientId = "37436556", Type = CardType.DEBIT, PhoneNumber = "911155121" });
            cardList.Add(new CardDDO { Pan = "12183888111", Name = "RUI SIMOES", ClientId = "8677", Type = CardType.DEBIT, PhoneNumber = "911111121" });
            cardList.Add(new CardDDO { Pan = "43183888111", Name = "PEDRO TOMAS", ClientId = "1285467345", Type = CardType.DEBIT, PhoneNumber = "966111121" });
            cardList.Add(new CardDDO { Pan = "53183888111", Name = "JOANA SEQUEIRA", ClientId = "75435", Type = CardType.CREDIT, PhoneNumber = "" });
            cardList.Add(new CardDDO { Pan = "2683888112", Name = "MARCO SAMPAIO", ClientId = "1234", Type = CardType.DEBIT, PhoneNumber = "2537121" });
            cardList.Add(new CardDDO { Pan = "2683888113", Name = "SOFIA CARVALHO", ClientId = "5544", Type = CardType.CREDIT });
            cardList.Add(new CardDDO { Pan = "2683888114", Name = "MARCO CARVALHO", ClientId = "5545", Type = CardType.CREDIT, PhoneNumber = "911111121" });
            cardList.Add(new CardDDO { Pan = "5483888111", Name = "RUI SANTOS", ClientId = "8888", Type = CardType.DEBIT });
            cardList.Add(new CardDDO { Pan = "6563888111", Name = "RONALDO MENDES", ClientId = "463367", Type = CardType.DEBIT, PhoneNumber = "81521" });
            return cardList;
        }



    }
}
