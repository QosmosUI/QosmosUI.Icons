// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiRos : ComponentBase
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
		builder.AddAttribute(15, "d", "M2.807 0C1.353 0 .173 1.22.173 2.722c0 1.504 1.18 2.723 2.634 2.723 1.455 0 2.635-1.22 2.635-2.723S4.262 0 2.807 0zM12 0c-1.455 0-2.634 1.22-2.634 2.722 0 1.504 1.18 2.723 2.634 2.723 1.455 0 2.634-1.22 2.634-2.723S13.454 0 12 0zm9.193 0c-1.455 0-2.635 1.22-2.635 2.722 0 1.504 1.18 2.723 2.635 2.723 1.455 0 2.634-1.22 2.634-2.723S22.647 0 21.193 0zM2.807 9.277C1.353 9.277.173 10.497.173 12s1.18 2.722 2.634 2.722c1.455 0 2.635-1.219 2.635-2.722 0-1.504-1.18-2.723-2.635-2.723zm9.193 0c-1.455 0-2.634 1.22-2.634 2.723s1.18 2.722 2.634 2.722c1.455 0 2.634-1.219 2.634-2.722 0-1.504-1.18-2.723-2.634-2.723zm9.193 0c-1.455 0-2.635 1.22-2.635 2.723s1.18 2.722 2.635 2.722c1.455 0 2.634-1.219 2.634-2.722 0-1.504-1.18-2.723-2.634-2.723zM2.807 18.555c-1.454 0-2.634 1.22-2.634 2.722C.173 22.781 1.353 24 2.807 24c1.455 0 2.635-1.22 2.635-2.723s-1.18-2.722-2.635-2.722zm9.193 0c-1.455 0-2.634 1.22-2.634 2.722C9.366 22.781 10.546 24 12 24c1.455 0 2.634-1.22 2.634-2.723s-1.18-2.722-2.634-2.722zm9.193 0c-1.455 0-2.635 1.22-2.635 2.722 0 1.504 1.18 2.723 2.635 2.723 1.455 0 2.634-1.22 2.634-2.723s-1.18-2.722-2.634-2.722z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
