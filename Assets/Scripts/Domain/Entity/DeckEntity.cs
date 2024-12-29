using System.Collections.Generic;
using CommonEntity;
using ObservableCollections;
using R3;

namespace Domain.Entity
{
    public class DeckEntity
    {
        private readonly ObservableList<CardEntity> _cardEntities = new();

        public Observable<CardEntity> ObserveAdd() => _cardEntities
            .ObserveAdd().Select(value => value.Value);

        public Observable<CardEntity> ObserveRemove() => _cardEntities
            .ObserveRemove().Select(value => value.Value);

        public void Add(CardEntity cardEntity)
        {
            _cardEntities.Add(cardEntity);
        }

        public void Remove(CardEntity cardEntity)
        {
            _cardEntities.Remove(cardEntity);
        }

        private readonly Subject<IEnumerable<CardEntity>> _onReset = new();

        public Observable<IEnumerable<CardEntity>> OnReset => _onReset;

        public void Reset(IEnumerable<CardEntity> deck)
        {
            _cardEntities.Clear();
            _cardEntities.AddRange(deck);
            _onReset.OnNext(_cardEntities);
        }

        private readonly ReactiveProperty<CardEntity> _currentFocusedCard = new();

        public CardEntity CurrentFocusedCard
        {
            get => _currentFocusedCard.Value;
            set => _currentFocusedCard.Value = value;
        }

        public Observable<CardEntity> ObserveCurrentFocusedCard() => _currentFocusedCard;
    }
}