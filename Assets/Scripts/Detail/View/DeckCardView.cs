using Adapter.Presenter;
using CommonEntity;
using R3;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Detail.View
{
    public class DeckCardView : MonoBehaviour
    {
        [SerializeField] private Button button;
        [SerializeField] private TMP_Text text;


        public CardEntity CardEntity { get; private set; }
        private RemoveController _removeController;

        public void Construct(CardEntity cardEntity, RemoveController removeController)
        {
            CardEntity = cardEntity;
            _removeController = removeController;

            Init();
        }

        private void Init()
        {
            text.text = CardEntity.CardKey;

            button.OnClickAsObservable().Subscribe(_ => _removeController.Remove(CardEntity));
        }
    }
}