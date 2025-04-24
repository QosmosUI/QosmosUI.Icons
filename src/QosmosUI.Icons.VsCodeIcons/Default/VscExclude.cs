// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.VsCodeIcons.Default;

public class VscExclude : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

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
    public string ViewBox { get; set; } = "0 0 16 16";

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
		builder.AddAttribute(14, "fill-rule", "evenodd");
		builder.AddAttribute(15, "clip-rule", "evenodd");
		builder.AddAttribute(16, "d", "M9.412 1H6.588l-.484 2.423-2.056-1.37-1.996 1.995 1.37 2.056L1 6.588v2.824l2.423.484-1.37 2.056 1.995 1.996 2.056-1.37L6.588 15h2.083a4.526 4.526 0 0 1-.917-1.005h-.342l-.288-1.441a4.473 4.473 0 0 1-.067-.334l-.116-.583-.764-.316-2 1.334-.832-.831L4.68 9.823l-.316-.764-2.358-.471V7.412l2.358-.471.316-.764-1.334-2 .831-.832 2 1.335.764-.316.471-2.358h1.176l.471 2.358.764.316 2-1.334.832.831-1.334 2.001.316.764.582.116c.113.018.225.04.335.067l1.441.288v.342c.38.254.719.563 1.005.917V6.588l-2.422-.484 1.37-2.056-1.996-1.996-2.056 1.37L9.412 1zM8 6a2 2 0 0 1 1.875 1.302 4.46 4.46 0 0 0-.9.473 1 1 0 1 0-1.2 1.2 4.46 4.46 0 0 0-.473.9A2 2 0 0 1 8 6zm1.28 2.795a3.5 3.5 0 1 1 4.44 5.41 3.5 3.5 0 0 1-4.44-5.41zM9 11v1h5v-1H9z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
