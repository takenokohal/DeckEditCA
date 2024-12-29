using System.Collections.Generic;
using CommonEntity;
using Domain.UseCase;

namespace Adapter.Gateway
{
    public class CardPoolGateway : ICardPoolGateway
    {
        private readonly ICardDatabase _cardDatabase;

        public CardPoolGateway(ICardDatabase cardDatabase)
        {
            _cardDatabase = cardDatabase;
        }

        public IReadOnlyList<CardEntity> GetCardPool()
        {
            return _cardDatabase.GetCardList();
        }
    }
}