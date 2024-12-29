using CommonEntity;
using Domain.Entity;
using R3;

namespace Domain.UseCase
{
    public class AddUseCase
    {
        private readonly DeckEntity _deckEntity;

        public AddUseCase(DeckEntity deckEntity)
        {
            _deckEntity = deckEntity;
        }
        public void Add(CardEntity cardEntity) => _deckEntity.Add(cardEntity);
        public Observable<CardEntity> ObserveAdd() => _deckEntity.ObserveAdd();
    }
}