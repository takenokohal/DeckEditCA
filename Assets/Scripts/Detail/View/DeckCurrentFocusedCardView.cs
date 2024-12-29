using System.Linq;
using Adapter.Presenter;
using CommonEntity;
using UnityEngine;
using UnityEngine.InputSystem;
using VContainer;

namespace Detail.View
{
    public class DeckCurrentFocusedCardView : MonoBehaviour, IDeckCurrentFocusedView
    {
        [SerializeField] private PlayerInput playerInput;

        [Inject] private readonly DeckView _deckView;
        private DeckCardView _currentFocusedCard;

        public void OnSet(CardEntity cardEntity)
        {
            _currentFocusedCard = _deckView.DeckCardViews.First(value => value.CardEntity == cardEntity);
        }

        private void Update()
        {
            var inputDirection = playerInput.actions["Move"].ReadValue<Vector2>();
            var y = inputDirection.y;
            var value = y switch
            {
                > 0 => 1,
                < 0 => -1,
                _ => 0
            };
        }

        
    }
}