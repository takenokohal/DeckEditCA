using System.Collections.Generic;
using CommonEntity;

namespace Adapter.Gateway
{
    public interface ICardDatabase
    {
        public IReadOnlyList<CardEntity> GetCardList();
    }
}