﻿using System;
using System.Collections.Specialized;
using System.Threading;
using System.Threading.Tasks;
using Idfy.QuartzExtensions.Core;
using Quartz;
using Quartz.Impl;

namespace Idfy.QuartzExtensions.SqlServer
{
    public static class SqlServerSchedulerFactory
    {
        public static async Task<IScheduler> GetDefaultScheduler(string instanceName, string connectionString,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var configuration = new QuartzSqlServerConfiguration(instanceName, connectionString);
            return await GetDefaultScheduler(configuration, cancellationToken);
        }

        public static async Task<IScheduler> GetDefaultScheduler(QuartzSqlServerConfiguration configuration,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return await PersistentSchedulerFactory.GetDefaultScheduler(configuration, cancellationToken);
        }
    }
}