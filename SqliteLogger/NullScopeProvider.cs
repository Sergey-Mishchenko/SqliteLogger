﻿using Microsoft.Extensions.Logging;
using System;

namespace SqliteLogger
{
    internal class NullScopeProvider : IExternalScopeProvider
    {
        public static readonly IExternalScopeProvider Instance = new NullScopeProvider();

        private NullScopeProvider()
        {

        }

        public void ForEachScope<TState>(Action<object, TState> callback, TState state)
        {
            // Do nothing
        }

        public IDisposable Push(object state) => NullDisposable.Instance;
    }

    internal class NullDisposable : IDisposable
    {
        public static readonly IDisposable Instance = new NullDisposable();

        private NullDisposable()
        {

        }

        public void Dispose()
        {
            return;
        }
    }
}
