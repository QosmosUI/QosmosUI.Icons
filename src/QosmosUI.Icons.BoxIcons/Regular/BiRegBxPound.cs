// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.BoxIcons.Regular;

public class BiRegBxPound : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "m5.553 19.105.764 1.843C7.498 20.555 9.422 20 10 20c.838 0 1.462.208 2.184.448.775.259 1.654.552 2.816.552 1.177 0 3.078-.921 3.447-1.105l-.895-1.789c-.721.36-2.031.894-2.552.894-.838 0-1.462-.208-2.184-.448C12.041 18.293 11.162 18 10 18c-.229 0-.526.037-.857.099C9.702 16.95 10 15.561 10 14h3v-2H9.626c-.042-.107-.084-.216-.125-.317C9.243 11.052 9 10.455 9 9c0-1.369.521-3 3-3 2.224 0 3.021 2.227 3.052 2.316l1.896-.633C16.898 7.533 15.679 4 12 4 8.313 4 7 6.583 7 9c0 1.491.234 2.35.478 3H5v2h3c0 2.467-.892 4.328-2.447 5.105z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
