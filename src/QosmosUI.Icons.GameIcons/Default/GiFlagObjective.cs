// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiFlagObjective : ComponentBase
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
		builder.AddAttribute(14, "d", "M247 26v163.2c-15 .8-28.5 3.3-39.4 7.4-6.5 2.4-12.1 5.4-16.5 9.3-4.5 4-8.1 9.5-8.1 16.1 0 6.6 3.6 12.1 8.1 16.1 4.4 3.9 10 6.9 16.5 9.3 13 4.9 29.8 7.6 48.4 7.6 18.6 0 35.4-2.7 48.4-7.6 6.5-2.4 12.1-5.4 16.5-9.3 4.5-4 8.1-9.5 8.1-16.1 0-6.6-3.6-12.1-8.1-16.1-4.4-3.9-10-6.9-16.5-9.3-10.9-4.1-24.4-6.6-39.4-7.4V26zm38 .99v70.02L378.4 62zM247 207.3v29.4c-13.1-.7-24.8-3-33.1-6.2-5.1-1.9-8.9-4.1-10.9-5.9-2-1.8-2-2.5-2-2.6 0-.1 0-.8 2-2.6s5.8-4 10.9-5.9c8.3-3.2 20-5.5 33.1-6.2zm18 0c13.1.7 24.8 3 33.1 6.2 5.1 1.9 8.9 4.1 10.9 5.9 2 1.8 2 2.5 2 2.6 0 .1 0 .8-2 2.6s-5.8 4-10.9 5.9c-8.3 3.2-20 5.5-33.1 6.2zm-9 70.7L96 358l128-16-32 144h128l-32-144 128 16z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
