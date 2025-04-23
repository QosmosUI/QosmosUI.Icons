// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiSignpostR1 : ComponentBase
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
		builder.AddAttribute(14, "id", "Signpost_R_1");
		builder.AddAttribute(15, "data-name", "Signpost R 1");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M3.563,8h13.9a2.489,2.489,0,0,1,1.744.709l2.25,2.192a1.5,1.5,0,0,1-.007,2.2l-2.243,2.187A2.483,2.483,0,0,1,17.464,16H3.563a1.5,1.5,0,0,1-1.5-1.5v-5A1.5,1.5,0,0,1,3.563,8Zm13.9,7a1.491,1.491,0,0,0,1.046-.425l2.255-2.2A.5.5,0,0,0,20.937,12a.494.494,0,0,0-.162-.369l-.01-.01-2.254-2.2A1.492,1.492,0,0,0,17.464,9H3.563a.5.5,0,0,0-.5.5v5a.5.5,0,0,0,.5.5Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
