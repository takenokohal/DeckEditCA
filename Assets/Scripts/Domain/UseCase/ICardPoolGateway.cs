using System.Collections.Generic;
using CommonEntity;

namespace Domain.UseCase
{
    public interface ICardPoolGateway
    {
        public IReadOnlyList<CardEntity> GetCardPool();
    }
}