// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.BoxIcons.Logo;

public class BiLogoBxlKickstarter : ComponentBase
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
		builder.AddAttribute(14, "d", "m10.198 9.127 3.309-4.799c.628-.902 1.434-1.354 2.427-1.354.806 0 1.506.287 2.097.861.59.574.885 1.26.885 2.059 0 .59-.155 1.113-.469 1.563l-2.983 4.34 3.649 4.627c.363.461.547 1 .547 1.617 0 .816-.286 1.518-.86 2.105a2.81 2.81 0 0 1-2.084.879c-.895 0-1.577-.291-2.047-.873L10.2 14.574v3.074c0 .879-.152 1.561-.457 2.049-.555.885-1.356 1.328-2.417 1.328-.963 0-1.711-.328-2.24-.977-.496-.602-.744-1.396-.744-2.387V6.258c0-.936.253-1.709.755-2.318.525-.643 1.255-.965 2.186-.965.887 0 1.624.322 2.216.965.329.357.537.717.625 1.082.053.227.079.646.079 1.266v2.84h-.005z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
