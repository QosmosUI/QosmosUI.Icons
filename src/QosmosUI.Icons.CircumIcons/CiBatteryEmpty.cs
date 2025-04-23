// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiBatteryEmpty : ComponentBase
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
		builder.AddAttribute(14, "id", "Battery_Empty");
		builder.AddAttribute(15, "data-name", "Battery Empty");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M17.505,18.5H4.065a2,2,0,0,1-2-2v-9a2,2,0,0,1,2-2h13.44a2,2,0,0,1,2,2v1h.93a1.5,1.5,0,0,1,1.5,1.5v4a1.5,1.5,0,0,1-1.5,1.5h-.93v1A2,2,0,0,1,17.505,18.5ZM4.065,6.5a1,1,0,0,0-1,1v9a1,1,0,0,0,1,1h13.44a1,1,0,0,0,1-1V15.25a.752.752,0,0,1,.75-.75h1.18a.5.5,0,0,0,.5-.5V10a.5.5,0,0,0-.5-.5h-1.18a.752.752,0,0,1-.75-.75V7.5a1,1,0,0,0-1-1Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
