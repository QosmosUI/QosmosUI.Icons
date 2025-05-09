// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class Gi3dHammer : ComponentBase
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
		builder.AddAttribute(14, "d", "M307.3 84.2l-88.8 59.7 156.6 94.9 88.1-60.1zM215 163l11.5 53.1 12.5 7.5 18.6-13.3c6.8-4.9 14.6-6.8 22.2-6.6.9 0 1.8.1 2.7.1zm259.3 29.9l-88.7 60.5 14.9 59.3 89.2-58.9zm-196.4 28.7c-3.6.1-6.9 1.2-9.9 3.3L23.55 400c-.81.6-1.69 2.1-1.08 6.1.61 4.1 3.09 9.4 6.96 13.6 3.86 4.2 8.84 7.2 14.63 7.9 5.79.7 12.8-.6 21.62-6.7L305.3 252.5v-.1c4.5-3.1 4.8-5 4.2-8.5-.6-3.5-3.6-8.7-8.4-13-4.8-4.2-11.3-7.6-17.3-8.8-1.5-.3-2.9-.5-4.3-.5h-1.6zm44 6.1c2.6 4 4.5 8.4 5.3 13.2 1.6 9.2-2.4 19.9-11.5 26.2v.1l-1.7 1.2 66.9 40-13.3-53.1z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
