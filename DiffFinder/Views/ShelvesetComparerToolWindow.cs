﻿// <copyright file="ShelvesetComparerToolWindow.cs" company="https://github.com/rajeevboobna/CompareShelvesets">Copyright https://github.com/rajeevboobna/CompareShelvesets. All Rights Reserved. This code released under the terms of the Microsoft Public License (MS-PL, http://opensource.org/licenses/ms-pl.html.) This is sample code only, do not use in production environments.</copyright>

using Microsoft.VisualStudio.Shell;
using System.Runtime.InteropServices;

namespace DiffFinder
{
    /// <summary>
    /// This class implements the tool window exposed by this package and hosts a user control.
    /// </summary>
    [Guid("0866ec06-7a85-4e90-8244-4da11ad1677b")]
    public sealed class ShelvesetComparerToolWindow : ToolWindowPane
    {
        /// <summary>
        /// Initializes a new instance of the ShelvesetComparerToolWindow class.
        /// </summary>
        public ShelvesetComparerToolWindow() : base(null)
        {
            this.Caption = Resources.ToolWindowTitle;
            this.BitmapResourceID = 301;
            this.BitmapIndex = 1;
            this.Content = new MainView();
        }
    }
}
