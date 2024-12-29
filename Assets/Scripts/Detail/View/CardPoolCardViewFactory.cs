using Adapter.Controller;
using Adapter.Presenter;
using CommonEntity;
using UnityEngine;
using VContainer;

namespace Detail.View
{
    public class CardPoolCardViewFactory : MonoBehaviour
    {
        [SerializeField] private CardPoolCardView cardPrefab;
        [SerializeField] private Transform parent;

        [Inject] private readonly AddController _addController;

        public CardPoolCardView Create(CardEntity cardEntity)
        {
            var instance = Instantiate(cardPrefab, parent);
            instance.Construct(cardEntity, _addController);
            return instance;
        }
    }
}