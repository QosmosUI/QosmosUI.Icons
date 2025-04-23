// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoMedical : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M272,464H240a32,32,0,0,1-32-32l.05-85.82a4,4,0,0,0-6-3.47l-74.34,43.06a31.48,31.48,0,0,1-43-11.52L68.21,345.61l-.06-.1a31.65,31.65,0,0,1,11.56-42.8l74.61-43.25a4,4,0,0,0,0-6.92L79.78,209.33a31.41,31.41,0,0,1-11.55-43l16.44-28.55a31.48,31.48,0,0,1,19.27-14.74,31.14,31.14,0,0,1,23.8,3.2l74.31,43a4,4,0,0,0,6-3.47L208,80a32,32,0,0,1,32-32h32a32,32,0,0,1,32,32L304,165.72a4,4,0,0,0,6,3.47l74.34-43.06a31.51,31.51,0,0,1,43,11.52l16.49,28.64.06.09a31.52,31.52,0,0,1-11.64,42.86l-74.53,43.2a4,4,0,0,0,0,6.92l74.53,43.2a31.42,31.42,0,0,1,11.56,43l-16.44,28.55a31.48,31.48,0,0,1-19.27,14.74,31.14,31.14,0,0,1-23.8-3.2l-74.31-43a4,4,0,0,0-6,3.46L304,432A32,32,0,0,1,272,464ZM178.44,266.52h0Zm0-21h0Zm155.1-.08Zm0,0h0Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
