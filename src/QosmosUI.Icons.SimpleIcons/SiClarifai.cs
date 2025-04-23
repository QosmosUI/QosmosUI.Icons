// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiClarifai : ComponentBase
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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M2.78 14.772A2.768 2.768 0 0 1 0 12.008a2.781 2.781 0 0 1 2.78-2.78 2.765 2.765 0 0 1 2.764 2.764c0 1.52-1.23 2.78-2.764 2.78zM17.119 1.83c-2.05 0-2.142 1.732-5.27 1.732-3.16 0-3.419-1.732-5.287-1.732a2.765 2.765 0 0 0-2.765 2.765 2.775 2.775 0 0 0 2.765 2.764c2.066 0 2.157-1.731 5.286-1.731 3.16 0 3.418 1.731 5.286 1.731A2.765 2.765 0 0 0 19.9 4.595a2.778 2.778 0 0 0-2.78-2.765zm0 14.81c-2.066 0-2.157 1.732-5.286 1.732-3.16 0-3.418-1.731-5.286-1.731a2.765 2.765 0 0 0-2.765 2.764 2.775 2.775 0 0 0 2.765 2.765c2.066 0 2.157-1.732 5.286-1.732 3.16 0 3.418 1.732 5.286 1.732a2.765 2.765 0 0 0 0-5.53zm4.101-7.397c-2.08 0-2.005 1.823-4.617 1.823-2.416-.015-2.446-1.823-4.755-1.823-1.443 0-2.628 1.322-2.628 2.765s1.2 2.764 2.765 2.764c2.08 0 2.005-1.823 4.618-1.823 2.415 0 2.445 1.808 4.77 1.808 1.442 0 2.627-1.322 2.627-2.765 0-1.427-1.2-2.749-2.78-2.749Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
