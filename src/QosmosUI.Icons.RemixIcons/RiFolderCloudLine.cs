// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiFolderCloudLine : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M3 3C2.44772 3 2 3.44772 2 4V20C2 20.5523 2.44772 21 3 21H10V19H4V5H9.58579L11.5858 7H20V11H22V6C22 5.44772 21.5523 5 21 5H12.4142L10.4142 3H3ZM12 18.25C12 16.9907 12.8465 15.9291 14.0015 15.6031C13.9452 13.6578 15.5523 12 17.5 12C19.4477 12 21.0548 13.6578 20.9985 15.6031C22.1535 15.9291 23 16.9907 23 18.25C23 19.7688 21.7688 21 20.25 21H14.75C13.2312 21 12 19.7688 12 18.25ZM17.5 14C16.6716 14 16 14.6716 16 15.5C16 15.9637 16.0239 16.4751 16.0569 16.9605C15.0926 17.1654 14 17.5516 14 18.25C14 18.6642 14.3358 19 14.75 19H20.25C20.6642 19 21 18.6642 21 18.25C21 17.5516 19.9074 17.1654 18.9431 16.9605C18.9761 16.4751 19 15.9637 19 15.5C19 14.6716 18.3284 14 17.5 14Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
