using System.Collections.Generic;
using System.Linq;
using Adapter.Gateway;
using CommonEntity;
using UnityEngine;

namespace Detail.DB
{
    [CreateAssetMenu(menuName = "Create CardPoolDatabase", fileName = "CardPoolDatabase", order = 0)]
    public class CardPoolDatabase : ScriptableObject, ICardDatabase
    {
        [SerializeField] private List<CardData> cardData;


        public IReadOnlyList<CardEntity> GetCardList()
        {
            return cardData.Select(value => new CardEntity(value.cardKey)).ToList();
        }
    }
}