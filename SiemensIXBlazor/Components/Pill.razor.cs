using System;
using Microsoft.AspNetCore.Components;

namespace SiemensIXBlazor.Components
{
	public partial class Pill
	{
		[Parameter]
		public string Label { get; set; } = string.Empty;
        [Parameter]
        public string Class { get; set; } = string.Empty;
        [Parameter]
		public bool AllignLeft { get; set; } = false;
		[Parameter]
		public string? Background { get; set; }
		[Parameter]
		public string? Color { get; set; }
		[Parameter]
		public string? Icon { get; set; }
		[Parameter]
		public bool Outline { get; set; } = false;
		[Parameter]
		public string Variant { get; set; } = "primary";
	}
}

