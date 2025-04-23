// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiResharper : ComponentBase
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
		builder.AddAttribute(15, "d", "M24 0H0v24h24V0ZM3.006 19.476h9v1.5h-9v-1.5Zm9.824-9.392h-.98V8.432h1.264l.324-1.908h-1.136V4.872h1.416l.324-1.864h1.704l-.332 1.864h1.88l.324-1.864h1.7l-.304 1.864h.98v1.652h-1.28l-.324 1.908h1.136v1.652h-1.42l-.336 1.936h-1.7l.332-1.936h-1.868l-.32 1.936h-1.72l.336-1.936ZM3.014 3.008H7.15c1.144 0 2.021.304 2.632.912.529.553.808 1.3.772 2.064v.028a2.802 2.802 0 0 1-.536 1.784 3.065 3.065 0 0 1-1.404.992l2.204 3.224h-2.32L6.63 9.24H5.014v2.772h-2V3.008Zm13.672 5.424.328-1.908h-1.876l-.32 1.908h1.868ZM7.014 7.408c.415.014.821-.129 1.136-.4a1.2 1.2 0 0 0 .4-.928v-.028a1.156 1.156 0 0 0-.4-.968 1.836 1.836 0 0 0-1.148-.32H5.014v2.592l2 .052Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
