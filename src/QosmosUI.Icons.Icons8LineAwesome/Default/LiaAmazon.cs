// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaAmazon : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 32 32";

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
		builder.AddAttribute(14, "d", "M16.2,4c-3.3,0-6.9,1.2-7.7,5.3C8.4,9.7,8.7,10,9,10l3.3,0.3c0.3,0,0.6-0.3,0.6-0.6c0.3-1.4,1.5-2.1,2.8-2.1c0.7,0,1.5,0.3,1.9,0.9c0.5,0.7,0.4,1.7,0.4,2.5v0.5c-2,0.2-4.6,0.4-6.5,1.2c-2.2,0.9-3.7,2.8-3.7,5.7c0,3.6,2.3,5.4,5.2,5.4c2.5,0,3.8-0.6,5.7-2.5c0.6,0.9,0.9,1.4,2,2.3c0.3,0.1,0.6,0.1,0.8-0.1v0c0.7-0.6,2-1.7,2.7-2.3c0.3-0.2,0.2-0.6,0-0.9c-0.6-0.9-1.3-1.6-1.3-3.2v-5.4c0-2.3,0.2-4.4-1.5-6C20.1,4.4,17.9,4,16.2,4z M17.1,14.3c0.3,0,0.6,0,0.9,0v0.8c0,1.3,0.1,2.5-0.6,3.7c-0.5,1-1.4,1.6-2.4,1.6c-1.3,0-2.1-1-2.1-2.5C12.9,15.2,14.9,14.5,17.1,14.3z M26.7,22.4c-0.9,0-1.9,0.2-2.7,0.8c-0.2,0.2-0.2,0.4,0.1,0.4c0.9-0.1,2.8-0.4,3.2,0.1s-0.4,2.3-0.7,3.1c-0.1,0.2,0.1,0.3,0.3,0.2c1.5-1.2,1.9-3.8,1.6-4.2C28.3,22.5,27.6,22.4,26.7,22.4z M3.7,22.8c-0.2,0-0.3,0.3-0.1,0.4c3.3,3,7.6,4.7,12.4,4.7c3.4,0,7.4-1.1,10.2-3.1c0.5-0.3,0.1-0.9-0.4-0.7c-3.1,1.3-6.4,1.9-9.5,1.9c-4.5,0-8.8-1.2-12.4-3.3C3.8,22.9,3.7,22.8,3.7,22.8z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
