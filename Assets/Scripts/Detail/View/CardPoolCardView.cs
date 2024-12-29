using Adapter.Controller;
using Adapter.Presenter;
using CommonEntity;
using R3;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Detail.View
{
    public class CardPoolCardView : MonoBehaviour
    {
        [SerializeField] private Button button;
        [SerializeField] private TMP_Text text;
        
        private CardEntity _cardEntity;
        private AddController _addController;

        public void Construct(CardEntity cardEntity, AddController addController)
        {
            _cardEntity = cardEntity;
            _addController = addController;
            
            Init();
        }

        private void Init()
        {
            button.OnClickAsObservable().Subscribe(_ => _addController.Add(new CardEntity(_cardEntity.CardKey)));
            text.text = _cardEntity.CardKey;
        }
    }
}