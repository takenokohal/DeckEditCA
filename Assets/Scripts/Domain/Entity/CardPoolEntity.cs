using System.Collections.Generic;
using CommonEntity;
using R3;

namespace Domain.Entity
{
    public class CardPoolEntity
    {
        private List<CardEntity> _cardList;
        public IReadOnlyList<CardEntity> CardList => _cardList;

        public void Reset(IEnumerable<CardEntity> cardEntities)
        {
            _cardList = new List<CardEntity>(cardEntities);
            _onReset.OnNext(Unit.Default);
        }

        private readonly Subject<Unit> _onReset = new();
        public Observable<Unit> ObserveReset() => _onReset;
    }
}