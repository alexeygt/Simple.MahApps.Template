namespace Simple.Wpf.Template.Services
{
    using System;
    using System.Reactive;

    public interface IHeartbeatService : IService
    {
        IObservable<Unit> Listen { get; }
    }
}