using System.Collections.Generic;
using Adapter.Presenter;
using CommonEntity;
using UnityEngine;
using VContainer;

namespace Detail.View
{
    public class CardPoolView : MonoBehaviour, ICardPoolView
    {
        [Inject] private readonly CardPoolCardViewFactory _cardViewFactory;

        private readonly List<CardPoolCardView> _instances = new();

        public void OnReset(IReadOnlyList<CardEntity> cardEntities)
        {
            foreach (var cardPoolCardView in _instances)
            {
                Destroy(cardPoolCardView.gameObject);
            }

            _instances.Clear();

            foreach (var cardEntity in cardEntities)
            {
                var instance = _cardViewFactory.Create(cardEntity);
                _instances.Add(instance);
            }
        }
    }
}