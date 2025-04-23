// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.BoxIcons.Logo;

public class BiLogoBxlOpera : ComponentBase
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
		builder.AddAttribute(14, "d", "M8.71 6.366C7.604 7.67 6.888 9.602 6.838 11.765v.471c.05 2.165.766 4.094 1.872 5.397 1.434 1.865 3.564 3.046 5.948 3.046a7.218 7.218 0 0 0 4.006-1.225 9.943 9.943 0 0 1-7.139 2.533A9.995 9.995 0 0 1 2 12C2 6.477 6.478 2 12 2h.038a9.971 9.971 0 0 1 6.627 2.545c-1.173-.773-2.543-1.225-4.009-1.225-2.382 0-4.514 1.184-5.95 3.046h.004zM22 12a9.971 9.971 0 0 1-3.335 7.455c-2.564 1.25-4.954.375-5.747-.172 2.52-.553 4.422-3.6 4.422-7.283 0-3.686-1.901-6.73-4.422-7.283.792-.545 3.183-1.42 5.747-.172A9.971 9.971 0 0 1 22 12z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
