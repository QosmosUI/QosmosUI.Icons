// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaGooglePlusSquare : ComponentBase
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
		builder.AddAttribute(14, "d", "M 5 5 L 5 27 L 27 27 L 27 5 L 5 5 z M 7 7 L 25 7 L 25 25 L 7 25 L 7 7 z M 13.59375 11 C 11.05575 11 9 13.055984 9 15.583984 C 9 18.121984 11.05575 20.177734 13.59375 20.177734 C 16.23775 20.177734 18 18.321219 18 15.699219 C 18 15.406219 17.969016 15.231 17.916016 15 L 13.59375 15 L 13.59375 16.517578 L 16.195312 16.517578 C 16.091312 17.188578 15.40875 18.490234 13.59375 18.490234 C 12.03075 18.490234 10.751953 17.200703 10.751953 15.595703 C 10.751953 13.990703 12.03075 12.689453 13.59375 12.689453 C 14.48475 12.689453 15.083922 13.077344 15.419922 13.402344 L 16.667969 12.205078 C 15.860969 11.450078 14.83175 11 13.59375 11 z M 20.330078 14 L 20.330078 15.330078 L 19 15.330078 L 19 16.669922 L 20.330078 16.669922 L 20.330078 18 L 21.669922 18 L 21.669922 16.669922 L 23 16.669922 L 23 15.330078 L 21.669922 15.330078 L 21.669922 14 L 20.330078 14 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
