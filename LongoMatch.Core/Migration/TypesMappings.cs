﻿//
//  Copyright (C) 2016 Fluendo S.A.
//
//  This program is free software; you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation; either version 2 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program; if not, write to the Free Software
//  Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA 02110-1301, USA.
//
using System;
using System.Collections.Generic;

namespace LongoMatch.Core.Migration
{
	public static class Mappings
	{
		public static Dictionary<string, Tuple<string, string>> NamespacesReplacements = new Dictionary<string, Tuple<string, string>> {
			{ "LongoMatch.Core", new Tuple<string, string> ("VAS.Core", "VAS.Core") },
		};

		public static Dictionary<string, Type> TypesMappings = new Dictionary<string, Type> {
			{ "LongoMatch.Core.Store.Templates.TeamTemplate", typeof(LongoMatch.Core.Store.Templates.SportsTeam) },
			{ "LongoMatch.Core.Store.Templates.Team", typeof(LongoMatch.Core.Store.Templates.SportsTeam) },
			{ "LongoMatch.Core.Store.Templates.Dashboard", typeof(LongoMatch.Core.Store.Templates.DashboardLongoMatch) },
			{ "LongoMatch.Core.Store.Player", typeof(LongoMatch.Core.Store.PlayerLongoMatch) },
			{ "LongoMatch.Core.Store.Project", typeof(LongoMatch.Core.Store.ProjectLongoMatch) },
			{ "LongoMatch.Core.Store.TimelineEvent", typeof(LongoMatch.Core.Store.TimelineEventLongoMatch) },
		};
	}
}
