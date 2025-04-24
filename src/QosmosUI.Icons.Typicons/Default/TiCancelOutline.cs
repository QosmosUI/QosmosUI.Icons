// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons.Default;

public class TiCancelOutline : ComponentBase
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
		builder.AddAttribute(14, "d", "M12 20.5c-4.688 0-8.5-3.812-8.5-8.5s3.812-8.5 8.497-8.5c4.69 0 8.503 3.812 8.503 8.5s-3.812 8.5-8.5 8.5zm0-15c-3.586 0-6.5 2.916-6.5 6.5s2.916 6.5 6.5 6.5 6.5-2.916 6.5-6.5-2.916-6.5-6.5-6.5zM12.003 8.5c1.929 0 3.497 1.57 3.497 3.5 0 .206-.02.412-.057.615l-4.057-4.059c.203-.036.408-.056.614-.056m.003-1c-.882 0-1.696.262-2.39.697l6.188 6.188c.438-.692.699-1.508.699-2.387 0-2.48-2.014-4.498-4.497-4.498zM8.557 11.384l4.059 4.06c-.204.036-.409.056-.616.056-1.93 0-3.5-1.57-3.5-3.502 0-.206.02-.412.057-.614m-.358-1.773c-.435.694-.699 1.508-.699 2.387 0 2.486 2.016 4.502 4.5 4.502.879 0 1.693-.264 2.387-.699l-6.188-6.19z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
