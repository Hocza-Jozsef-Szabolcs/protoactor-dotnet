// -----------------------------------------------------------------------
// <copyright file="AmazonEcsProviderConfig.cs" company="Asynkron AB">
//      Copyright (C) 2015-2021 Asynkron AB All rights reserved
// </copyright>
// -----------------------------------------------------------------------
using Microsoft.Extensions.Logging;

namespace Proto.Cluster.AmazonECS
{
    public record AmazonEcsProviderConfig
    {
        public int WatchTimeoutSeconds { get; }
        private bool DeveloperLogging { get; }

        public AmazonEcsProviderConfig(int watchTimeoutSeconds = 30, bool developerLogging = false)
        {
            WatchTimeoutSeconds = watchTimeoutSeconds;
            DeveloperLogging = developerLogging;
        }
        
        internal LogLevel DebugLogLevel => DeveloperLogging ? LogLevel.Information : LogLevel.Debug;
    }
}