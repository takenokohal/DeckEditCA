using System.Collections.Generic;
using CommonEntity;

namespace Adapter.Presenter
{
    public interface ICardPoolView
    {
        public void OnReset(IReadOnlyList<CardEntity> cardEntities);
    }
}