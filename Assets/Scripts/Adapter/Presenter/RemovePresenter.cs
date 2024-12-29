using Domain.UseCase;
using R3;
using VContainer.Unity;

namespace Adapter.Presenter
{
    public class RemovePresenter : IInitializable
    {
        private readonly RemoveUseCase _removeUseCase;
        private readonly IRemoveView _removeView;

        public RemovePresenter(RemoveUseCase removeUseCase, IRemoveView removeView)
        {
            _removeUseCase = removeUseCase;
            _removeView = removeView;
        }

        public void Initialize()
        {
            _removeUseCase.ObserveRemove().Subscribe(value => _removeView.OnRemove(value));
        }
    }
}