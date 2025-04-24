// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify.Default;

public class TfiBell : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "17";

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
    public string ViewBox { get; set; } = "0 0 17 17";

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
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M15.312 14.125c-0.014-0.013-1.312-1.294-1.312-3.21v-3.292c0-3.101-2.468-5.623-5.5-5.623s-5.5 2.522-5.5 5.623v3.292c0 1.861-1.306 3.203-1.318 3.216l-0.843 0.853h15.357l-0.884-0.859zM3.052 13.984c0.444-0.692 0.948-1.764 0.948-3.069v-3.292c0-2.549 2.019-4.623 4.5-4.623s4.5 2.074 4.5 4.623v3.292c0 1.32 0.495 2.383 0.938 3.069h-10.886zM9 2h-1v-1h1v1zM9 15h1c0 0.827-0.673 1.5-1.5 1.5s-1.5-0.673-1.5-1.5h1c0 0.276 0.225 0.5 0.5 0.5s0.5-0.224 0.5-0.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
