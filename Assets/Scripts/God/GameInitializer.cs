using Domain.UseCase;
using VContainer.Unity;

namespace God
{
    public class GameInitializer : IInitializable
    {
        private readonly CardPoolUseCase _cardPoolUseCase;

        public GameInitializer(CardPoolUseCase cardPoolUseCase)
        {
            _cardPoolUseCase = cardPoolUseCase;
        }
        public void Initialize()
        {
            _cardPoolUseCase.Reset();
        }
    }
}