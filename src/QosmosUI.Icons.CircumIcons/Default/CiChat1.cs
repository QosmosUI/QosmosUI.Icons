// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiChat1 : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "id", "Chat_1");
		builder.AddAttribute(15, "data-name", "Chat 1");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M3.316,19.937A1.251,1.251,0,0,1,2.065,18.69l0-1.716L2.068,6.56a2.5,2.5,0,0,1,2.5-2.5H19.44a2.5,2.5,0,0,1,2.5,2.5v8.41a2.5,2.5,0,0,1-2.5,2.5H6.918a1.49,1.49,0,0,0-1.06.439L4.2,19.57A1.246,1.246,0,0,1,3.316,19.937ZM4.568,5.062a1.5,1.5,0,0,0-1.5,1.5L3.06,16.973l0,1.714a.25.25,0,0,0,.427.176L5.151,17.2a2.482,2.482,0,0,1,1.767-.732H19.44a1.5,1.5,0,0,0,1.5-1.5V6.562a1.5,1.5,0,0,0-1.5-1.5Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
