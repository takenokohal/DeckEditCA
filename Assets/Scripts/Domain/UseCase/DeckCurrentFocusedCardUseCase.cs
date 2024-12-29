using CommonEntity;
using Domain.Entity;
using R3;

namespace Domain.UseCase
{
    public class DeckCurrentFocusedCardUseCase
    {
        private readonly DeckEntity _deckEntity;

        public DeckCurrentFocusedCardUseCase(DeckEntity deckEntity)
        {
            _deckEntity = deckEntity;
        }

        public void Set(CardEntity cardEntity) => _deckEntity.CurrentFocusedCard = cardEntity;
        public CardEntity Get() => _deckEntity.CurrentFocusedCard;
        public Observable<CardEntity> Observe() => _deckEntity.ObserveCurrentFocusedCard();
    }
}