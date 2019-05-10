﻿#region license
//Copyright(C) 2019 by Clever Components

//Author: Sergey Shirokov<admin@clevercomponents.com>
//Website: www.CleverComponents.com

//This file is part of the Data Depersonalizer application.
//The Data Depersonalizer application is free software:
//you can redistribute it and/or modify it under the terms of
//the GNU Lesser General Public License version 3
//as published by the Free Software Foundation and appearing in the
//included file COPYING.LESSER.

//The Data Depersonalizer application is distributed in the hope
//that it will be useful, but WITHOUT ANY WARRANTY; without even the
//implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
//See the GNU Lesser General Public License for more details.

//You should have received a copy of the GNU Lesser General Public License
//along with the Data Depersonalizer application. If not, see<http://www.gnu.org/licenses/>.
#endregion

using System;
using System.Collections.Generic;
using Depersonalizer.Common;

namespace DataDepersonalizer.Editors
{
	public class ReplacerFactory
	{
		public ReplacerFactory()
		{
			Replacers = new Dictionary<Type, string>();
		}

		public void RegisterReplacer(Type replacerType, string replacerName)
		{
			Replacers.Add(replacerType, replacerName);
		}

		public IDataReplacer CreateReplacer(Type replacerType)
		{
			return (IDataReplacer)Activator.CreateInstance(replacerType);
		}

		public string GetReplacerName(Type replacerType)
		{
			return Replacers[replacerType];
		}

		public Dictionary<Type, string> Replacers { get; }
	}
}
