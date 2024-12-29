using Domain.UseCase;
using R3;
using VContainer.Unity;

namespace Adapter.Presenter
{
    public class AddPresenter : IInitializable
    {
        private readonly IAddView _addView;
        private readonly AddUseCase _addUseCase;

        public AddPresenter(IAddView addView, AddUseCase addUseCase)
        {
            _addView = addView;
            _addUseCase = addUseCase;
        }
        
        public void Initialize()
        {
            _addUseCase.ObserveAdd().Subscribe(value => _addView.OnAdd(value));
        }
    }
}