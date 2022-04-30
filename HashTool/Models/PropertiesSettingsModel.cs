﻿// Copyright (c) Kiyan Yang. All rights reserved.
// Licensed under the GNU General Public License v3.0.
// See LICENSE file in the project root for full license information.

using System.Collections.Specialized;
using System.Runtime.CompilerServices;

using HashTool.Properties;

using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace HashTool.Models
{
    public class PropertiesSettingsModel : ObservableObject
    {
        private bool? _isLowerCase;
        private StringCollection? _selectedHashAlgorithms;

        /// <summary>
        /// 是否以小写字母展示结果。
        /// </summary>
        public bool IsLowerCase
        {
            get => _isLowerCase ??= Settings.Default.IsLowerCase;
            set
            {
                SetProperty(ref _isLowerCase, value);
                SaveSettings(value);
            }
        }

        /// <summary>
        /// 所选的哈希算法。
        /// </summary>
        public StringCollection SelectedHashAlgorithms
        {
            get => _selectedHashAlgorithms ??= Settings.Default.SelectedHashAlgorithms;
        }

        /// <summary>
        /// 保存设置。
        /// </summary>
        /// <typeparam name="T">设置内支持的类型。</typeparam>
        /// <param name="value">新值。</param>
        /// <param name="propertyName">设置的键值。</param>
        private static void SaveSettings<T>(T value, [CallerMemberName] string? propertyName = null)
        {
            Settings.Default[propertyName] = value;
            Settings.Default.Save();
        }
    }
}
