// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons.Default;

public class TiAnchorOutline : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.OpenElement(14, "circle");
		builder.AddAttribute(15, "cx", "12");
		builder.AddAttribute(16, "cy", "6");
		builder.AddAttribute(17, "r", "1");
		builder.CloseElement();
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M19.793 12.096c.134-.34.207-.709.207-1.096 0-1.654-1.346-3-3-3h-.422c.273-.619.422-1.297.422-2 0-2.757-2.243-5-5-5s-5 2.243-5 5c0 .703.149 1.381.422 2h-.422c-1.654 0-3 1.346-3 3 0 .387.073.756.207 1.096-.732.548-1.207 1.422-1.207 2.404 0 4.963 4.037 9 9 9s9-4.037 9-9c0-.982-.475-1.856-1.207-2.404zm-7.793 9.404c-3.859 0-7-3.141-7-7 0-.553.447-1 1-1s1 .447 1 1c0 2.414 1.721 4.434 4 4.898v-7.398h-4c-.553 0-1-.447-1-1s.447-1 1-1h4v-1.184c-1.162-.413-2-1.511-2-2.816 0-1.657 1.343-3 3-3s3 1.343 3 3c0 1.305-.838 2.403-2 2.816v1.184h4c.553 0 1 .447 1 1s-.447 1-1 1h-4v7.398c2.279-.465 4-2.484 4-4.898 0-.553.447-1 1-1s1 .447 1 1c0 3.859-3.141 7-7 7zm-4.679-8.5h2.679v4.962c-1.207-.701-2-2.009-2-3.462 0-.597-.263-1.133-.679-1.5zm9.358 0c-.416.367-.679.903-.679 1.5 0 1.453-.793 2.761-2 3.462v-4.962h2.679z");
		builder.CloseElement();
		builder.OpenElement(20, "circle");
		builder.AddAttribute(21, "cx", "12");
		builder.AddAttribute(22, "cy", "6");
		builder.AddAttribute(23, "r", "1");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
