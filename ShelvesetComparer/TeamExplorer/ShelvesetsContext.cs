﻿// <copyright file="ShelvesetsContext.cs" company="https://github.com/rajeevboobna/shelvesetcomparer">Copyright https://github.com/rajeevboobna/shelvesetcomparer. All Rights Reserved. This code released under the terms of the Microsoft Public License (MS-PL, http://opensource.org/licenses/ms-pl.html.) This is sample code only, do not use in production environments.</copyright>
namespace ShelvesetComparer
{
    using System.Collections.ObjectModel;
    using Microsoft.TeamFoundation.VersionControl.Client;

    /// <summary>
    /// The class provides the place holder for storing shelveset information in the Shelveset Comparer team explorer window.
    /// </summary>
    internal class ShelvesetsContext
    {
        /// <summary>
        /// Gets or sets the list of Shelveset.
        /// </summary>
        public ObservableCollection<Shelveset> Shelvesets { get; set; }
    }
}
