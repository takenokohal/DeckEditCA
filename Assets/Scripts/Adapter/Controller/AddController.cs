using CommonEntity;
using Domain.UseCase;

namespace Adapter.Controller
{
    public class AddController
    {
        private readonly AddUseCase _addUseCase;

        public AddController(AddUseCase addUseCase)
        {
            _addUseCase = addUseCase;
        }

        public void Add(CardEntity cardEntity) => _addUseCase.Add(cardEntity);
    }
}