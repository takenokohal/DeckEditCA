using Adapter.Gateway;
using Adapter.Presenter;
using Detail.DB;
using Detail.View;
using Domain.Entity;
using Domain.UseCase;
using Test;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace God
{
    public class DeckEditLifetimeScope : LifetimeScope
    {
        [SerializeField] private CardPoolDatabase cardPoolDatabase;

        protected override void Configure(IContainerBuilder builder)
        {
            //Entity
            builder.Register<DeckEntity>(Lifetime.Singleton);
            builder.Register<CardPoolEntity>(Lifetime.Singleton);

            //UseCase
            builder.Register<AddUseCase>(Lifetime.Singleton);
            builder.Register<RemoveUseCase>(Lifetime.Singleton);
            builder.Register<ResetCardPoolUseCase>(Lifetime.Singleton);

            //Presenter
            builder.RegisterEntryPoint<AddPresenter>();
            builder.RegisterEntryPoint<RemovePresenter>();
            builder.RegisterEntryPoint<CardPoolPresenter>();

            //Controller
            builder.Register<AddController>(Lifetime.Singleton);
            builder.Register<RemoveController>(Lifetime.Singleton);

            //Gateway
            builder.Register<CardPoolGateway>(Lifetime.Singleton).AsImplementedInterfaces();

            //View
            builder.RegisterComponentInHierarchy<DeckView>().AsImplementedInterfaces();
            builder.RegisterComponentInHierarchy<DeckCardViewFactory>();

            builder.RegisterComponentInHierarchy<CardPoolView>().AsImplementedInterfaces();
            builder.RegisterComponentInHierarchy<CardPoolCardViewFactory>();

            //DB
            builder.RegisterInstance(cardPoolDatabase).AsImplementedInterfaces();

            //Initialized
            builder.RegisterEntryPoint<GameInitializer>();
        }
    }
}