using Domain.UseCase;
using R3;
using VContainer.Unity;

namespace Adapter.Presenter
{
    public class DeckCurrentFocusedCardPresenter : IInitializable
    {
        private readonly IDeckCurrentFocusedView _deckCurrentFocusedView;
        private readonly DeckCurrentFocusedCardUseCase _deckCurrentFocusedCardUseCase;

        public DeckCurrentFocusedCardPresenter(IDeckCurrentFocusedView deckCurrentFocusedView,
            DeckCurrentFocusedCardUseCase deckCurrentFocusedCardUseCase)
        {
            _deckCurrentFocusedView = deckCurrentFocusedView;
            _deckCurrentFocusedCardUseCase = deckCurrentFocusedCardUseCase;
        }

        public void Initialize()
        {
            _deckCurrentFocusedCardUseCase.Observe().Subscribe(value => _deckCurrentFocusedView.OnSet(value));
        }
    }
}