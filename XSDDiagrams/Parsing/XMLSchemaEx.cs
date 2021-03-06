//    XSDDiagram - A XML Schema Definition file viewer
//    Copyright (C) 2006-2011  Regis COSNIER
//    
//    The content of this file is subject to the terms of either
//    the GNU Lesser General Public License only (LGPL) or
//    the Microsoft Public License (Ms-PL).
//    Please see LICENSE-LGPL.txt and LICENSE-MS-PL.txt files for details.
//
//    Authors:
//      Regis Cosnier (Initial developer)
//      Paul Selormey (Refactoring)

namespace XMLSchema
{
    using System.ComponentModel;

	[TypeConverter(typeof(ExpandableObjectConverter))]
	partial class annotation
	{
	}

	[TypeConverter(typeof(ExpandableObjectConverter))]
	partial class localComplexType
	{
	}

	[TypeConverter(typeof(ExpandableObjectConverter))]
	partial class documentation
	{
	}

	[TypeConverter(typeof(ExpandableObjectConverter))]
	partial class appinfo
	{
	}
}
