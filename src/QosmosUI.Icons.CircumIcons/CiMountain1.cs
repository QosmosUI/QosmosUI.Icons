// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiMountain1 : ComponentBase
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
		builder.AddAttribute(14, "id", "Mountain_1");
		builder.AddAttribute(15, "data-name", "Mountain 1");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M20.857,19.525l-6.57-14.96a2.5,2.5,0,0,0-4.58-.01l-6.56,14.96a1,1,0,0,0,.07.96.985.985,0,0,0,.84.46h15.89a1,1,0,0,0,.91-1.41ZM10.627,4.965a1.5,1.5,0,0,1,2.75,0l2.43,5.53-1.45,1.45a.5.5,0,0,1-.71,0l-2.04-2.03a1.5,1.5,0,0,0-1.06-.44h-1.9Zm-6.57,14.96,4.15-9.45h2.34a.491.491,0,0,1,.36.15l2.03,2.03A1.508,1.508,0,0,0,14,13.1a1.491,1.491,0,0,0,1.06-.44l1.18-1.17,3.71,8.45Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
