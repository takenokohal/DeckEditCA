using CommonEntity;
using Domain.UseCase;

namespace Adapter.Controller
{
    public class RemoveController
    {
        private readonly RemoveUseCase _removeUseCase;

        public RemoveController(RemoveUseCase removeUseCase)
        {
            _removeUseCase = removeUseCase;
        }

        public void Remove(CardEntity cardEntity)
        {
            _removeUseCase.Remove(cardEntity);
        }
    }
}