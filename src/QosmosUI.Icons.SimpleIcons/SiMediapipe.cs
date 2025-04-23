// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiMediapipe : ComponentBase
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
		builder.AddAttribute(15, "d", "M2.182 0C1 0 .037.94.002 2.114L0 2.182v6.545a2.182 2.182 0 0 0 4.364 0V2.182A2.182 2.182 0 0 0 2.182 0Zm6.545 0c-1.182 0-2.145.94-2.18 2.114l-.002.068v13.09a2.182 2.182 0 0 0 4.364 0V2.183A2.182 2.182 0 0 0 8.727 0Zm6.546 0a2.182 2.182 0 0 0-2.182 2.182 2.182 2.182 0 0 0 2.182 2.182 2.182 2.182 0 0 0 2.182-2.182A2.182 2.182 0 0 0 15.273 0Zm6.545 0c-1.182 0-2.145.94-2.18 2.114l-.002.068v19.636a2.182 2.182 0 0 0 4.364 0V2.182A2.182 2.182 0 0 0 21.818 0Zm-6.545 6.545c-1.183 0-2.145.94-2.181 2.114l-.001.068v13.091a2.182 2.182 0 0 0 4.364 0V8.728a2.182 2.182 0 0 0-2.182-2.183zM2.182 13.091c-1.182 0-2.145.94-2.18 2.114L0 15.273v6.545a2.182 2.182 0 0 0 4.364 0v-6.545a2.182 2.182 0 0 0-2.182-2.182zm6.545 6.545a2.182 2.182 0 0 0-2.182 2.182A2.182 2.182 0 0 0 8.727 24a2.182 2.182 0 0 0 2.182-2.182 2.182 2.182 0 0 0-2.182-2.182Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
