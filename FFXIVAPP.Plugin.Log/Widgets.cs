﻿// FFXIVAPP.Plugin.Log ~ Widgets.cs
// 
// Copyright © 2007 - 2017 Ryan Wilson - All Rights Reserved
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using FFXIVAPP.Common.Models;
using FFXIVAPP.Common.Utilities;
using FFXIVAPP.Plugin.Log.Windows;
using NLog;

namespace FFXIVAPP.Plugin.Log
{
    public class Widgets
    {
        #region Logger

        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        #endregion

        private static Widgets _instance;
        private TranslationWidget _translationWidget;

        public static Widgets Instance
        {
            get { return _instance ?? (_instance = new Widgets()); }
            set { _instance = value; }
        }

        public TranslationWidget TranslationWidget
        {
            get { return _translationWidget ?? (_translationWidget = new TranslationWidget()); }
        }

        public void ShowTranslationWidget()
        {
            try
            {
                TranslationWidget.Show();
            }
            catch (Exception ex)
            {
                Logging.Log(Logger, new LogItem(ex, true));
            }
        }
    }
}