using Domain.UseCase;
using VContainer.Unity;

namespace God
{
    public class GameInitializer : IInitializable
    {
        private readonly ResetCardPoolUseCase _resetCardPoolUseCase;

        public GameInitializer(ResetCardPoolUseCase resetCardPoolUseCase)
        {
            _resetCardPoolUseCase = resetCardPoolUseCase;
        }
        public void Initialize()
        {
            _resetCardPoolUseCase.Reset();
        }
    }
}