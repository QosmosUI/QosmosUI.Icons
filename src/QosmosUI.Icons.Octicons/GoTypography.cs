// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Octicons;

public class GoTypography : ComponentBase
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
		builder.AddAttribute(14, "d", "M10.414 15H3.586l-1.631 4.505a.75.75 0 1 1-1.41-.51l5.08-14.03a1.463 1.463 0 0 1 2.75 0l5.08 14.03a.75.75 0 1 1-1.411.51Zm4.532-5.098c.913-1.683 2.703-2.205 4.284-2.205 1.047 0 2.084.312 2.878.885.801.577 1.392 1.455 1.392 2.548v8.12a.75.75 0 0 1-1.5 0v-.06l-.044.025c-.893.52-2.096.785-3.451.785-1.051 0-2.048-.315-2.795-.948-.76-.643-1.217-1.578-1.217-2.702 0-.919.349-1.861 1.168-2.563.81-.694 2-1.087 3.569-1.087H22v-1.57c0-.503-.263-.967-.769-1.332-.513-.37-1.235-.6-2.001-.6-1.319 0-2.429.43-2.966 1.42a.75.75 0 0 1-1.318-.716ZM9.87 13.5 7 5.572 4.13 13.5Zm12.13.7h-2.77c-1.331 0-2.134.333-2.593.726a1.822 1.822 0 0 0-.644 1.424c0 .689.267 1.203.686 1.557.43.365 1.065.593 1.826.593 1.183 0 2.102-.235 2.697-.581.582-.34.798-.74.798-1.134Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
