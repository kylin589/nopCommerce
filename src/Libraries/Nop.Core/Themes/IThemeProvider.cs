﻿using System.Collections.Generic;

namespace Nop.Core.Themes
{
    /// <summary>
    /// Represents a theme provider
    /// </summary>
    public partial interface IThemeProvider
    {
        #region Methods

        /// <summary>
        /// Get all themes
        /// </summary>
        /// <returns>List of the theme descriptor</returns>
        IList<ThemeDescriptor> GetThemes();

        /// <summary>
        /// Get a theme by the system name
        /// </summary>
        /// <param name="systemName">Theme system name</param>
        /// <returns>Theme descriptor</returns>
        ThemeDescriptor GetThemeBySystemName(string systemName);

        /// <summary>
        /// Check whether the theme with specified system name exists
        /// </summary>
        /// <param name="systemName">Theme system name</param>
        /// <returns>True if the theme exists; otherwise false</returns>
        bool ThemeExists(string systemName);

        #endregion

        #region Properties

        /// <summary>
        /// Gets the path to themes folder
        /// </summary>
        string ThemesPath { get; }

        /// <summary>
        /// Gets the name of the theme description file
        /// </summary>
        string ThemeDescriptionFileName { get; }

        #endregion
    }
}