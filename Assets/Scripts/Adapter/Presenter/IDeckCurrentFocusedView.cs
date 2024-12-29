using CommonEntity;

namespace Adapter.Presenter
{
    public interface IDeckCurrentFocusedView
    {
        public void OnSet(CardEntity cardEntity);
    }
}