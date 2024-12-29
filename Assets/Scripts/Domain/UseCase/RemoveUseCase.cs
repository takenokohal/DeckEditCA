using CommonEntity;
using Domain.Entity;
using R3;

namespace Domain.UseCase
{
    public class RemoveUseCase
    {
        private readonly DeckEntity _deckEntity;

        public RemoveUseCase(DeckEntity deckEntity)
        {
            _deckEntity = deckEntity;
        }
        public void Remove(CardEntity cardEntity) => _deckEntity.Remove(cardEntity);

        public Observable<CardEntity> ObserveRemove() =>
            _deckEntity.ObserveRemove();
    }
}