using System.ComponentModel;

namespace Uno.Toolkit.Samples.Entities
{
	public enum SourceSdk
	{
		[Description("WinUI/Uno.UI")]
		WinUI,
		[Description("Uno")]
		Uno,
		[Description("Uno.Material")]
		UnoMaterial,
		[Description("Uno.Cupertino")]
		UnoCupertino,
		[Description("Uno.Toolkit")]
		UnoToolkit,
	}
}
