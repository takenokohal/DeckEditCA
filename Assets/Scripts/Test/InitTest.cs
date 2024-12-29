using Adapter.Presenter;
using CommonEntity;
using Domain.Entity;
using Domain.UseCase;
using VContainer.Unity;

namespace Test
{
    public class InitTest : IInitializable
    {
        private readonly AddController _addPresenter;

        public InitTest(AddController addPresenter)
        {
            _addPresenter = addPresenter;
        }

        public void Initialize()
        {
            for (int i = 0; i < 5; i++)
            {
                _addPresenter.Add(new CardEntity("aaaaa" + i));
            }
        }
    }
}