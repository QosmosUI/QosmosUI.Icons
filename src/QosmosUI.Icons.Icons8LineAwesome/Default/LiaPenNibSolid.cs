// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaPenNibSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 22 3.5859375 L 17.478516 8.1074219 L 10.738281 10.035156 C 9.4172813 10.392156 8.3715 11.380547 7.9375 12.685547 L 3.859375 25.273438 L 5.2929688 26.707031 L 6.7265625 28.140625 L 19.320312 24.060547 C 20.618313 23.628547 21.606938 22.581437 21.960938 21.273438 L 23.888672 14.525391 L 28.414062 10 L 22 3.5859375 z M 22 6.4140625 L 25.585938 10 L 23 12.585938 L 19.414062 9 L 22 6.4140625 z M 17.710938 10.125 L 21.875 14.289062 L 20.033203 20.738281 C 19.851203 21.410281 19.349266 21.942156 18.697266 22.160156 L 7.6894531 25.724609 L 13.484375 19.929688 A 2 2 0 0 0 14 20 A 2 2 0 0 0 14 16 A 2 2 0 0 0 12.070312 18.515625 L 6.2753906 24.310547 L 9.8378906 13.310547 C 10.057891 12.649547 10.590391 12.148891 11.275391 11.962891 L 17.710938 10.125 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
