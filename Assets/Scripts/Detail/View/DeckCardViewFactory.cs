using Adapter.Controller;
using Adapter.Presenter;
using CommonEntity;
using UnityEngine;
using VContainer;

namespace Detail.View
{
    public class DeckCardViewFactory : MonoBehaviour
    {
        [SerializeField] private DeckCardView deckCardViewPrefab;

        [SerializeField] private Transform parent;


        [Inject] private readonly RemoveController _removePresenter;

        public DeckCardView Create(CardEntity cardEntity)
        {
            var instance = Instantiate(deckCardViewPrefab, parent);
            instance.Construct(cardEntity, _removePresenter);


            return instance;
        }
    }
}