﻿// -----------------------------------------------------------------------
// <copyright file="SearchConfiguration.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

using Sitecore.Search;

namespace Sitecore.ItemBuckets.BigData.RamDirectory
{
    using System.Collections.Generic;

    using Sitecore.Diagnostics;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class SearchConfiguration
    {
        // Fields
        private Dictionary<string, ILuceneIndex> _indexes = new Dictionary<string, ILuceneIndex>();

        // Methods
        public virtual void AddIndex(InMemoryIndex index)
        {
            Assert.ArgumentNotNull(index, "index");
            this._indexes[index.Name] = index;
        }

        // Properties
        public Dictionary<string, ILuceneIndex> Indexes
        {
            get
            {
                return this._indexes;
            }
        }
    }
}
