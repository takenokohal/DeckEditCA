using Domain.UseCase;
using R3;
using VContainer.Unity;

namespace Adapter.Presenter
{
    public class CardPoolPresenter : IInitializable
    {
        private readonly CardPoolUseCase _cardPoolUseCase;
        private readonly ICardPoolView _cardPoolView;

        public CardPoolPresenter(CardPoolUseCase cardPoolUseCase, ICardPoolView cardPoolView)
        {
            _cardPoolUseCase = cardPoolUseCase;
            _cardPoolView = cardPoolView;
        }

        public void Initialize()
        {
            _cardPoolUseCase.ObserveReset().Subscribe(value => _cardPoolView.OnReset(value));
        }
    }
}