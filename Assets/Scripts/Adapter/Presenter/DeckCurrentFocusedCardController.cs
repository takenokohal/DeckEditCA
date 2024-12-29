using Domain.UseCase;

namespace Adapter.Presenter
{
    public class DeckCurrentFocusedCardController
    {
        private readonly DeckCurrentFocusedCardUseCase _deckCurrentFocusedCardUseCase;

        public DeckCurrentFocusedCardController(DeckCurrentFocusedCardUseCase deckCurrentFocusedCardUseCase)
        {
            _deckCurrentFocusedCardUseCase = deckCurrentFocusedCardUseCase;
        }
    }
}