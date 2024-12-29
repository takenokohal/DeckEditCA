using System.Collections.Generic;
using System.Linq;
using Adapter.Presenter;
using CommonEntity;
using UnityEngine;
using VContainer;

namespace Detail.View
{
    public class DeckView : MonoBehaviour, IAddView, IRemoveView
    {
        [Inject] private readonly DeckCardViewFactory _deckCardViewFactory;

        private readonly List<DeckCardView> _deckCardViews = new();
        public IReadOnlyList<DeckCardView> DeckCardViews => _deckCardViews;

        public void OnAdd(CardEntity cardEntity)
        {
            var instance = _deckCardViewFactory.Create(cardEntity);
            _deckCardViews.Add(instance);
        }

        public void OnRemove(CardEntity cardEntity)
        {
            var instance = _deckCardViews.First(value => value.CardEntity == cardEntity);
            _deckCardViews.Remove(instance);
            Destroy(instance.gameObject);
        }
    }
}