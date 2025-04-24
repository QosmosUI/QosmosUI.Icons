// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiMintlify : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 24 24";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M15.158.002a8.807 8.807 0 0 0-6.249 2.59l-.062.063h-.003L2.655 8.844a.605.605 0 0 0-.062.058 8.838 8.838 0 0 0-.83 11.55l6.251-6.249.065-.063a8.778 8.778 0 0 1-1.758-5.385 8.784 8.784 0 0 1 .283-2.151 8.993 8.993 0 0 1 2.151-.286 8.802 8.802 0 0 1 5.386 1.76 8.81 8.81 0 0 1 3.032 4.11 8.879 8.879 0 0 1 .225 5.21 8.784 8.784 0 0 0-.341.082 8.846 8.846 0 0 1-4.868-.303 8.679 8.679 0 0 1-2.323-1.25l-.064.065L3.55 22.24a8.85 8.85 0 0 0 11.548-.83l.06-.062 6.19-6.187a8.801 8.801 0 0 1-.367.337c.125-.11.247-.224.366-.341l.063-.058A8.817 8.817 0 0 0 24 8.844V.002ZM8.38 3.17a8.73 8.73 0 0 1 0 0Zm-.325.413Zm-.328.475Zm-.31.518Zm-.235.455Zm-.283.66zm-.156.447Zm14.147 9.44zm-.43.343zm-1.005.65zm-.533.274zm-.475.207z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
