// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Migrations.Operations.Builders;
using Microsoft.EntityFrameworkCore.SqlServer.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Utilities;

// ReSharper disable once CheckNamespace
namespace Microsoft.EntityFrameworkCore
{
    /// <summary>
    ///     SQL Server specific extension methods for <see cref="IndexBuilder" />.
    /// </summary>
    public static class SqlServerMigrationOperationExtensions
    {
        /// <summary>
        ///     Configures that the index should be built as online index when targeting SQL Server.
        /// </summary>
        /// <param name="operation"> The index migration operation that should be applied as online index.</param>
        /// <returns> An operation builder to further configure the index migration. </returns>
        public static OperationBuilder<CreateIndexOperation> AsOnlineIndexMigration([NotNull] this OperationBuilder<CreateIndexOperation> operation)
        {
            Check.NotNull(operation, nameof(operation));

            operation.Annotation(SqlServerAnnotationNames.OnlineIndex, true);

            return operation;
        }
    }
}
