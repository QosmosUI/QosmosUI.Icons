// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaEuroSignSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 18 4 C 13.261719 4 9.414063 7.886719 8.3125 13 L 6 13 L 6 15 L 8.0625 15 C 8.039063 15.328125 8 15.664063 8 16 C 8 16.335938 8.039063 16.671875 8.0625 17 L 6 17 L 6 19 L 8.3125 19 C 9.414063 24.113281 13.261719 28 18 28 C 20.707031 28 23.167969 26.695313 24.9375 24.65625 L 23.40625 23.34375 C 21.953125 25.019531 20.070313 26 18 26 C 14.496094 26 11.410156 23.101563 10.375 19 L 19 19 L 19 17 L 10.03125 17 C 10.003906 16.667969 10 16.339844 10 16 C 10 15.660156 10.003906 15.332031 10.03125 15 L 19 15 L 19 13 L 10.375 13 C 11.410156 8.898438 14.496094 6 18 6 C 20.070313 6 21.953125 6.980469 23.40625 8.65625 L 24.9375 7.34375 C 23.167969 5.304688 20.707031 4 18 4 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
