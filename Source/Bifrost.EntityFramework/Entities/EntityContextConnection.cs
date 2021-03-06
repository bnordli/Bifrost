﻿/*---------------------------------------------------------------------------------------------
 *  Copyright (c) 2008-2017 Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using Bifrost.Entities;
using Bifrost.Execution;

namespace Bifrost.EntityFramework.Entities
{
    /// <summary>
    /// Represents a <see cref="IEntityContextConnection"/> for EntityFramework
    /// </summary>
    public class EntityContextConnection : IEntityContextConnection
    {
        /// <summary>
        /// Initializes a new instance of <see cref="EntityContextConnection"/>
        /// </summary>
        public EntityContextConnection(EntityContextConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// Gets the <see cref="EntityContextConfiguration"/>
        /// </summary>
        public EntityContextConfiguration Configuration { get; private set; }

#pragma warning disable 1591 // Xml Comments
        public void Initialize(IContainer container)
        {

        }
#pragma warning restore 1591 // Xml Comments
    }
}