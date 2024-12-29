using System.Collections.Generic;
using CommonEntity;
using Domain.Entity;
using R3;

namespace Domain.UseCase
{
    public class ResetCardPoolUseCase
    {
        private readonly CardPoolEntity _cardPoolEntity;
        private readonly ICardPoolGateway _cardPoolGateway;

        public ResetCardPoolUseCase(CardPoolEntity cardPoolEntity, ICardPoolGateway cardPoolGateway)
        {
            _cardPoolEntity = cardPoolEntity;
            _cardPoolGateway = cardPoolGateway;
        }


        public void Reset() => _cardPoolEntity.Reset(_cardPoolGateway.GetCardPool());

        public Observable<IReadOnlyList<CardEntity>> ObserveReset() =>
            _cardPoolEntity.ObserveReset().Select(_ => _cardPoolEntity.CardList);
    }
}