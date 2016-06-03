using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rhino.PlugIns;


// Plug-in Description Attributes - all of these are optional
// These will show in Rhino's option dialog, in the tab Plug-ins
[assembly: PlugInDescription(DescriptionType.Address, "8 rue Samson - 44400 - Reze")]
[assembly: PlugInDescription(DescriptionType.Country, "France")]
[assembly: PlugInDescription(DescriptionType.Email, "q.labrosse@kinematiq.net")]
[assembly: PlugInDescription(DescriptionType.Phone, "+33 7 77 04 26 08")]
[assembly: PlugInDescription(DescriptionType.Fax, "-")]
[assembly: PlugInDescription(DescriptionType.Organization, "Kinematiq")]
[assembly: PlugInDescription(DescriptionType.UpdateUrl, "-")]
[assembly: PlugInDescription(DescriptionType.WebSite, "www.kinematiq.net")]


// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("RhinoSlic3r")] // Plug-In title is extracted from this
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("RhinoSlic3r")]
[assembly: AssemblyCopyright("Copyright © Kinematiq 2016")]
[assembly: AssemblyTrademark("RhinoSlic3r")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("57dc80bc-3a7c-489e-a922-b47a1827a781")] // This will also be the Guid of the Rhino plug-in

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
