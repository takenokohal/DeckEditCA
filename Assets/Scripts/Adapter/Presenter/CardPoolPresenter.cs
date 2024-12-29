using Domain.UseCase;
using R3;
using VContainer.Unity;

namespace Adapter.Presenter
{
    public class CardPoolPresenter : IInitializable
    {
        private readonly ResetCardPoolUseCase _resetCardPoolUseCase;
        private readonly ICardPoolView _cardPoolView;

        public CardPoolPresenter(ResetCardPoolUseCase resetCardPoolUseCase, ICardPoolView cardPoolView)
        {
            _resetCardPoolUseCase = resetCardPoolUseCase;
            _cardPoolView = cardPoolView;
        }

        public void Initialize()
        {
            _resetCardPoolUseCase.ObserveReset().Subscribe(value => _cardPoolView.OnReset(value));
        }
    }
}